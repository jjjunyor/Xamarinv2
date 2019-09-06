using AppECM.Model;
using AppECM.Model.ViewModels;
using AppECM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppECM.ViewModels
{
    public class PedidoViewModel : ViewModelBase
    {
        private MainPageViewModel viewModel;
        public PedidoViewModel(MainPageViewModel ViewModel)
        {
            this.viewModel = ViewModel;
        }
        
        public PedidoViewModel()
        {
            CarregarMoeda();
        }

        private void CarregarMoeda()
        {
            Moedas = new ObservableCollection<Value>();
            var service = new PedidoService().GetMoedaAsync();
            service.Result.value.ForEach(x => Moedas.Add(x));
            IsBusy = false;
        }

        public ObservableCollection<Value> Moedas { get; set; }
        private bool _closePage;
        public bool closePage
        {
            get { return _closePage; }
            set
            {
                if (value == _closePage) return;
                _closePage = value;
                OnPropertyChanged("closePage");
            }
        }
        public async Task OnAppearing()
        {
            await loadInput();
        }
        public async Task loadInput()
        {
           
        }
    }
}
