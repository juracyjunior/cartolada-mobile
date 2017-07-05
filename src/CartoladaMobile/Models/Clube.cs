using System;
using Newtonsoft.Json;

namespace CartoladaMobile.Models
{
    public class Clube
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Abreviacao { get; set; }

        public EscudosClube Escudos { get; set; }
    }
}
