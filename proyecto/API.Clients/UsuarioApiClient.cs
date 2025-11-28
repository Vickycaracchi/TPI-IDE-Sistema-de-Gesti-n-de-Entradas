using DTOs;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace API.Clients
{
    public class UsuarioApiClient
    {
        private static HttpClient client = new HttpClient();
        static UsuarioApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<UsuarioDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("usuarios/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<UsuarioDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener usuario con Id {id}.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener usuario con Id {id}");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener usuario con Id {id}");
            }
        }
        public static async Task<IEnumerable<UsuarioDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("usuarios");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<UsuarioDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de usuarios. ");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de usuarios");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear producto");
            }
        }
        public static async Task<IEnumerable<UsuarioDTO>> GetByTipoAsync(string tipoBuscado)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("usuariosByTipo/" + tipoBuscado);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<UsuarioDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de usuarios. ");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de usuarios");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de usuarios");
            }
        }
        public async static Task AddAsync(UsuarioDTO usuario)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("usuarios", usuario);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear usuario.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear usuario");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de usuarios");
            }
        }
        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("usuarios/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    
                   
                    try
                    {
                        var errorObj = await response.Content.ReadFromJsonAsync<JsonElement>();
                        if (errorObj.TryGetProperty("error", out var errorProperty))
                        {
                            throw new Exception(errorProperty.GetString() ?? $"Error al eliminar usuario con Id {id}");
                        }
                    }
                    catch
                    {
                       
                    }
                    
                    throw new Exception($"Error al eliminar usuario con Id {id}.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar usuario con Id {id}");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar usuario con Id {id}");
            }
        }
        public static async Task UpdateAsync(UsuarioDTO usuario)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("usuarios", usuario);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar usuario con Id {usuario.Id}.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar usuario con Id {usuario.Id}");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar usuario con Id {usuario.Id}");
            }
        }
        public static async Task<UsuarioDTO?> LoginAsync(LoginDTO loginDto)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("loginUsuario", loginDto);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<UsuarioDTO>();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    return null;
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error de servidor.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al intentar iniciar sesión");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al intentar iniciar sesión");
            }
        }

        public static async Task AsignarVendedorAJefeAsync(int idVendedor, int idJefe)
        {
            try
            {
                var requestBody = new { IdVendedor = idVendedor, IdJefe = idJefe };
                HttpResponseMessage response = await client.PostAsJsonAsync("usuarios/asignarVendedor", requestBody);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al asignar vendedor a jefe.");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al asignar vendedor a jefe");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al asignar vendedor a jefe");
            }
        }
    }
}