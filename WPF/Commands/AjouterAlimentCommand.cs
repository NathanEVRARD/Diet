using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.ViewModel;
using WPF.Windows;

namespace WPF.Commands
{
    class AjouterAlimentCommand : CommandBase
    {
        private ObservableCollection<AlimentViewModel> _aliments;
        public override void Execute(object parameter)
        {
            AjoutAliment window = new AjoutAliment();
            window.Show();
            window.DataContext = new AjouterAlimentViewModel(_aliments);
        }

        public AjouterAlimentCommand(ObservableCollection<AlimentViewModel> aliments)
        {
            _aliments = aliments;
        }
    }
}
