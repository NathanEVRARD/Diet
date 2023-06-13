using MaLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.MVVM.ViewModel
{
    public class AlimentViewModel : ViewModelBase
    {
        public Aliment _model;
        public AlimentViewModel(Aliment a)
        {
            this._model = a;
        }

        private int arrondi = 1;

        public String Nom
        {
            get { return _model.Nom; }
            set
            {
                _model.Nom = value;
                OnPropertyChanged();
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

    }
}
