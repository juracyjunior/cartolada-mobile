using CartoladaMobile.Helpers;
using CartoladaMobile.Views;
using Xamarin.Forms;

namespace CartoladaMobile.Main
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "Cartolada";

            if (Device.RuntimePlatform == Device.Android)
            {
                BarBackgroundColor = ColorApp.GetColor("Primary");
            }

            this.ToolbarItems.

            Children.Add(new NavigationPage(new MercadoDestaques())
            {
                Title = "Mais Escalados"/*,
                Icon = Device.OnPlatform("tab_feed.png", null, null)*/
            });

            Children.Add(new NavigationPage(new Partidas())
			{
				Title = "Partidas"/*,
                Icon = Device.OnPlatform("tab_feed.png", null, null)*/
			});
        }
    }
}
