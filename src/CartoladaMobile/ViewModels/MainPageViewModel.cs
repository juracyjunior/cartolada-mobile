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
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        public MercadoStatus MercadoStatus { get; set; }

		public string MercadoStatusStr
		{
			get
			{
                if (MercadoStatus == null)
                    return string.Empty;
                
				string status = this.MercadoStatus?.StatusMercado == 1 ? "Aberto" : "Fechado";
				return $"Mercado {status}";
			}
		}

		public string RodadaAtualStr
		{
			get
			{
				if (MercadoStatus == null)
					return string.Empty;

				string rodada = this.MercadoStatus?.RodadaAtual.ToString();
                return $"Mercado {rodada}";
			}
		}

        public MainPageViewModel()
        {
            Title = "Cartolada";

			MercadoStatus = (new CartoladaApi()).GetMercadoStatusAsync();
        }
    }
}
