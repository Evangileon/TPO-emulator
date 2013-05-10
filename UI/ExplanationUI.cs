namespace TPO.UI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class ExplanationUI : Form
    {
        private IContainer components = null;
        private RichTextBox rtb_Explanation;

        public ExplanationUI()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Explanation_Load(object sender, EventArgs e)
        {
            this.rtb_Explanation.Rtf = MainForm.EXPLANATION;
        }

        private void InitializeComponent()
        {
            this.rtb_Explanation = new RichTextBox();
            base.SuspendLayout();
            this.rtb_Explanation.Location = new Point(0x18, 12);
            this.rtb_Explanation.Name = "rtb_Explanation";
            this.rtb_Explanation.ReadOnly = true;
            this.rtb_Explanation.ShortcutsEnabled = false;
            this.rtb_Explanation.Size = new Size(0x2a7, 0x23f);
            this.rtb_Explanation.TabIndex = 0;
            this.rtb_Explanation.Text = "";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x2cb, 0x257);
            base.Controls.Add(this.rtb_Explanation);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.Name = "ExplanationUI";
            this.Text = "EXPLANATION";
            base.TopMost = true;
            base.Load += new EventHandler(this.Explanation_Load);
            base.ResumeLayout(false);
        }

        public void Refresh()
        {
            try
            {
                this.rtb_Explanation.Rtf = MainForm.EXPLANATION;
            }
            catch
            {
            }
        }
    }
}

