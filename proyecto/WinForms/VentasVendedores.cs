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
    public partial class VentasVendedores : Form
    {
        public UsuarioDTO usuarioIngresado { get; set; }
        public VentasVendedores()
        {
            InitializeComponent();
        }

        private void VentasVendedores_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            try
            {
                var compras = await CompraApiClient.GetAllByJefeAsync(usuarioIngresado.Id);
               
                var usuarios = await UsuarioApiClient.GetAllAsync();
                var fiestas = await FiestaApiClient.GetAllAsync();
                var lugares = await LugarApiClient.GetAllAsync();
                var eventos = await EventoApiClient.GetAllAsync();

                // Primero mapear las compras con los nombres
                var comprasConNombres = compras.Select(c =>
                {
                    var vendedor = usuarios.FirstOrDefault(u => u.Id == c.IdVendedor);
                    var fiesta = fiestas.FirstOrDefault(f => f.IdFiesta == c.IdFiesta);
                    var evento = eventos.FirstOrDefault(e => e.Id == fiesta?.IdEvento);

                    return new
                    {
                        Vendedor = vendedor?.Nombre ?? "Desconocido",
                        CantidadEntradas = c.CantidadCompra,
                        Fiesta = evento?.Nombre ?? "Desconocido"
                    };
                }).ToList();

                // Agrupar por Vendedor y Fiesta, sumando las cantidades
                var listaParaMostrar = comprasConNombres
                    .GroupBy(c => new { c.Vendedor, c.Fiesta })
                    .Select(g => new
                    {
                        Vendedor = g.Key.Vendedor,
                        CantidadEntradas = g.Sum(c => c.CantidadEntradas),
                        Fiesta = g.Key.Fiesta
                    })
                    .OrderBy(x => x.Vendedor)
                    .ThenBy(x => x.Fiesta)
                    .ToList();

                ventasVendedoresDataGridView.AutoGenerateColumns = true;
                ventasVendedoresDataGridView.DataSource = listaParaMostrar;

                if (ventasVendedoresDataGridView.Rows.Count > 0)
                {
                    ventasVendedoresDataGridView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas de vendedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

