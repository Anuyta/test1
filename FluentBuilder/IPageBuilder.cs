using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public interface IPageBuilder
    {
        IPageBuilder BuildHeader(string headers);

        IPageBuilder BuildMenu(string menu);

        IPageBuilder BuildContent(string content);

        IPageBuilder BuildFooter(string footer);

        string GetPage(); //result method
    }
}
