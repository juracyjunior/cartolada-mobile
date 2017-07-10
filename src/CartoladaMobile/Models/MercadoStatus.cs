using System;
using Newtonsoft.Json;

namespace CartoladaMobile.Models
{
    public class MercadoStatus
    {
		[JsonProperty("rodada_atual")]
	    public int RodadaAtual { get; set; }

        [JsonProperty("status_mercado")]
        public int StatusMercado { get; set; }

        public string StatusMercadoStr {
            get
            {
                return StatusMercado == 2 ? "Fechado" : "Aberto";
            }
        }

        [JsonProperty("times_escalados")]
        public int TimesEscalados { get; set; }

        public FechamentoMercado Fechamento { get; set; }

        public string Aviso { get; set; }
    }
}
