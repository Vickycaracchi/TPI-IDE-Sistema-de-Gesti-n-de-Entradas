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
    public partial class ClientesLista : Form
    {
        public ClientesLista()
        {
            InitializeComponent();
        }
        private void ClientesLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private void agregarButton_Click(object sender, EventArgs e)
        {
            ClienteDetalle clienteDetalle = new ClienteDetalle();

            ClienteDTO clienteNuevo = new ClienteDTO();

            clienteDetalle.Mode = FormMode.Add;
            clienteDetalle.Cliente = clienteNuevo;

            clienteDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un cliente para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ClienteDetalle clienteDetalle = new ClienteDetalle();

                ClienteDTO cliente = await ClienteApiClient.GetAsync(selected.Id);

                clienteDetalle.Mode = FormMode.Update;
                clienteDetalle.Cliente = cliente;

                clienteDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cliente para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un cliente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el cliente con Id {selected.Id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await ClienteApiClient.DeleteAsync(selected.Id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.clientesDataGridView.DataSource = null;
                this.clientesDataGridView.DataSource = await ClienteApiClient.GetAllAsync();

                if (this.clientesDataGridView.Rows.Count > 0)
                {
                    this.clientesDataGridView.Rows[0].Selected = true;
                    this.eliminarButtonCliente.Enabled = true;
                    this.modificarButtonCliente.Enabled = true;
                }
                else
                {
                    this.eliminarButtonCliente.Enabled = false;
                    this.modificarButtonCliente.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButtonCliente.Enabled = false;
                this.modificarButtonCliente.Enabled = false;
            }
        }
        private ClienteDTO SelectedItem()
        {
            if (clientesDataGridView.SelectedRows.Count > 0)
            {
                return (ClienteDTO)clientesDataGridView.SelectedRows[0].DataBoundItem;
            }
            return null;
        }
        private void clientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
