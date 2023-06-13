using MaLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace WPF.MVVM.ViewModel
{
    public class ClientViewModel : ViewModelBase
    {
        private Client _model;

        public ClientViewModel(Client c) 
        {
            this._model = c;
        }

        public int Id
        {
            get { return _model.Id; }
            set
            {
                _model.Id = value;
                OnPropertyChanged();
            }
        }

        public String Nom 
        {
            get { return _model.Nom; }
            set
            {
                _model.Nom = value;
                OnPropertyChanged();
            }
        }
        public String Prenom
        {
            get { return _model.Prenom; }
            set
            {
                _model.Prenom = value;
                OnPropertyChanged();
            }
        }

        public DateTime Naissance
        {
            get { return _model.Naissance; }
            set
            {
                _model.Naissance = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Ingredient> Plan
        {
            get { return _model.Plan; }
            set
            {
                _model.Plan = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<String> Pathologies
        {
            get { return _model.Pathologies; }
            set
            {
                _model.Pathologies = value;
                OnPropertyChanged();
            }
        }
        public int Taille
        {
            get { return _model.Taille; }
            set
            {
                _model.Taille = value;
                OnPropertyChanged();
                Bmi = _model.calculBmi().ToString("F");
            }
        }
        public float Poids
        {
            get { return _model.Poids; }
            set
            {
                _model.Poids = value;
                OnPropertyChanged();
                Bmi = _model.calculBmi().ToString("F");
            }
        }
        public String Bmi
        {
            get { return _model.Bmi.ToString("F"); }
            set
            {
                _model.Bmi = float.Parse(value);
                OnPropertyChanged();
            }
        }

        public ClientViewModel()
        {

        }
    }
}
