﻿using CartoladaMobile.Helpers;
using CartoladaMobile.ViewModels;
using CartoladaMobile.Views;
using Xamarin.Forms;

namespace CartoladaMobile.Main
{
    public partial class MainPage : TabbedPage
    {
        MainPageViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = viewModel = new MainPageViewModel();
        }

		protected override void OnAppearing()
		{
            Children.Add(new NavigationPage(new MercadoDestaques())
			{
				Title = "Mais Escalados"//,
                //Icon = Device.OnPlatform("tab_feed.png", null, null)
			});

			Children.Add(new NavigationPage(new Partidas())
			{
				Title = "Partidas"//,
                //Icon = Device.OnPlatform("tab_feed.png", null, null)
			});

            // ANDROID

			if (Device.RuntimePlatform == Device.Android)
			{
				BarBackgroundColor = ColorApp.GetColor("Primary");
			}

            base.OnAppearing();
		}
    }
}
