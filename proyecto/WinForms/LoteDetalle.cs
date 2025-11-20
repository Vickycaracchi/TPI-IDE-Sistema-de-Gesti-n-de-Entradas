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
    public partial class LoteDetalle : Form
    {
        internal LoteDTO lote = new LoteDTO();
        private List<LugarDTO> lugares;
        private List<EventoDTO> eventos;
        public LoteDetalle()
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
            if (mode == FormMode.Add)
            {
                this.Text = "Agregar Lote";
                this.button1.Text = "Agregar";
            }
            else if (mode == FormMode.Update)
            {
                this.Text = "Modificar Lote";
                this.button1.Text = "Modificar";
            }
        }

        private void listaFiestas_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private async void GetAllAndLoad()
        {
            try
            {
                lugares = (await LugarApiClient.GetAllAsync()).ToList();
                eventos = (await EventoApiClient.GetAllAsync()).ToList();

                var fiestas = await FiestaApiClient.GetAllAsync();

                var listaParaMostrar = fiestas.Select(f => new
                {
                    f.IdFiesta,
                    f.FechaFiesta,
                    NombreLugar = lugares.FirstOrDefault(l => l.Id == f.IdLugar)?.Nombre ?? "Desconocido",
                    NombreEvento = eventos.FirstOrDefault(e => e.Id == f.IdEvento)?.Nombre ?? "Desconocido"
                }).ToList();

                listaFiestas.AutoGenerateColumns = true;
                listaFiestas.DataSource = listaParaMostrar;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de fiestas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoteDetalle_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();

            if (mode == FormMode.Update)
            {
                nombreTextBox.Text = lote.Nombre;
                precioTextBox.Text = lote.Precio.ToString();
                fechaDesdeDateTimePicker.Value = lote.FechaDesde;
                fechaHastaDateTimePicker.Value = lote.FechaHasta;
            }
            else
            {
                lote = new LoteDTO();
            }
        }

        private bool ValidateLote()
        {
            bool isValid = true;

            loteErrorProvider.SetError(nombreTextBox, string.Empty);
            loteErrorProvider.SetError(precioTextBox, string.Empty);
            loteErrorProvider.SetError(fechaDesdeDateTimePicker, string.Empty);
            loteErrorProvider.SetError(fechaHastaDateTimePicker, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                loteErrorProvider.SetError(nombreTextBox, "El nombre es requerido");
            }

            if (this.precioTextBox.Text == string.Empty)
            {
                isValid = false;
                loteErrorProvider.SetError(precioTextBox, "El precio es requerido");
            }
            else if (!decimal.TryParse(this.precioTextBox.Text, out decimal precio) || precio < 0)
            {
                isValid = false;
                loteErrorProvider.SetError(precioTextBox, "El precio debe ser un número válido mayor o igual a 0");
            }

            if (this.fechaHastaDateTimePicker.Value <= this.fechaDesdeDateTimePicker.Value)
            {
                isValid = false;
                loteErrorProvider.SetError(fechaHastaDateTimePicker, "La fecha hasta debe ser posterior a la fecha desde");
            }

            return isValid;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateLote())
            {
                try
                {
                    if (listaFiestas.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar una fiesta antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var fiesta = listaFiestas.SelectedRows[0].Cells[0].Value;
                    var idFiestaStr = Convert.ToString(fiesta);
                    var idFiesta = int.Parse(idFiestaStr);
                    lote.Nombre = this.nombreTextBox.Text;
                    lote.Precio = int.Parse(this.precioTextBox.Text);
                    lote.FechaDesde = this.fechaDesdeDateTimePicker.Value;
                    lote.FechaHasta = this.fechaHastaDateTimePicker.Value;

                    if (mode == FormMode.Update)
                    {
                        await LoteApiClient.UpdateAsync(this.lote);
                        MessageBox.Show("Lote actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (mode == FormMode.Add)
                    {
                        await LoteApiClient.AddAsync(this.lote);
                        MessageBox.Show("Lote agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar lote: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
