using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    class PageBuilder : IPageBuilder
    {
        private string page = string.Empty;

        public IPageBuilder BuildHeader(string header)
        {
            page += header + Environment.NewLine;
            return this;
        }

        public IPageBuilder BuildMenu(string menu)
        {
            page += menu + Environment.NewLine;
            return this;
        }

        public IPageBuilder BuildContent(string content)
        {
            page += content + Environment.NewLine;
            return this;
        }

        public IPageBuilder BuildFooter(string footer)
        {
            page += footer + Environment.NewLine;
            return this;
        }

        public string GetPage()
        {
            return page;
        }
    }
}
