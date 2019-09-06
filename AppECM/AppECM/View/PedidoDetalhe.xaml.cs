using AppECM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppECM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PedidoDetalhe : ContentPage
    {
        private PedidoDetalheModel viewModel;
        public PedidoDetalhe()
        {
            InitializeComponent();
        }
        public PedidoDetalhe(Model.Value moedas)
        {
            InitializeComponent();
          BindingContext = viewModel = new PedidoDetalheModel(moedas, this.Navigation);
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.closePage)
                await Navigation.PopModalAsync();
           
        }
    }
}