using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
namespace PROG6221POE
{
    public class RecipeApp
    {
        // List to store multiple recipes
        private List<Recipe> recipes;
        private double ratio = 1;

        // Constructor to initialize RecipeApp
        public RecipeApp()
        {
            // Initialize the list of recipes
            recipes = new List<Recipe>();

            // Example: Adding a default recipe
            Ingredient[] ingredients = new Ingredient[]
            {
            new Ingredient("Egg", 1, "large"),
            new Ingredient("Butter", 1, "Teaspoon"),
            new Ingredient("Pepper", 1, "Teaspoon"),
            new Ingredient("Salt", 1, "Pinch")
            };

            Step[] steps = new Step[]
            {
            new Step("Preheat pan"),
            new Step("In a bowl combine and mix eggs, salt and pepper."),
            new Step("Pour batter into a greased pan."),
            new Step("Cook for 3 minutes, or until cooked.")
            };
            Recipe defaultRecipe = new Recipe("Scrambled Egg", ingredients, steps);
            recipes.Add(defaultRecipe);
        }

        // Method to add a recipe
        public void AddRecipe()
        {
            // Prompt user to enter recipe details
            Console.WriteLine("Enter Recipe Details:");

            // Prompt user to enter recipe name
            Console.Write("Name: ");
            string name = Console.ReadLine();

            // Prompt user to enter number of ingredients and validate the input
            int numIngredients;
            while (true)
            {
                Console.Write("Number of Ingredients: ");
                if (int.TryParse(Console.ReadLine(), out numIngredients) && numIngredients > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Create an array to store ingredients
            Ingredient[] ingredients = new Ingredient[numIngredients];

            // Prompt user to enter ingredient details
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"\nEnter details for Ingredient {i + 1}");

                // Prompt user to enter ingredient name
                Console.Write("Name: ");
                string ingredientName = Console.ReadLine();

                // Prompt user to enter ingredient quantity
                float quantity;
                while (true)
                {
                    Console.Write("Quantity: ");
                    if (float.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                        break;
                    else
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                // Prompt user to enter ingredient unit
                Console.Write("Unit: ");
                string unit = Console.ReadLine();

                // Create and add new Ingredient object to the array
                ingredients[i] = new Ingredient(ingredientName, quantity, unit);
            }

            // Prompt user to enter number of steps and validate the input
            int numSteps;
            while (true)
            {
                Console.Write("\nNumber of Steps: ");
                if (int.TryParse(Console.ReadLine(), out numSteps) && numSteps > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Create an array to store steps
            Step[] steps = new Step[numSteps];

            // Prompt user to enter recipe instruction steps
            Console.WriteLine("Enter the instruction steps");
            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"{i + 1}: ");
                string description = Console.ReadLine();
                steps[i] = new Step(description);
            }

            // Create a new Recipe object and add it to the list of recipes
            Recipe newRecipe = new Recipe(name, ingredients, steps);
            recipes.Add(newRecipe);

            // Notify user that the recipe has been added
            Console.WriteLine("Recipe added successfully!");
        }

        // Method to view recipes
        public void ViewRecipes()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available");
                return;
            }

            Console.WriteLine("Recipes:");
            for (int k = 0; k < recipes.Count; k++)
            {
                Console.WriteLine($"{k + 1}. {recipes[k].name}");
            }

            // Prompt user to enter recipe to view
            Boolean inputOk = false;
            int i = 0;
            while (inputOk == false)
            {
                try
                {
                    // Prompt user to enter number recipe
                    Console.Write("\nEnter the number corresponding to the recipe to view: ");
                    i = int.Parse(Console.ReadLine());
                    if (i > 0 && i <= recipes.Count)
                        inputOk = true;
                    else
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            }
            i -= 1;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Recipe Details\n");
            // Display Recipe name
            Console.WriteLine("Name:" + recipes[i].name);

            // Display ingredients name, quantity and unit with numbering
            Console.WriteLine("\nIngredients:");
            Console.WriteLine("{0, -5} {1, -10} {2, -10} {3, -10}", "No.", "Name", "Quantity", "Unit");
            for (int k = 0; k < recipes[i].ingredients.Length; k++)
            {
                Console.WriteLine("{0, -5} {1, -10} {2, -10} {3, -10}", (k + 1), recipes[i].ingredients[k].name, recipes[i].ingredients[k].quantity * ratio, recipes[i].ingredients[k].unit);
            }

            // Display steps with numbering
            Console.WriteLine("\nSteps:");
            for (int k = 0; k < recipes[i].steps.Length; k++)
            {
                Console.WriteLine(k + 1 + ". " + recipes[i].steps[k].description);
            }
            Console.WriteLine("----------------------------------------------");

        }

        // Method to change the recipe scale
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
            Console.WriteLine("");
            switch (choice.ToUpper())
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
                default:
                    Console.WriteLine("Invalid Choice!");
                    return;
            }
            // Notify user that the scale has been updated
            Console.WriteLine("Recipe scale updated!");

        }

        // Method to remove the recipe
        public void RemoveRecipe()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available to remove.");
                return;
            }

            // Display the list of recipes to the user
            Console.WriteLine("Select a recipe to remove:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].name}");
            }

            // Prompt the user to enter the index of the recipe to remove
            int index;
            while (true)
            {
                Console.Write("Enter the number corresponding to the recipe to remove: ");
                if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= recipes.Count)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Remove the selected recipe from the list
            Recipe removedRecipe = recipes[index - 1];
            recipes.RemoveAt(index - 1);

            // Notify the user that the recipe has been removed
            Console.WriteLine($"Recipe '{removedRecipe.name}' removed successfully!");
        }
    }
}