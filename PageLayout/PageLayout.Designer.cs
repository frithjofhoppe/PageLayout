namespace PageLayout
{
    partial class PageLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.richTxtBefore = new System.Windows.Forms.RichTextBox();
            this.richTxtAfter = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLineLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFormatContent = new System.Windows.Forms.Button();
            this.btnBereinigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vorher";
            // 
            // richTxtBefore
            // 
            this.richTxtBefore.Location = new System.Drawing.Point(11, 24);
            this.richTxtBefore.Name = "richTxtBefore";
            this.richTxtBefore.Size = new System.Drawing.Size(354, 194);
            this.richTxtBefore.TabIndex = 3;
            this.richTxtBefore.Text = "";
            // 
            // richTxtAfter
            // 
            this.richTxtAfter.Location = new System.Drawing.Point(12, 274);
            this.richTxtAfter.Name = "richTxtAfter";
            this.richTxtAfter.Size = new System.Drawing.Size(353, 194);
            this.richTxtAfter.TabIndex = 5;
            this.richTxtAfter.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nachher";
            // 
            // txtLineLength
            // 
            this.txtLineLength.Location = new System.Drawing.Point(106, 479);
            this.txtLineLength.Name = "txtLineLength";
            this.txtLineLength.Size = new System.Drawing.Size(44, 20);
            this.txtLineLength.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Breite in Zeichen:";
            // 
            // btnFormatContent
            // 
            this.btnFormatContent.Location = new System.Drawing.Point(290, 477);
            this.btnFormatContent.Name = "btnFormatContent";
            this.btnFormatContent.Size = new System.Drawing.Size(75, 23);
            this.btnFormatContent.TabIndex = 8;
            this.btnFormatContent.Text = "Umbrechen";
            this.btnFormatContent.UseVisualStyleBackColor = true;
            this.btnFormatContent.Click += new System.EventHandler(this.btnFormatContent_Click);
            // 
            // btnBereinigen
            // 
            this.btnBereinigen.Location = new System.Drawing.Point(290, 224);
            this.btnBereinigen.Name = "btnBereinigen";
            this.btnBereinigen.Size = new System.Drawing.Size(75, 23);
            this.btnBereinigen.TabIndex = 9;
            this.btnBereinigen.Text = "Bereinigen";
            this.btnBereinigen.UseVisualStyleBackColor = true;
            this.btnBereinigen.Click += new System.EventHandler(this.btnBereinigen_Click);
            // 
            // PageLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 506);
            this.Controls.Add(this.btnBereinigen);
            this.Controls.Add(this.btnFormatContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLineLength);
            this.Controls.Add(this.richTxtAfter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTxtBefore);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PageLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Textumbruch";
            this.Load += new System.EventHandler(this.PageLayout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTxtBefore;
        private System.Windows.Forms.RichTextBox richTxtAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLineLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFormatContent;
        private System.Windows.Forms.Button btnBereinigen;
    }
}

