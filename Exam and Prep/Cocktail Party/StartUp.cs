namespace CocktailParty
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Sample Code Usage:

            //Initialize Cocktail
            Cocktail cocktail = new Cocktail("Pina Colada", 3, 10);

            //Initialize Ingredient
            Ingredient rum = new Ingredient("Rum", 2, 3);

            //Print rum
            Console.WriteLine(rum.ToString());

            //Ingredient: Rum
            //Quantity: 3
            //Alcohol: 2

            //Add rum
            cocktail.Add(rum);

            //Remove rum
            Console.WriteLine(cocktail.Remove("Rum")); // true

        }
    }
}
