using System;

// Base class representing an item in a recipe
public class RecipeItem
{
    public string Description { get; set; }

    // Constructor for the RecipeItem class.
    public RecipeItem(string description)
    {
        Description = description;
    }
}

// Derived class representing a step in a recipe
public class Step : RecipeItem
{
    // Constructor for the Step class.
    public Step(string description) : base(description) { }
}
