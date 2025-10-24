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
    public partial class LugarDetalle : Form
    {
        internal LugarDTO lugar = new LugarDTO();
        public LugarDetalle()
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
                this.Text = "Agregar Lugar";
                this.button1.Text = "Agregar";
            }
            else if (mode == FormMode.Update)
            {
                this.Text = "Modificar Lugar";
                this.button1.Text = "Modificar";
            }
        }

        private void LugarDetalle_Load(object sender, EventArgs e)
        {
            if (mode == FormMode.Update)
            {
                this.nombreTextBox.Text = lugar.Nombre;
                this.direccionTextBox.Text = lugar.Direccion;
                this.ciudadTextBox.Text = lugar.Ciudad;
            }
            else
            {
                lugar = new LugarDTO();
            }
        }

        private bool ValidateLugar()
        {
            bool isValid = true;

            lugarErrorProvider.SetError(nombreTextBox, string.Empty);
            lugarErrorProvider.SetError(direccionTextBox, string.Empty);
            lugarErrorProvider.SetError(ciudadTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                lugarErrorProvider.SetError(nombreTextBox, "El nombre es requerido");
            }

            if (this.direccionTextBox.Text == string.Empty)
            {
                isValid = false;
                lugarErrorProvider.SetError(direccionTextBox, "La dirección es requerida");
            }

            if (this.ciudadTextBox.Text == string.Empty)
            {
                isValid = false;
                lugarErrorProvider.SetError(ciudadTextBox, "La ciudad es requerida");
            }

            return isValid;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateLugar())
            {
                try
                {
                    lugar.Nombre = this.nombreTextBox.Text;
                    lugar.Direccion = this.direccionTextBox.Text;
                    lugar.Ciudad = this.ciudadTextBox.Text;

                    if (mode == FormMode.Update)
                    {
                        await LugarApiClient.UpdateAsync(this.lugar);
                        MessageBox.Show("Lugar actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (mode == FormMode.Add)
                    {
                        await LugarApiClient.AddAsync(this.lugar);
                        MessageBox.Show("Lugar agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar lugar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
