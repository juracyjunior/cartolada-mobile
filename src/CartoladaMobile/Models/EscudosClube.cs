using System;
using Newtonsoft.Json;

namespace CartoladaMobile.Models
{
	public class EscudosClube
	{
		[JsonProperty("60x60")]
		public String Img60x60 { get; set; }

		[JsonProperty("45x45")]
		public String Img45x45 { get; set; }

		[JsonProperty("30x30")]
		public String Img30x30 { get; set; }
	}
}
