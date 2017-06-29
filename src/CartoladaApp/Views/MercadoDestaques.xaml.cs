using CartoladaApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CartoladaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MercadoDestaques : ContentPage
    {
        public MercadoDestaques()
        {
            InitializeComponent();

            this.BindingContext = new MercadoDestaquesViewModel();
        }
    }
}