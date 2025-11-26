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

                List<CompraParaMostrarDTO> listacompraMostrar = new List<CompraParaMostrarDTO>();

                foreach (var c in compras)
                {
                    var cliente = usuarios.FirstOrDefault(u => u.Id == c.IdCliente);
                    var vendedor = usuarios.FirstOrDefault(u => u.Id == c.IdVendedor);
                    var fiesta = fiestas.FirstOrDefault(f => f.IdFiesta == c.IdFiesta);
                    var lugar = lugares.FirstOrDefault(l => l.Id == fiesta?.IdLugar);
                    var evento = eventos.FirstOrDefault(e => e.Id == fiesta?.IdEvento);
                    listacompraMostrar.Add( new CompraParaMostrarDTO
                    {
                        Cliente = cliente?.Nombre ?? "Desconocido",
                        Vendedor = vendedor?.Nombre ?? "Desconocido",
                        Fiesta = evento?.Nombre ?? "Desconocido",
                        Lugar = lugar?.Nombre ?? "Desconocido",
                        CantidadCompra = c.CantidadCompra,
                        FechaHora = c.FechaHora,
                        Entrada = c.Entrada
                    });

                }
                
                ventasVendedoresDataGridView.AutoGenerateColumns = true;
                ventasVendedoresDataGridView.DataSource = listacompraMostrar;

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
    public class CompraParaMostrarDTO
    {
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public string Fiesta { get; set; }
        public string Lugar { get; set; }
        public int CantidadCompra { get; set; }
        public DateTime FechaHora { get; set; }
        public string Entrada { get; set; }
    }
}

