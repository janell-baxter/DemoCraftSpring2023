using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCraftSpring2023
{
    public class Item
    {
        private string name;
        private double amount;

        public string Name { get => name; set => name = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}