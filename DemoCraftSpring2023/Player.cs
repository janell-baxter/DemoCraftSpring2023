using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCraftSpring2023
{
    public class Player
    {
        string name;

        public string Name { get => name; set => name = value; }
        public List<Item> Inventory = new List<Item>();

        public Player(string _name)
        {
            name = _name;
        }
        public Player ()
        {

        }

        public ConsoleColor textColor;

        public string ShowInventoryItems()
        {
            string output = $"Inventory items for {Name}:\n";
            foreach(Item i in Inventory)
            {
                output += $"{i.Name}{Environment.NewLine}";
            }

            return output;
        }
    }
}