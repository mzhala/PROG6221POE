using System;

// Base class representing a food item
public class FoodItem
{
    public string Name { get; set; }
    public float Quantity { get; set; }
    public string Unit { get; set; }

    // Constructor for the FoodItem class.
    public FoodItem(string name, float quantity, string unit)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
    }
}

// Derived class representing an ingredient
public class Ingredient : FoodItem
{
    // Constructor for the Ingredient class.
    public Ingredient(string name, float quantity, string unit) : base(name, quantity, unit) { }
}
