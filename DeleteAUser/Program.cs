using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteAUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Username you want to Delete:");
            string name = Console.ReadLine();
            Console.WriteLine($"given username, {name}!");
            Console.ReadKey(); // Waits for a key press before closing the console
        }
    }
}
