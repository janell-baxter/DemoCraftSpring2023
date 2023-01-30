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
        Player player = new Player() {Name="janell", textColor= ConsoleColor.Magenta };
        Player player1 = new Player() { Name = "Duncan", textColor = ConsoleColor.DarkGreen };
        
        CraftingTable craftingtable;

        public void Play()
        {
            double price = 3.4567;

            Print("Hello world"); //setting up for a delegate later
            Print("Hello " + player.Name); //concatenation
            Console.WriteLine("Hello {0}", player.Name); //composite
            Print($"Hello {player.Name}"); //interpolation

            Print($"I paid {price.ToString("c")} for this coffee");
            Print($"My name is {player.Name}", player);
            Print($"My name is {player1.Name}", player1);

            if (ConvertLowerCase("HHello") == "hhello")
            {

            }
            Console.ReadKey();
          

        }

        //public string ConvertLowerCase(string message)
        //{
        //    return message.ToLower();
        //}
        public string ConvertLowerCase(string message) => message.ToLower();
        private bool SearchText(string text, string searchTerm)
        {
            if (text.Contains(searchTerm))
            {
                return true;
            }
            return false;
        }

    }
}
