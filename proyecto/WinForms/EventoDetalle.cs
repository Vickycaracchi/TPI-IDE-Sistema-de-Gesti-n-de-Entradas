using API.Clients;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms
{
    public partial class EventoDetalle : Form
    {
        private EventoDTO evento;
        public EventoDTO Evento
        {
            get { return evento; }
            set
            {
                evento = value;
                this.SetEvento();
            }
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
        public EventoDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }
        private void SetEvento()
        {
            this.nombreTextBox.Text = this.Evento.Nombre;
            this.descTextBox.Text = this.Evento.Desc;
        }
        private bool ValidateEvento()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }
            return isValid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EventoDetalle_Load(object sender, EventArgs e)
        {

        }

        private async void enviarFormularioEvento(object sender, EventArgs e)
        {
            if (this.ValidateEvento())
            {
                try
                {
                    this.Evento.Nombre = nombreTextBox.Text;
                    this.Evento.Desc = descTextBox.Text;

                    if (this.Mode == FormMode.Update)
                    {
                        await EventoApiClient.UpdateAsync(this.Evento);
                    }
                    else
                    {
                        await EventoApiClient.AddAsync(this.Evento);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}