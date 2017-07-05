using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CartoladaMobile.Models;
using CartoladaMobile.Services;
using Xamarin.Forms;

namespace CartoladaMobile.ViewModels
{
    public class MainPageViewModel //: INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        public MercadoStatus MercadoStatus { get; set; }

        public Command CarregarMercadoStatus { get; set; }

        public MainPageViewModel()
        {
            Title = "Cartolada";

            DoCarregaMercadoStatus();
        }

        public async void DoCarregaMercadoStatus()
        {
			CartoladaApi api = new CartoladaApi();
            this.MercadoStatus = await api.GetMercadoStatusAsync();
        }

		public string MercadoStatusStr()
		{
			return this.MercadoStatus?.StatusMercado == 2 ? "Fechado" : "Aberto";
		}
    }
}
