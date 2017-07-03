using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using CartoladaMobile.Models;
using CartoladaMobile.Services;
using Xamarin.Forms;

namespace CartoladaMobile.ViewModels
{
    public class PartidasViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        private List<Partida> _lista;
        public List<Partida> Lista
        {
            get
            {
                return _lista;
            }
            set
            {
                _lista = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Lista"));
            }
        }

        public Command CarregarPartidas { get; set; }

        public PartidasViewModel()
        {
            Title = "Partidas";

            this.CarregarPartidas = new Command(async () => this.Lista = await DoCarregarPartidas());
        }

        private async Task<List<Partida>> DoCarregarPartidas()
        {
            CartoladaApi cartoladaApi = new CartoladaApi();

            PartidasArray partidas = await cartoladaApi.GetPartidasAsync();

            List<Partida> retorno = new List<Partida>();

            List<Clube> clubes = await cartoladaApi.GetClubesAsync();

            foreach(Partida partida in partidas.Partidas)
            {
                partida.ClubeCasa = clubes.Find(c => c.Id == partida.IdClubeCasa);
                partida.ClubeVisitante = clubes.Find(c => c.Id == partida.IdClubeVisitante);

                retorno.Add(partida);
            }

            retorno.Sort();

            return retorno;
        }
    }
}
