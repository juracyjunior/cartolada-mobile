using System;
using Newtonsoft.Json;

namespace CartoladaMobile.Models
{
    public class MercadoDestaque
    {
        public Atleta Atleta { get; set; }

        private String _posicao;
        public String Posicao
        {
            get
            {
                return _posicao.ToUpper();
            }
            set
            {
                _posicao = value;
            }
        }

        public int Escalacoes { get; set; }

        [JsonProperty("clube")]
        public String ClubeSigla { get; set; }

        [JsonProperty("escudo_clube")]
        public String ClubeEscudo { get; set; }
    }
}
