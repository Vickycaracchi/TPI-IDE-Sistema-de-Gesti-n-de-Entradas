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
            this.Resize += VentasVendedores_Resize;
        }

        private void VentasVendedores_Load(object sender, EventArgs e)
        {
            this.VentasVendedores_Resize(sender, e);
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
                    listacompraMostrar.Add(new CompraParaMostrarDTO
                    {
                        Cliente = cliente?.Nombre ?? "Desconocido",
                        Vendedor = vendedor?.Nombre ?? "Desconocido",
                        Fiesta = evento?.Nombre ?? "Desconocido",
                        Lugar = lugar?.Nombre ?? "Desconocido",
                        CantidadCompra = c.CantidadCompra,
                        FechaHora = c.FechaHora,
                        Entrada = c.Entrada,
                        Lote = c.Lote
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

        private void ventasVendedoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void VentasVendedores_Resize(object sender, EventArgs e)
        {


            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;


        }
    }
}

