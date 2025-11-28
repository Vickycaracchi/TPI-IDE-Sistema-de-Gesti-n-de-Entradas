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
            this.Resize += AsignarVendedores_Resize;
        }

        private async void AsignarVendedores_Load(object sender, EventArgs e)
        {
            this.AsignarVendedores_Resize(sender, e);
            try
            {
                var listaJefes = await UsuarioApiClient.GetByTipoAsync("Jefe");
                jefesDataGridView.DataSource = listaJefes.Select(j => new
                {
                    j.Id,
                    j.Dni,
                    j.Nombre,
                    j.Apellido,
                    j.Email
                }).ToList();

                var listaVendedores = await UsuarioApiClient.GetByTipoAsync("Vendedor");
                vendedoresDataGridView.DataSource = listaVendedores.Select(v => new
                {
                    v.Id,
                    v.Dni,
                    v.Nombre,
                    v.Apellido,
                    v.Email
                }).ToList();

                if (jefesDataGridView.Rows.Count > 0)
                {
                    jefesDataGridView.Rows[0].Selected = true;
                }

                if (vendedoresDataGridView.Rows.Count > 0)
                {
                    vendedoresDataGridView.Rows[0].Selected = true;
                }
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
                if (jefesDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor seleccione un jefe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (vendedoresDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor seleccione un vendedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var idJefe = (int)jefesDataGridView.SelectedRows[0].Cells["Id"].Value;
                var idVendedor = (int)vendedoresDataGridView.SelectedRows[0].Cells["Id"].Value;

                var nombreJefe = jefesDataGridView.SelectedRows[0].Cells["Nombre"].Value?.ToString() ?? "Desconocido";
                var nombreVendedor = vendedoresDataGridView.SelectedRows[0].Cells["Nombre"].Value?.ToString() ?? "Desconocido";

                var result = MessageBox.Show(
                    $"¿Está seguro que desea asignar el vendedor {nombreVendedor} al jefe {nombreJefe}?",
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

        private void vendedoresLabel_Click(object sender, EventArgs e)
        {

        }
        private void AsignarVendedores_Resize(object sender, EventArgs e)
        {


            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;


        }
    }
}

