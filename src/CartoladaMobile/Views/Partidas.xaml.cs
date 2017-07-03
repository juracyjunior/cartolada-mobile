using System;
using System.Collections.Generic;
using Xamarin.Forms;
using CartoladaMobile.ViewModels;

namespace CartoladaMobile.Views
{
    public partial class Partidas : ContentPage
    {
        PartidasViewModel viewModel;

        public Partidas()
        {
			InitializeComponent();

            this.BindingContext = viewModel = new PartidasViewModel();
        }

        protected override void OnAppearing()
        {
            //await viewModel.Load();

            base.OnAppearing();

            lvwPartidas.IsPullToRefreshEnabled = true;

            lvwPartidas.Refreshing += (sender, e) => 
            {
                Load();
                lvwPartidas.EndRefresh();
            };

            Load();
        }

        private void Load()
        {
            viewModel.CarregarPartidas.Execute(null);
        }
    }
}
