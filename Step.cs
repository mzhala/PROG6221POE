using System;

namespace PROG6221POE
{
    public class Step : RecipeItem
    {
        public string Instruction { get; set; }

        // Constructor for the Step class.
        public Step(string instruction) : base(instruction)
        {
            Instruction = instruction;
        }
    }
}
