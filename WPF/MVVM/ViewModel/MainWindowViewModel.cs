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
using Newtonsoft.Json;
using WPF.Commands;

namespace WPF.MVVM.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;
        private ObservableCollection<AlimentViewModel> _aliments;
        private ObservableCollection<ClientViewModel> _clients;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        public ClientsListingViewModel Clients { get; set; }
        public ICommand NavigateClientsCommand { get; }
        public ICommand NavigateAlimentsCommand { get; }

        public ObservableCollection<AlimentViewModel> Aliments 
        { 
            get 
            {
                return _aliments; 
            } 
        }

        public MainWindowViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _aliments = new ObservableCollection<AlimentViewModel>();
            _clients = new ObservableCollection<ClientViewModel>();
            LoadCSVAliments("aliments.txt");
            LoadClients("clients.txt");
            LoadClientNum("clientNum.txt");

            _navigationStore.CurrentViewModel = new ClientsListingViewModel(_aliments, _clients, navigationStore);

            NavigateAlimentsCommand = new NavigateCommand<AlimentsListingViewModel>(navigationStore, () => new AlimentsListingViewModel(_aliments, navigationStore));
            NavigateClientsCommand = new NavigateCommand<ClientsListingViewModel>(navigationStore, () => new ClientsListingViewModel(_aliments, _clients, navigationStore));

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        private void LoadCSVAliments(string csvPath)
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
                    _aliments.Add(new AlimentViewModel(a));
                    content = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadClients(string csvPath)
        {
            try
            {
                StreamReader reader = new StreamReader (csvPath);
                string data;
                do
                {
                    data = reader.ReadLine();
                    if(data != null)
                    {
                        Client c = JsonConvert.DeserializeObject<Client>(data);
                        data = reader.ReadLine();
                        ObservableCollection<IngredientViewModel> plan = JsonConvert.DeserializeObject<ObservableCollection<IngredientViewModel>>(data);
                        ClientViewModel cvm = new ClientViewModel(c);
                        cvm.Plan = plan;
                        _clients.Add(cvm);
                    }
                }while(data != null);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadClientNum(string csvPath)
        {
            try
            {
                StreamReader reader = new StreamReader (csvPath);
                string data = reader.ReadLine();
                if(data != null)
                    Client.IdCourant = Int32.Parse(data);
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SaveClients(string csvPath)
        {
            try
            {
                StreamWriter writer = new StreamWriter(csvPath);
                _clients.ToList().ForEach(client => {
                    writer.WriteLine(JsonConvert.SerializeObject(client.Model));
                    writer.WriteLine(JsonConvert.SerializeObject(client.Plan));
                });
                writer.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SaveCSVAliments(string csvPath)
        {
            try
            {
                StreamWriter writer = new StreamWriter(csvPath);
                _aliments.ToList().ForEach(a => writer.WriteLine(a.Nom + ";" + a.Proteines + ";" + a.Lipides + ";" + a.Glucides + ";" + a.Fibres + ";" + a.Calcium + ";" + a.Fer + ";" + a.VitC));
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SaveClientNum(string csvPath)
        {
            try
            {
                StreamWriter writer = new StreamWriter(csvPath);
                writer.WriteLine(Client.IdCourant);
                writer.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
