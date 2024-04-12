using Microsoft.VisualBasic;
using System;
using System.Linq.Expressions;

// Ingredient class representing an ingredient with name, measurement, and unit
class Ingredient
{
    public string name { get; set; }
    public float quantity { get; set; }
    public string unit { get; set; }

    // Constructor for the Ingredient class.
    public Ingredient(string name, float quantity, string unit)
    {
        this.name = name;
        this.quantity = quantity;
        this.unit = unit;
    }
}

// Recipe class representing a recipe with name, ingredients, and instructions
class Recipe
{
    public string name { get; set; }
    public Ingredient[] ingredients { get; set; }
    public string[] steps { get; set; }

    // Constructor for the Recipe class.
    public Recipe(string name, Ingredient[] ingredients, string[] steps)
    {
        this.name = name;
        this.ingredients = ingredients;
        this.steps = steps;
    }
}

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Dine.Me Menu");
    }
}