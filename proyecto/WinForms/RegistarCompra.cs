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
    public partial class RegistrarCompra : Form
    {
        internal UsuarioDTO usuarioIngresado = new UsuarioDTO();
        private List<LugarDTO> lugares;
        private List<EventoDTO> eventos;
        public RegistrarCompra()
        {
            InitializeComponent();
        }
        private void ClientesLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.clientesDataGridView.DataSource = null;
                this.clientesDataGridView.DataSource = await UsuarioApiClient.GetByTipoAsync("Cliente");
                lugares = (await LugarApiClient.GetAllAsync()).ToList();
                eventos = (await EventoApiClient.GetAllAsync()).ToList();


                var fiestas = await FiestaApiClient.GetFiestasConLotesAsync();


                var listaParaMostrar = fiestas.Select(f => new
                {
                    f.IdFiesta,
                    f.FechaFiesta,
                    NombreLugar = lugares.FirstOrDefault(l => l.Id == f.IdLugar)?.Nombre ?? "Desconocido",
                    NombreEvento = eventos.FirstOrDefault(e => e.Id == f.IdEvento)?.Nombre ?? "Desconocido"
                }).ToList();


                fiestasDataGridView.AutoGenerateColumns = true;
                fiestasDataGridView.DataSource = listaParaMostrar;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de clientes o eventos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void enviarRegCompra_click(object sender, EventArgs e)
        {
            if (this.ValidarCompra())
            {
                try
                {
                    if (clientesDataGridView.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un cliente antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (fiestasDataGridView.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar una fiesta antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var cliente = clientesDataGridView.SelectedRows[0].Cells[0].Value;
                    var idClienteStr = Convert.ToString(cliente);
                    var idCliente = int.Parse(idClienteStr);

                    var fiesta = fiestasDataGridView.SelectedRows[0].Cells[0].Value;
                    var idFiestaStr = Convert.ToString(fiesta);
                    var idFiesta = int.Parse(idFiestaStr);

                    var cantidad = int.Parse(cantidadTextBox.Text);

                    var fecha = DateTime.Now;
                    var fiestaDTO = await FiestaApiClient.GetAsync(idFiesta);
                    LoteDTO loteDTO = await LoteApiClient.GetLoteActualAsync(fiestaDTO.IdFiesta);

                    CompraDTO compraDTO = new();
                    compraDTO.IdFiesta = idFiesta;
                    compraDTO.IdCliente = idCliente;
                    compraDTO.IdVendedor = usuarioIngresado.Id;
                    compraDTO.CantidadCompra = cantidad;
                    compraDTO.Entrada = "";
                    compraDTO.FechaHora = fecha;
                    await CompraApiClient.AddAsync(compraDTO);

                   
                    

                    MessageBox.Show("Compra registrada correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al intentar iniciar sesión: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private bool ValidarCompra()
        {
            bool isValid = true;

            registrarCompraErrorProvider.SetError(cantidadTextBox, string.Empty);

            if (this.cantidadTextBox.Text == string.Empty)
            {
                isValid = false;
                registrarCompraErrorProvider.SetError(cantidadTextBox, "La cantidad de entradas es requerida");
            }

            return isValid;
        }

        private void fiestasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
