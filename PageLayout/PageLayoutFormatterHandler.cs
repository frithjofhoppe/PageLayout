using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageLayout
{
    public class PageLayoutFormatterHandler
    {
        private List<String> RawContent { get; set; }
        private List<String> FormattedContent { get; set; }
        private int WidthInChars { get; set; }
        public PageLayoutFormatterHandler(int widthInChars)
        {
            if(widthInChars < 1)
            {
                throw new ArgumentException();
            }

            FormattedContent = new List<String>(); 
            WidthInChars = widthInChars;
        }

        public PageLayoutFormatterHandler(IContentInput input, int widthInChars) : this(widthInChars)
        { 
            if (input.InputContent().Count < 1)
            {
                throw new ArgumentException();
            }
            RawContent = input.InputContent();
        }

        public PageLayoutFormatterHandler(List<String> input, int widthInChars) : this(widthInChars)
        {
            if (input.Count < 1)
            {
                throw new ArgumentException();
            }
            RawContent = input;
        }

        public List<String> FomrattedContent()
        {
            FormatProcess();
            return FormattedContent;
        }

        private void FormatProcess()
        {
            ContentFormatter contentFormatter = new ContentFormatter(RawContent, WidthInChars);
            FormattedContent = contentFormatter.Formatted;
        }
    }
}
