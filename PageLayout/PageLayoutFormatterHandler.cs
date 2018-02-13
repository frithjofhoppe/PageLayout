using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageLayout
{
    public class PageLayoutFormatterHandler
    {
        private List<String> _rawContent { get; set; }
        private List<String> _formattedContent { get; set; }
        private int _widthInChars { get; set; }
        public PageLayoutFormatterHandler(int widthInChars)
        {
            if(widthInChars < 1)
            {
                throw new ArgumentException();
            }

            _formattedContent = new List<String>(); 
            _widthInChars = widthInChars;
        }

        public PageLayoutFormatterHandler(IContentInput input, int widthInChars) : this(widthInChars)
        { 
            if (input.InputContent().Count < 1)
            {
                throw new ArgumentException();
            }
            _rawContent = input.InputContent();
        }

        public PageLayoutFormatterHandler(List<String> input, int widthInChars) : this(widthInChars)
        {
            if (input.Count < 1)
            {
                throw new ArgumentException();
            }
            _rawContent = input;
        }

        public List<String> FomrattedContent()
        {
            FormatProcess();
            return _formattedContent;
        }

        private void FormatProcess()
        {
            ContentFormatter contentFormatter = new ContentFormatter(_rawContent, _widthInChars);
            _formattedContent = contentFormatter._formatted;
        }
    }
}
