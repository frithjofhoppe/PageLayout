using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PageLayout;

namespace PageLayoutFormatterHandlerTest
{
    [TestFixture]
    public class PositivTest
    {
        [TestCase]
        public void FormatProcess_WidthValidInput_ReturnValue()
        {
            List<String> rawContent = new List<String>();
            rawContent.Add("word");
            PageLayoutFormatterHandler handler = new PageLayoutFormatterHandler(rawContent, 5);

            Assert.Greater(handler.FomrattedContent().Count, 0);
        }
    }
}
