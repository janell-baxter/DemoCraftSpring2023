using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoCraftSpring2023
{
    internal class Utility
    {
        public static Random randomNumber = new Random();
        public int GetRandomNumber(int Max) => randomNumber.Next(Max);
        public int GetRandomNumber(int Min, int Max) => randomNumber.Next(Min, Max);

        public static void Print()
        {
            Console.WriteLine(Environment.NewLine);
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Print(message);
        }

        public static void Print(string message, Player player)
        {
            Console.ForegroundColor = player.textColor;
            Print(message);
        }
    }
}
