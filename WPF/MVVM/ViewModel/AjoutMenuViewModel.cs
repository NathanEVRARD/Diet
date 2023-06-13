using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.MVVM.ViewModel
{
    public class AjoutMenuViewModel : ViewModelBase
    {
        private ClientViewModel _client;

        public ClientViewModel Client
        {
            get { return _client; }
            set
            {
                _client = value;
                OnPropertyChanged();
            }
        }
        public AjoutMenuViewModel(ClientViewModel client)
        {
            _client = client;
        }
    }
}
