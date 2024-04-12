using System;

// Base class representing an item in a recipe
public class RecipeItem
{
    public string description { get; set; }

    // Constructor for the RecipeItem class.
    public RecipeItem(string description)
    {
        this.description = description;
    }
}

