using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaFarmacia.HTTP
{
    public class ClientSingleton
    {
        //--comienza singleton--
        private static ClientSingleton instancia;
        private HttpClient client;
        private ClientSingleton()
        {
            client = new HttpClient();
        }
        public static ClientSingleton GetInstance()
        {
            if (instancia == null)
                instancia = new ClientSingleton();
            return instancia;
        }

        //--fin singleton--

        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }
        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await client.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }
        public async Task<string> PutAsync(string url, string data)
        {
            var content = new StringContent(data, Encoding.UTF8, "application/json");

            var result = await client.PutAsync(url, content);
            if (result.IsSuccessStatusCode)
            {
                // La solicitud PUTA fue exitosa
                return await result.Content.ReadAsStringAsync();
            }
            else
            {
                throw new HttpRequestException($"Error en la solicitud PUT. Código de estado: {result.StatusCode}");
            }
        }

        public async Task<string> DeleteAsync(string url)
        {
            var result = await client.DeleteAsync(url);
            var response = " ";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }
    }
}
