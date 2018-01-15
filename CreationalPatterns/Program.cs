using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new GucciFactory();
            var bag = factory.CreateBag();
            var shoes = factory.CreateShoes();
            Console.WriteLine("Bag material is {0}, and shoes material is {1}", bag.Material, shoes.Price);
            Console.ReadLine();
        }
    }
}
