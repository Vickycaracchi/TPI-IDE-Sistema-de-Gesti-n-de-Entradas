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
            this.Resize += fiesLista_Resize;
        }

        private async void GetAllAndLoad()
        {
            try
            {

                lugares = (await LugarApiClient.GetAllAsync()).ToList();
                eventos = (await EventoApiClient.GetAllAsync()).ToList();


                var fiestas = (await FiestaApiClient.GetAllAsync()).ToList();

                // Obtener el lote actual por fiesta (si existe)
                var lotesPorFiesta = new Dictionary<int, LoteDTO>();
                var listaParaMostrar = new List<object>();

                foreach (var f in fiestas)
                {
                    LoteDTO? lote = null;
                    if (!lotesPorFiesta.TryGetValue(f.IdFiesta, out lote))
                    {
                        try
                        {
                            lote = await LoteApiClient.GetLoteActualAsync(f.IdFiesta);
                        }
                        catch
                        {
                            lote = null;
                        }
                        lotesPorFiesta[f.IdFiesta] = lote;
                    }

                    listaParaMostrar.Add(new
                    {
                        f.IdFiesta,
                        f.FechaFiesta,
                        NombreLugar = lugares.FirstOrDefault(l => l.Id == f.IdLugar)?.Nombre ?? "Desconocido",
                        NombreEvento = eventos.FirstOrDefault(e => e.Id == f.IdEvento)?.Nombre ?? "Desconocido",
                        Lote = lote?.Nombre ?? "Sin lote actual"
                    });
                }


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
            this.fiesLista_Resize(sender, e);
            GetAllAndLoad();
        }

        private void fiesLista_Resize(object sender, EventArgs e)
        {


            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;


        }
    }
}