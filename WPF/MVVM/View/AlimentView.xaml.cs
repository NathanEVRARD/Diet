using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WPF.MVVM.ViewModel;

namespace WPF.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour AlimentView.xaml
    /// </summary>
    public partial class AlimentView : UserControl
    {
        private DispatcherTimer searchTimer;
        public AlimentView()
        {
            InitializeComponent();

            searchTimer = new DispatcherTimer();
            searchTimer.Interval = TimeSpan.FromMilliseconds(500);
            searchTimer.Tick += SearchTimer_Tick;
        }

        private void ChampRecherche_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }
        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            var viewModel = DataContext as AlimentsListingViewModel;
            var items = viewModel?.Aliments;
            string searchQuery = ChampRecherche.Text.ToLower();
            var filteredItems = items.Where(item => item.Nom.ToLower().Contains(searchQuery));
            DataGridAliments.ItemsSource = filteredItems;
        }
    }
}
