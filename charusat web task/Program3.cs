using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridingtostring
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your product name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your product price");
            float price = float.Parse(Console.ReadLine());

            product p1 = new product(name, price);
            Console.WriteLine(p1.ToString());
            Console.ReadKey();
        }
    }
}
