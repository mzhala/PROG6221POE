using Microsoft.VisualBasic;
using System;
using System.Linq.Expressions;
using System.Xml.Linq;

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

// RecipeApp class managing the recipe application
class RecipeApp
{
    // Object to store the current Recipe
    private Recipe recipe;
    
    // Ratio value with default value 1
    double ratio = 1;
    // Constructor to initialize RecipeApp
    public RecipeApp()
    {
        //recipe = null;

        // Initialize recipe with a simple default recipe
        Ingredient[] ingredients = new Ingredient[]
        {
            new Ingredient("Egg", 1, "units"),
            new Ingredient("Butter", 1, "Teaspoon"),
            new Ingredient("Pepper", 1, "units"),
            new Ingredient("Salt", 1, "Pinch")
        };

        string[] steps = new string[]
        {
            "Preheat pan",
            "In a bowl combine and mix eggs, salt and pepper.",
            "Pour batter into a greased pan.",
            "Cook for 3 minutes, or until cooked."
        };
        recipe = new Recipe("Scrambled Egg", ingredients, steps);
    }

    // Method to add a recipe
    public void AddRecipe()
    {
        // Prompt user to enter recipe name
        Console.WriteLine("Enter Recipe Details:");

        // Prompt user to enter recipe name
        Console.Write("Name: ");
        string name = Console.ReadLine();

        // Prompt user to enter number of ingredient
        Console.Write("Number of Ingredients: ");
        int numIngredients = int.Parse(Console.ReadLine());

        // Create an array to store ingredients
        Ingredient[] ingredients = new Ingredient[numIngredients];

        for(int i = 0; i < numIngredients; i++)
        {
            // Prompt user to enter details for ingredient
            Console.WriteLine("\nEnter details for Ingredient " + (i + 1));
            
            // Prompt user to enter ingredient name
            Console.Write("Name: ");
            string ingredientName = Console.ReadLine();

            // Prompt user to enter ingredient quantity
            Console.Write("Quantity: ");
            float quantity = float.Parse(Console.ReadLine());

            // Prompt user to enter ingredient unit
            Console.Write("Unit: ");
            string unit = Console.ReadLine();

            // Create and add new Ingredient object to the array
            ingredients[i] = new Ingredient(ingredientName, quantity, unit);
        }

        // Prompt user to enter number of steps
        Console.Write("\nNumber of Steps: ");
        int numSteps = int.Parse(Console.ReadLine());

        // Create an array to store steps
        string[] steps = new string[numSteps];

        // Prompt user to enter recipe instruction steps
        Console.WriteLine("Enter the instruction steps");
        for(int i = 0; i < numSteps; i++)
        {
            Console.Write(i + 1 + ": ");
            steps[i] = Console.ReadLine();
        }

        // Create a new Recipe object with capture deails
        recipe = new Recipe(name, ingredients, steps);

        // Notify user that recipe has been added
        Console.WriteLine("Recipe added successfully!");
    }

    // Method to view the current recipe
    public void ViewRecipe()
    {
        if(recipe == null)
        {
            // Notify user if no recipe is available
            Console.WriteLine("No recipe available");
            return;
        }

        Console.WriteLine("______________________________________________");
        
        // Display Recipe name
        Console.WriteLine("\nName:" + recipe.name);

        // Display ingredients name, quantity and unit with numbering
        Console.WriteLine("\nIngredients:\n");
        Console.WriteLine("{0, -2} {1, -10} {2, -10} {3, -10}","No.", "Name", "Quantity", "Unit");
        for (int i = 0; i < recipe.ingredients.Length; i++)
        {
            Console.WriteLine("{0, -2} {1, -10} {2, -10} {3, -10}", (i+ 1), recipe.ingredients[i].name, recipe.ingredients[i].quantity, recipe.ingredients[i].unit);
        }

        // Display steps with numbering
        Console.WriteLine("\nSteps:\n");
        for(int i = 0; i< recipe.steps.Length; i++) 
        {
            Console.WriteLine(i+1 + ". " + recipe.steps[i]);
        }
        Console.WriteLine("----------------------------------------------");
    }

    public void ScaleRecipe()
    {
        Console.WriteLine("Scale Menu:");
        Console.WriteLine("A. 1/2 Half");
        Console.WriteLine("B. 2 Double");
        Console.WriteLine("C. 3 Triple");
        Console.WriteLine("D. Reset Scale");

        // Prompt user to enter new scale value
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        
        switch(choice)
        {
            case "A":
                ratio = 0.5;
                break;
            case "B":
                ratio = 2;
                break;
            case "C":
                ratio = 3;
                break;
            case "D":
                ratio = 1;
                break;
            
        }
        // Notify user that the scale has been updated
        Console.WriteLine("Recipe scale updated");

    }
}


// Main program
class Program
{
    static void Main(String[] args)
    {
        // Create an instance of RecipeApp
        RecipeApp recipeApp = new RecipeApp();
        
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

                    recipeApp.AddRecipe();
                    break;
                case "2":
                    // Call ViewRecipe method when user chooses option 2

                    recipeApp.ViewRecipe();
                    break;
                case "3":
                    // Call ScaleRecipe method when user chooses option 3

                    recipeApp.ScaleRecipe();
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