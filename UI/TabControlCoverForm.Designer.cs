namespace TPO.UI
{
    partial class TabControlCoverForm
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
            this.tab_CoverForm = new System.Windows.Forms.TabControl();
            this.tabf_tposelection = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tpo_GridView = new System.Windows.Forms.DataGridView();
            this.tpo_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpo_Reading = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tpo_Listening = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tpo_Speaking = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tpo_Writing = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tpo_StartTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tpo_ViewAnswers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tab_CoverForm.SuspendLayout();
            this.tabf_tposelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpo_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_CoverForm
            // 
            this.tab_CoverForm.Controls.Add(this.tabf_tposelection);
            this.tab_CoverForm.Controls.Add(this.tabPage2);
            this.tab_CoverForm.Location = new System.Drawing.Point(4, 22);
            this.tab_CoverForm.Name = "tab_CoverForm";
            this.tab_CoverForm.SelectedIndex = 0;
            this.tab_CoverForm.Size = new System.Drawing.Size(780, 484);
            this.tab_CoverForm.TabIndex = 0;
            this.tab_CoverForm.Text = "CoverForm";
            // 
            // tabf_tposelection
            // 
            this.tabf_tposelection.Controls.Add(this.tpo_GridView);
            this.tabf_tposelection.Location = new System.Drawing.Point(4, 22);
            this.tabf_tposelection.Name = "tabf_tposelection";
            this.tabf_tposelection.Padding = new System.Windows.Forms.Padding(3);
            this.tabf_tposelection.Size = new System.Drawing.Size(772, 458);
            this.tabf_tposelection.TabIndex = 0;
            this.tabf_tposelection.Text = "tposelection";
            this.tabf_tposelection.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tpo_GridView
            // 
            this.tpo_GridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpo_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tpo_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tpo_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tpo_NO,
            this.tpo_Reading,
            this.tpo_Listening,
            this.tpo_Speaking,
            this.tpo_Writing,
            this.tpo_StartTest,
            this.tpo_ViewAnswers});
            this.tpo_GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpo_GridView.Location = new System.Drawing.Point(3, 3);
            this.tpo_GridView.MultiSelect = false;
            this.tpo_GridView.Name = "tpo_GridView";
            this.tpo_GridView.ReadOnly = true;
            this.tpo_GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tpo_GridView.RowTemplate.Height = 23;
            this.tpo_GridView.Size = new System.Drawing.Size(766, 452);
            this.tpo_GridView.TabIndex = 0;
            this.tpo_GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tpo_GridView_CellClick);
            // 
            // tpo_NO
            // 
            this.tpo_NO.HeaderText = "TPO NO";
            this.tpo_NO.Name = "tpo_NO";
            this.tpo_NO.ReadOnly = true;
            // 
            // tpo_Reading
            // 
            this.tpo_Reading.HeaderText = "READING";
            this.tpo_Reading.Name = "tpo_Reading";
            this.tpo_Reading.ReadOnly = true;
            // 
            // tpo_Listening
            // 
            this.tpo_Listening.HeaderText = "LISTENING";
            this.tpo_Listening.Name = "tpo_Listening";
            this.tpo_Listening.ReadOnly = true;
            // 
            // tpo_Speaking
            // 
            this.tpo_Speaking.HeaderText = "SPEAKING";
            this.tpo_Speaking.Name = "tpo_Speaking";
            this.tpo_Speaking.ReadOnly = true;
            // 
            // tpo_Writing
            // 
            this.tpo_Writing.HeaderText = "WRITING";
            this.tpo_Writing.Name = "tpo_Writing";
            this.tpo_Writing.ReadOnly = true;
            // 
            // tpo_StartTest
            // 
            this.tpo_StartTest.HeaderText = "START TEST";
            this.tpo_StartTest.Name = "tpo_StartTest";
            this.tpo_StartTest.ReadOnly = true;
            this.tpo_StartTest.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tpo_StartTest.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tpo_ViewAnswers
            // 
            this.tpo_ViewAnswers.HeaderText = "VIEW ANSWERS";
            this.tpo_ViewAnswers.Name = "tpo_ViewAnswers";
            this.tpo_ViewAnswers.ReadOnly = true;
            this.tpo_ViewAnswers.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tpo_ViewAnswers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TabControlCoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab_CoverForm);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "TabControlCoverForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(780, 484);
            this.tab_CoverForm.ResumeLayout(false);
            this.tabf_tposelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tpo_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_CoverForm;
        private System.Windows.Forms.TabPage tabf_tposelection;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tpo_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpo_NO;
        private System.Windows.Forms.DataGridViewButtonColumn tpo_Reading;
        private System.Windows.Forms.DataGridViewButtonColumn tpo_Listening;
        private System.Windows.Forms.DataGridViewButtonColumn tpo_Speaking;
        private System.Windows.Forms.DataGridViewButtonColumn tpo_Writing;
        private System.Windows.Forms.DataGridViewButtonColumn tpo_StartTest;
        private System.Windows.Forms.DataGridViewButtonColumn tpo_ViewAnswers;
    }
}
