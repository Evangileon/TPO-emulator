using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPO.UI
{
    public partial class TabControlAnswer : UserControl
    {
        TabControl tabf_answer;

        private TabPage atab_listeninganswers;
        private TabPage atab_readinganswer;
        private TabPage atab_speakinganswers;
        private TabPage atab_writinganswers;
        
        private TableLayoutPanel a_tableLayoutPanel1;
        private Button abtn_speakinganswer1;
        private Button abtn_speakinganswer2;
        private Button abtn_speakinganswer3;
        private Button abtn_speakinganswer4;
        private Button abtn_speakinganswer5;
        private Button abtn_speakinganswer6;
        private Label a_label10;
        private Label a_label11;
        private Label a_label12;
        private Label a_label13;
        private Label a_label14;
        private Label a_label15;
        private Label a_label5;
        private Label a_label1;
        private Label a_label2;
        private Label a_label3;
        private Label a_label4;
        private Label a_label6;
        private Label a_label7;
        private Label a_label8;
        private Label albl_listeningScorereport;
        private Label albl_readingscorereport;
        private PictureBox a_pictureBox5;
        private PictureBox a_pictureBox6;
        private PictureBox a_pictureBox1;
        private PictureBox a_pictureBox2;
        private PictureBox a_pictureBox3;
        private PictureBox a_pictureBox4;
        private RadioButton artb_writing1;
        private RadioButton artb_writing2;
        private RichTextBox artb_writinganswers;       
        private DataGridView adgv_readingSelect;
        private DataGridView adgv_listeningSelect;
        private DataGridView adgv_listeninganswers;
        private DataGridView adgv_readinganswers;

        private BindingSource bindingSource_Section;
        private BindingSource bindingSource_Set;

        EventHandler btn_speakinganswer_Click;
        EventHandler tab_speakinganswers_Click;
        EventHandler tab_speakinganswers_Leave;
        EventHandler tabf_answer_SelectedIndexChanged;
        EventHandler dgv_readingSelect_SelectionChanged;
        EventHandler dgv_readingSelect_MouseDoubleClick;
        EventHandler dgv_readinganswers_DataBindingComplete;
        EventHandler dgv_readinganswers_MouseDoubleClick;
        EventHandler rtb_writing2_CheckedChanged;
        
        public TabControlAnswer()
        {
            InitializeComponent();
        }
    }
}
