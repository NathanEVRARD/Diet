using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MaLib;
using WPF.Commands;

namespace WPF.MVVM.ViewModel
{
    public class AjoutClientViewModel : ViewModelBase
    {
        private ClientViewModel _newClient;

        private String _currentPatho;

        private bool _isPathoSelected = false;

        private String? _selectedPatho;
        private ObservableCollection<ClientViewModel> _clients;

        public bool IsPathoSelected
        {
            get { return _isPathoSelected;}
            set
            {
                _isPathoSelected = value;
                OnPropertyChanged();
            }
        }

        public String CurrentPatho
        {
            get { return _currentPatho;}
            set
            {
                _currentPatho = value;
                OnPropertyChanged();
            }
        }

        public String? SelectedPatho
        {
            get { return _selectedPatho; }
            set
            {
                _selectedPatho = value;
                IsPathoSelected = true;
                OnPropertyChanged();
            }
        }

        public ClientViewModel NewClient
        {
            get { return _newClient;}
            set
            {
                _newClient = value;
                OnPropertyChanged();
            }

        }

        public ICommand AjoutPathologieCommand { get; }
        public ICommand SuppressionPathologieCommand { get; }
        public ICommand AjoutClientCommand { get; }
        

        public AjoutClientViewModel(ObservableCollection<ClientViewModel> clients)
        {
            _clients = clients;
            _newClient = new ClientViewModel(new Client());
            _newClient.Naissance = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            AjoutPathologieCommand = new AjoutPathologieCommand(_newClient.Pathologies);
            SuppressionPathologieCommand = new SuppressionPathologieCommand(_newClient.Pathologies);
            AjoutClientCommand = new AjoutClientCommand(_clients);
        }
    }
}
