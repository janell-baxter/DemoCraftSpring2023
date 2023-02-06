using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DemoCraftSpring2023.Utility;

namespace DemoCraftSpring2023
{
    internal class Engine
    {
        Player playerOne = new Player() {Name="janell", textColor= ConsoleColor.Magenta };
        Player playerTwo = new Player() { Name = "Duncan", textColor = ConsoleColor.DarkGreen };
        
        CraftingTable craftingtable;

        private void SetUpPlayers()
        {
            playerOne.Name = LoadTextFromTextFile("../../../data/playerOneName.txt");
            playerTwo.Name = LoadTextFromTextFile("../../../data/playerTwoName.txt");

            //load inventory items from file
            playerOne.Inventory = LoadItemsFromTextFile("../../../data/playerInventory.txt");
            playerTwo.Inventory = LoadItemsFromTextFile("../../../data/playerInventory.txt");
        }

        public void Play()
        {
            SetUpPlayers();
            double price = 3.4567;

            Print("Hello world"); //setting up for a delegate later
            Print("Hello " + playerOne.Name); //concatenation
            Console.WriteLine("Hello {0}", playerOne.Name); //composite
            Print($"Hello {playerOne.Name}"); //interpolation

            Print($"I paid {price.ToString("c")} for this coffee");
            Print($"My name is {playerOne.Name}", playerOne);
            Print($"My name is {playerTwo.Name}", playerTwo);

            Print(playerOne.ShowInventoryItems());
            Print(playerTwo.ShowInventoryItems());

            Console.ReadKey();

            Print();

        }

      

    }
}
