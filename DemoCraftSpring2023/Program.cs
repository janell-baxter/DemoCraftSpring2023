using System;
using static System.Console;

namespace DemoCraftSpring2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "Crafting Demo!";
            WriteLine("Hello, World!");
            Engine engine = new Engine();
            engine.Play();

        }
    }
}