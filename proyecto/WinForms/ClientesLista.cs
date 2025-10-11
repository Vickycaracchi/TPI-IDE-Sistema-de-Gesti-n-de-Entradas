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
        public FormMode mode;
        public FormMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                SetFormMode(value);
            }
        }
        private void SetFormMode(FormMode value)
        {
            mode = value;
        }
        private void ClientesLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private void agregarButton_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrarCliente = new RegistrarUsuario();

            registrarCliente.Mode = FormMode.Add;

            registrarCliente.ShowDialog();

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

                RegistrarUsuario clienteDetalle = new RegistrarUsuario();

                UsuarioDTO usuario = await UsuarioApiClient.GetAsync(selected.Id);

                clienteDetalle.Mode = FormMode.Update;
                clienteDetalle.usuario = usuario;

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
                    await UsuarioApiClient.DeleteAsync(selected.Id);
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
                this.clientesDataGridView.DataSource = await UsuarioApiClient.GetByTipoAsync("Cliente");

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
        private UsuarioDTO SelectedItem()
        {
            if (clientesDataGridView.SelectedRows.Count > 0)
            {
                return (UsuarioDTO)clientesDataGridView.SelectedRows[0].DataBoundItem;
            }
            return null;
        }
        private void clientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
