using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MaLib;
using WPF.Commands;

namespace WPF.MVVM.ViewModel
{
    class AjouterAlimentViewModel : ViewModelBase
    {
        private AlimentViewModel _newAliment;
        private ObservableCollection<AlimentViewModel> _aliments;
        public AlimentViewModel NewAliment
        {
            get { return _newAliment;}
            set
            {
                _newAliment = value;
                OnPropertyChanged();
            }
        }

        public ICommand AjoutAlimentCommand { get;}

        public AjouterAlimentViewModel(ObservableCollection<AlimentViewModel> aliments)
        {
            _aliments = aliments;
            _newAliment = new AlimentViewModel(new Aliment());
            AjoutAlimentCommand = new AjoutAlimentCommand(_aliments);
        }

    }
}
