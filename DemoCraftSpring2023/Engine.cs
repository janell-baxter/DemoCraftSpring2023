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
        Player player = new Player() {Name="janell" };
        
        CraftingTable craftingtable;

        public void Play()
        {
            double price = 3.4567;

            Print("Hello world"); //setting up for a delegate later
            Print("Hello " + player.Name); //concatenation
            Console.WriteLine("Hello {0}", player.Name); //composite
            Print($"Hello {player.Name}"); //interpolation

            Print($"I paid {price.ToString("c")} for this coffee");

            Console.ReadKey();
          

        }
    }
}
