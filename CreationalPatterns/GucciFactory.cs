using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class GucciFactory : IFactory
    {
        public IBag CreateBag()
        {
            return new GucciBag();
        }

        public IShoes CreateShoes()
        {
            return new GucciShoes();
        }
    }
}
