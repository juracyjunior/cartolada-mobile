using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using CartoladaMobile.Models;
using CartoladaMobile.Services;
using Xamarin.Forms;

namespace CartoladaMobile.ViewModels
{
    public class MercadoDestaquesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        private List<MercadoDestaque> _lista;
        public List<MercadoDestaque> Lista
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

        public Command CarregarMercadoDestaques { get; set; }

        public MercadoDestaquesViewModel()
        {
            Title = "Mais Escalados";

            this.CarregarMercadoDestaques = new Command(async () => 
                this.Lista = await DoMercadoDestaquesViewModel());
        }

        public async Task<List<MercadoDestaque>> DoMercadoDestaquesViewModel()
        {
            CartoladaApi cartoladaApi = new CartoladaApi();
            return await cartoladaApi.GetMercadoDestaquesAsync();
        }
    }
}
