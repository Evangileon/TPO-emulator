namespace TPO.UI
{
    partial class TabControlSpeaking
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.tabf_speaking = new System.Windows.Forms.TabControl();
            this.stab_Direction = new System.Windows.Forms.TabPage();
            this.s_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stab_NormalQuestions = new System.Windows.Forms.TabPage();
            this.spb_progress = new System.Windows.Forms.ProgressBar();
            this.s_tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.srtb_timer = new System.Windows.Forms.Label();
            this.srtb_timeindicator = new System.Windows.Forms.Label();
            this.srtb_introduction = new System.Windows.Forms.RichTextBox();
            this.spb_speakingScene = new System.Windows.Forms.PictureBox();

            
            ((System.ComponentModel.ISupportInitialize)this.spb_speakingScene).BeginInit();        
            ((System.ComponentModel.ISupportInitialize)this.s_pictureBox1).BeginInit();
            
            // 
            // TabControlSpeaking
            // 
            this.Controls.Add(tabf_speaking);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "TabControlSpeaking";
            this.Size = new System.Drawing.Size(780, 484);
            this.TabIndex = 2;
            this.Text = "Speaking";
            //this.UseVisualStyleBackColor = true;
            // 
            // tabf_speaking
            // 
            this.tabf_speaking.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabf_speaking.Controls.Add(this.stab_Direction);
            this.tabf_speaking.Controls.Add(this.stab_NormalQuestions);
            this.tabf_speaking.Location = new System.Drawing.Point(5, -23);
            this.tabf_speaking.Name = "tabf_speaking";
            this.tabf_speaking.SelectedIndex = 0;
            this.tabf_speaking.Size = new System.Drawing.Size(771, 477);
            this.tabf_speaking.TabIndex = 1;
            this.tabf_speaking.TabStop = false;
            // 
            // stab_Direction
            // 
            this.stab_Direction.Controls.Add(this.s_pictureBox1);
            this.stab_Direction.Location = new System.Drawing.Point(4, 25);
            this.stab_Direction.Name = "stab_Direction";
            this.stab_Direction.Size = new System.Drawing.Size(763, 448);
            this.stab_Direction.TabIndex = 3;
            this.stab_Direction.Text = "sDirection";
            this.stab_Direction.UseVisualStyleBackColor = true;
            // 
            // s_pictureBox1
            // 
            this.s_pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.s_pictureBox1.Image = TPO.Properties.Resources.SpeakingDirection4;
            this.s_pictureBox1.InitialImage = null;
            this.s_pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.s_pictureBox1.Name = "s_pictureBox1";
            this.s_pictureBox1.Size = new System.Drawing.Size(904, 523);
            this.s_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.s_pictureBox1.TabIndex = 17;
            this.s_pictureBox1.TabStop = false;
            // 
            // stab_NormalQuestions
            // 
            this.stab_NormalQuestions.Controls.Add(this.spb_progress);
            this.stab_NormalQuestions.Controls.Add(this.s_tableLayoutPanel1);
            this.stab_NormalQuestions.Controls.Add(this.srtb_introduction);
            this.stab_NormalQuestions.Controls.Add(this.spb_speakingScene);
            this.stab_NormalQuestions.Location = new System.Drawing.Point(4, 25);
            this.stab_NormalQuestions.Name = "stab_NormalQuestions";
            this.stab_NormalQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.stab_NormalQuestions.Size = new System.Drawing.Size(763, 448);
            this.stab_NormalQuestions.TabIndex = 0;
            this.stab_NormalQuestions.Text = "sNormalQuestions";
            this.stab_NormalQuestions.UseVisualStyleBackColor = true;
            // 
            // spb_progress
            // 
            this.spb_progress.Location = new System.Drawing.Point(190, 371);
            this.spb_progress.Name = "spb_progress";
            this.spb_progress.Size = new System.Drawing.Size(350, 21);
            this.spb_progress.TabIndex = 41;
            // 
            // s_tableLayoutPanel1
            // 
            this.s_tableLayoutPanel1.AutoSize = true;
            this.s_tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.s_tableLayoutPanel1.ColumnCount = 1;
            this.s_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.s_tableLayoutPanel1.Controls.Add(this.srtb_timer, 0, 1);
            this.s_tableLayoutPanel1.Controls.Add(this.srtb_timeindicator, 0, 0);
            this.s_tableLayoutPanel1.Location = new System.Drawing.Point(267, 228);
            this.s_tableLayoutPanel1.Name = "s_tableLayoutPanel1";
            this.s_tableLayoutPanel1.RowCount = 2;
            this.s_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.s_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.s_tableLayoutPanel1.Size = new System.Drawing.Size(200, 72);
            this.s_tableLayoutPanel1.TabIndex = 4;
            // 
            // srtb_timer
            // 
            this.srtb_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.srtb_timer.Location = new System.Drawing.Point(3, 36);
            this.srtb_timer.Name = "srtb_timer";
            this.srtb_timer.Size = new System.Drawing.Size(194, 36);
            this.srtb_timer.TabIndex = 1;
            this.srtb_timer.Text = "label1";
            this.srtb_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srtb_timeindicator
            // 
            this.srtb_timeindicator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.srtb_timeindicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.srtb_timeindicator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.srtb_timeindicator.Location = new System.Drawing.Point(3, 0);
            this.srtb_timeindicator.Name = "srtb_timeindicator";
            this.srtb_timeindicator.Size = new System.Drawing.Size(194, 36);
            this.srtb_timeindicator.TabIndex = 1;
            this.srtb_timeindicator.Text = "PREPARATION TIME";
            this.srtb_timeindicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srtb_introduction
            // 
            this.srtb_introduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.srtb_introduction.Location = new System.Drawing.Point(129, 69);
            this.srtb_introduction.Name = "srtb_introduction";
            this.srtb_introduction.ReadOnly = true;
            this.srtb_introduction.ShortcutsEnabled = false;
            this.srtb_introduction.Size = new System.Drawing.Size(461, 90);
            this.srtb_introduction.TabIndex = 3;
            this.srtb_introduction.TabStop = false;
            this.srtb_introduction.Text = "Introduction";
            this.srtb_introduction.Visible = false;
            this.srtb_introduction.TextChanged += new System.EventHandler(this.RtbAnswers_TextChanged);
            // 
            // spb_speakingScene
            // 
            this.spb_speakingScene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spb_speakingScene.Image = (System.Drawing.Image)TPO.Properties.Resources.ResourceManager.GetObject("pb_speakingScene.Image");
            this.spb_speakingScene.Location = new System.Drawing.Point(190, 18);
            this.spb_speakingScene.Name = "spb_speakingScene";
            this.spb_speakingScene.Size = new System.Drawing.Size(350, 323);
            this.spb_speakingScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spb_speakingScene.TabIndex = 0;
            this.spb_speakingScene.TabStop = false;

            
            ((System.ComponentModel.ISupportInitialize)this.spb_speakingScene).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.s_pictureBox1).EndInit();
        }

        #endregion
    }
}