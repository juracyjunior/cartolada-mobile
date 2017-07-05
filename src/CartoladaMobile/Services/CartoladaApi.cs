using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CartoladaMobile.Models;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Dynamic;

namespace CartoladaMobile.Services
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

            List<MercadoDestaque> lista = JsonConvert.DeserializeObject<List<MercadoDestaque>>(content);

            return lista;
        }

        public async Task<PartidasArray> GetPartidasAsync()
		{
			string url = getURL("partidas");

			HttpClient client = new HttpClient();

			var response = await client.GetAsync(url);

			String content = await response.Content.ReadAsStringAsync();

			PartidasArray partidas = JsonConvert.DeserializeObject<PartidasArray>(content);

			return partidas;
		}

        public async Task<List<Clube>> GetClubesAsync()
		{
			string url = getURL("clubes");

			HttpClient client = new HttpClient();

			var response = await client.GetAsync(url);

			String content = await response.Content.ReadAsStringAsync();

            List<Clube> clubes = new List<Clube>();

            dynamic lista = JsonConvert.DeserializeObject<ExpandoObject>(content);

            foreach (var item in lista)
            {
                Clube clube = new Clube();

                foreach (var i in item.Value)
                {
                    if (i.Key == "id")
                    {
                        clube.Id = Int32.Parse(i.Value.ToString());
                    }
                    else if (i.Key == "nome")
                    {
                        clube.Nome = i.Value.ToString();
					}
					else if (i.Key == "abreviacao")
					{
                        clube.Abreviacao = i.Value.ToString();
					}
					else if (i.Key == "escudos")
					{
                        clube.Escudos = new EscudosClube();

                        foreach (var e in i.Value)
                        {
							if (e.Key == "60x60")
							{
                                clube.Escudos.Img60x60 = e.Value.ToString();
							}
							else if (e.Key == "45x45")
							{
                                clube.Escudos.Img45x45 = e.Value.ToString();
							}
							else if (e.Key == "30x30")
							{
                                clube.Escudos.Img30x30 = e.Value.ToString();
							}
                        }
					}  
                }

                clubes.Add(clube);
            }

            return clubes;
		}

        public async Task<MercadoStatus> GetMercadoStatusAsync()
        {
			string url = getURL("mercado/status");

			HttpClient client = new HttpClient();

			var response = await client.GetAsync(url);

			String content = await response.Content.ReadAsStringAsync();

			MercadoStatus mercadoStatus = JsonConvert.DeserializeObject<MercadoStatus>(content);

            return mercadoStatus;
        }
    }
}
