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
    public partial class ListarCompras : Form
    {
        public UsuarioDTO usuarioIngresado { get; set; }
        public ListarCompras()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarCompras_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            try
            {

                var compras = await CompraApiClient.GetAllCliAsync(usuarioIngresado.Id);


                var usuarios = await UsuarioApiClient.GetAllAsync();
                var fiestas = await FiestaApiClient.GetAllAsync();
                var lugares = await LugarApiClient.GetAllAsync();
                var eventos = await EventoApiClient.GetAllAsync();


                var listaParaMostrar = compras.Select(c =>
                {
                    var cliente = usuarios.FirstOrDefault(u => u.Id == c.IdCliente);
                    var vendedor = usuarios.FirstOrDefault(u => u.Id == c.IdVendedor);
                    var fiesta = fiestas.FirstOrDefault(f => f.IdFiesta == c.IdFiesta);

                    var lugar = lugares.FirstOrDefault(l => l.Id == fiesta?.IdLugar);
                    var evento = eventos.FirstOrDefault(e => e.Id == fiesta?.IdEvento);

                    return new
                    {

                        Cliente = cliente?.Nombre ?? "Desconocido",
                        Vendedor = vendedor?.Nombre ?? "Desconocido",
                        Fiesta = evento?.Nombre ?? "Desconocido",
                        Lugar = lugar?.Nombre ?? "Desconocido",
                        c.CantidadCompra,
                        c.FechaHora,
                        c.Entrada,
                    };
                }).ToList();


                ListarComprasDataGridView.AutoGenerateColumns = true;
                ListarComprasDataGridView.DataSource = listaParaMostrar;

                if (ListarComprasDataGridView.Rows.Count > 0)
                {
                    ListarComprasDataGridView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las compras: {ex.Message}\n\nStackTrace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
