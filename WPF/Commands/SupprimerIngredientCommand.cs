using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.ViewModel;

namespace WPF.Commands
{
    public class SupprimerIngredientCommand : CommandBase
    {
        private ObservableCollection<IngredientViewModel> _ingredients;
        public override void Execute(object parameter)
        {
            _ingredients.Remove((IngredientViewModel)parameter);
        }
        public SupprimerIngredientCommand(ObservableCollection<IngredientViewModel> ingredients)
        {
            _ingredients = ingredients;
        }
    }
}
