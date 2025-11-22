using API.Clients;
using DTOs;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinForms
{
    public partial class AsignarVendedores : Form
    {
        public AsignarVendedores()
        {
            InitializeComponent();
        }

        private async void AsignarVendedores_Load(object sender, EventArgs e)
        {
            try
            {
                var listaJefes = await UsuarioApiClient.GetByTipoAsync("Jefe");
                jefesComboBox.DataSource = listaJefes.ToList();
                jefesComboBox.DisplayMember = "Nombre";
                jefesComboBox.ValueMember = "Id";

                var listaVendedores = await UsuarioApiClient.GetByTipoAsync("Vendedor");
                vendedoresComboBox.DataSource = listaVendedores.ToList();
                vendedoresComboBox.DisplayMember = "Nombre";
                vendedoresComboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void asignarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (jefesComboBox.SelectedValue == null || vendedoresComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Por favor seleccione un jefe y un vendedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int idJefe = (int)jefesComboBox.SelectedValue;
                int idVendedor = (int)vendedoresComboBox.SelectedValue;

                var result = MessageBox.Show(
                    $"¿Está seguro que desea asignar el vendedor {vendedoresComboBox.Text} al jefe {jefesComboBox.Text}?",
                    "Confirmar asignación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await UsuarioApiClient.AsignarVendedorAJefeAsync(idVendedor, idJefe);
                    MessageBox.Show("Vendedor asignado exitosamente al jefe.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al asignar vendedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

