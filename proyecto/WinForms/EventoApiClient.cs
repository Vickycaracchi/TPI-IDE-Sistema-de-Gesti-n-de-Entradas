using DTOs;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WindowsForms
{
    //Revisar si no seria mejor usar metodos estaticos        

    public class EventoApiClient
    {
        private static HttpClient client = new HttpClient();
        static EventoApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<EventoDTO> GetAsync(int id)
        {
            EventoDTO evento = null;
            HttpResponseMessage response = await client.GetAsync("eventos/" + id);
            if (response.IsSuccessStatusCode)
            {
                evento = await response.Content.ReadFromJsonAsync<EventoDTO>();
            }
            return evento;
        }

        public static async Task<IEnumerable<EventoDTO>> GetAllAsync()
        {
            IEnumerable<EventoDTO> eventos = null;
            HttpResponseMessage response = await client.GetAsync("eventos");
            if (response.IsSuccessStatusCode)
            {
                eventos = await response.Content.ReadFromJsonAsync<IEnumerable<EventoDTO>>();
            }
            return eventos;
        }

        public async static Task AddAsync(EventoDTO evento)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("eventos", evento);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("eventos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(EventoDTO evento)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("eventos", evento);
            response.EnsureSuccessStatusCode();
        }
    }
}
