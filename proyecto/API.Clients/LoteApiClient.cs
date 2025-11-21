using DTOs;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace API.Clients
{
    public class LoteApiClient
    {
        private static HttpClient client = new HttpClient();
        static LoteApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<LoteDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("lotes/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<LoteDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lote con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lote con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lote con Id {id}: {ex.Message}", ex);
            }
        }
        public static async Task<IEnumerable<LoteDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("lotes");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<LoteDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de lotes. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de lotes: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de lotes: {ex.Message}", ex);
            }
        }
        public static async Task<IEnumerable<LoteDTO>> GetByEventoAsync(int idEvento)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("lotesByEvento/" + idEvento);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<LoteDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de lotes. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de lotes: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de lotes: {ex.Message}", ex);
            }
        }
        public async static Task AddAsync(LoteConFiestaDTO lote)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("lotes", lote);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear lote.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear lote.");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear lote.");
            }
        }
        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("lotes/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar lote con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar lote con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar lote con Id {id}: {ex.Message}", ex);
            }
        }
        public static async Task UpdateAsync(LoteDTO lote)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("lotes", lote);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar lote con Id {lote.Id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar lote con Id {lote.Id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar lote con Id {lote.Id}: {ex.Message}", ex);
            }
        }

        public static async Task<LoteDTO> GetLoteActualAsync(int idFiesta)
        {
            HttpResponseMessage response = await client.GetAsync("loteActual/" + idFiesta);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<LoteDTO>();
            }
            else
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener el lote actual de la fiesta {idFiesta}: {errorContent}");
            }
        }

    }
}
