using System;

// Recipe class representing a recipe with name, ingredients, and instructions
namespace PROG6221POE
{
    public class Recipe
    {
        public string name { get; set; }
        public Ingredient[] ingredients { get; set; }
        public Step[] steps { get; set; }

        // Constructor for the Recipe class.
        public Recipe(string name, Ingredient[] ingredients, Step[] steps)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.steps = steps;
        }
    }
}