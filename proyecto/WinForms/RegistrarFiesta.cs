using API.Clients;
using DTOs;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class RegistrarFiesta : Form
    {
        public FormMode Mode { get; set; }
        public FiestaDTO Fiesta { get; set; }

        public RegistrarFiesta()
        {
            InitializeComponent();
        }

        private async void RegistrarFiesta_Load(object sender, EventArgs e)
        {
            await GetAllAndLoad();
        }

        private async Task GetAllAndLoad()
        {
            try
            {
                this.LugaresDataGridView.DataSource = null;
                this.LugaresDataGridView.DataSource = await LugarApiClient.GetAllAsync();

                this.EventosDataGridView.DataSource = null;
                this.EventosDataGridView.DataSource = await EventoApiClient.GetAllAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de lugares o eventos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void enviarRegFiesta_click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFiesta())
                    return;

                var idLugar = Convert.ToInt32(LugaresDataGridView.SelectedRows[0].Cells[0].Value);
                var idEvento = Convert.ToInt32(EventosDataGridView.SelectedRows[0].Cells[0].Value);

                FiestaDTO fiestaDTO = new()
                {
                    IdLugar = idLugar,
                    IdEvento = idEvento,
                    FechaFiesta = fechaPicker.Value
                };

                if (this.Mode == FormMode.Update)
                {
                    fiestaDTO.IdFiesta = this.Fiesta.IdFiesta;
                    await FiestaApiClient.UpdateAsync(fiestaDTO);
                    MessageBox.Show("Fiesta actualizada correctamente.");
                }
                else
                {
                    await FiestaApiClient.AddAsync(fiestaDTO);
                    MessageBox.Show("Fiesta registrada correctamente.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al enviar: {ex.Message}",
                    "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarFiesta()
        {
            // Validar selección de lugar
            if (LugaresDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un lugar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar selección de evento
            if (EventosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un evento.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar fecha (no puede ser anterior a hoy)
            if (fechaPicker.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de la fiesta no puede ser anterior a hoy.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}