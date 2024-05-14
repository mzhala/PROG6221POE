using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG6221POE
{
    public class RecipeApp
    {
        private List<Recipe> recipes;
        private double ratio = 1;

        public RecipeApp()
        {
            recipes = new List<Recipe>();

            // Example: Adding a default recipe
            List<Ingredient> ingredients = new List<Ingredient>
            {
                new Ingredient("Egg", 1, "large"),
                new Ingredient("Butter", 1, "Teaspoon"),
                new Ingredient("Pepper", 1, "Teaspoon"),
                new Ingredient("Salt", 1, "Pinch")
            };

            List<Step> steps = new List<Step>
            {
                new Step("Preheat pan"),
                new Step("In a bowl combine and mix eggs, salt and pepper."),
                new Step("Pour batter into a greased pan."),
                new Step("Cook for 3 minutes, or until cooked.")
            };
            Recipe defaultRecipe = new Recipe("Scrambled Egg", ingredients, steps);
            recipes.Add(defaultRecipe);
        }

        public void AddRecipe()
        {
            Console.WriteLine("Enter Recipe Details:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            int numIngredients;
            while (true)
            {
                Console.Write("Number of Ingredients: ");
                if (int.TryParse(Console.ReadLine(), out numIngredients) && numIngredients > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            List<Ingredient> ingredients = new List<Ingredient>();
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"\nEnter details for Ingredient {i + 1}");

                Console.Write("Name: ");
                string ingredientName = Console.ReadLine();

                float quantity;
                while (true)
                {
                    Console.Write("Quantity: ");
                    if (float.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                        break;
                    else
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.Write("Unit: ");
                string unit = Console.ReadLine();

                ingredients.Add(new Ingredient(ingredientName, quantity, unit));
            }

            int numSteps;
            while (true)
            {
                Console.Write("\nNumber of Steps: ");
                if (int.TryParse(Console.ReadLine(), out numSteps) && numSteps > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            List<Step> steps = new List<Step>();
            Console.WriteLine("Enter the instruction steps");
            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"{i + 1}: ");
                string description = Console.ReadLine();
                steps.Add(new Step(description));
            }

            Recipe newRecipe = new Recipe(name, ingredients, steps);
            recipes.Add(newRecipe);

            Console.WriteLine("Recipe added successfully!");
        }

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
                Console.WriteLine($"{k + 1}. {recipes[k].Name}");
            }

            bool inputOk = false;
            int i = 0;
            while (!inputOk)
            {
                try
                {
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

            Console.WriteLine("Name:" + recipes[i].Name);

            Console.WriteLine("\nIngredients:");
            Console.WriteLine("{0, -5} {1, -10} {2, -10} {3, -10}", "No.", "Name", "Quantity", "Unit");
            foreach (var ingredient in recipes[i].Ingredients)
            {
                Console.WriteLine("{0, -5} {1, -10} {2, -10} {3, -10}", (recipes[i].Ingredients.IndexOf(ingredient) + 1), ingredient.Name, ingredient.Quantity * ratio, ingredient.Unit);
            }

            Console.WriteLine("\nSteps:");
            foreach (var step in recipes[i].Steps)
            {
                Console.WriteLine($"{recipes[i].Steps.IndexOf(step) + 1}. {step.Instruction}");
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
            Console.WriteLine("Recipe scale updated!");

        }

        public void RemoveRecipe()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available to remove.");
                return;
            }

            Console.WriteLine("Select a recipe to remove:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].Name}");
            }

            int index;
            while (true)
            {
                Console.Write("Enter the number corresponding to the recipe to remove: ");
                if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= recipes.Count)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Recipe removedRecipe = recipes[index - 1];
            recipes.RemoveAt(index - 1);

            Console.WriteLine($"Recipe '{removedRecipe.Name}' removed successfully!");
        }
    }
}
