namespace TPO.UI
{
    partial class TabControlReading
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
            this.components = new System.ComponentModel.Container();
            this.tabf_Reading = new System.Windows.Forms.TabControl();
            this.rtab_Direction = new System.Windows.Forms.TabPage();  
            this.rtab_NormalQuestion = new System.Windows.Forms.TabPage();
            this.rtab_SumQuestion = new System.Windows.Forms.TabPage();
            this.rtab_Review = new System.Windows.Forms.TabPage();

            this.r_pictureBox = new System.Windows.Forms.PictureBox();
            this.rtb_reading = new System.Windows.Forms.TrackBar();
            this.rtb_Passage = new System.Windows.Forms.RichTextBox();
            this.r_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.rrtb_question = new System.Windows.Forms.RichTextBox();
            this.rtlp_answers = new System.Windows.Forms.TableLayoutPanel();
            this.rrtb_answerE = new System.Windows.Forms.RichTextBox();
            this.rrtb_answerD = new System.Windows.Forms.RichTextBox();
            this.rrtb_answerC = new System.Windows.Forms.RichTextBox();
            this.rrtb_answerB = new System.Windows.Forms.RichTextBox();
            this.rckb_A = new System.Windows.Forms.CheckBox();
            this.rckb_B = new System.Windows.Forms.CheckBox();
            this.rckb_C = new System.Windows.Forms.CheckBox();
            this.rckb_D = new System.Windows.Forms.CheckBox();
            this.rckb_E = new System.Windows.Forms.CheckBox();
            this.rrtb_answerA = new System.Windows.Forms.RichTextBox();
            this.rckb_F = new System.Windows.Forms.CheckBox();
            this.rckb_G = new System.Windows.Forms.CheckBox();
            this.rckb_H = new System.Windows.Forms.CheckBox();
            this.rrtb_answerF = new System.Windows.Forms.RichTextBox();
            this.rrtb_answerG = new System.Windows.Forms.RichTextBox();
            this.rrtb_answerH = new System.Windows.Forms.RichTextBox();
            this.rbtn_stopReading = new System.Windows.Forms.Button();
            this.rbtn_readText = new System.Windows.Forms.Button();
            this.rlbl_readingIndication = new System.Windows.Forms.Label();
            
            this.rlbl_rightAnswer = new System.Windows.Forms.Label();
            this.r_flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            
            this.tabf_Reading.SuspendLayout();
            this.rtab_Direction.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.r_pictureBox)).BeginInit();
            this.rtab_NormalQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtb_reading)).BeginInit();
            this.r_flowLayoutPanel.SuspendLayout();
            this.rtlp_answers.SuspendLayout();
            this.rtab_SumQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabf_Reading
            // 
            this.tabf_Reading.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabf_Reading.Controls.Add(this.rtab_Direction);
            this.tabf_Reading.Controls.Add(this.rtab_NormalQuestion);
            this.tabf_Reading.Controls.Add(this.rtab_SumQuestion);
            this.tabf_Reading.Controls.Add(this.rtab_Review);
            this.tabf_Reading.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabf_Reading.Location = new System.Drawing.Point(3, -18);
            this.tabf_Reading.Name = "tabf_Reading";
            this.tabf_Reading.SelectedIndex = 0;
            this.tabf_Reading.Size = new System.Drawing.Size(771, 510);
            this.tabf_Reading.TabIndex = 0;
            this.tabf_Reading.TabStop = false;
            // 
            // rtab_Direction
            // 
            this.rtab_Direction.BackColor = System.Drawing.Color.White;
            this.rtab_Direction.Controls.Add(this.r_pictureBox);
            this.rtab_Direction.Location = new System.Drawing.Point(4, 25);
            this.rtab_Direction.Name = "rtab_Direction";
            this.rtab_Direction.Size = new System.Drawing.Size(763, 481);
            this.rtab_Direction.TabIndex = 3;
            this.rtab_Direction.Text = "rDirection";
            // 
            // r_pictureBox
            // 
            this.r_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.r_pictureBox.Image = global::TPO.Properties.Resources.ReadingDirection;
            this.r_pictureBox.InitialImage = null;
            this.r_pictureBox.Location = new System.Drawing.Point(30, 5);
            this.r_pictureBox.Name = "r_pictureBox";
            this.r_pictureBox.Size = new System.Drawing.Size(1093, 506);
            this.r_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.r_pictureBox.TabIndex = 17;
            this.r_pictureBox.TabStop = false;
            // 
            // rtab_NormalQuestion
            // 
            this.rtab_NormalQuestion.Controls.Add(this.rtb_reading);
            this.rtab_NormalQuestion.Controls.Add(this.rtb_Passage);
            this.rtab_NormalQuestion.Controls.Add(this.r_flowLayoutPanel);
            this.rtab_NormalQuestion.Controls.Add(this.rbtn_stopReading);
            this.rtab_NormalQuestion.Controls.Add(this.rbtn_readText);
            this.rtab_NormalQuestion.Controls.Add(this.rlbl_readingIndication);
            this.rtab_NormalQuestion.Location = new System.Drawing.Point(4, 25);
            this.rtab_NormalQuestion.Name = "rtab_NormalQuestion";
            this.rtab_NormalQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.rtab_NormalQuestion.Size = new System.Drawing.Size(763, 481);
            this.rtab_NormalQuestion.TabIndex = 0;
            this.rtab_NormalQuestion.Text = "rNormalQuestions";
            this.rtab_NormalQuestion.UseVisualStyleBackColor = true;
            // 
            // rtb_reading
            // 
            this.rtb_reading.AutoSize = false;
            this.rtb_reading.Location = new System.Drawing.Point(426, 0);
            this.rtb_reading.Name = "rtb_reading";
            this.rtb_reading.Size = new System.Drawing.Size(282, 19);
            this.rtb_reading.TabIndex = 25;
            this.rtb_reading.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rtb_reading.Visible = false;
            this.rtb_reading.Scroll += new System.EventHandler(this.rtb_reading_Scroll);
            // 
            // rtb_Passage
            // 
            this.rtb_Passage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb_Passage.EnableAutoDragDrop = true;
            this.rtb_Passage.Location = new System.Drawing.Point(348, 19);
            this.rtb_Passage.Name = "rtb_Passage";
            this.rtb_Passage.ReadOnly = true;
            this.rtb_Passage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_Passage.ShortcutsEnabled = false;
            this.rtb_Passage.Size = new System.Drawing.Size(412, 436);
            this.rtb_Passage.TabIndex = 4;
            this.rtb_Passage.TabStop = false;
            this.rtb_Passage.Text = "";
            this.rtb_Passage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtb_Passage_MouseClick);
            this.rtb_Passage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rtb_Passage_MouseMove);
            // 
            // r_flowLayoutPanel
            // 
            this.r_flowLayoutPanel.AutoSize = true;
            this.r_flowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.r_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.r_flowLayoutPanel.Controls.Add(this.rrtb_question);
            this.r_flowLayoutPanel.Controls.Add(this.rtlp_answers);
            this.r_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.r_flowLayoutPanel.Location = new System.Drawing.Point(7, 20);
            this.r_flowLayoutPanel.Name = "r_flowLayoutPanel";
            this.r_flowLayoutPanel.Size = new System.Drawing.Size(346, 490);
            this.r_flowLayoutPanel.TabIndex = 3;
            // 
            // rrtb_question
            // 
            this.rrtb_question.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rrtb_question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rrtb_question.Location = new System.Drawing.Point(3, 3);
            this.rrtb_question.Name = "rrtb_question";
            this.rrtb_question.ReadOnly = true;
            this.rrtb_question.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rrtb_question.Size = new System.Drawing.Size(331, 43);
            this.rrtb_question.TabIndex = 0;
            this.rrtb_question.TabStop = false;
            this.rrtb_question.Text = "";
            // 
            // rtlp_answers
            // 
            this.rtlp_answers.AutoSize = true;
            this.rtlp_answers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rtlp_answers.ColumnCount = 2;
            this.rtlp_answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.rtlp_answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rtlp_answers.Controls.Add(this.rrtb_answerE, 1, 4);
            this.rtlp_answers.Controls.Add(this.rrtb_answerD, 1, 3);
            this.rtlp_answers.Controls.Add(this.rrtb_answerC, 1, 2);
            this.rtlp_answers.Controls.Add(this.rrtb_answerB, 1, 1);
            this.rtlp_answers.Controls.Add(this.rckb_A, 0, 0);
            this.rtlp_answers.Controls.Add(this.rckb_B, 0, 1);
            this.rtlp_answers.Controls.Add(this.rckb_C, 0, 2);
            this.rtlp_answers.Controls.Add(this.rckb_D, 0, 3);
            this.rtlp_answers.Controls.Add(this.rckb_E, 0, 4);
            this.rtlp_answers.Controls.Add(this.rrtb_answerA, 1, 0);
            this.rtlp_answers.Controls.Add(this.rckb_F, 0, 5);
            this.rtlp_answers.Controls.Add(this.rckb_G, 0, 6);
            this.rtlp_answers.Controls.Add(this.rckb_H, 0, 7);
            this.rtlp_answers.Controls.Add(this.rrtb_answerF, 1, 5);
            this.rtlp_answers.Controls.Add(this.rrtb_answerG, 1, 6);
            this.rtlp_answers.Controls.Add(this.rrtb_answerH, 1, 7);
            this.rtlp_answers.Location = new System.Drawing.Point(3, 52);
            this.rtlp_answers.Name = "rtlp_answers";
            this.rtlp_answers.RowCount = 8;
            this.rtlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlp_answers.Size = new System.Drawing.Size(336, 368);
            this.rtlp_answers.TabIndex = 1;
            // 
            // rrtb_answerE
            // 
            this.rrtb_answerE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rrtb_answerE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rrtb_answerE.Location = new System.Drawing.Point(43, 187);
            this.rrtb_answerE.Name = "rrtb_answerE";
            this.rrtb_answerE.ReadOnly = true;
            this.rrtb_answerE.ShortcutsEnabled = false;
            this.rrtb_answerE.Size = new System.Drawing.Size(290, 40);
            this.rrtb_answerE.TabIndex = 9;
            this.rrtb_answerE.TabStop = false;
            this.rrtb_answerE.Text = "";
            this.rrtb_answerE.Visible = false;
            // 
            // rrtb_answerD
            // 
            this.rrtb_answerD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rrtb_answerD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rrtb_answerD.Location = new System.Drawing.Point(43, 141);
            this.rrtb_answerD.Name = "rrtb_answerD";
            this.rrtb_answerD.ReadOnly = true;
            this.rrtb_answerD.ShortcutsEnabled = false;
            this.rrtb_answerD.Size = new System.Drawing.Size(290, 40);
            this.rrtb_answerD.TabIndex = 8;
            this.rrtb_answerD.TabStop = false;
            this.rrtb_answerD.Text = "";
            this.rrtb_answerD.Visible = false;
            // 
            // rrtb_answerC
            // 
            this.rrtb_answerC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rrtb_answerC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rrtb_answerC.Location = new System.Drawing.Point(43, 95);
            this.rrtb_answerC.Name = "rrtb_answerC";
            this.rrtb_answerC.ReadOnly = true;
            this.rrtb_answerC.ShortcutsEnabled = false;
            this.rrtb_answerC.Size = new System.Drawing.Size(290, 40);
            this.rrtb_answerC.TabIndex = 7;
            this.rrtb_answerC.TabStop = false;
            this.rrtb_answerC.Text = "";
            this.rrtb_answerC.Visible = false;
            // 
            // rrtb_answerB
            // 
            this.rrtb_answerB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rrtb_answerB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rrtb_answerB.Location = new System.Drawing.Point(43, 49);
            this.rrtb_answerB.Name = "rrtb_answerB";
            this.rrtb_answerB.ReadOnly = true;
            this.rrtb_answerB.ShortcutsEnabled = false;
            this.rrtb_answerB.Size = new System.Drawing.Size(290, 40);
            this.rrtb_answerB.TabIndex = 6;
            this.rrtb_answerB.TabStop = false;
            this.rrtb_answerB.Text = "";
            this.rrtb_answerB.Visible = false;
            // 
            // rckb_A
            // 
            this.rckb_A.Appearance = System.Windows.Forms.Appearance.Button;
            this.rckb_A.AutoSize = true;
            this.rckb_A.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rckb_A.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rckb_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rckb_A.Location = new System.Drawing.Point(3, 3);
            this.rckb_A.Name = "rckb_A";
            this.rckb_A.Size = new System.Drawing.Size(21, 22);
            this.rckb_A.TabIndex = 0;
            this.rckb_A.TabStop = false;
            this.rckb_A.Text = "A";
            this.rckb_A.UseVisualStyleBackColor = true;
            this.rckb_A.Visible = false;
            // 
            // rckb_B
            // 
            this.rckb_B.Appearance = System.Windows.Forms.Appearance.Button;
            this.rckb_B.AutoSize = true;
            this.rckb_B.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rckb_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rckb_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rckb_B.Location = new System.Drawing.Point(3, 49);
            this.rckb_B.Name = "rckb_B";
            this.rckb_B.Size = new System.Drawing.Size(21, 22);
            this.rckb_B.TabIndex = 1;
            this.rckb_B.TabStop = false;
            this.rckb_B.Text = "B";
            this.rckb_B.UseVisualStyleBackColor = true;
            this.rckb_B.Visible = false;
            // 
            // rckb_C
            // 
            this.rckb_C.Appearance = System.Windows.Forms.Appearance.Button;
            this.rckb_C.AutoSize = true;
            this.rckb_C.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rckb_C.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rckb_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rckb_C.Location = new System.Drawing.Point(3, 95);
            this.rckb_C.Name = "rckb_C";
            this.rckb_C.Size = new System.Drawing.Size(21, 22);
            this.rckb_C.TabIndex = 2;
            this.rckb_C.TabStop = false;
            this.rckb_C.Text = "C";
            this.rckb_C.UseVisualStyleBackColor = true;
            this.rckb_C.Visible = false;
            // 
            // rckb_D
            // 
            this.rckb_D.Appearance = System.Windows.Forms.Appearance.Button;
            this.rckb_D.AutoSize = true;
            this.rckb_D.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rckb_D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rckb_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rckb_D.Location = new System.Drawing.Point(3, 141);
            this.rckb_D.Name = "rckb_D";
            this.rckb_D.Size = new System.Drawing.Size(21, 22);
            this.rckb_D.TabIndex = 3;
            this.rckb_D.TabStop = false;
            this.rckb_D.Text = "D";
            this.rckb_D.UseVisualStyleBackColor = true;
            this.rckb_D.Visible = false;
            // 
            // rckb_E
            // 
            this.rckb_E.Appearance = System.Windows.Forms.Appearance.Button;
            this.rckb_E.AutoSize = true;
            this.rckb_E.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rckb_E.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rckb_E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rckb_E.Location = new System.Drawing.Point(3, 187);
            this.rckb_E.Name = "rckb_E";
            this.rckb_E.Size = new System.Drawing.Size(21, 22);
            this.rckb_E.TabIndex = 4;
            this.rckb_E.TabStop = false;
            this.rckb_E.Text = "E";
            this.rckb_E.UseVisualStyleBackColor = true;
            this.rckb_E.Visible = false;
            // 
            // rrtb_answerA
            // 
            this.rrtb_answerA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rrtb_answerA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rrtb_answerA.Location = new System.Drawing.Point(43, 3);
            this.rrtb_answerA.Name = "rrtb_answerA";
            this.rrtb_answerA.ReadOnly = true;
            this.rrtb_answerA.ShortcutsEnabled = false;
            this.rrtb_answerA.Size = new System.Drawing.Size(290, 40);
            this.rrtb_answerA.TabIndex = 5;
            this.rrtb_answerA.TabStop = false;
            this.rrtb_answerA.Text = "";
            this.rrtb_answerA.Visible = false;
            // 
            // rckb_F
            // 
            this.rckb_F.Appearance = System.Windows.Forms.Appearance.Button;
            this.rckb_F.AutoSize = true;
            this.rckb_F.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rckb_F.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rckb_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rckb_F.Location = new System.Drawing.Point(3, 233);
            this.rckb_F.Name = "rckb_F";
            this.rckb_F.Size = new System.Drawing.Size(21, 22);
            this.rckb_F.TabIndex = 4;
            this.rckb_F.TabStop = false;
            this.rckb_F.Text = "F";
            this.rckb_F.UseVisualStyleBackColor = true;
            this.rckb_F.Visible = false;
            // 
            // rckb_G
            // 
            this.rckb_G.Appearance = System.Windows.Forms.Appearance.Button;
            this.rckb_G.AutoSize = true;
            this.rckb_G.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rckb_G.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rckb_G.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rckb_G.Location = new System.Drawing.Point(3, 279);
            this.rckb_G.Name = "rckb_G";
            this.rckb_G.Size = new System.Drawing.Size(21, 22);
            this.rckb_G.TabIndex = 4;
            this.rckb_G.TabStop = false;
            this.rckb_G.Text = "G";
            this.rckb_G.UseVisualStyleBackColor = true;
            this.rckb_G.Visible = false;
            // 
            // rckb_H
            // 
            this.rckb_H.Appearance = System.Windows.Forms.Appearance.Button;
            this.rckb_H.AutoSize = true;
            this.rckb_H.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rckb_H.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rckb_H.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rckb_H.Location = new System.Drawing.Point(3, 325);
            this.rckb_H.Name = "rckb_H";
            this.rckb_H.Size = new System.Drawing.Size(21, 22);
            this.rckb_H.TabIndex = 4;
            this.rckb_H.TabStop = false;
            this.rckb_H.Text = "H";
            this.rckb_H.UseVisualStyleBackColor = true;
            this.rckb_H.Visible = false;
            // 
            // rrtb_answerF
            // 
            this.rrtb_answerF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rrtb_answerF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rrtb_answerF.Location = new System.Drawing.Point(43, 233);
            this.rrtb_answerF.Name = "rrtb_answerF";
            this.rrtb_answerF.ReadOnly = true;
            this.rrtb_answerF.ShortcutsEnabled = false;
            this.rrtb_answerF.Size = new System.Drawing.Size(290, 40);
            this.rrtb_answerF.TabIndex = 9;
            this.rrtb_answerF.TabStop = false;
            this.rrtb_answerF.Text = "";
            this.rrtb_answerF.Visible = false;
            // 
            // rrtb_answerG
            // 
            this.rrtb_answerG.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rrtb_answerG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rrtb_answerG.Location = new System.Drawing.Point(43, 279);
            this.rrtb_answerG.Name = "rrtb_answerG";
            this.rrtb_answerG.ReadOnly = true;
            this.rrtb_answerG.ShortcutsEnabled = false;
            this.rrtb_answerG.Size = new System.Drawing.Size(290, 40);
            this.rrtb_answerG.TabIndex = 9;
            this.rrtb_answerG.TabStop = false;
            this.rrtb_answerG.Text = "";
            this.rrtb_answerG.Visible = false;
            // 
            // rrtb_answerH
            // 
            this.rrtb_answerH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rrtb_answerH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rrtb_answerH.Location = new System.Drawing.Point(43, 325);
            this.rrtb_answerH.Name = "rrtb_answerH";
            this.rrtb_answerH.ReadOnly = true;
            this.rrtb_answerH.ShortcutsEnabled = false;
            this.rrtb_answerH.Size = new System.Drawing.Size(290, 40);
            this.rrtb_answerH.TabIndex = 9;
            this.rrtb_answerH.TabStop = false;
            this.rrtb_answerH.Text = "";
            this.rrtb_answerH.Visible = false;
            // 
            // rbtn_stopReading
            // 
            this.rbtn_stopReading.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_stopReading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtn_stopReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_stopReading.Location = new System.Drawing.Point(711, 0);
            this.rbtn_stopReading.Name = "rbtn_stopReading";
            this.rbtn_stopReading.Size = new System.Drawing.Size(55, 19);
            this.rbtn_stopReading.TabIndex = 24;
            this.rbtn_stopReading.Text = "Stop";
            this.rbtn_stopReading.UseVisualStyleBackColor = false;
            this.rbtn_stopReading.Visible = false;
            this.rbtn_stopReading.Click += new System.EventHandler(this.rbtn_stopReading_Click);
            // 
            // rbtn_readText
            // 
            this.rbtn_readText.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_readText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtn_readText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_readText.Location = new System.Drawing.Point(348, -1);
            this.rbtn_readText.Name = "rbtn_readText";
            this.rbtn_readText.Size = new System.Drawing.Size(75, 19);
            this.rbtn_readText.TabIndex = 24;
            this.rbtn_readText.Text = "ReadText";
            this.rbtn_readText.UseVisualStyleBackColor = false;
            this.rbtn_readText.Click += new System.EventHandler(this.rbn_readText_Click);
            // 
            // rlbl_readingIndication
            // 
            this.rlbl_readingIndication.BackColor = System.Drawing.Color.Teal;
            this.rlbl_readingIndication.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rlbl_readingIndication.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rlbl_readingIndication.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rlbl_readingIndication.Location = new System.Drawing.Point(348, -1);
            this.rlbl_readingIndication.Name = "rlbl_readingIndication";
            this.rlbl_readingIndication.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rlbl_readingIndication.Size = new System.Drawing.Size(416, 20);
            this.rlbl_readingIndication.TabIndex = 5;
            this.rlbl_readingIndication.Text = "Beginning";
            // 
            // rtab_SumQuestion
            // 
            this.rtab_SumQuestion.Controls.Add(this.rlbl_rightAnswer);
            this.rtab_SumQuestion.Controls.Add(this.r_flowLayoutPanel2);
            this.rtab_SumQuestion.Location = new System.Drawing.Point(4, 25);
            this.rtab_SumQuestion.Name = "rtab_SumQuestion";
            this.rtab_SumQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.rtab_SumQuestion.Size = new System.Drawing.Size(763, 481);
            this.rtab_SumQuestion.TabIndex = 1;
            this.rtab_SumQuestion.Text = "rSumQuestion";
            this.rtab_SumQuestion.UseVisualStyleBackColor = true;
            // 
            // rlbl_rightAnswer
            // 
            this.rlbl_rightAnswer.Location = new System.Drawing.Point(0, 0);
            this.rlbl_rightAnswer.Name = "rlbl_rightAnswer";
            this.rlbl_rightAnswer.Size = new System.Drawing.Size(100, 23);
            this.rlbl_rightAnswer.TabIndex = 0;
            // 
            // r_flowLayoutPanel2
            // 
            this.r_flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.r_flowLayoutPanel2.Name = "r_flowLayoutPanel2";
            this.r_flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.r_flowLayoutPanel2.TabIndex = 1;
            // 
            // rtab_Review
            // 
            this.rtab_Review.Location = new System.Drawing.Point(0, 0);
            this.rtab_Review.Name = "rtab_Review";
            this.rtab_Review.Size = new System.Drawing.Size(200, 100);
            this.rtab_Review.TabIndex = 4;
            // 
            // TabControlReading
            // 
            this.Controls.Add(this.tabf_Reading);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "tab_Reading";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(780, 484);
            this.TabIndex = 0;
            this.Text = "Reading";
            //this.UseVisualStyleBackColor = true;

            this.Load += new System.EventHandler(this.TabControlReading_Load);
            this.tabf_Reading.ResumeLayout(false);
            this.rtab_Direction.ResumeLayout(false);
            this.rtab_Direction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.r_pictureBox)).EndInit();
            this.rtab_NormalQuestion.ResumeLayout(false);
            this.rtab_NormalQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtb_reading)).EndInit();
            this.r_flowLayoutPanel.ResumeLayout(false);
            this.r_flowLayoutPanel.PerformLayout();
            this.rtlp_answers.ResumeLayout(false);
            this.rtlp_answers.PerformLayout();
            this.rtab_SumQuestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
