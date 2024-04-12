using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of RecipeApp
        RecipeApp recipeApp = new RecipeApp();

        // Main loop of the program
        string choice = "";
        while (choice != "5")
        {
            // Display menu options
            Console.WriteLine("\nDine.Me Menu");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. View Recipes");
            Console.WriteLine("3. Scale Recipe");
            Console.WriteLine("4. Remove Recipe");
            Console.WriteLine("5. Exit");

            //Read user choice from input
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();
            Console.WriteLine("");
            switch (choice)
            {
                case "1":
                    // Call AddRecipe method when user chooses option 1
                    recipeApp.AddRecipe();
                    break;
                case "2":
                    // Call ViewRecipes method when user chooses option 2
                    recipeApp.ViewRecipes();
                    break;
                case "3":
                    // Call ScaleRecipe method when user chooses option 3
                    recipeApp.ScaleRecipe();
                    break;
                case "4":
                    // Call RemoveRecipe method when user chooses option 4
                    recipeApp.RemoveRecipe();
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
