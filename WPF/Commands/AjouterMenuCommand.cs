using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using WPF.MVVM.View;
using WPF.MVVM.ViewModel;
using WPF.Windows;

namespace WPF.Commands
{
    public class AjouterMenuCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            AjoutMenu window = new AjoutMenu();
            window.Show();
            AjoutMenuViewModel viewModel = new AjoutMenuViewModel((ClientViewModel)parameter);
            window.DataContext = viewModel;
        }

        public AjouterMenuCommand()
        {

        }
    }
}
