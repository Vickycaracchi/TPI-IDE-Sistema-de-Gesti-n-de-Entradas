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
    public partial class ProductosLista : Form
    {
        public ProductosLista()
        {
            InitializeComponent();
            this.Resize += ProductosLista_Resize;
        }
        private void ProductosLista_Load(object sender, EventArgs e)
        {
            this.ProductosLista_Resize(sender, e);
            this.GetAllAndLoad();
        }

        private void agregarButtonProducto_Click(object sender, EventArgs e)
        {
            ProductoDetalle productoDetalle = new ProductoDetalle();

            ProductoDTO productoNuevo = new ProductoDTO();

            productoDetalle.Mode = FormMode.Add;
            productoDetalle.Producto = productoNuevo;

            productoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButtonProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un producto para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ProductoDetalle productoDetalle = new ProductoDetalle();

                ProductoDTO producto = await ProductoApiClient.GetAsync(selected.Id);

                productoDetalle.Mode = FormMode.Update;
                productoDetalle.Producto = producto;

                productoDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar producto para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButtonEvento_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el producto con Id {selected.Id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await ProductoApiClient.DeleteAsync(selected.Id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void GetAllAndLoad()
        {
            try
            {
                this.productosDataGridView.DataSource = null;
                this.productosDataGridView.DataSource = await ProductoApiClient.GetAllAsync();

                if (this.productosDataGridView.Rows.Count > 0)
                {
                    this.productosDataGridView.Rows[0].Selected = true;
                    this.eliminarButtonProducto.Enabled = true;
                    this.modificarButtonProducto.Enabled = true;
                }
                else
                {
                    this.eliminarButtonProducto.Enabled = false;
                    this.modificarButtonProducto.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButtonProducto.Enabled = false;
                this.modificarButtonProducto.Enabled = false;
            }
        }
        private ProductoDTO SelectedItem()
        {
            if (productosDataGridView.SelectedRows.Count > 0)
            {
                return (ProductoDTO)productosDataGridView.SelectedRows[0].DataBoundItem;
            }
            return null;
        }
        private void productosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ProductosLista_Resize(object sender, EventArgs e)
        {


            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;


        }
    }
}
