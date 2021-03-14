using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Async_Example
{
    public class TeaAsync
    {
        public async Task MakeTea()
        {
            Console.WriteLine("Take Cups out from Cabinet ! ");
            Console.WriteLine("Put Raw Tea into the Cups ! ");
            var bw = await BoilWater();
            Console.WriteLine("Close Cabinet ! and Wait for The Boiled Water");
            Console.WriteLine($"Put {bw} into the cups ");
            Console.WriteLine("Drink Tea :) ");
        }
        public async Task<string> BoilWater()
        {
            Console.WriteLine("Make the oven on !");
            Console.WriteLine("put the kettle on the oven ! and wait ....");
            await Task.Delay(5000);
            return "boiled water";
        }
    }
}
