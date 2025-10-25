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

        private void LoteDetalle_Load(object sender, EventArgs e)
        {
            if (mode == FormMode.Update)
            {
                this.nombreTextBox.Text = lote.Nombre;
                this.precioTextBox.Text = lote.Precio.ToString();
                this.fechaDesdeDateTimePicker.Value = lote.FechaDesde;
                this.fechaHastaDateTimePicker.Value = lote.FechaHasta;
                this.cantidadLoteTextBox.Text = lote.CantidadLote.ToString();
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
            loteErrorProvider.SetError(cantidadLoteTextBox, string.Empty);

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

            if (this.cantidadLoteTextBox.Text == string.Empty)
            {
                isValid = false;
                loteErrorProvider.SetError(cantidadLoteTextBox, "La cantidad del lote es requerida");
            }
            else if (!int.TryParse(this.cantidadLoteTextBox.Text, out int cantidadLote) || cantidadLote < 0)
            {
                isValid = false;
                loteErrorProvider.SetError(cantidadLoteTextBox, "La cantidad del lote debe ser un número entero válido mayor o igual a 0");
            }

            return isValid;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateLote())
            {
                try
                {
                    lote.Nombre = this.nombreTextBox.Text;
                    lote.Precio = decimal.Parse(this.precioTextBox.Text);
                    lote.FechaDesde = this.fechaDesdeDateTimePicker.Value;
                    lote.FechaHasta = this.fechaHastaDateTimePicker.Value;
                    lote.CantidadLote = int.Parse(this.cantidadLoteTextBox.Text);

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
    }
}
