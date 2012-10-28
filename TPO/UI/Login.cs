namespace TPO.UI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml;

    public class Login : Form
    {
        private Button btn_cancel;
        private Button btn_login;
        private IContainer components = null;
        private Label label1;
        private Label lbl_pwd;
        private Label lbl_repwd;
        private bool LoginSuccess = false;
        private RadioButton rb_existedUser;
        private RadioButton rb_newUser;
        private TextBox txt_pwd1;
        private TextBox txt_pwd2;
        private TextBox txt_username;

        public Login()
        {
            this.InitializeComponent();
            /*if (!File.Exists("user.xml"))
            {
                XmlDocument document = new XmlDocument();
                File.Create("user.xml");
                document.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement xmlele = document.CreateElement("", "users");
                document.CreateNode(XmlNodeType.Element, "", "user");
                document.CreateNode(XmlNodeType.EndElement, "", "users");
            }*/
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load("user.xml");
            string str = this.txt_username.Text.ToString().ToLower();
            string str2 = this.txt_pwd1.Text.ToString();
            if (this.rb_newUser.Checked)
            {
                if (str2.ToString().Equals(this.txt_pwd2.Text.ToString()))
                {
                    if (document.SelectSingleNode("//users/user[@name='" + str + "']") == null)
                    {
                        XmlNode node2 = document.SelectSingleNode("users");
                        XmlElement newChild = document.CreateElement("user");
                        newChild.SetAttribute("name", str);
                        newChild.SetAttribute("pwd", str2);
                        node2.AppendChild(newChild);
                        document.Save("user.xml");
                        for (int i = 1; i < 0x19; i++)
                        {
                            string path = @"users\" + str + @"\" + i.ToString();
                            if (!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }
                        }
                        MainForm.USERNAME = str;
                        base.Close();
                        this.LoginSuccess = true;
                    }
                    else
                    {
                        MessageBox.Show("Username '" + str + "' exists");
                    }
                }
                else
                {
                    MessageBox.Show("Passward isn't matched!");
                }
            }
            else
            {
                XmlNode node = document.SelectSingleNode("//users/user[@name='" + str + "']");
                if (node == null)
                {
                    MessageBox.Show(str + " does not exist");
                }
                else
                {
                    string str4 = node.Attributes["pwd"].Value;
                    if (str2.Equals(str4))
                    {
                        MainForm.USERNAME = str;
                        this.LoginSuccess = true;
                        base.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
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
            this.label1 = new Label();
            this.lbl_pwd = new Label();
            this.txt_username = new TextBox();
            this.txt_pwd1 = new TextBox();
            this.txt_pwd2 = new TextBox();
            this.lbl_repwd = new Label();
            this.rb_existedUser = new RadioButton();
            this.rb_newUser = new RadioButton();
            this.btn_login = new Button();
            this.btn_cancel = new Button();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label1.Location = new Point(0x5e, 0x24);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x31, 0x11);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.lbl_pwd.Location = new Point(70, 0x48);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new Size(0x49, 0x11);
            this.lbl_pwd.TabIndex = 0;
            this.lbl_pwd.Text = "Password:";
            this.txt_username.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.txt_username.Location = new Point(0x95, 0x23);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new Size(0x85, 0x17);
            this.txt_username.TabIndex = 3;
            this.txt_username.Text = "stu";
            this.txt_pwd1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.txt_pwd1.Location = new Point(0x95, 0x47);
            this.txt_pwd1.Name = "txt_pwd1";
            this.txt_pwd1.PasswordChar = '*';
            this.txt_pwd1.Size = new Size(0x85, 0x17);
            this.txt_pwd1.TabIndex = 4;
            this.txt_pwd1.Text = "123";
            this.txt_pwd2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.txt_pwd2.Location = new Point(0x95, 0x60);
            this.txt_pwd2.Name = "txt_pwd2";
            this.txt_pwd2.PasswordChar = '*';
            this.txt_pwd2.Size = new Size(0x85, 0x17);
            this.txt_pwd2.TabIndex = 5;
            this.txt_pwd2.Visible = false;
            this.lbl_repwd.AutoSize = true;
            this.lbl_repwd.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.lbl_repwd.Location = new Point(12, 0x63);
            this.lbl_repwd.Name = "lbl_repwd";
            this.lbl_repwd.Size = new Size(0x85, 0x11);
            this.lbl_repwd.TabIndex = 0;
            this.lbl_repwd.Text = "Re-enter Password:";
            this.lbl_repwd.Visible = false;
            this.rb_existedUser.AutoSize = true;
            this.rb_existedUser.Checked = true;
            this.rb_existedUser.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.rb_existedUser.Location = new Point(15, 8);
            this.rb_existedUser.Name = "rb_existedUser";
            this.rb_existedUser.Size = new Size(0x69, 0x15);
            this.rb_existedUser.TabIndex = 1;
            this.rb_existedUser.TabStop = true;
            this.rb_existedUser.Text = "Existed User";
            this.rb_existedUser.UseVisualStyleBackColor = true;
            this.rb_existedUser.CheckedChanged += new EventHandler(this.rb_existedUser_CheckedChanged);
            this.rb_newUser.AutoSize = true;
            this.rb_newUser.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.rb_newUser.Location = new Point(0x95, 8);
            this.rb_newUser.Name = "rb_newUser";
            this.rb_newUser.Size = new Size(0x85, 0x15);
            this.rb_newUser.TabIndex = 2;
            this.rb_newUser.Text = "Create New User";
            this.rb_newUser.UseVisualStyleBackColor = true;
            this.btn_login.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_login.Location = new Point(0x49, 0x7e);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new Size(0x5d, 0x1d);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new EventHandler(this.btn_login_Click);
            this.btn_cancel.DialogResult = DialogResult.Cancel;
            this.btn_cancel.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_cancel.Location = new Point(0xbd, 0x7e);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new Size(0x5d, 0x1d);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            base.AcceptButton = this.btn_login;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.btn_cancel;
            base.ClientSize = new Size(380, 0xaf);
            base.Controls.Add(this.btn_cancel);
            base.Controls.Add(this.btn_login);
            base.Controls.Add(this.rb_newUser);
            base.Controls.Add(this.rb_existedUser);
            base.Controls.Add(this.txt_pwd2);
            base.Controls.Add(this.txt_pwd1);
            base.Controls.Add(this.txt_username);
            base.Controls.Add(this.lbl_repwd);
            base.Controls.Add(this.lbl_pwd);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "Login";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";
            base.FormClosed += new FormClosedEventHandler(this.Login_FormClosed);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.LoginSuccess)
            {
                Application.Exit();
            }
        }

        private void rb_existedUser_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_existedUser.Checked)
            {
                this.lbl_repwd.Visible = false;
                this.txt_pwd2.Visible = false;
                this.btn_login.Text = "Log In";
            }
            else
            {
                this.lbl_repwd.Visible = true;
                this.txt_pwd2.Visible = true;
                this.btn_login.Text = "Create";
            }
        }
    }
}

