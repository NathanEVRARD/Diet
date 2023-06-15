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
    public class AjoutIngredientViewModel : ViewModelBase
    {
        private ObservableCollection<AlimentViewModel> _aliments;
        private ObservableCollection<IngredientViewModel> _ingredients;
        private AlimentViewModel _selectedAliment;
        private bool _isSelectedAliment = false;
        public IEnumerable<AlimentViewModel> Aliments => _aliments;

        public ICommand AjoutIngredientCommand { get; }

        public AlimentViewModel SelectedAliment
        {
            get { return _selectedAliment; }
            set
            {
                _selectedAliment = value;
                IsSelectedAliment = true;
                OnPropertyChanged();
            }
        }

        public bool IsSelectedAliment
        {
            get { return _isSelectedAliment; }
            set
            {
                _isSelectedAliment = value;
                OnPropertyChanged();
            }
        }
        public AjoutIngredientViewModel(ObservableCollection<AlimentViewModel> aliments, ObservableCollection<IngredientViewModel> ingredients)
        {
            _aliments = aliments;
            _ingredients = ingredients;
            AjoutIngredientCommand = new AjoutIngredientCommand(_ingredients);
        }
    }
}
