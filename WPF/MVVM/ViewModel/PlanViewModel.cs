using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLib;

namespace WPF.MVVM.ViewModel
{
    public class PlanViewModel : ViewModelBase
    {
        public ObservableCollection<IngredientViewModel> _ingredients;
        public IEnumerable<IngredientViewModel> Ingredients => _ingredients;
        private ObservableCollection<AlimentViewModel> _aliments;
        public IEnumerable<AlimentViewModel> Aliments => _aliments;
        private ObservableCollection<Repas> _plan;
        private ClientViewModel _client;
        private IngredientViewModel _selectedIngredient;

        public IngredientViewModel SelectedIngredient
        {
            get { return _selectedIngredient; }
            set
            {
                _selectedIngredient = value;
                OnPropertyChanged();
            }
        }

        public ClientViewModel Client
        {
            get { return _client; }
            set
            {
                _client = value;
                OnPropertyChanged();
            }
        }
        public PlanViewModel(ClientViewModel client, ObservableCollection<AlimentViewModel> aliments, NavigationStore navigationStore)
        {
            _client = client;
            _aliments = aliments;
            _ingredients = new ObservableCollection<IngredientViewModel>();
        }
    }
}
