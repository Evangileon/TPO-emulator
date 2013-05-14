namespace TPO.UI
{
    partial class TabControlWriting
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
            this.tabf_writing = new System.Windows.Forms.TabControl();
            this.wtab_Direction = new System.Windows.Forms.TabPage();
            this.w_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wtab_Reading = new System.Windows.Forms.TabPage();
            this.wrtb_writing1 = new System.Windows.Forms.RichTextBox();
            this.wrtb_reading = new System.Windows.Forms.RichTextBox();
            this.wtab_SpeakingPassage = new System.Windows.Forms.TabPage();
            this.wpb_speak = new System.Windows.Forms.ProgressBar();
            this.wtb_speak = new System.Windows.Forms.TrackBar();
            this.wpb_writingScene = new System.Windows.Forms.PictureBox();
            this.wtab_Writing2 = new System.Windows.Forms.TabPage();
            this.wlbl_writeDirection = new System.Windows.Forms.Label();
            this.wrtb_writing2 = new System.Windows.Forms.RichTextBox();
            this.wrtb_Question2 = new System.Windows.Forms.RichTextBox();
            this.w_panel = new System.Windows.Forms.Panel();
            this.wlbl_wordcount = new System.Windows.Forms.Label();
            this.wbtn_wordcount = new System.Windows.Forms.Button();
            this.wbtn_redo = new System.Windows.Forms.Button();
            this.wbtn_undo = new System.Windows.Forms.Button();
            this.wbtn_paste = new System.Windows.Forms.Button();
            this.wbtn_cut = new System.Windows.Forms.Button();
            
            this.SuspendLayout();
            this.tabf_writing.SuspendLayout();
            this.wtab_Direction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w_pictureBox1)).BeginInit();
            this.wtab_Reading.SuspendLayout();
            this.wtab_SpeakingPassage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wtb_speak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wpb_writingScene)).BeginInit();
            this.wtab_Writing2.SuspendLayout();
            this.w_panel.SuspendLayout();
            // 
            // TabControlWriting
            // 
            this.Controls.Add(this.tabf_writing);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "TabControlWriting";
            this.Size = new System.Drawing.Size(780, 484);
            this.TabIndex = 3;
            this.Text = "Writing";
            //this.UseVisualStyleBackColor = true;
            // 
            // tabf_writing
            // 
            this.tabf_writing.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabf_writing.Controls.Add(this.wtab_Direction);
            this.tabf_writing.Controls.Add(this.wtab_Reading);
            this.tabf_writing.Controls.Add(this.wtab_SpeakingPassage);
            this.tabf_writing.Controls.Add(this.wtab_Writing2);
            this.tabf_writing.Location = new System.Drawing.Point(5, -25);
            this.tabf_writing.Name = "tabf_writing";
            this.tabf_writing.SelectedIndex = 0;
            this.tabf_writing.Size = new System.Drawing.Size(771, 477);
            this.tabf_writing.TabIndex = 2;
            this.tabf_writing.TabStop = false;
            this.tabf_writing.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            // 
            // wtab_Direction
            // 
            this.wtab_Direction.Controls.Add(this.w_pictureBox1);
            this.wtab_Direction.Location = new System.Drawing.Point(4, 25);
            this.wtab_Direction.Name = "wtab_Direction";
            this.wtab_Direction.Size = new System.Drawing.Size(763, 448);
            this.wtab_Direction.TabIndex = 3;
            this.wtab_Direction.Text = "wDirection";
            this.wtab_Direction.UseVisualStyleBackColor = true;
            // 
            // w_pictureBox1
            // 
            this.w_pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.w_pictureBox1.ErrorImage = null;
            this.w_pictureBox1.Image = TPO.Properties.Resources.WritingDirection1;
            this.w_pictureBox1.InitialImage = null;
            this.w_pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.w_pictureBox1.Name = "w_pictureBox1";
            this.w_pictureBox1.Size = new System.Drawing.Size(1081, 490);
            this.w_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.w_pictureBox1.TabIndex = 17;
            this.w_pictureBox1.TabStop = false;
            // 
            // wtab_Reading
            // 
            this.wtab_Reading.Controls.Add(this.wrtb_writing1);
            this.wtab_Reading.Controls.Add(this.wrtb_reading);
            this.wtab_Reading.Location = new System.Drawing.Point(4, 25);
            this.wtab_Reading.Name = "wtab_Reading";
            this.wtab_Reading.Size = new System.Drawing.Size(763, 448);
            this.wtab_Reading.TabIndex = 5;
            this.wtab_Reading.Text = "wReading";
            this.wtab_Reading.UseVisualStyleBackColor = true;
            // 
            // wrtb_writing1
            // 
            this.wrtb_writing1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wrtb_writing1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrtb_writing1.Location = new System.Drawing.Point(387, 3);
            this.wrtb_writing1.Name = "wrtb_writing1";
            this.wrtb_writing1.ShortcutsEnabled = false;
            this.wrtb_writing1.Size = new System.Drawing.Size(373, 443);
            this.wrtb_writing1.TabIndex = 4;
            this.wrtb_writing1.TabStop = false;
            this.wrtb_writing1.Text = "Introduction";
            // 
            // wrtb_reading
            // 
            this.wrtb_reading.BackColor = System.Drawing.SystemColors.Control;
            this.wrtb_reading.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrtb_reading.Location = new System.Drawing.Point(3, 3);
            this.wrtb_reading.Name = "wrtb_reading";
            this.wrtb_reading.ReadOnly = true;
            this.wrtb_reading.ShortcutsEnabled = false;
            this.wrtb_reading.Size = new System.Drawing.Size(384, 443);
            this.wrtb_reading.TabIndex = 4;
            this.wrtb_reading.TabStop = false;
            this.wrtb_reading.Text = "Introduction";
            // 
            // wtab_SpeakingPassage
            // 
            this.wtab_SpeakingPassage.Controls.Add(this.wpb_speak);
            this.wtab_SpeakingPassage.Controls.Add(this.wtb_speak);
            this.wtab_SpeakingPassage.Controls.Add(this.wpb_writingScene);
            this.wtab_SpeakingPassage.Location = new System.Drawing.Point(4, 25);
            this.wtab_SpeakingPassage.Name = "wtab_SpeakingPassage";
            this.wtab_SpeakingPassage.Padding = new System.Windows.Forms.Padding(3);
            this.wtab_SpeakingPassage.Size = new System.Drawing.Size(763, 448);
            this.wtab_SpeakingPassage.TabIndex = 0;
            this.wtab_SpeakingPassage.Text = "wSpeakingPassage";
            this.wtab_SpeakingPassage.UseVisualStyleBackColor = true;
            // 
            // wpb_speak
            // 
            this.wpb_speak.Location = new System.Drawing.Point(206, 388);
            this.wpb_speak.Name = "wpb_speak";
            this.wpb_speak.Size = new System.Drawing.Size(350, 21);
            this.wpb_speak.TabIndex = 40;
            // 
            // wtb_speak
            // 
            this.wtb_speak.AutoSize = false;
            this.wtb_speak.LargeChange = 1;
            this.wtb_speak.Location = new System.Drawing.Point(206, 18);
            this.wtb_speak.Name = "wtb_speak";
            this.wtb_speak.Size = new System.Drawing.Size(350, 23);
            this.wtb_speak.TabIndex = 39;
            this.wtb_speak.TabStop = false;
            this.wtb_speak.TickStyle = System.Windows.Forms.TickStyle.None;
            this.wtb_speak.Scroll += new System.EventHandler(this.wtb_speak_Scroll);
            // 
            // wpb_writingScene
            // 
            this.wpb_writingScene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.wpb_writingScene.Image = ((System.Drawing.Image)(TPO.Properties.Resources.ResourceManager.GetObject("pb_writingScene.Image")));
            this.wpb_writingScene.Location = new System.Drawing.Point(206, 46);
            this.wpb_writingScene.Name = "wpb_writingScene";
            this.wpb_writingScene.Size = new System.Drawing.Size(350, 323);
            this.wpb_writingScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wpb_writingScene.TabIndex = 1;
            this.wpb_writingScene.TabStop = false;
            // 
            // wtab_Writing2
            // 
            this.wtab_Writing2.Controls.Add(this.wlbl_writeDirection);
            this.wtab_Writing2.Controls.Add(this.wrtb_writing2);
            this.wtab_Writing2.Controls.Add(this.wrtb_Question2);
            this.wtab_Writing2.Controls.Add(this.w_panel);
            this.wtab_Writing2.Location = new System.Drawing.Point(4, 25);
            this.wtab_Writing2.Name = "wtab_Writing2";
            this.wtab_Writing2.Size = new System.Drawing.Size(763, 448);
            this.wtab_Writing2.TabIndex = 4;
            this.wtab_Writing2.Text = "wWriting2";
            this.wtab_Writing2.UseVisualStyleBackColor = true;
            // 
            // qlbl_writeDirection
            // 
            this.wlbl_writeDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlbl_writeDirection.Location = new System.Drawing.Point(3, 21);
            this.wlbl_writeDirection.Name = "wlbl_writeDirection";
            this.wlbl_writeDirection.Size = new System.Drawing.Size(760, 45);
            this.wlbl_writeDirection.TabIndex = 8;
            this.wlbl_writeDirection.Text = TPO.Properties.Resources.ResourceManager.GetString("lbl_writeDirection.Text");
            // 
            // wrtb_writing2
            // 
            this.wrtb_writing2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wrtb_writing2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrtb_writing2.Location = new System.Drawing.Point(351, 106);
            this.wrtb_writing2.Name = "wrtb_writing2";
            this.wrtb_writing2.ShortcutsEnabled = false;
            this.wrtb_writing2.Size = new System.Drawing.Size(417, 345);
            this.wrtb_writing2.TabIndex = 6;
            this.wrtb_writing2.TabStop = false;
            this.wrtb_writing2.Text = "";
            this.wrtb_writing2.TextChanged += new System.EventHandler(this.wrtb_writing2_TextChanged);
            // 
            // wrtb_Question2
            // 
            this.wrtb_Question2.BackColor = System.Drawing.SystemColors.Control;
            this.wrtb_Question2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrtb_Question2.Location = new System.Drawing.Point(3, 69);
            this.wrtb_Question2.Name = "wrtb_Question2";
            this.wrtb_Question2.ReadOnly = true;
            this.wrtb_Question2.ShortcutsEnabled = false;
            this.wrtb_Question2.Size = new System.Drawing.Size(347, 381);
            this.wrtb_Question2.TabIndex = 5;
            this.wrtb_Question2.TabStop = false;
            this.wrtb_Question2.Text = "Introduction";
            // 
            // w_panel
            // 
            this.w_panel.BackColor = System.Drawing.Color.LightGray;
            this.w_panel.Controls.Add(this.wlbl_wordcount);
            this.w_panel.Controls.Add(this.wbtn_wordcount);
            this.w_panel.Controls.Add(this.wbtn_redo);
            this.w_panel.Controls.Add(this.wbtn_undo);
            this.w_panel.Controls.Add(this.wbtn_paste);
            this.w_panel.Controls.Add(this.wbtn_cut);
            this.w_panel.Location = new System.Drawing.Point(350, 69);
            this.w_panel.Name = "wpanel";
            this.w_panel.Size = new System.Drawing.Size(425, 38);
            this.w_panel.TabIndex = 7;
            // 
            // wlbl_wordcount
            // 
            this.wlbl_wordcount.AutoSize = true;
            this.wlbl_wordcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wlbl_wordcount.Location = new System.Drawing.Point(371, 7);
            this.wlbl_wordcount.Name = "wlbl_wordcount";
            this.wlbl_wordcount.Size = new System.Drawing.Size(19, 20);
            this.wlbl_wordcount.TabIndex = 1;
            this.wlbl_wordcount.Text = "0";
            // 
            // wbtn_wordcount
            // 
            this.wbtn_wordcount.Location = new System.Drawing.Point(246, 5);
            this.wbtn_wordcount.Name = "wbtn_wordcount";
            this.wbtn_wordcount.Size = new System.Drawing.Size(119, 27);
            this.wbtn_wordcount.TabIndex = 0;
            this.wbtn_wordcount.TabStop = false;
            this.wbtn_wordcount.Text = "Hide Word Count";
            this.wbtn_wordcount.UseVisualStyleBackColor = true;
            this.wbtn_wordcount.Click += new System.EventHandler(this.wbtn_wordcount_Click);
            // 
            // wbtn_redo
            // 
            this.wbtn_redo.Location = new System.Drawing.Point(174, 5);
            this.wbtn_redo.Name = "wbtn_redo";
            this.wbtn_redo.Size = new System.Drawing.Size(45, 27);
            this.wbtn_redo.TabIndex = 0;
            this.wbtn_redo.TabStop = false;
            this.wbtn_redo.Text = "Redo";
            this.wbtn_redo.UseVisualStyleBackColor = true;
            this.wbtn_redo.Click += new System.EventHandler(this.wbtn_redo_Click);
            // 
            // wbtn_undo
            // 
            this.wbtn_undo.Location = new System.Drawing.Point(115, 5);
            this.wbtn_undo.Name = "wbtn_undo";
            this.wbtn_undo.Size = new System.Drawing.Size(45, 27);
            this.wbtn_undo.TabIndex = 0;
            this.wbtn_undo.TabStop = false;
            this.wbtn_undo.Text = "Undo";
            this.wbtn_undo.UseVisualStyleBackColor = true;
            this.wbtn_undo.Click += new System.EventHandler(this.wbtn_undo_Click);
            // 
            // wbtn_paste
            // 
            this.wbtn_paste.Location = new System.Drawing.Point(59, 5);
            this.wbtn_paste.Name = "wbtn_paste";
            this.wbtn_paste.Size = new System.Drawing.Size(45, 27);
            this.wbtn_paste.TabIndex = 0;
            this.wbtn_paste.TabStop = false;
            this.wbtn_paste.Text = "Paste";
            this.wbtn_paste.UseVisualStyleBackColor = true;
            this.wbtn_paste.Click += new System.EventHandler(this.wbtn_paste_Click);
            // 
            // wbtn_cut
            // 
            this.wbtn_cut.Location = new System.Drawing.Point(6, 5);
            this.wbtn_cut.Name = "wbtn_cut";
            this.wbtn_cut.Size = new System.Drawing.Size(45, 27);
            this.wbtn_cut.TabIndex = 0;
            this.wbtn_cut.TabStop = false;
            this.wbtn_cut.Text = "Cut";
            this.wbtn_cut.UseVisualStyleBackColor = true;
            this.wbtn_cut.Click += new System.EventHandler(this.wbtn_cut_Click);

            this.wtab_Direction.ResumeLayout(false);
            this.wtab_Direction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w_pictureBox1)).EndInit();
            this.wtab_Reading.ResumeLayout(false);
            this.wtab_SpeakingPassage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wtb_speak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wpb_writingScene)).EndInit();
            this.wtab_Writing2.ResumeLayout(false);
            this.w_panel.ResumeLayout(false);
            this.w_panel.PerformLayout();
        }

        #endregion
    }
}
