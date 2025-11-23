using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace API.Clients
{
    public class CompraApiClient
    {
        private static HttpClient client = new HttpClient();
        static CompraApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<IEnumerable<CompraDTO>> GetAllVendedorAsync(int idVendedor)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("compras/vendedor/" + idVendedor);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<CompraDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de compras. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de compras.");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de compras.");
            }
        }

        public static async Task<IEnumerable<CompraDTO>> GetAllCliAsync(int idCliente)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("compras/cliente/" + idCliente);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<CompraDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de compras. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de compras.");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de compras.");
            }
        }
        public async static Task AddAsync(CompraDTO compra)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("compras", compra);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear compra. Status: {response.StatusCode}.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear compra.");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear compra.");
            }
        }
        public static async Task UpdateAsync(CompraDTO compra)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("eventos", compra);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar compra. Status: {response.StatusCode}.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar compra.");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar compra.");
            }
        }

        public static async Task<IEnumerable<CompraDTO>> GetAllByJefeAsync(int idJefe)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("compras/jefe/" + idJefe);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<CompraDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de compras. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de compras.");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de compras.");
            }
        }
    }
}
