using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> ingredients;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public Cocktail(string name,int capacity,int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            ingredients = new List<Ingredient>();


        }
        public List<Ingredient> Ingredients { get { return this.ingredients; } }
        public int CurrentAlcoholLevel => ingredients.Select(x => x.Alcohol).Sum();

        public void Add(Ingredient ingredient)
        {
            Ingredient ingredientInCocktail = this.ingredients.FirstOrDefault(x => x.Name == ingredient.Name);
            if (ingredientInCocktail == null && this.ingredients.Count < this.Capacity && CurrentAlcoholLevel + ingredient.Alcohol <= this.MaxAlcoholLevel)
            {
                this.ingredients.Add(ingredient);
            }

        }
        public bool Remove(string name)
        {
            return ingredients.Remove(FindIngredient(name));
            
        }
        public Ingredient FindIngredient(string name)
        {
            var cur = ingredients.FirstOrDefault(x => x.Name == name);
            return cur;
            
        }
        public Ingredient GetMostAlcoholicIngredient()
        {
            var cur = ingredients.OrderByDescending(x => x.Alcohol).First();
            return cur;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (Ingredient ingredient in this.ingredients)
            {
                sb.AppendLine(ingredient.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
