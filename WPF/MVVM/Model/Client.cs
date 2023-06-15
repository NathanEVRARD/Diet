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
        private static int idCourant = 1;
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

        public String Nom 
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Prenom 
        {
            get { return  prenom; }
            set { prenom = value; }
        }
        public int Taille 
        {
            get { return taille; } 
            set { taille  = value; }
        }
        public float Poids
        {
            get { return poids; }
            set { poids = value; }
        }
        public float Bmi 
        {
            get { return bmi; }
            set { bmi = value; }
        }
        public ObservableCollection<Ingredient> Plan 
        {
            get { return plan; }
            set { plan = value; }
        }
        public ObservableCollection<String> Pathologies 
        {
            get { return pathologies; }
            set { pathologies = value; }
        }
        public DateTime Naissance
        {
            get { return naissance; }
            set { naissance = value; }
        }

        public static int IdCourant
        {
            get { return idCourant;}
            set { idCourant = value; }
        }

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
