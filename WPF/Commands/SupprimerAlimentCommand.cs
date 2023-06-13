using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.ViewModel;

namespace WPF.Commands
{
    public class SupprimerAlimentCommand : CommandBase
    {
        private ObservableCollection<AlimentViewModel> _aliments;
        public override void Execute(object parameter)
        {
            _aliments.Remove((AlimentViewModel)parameter);
        }
        public SupprimerAlimentCommand(ObservableCollection<AlimentViewModel> aliments)
        {
            _aliments = aliments;
        }
    }
}
