using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLib;

namespace WPF.MVVM.ViewModel
{
    public class IngredientViewModel : ViewModelBase, INotifyDataErrorInfo
    {
        private Ingredient _model;
        private int arrondi = 1;

        private readonly Dictionary<String, List<String>> _propertyErrors = new Dictionary<String, List<String>>();

        public IngredientViewModel(Ingredient model)
        {
            _model = model;
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

        public float Quantite
        {
            get { return _model.Quantite; }
            set
            {
                ClearErrors(nameof(Quantite));
                if(value <= 0)
                    AddError(nameof(Quantite), "La quantité ne peut être égale ou inférieure à 0.");
                if (!HasErrors)
                {
                    Glucides = _model.Glucides / _model.Quantite * value;
                    Proteines = _model.Proteines / _model.Quantite * value;
                    Lipides = _model.Lipides / _model.Quantite * value;
                    Fibres = _model.Fibres / _model.Quantite * value;
                    Calcium = _model.Calcium / _model.Quantite * value;
                    Fer = _model.Fer / _model.Quantite * value;
                    VitC = _model.VitC / _model.Quantite * value;
                    FqGlucides = _model.CalculFrequence(_model.Glucides, _model.Frequence, _model.Frequence);
                    FqProteines = _model.CalculFrequence(_model.Proteines, _model.Frequence, _model.Frequence);
                    FqLipides = _model.CalculFrequence(_model.Lipides, _model.Frequence, _model.Frequence);
                    FqFibres = _model.CalculFrequence(_model.Fibres, _model.Frequence, _model.Frequence);
                    FqCalcium = _model.CalculFrequence(_model.Calcium, _model.Frequence, _model.Frequence);    
                    FqFer = _model.CalculFrequence(_model.Fer, _model.Frequence, _model.Frequence);    
                    FqVitC = _model.CalculFrequence(_model.VitC, _model.Frequence, _model.Frequence);  
                    _model.Quantite = value;
                    Kcal = _model.calculKcal();
                    OnPropertyChanged();
                }
            }
        }

        public float Kcal
        {
            get { return (float)Math.Round(_model.Kcal, arrondi); }
            set
            {
                _model.Kcal = value;
                OnPropertyChanged();
            }
        }

        public int Frequence
        {
            get { return _model.Frequence; }
            set
            {
                ClearErrors(nameof(Frequence));
                if (value <= 0)
                    AddError(nameof(Frequence), "La fréquence ne peut être égale ou inférieure à 0.");
                if (!HasErrors)
                {
                    FqGlucides = _model.CalculFrequence(_model.Glucides, _model.Frequence, value);
                    FqProteines = _model.CalculFrequence(_model.Proteines, _model.Frequence, value);
                    FqLipides = _model.CalculFrequence(_model.Lipides, _model.Frequence, value);
                    FqFibres = _model.CalculFrequence(_model.Fibres, _model.Frequence, value);
                    FqCalcium = _model.CalculFrequence(_model.Calcium, _model.Frequence, value);
                    FqFer = _model.CalculFrequence(_model.Fer, _model.Frequence, value);
                    FqVitC = _model.CalculFrequence(_model.VitC, _model.Frequence, value);
                    Glucides = _model.Glucides / _model.Quantite * _model.Quantite;
                    Proteines = _model.Proteines / _model.Quantite * _model.Quantite;
                    Lipides = _model.Lipides / _model.Quantite * _model.Quantite;
                    Fibres = _model.Fibres / _model.Quantite * _model.Quantite;
                    Calcium = _model.Calcium / _model.Quantite * _model.Quantite;
                    Fer = _model.Fer / _model.Quantite * _model.Quantite;
                    VitC = _model.VitC / _model.Quantite * _model.Quantite;
                    _model.Frequence = value;
                    OnPropertyChanged();
                }
            }
        }


        public float Glucides
        {
            get { return (float)Math.Round(_model.Glucides, arrondi); }
            set
            {
                _model.Glucides = value;
                Kcal = _model.calculKcal();
                OnPropertyChanged();
            }
        }
        public float Proteines
        {
            get { return (float)Math.Round(_model.Proteines, arrondi); }
            set
            {
                _model.Proteines = value;
                Kcal = _model.calculKcal();
                OnPropertyChanged();
            }
        }
        public float Lipides
        {
            get { return (float)Math.Round(_model.Lipides, arrondi); }
            set
            {
                _model.Lipides = value;
                Kcal = _model.calculKcal();
                OnPropertyChanged();
            }
        }
        public float Fibres
        {
            get { return (float)Math.Round(_model.Fibres, arrondi); }
            set
            {
                _model.Fibres = value;
                OnPropertyChanged();
            }
        }
        public float Fer
        {
            get { return (float)Math.Round(_model.Fer, arrondi); }
            set
            {
                _model.Fer = value;
                OnPropertyChanged();
            }
        }
        public float VitC
        {
            get { return (float)Math.Round(_model.VitC, arrondi); }
            set
            {
                _model.VitC = value;
                OnPropertyChanged();
            }
        }

        public float Calcium
        {
            get { return (float)Math.Round(_model.Calcium, arrondi); }
            set
            {
                _model.Calcium = value;
                OnPropertyChanged();
            }
        }

        public float FqGlucides
        {
            get { return (float)Math.Round(_model.Glucides, arrondi); }
            set
            {
                _model.Glucides = value;
                Kcal = _model.calculKcal();
                OnPropertyChanged();
            }
        }
        public float FqProteines
        {
            get { return (float)Math.Round(_model.Proteines, arrondi); }
            set
            {
                _model.Proteines = value;
                Kcal = _model.calculKcal();
                OnPropertyChanged();
            }
        }
        public float FqLipides
        {
            get { return (float)Math.Round(_model.Lipides, arrondi); }
            set
            {
                _model.Lipides = value;
                Kcal = _model.calculKcal();
                OnPropertyChanged();
            }
        }
        public float FqFibres
        {
            get { return (float)Math.Round(_model.Fibres, arrondi); }
            set
            {
                _model.Fibres = value;
                OnPropertyChanged();
            }
        }
        public float FqFer
        {
            get { return (float)Math.Round(_model.Fer, arrondi); }
            set
            {
                _model.Fer = value;
                OnPropertyChanged();
            }
        }
        public float FqVitC
        {
            get { return (float)Math.Round(_model.VitC, arrondi); }
            set
            {
                _model.VitC = value;
                OnPropertyChanged();
            }
        }

        public float FqCalcium
        {
            get { return (float)Math.Round(_model.Calcium, arrondi); }
            set
            {
                _model.Calcium = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable GetErrors(string? propertyName)
        {
            return _propertyErrors.GetValueOrDefault(propertyName, null);
        }

        public bool HasErrors => _propertyErrors.Any();
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public void AddError(String propertyName, String errorMessage)
        {
            if (!_propertyErrors.ContainsKey(propertyName))
            {
                _propertyErrors.Add(propertyName, new List<String>());
            }

            _propertyErrors[propertyName].Add(errorMessage);
            OnErrorsChanged(propertyName);
        }

        private void OnErrorsChanged(String propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
        public void ClearErrors(string propertyName)
        {
            if (_propertyErrors.Remove(propertyName))
            {
                OnErrorsChanged(propertyName);  
            }
        }
    }
}
