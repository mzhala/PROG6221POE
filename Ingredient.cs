﻿using System;

// Derived class representing an ingredient
namespace PROG6221POE
{
    public class Ingredient : FoodItem
    {
        public int CalorieCount { get; set; } // New property
        public int FoodGroupIndex { get; set; } // New property

        // Constructor for the Ingredient class.
        public Ingredient(string name, float quantity, string unit, int calorieCount, int foodGroupIndex) : base(name, quantity, unit)
        {
            CalorieCount = calorieCount;
            FoodGroupIndex = foodGroupIndex;
        }
    }
}
