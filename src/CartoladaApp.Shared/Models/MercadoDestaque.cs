using System;
using Newtonsoft.Json;

namespace CartoladaApp.Shared.Models
{
    public class MercadoDestaque : Jogador
    {
        public int Escalacoes { get; set; }

        public String Clube { get; set; }

        [JsonProperty("escudo_clube")]
        public String UrlEscudoClube { get; set; }
    }
}
