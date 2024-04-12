using System;

// RecipeApp class managing the recipe application
public class RecipeApp
{
    // Object to store the current Recipe
    private Recipe recipe;

    // Ratio value with default value 1
    double ratio = 1;

    // Constructor to initialize RecipeApp
    public RecipeApp()
    {
        // Initialize recipe with a simple default recipe
        Ingredient[] ingredients = new Ingredient[]
        {
            new Ingredient("Egg", 1, "units"),
            new Ingredient("Butter", 1, "Teaspoon"),
            new Ingredient("Pepper", 1, "units"),
            new Ingredient("Salt", 1, "Pinch")
        };

        Step[] steps = new Step[]
        {
            new Step("Preheat pan"),
            new Step("In a bowl combine and mix eggs, salt and pepper."),
            new Step("Pour batter into a greased pan."),
            new Step("Cook for 3 minutes, or until cooked.")
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

        // Declare and initialize numIngredients
        int numIngredients = 0;

        // Prompt user to enter number of ingredients and validate the input
        Boolean inputOk = false;
        while (inputOk == false)
        {
            try
            {
                // Prompt user to enter number of ingredient
                Console.Write("Number of Ingredients: ");
                numIngredients = int.Parse(Console.ReadLine());
                inputOk = true;
            }
            catch
            {
                Console.WriteLine("Invalid input, Please enter numeric value");
            }
        }

        // Create an array to store ingredients
        Ingredient[] ingredients = new Ingredient[numIngredients];

        for (int i = 0; i < numIngredients; i++)
        {
            // Prompt user to enter details for ingredient
            Console.WriteLine("\nEnter details for Ingredient " + (i + 1));

            // Prompt user to enter ingredient name
            Console.Write("Name: ");
            string ingredientName = Console.ReadLine();

            // Declare and initialize ingredient quantity
            float quantity = 0;

            // Prompt user to enter quantity of ingredient and validate the input
            inputOk = false;
            while (inputOk == false)
            {
                try
                {
                    // Prompt user to enter ingredient quantity
                    Console.Write("Quantity: ");
                    quantity = float.Parse(Console.ReadLine());
                    inputOk = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input, Please enter numeric value");
                }
            }

            // Prompt user to enter ingredient unit
            Console.Write("Unit: ");
            string unit = Console.ReadLine();

            // Create and add new Ingredient object to the array
            ingredients[i] = new Ingredient(ingredientName, quantity, unit);
        }

        // Declare and initialize number of steps
        int numSteps = 0;

        // Prompt user to enter int numSteps and validate the input
        inputOk = false;
        while (inputOk == false)
        {
            try
            {
                // Prompt user to enter number of steps
                Console.Write("\nNumber of Steps: ");
                numSteps = int.Parse(Console.ReadLine());
                inputOk = true;
            }
            catch
            {
                Console.WriteLine("Invalid input, Please enter numeric value");
            }
        }


        // Create an array to store steps
        Step[] steps = new Step[numSteps];

        // Prompt user to enter recipe instruction steps
        Console.WriteLine("Enter the instruction steps");
        string description = "";
        for (int i = 0; i < numSteps; i++)
        {
            Console.Write(i + 1 + ": ");
            description = Console.ReadLine();

            steps[i] = new Step(description);
        }

        // Create a new Recipe object with capture details
        recipe = new Recipe(name, ingredients, steps);

        // Notify user that recipe has been added
        Console.WriteLine("Recipe added successfully!");
    }

    // Method to view the current recipe
    public void ViewRecipe()
    {
        if (recipe == null)
        {
            // Notify user if no recipe is available
            Console.WriteLine("No recipe available");
            return;
        }

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Recipe Details");
        Console.WriteLine("----------------------------------------------");
        // Display Recipe name
        Console.WriteLine("\nName:" + recipe.Name);

        // Display ingredients name, quantity and unit with numbering
        Console.WriteLine("\nIngredients:\n");
        Console.WriteLine("{0, -5} {1, -10} {2, -10} {3, -10}", "No.", "Name", "Quantity", "Unit");
        for (int i = 0; i < recipe.Ingredients.Length; i++)
        {
            Console.WriteLine("{0, -5} {1, -10} {2, -10} {3, -10}", (i + 1), recipe.Ingredients[i].Name, recipe.Ingredients[i].Quantity * ratio, recipe.Ingredients[i].Unit);
        }

        // Display steps with numbering
        Console.WriteLine("\nSteps:\n");
        for (int i = 0; i < recipe.Steps.Length; i++)
        {
            Console.WriteLine(i + 1 + ". " + recipe.Steps[i].Description);
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
        // Remove the recipe
        recipe = null;

        // Notify user that recipe has been removed
        Console.WriteLine("Recipe removed successfully!");
    }
}
