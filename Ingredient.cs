using System;

// Derived class representing an ingredient
public class Ingredient : FoodItem
{
    // Constructor for the Ingredient class.
    public Ingredient(string name, float quantity, string unit) : base(name, quantity, unit) { }
}
