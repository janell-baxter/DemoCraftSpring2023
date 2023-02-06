using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

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
        public static string LoadTextFromTextFile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }

            return "Data was not found";
        }

        public static List<Item> LoadItemsFromTextFile(string path)
        {
            List<Item> items = new List<Item>();
            

            if (File.Exists(path))
            {
                string[] itemNames = File.ReadAllLines(path);
                foreach (string s in itemNames)
                {
                    items.Add(new Item() {Name = s });
                }
            }


            return items;
        }
    }
}
