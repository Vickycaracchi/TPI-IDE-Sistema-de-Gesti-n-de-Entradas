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
    public partial class FiestasLista : Form
    {

        public FiestasLista()
        {
            InitializeComponent();
        }

        private void FiestasLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButtonFiesta_Click(object sender, EventArgs e)
        {
            RegistrarFiesta registrarFiesta = new RegistrarFiesta();

            FiestaDTO fiestaNueva = new FiestaDTO();

            registrarFiesta.Mode = FormMode.Add;
            registrarFiesta.Fiesta = fiestaNueva;

            registrarFiesta.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButtonFiesta_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione una fiesta para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                RegistrarFiesta registrarFiesta = new RegistrarFiesta();


                FiestaDTO fiesta = await FiestaApiClient.GetAsync(selected.IdFiesta);

                registrarFiesta.Mode = FormMode.Update;
                registrarFiesta.Fiesta = fiesta;

                registrarFiesta.ShowDialog();

                this.GetAllAndLoad();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar fiesta para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButtonFiesta_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un fiesta para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el fiesta con IdFiesta {selected.IdFiesta}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await FiestaApiClient.DeleteAsync(selected.IdFiesta);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar fiesta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void GetAllAndLoad()
        {
            try
            {
                this.FiestasDataGridView.DataSource = null;
                this.FiestasDataGridView.DataSource = await FiestaApiClient.GetAllAsync();

                if (this.FiestasDataGridView.Rows.Count > 0)
                {
                    this.FiestasDataGridView.Rows[0].Selected = true;
                    this.eliminarButtonFiesta.Enabled = true;
                    this.modificarButtonFiesta.Enabled = true;
                }
                else
                {
                    this.eliminarButtonFiesta.Enabled = false;
                    this.modificarButtonFiesta.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de fiestas: {ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButtonFiesta.Enabled = false;
                this.modificarButtonFiesta.Enabled = false;
            }
        }
        private FiestaDTO SelectedItem()
        {
            if (FiestasDataGridView.SelectedRows.Count > 0)
            {
                return (FiestaDTO)FiestasDataGridView.SelectedRows[0].DataBoundItem;
            }
            return null;
        }


    }
}
