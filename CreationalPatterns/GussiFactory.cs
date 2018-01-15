using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class GussiFactory : IFactory
    {
        public IBag CreateBag()
        {
            return new GussiBag();
        }

        public IShoes CreateShoes()
        {
            return new GussiShoes();
        }
    }
}
