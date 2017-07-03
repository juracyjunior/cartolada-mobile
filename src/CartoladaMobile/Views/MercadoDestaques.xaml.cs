using System;
using System.Collections.Generic;
using Xamarin.Forms;
using CartoladaMobile.ViewModels;

namespace CartoladaMobile.Views
{
    public partial class MercadoDestaques : ContentPage
    {
        MercadoDestaquesViewModel viewModel;

        public MercadoDestaques()
        {
            InitializeComponent();

            this.BindingContext = viewModel = new MercadoDestaquesViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			lvwMercadoDestaques.IsPullToRefreshEnabled = true;

			lvwMercadoDestaques.Refreshing += (sender, e) =>
			{
                Load();
				lvwMercadoDestaques.EndRefresh();
			};

            Load();
		}

        private void Load()
        {
            viewModel.CarregarMercadoDestaques.Execute(null);
        }
    }
}
