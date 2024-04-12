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

// Main program
class Program
{
    static void Main(String[] args)
    {
        // Main loop of the program
        string choice = "";
        while(choice != "5")
        {
            // Display menu options
            Console.WriteLine("\nDine.Me Menu");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. View Recipe");
            Console.WriteLine("3. Scale Recipe");
            Console.WriteLine("4. Remove Recipe");
            Console.WriteLine("5. Exit");

            //Read user choice from input
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    // Call Add Recipe method when user chooses option 1

                    break;
                case "2":
                    // Call ViewRecipe method when user chooses option 2

                    break;
                case "3":
                    // Call ScaleRecipe method when user chooses option 3
                    
                    break;
                case "4":
                    // Call RemoveRecipe method when user chooses option 4

                    break;
                case "5":
                    // Exit the program when the user chooses option 5

                    Environment.Exit(0);
                    break;
                default:
                    // Display message for invalid input

                    Console.WriteLine("Invalid choice. please try again");
                    break;
            }
        }        
    }
}