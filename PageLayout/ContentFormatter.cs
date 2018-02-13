using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageLayout
{
    public class ContentFormatter
    {
        List<String> _raw { get; }
        private List<String> _formatted { get; }
        int _lineWidth { get; }
        public ContentFormatter(List<String> raw, int lineWidth)
        {
            _raw = raw;
            _lineWidth = lineWidth;
            _formatted = new List<String>();
            Format();
        }

        private void Format()
        {
            String rawString = "";
            String lineContent = "";
            int charCount = 0;
            _raw.ForEach(item => rawString += item);
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
                if(charCount + word.Length > _lineWidth)
                {
                    if (lineContent.Length == 0)
                    {
                        lineContent = lineContent + word;
                        _formatted.Add(lineContent);
                        lineContent = "";
                        charCount = 0;
                    }
                    else
                    {
                        lineContent = lineContent.Remove(lineContent.Length - 1);
                        _formatted.Add(lineContent);
                        if(listCount != 1)
                        {
                            lineContent = "";
                            lineContent = word + " ";
                            charCount = 0;
                            charCount = word.Length + 1;
                        }
                        else
                        {
                            _formatted.Add(word);
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
                        _formatted.Add(lineContent);
                    }
                }
                listCount--;
            });
        }
    }
}
