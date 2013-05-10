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
    public partial class TabControlReading : UserControl
    {
        private TabControl tabf_Reading;
        
        private TabPage rtab_Direction;
        private TabPage rtab_NormalQuestion;
        private TabPage rtab_Review;
        private TabPage rtab_SumQuestion;
        private RichTextBox rrtb_answerA;
        private RichTextBox rrtb_answerB;
        private RichTextBox rrtb_answerC;
        private RichTextBox rrtb_answerD;
        private RichTextBox rrtb_answerE;
        private RichTextBox rrtb_answerF;
        private RichTextBox rrtb_answerG;
        private RichTextBox rrtb_answerH;
        private RichTextBox rtb_Passage;
        private RichTextBox rrtb_question;
        private RichTextBox rtb_sumAnswer1;
        private RichTextBox rtb_sumAnswer10;
        private RichTextBox rtb_sumAnswer2;
        private RichTextBox rtb_sumAnswer3;
        private RichTextBox rtb_sumAnswer4;
        private RichTextBox rtb_sumAnswer5;
        private RichTextBox rtb_sumAnswer6;
        private RichTextBox rtb_sumAnswer7;
        private RichTextBox rtb_sumAnswer8;
        private RichTextBox rtb_sumAnswer9;
        private RichTextBox rtb_sumPassage;
        private RichTextBox rtb_sumQuestion;
        private RichTextBox rtb_SumSelected1;
        private RichTextBox rtb_SumSelected2;
        private RichTextBox rtb_SumSelected3;
        private RichTextBox rtb_SumSelected4;
        private RichTextBox rtb_SumSelected5;
        private RadioButton rtb_writing1;
        private RadioButton rtb_writing2;
        private RichTextBox rtb_writinganswers;
        private PictureBox r_pictureBox;

        private CheckBox rckb_A;
        private CheckBox rckb_B;
        private CheckBox rckb_C;
        private CheckBox rckb_D;
        private CheckBox rckb_E;
        private CheckBox rckb_F;
        private CheckBox rckb_G;
        private CheckBox rckb_H;

        private TrackBar rtb_reading;
        private FlowLayoutPanel r_flowLayoutPanel;
        private FlowLayoutPanel r_flowLayoutPanel2;
        private Label rlbl_rightAnswer;
        private TableLayoutPanel rtlp_answers;
        private Button rbtn_stopReading;
        private Button rbtn_readText;
        private Label rlbl_readingIndication;

        EventHandler rtb_reading_Scroll;
        MouseEventHandler rtb_Passage_MouseClick;
        MouseEventHandler rtb_Passage_MouseMove;
        EventHandler rbtn_stopReading_Click;
        EventHandler rbn_readText_Click;
        
        public TabControlReading()
        {
            InitializeComponent();
        }

        private void TabControlReading_Load(object sender, EventArgs e)
        {
            //this.tabf_Reading.Region = new Region(new RectangleF((float)this.tabf_test.TabPages[0].Left, (float)this.tabf_test.TabPages[0].Top, (float)this.tabf_Reading.TabPages[0].Width, (float)this.tabf_Reading.TabPages[0].Height));
        }
    }
}
