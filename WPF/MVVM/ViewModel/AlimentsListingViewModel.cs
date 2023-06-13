using MaLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Commands;

namespace WPF.MVVM.ViewModel
{
    public class AlimentsListingViewModel : ViewModelBase
    {
        private ObservableCollection<AlimentViewModel> _aliments;
        public IEnumerable<AlimentViewModel> Aliments => _aliments;

        private bool _isAlimentSelected;
        private AlimentViewModel _selectedAliment;

        public ICommand AjouterAlimentCommand { get; }
        public ICommand SupprimerAlimentCommand { get; }

        public bool IsAlimentSelected
        {
            get { return _isAlimentSelected;}
            set
            {
                _isAlimentSelected = value;
                OnPropertyChanged();
            }
        }

        public AlimentViewModel SelectedAliment
        {
            get { return _selectedAliment; }
            set
            {
                _selectedAliment = value;
                IsAlimentSelected = true;
                OnPropertyChanged();
            }
        }

        public AlimentsListingViewModel(ObservableCollection<AlimentViewModel> aliments, NavigationStore navigationStore)
        {
            _aliments = aliments;

            AjouterAlimentCommand = new AjouterAlimentCommand(_aliments);
            SupprimerAlimentCommand = new SupprimerAlimentCommand(_aliments);
        }
    }
}
