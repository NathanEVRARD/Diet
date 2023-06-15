using System.Collections.ObjectModel;
using MaLib;
using System.Windows;
using WPF.MVVM.ViewModel;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            var viewModel = DataContext as MainWindowViewModel;
            viewModel.SaveCSVAliments("aliments.txt");
            viewModel.SaveClients("clients.txt");
            viewModel.SaveClientNum("clientNum.txt");
        }
    }
}
