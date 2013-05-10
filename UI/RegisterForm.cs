namespace TPO.UI
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using TPO.Common;

    public class RegisterForm : Form
    {
        public bool ACTIVED = false;
        private Button btn_ACTIVE;
        private IContainer components = null;
        private Label label2;
        private TextBox txt_machineCode;
        private TextBox txt_pin;

        public RegisterForm()
        {
            this.InitializeComponent();
            Encode encode = new Encode();
            string hardDiskID = encode.GetHardDiskID();
            string cPUID = encode.GetCPUID();
            this.txt_pin.Visible = false;
            this.txt_pin.Text = hardDiskID + "    " + cPUID;
            this.txt_machineCode.Text = encode.GetSHA1MachineCode(hardDiskID + cPUID);
        }

        private void btn_ACTIVE_Click(object sender, EventArgs e)
        {
            string str = "1B3F1E4B5F1B3F5F80300206A7" + this.txt_machineCode.Text.ToString();
            Encode encode = new Encode();
            try
            {
                string str2 = encode.Decode(this.txt_pin.Text.ToString());
                if (str.Equals(str2))
                {
                    FileStream stream = new FileStream("license.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(this.txt_pin.Text.ToString());
                    writer.Close();
                    stream.Close();
                    if (MessageBox.Show("Successfully Actived") == DialogResult.OK)
                    {
                        this.ACTIVED = true;
                        MainForm.ISACTIVED = true;
                    }
                }
                else
                {
                    this.ACTIVED = false;
                    if (MessageBox.Show("Active failed, Do you want to buy the product?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                    {
                        Process.Start("http://item.taobao.com/item.htm?id=12813627381");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Active failed");
            }
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
            this.txt_pin = new TextBox();
            this.btn_ACTIVE = new Button();
            this.txt_machineCode = new TextBox();
            this.label2 = new Label();
            base.SuspendLayout();
            this.txt_pin.Location = new Point(0x2b, 0x31);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new Size(300, 20);
            this.txt_pin.TabIndex = 0;
            this.txt_pin.Visible = false;
            this.txt_pin.TextChanged += new EventHandler(this.txt_pin_TextChanged);
            this.btn_ACTIVE.Enabled = false;
            this.btn_ACTIVE.Location = new Point(0x73, 0x54);
            this.btn_ACTIVE.Name = "btn_ACTIVE";
            this.btn_ACTIVE.Size = new Size(0x79, 0x17);
            this.btn_ACTIVE.TabIndex = 1;
            this.btn_ACTIVE.Text = "ACTIVE";
            this.btn_ACTIVE.UseVisualStyleBackColor = true;
            this.btn_ACTIVE.Visible = false;
            this.btn_ACTIVE.Click += new EventHandler(this.btn_ACTIVE_Click);
            this.txt_machineCode.Location = new Point(0x2b, 0x17);
            this.txt_machineCode.Name = "txt_machineCode";
            this.txt_machineCode.ReadOnly = true;
            this.txt_machineCode.Size = new Size(300, 20);
            this.txt_machineCode.TabIndex = 0;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(0x1a, 7);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x14e, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please Copy the string below and tell me which TPO you want to buy!";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x178, 0x81);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.btn_ACTIVE);
            base.Controls.Add(this.txt_machineCode);
            base.Controls.Add(this.txt_pin);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.MinimizeBox = false;
            base.Name = "RegisterForm";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            base.TopMost = true;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void txt_pin_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_pin.Text.ToString().Trim().Equals(""))
            {
                this.btn_ACTIVE.Enabled = false;
            }
            else
            {
                this.btn_ACTIVE.Enabled = true;
            }
        }
    }
}

