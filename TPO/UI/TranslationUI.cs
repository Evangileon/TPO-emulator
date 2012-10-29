namespace TPO.UI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class TranslationUI : Form
    {
        private IContainer components = null;
        private RichTextBox rtb_Translation;

        public TranslationUI()
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

        private void InitializeComponent()
        {
            this.rtb_Translation = new RichTextBox();
            base.SuspendLayout();
            this.rtb_Translation.Location = new Point(13, 5);
            this.rtb_Translation.Name = "rtb_Translation";
            this.rtb_Translation.ReadOnly = true;
            this.rtb_Translation.ShortcutsEnabled = false;
            this.rtb_Translation.Size = new Size(0x2a7, 0x23f);
            this.rtb_Translation.TabIndex = 1;
            this.rtb_Translation.Text = "";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x2c1, 0x249);
            base.Controls.Add(this.rtb_Translation);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.Name = "TranslationUI";
            this.Text = "TRANSLATION";
            base.TopMost = true;
            base.Load += new EventHandler(this.TranslationUI_Load);
            base.ResumeLayout(false);
        }

        public void Refresh()
        {
            try
            {
                this.rtb_Translation.Rtf = MainForm.TRANSLATION;
            }
            catch
            {
            }
        }

        private void TranslationUI_Load(object sender, EventArgs e)
        {
            this.rtb_Translation.Rtf = MainForm.TRANSLATION;
        }
    }
}

