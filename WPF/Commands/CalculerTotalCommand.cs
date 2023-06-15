using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.ViewModel;

namespace WPF.Commands
{
    public class CalculerTotalCommand : CommandBase
    {
        private ObservableCollection<IngredientViewModel> _ingredients;
        private IngredientViewModel _total;
        public override void Execute(object parameter)
        {
            _total.Glucides = 0;
            _total.Lipides = 0;
            _total.Calcium = 0;
            _total.Fer = 0;
            _total.Proteines = 0;
            _total.Fibres = 0;
            _total.VitC = 0;
            _ingredients.ToList().ForEach(a =>
            {
                _total.Glucides += a.FqGlucides;
                _total.Lipides += a.FqLipides;
                _total.Calcium += a.FqCalcium;
                _total.Fer += a.FqFer;
                _total.Proteines += a.FqProteines;
                _total.Fibres += a.FqFibres;
                _total.VitC += a.FqVitC;
            });
        }

        public CalculerTotalCommand(ObservableCollection<IngredientViewModel> ingredients, IngredientViewModel total)
        {
            _ingredients = ingredients;
            _total = total;
        }
    }
}
