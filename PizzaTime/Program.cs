using System;

namespace PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process.Start("https://bestellen.dominos.nl/estore/nl/Home?redirectTo=delivery");
            Environment.Exit(0);
        }
    }
}
