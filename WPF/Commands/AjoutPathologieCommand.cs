using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.MVVM.ViewModel;

namespace WPF.Commands
{
    public class AjoutPathologieCommand : CommandBase
    {
        private ObservableCollection<String> _pathologies;
        private String _patho;

        public override void Execute(object parameter)
        {
            _patho = (String)parameter;
            _pathologies.Add(_patho);
        }

        public AjoutPathologieCommand(ObservableCollection<String> pathologies)
        {
            _pathologies = pathologies;
        }
    }
}
