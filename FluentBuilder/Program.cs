using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PageBuilder();

            var page = builder.BuildHeader("head")
                .BuildMenu("menu")
                .BuildFooter("footer")
                .BuildContent("content").GetPage();

            Console.WriteLine(page);
            Console.ReadLine();
        }
    }
}
