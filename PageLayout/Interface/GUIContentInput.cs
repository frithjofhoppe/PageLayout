using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PageLayout
{
    public class GUIContentInput : IContentInput
    {
        private RichTextBox richTxtBefore;

        public GUIContentInput(RichTextBox richTxtBefore)
        {
            this.richTxtBefore = richTxtBefore;
        }

        public List<string> InputContent()
        {
            return richTxtBefore.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}
