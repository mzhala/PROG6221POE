using System;

// Base class representing a food item
namespace PROG6221POE
{
    public class FoodItem
    {
        public string name { get; set; }
        public float quantity { get; set; }
        public string unit { get; set; }

        // Constructor for the FoodItem class.
        public FoodItem(string name, float quantity, string unit)
        {
            this.name = name;
            this.quantity = quantity;
            this.unit = unit;
        }
    }
}