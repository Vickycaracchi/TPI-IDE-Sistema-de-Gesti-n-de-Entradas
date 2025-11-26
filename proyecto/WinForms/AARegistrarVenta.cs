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
    public partial class RegistrarVenta : Form
    {
        public UsuarioDTO usuarioIngresado { get; set; }
        public RegistrarVenta()
        {
            InitializeComponent();
        }

    }
}
