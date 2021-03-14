using System;
using System.Threading.Tasks;

namespace Async_Example
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Tea.MakeTea();
        //}
        async static Task Main(string[] args)
        {
            TeaAsync tea = new TeaAsync();
           await tea.MakeTea();
        }
    }
}
