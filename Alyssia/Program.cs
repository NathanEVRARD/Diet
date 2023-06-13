using WPF.MVVM.Model;
internal class Program
{
    private static void Main(string[] args)
    {
         /*Aliment carotte = new Aliment("Carotte", 41, 10, (float)0.9, (float)0.2, (float)2.8);
         Aliment pommeDeTerre = new Aliment("Pomme de terre", (float)80.5, (float)16.7, (float)1.8, (float)0.3, (float)1.8);
 
         Client c = new Client("Dubuffet", "Alyssia");
 
         Recette potee = new Recette("Potée aux carottes");
         potee.Ingredients.Add(new Ingredient(150, pommeDeTerre));
         potee.Ingredients.Add(new Ingredient(100, carotte));
 
         Recette cassoulet = new Recette("Cassoulet");
         cassoulet.Ingredients.Add(new Ingredient(200, new Aliment("Haricots", 50, 1, 2, 3, 4)));
         cassoulet.Ingredients.Add(new Ingredient(120, pommeDeTerre));
 
         c.Menu.Add(potee);
         c.Menu.Add(cassoulet);
 
         c.Pathologies.Add(new String("Insuffisance cardiaque droite"));
         c.Pathologies.Add(new String("Diabète de type 2"));
         c.Pathologies.Add(new String("Insuffisance reinale"));
 
         c.Affiche();
 
         Aliment Beurre = new Aliment("Beurre", (float)7 * 8 / 100, (float)6 * 8 / 100, 7.4, 0, 0);
 
         Console.WriteLine(Beurre.ToString() + "\n");

         Ingredient i = new Ingredient(250, Beurre);
         Ingredient b = new Ingredient(i);
         b.Quantite = 100;
 
         Console.WriteLine(i.ToString() + "\n");
 
         Console.WriteLine("Frequence pour 100 g : " + b.CalculFrequence(b.Glucides, 2) + "\n");
         Console.WriteLine("Frequence pour " + i.Quantite + " g : " + i.CalculFrequence(i.Glucides, 2));

        /*Ingredient TestIngredient = new Ingredient(7, Beurre);
        TestIngredient.Freq = 4;
        TestIngredient.Frequence = TestIngredient.calculFrequences();

        Console.WriteLine(TestIngredient.ToString());*/
        //Console.WriteLine(BeurreIngredient.Frequence.ToString());*/

        Client c = new Client("Menvuça", "Gérard", 165, (float)70.0);

        c.Pathologies.Add(new String("Hypercholestérolémie"));
        c.Pathologies.Add(new String("Intolérant au lactose"));

        Console.WriteLine("Bmi : " + c.calculBmi());

        /*Aliment painGris = new Aliment("Pain Gris", (float)47.3, 9, (float)1.7, (float)4.5, 0);
        painGris.VitC = 0;
        painGris.Fer = (float)1.7;
        painGris.Calcium = 39;

        Ingredient pain = new Ingredient(35, painGris);

        double freqGlu = pain.CalculFrequence(pain.Glucides, 2);
        double freqPro = pain.CalculFrequence(pain.Proteines, 2);
        double freqLip = pain.CalculFrequence(pain.Lipides, 2);
        double freqFib = pain.CalculFrequence(pain.Fibres, 2);
        double freqFer = pain.CalculFrequence(pain.Fer, 2);
        double freqCal = pain.CalculFrequence(pain.Calcium, 2);
        double freqKcal = pain.CalculFrequence(pain.Kcal, 2);

       /* Console.WriteLine("Frequence Glucides : " + freqGlu);
        Console.WriteLine("Frequence Proteines : " + freqPro);
        Console.WriteLine("Frequence Lipides : " + freqLip);
        Console.WriteLine("Frequence Fibres : " + freqFib);
        Console.WriteLine("Frequence Fer : " + freqFer);
        Console.WriteLine("Frequence Calcium : " + freqCal);
        Console.WriteLine("Frequence Kcalories : " + freqKcal);

        Console.WriteLine(pain.ToString());

        Recette rPain = new Recette("Pain Gris");
        rPain.Ingredients.Add(pain);

        c.Menu.Add(rPain);
        c.Affiche();*/
    }
}