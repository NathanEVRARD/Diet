using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MaLib
{
    public class Client
    {
        public static int idCourant = 1;
        private int id = 1;
        private String nom;
        private String prenom;
        private ObservableCollection<Ingredient> plan;
        private ObservableCollection<String> pathologies;
        private int taille;
        private float poids;
        private float bmi;
        private DateTime naissance;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nom { get; set; }
        public String Prenom { get; set; }
        public int Taille { get; set; }
        public float Poids { get; set; }
        public float Bmi { get; set; }
        public ObservableCollection<Ingredient> Plan { get; set; }
        public ObservableCollection<String> Pathologies { get; set; }
        public DateTime Naissance { get; set; }

        public Client() : this("nom", "prenom", 0, 0){ }

        public Client(String n, String p, int t, float pd)
        {
            Nom = n;
            Prenom = p;
            Taille = t;
            Poids = pd;
            Plan = new ObservableCollection<Ingredient>();
            Pathologies = new ObservableCollection<String>();
            Bmi = calculBmi();
            Id = idCourant++;
        }

        public override String ToString()
        {
            String chaine = "";
            chaine += Nom + " " + Prenom + "\n";
            
            if(Plan is not null)
            {
                chaine += "Recettes : \n";
                foreach (Ingredient r in Plan)
                {
                    chaine += r.ToString() + "\n";
                }
                chaine += "\n";
            }
            if(Pathologies is not null)
            {
                chaine += "Pathologies : (";
                foreach(String p in Pathologies)
                {
                    chaine += p + ", ";
                }
                chaine += ")\n";
            }
            return chaine;
        }

        public float calculBmi()
        {
            return Poids / (((float)Taille / 100) * ((float)Taille / 100));
        }

        public void Affiche()
        {
            Console.WriteLine(ToString());
        }
    }
}
