using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class GucciBag : IBag
    {
        public string Material
        {
            get { return "Crocodial skin"; }
        }
    }
}
