using CartoladaApp.Shared;
using CartoladaApp.Shared.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace CartoladaApp.ViewModels
{
    public class MercadoDestaquesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        public MercadoDestaquesViewModel()
        {
            Load();
        }

        public async void Load()
        {
            CartoladaApi cartoladaApi = new CartoladaApi();
            this.Lista = await cartoladaApi.GetMercadoDestaquesAsync();
        }
    }
}
