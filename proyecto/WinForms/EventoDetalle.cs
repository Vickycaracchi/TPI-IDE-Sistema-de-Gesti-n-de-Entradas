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
using WindowsForms;

namespace WinForms
{
    public partial class EventoDetalle : Form
    {
        private EventoDTO evento;
        private FormMode mode;

        public EventoDTO Evento
        {
            get { return evento; }
            set
            {
                evento = value;
                this.SetEvento();
            }
        }
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
        public EventoDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }
        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateEvento())
            {
                try
                {
                    this.Evento.Nombre = NombreTextBox.Text;
                    this.Evento.Desc = DescTextBox.Text;
                    this.Evento.Fecha = DateTime.Parse(FechaTextBox.Text);
                    this.Evento.Lugar = LugarTextBox.Text;



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
        private void SetEvento()
        {

            this.NombreTextBox.Text = this.Evento.Nombre;
            this.DescTextBox.Text = this.Evento.Desc;
            this.FechaTextBox.Text = this.Evento.Fecha.ToString();
            this.LugarTextBox.Text = this.Evento.Lugar;
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;
        }

        private bool ValidateEvento()
        {
            bool isValid = true;

            errorProvider.SetError(NombreTextBox, string.Empty);
            errorProvider.SetError(LugarTextBox, string.Empty);

            if (this.NombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(NombreTextBox, "El Nombre es Requerido");
            }

            if (this.LugarTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(LugarTextBox, "El Lugar es Requerido");
            }



            return isValid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EventoDetalle_Load(object sender, EventArgs e)
        {

        }




    }
}