using PROG6221POE;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of RecipeApp
        PROG6221POE.RecipeApp recipeApp = new PROG6221POE.RecipeApp();

        // Create an object of FoodGroups
        FoodGroups foodGroups = new FoodGroups();

        // Main loop of the program
        string choice = "";
        while (choice != "5")
        {
            // Set the Foreground color to DarkMagenta 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-----------------------------");
            // Reset the Foreground color to white 
            Console.ForegroundColor = ConsoleColor.White;

            // Display menu options
            Console.WriteLine("Dine.Me Menu");
            // Set the Foreground color to DarkMagenta 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-----------------------------");
            // Reset the Foreground color to white 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. View Recipes");
            Console.WriteLine("3. Scale Recipe");
            Console.WriteLine("4. Remove Recipe");
            Console.WriteLine("5. Food Group Details");
            Console.WriteLine("6. Calorie Counting Basicss");
            Console.WriteLine("7. Exit");

            // Set the Foreground color to DarkMagenta 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Read user choice from input
            Console.WriteLine("_____________________________");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();
            //Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            // Reset the Foreground color to white 
            Console.ForegroundColor = ConsoleColor.White;
            
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
                    // Call DisplayAllFoodGroupDetails method when user chooses option 5
                    foodGroups.DisplayAllFoodGroupDetails();
                    break;
                case "6":
                    // Call DisplayCalorieCountingGuide method when user chooses option 6
                    DisplayCalorieCountingGuide();
                    break;
                case "7":
                    // Exit the program when the user chooses option 7
                    Environment.Exit(0);
                    break;
                default:
                    // Display message for invalid input
                    Console.WriteLine("Invalid choice. please try again");
                    break;
            }
        }
    }

    static void DisplayCalorieCountingGuide()
    {
        Console.WriteLine("## Calorie Counting Basics ##\n");

        Console.WriteLine("### What Are Calories? ###\n");
        Console.WriteLine("Calories are units of energy found in food and beverages. They are essential for fueling our bodies and performing daily activities.\n");

        Console.WriteLine("### Expected Calorie Consumption ###\n");
        Console.WriteLine("The recommended daily calorie intake varies based on factors such as age, gender, weight, height, and activity level.\n");

        Console.WriteLine("For adult males:");
        Console.WriteLine("- The average daily calorie intake is around 2,500 calories for maintaining weight.");
        Console.WriteLine("- To lose weight, calorie intake may be reduced to 2,000 calories per day.");
        Console.WriteLine("- To gain weight or build muscle, calorie intake may be increased to 3,000 calories or more per day.\n");

        Console.WriteLine("For adult females:");
        Console.WriteLine("- The average daily calorie intake is around 2,000 calories for maintaining weight.");
        Console.WriteLine("- To lose weight, calorie intake may be reduced to 1,500 calories per day.");
        Console.WriteLine("- To gain weight or build muscle, calorie intake may be increased to 2,500 calories or more per day.\n");

        Console.WriteLine("It's important to consult with a healthcare professional or registered dietitian for personalized nutrition advice based on individual needs and goals.\n");

    }
}
