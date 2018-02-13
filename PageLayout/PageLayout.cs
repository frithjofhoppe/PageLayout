using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PageLayout
{
    public partial class PageLayout : Form
    {
        public PageLayout()
        {
            InitializeComponent();
        }

        private void PageLayout_Load(object sender, EventArgs e)
        {
             
        }

        private void btnFormatContent_Click(object sender, EventArgs e)
        {
            richTxtAfter.Clear();
            IContentInput cInput = new GUIContentInput(richTxtBefore);

            try
            {
                PageLayoutFormatterHandler handler = new PageLayoutFormatterHandler(cInput, Int32.Parse(txtLineLength.Text));
                handler.FomrattedContent().ForEach(line =>
                {
                    richTxtAfter.Text += line + "\n";
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Überprüfen sie ihre Eingaben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBereinigen_Click(object sender, EventArgs e)
        {
            richTxtBefore.Clear();
        }
    }
}
