using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.ViewModel;

namespace WPF.Commands
{
    public class AjoutAlimentCommand : CommandBase
    {
        private ObservableCollection<AlimentViewModel> _aliments;
        public override void Execute(object parameter)
        {
            _aliments.Add((AlimentViewModel)parameter);
        }

        public AjoutAlimentCommand(ObservableCollection<AlimentViewModel> aliments)
        {
            _aliments = aliments;
        }
    }
}
