using System;

// Recipe class representing a recipe with name, ingredients, and instructions
public class Recipe
{
    public string Name { get; set; }
    public Ingredient[] Ingredients { get; set; }
    public Step[] Steps { get; set; }

    // Constructor for the Recipe class.
    public Recipe(string name, Ingredient[] ingredients, Step[] steps)
    {
        Name = name;
        Ingredients = ingredients;
        Steps = steps;
    }
}
