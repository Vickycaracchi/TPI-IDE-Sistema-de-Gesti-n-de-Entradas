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
    public partial class ProductoDetalle : Form
    {
        private ProductoDTO producto;
        private FormMode mode;

        public ProductoDTO Producto
        {
            get { return producto; }
            set
            {
                producto = value;
                this.SetProducto();
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
        public ProductoDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }
        private void SetProducto()
        {
            this.nombreTextBox.Text = this.Producto.Nombre;
            this.descripcionTextBox.Text = this.Producto.Descripcion;
            precioTextBox.Text = this.Producto.Precio.ToString("0.00");
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;
        }

        private bool ValidateProducto()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(descripcionTextBox, string.Empty);
            errorProvider.SetError(precioTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }

            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "La descripcion es Requerida");
            }

            if (!decimal.TryParse(precioTextBox.Text.Trim(), out decimal precio))
            {
                isValid = false;
                errorProvider.SetError(precioTextBox, "Precio inválido");
            }
            else
            {
                this.Producto.Precio = precio; 
            }

            return isValid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductoDetalle_Load(object sender, EventArgs e)
        {

        }

        private async void enviarFormularioProducto(object sender, EventArgs e)
        {
            if (this.ValidateProducto())
            {
                try
                {
                    this.Producto.Nombre = nombreTextBox.Text;
                    this.Producto.Descripcion = descripcionTextBox.Text;



                    if (this.Mode == FormMode.Update)
                    {
                        await ProductoApiClient.UpdateAsync(this.Producto);
                    }
                    else
                    {
                        await ProductoApiClient.AddAsync(this.Producto);
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