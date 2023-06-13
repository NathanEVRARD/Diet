using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.View;
using WPF.MVVM.ViewModel;

namespace WPF.Commands
{
    public class SupprimerClientCommand : CommandBase
    {
        private ObservableCollection<ClientViewModel> _clients;
        public override void Execute(object parameter)
        {
            _clients.Remove((ClientViewModel)parameter);
        }
        public SupprimerClientCommand(ObservableCollection<ClientViewModel> clients)
        {
            _clients = clients;
        }
    }
}
