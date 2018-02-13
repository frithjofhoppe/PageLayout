using System;
using PageLayout;
using NUnit.Framework;
using System.Collections.Generic;

namespace PageLayoutFormatterHandlerTest
{
    [TestFixture]
    public class NegativTest
    {
        [TestCase]
        public void FormatProcess_WithNegativLessThanOne_ThrowsArgumentExceptions()
        {
            PageLayoutFormatterHandler handler;
            List<String> rawContent = new List<String>();
            rawContent.Add("word");

            Assert.Throws<ArgumentException>(() => { handler = new PageLayoutFormatterHandler(rawContent, 0); });
        }

        [TestCase]
        public void FormatProcess_WidthInvalidContent_ThrowsInvalidContentException()
        {
            PageLayoutFormatterHandler handler;
            List<String> rawContent = new List<String>();

            Assert.Throws<ArgumentException>(() => { handler = new PageLayoutFormatterHandler(rawContent, 2); });
        }
    }
}
