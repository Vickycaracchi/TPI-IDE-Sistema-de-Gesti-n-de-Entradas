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
    public partial class EventosLista : Form
    {
        public EventosLista()
        {
            InitializeComponent();
        }
        private void EventosLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButtonEvento_Click(object sender, EventArgs e)
        {
            EventoDetalle eventoDetalle = new EventoDetalle();

            EventoDTO eventoNuevo = new EventoDTO();

            eventoDetalle.Mode = FormMode.Add;
            eventoDetalle.Evento = eventoNuevo;

            eventoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButtonEvento_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un evento para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                EventoDetalle eventoDetalle = new EventoDetalle();

                EventoDTO evento = await EventoApiClient.GetAsync(selected.Id);

                eventoDetalle.Mode = FormMode.Update;
                eventoDetalle.Evento = evento;

                eventoDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar evento para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButtonEvento_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = this.SelectedItem();
                if (selected == null)
                {
                    MessageBox.Show("Seleccione un evento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el evento con Id {selected.Id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await EventoApiClient.DeleteAsync(selected.Id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void GetAllAndLoad()
        {
            try
            {
                this.eventosDataGridView.DataSource = null;
                this.eventosDataGridView.DataSource = await EventoApiClient.GetAllAsync();

                if (this.eventosDataGridView.Rows.Count > 0)
                {
                    this.eventosDataGridView.Rows[0].Selected = true;
                    this.eliminarButtonEvento.Enabled = true;
                    this.modificarButtonEvento.Enabled = true;
                }
                else
                {
                    this.eliminarButtonEvento.Enabled = false;
                    this.modificarButtonEvento.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de eventos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButtonEvento.Enabled = false;
                this.modificarButtonEvento.Enabled = false;
            }
        }
        private EventoDTO SelectedItem()
        {
            if (eventosDataGridView.SelectedRows.Count > 0)
            {
                return (EventoDTO)eventosDataGridView.SelectedRows[0].DataBoundItem;
            }
            return null;
        }
        private void eventosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
