using DTOs;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace API.Clients
{
    public class LugarApiClient
    {
        private static HttpClient client = new HttpClient();
        static LugarApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<LugarDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("lugares/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<LugarDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lugar con Id {id}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lugar con Id {id}");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lugar con Id {id}");
            }
        }
        public static async Task<IEnumerable<LugarDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("lugares");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<LugarDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de lugares.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de lugares");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de lugares");
            }
        }
        public async static Task AddAsync(LugarDTO lugar)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("lugares", lugar);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear lugar. ");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear lugar: ");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear lugar: ");
            }
        }
        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("lugares/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar lugar con Id {id}.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar lugar con Id {id}");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar lugar con Id {id}:");
            }
        }
        public static async Task UpdateAsync(LugarDTO lugar)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("lugares", lugar);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar lugar con Id {lugar.Id}.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar lugar con Id {lugar.Id}");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar lugar con Id {lugar.Id}");
            }
        }
    }
}
