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

        public ClientsListingViewModel(ObservableCollection<AlimentViewModel> aliments, NavigationStore navigationStore)
        {
            Client.idCourant = 1;
            _clients = new ObservableCollection<ClientViewModel>();
            _navigationStore = navigationStore;
            _aliments = aliments;


            AjouterClientCommand = new AjouterClientCommand(_clients);
            SupprimerClientCommand = new SupprimerClientCommand(_clients);
            NavigatePlanCommand = new NavigateCommand<PlanViewModel>(navigationStore, () => new PlanViewModel(_selectedClient, _aliments, navigationStore));

            Client nathan = new Client("Evrard", "Nathan", 173, 63);
            Client alyssia = new Client("Dubuffet", "Alyssia", 160, 52);
            alyssia.Naissance = new DateTime(2002, 12, 17);
            nathan.Pathologies = new ObservableCollection<String>();
            nathan.Pathologies.Add(new String("Insuffisance reinale"));
            nathan.Pathologies.Add(new String("Diabète"));
            nathan.Naissance = new DateTime(2002, 11, 20);
            for (int i = 0; i < 10; i++)
            {
                _clients.Add(new ClientViewModel(nathan));
                _clients.Add(new ClientViewModel(alyssia));
            }
        }
    }
}
