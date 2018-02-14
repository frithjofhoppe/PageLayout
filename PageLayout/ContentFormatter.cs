using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageLayout
{
    public class ContentFormatter
    {
        List<String> Raw { get; }
        public List<String> Formatted { get; }
        int LineWidth { get; }
        public ContentFormatter(List<String> raw, int lineWidth)
        {
            Raw = raw;
            LineWidth = lineWidth;
            Formatted = new List<String>();
            Format();
        }

        private void Format()
        {
            String rawString = "";
            String lineContent = "";
            int charCount = 0;
            Raw.ForEach(item => rawString += item);
            List<String> rawList = new List<String>();
            List<String> rawList1 = rawString.Split('\n').ToList();
            rawList1.ForEach(item => {
                List<String> rawList2 = item.Split(' ').ToList();
                rawList2.ForEach(item2 =>
                {
                    rawList.Add(item2);
                });
            });

            int listCount = rawList.Count;

            rawList.ForEach(word => {
                if(charCount + word.Length > LineWidth)
                {
                    if (lineContent.Length == 0)
                    {
                        lineContent = lineContent + word;
                        Formatted.Add(lineContent);
                        lineContent = "";
                        charCount = 0;
                    }
                    else
                    {
                        lineContent = lineContent.Remove(lineContent.Length - 1);
                        Formatted.Add(lineContent);
                        if(listCount != 1)
                        {
                            lineContent = "";
                            lineContent = word + " ";
                            charCount = 0;
                            charCount = word.Length + 1;
                        }
                        else
                        {
                            Formatted.Add(word);
                        }
                    }
                }
                else
                {
                    charCount += word.Length + 1;
                    if(listCount != 1)
                    {
                        lineContent = lineContent + word + " ";
                    }
                    else
                    {
                        lineContent = lineContent + word;
                        Formatted.Add(lineContent);
                    }
                }
                listCount--;
            });
        }
    }
}
