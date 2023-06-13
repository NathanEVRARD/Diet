using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MaLib;
using WPF.Commands;

namespace WPF.MVVM.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;
        private ObservableCollection<AlimentViewModel> _aliments;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        public ClientsListingViewModel Clients { get; set; }
        public ICommand NavigateClientsCommand { get; }
        public ICommand NavigateAlimentsCommand { get; }

        public MainWindowViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _aliments = new ObservableCollection<AlimentViewModel>();

            LoadCSVAliments("aliments.csv", _aliments);

            NavigateAlimentsCommand = new NavigateCommand<AlimentsListingViewModel>(navigationStore, () => new AlimentsListingViewModel(_aliments, navigationStore));
            NavigateClientsCommand = new NavigateCommand<ClientsListingViewModel>(navigationStore, () => new ClientsListingViewModel(_aliments, navigationStore));

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        private void LoadCSVAliments(string csvPath, ObservableCollection<AlimentViewModel> aliments)
        {
            try
            {
                StreamReader reader = new StreamReader(csvPath);
                string? content = reader.ReadLine();
                List<string> list;
                while (content != null)
                {
                    list = content.Split(';').ToList();
                    Aliment a = new Aliment(list[0], float.Parse(list[3]), float.Parse(list[1]), float.Parse(list[2]), float.Parse(list[4]));
                    a.Calcium = float.Parse(list[5]);
                    a.Fer = float.Parse(list[6]);
                    a.VitC = float.Parse(list[7]);
                    aliments.Add(new AlimentViewModel(a));
                    content = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
