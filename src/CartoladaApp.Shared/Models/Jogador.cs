using System;
using Newtonsoft.Json;

namespace CartoladaApp.Shared.Models
{
    public class Jogador
    {
        [JsonProperty("atleta_id")]
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Apelido { get; set; }

        [JsonProperty("foto")]
        public String UrlFoto { get; set; }
    }
}
