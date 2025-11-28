using DTOs;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace API.Clients
{
    public class ProductoApiClient
    {
        private static HttpClient client = new HttpClient();
        static ProductoApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<ProductoDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("productos/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<ProductoDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener producto con Id {id}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener producto con Id {id}");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener producto con Id {id}");
            }
        }
        public static async Task<IEnumerable<ProductoDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("productos");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<ProductoDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de productos. ");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de productos: ");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de productos");
            }
        }
        public async static Task AddAsync(ProductoDTO producto)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("productos", producto);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear producto.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear producto: ");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear producto");
            }
        }
        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("productos/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar producto con Id {id}. ");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar producto con Id {id}");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar producto con Id {id}");
            }
        }
        public static async Task UpdateAsync(ProductoDTO producto)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("productos", producto);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar producto con Id {producto.Id}.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar producto con Id {producto.Id}");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar producto con Id {producto.Id}");
            }
        }
        public static async Task AddCompra(ProductoConCompraDTO producto)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("productos/concompra", producto);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear producto con compra.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear producto con compra.");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear producto con compra.");
            }
        }
    }
}

