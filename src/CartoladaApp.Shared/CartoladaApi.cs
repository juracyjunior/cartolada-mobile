using CartoladaApp.Shared.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CartoladaApp.Shared
{
    public class CartoladaApi
    {
        private string baseURL = "https://api-jj.jelasticlw.com.br/cartola/";

        private string getURL(String url)
        {
            return baseURL + url;
        }

        public async Task<List<MercadoDestaque>> GetMercadoDestaquesAsync()
        {
            string url = getURL("mercado/destaques");

            HttpClient client = new HttpClient();

            var response = await client.GetAsync(url);

            String content = await response.Content.ReadAsStringAsync();

            //var json = JArray.Parse(content);

            List<MercadoDestaque> lista = JsonConvert.DeserializeObject<List<MercadoDestaque>>(content);

            return lista;
        }
    }
}
