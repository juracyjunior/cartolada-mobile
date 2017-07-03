using System;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CartoladaMobile.Models
{
    public class Atleta
    {
        [JsonProperty("atleta_id")]
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Apelido { get; set; }

        [JsonProperty("foto")]
        public String UrlFoto { get; set; }

        public ImageSource Imagem
        {
            get
            {
                return UrlFoto.Replace("FORMATO", "140x140");
            }
        }
    }
}
