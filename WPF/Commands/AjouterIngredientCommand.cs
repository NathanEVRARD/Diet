using MaLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.MVVM.ViewModel;
using WPF.Windows;

namespace WPF.Commands
{
    public class AjouterIngredientCommand : CommandBase
    {
        private ObservableCollection<AlimentViewModel> _aliments;
        private ObservableCollection<IngredientViewModel> _ingredients;
        public override void Execute(object parameter)
        {
            AjoutIngredient window = new AjoutIngredient();
            window.Show();
            AjoutIngredientViewModel viewModel = new AjoutIngredientViewModel(_aliments, _ingredients);
            window.DataContext = viewModel;
        }

        public AjouterIngredientCommand(ObservableCollection<AlimentViewModel> aliments, ObservableCollection<IngredientViewModel> ingredients)
        {
            _aliments = aliments;
            _ingredients = ingredients;
        }
    }
}
