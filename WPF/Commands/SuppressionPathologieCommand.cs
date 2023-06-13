using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Commands
{
    public class SuppressionPathologieCommand : CommandBase
    {
        private ObservableCollection<String> _pathologies;

        public override void Execute(object parameter)
        {
            _pathologies.Remove((String)parameter);
        }

        public SuppressionPathologieCommand(ObservableCollection<String> pathologies)
        {
            _pathologies = pathologies;
        }
    }
}
