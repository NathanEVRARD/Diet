using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLib
{
    public class Repas
    {
        private String nom;
        private ObservableCollection<Ingredient> ingredients;

        public String Nom { get; set; }
        public ObservableCollection<Ingredient> Ingredients{get; set;}

        public Repas() : this("")
        {
            Ingredients = new ObservableCollection<Ingredient>();
        }

        public Repas(String n)
        {
            Nom = n;
            Ingredients = new ObservableCollection<Ingredient>();
        }

        public override string ToString()
        {
            String chaine = Nom + "(";
            foreach(Ingredient i in Ingredients)
            {
                chaine += i.Quantite + "g de " + i.Nom + ", ";
            }
            chaine += ")\n";
            return chaine;
        }

        public void Affiche()
        {
            Console.WriteLine(ToString());
        }
    }
}
