using System;
using System.Collections.Generic;
using System.Text;

namespace Async_Example
{
    public static class Tea
    {
        public static void MakeTea()
        {
            Console.WriteLine("Take Cups out from Cabinet ! ");
            Console.WriteLine("Put Raw Tea into the Cups ! ");
            var bw = BoilWater();
            Console.WriteLine("Close Cabinet ! and Wait for The Boiled Water");
            Console.WriteLine($"Put {bw} into the cups ");
            Console.WriteLine("Drink Tea :) ");
        }
        public static string BoilWater()
        {
            Console.WriteLine("Make the oven on !");
            Console.WriteLine("put the kettle on the oven ! and wait ....");
            return "boiled water";
        }
    }
}
