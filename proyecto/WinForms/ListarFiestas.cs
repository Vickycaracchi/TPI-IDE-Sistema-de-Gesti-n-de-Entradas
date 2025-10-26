using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Clients;
using DTOs;

namespace WinForms
{
    public partial class ListarFiestas : Form
    {
        private List<LugarDTO> lugares;
        private List<EventoDTO> eventos;

        public ListarFiestas()
        {
            InitializeComponent();
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


                fiestasDataGridView.AutoGenerateColumns = true;
                fiestasDataGridView.DataSource = listaParaMostrar;
            }


            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de fiestas: {ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarFiestas_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }
    }
}