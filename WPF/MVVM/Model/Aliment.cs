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

        public String Nom { get; set; }
        public float Lipides { get; set; }
        public float Glucides { get; set; }
        public float Fibres { get; set; }
        public float Proteines { get; set; }
        public float Kcal { get; set; }
        public float Fer { get; set; }
        public float Calcium { get; set; }
        public float VitC { get; set; }


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