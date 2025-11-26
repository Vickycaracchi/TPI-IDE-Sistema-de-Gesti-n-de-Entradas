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
    public partial class VentasVendedores : Form
    {
        public UsuarioDTO usuarioIngresado { get; set; }
        public VentasVendedores()
        {
            InitializeComponent();
        }

        private void VentasVendedores_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            try
            {
                var compras = await CompraApiClient.GetAllByJefeAsync(usuarioIngresado.Id);
               
                var usuarios = await UsuarioApiClient.GetAllAsync();
                var fiestas = (await FiestaApiClient.GetAllAsync()).ToList();
                var lugares = await LugarApiClient.GetAllAsync();
                var eventos = await EventoApiClient.GetAllAsync();

                // Cache de lotes por fiesta
                var lotesPorFiesta = new Dictionary<int, LoteDTO?>();

                // Primero mapear las compras con los nombres y lote
                var comprasConNombres = new List<(string Vendedor, string Fiesta, string Lote, int CantidadEntradas)>();
                foreach (var c in compras)
                {
                    var vendedor = usuarios.FirstOrDefault(u => u.Id == c.IdVendedor);
                    var fiesta = fiestas.FirstOrDefault(f => f.IdFiesta == c.IdFiesta);
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

                    var nombreVendedor = vendedor?.Nombre ?? "Desconocido";
                    var nombreFiesta = evento?.Nombre ?? "Desconocido";
                    var nombreLote = lote?.Nombre ?? "Sin lote actual";

                    comprasConNombres.Add((nombreVendedor, nombreFiesta, nombreLote, c.CantidadCompra));
                }

                // Agrupar por Vendedor, Fiesta y Lote, sumando las cantidades
                var listaParaMostrar = comprasConNombres
                    .GroupBy(c => new { c.Vendedor, c.Fiesta, c.Lote })
                    .Select(g => new
                    {
                        Vendedor = g.Key.Vendedor,
                        Fiesta = g.Key.Fiesta,
                        Lote = g.Key.Lote,
                        CantidadEntradas = g.Sum(x => x.CantidadEntradas)
                    })
                    .OrderBy(x => x.Vendedor)
                    .ThenBy(x => x.Fiesta)
                    .ThenBy(x => x.Lote)
                    .ToList();

                ventasVendedoresDataGridView.AutoGenerateColumns = true;
                ventasVendedoresDataGridView.DataSource = listaParaMostrar;

                if (ventasVendedoresDataGridView.Rows.Count > 0)
                {
                    ventasVendedoresDataGridView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas de vendedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

