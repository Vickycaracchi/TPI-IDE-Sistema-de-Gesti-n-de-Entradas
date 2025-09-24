using DTOs;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace API.Clients
{
    public class VendedorApiClient
    {
        private static HttpClient client = new HttpClient();
        static VendedorApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<VendedorDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("vendedors/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<VendedorDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener vendedor con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener vendedor con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener vendedor con Id {id}: {ex.Message}", ex);
            }
        }
        public static async Task<IEnumerable<VendedorDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("vendedors");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<VendedorDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de vendedors. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de vendedors: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de vendedors: {ex.Message}", ex);
            }
        }
        public async static Task AddAsync(VendedorDTO vendedor)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("vendedors", vendedor);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear vendedor. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear vendedor: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear vendedor: {ex.Message}", ex);
            }
        }
        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("vendedors/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar vendedor con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar vendedor con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar vendedor con Id {id}: {ex.Message}", ex);
            }
        }
        public static async Task UpdateAsync(VendedorDTO vendedor)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("vendedors", vendedor);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar vendedor con Id {vendedor.Id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar vendedor con Id {vendedor.Id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar vendedor con Id {vendedor.Id}: {ex.Message}", ex);
            }
        }
        public static async Task<VendedorDTO?> LoginAsync(CliLoginDTO vendedor)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("loginVendedor", vendedor);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<VendedorDTO>();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    return null;
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error de servidor. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al intentar iniciar sesión: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al intentar iniciar sesión: {ex.Message}", ex);
            }
        }
    }
}