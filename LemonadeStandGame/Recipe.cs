﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Recipe
    {
        public int[] ingredients;
        public Recipe()
        {
            ingredients = new int[3]; //#Lemons, #Sugar, #Ice,
        }
        public void GetNumberOfLemons()
        {
            Console.WriteLine("Enter how many lemons...");
            ingredients[0] = GetInput();
        }
        public void GetTablespoonsOfSugar()
        {
            Console.WriteLine("Enter how many tablespoons of sugar...");
            ingredients[1] = GetInput();
        }
        public void GetCupsOfIce()
        {
            Console.WriteLine("Enter how many cups of ice...");
            ingredients[2] = GetInput();
        }
        private int GetInput()
        {
            int userInput;
            if (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("*Invalid Number*\nEnter valid number below...");
                return GetInput();
            }
            else if(userInput == 0)
            {
                Console.WriteLine("*Must have at least 1 of each ingredient*\nEnter valid number below...");
                return GetInput();
            }
            return userInput;
        }
    }
}