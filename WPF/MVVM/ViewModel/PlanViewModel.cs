﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MaLib;
using WPF.Commands;

namespace WPF.MVVM.ViewModel
{
    public class PlanViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;
        private ObservableCollection<IngredientViewModel> _ingredients;
        public IEnumerable<IngredientViewModel> Ingredients => _ingredients;
        private ObservableCollection<AlimentViewModel> _aliments;
        public IEnumerable<AlimentViewModel> Aliments => _aliments;
        private ClientViewModel _client;
        private IngredientViewModel _selectedIngredient;
        private bool _isIngredientSelected;

        public ICommand AjouterIngredientCommand { get; }

        public IngredientViewModel SelectedIngredient
        {
            get { return _selectedIngredient; }
            set
            {
                _selectedIngredient = value;
                OnPropertyChanged();
            }
        }

        public bool IsIngredientSelected
        {
            get { return _isIngredientSelected; }
            set
            {
                _isIngredientSelected = value;
                OnPropertyChanged();
            }
        }
        public ClientViewModel Client
        {
            get { return _client; }
            set
            {
                _client = value;
                OnPropertyChanged();
            }
        }
        public PlanViewModel(ClientViewModel client, ObservableCollection<AlimentViewModel> aliments, NavigationStore navigationStore)
        {
            _client = client;
            _aliments = aliments;
            _ingredients = new ObservableCollection<IngredientViewModel>();
            AjouterIngredientCommand = new AjouterIngredientCommand(_aliments, _ingredients);
            _navigationStore = navigationStore;
        }
    }
}
