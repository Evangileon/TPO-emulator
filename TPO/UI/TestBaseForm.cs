namespace TPO.UI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class TestBaseForm : Form
    {
        protected Button btn_continue;
        protected Button btn_mainmenu;
        protected Button btn_nextQuestion;
        protected Button btn_preQuestion;
        protected Button btn_quit;
        protected Button btn_review;
        protected Button button1;
        private IContainer components = null;
        protected Label lbl_mode;
        protected Label lbl_questionNO;
        protected Label lbl_timeremain;
        protected Panel Sound_icon;
        protected TrackBar tb_sound;

        public TestBaseForm()
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(TestBaseForm));
            this.btn_mainmenu = new Button();
            this.btn_quit = new Button();
            this.tb_sound = new TrackBar();
            this.Sound_icon = new Panel();
            this.lbl_mode = new Label();
            this.lbl_questionNO = new Label();
            this.button1 = new Button();
            this.lbl_timeremain = new Label();
            this.btn_continue = new Button();
            this.btn_review = new Button();
            this.btn_preQuestion = new Button();
            this.btn_nextQuestion = new Button();
            this.tb_sound.BeginInit();
            base.SuspendLayout();
            this.btn_mainmenu.BackColor = SystemColors.Control;
            this.btn_mainmenu.Font = new Font("SimSun", 9f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_mainmenu.Location = new Point(7, 0x1d);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new Size(0x55, 0x21);
            this.btn_mainmenu.TabIndex = 0;
            this.btn_mainmenu.Text = "Main Menu";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_quit.BackColor = SystemColors.Control;
            this.btn_quit.Font = new Font("SimSun", 9f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_quit.Location = new Point(0x63, 0x1d);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new Size(0x55, 0x21);
            this.btn_quit.TabIndex = 1;
            this.btn_quit.Text = "Quit Section";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.tb_sound.AutoSize = false;
            this.tb_sound.BackColor = SystemColors.ActiveCaptionText;
            this.tb_sound.Location = new Point(190, 0x1d);
            this.tb_sound.Name = "tb_sound";
            this.tb_sound.Size = new Size(110, 0x21);
            this.tb_sound.TabIndex = 6;
            this.tb_sound.TickStyle = TickStyle.TopLeft;
            this.tb_sound.Value = 5;
            this.Sound_icon.BackColor = SystemColors.ActiveCaptionText;
            this.Sound_icon.BackgroundImage = (Image) manager.GetObject("Sound_icon.BackgroundImage");
            this.Sound_icon.BackgroundImageLayout = ImageLayout.Stretch;
            this.Sound_icon.Location = new Point(0xbf, 0);
            this.Sound_icon.Name = "Sound_icon";
            this.Sound_icon.Size = new Size(0x25, 0x1d);
            this.Sound_icon.TabIndex = 7;
            this.lbl_mode.AutoSize = true;
            this.lbl_mode.BorderStyle = BorderStyle.Fixed3D;
            this.lbl_mode.Location = new Point(0x163, 40);
            this.lbl_mode.Name = "lbl_mode";
            this.lbl_mode.Size = new Size(0x4e, 15);
            this.lbl_mode.TabIndex = 9;
            this.lbl_mode.Text = "Practice Mode";
            this.lbl_questionNO.BorderStyle = BorderStyle.Fixed3D;
            this.lbl_questionNO.Font = new Font("SimSun", 9f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.lbl_questionNO.Location = new Point(0x151, 0x41);
            this.lbl_questionNO.Name = "lbl_questionNO";
            this.lbl_questionNO.Size = new Size(0x73, 0x11);
            this.lbl_questionNO.TabIndex = 10;
            this.lbl_questionNO.Text = "Question 55 of 55";
            this.button1.Location = new Point(0x238, 0x37);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x53, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Hide Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.lbl_timeremain.BorderStyle = BorderStyle.Fixed3D;
            this.lbl_timeremain.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.lbl_timeremain.Location = new Point(0x29b, 0x3d);
            this.lbl_timeremain.Name = "lbl_timeremain";
            this.lbl_timeremain.Size = new Size(0x3a, 0x11);
            this.lbl_timeremain.TabIndex = 12;
            this.lbl_timeremain.Text = "40:00";
            this.btn_continue.Location = new Point(0x279, -1);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new Size(0x4c, 0x1b);
            this.btn_continue.TabIndex = 13;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_review.Location = new Point(0x2cb, -1);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new Size(0x48, 0x1b);
            this.btn_review.TabIndex = 13;
            this.btn_review.Text = "Review";
            this.btn_review.UseVisualStyleBackColor = true;
            this.btn_preQuestion.Location = new Point(0x282, 0x1a);
            this.btn_preQuestion.Name = "btn_preQuestion";
            this.btn_preQuestion.Size = new Size(0x39, 0x1c);
            this.btn_preQuestion.TabIndex = 14;
            this.btn_preQuestion.Text = "<<Back";
            this.btn_preQuestion.UseVisualStyleBackColor = true;
            this.btn_nextQuestion.Location = new Point(730, 0x19);
            this.btn_nextQuestion.Name = "btn_nextQuestion";
            this.btn_nextQuestion.Size = new Size(0x39, 0x1c);
            this.btn_nextQuestion.TabIndex = 14;
            this.btn_nextQuestion.Text = "Next>>";
            this.btn_nextQuestion.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = (Image) manager.GetObject("$this.BackgroundImage");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(0x318, 0x25b);
            base.Controls.Add(this.Sound_icon);
            base.Controls.Add(this.btn_nextQuestion);
            base.Controls.Add(this.btn_preQuestion);
            base.Controls.Add(this.btn_review);
            base.Controls.Add(this.btn_continue);
            base.Controls.Add(this.lbl_timeremain);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.lbl_questionNO);
            base.Controls.Add(this.lbl_mode);
            base.Controls.Add(this.tb_sound);
            base.Controls.Add(this.btn_quit);
            base.Controls.Add(this.btn_mainmenu);
            base.FormBorderStyle = FormBorderStyle.Fixed3D;
            base.MinimizeBox = false;
            base.Name = "TestBaseForm";
            this.Text = "TestBaseForm";
            this.tb_sound.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

