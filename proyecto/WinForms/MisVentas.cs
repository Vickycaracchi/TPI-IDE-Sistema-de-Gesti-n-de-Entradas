﻿using API.Clients;
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
    public partial class MisVentas : Form
    {
        public UsuarioDTO usuarioIngresado { get; set; }
        public MisVentas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MisVentas_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            try
            {
                
                var compras = await CompraApiClient.GetAllVendedorAsync(usuarioIngresado.Id);
               
                var usuarios = await UsuarioApiClient.GetAllAsync();
                var fiestas = await FiestaApiClient.GetAllAsync();
                var lugares = await LugarApiClient.GetAllAsync();
                var eventos = await EventoApiClient.GetAllAsync();

                
                var listaParaMostrar = compras.Select(c =>
                {
                    var cliente = usuarios.FirstOrDefault(u => u.Id == c.IdCliente);
                    var vendedor = usuarios.FirstOrDefault(u => u.Id == c.IdVendedor);
                    var fiesta = fiestas.FirstOrDefault(f => f.IdFiesta == c.IdFiesta);

                    var lugar = lugares.FirstOrDefault(l => l.Id == fiesta?.IdLugar);
                    var evento = eventos.FirstOrDefault(e => e.Id == fiesta?.IdEvento);

                    return new
                    {

                        Cliente = cliente?.Nombre ?? "Desconocido",
                        Vendedor = vendedor?.Nombre ?? "Desconocido",
                        Fiesta = evento?.Nombre ?? "Desconocido",
                        Lugar = lugar?.Nombre ?? "Desconocido",
                        c.CantidadCompra,
                        c.FechaHora,
                        c.Entrada,
                        c.Precio_Entrada,
                    };
                }).ToList();

               
                misVentasDataGridView.AutoGenerateColumns = true;
                misVentasDataGridView.DataSource = listaParaMostrar;

                if (misVentasDataGridView.Rows.Count > 0)
                {
                    misVentasDataGridView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
