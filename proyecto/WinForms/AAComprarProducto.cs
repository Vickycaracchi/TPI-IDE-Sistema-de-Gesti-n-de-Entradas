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
    public partial class ComprarProducto : Form
    {
        public UsuarioDTO usuarioIngresado { get; set; }
        public List<ProdcutoConCantidadDTO> productosSeleccionados { get; set; } = new List<ProdcutoConCantidadDTO>();
        public ComprarProducto()
        {
            InitializeComponent();
            this.Resize += ComprarProductos_Resize;
        }

        private void ComprarProducto_Load(object sender, EventArgs e)
        {
            this.ComprarProductos_Resize(sender, e);
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
                    var vendedor = usuarios.FirstOrDefault(u => u.Id == c.IdVendedor);
                    var fiesta = fiestas.FirstOrDefault(f => f.IdFiesta == c.IdFiesta);

                    var lugar = lugares.FirstOrDefault(l => l.Id == fiesta?.IdLugar);
                    var evento = eventos.FirstOrDefault(e => e.Id == fiesta?.IdEvento);

                    return new
                    {
                        Vendedor = vendedor?.Nombre ?? "Desconocido",
                        Evento = evento?.Nombre ?? "Desconocido",
                        Lugar = lugar?.Nombre ?? "Desconocido",
                        c.FechaHora,
                        CompraKey = new CompraKeyDTO
                        {
                            IdCliente = usuarioIngresado.Id,
                            IdFiesta = c.IdFiesta,
                            FechaHora = c.FechaHora
                        }
                    };
                }).ToList();


                CompraProdListaComprasDataGridView.AutoGenerateColumns = true;
                CompraProdListaComprasDataGridView.DataSource = listaParaMostrar;

                if (CompraProdListaComprasDataGridView.Rows.Count > 0)
                {
                    CompraProdListaComprasDataGridView.Columns["CompraKey"].Visible = false;
                    CompraProdListaComprasDataGridView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las compras: {ex.Message}\n\nStackTrace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                var productos = await ProductoApiClient.GetAllAsync();
                var prodsParaMostrar = productos.Select(p => new ProdcutoConCantidadDTO
                {
                    Id = p.Id,
                    Descripcion = p.Descripcion,
                    Precio = p.Precio,
                    Cantidad = 0
                }).ToList();
                CompraProdsproductosDataGridView.AutoGenerateColumns = true;
                CompraProdsproductosDataGridView.DataSource = prodsParaMostrar;

                if (CompraProdListaComprasDataGridView.Rows.Count > 0)
                {
                    CompraProdListaComprasDataGridView.Rows[0].Selected = true;
                }
                this.CompraProdsproductosDataGridView.ReadOnly = false;
                this.CompraProdsproductosDataGridView.Columns["Cantidad"].ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidarCompra())
            {
                ProductoConCompraDTO compra = new ProductoConCompraDTO();
                compra.Compra = new CompraKeyDTO();
                compra.Producto = productosSeleccionados;

                DataGridViewRow selectedRow = CompraProdListaComprasDataGridView.SelectedRows[0];
                dynamic compraSeleccionada = selectedRow.DataBoundItem;
                compra.Compra = compraSeleccionada.CompraKey;

                await ProductoApiClient.AddCompra(compra);

                MessageBox.Show("Compra realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ValidarCompra()
        {
            if (CompraProdListaComprasDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una compra de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            productosSeleccionados.Clear();
            foreach (DataGridViewRow row in CompraProdsproductosDataGridView.Rows)
            {
                if (row.Cells["Cantidad"].Value != null && int.TryParse(row.Cells["Cantidad"].Value.ToString(), out int cantidad) && cantidad > 0)
                {
                    var producto = new ProdcutoConCantidadDTO
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        Descripcion = row.Cells["Descripcion"].Value.ToString(),
                        Precio = Convert.ToInt32(row.Cells["Precio"].Value),
                        Cantidad = cantidad
                    };
                    productosSeleccionados.Add(producto);
                }
            }
            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un producto con cantidad mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ComprarProductos_Resize(object sender, EventArgs e)
        {


            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;


        }
    }
}
