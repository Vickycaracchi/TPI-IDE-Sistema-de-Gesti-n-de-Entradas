using API.Clients;
using DTOs;
using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class VendedoresLista : Form
    {
        public VendedoresLista()
        {
            InitializeComponent();
        }

        private void VendedoresLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButtonVendedor_Click(object sender, EventArgs e)
        {
            RegistrarUsuario vendedorDetalle = new RegistrarUsuario();

            vendedorDetalle.Mode = FormMode.Add;

            vendedorDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButtonVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un vendedor para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Traigo el vendedor desde la API
                UsuarioDTO vendedor = await UsuarioApiClient.GetAsync(selected.Id);

                RegistrarUsuario vendedorDetalle = new RegistrarUsuario();

                // IMPORTANTE: primero asigno el vendedor, después el modo
                vendedorDetalle.usuario = vendedor;
                vendedorDetalle.Mode = FormMode.Update;

                vendedorDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar vendedor para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButtonVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un vendedor para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el vendedor con Id {selected.Id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await UsuarioApiClient.DeleteAsync(selected.Id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar vendedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.vendedoresDataGridView.DataSource = null;
                this.vendedoresDataGridView.DataSource = await UsuarioApiClient.GetByTipoAsync("Vendedor");

                if (this.vendedoresDataGridView.Rows.Count > 0)
                {
                    this.vendedoresDataGridView.Rows[0].Selected = true;
                    this.eliminarButtonVendedor.Enabled = true;
                    this.modificarButtonVendedor.Enabled = true;
                }
                else
                {
                    this.eliminarButtonVendedor.Enabled = false;
                    this.modificarButtonVendedor.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de vendedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButtonVendedor.Enabled = false;
                this.modificarButtonVendedor.Enabled = false;
            }
        }

        private UsuarioDTO SelectedItem()
        {
            if (vendedoresDataGridView.SelectedRows.Count > 0)
            {
                return (UsuarioDTO)vendedoresDataGridView.SelectedRows[0].DataBoundItem;
            }
            return null;
        }

        private void vendedoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}