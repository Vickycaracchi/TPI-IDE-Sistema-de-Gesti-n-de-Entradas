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
    public partial class LugaresLista : Form
    {
        public LugaresLista()
        {
            InitializeComponent();
            this.Resize += LugaresLista_Resize;
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
        private void LugaresLista_Load(object sender, EventArgs e)
        {
            this.LugaresLista_Resize(sender, e);
            this.GetAllAndLoad();
        }
        private void agregarButton_Click(object sender, EventArgs e)
        {
            LugarDetalle registrarLugar = new LugarDetalle();

            registrarLugar.Mode = FormMode.Add;

            registrarLugar.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un lugar para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                LugarDetalle lugarDetalle = new LugarDetalle();

                LugarDTO lugar = await LugarApiClient.GetAsync(selected.Id);

                lugarDetalle.Mode = FormMode.Update;
                lugarDetalle.lugar = lugar;

                lugarDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar lugar para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un lugar para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el lugar con Id {selected.Id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await LugarApiClient.DeleteAsync(selected.Id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar lugar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.lugaresDataGridView.DataSource = null;
                this.lugaresDataGridView.DataSource = await LugarApiClient.GetAllAsync();

                if (this.lugaresDataGridView.Rows.Count > 0)
                {
                    this.lugaresDataGridView.Rows[0].Selected = true;
                    this.eliminarButtonLugar.Enabled = true;
                    this.modificarButtonLugar.Enabled = true;
                }
                else
                {
                    this.eliminarButtonLugar.Enabled = false;
                    this.modificarButtonLugar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de lugares: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButtonLugar.Enabled = false;
                this.modificarButtonLugar.Enabled = false;
            }
        }
        private LugarDTO SelectedItem()
        {
            if (lugaresDataGridView.SelectedRows.Count > 0)
            {
                return (LugarDTO)lugaresDataGridView.SelectedRows[0].DataBoundItem;
            }
            return null;
        }
        private void lugaresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LugaresLista_Resize(object sender, EventArgs e)
        {


            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;


        }
    }
}
