namespace TPO.UI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class CoverForm : Form
    {
        private IContainer components = null;
        private Label label1;
        private Label label10;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private int preHeight = 0;
        private int preWidth = 0;
        private TabControl tab_tposelection;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;

        public CoverForm()
        {
            this.InitializeComponent();
            this.preHeight = base.Height;
            this.preWidth = base.Width;
        }

        private void ChangeControlSize(Control control, double scale1, double scale2)
        {
            foreach (Control control2 in control.Controls)
            {
                control2.Top = Convert.ToInt16((double) (Convert.ToDouble(control2.Top) * scale1));
                control2.Height = Convert.ToInt16((double) (Convert.ToDouble(control2.Height) * scale1));
                control2.Left = Convert.ToInt16((double) (Convert.ToDouble(control2.Left) * scale2));
                control2.Width = Convert.ToInt16((double) (Convert.ToDouble(control2.Width) * scale2));
                this.ChangeControlSize(control2, scale1, scale2);
            }
        }

        private void CoverForm_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void CoverForm_SizeChanged(object sender, EventArgs e)
        {
            double num = 1.0 + ((Convert.ToDouble(base.Height) - Convert.ToDouble(this.preHeight)) / Convert.ToDouble(this.preHeight));
            double num2 = 1.0 + ((Convert.ToDouble(base.Width) - Convert.ToDouble(this.preWidth)) / Convert.ToDouble(this.preWidth));
            this.preHeight = base.Height;
            this.preWidth = base.Width;
            this.ChangeControlSize(this, num, num2);
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CoverForm));
            this.tab_tposelection = new TabControl();
            this.tabPage1 = new TabPage();
            this.label6 = new Label();
            this.label9 = new Label();
            this.label10 = new Label();
            this.label8 = new Label();
            this.label7 = new Label();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.tabPage2 = new TabPage();
            this.tabPage3 = new TabPage();
            this.tab_tposelection.SuspendLayout();
            this.tabPage1.SuspendLayout();
            base.SuspendLayout();
            this.tab_tposelection.Controls.Add(this.tabPage1);
            this.tab_tposelection.Controls.Add(this.tabPage2);
            this.tab_tposelection.Controls.Add(this.tabPage3);
            this.tab_tposelection.Location = new Point(8, 0x92);
            this.tab_tposelection.Name = "tab_tposelection";
            this.tab_tposelection.SelectedIndex = 0;
            this.tab_tposelection.Size = new Size(0x30a, 0x1c4);
            this.tab_tposelection.TabIndex = 0;
            this.tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new Point(4, 0x16);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new Padding(3);
            this.tabPage1.Size = new Size(770, 0x1aa);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TPO1-10";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(0x11, 0xb8);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x40, 0x13);
            this.label6.TabIndex = 0;
            this.label6.Text = "TPO 05";
            this.label9.AutoSize = true;
            this.label9.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(0x11, 0x135);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x40, 0x13);
            this.label9.TabIndex = 0;
            this.label9.Text = "TPO 08";
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(0x11, 0x184);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x40, 0x13);
            this.label10.TabIndex = 0;
            this.label10.Text = "TPO 10";
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(0x11, 0x159);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x40, 0x13);
            this.label8.TabIndex = 0;
            this.label8.Text = "TPO 09";
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(0x11, 0x107);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x40, 0x13);
            this.label7.TabIndex = 0;
            this.label7.Text = "TPO 07";
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(0x11, 0xe1);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x40, 0x13);
            this.label5.TabIndex = 0;
            this.label5.Text = "TPO 06";
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(0x11, 140);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x40, 0x13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TPO 04";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(0x11, 0x62);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x40, 0x13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TPO 03";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0x11, 0x37);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x40, 0x13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TPO 02";
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0x11, 0x11);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x40, 0x13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TPO 01";
            this.tabPage2.BackgroundImage = (Image) manager.GetObject("tabPage2.BackgroundImage");
            this.tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            this.tabPage2.Location = new Point(4, 0x16);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new Padding(3);
            this.tabPage2.Size = new Size(770, 0x1aa);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TPO11-20";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage3.BackgroundImage = (Image) manager.GetObject("tabPage3.BackgroundImage");
            this.tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            this.tabPage3.Location = new Point(4, 0x16);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new Size(770, 0x1aa);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TPO21-22";
            this.tabPage3.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = (Image) manager.GetObject("$this.BackgroundImage");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(0x318, 0x25b);
            base.Controls.Add(this.tab_tposelection);
            base.Name = "CoverForm";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "CoverForm";
            base.WindowState = FormWindowState.Maximized;
            base.ResizeEnd += new EventHandler(this.CoverForm_ResizeEnd);
            base.SizeChanged += new EventHandler(this.CoverForm_SizeChanged);
            this.tab_tposelection.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            base.ResumeLayout(false);
        }
    }
}

