using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace API.Clients
{
    public class FiestaApiClient
    {
        private static HttpClient client = new HttpClient();
        static FiestaApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<IEnumerable<FiestaDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("fiestas/");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<FiestaDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de fiestas. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de fiestas.");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de fiestas.");
            }
        }

        public static async Task<IEnumerable<FiestaDTO>> GetFiestasConLotesAsync()
        {
            HttpResponseMessage response = await client.GetAsync("fiestas/con-lotes");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<IEnumerable<FiestaDTO>>();
            }
            else
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener fiestas con lotes. Status: {response.StatusCode}, Detalle: {errorContent}");
            }
        }
        public static async Task<FiestaDTO> GetAsync(int idFiesta)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("fiestas/" + idFiesta);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<FiestaDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener fiesta con Id {idFiesta}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener fiesta con Id {idFiesta}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener producto con Id {idFiesta}: {ex.Message}", ex);
            }
        }
        public async static Task AddAsync(FiestaDTO fiesta)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("fiestas", fiesta);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear fiesta. Status: {response.StatusCode}.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear fiesta.");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear fiesta.");
            }
        }
        public static async Task UpdateAsync(FiestaDTO fiesta)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("fiestas", fiesta);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar fiesta. Status: {response.StatusCode}.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar fiesta.");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar fiesta.");
            }
        }
        public static async Task DeleteAsync(int idFiesta)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("fiestas/" + idFiesta);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar fiesta con Id {idFiesta}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)

            {
                throw new Exception($"Error de conexión al eliminar fiesta con Id {idFiesta}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar fiesta con Id {idFiesta}: {ex.Message}", ex);
            }
        }
    }
}
