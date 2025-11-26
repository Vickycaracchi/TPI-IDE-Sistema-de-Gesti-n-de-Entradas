using API.Clients;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MisVentas : Form
    {
        public UsuarioDTO usuarioIngresado { get; set; }
        public MisVentas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MisVentas_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            try
            {

                var compras = await CompraApiClient.GetAllVendedorAsync(usuarioIngresado.Id);

                var usuarios = await UsuarioApiClient.GetAllAsync();
                var fiestas = (await FiestaApiClient.GetAllAsync()).ToList();
                var lugares = await LugarApiClient.GetAllAsync();
                var eventos = await EventoApiClient.GetAllAsync();

                // Cache de lotes por fiesta
                var lotesPorFiesta = new Dictionary<int, LoteDTO?>();

                // Lista intermedia con IdCliente, Cliente, Fiesta, Lote y cantidad
                var comprasConDatos = new List<(int IdCliente, string Cliente, string Fiesta, string Lote, string Lugar, string Vendedor, int CantidadEntradas, DateTime FechaHora, string Entrada)>();

                foreach (var c in compras)
                {
                    var cliente = usuarios.FirstOrDefault(u => u.Id == c.IdCliente);
                    var vendedor = usuarios.FirstOrDefault(u => u.Id == c.IdVendedor);
                    var fiesta = fiestas.FirstOrDefault(f => f.IdFiesta == c.IdFiesta);

                    var lugar = lugares.FirstOrDefault(l => l.Id == fiesta?.IdLugar);
                    var evento = eventos.FirstOrDefault(e => e.Id == fiesta?.IdEvento);

                    // Obtener lote actual de la fiesta (si existe)
                    LoteDTO? lote = null;
                    if (fiesta != null)
                    {
                        if (!lotesPorFiesta.TryGetValue(fiesta.IdFiesta, out lote))
                        {
                            try
                            {
                                lote = await LoteApiClient.GetLoteActualAsync(fiesta.IdFiesta);
                            }
                            catch
                            {
                                lote = null;
                            }
                            lotesPorFiesta[fiesta.IdFiesta] = lote;
                        }
                    }

                    var nombreCliente = cliente?.Nombre ?? "Desconocido";
                    var nombreFiesta = evento?.Nombre ?? "Desconocido";
                    var nombreLugar = lugar?.Nombre ?? "Desconocido";
                    var nombreVendedor = vendedor?.Nombre ?? "Desconocido";
                    var nombreLote = lote?.Nombre ?? "Sin lote actual";

                    comprasConDatos.Add((c.IdCliente, nombreCliente, nombreFiesta, nombreLote, nombreLugar, nombreVendedor, c.CantidadCompra, c.FechaHora, c.Entrada));
                }

                // Agrupar por Fiesta, Lote y Cliente, sumando la cantidad
                var listaParaMostrar = comprasConDatos
                    .GroupBy(c => new { c.IdCliente, c.Fiesta, c.Lote, c.Lugar, c.Vendedor })
                    .Select(g => new
                    {
                        // el nombre se toma del primer elemento del grupo para mostrarlo
                        Cliente = g.First().Cliente,
                        Vendedor = g.Key.Vendedor,
                        Fiesta = g.Key.Fiesta,
                        Lugar = g.Key.Lugar,
                        Lote = g.Key.Lote,
                        CantidadEntradas = g.Sum(x => x.CantidadEntradas),
                        // la fecha y las entradas del primer registro del grupo para mostrar
                        FechaHora = g.First().FechaHora,
                        Entrada = g.First().Entrada
                    })
                    .OrderBy(x => x.Fiesta)
                    .ThenBy(x => x.Lote)
                    .ThenBy(x => x.Cliente)
                    .ToList();


                misVentasDataGridView.AutoGenerateColumns = true;
                misVentasDataGridView.DataSource = listaParaMostrar;

                if (misVentasDataGridView.Rows.Count > 0)
                {
                    misVentasDataGridView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
