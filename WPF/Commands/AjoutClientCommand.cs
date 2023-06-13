using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLib;
using WPF.MVVM.ViewModel;

namespace WPF.Commands
{
    public class AjoutClientCommand : CommandBase
    {
        private ObservableCollection<ClientViewModel> _clients;
        public override void Execute(object parameter)
        {
            _clients.Add((ClientViewModel)parameter);
        }

        public AjoutClientCommand(ObservableCollection<ClientViewModel> clients)
        {
            _clients = clients;
        }
    }
}
