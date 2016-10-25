﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Game
    {
        UserInterface output = new UserInterface();
        Player player = new Player();
        Day day;
        int currentDay = 0;

        public void ExecuteStartOfGame()
        {
            ExecuteGameWelcome();
            player.GetPlayerName();

            while (currentDay < 8)
            {
                day = new Day(player);
                day.ExecuteDay();
                currentDay++;
            }
        }
        private void ExecuteGameWelcome()
        {
            output.DisplayMenuMessage();
            output.AddSpace();
            output.DisplayMenuNewGame();
            GetUserInput();
            output.AddSpace();
            output.DisplayMenuNumberOfPeople();
            GetUserInput();
            output.ClearScreen();
            output.DisplayMenuInstructions();
            output.AddSpace();
            output.DisplayContinueOrExit();
            GetUserInput();
            output.ClearScreen();
        }
        private string GetUserInput()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
