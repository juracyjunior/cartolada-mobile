using System;
using Newtonsoft.Json;

namespace CartoladaMobile.Models
{
    public class Partida: IComparable
    {
		[JsonProperty("clube_casa_id")]
		public int IdClubeCasa { get; set; }

        public Clube ClubeCasa { get; set; }

		[JsonProperty("clube_casa_posicao")]
		public int ClubeCasaPosicao { get; set; }

        [JsonProperty("aproveitamento_mandante")]
        public String[] AproveitamentoCasa { get; set; }

		[JsonProperty("clube_visitante_id")]
		public int IdClubeVisitante { get; set; }

        public Clube ClubeVisitante { get; set; }

		[JsonProperty("clube_visitante_posicao")]
		public int ClubeVisitantePosicao { get; set; }

		[JsonProperty("aproveitamento_visitante")]
		public String[] AproveitamentoVisitante { get; set; }

		[JsonProperty("partida_data")]
        public DateTime PartidaData { get; set; }

		public String Local { get; set; }

        private int _placarCasa;
        [JsonProperty("placar_oficial_mandante")]
        public int? PlacarCasa
        { 
            get
            {
                return _placarCasa;
            }
            set
            {
                _placarCasa = value ?? 0;
            }
        }

        private int _placarVisitante;
        [JsonProperty("placar_oficial_visitante")]
		public int? PlacarVisitante
		{
			get
			{
				return _placarVisitante;
			}
			set
			{
				_placarVisitante = value ?? 0;
			}
		}

        public int CompareTo(object obj)
        {
            return this.PartidaData.CompareTo((obj as Partida).PartidaData);
        }
    }

    public class PartidasArray
    {
        public Partida[] Partidas { get; set; }
    }
}
