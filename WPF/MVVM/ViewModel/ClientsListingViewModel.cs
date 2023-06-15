using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MaLib;
using WPF.Commands;

namespace WPF.MVVM.ViewModel
{
    public class ClientsListingViewModel : ViewModelBase
    {
        private ObservableCollection<ClientViewModel> _clients;
        public IEnumerable<ClientViewModel> Clients => _clients;

        private ObservableCollection<AlimentViewModel> _aliments;

        private ClientViewModel? _selectedClient;
        private NavigationStore _navigationStore;

        private bool _isClientSelected = false;
        public ICommand AjouterClientCommand { get; }
        public ICommand SupprimerClientCommand { get; }
        public ICommand NavigatePlanCommand { get; }

        public bool IsClientSelected
        {
            get { return _isClientSelected; }
            set
            {
                _isClientSelected = value;
                OnPropertyChanged();
            }
        }

        public ClientViewModel? SelectedClient
        {
            get { return _selectedClient; }
            set
            {
                _selectedClient = value;
                IsClientSelected = true;
                OnPropertyChanged();
            }
        }

        public ClientsListingViewModel(ObservableCollection<AlimentViewModel> aliments, ObservableCollection<ClientViewModel> clients, NavigationStore navigationStore)
        {
            _clients = clients;
            _navigationStore = navigationStore;
            _aliments = aliments;

            AjouterClientCommand = new AjouterClientCommand(_clients);
            SupprimerClientCommand = new SupprimerClientCommand(_clients);
            NavigatePlanCommand = new NavigateCommand<PlanViewModel>(navigationStore, () => new PlanViewModel(_selectedClient, _aliments, navigationStore));
        }
    }
}
