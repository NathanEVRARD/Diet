using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MaLib
{
    public class Ingredient : Aliment
    {
        private float quantite;
        private int frequence;

        public float Quantite
        {
            get { return quantite;}
            set { quantite = value; }
        }

        public int Frequence
        {
            get { return frequence;}
            set { frequence = value; }
        }

        public Ingredient() : base()
        {
            Quantite = 100;
            Frequence = 7;
        }

        public Ingredient(String n, int q, float g, float p, float l, float f) : base(n, g, p, l, f)
        {
            Quantite = q;
            Kcal = Kcal * q / 100;
            Frequence = 7;
        }

        public Ingredient(float q, int fq, Aliment a) : base(a.Nom, a.Glucides, a.Proteines, a.Lipides, a.Fibres)
        {
            Quantite = q;
            Frequence = 7;
            Glucides = CalculQuantite(a.Glucides);
            Lipides = CalculQuantite(a.Lipides);
            Proteines = CalculQuantite(a.Proteines);
            Fibres = CalculQuantite(a.Fibres);
            Calcium = CalculQuantite(a.Calcium);
            Fer = CalculQuantite(a.Fer);
            VitC = CalculQuantite(a.VitC);
            Kcal = calculKcal();
        }

        public float CalculFrequence(float v, int fq, int nFq)
        {
            return v * nFq / (float)fq;
        }

        public override string ToString()
        {
            return "Quantite : " + Quantite + "\n" + base.ToString();
        }

        public float CalculQuantite(float value)
        {
            return value * (float)Quantite / 100;
        }
    }
}
