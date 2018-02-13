using System;
using System.Collections.Generic;
using NUnit.Framework;
using PageLayout;

namespace ContentFormatterTest
{
    [TestFixture]
    public class PositivTest
    {
        [TestCase]
        public void ContentFormat_WidthSingleLineContent_ReturnValidFormatting()
        {
            bool hasTestFailed = false;
            List<String> rawContent = new List<String>();
            rawContent.Add("Lorem ipsum\n");
            rawContent.Add("consetetur");

            List<String> definedContent = new List<String>();
            definedContent.Add("Lorem");
            definedContent.Add("ipsum");
            definedContent.Add("consetetur");

            ContentFormatter contentFormatter = new ContentFormatter(rawContent, 4);
            List<String> result = contentFormatter._formatted;
            for (int i = 0; i < definedContent.Count; i++)
            {
                if (definedContent[i] != result[i])
                {
                    hasTestFailed = true;
                }
            }
            Assert.AreEqual(hasTestFailed, false);
        }

        [TestCase]
        public void ContentFormat_WidthSingleMultiLine_ReturnValidFormatting()
        {
            bool hasTestFailed = false;
            List<String> rawContent = new List<String>();
            rawContent.Add("Lorem ipsum\n");
            rawContent.Add("consetetur");

            List<String> definedContent = new List<String>();
            definedContent.Add("Lorem ipsum");
            definedContent.Add("consetetur");

            ContentFormatter contentFormatter = new ContentFormatter(rawContent, 11);
            List<String> result = contentFormatter._formatted;
            for (int i = 0; i < definedContent.Count; i++)
            {
                if (definedContent[i] != result[i])
                {
                    hasTestFailed = true;
                }
            }
            Assert.AreEqual(hasTestFailed, false);
        }

        [TestCase]
        public void ContentFormat_WidthLineWidthGreaterTheanContent_ReturnValidFormatting()
        {
            bool hasTestFailed = false;
            List<String> rawContent = new List<String>();
            rawContent.Add("Lorem ipsum\n");
            rawContent.Add("consetetur");

            List<String> definedContent = new List<String>();
            definedContent.Add("Lorem ipsum consetetur");

            ContentFormatter contentFormatter = new ContentFormatter(rawContent, 120);
            List<String> result = contentFormatter._formatted;
            for (int i = 0; i < definedContent.Count; i++)
            {
                if (definedContent[i] != result[i])
                {
                    hasTestFailed = true;
                }
            }
            Assert.AreEqual(hasTestFailed, false);
        }
    }
}
