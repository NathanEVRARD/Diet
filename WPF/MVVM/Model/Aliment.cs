using System;

namespace MaLib
{
    public class Aliment
    {
        private String nom;
        private float kcal;
        private float glucides;
        private float proteines;
        private float lipides;
        private float fibres;
        private float fer = 0;
        private float calcium = 0;
        private float vitC = 0;

        public String Nom 
        {
            get { return nom; }
            set { nom = value; }
        }
        public float Lipides 
        {
            get { return lipides; }
            set { lipides = value; }
        }
        public float Glucides 
        {
            get { return glucides; }
            set { glucides = value; }
       }
        public float Fibres 
        {
            get { return fibres; }
            set { fibres = value; }
        }
        public float Proteines 
        {
            get { return proteines; }
            set { proteines = value; }
        }
        public float Kcal 
        {
            get { return kcal; }
            set { kcal = value; }
        }
        public float Fer 
        {
            get { return fer; }
            set { fer = value; }
        }
        public float Calcium 
        {
            get { return calcium; }
            set { calcium = value; }
        }
        public float VitC 
        {
            get { return vitC; }
            set { vitC = value; }
        }


        public Aliment() : this("Aliment", 0, 0, 0, 0){}

        public Aliment(String n, float g, float p, float l, float f)
        {
            Nom = n;
            Lipides = l;
            Glucides = g;
            Fibres = f;
            Proteines = p;
            Kcal = calculKcal();
        }

        public Aliment(String n, double g, double p, double l, double f)
        {
            Nom = n;
            Lipides = (float)l;
            Glucides = (float)g;
            Proteines = (float)p;
            Fibres = (float)f;
            Kcal = calculKcal();
        }

        public override String ToString()
        {
            String chaine = "Nom : " + Nom + "\nKcalories : " + Kcal + "\nGlucides : " + Glucides + "\nProtéines : " + Proteines +"\nLipides : " + Lipides +  "\nFibres : " + Fibres + "\n";
            return chaine;
        }

        public void Affiche()
        {
            Console.WriteLine(ToString());
        }

        public float calculKcal()
        {
            return Proteines * 4 + Lipides * 9 + Glucides * 4;
        }
    }
}