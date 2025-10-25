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
    public partial class LotesLista : Form
    {
        public LotesLista()
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
        private void LotesLista_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            this.GetAllAndLoad();
        }

        private void ConfigurarDataGridView()
        {
            lotesDataGridView.AutoGenerateColumns = false;
            lotesDataGridView.Columns.Clear();

            // Deshabilitar redimensionamiento de columnas por el usuario
            lotesDataGridView.AllowUserToResizeColumns = false;
            // Hacer que las columnas llenen el ancho disponible
            lotesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lotesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "Id",
                FillWeight = 5 // Ancho más pequeño para ID
            });

            lotesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Name = "Nombre",
                FillWeight = 30 // Ancho más grande para Nombre
            });

            lotesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                Name = "Precio",
                FillWeight = 15 // Ancho medio para Precio
            });

            lotesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaDesde",
                HeaderText = "Fecha Desde",
                Name = "FechaDesde",
                FillWeight = 20 // Ancho medio-grande para FechaDesde
            });

            lotesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaHasta",
                HeaderText = "Fecha Hasta",
                Name = "FechaHasta",
                FillWeight = 20 // Ancho medio-grande para FechaHasta
            });

            lotesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CantidadLote",
                HeaderText = "Cantidad Lote",
                Name = "CantidadLote",
                FillWeight = 10 // Ancho más pequeño para Cantidad
            });
        }
        private void agregarButton_Click(object sender, EventArgs e)
        {
            LoteDetalle registrarLote = new LoteDetalle();

            registrarLote.Mode = FormMode.Add;

            registrarLote.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un lote para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                LoteDetalle loteDetalle = new LoteDetalle();

                LoteDTO lote = await LoteApiClient.GetAsync(selected.Id);

                loteDetalle.Mode = FormMode.Update;
                loteDetalle.lote = lote;

                loteDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar lote para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un lote para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el lote con Id {selected.Id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await LoteApiClient.DeleteAsync(selected.Id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar lote: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.lotesDataGridView.DataSource = null;
                this.lotesDataGridView.DataSource = await LoteApiClient.GetAllAsync();

                if (this.lotesDataGridView.Rows.Count > 0)
                {
                    this.lotesDataGridView.Rows[0].Selected = true;
                    this.eliminarButtonLote.Enabled = true;
                    this.modificarButtonLote.Enabled = true;
                }
                else
                {
                    this.eliminarButtonLote.Enabled = false;
                    this.modificarButtonLote.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de lotes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButtonLote.Enabled = false;
                this.modificarButtonLote.Enabled = false;
            }
        }
        private LoteDTO SelectedItem()
        {
            if (lotesDataGridView.SelectedRows.Count > 0)
            {
                return (LoteDTO)lotesDataGridView.SelectedRows[0].DataBoundItem;
            }
            return null;
        }
        private void lotesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
