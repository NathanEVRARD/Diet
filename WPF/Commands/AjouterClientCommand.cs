using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF.MVVM.ViewModel;
using WPF.Windows;

namespace WPF.Commands
{
    public class AjouterClientCommand : CommandBase
    {
        private ObservableCollection<ClientViewModel> _clients;
        public override void Execute(object parameter)
        {
            AjoutClient window = new AjoutClient();
            window.Show();
            AjoutClientViewModel viewModel = new AjoutClientViewModel(_clients);
            window.DataContext = viewModel;
        }

        public AjouterClientCommand(ObservableCollection<ClientViewModel> clients)
        {
            _clients = clients;
        }
    }
}
