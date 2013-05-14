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
        
        private RichTextBox rrtb_sumPassage;
        private RichTextBox rrtb_sumQuestion;
        private TableLayoutPanel rtlp_Summary;
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
        
        private TableLayoutPanel rtlp_answers;
        private Button rbtn_stopReading;
        private Button rbtn_readText;
        private Label rlbl_readingIndication;

        private TableLayoutPanel rtlp_sumAnswers;

        private RichTextBox rrtb_SumSelected1;
        private RichTextBox rrtb_SumSelected2;
        private RichTextBox rrtb_SumSelected3;
        private RichTextBox rrtb_SumSelected4;
        private RichTextBox rrtb_SumSelected5;
        private RichTextBox rrtb_sumAnswer1;
        private RichTextBox rrtb_sumAnswer10;
        private RichTextBox rrtb_sumAnswer2;
        private RichTextBox rrtb_sumAnswer3;
        private RichTextBox rrtb_sumAnswer4;
        private RichTextBox rrtb_sumAnswer5;
        private RichTextBox rrtb_sumAnswer6;
        private RichTextBox rrtb_sumAnswer7;
        private RichTextBox rrtb_sumAnswer8;
        private RichTextBox rrtb_sumAnswer9;
        private CheckBox rckb_sumAnswer1;
        private CheckBox rckb_sumAnswer10;
        private CheckBox rckb_sumAnswer2;
        private CheckBox rckb_sumAnswer3;
        private CheckBox rckb_sumAnswer4;
        private CheckBox rckb_sumAnswer5;
        private CheckBox rckb_sumAnswer6;
        private CheckBox rckb_sumAnswer7;
        private CheckBox rckb_sumAnswer8;
        private CheckBox rckb_sumAnswer9;
        private CheckBox rckb_SumSelected1;
        private CheckBox rckb_SumSelected2;
        private CheckBox rckb_SumSelected3;
        private CheckBox rckb_SumSelected4;
        private CheckBox rckb_SumSelected5;

        private Label r_label1;
        private Label rlbl_rightAnswer;
        private Label rlbl_rightAnswered;
        private Label rlbl_scoreReport;
        private Label rlbl_wrongAnswered;
        private PictureBox rpb_wrongAnswered;
        private PictureBox rpb_rightAnswered;

        private PictureBox r_pictureBox5;
        private DataGridView rdgv_readingReview;

        EventHandler rtb_reading_Scroll;
        MouseEventHandler rtb_Passage_MouseClick;
        MouseEventHandler rtb_Passage_MouseMove;
        EventHandler rbtn_stopReading_Click;
        EventHandler rbn_readText_Click;
        DataGridViewCellEventHandler dgv_readingReview_CellContentClick;
        DataGridViewCellMouseEventHandler dgv_readingReview_ColumnHeaderMouseClick;
        DataGridViewBindingCompleteEventHandler dgv_readingReview_DataBindingComplete;

        private CheckBox[] CkbReading;
        private CheckBox[] CkbSummary;
        private CheckBox[] CkbSummarySelected;
        private RichTextBox[] RtbReadingAnswers;
        private RichTextBox[] RtbSumAnswersToBeSelected;
        private RichTextBox[] RtbSumSelected;

        

        public TabControlReading()
        {
            this.CkbReading = new CheckBox[8];
            this.RtbReadingAnswers = new RichTextBox[8];
            this.CkbSummary = new CheckBox[10];
            this.RtbSumAnswersToBeSelected = new RichTextBox[10];
            this.CkbSummarySelected = new CheckBox[5];
            this.RtbSumSelected = new RichTextBox[5];

            InitializeComponent();

            this.CkbReading[0] = this.rckb_A;
            this.CkbReading[1] = this.rckb_B;
            this.CkbReading[2] = this.rckb_C;
            this.CkbReading[3] = this.rckb_D;
            this.CkbReading[4] = this.rckb_E;
            this.CkbReading[5] = this.rckb_F;
            this.CkbReading[6] = this.rckb_G;
            this.CkbReading[7] = this.rckb_H;

            this.RtbReadingAnswers[0] = this.rrtb_answerA;
            this.RtbReadingAnswers[1] = this.rrtb_answerB;
            this.RtbReadingAnswers[2] = this.rrtb_answerC;
            this.RtbReadingAnswers[3] = this.rrtb_answerD;
            this.RtbReadingAnswers[4] = this.rrtb_answerE;
            this.RtbReadingAnswers[5] = this.rrtb_answerF;
            this.RtbReadingAnswers[6] = this.rrtb_answerG;
            this.RtbReadingAnswers[7] = this.rrtb_answerH;

            this.CkbSummary[0] = this.rckb_sumAnswer1;
            this.CkbSummary[1] = this.rckb_sumAnswer2;
            this.CkbSummary[2] = this.rckb_sumAnswer3;
            this.CkbSummary[3] = this.rckb_sumAnswer4;
            this.CkbSummary[4] = this.rckb_sumAnswer5;
            this.CkbSummary[5] = this.rckb_sumAnswer6;
            this.CkbSummary[6] = this.rckb_sumAnswer7;
            this.CkbSummary[7] = this.rckb_sumAnswer8;
            this.CkbSummary[8] = this.rckb_sumAnswer9;
            this.CkbSummary[9] = this.rckb_sumAnswer10;

            this.RtbSumAnswersToBeSelected[0] = this.rrtb_sumAnswer1;
            this.RtbSumAnswersToBeSelected[1] = this.rrtb_sumAnswer2;
            this.RtbSumAnswersToBeSelected[2] = this.rrtb_sumAnswer3;
            this.RtbSumAnswersToBeSelected[3] = this.rrtb_sumAnswer4;
            this.RtbSumAnswersToBeSelected[4] = this.rrtb_sumAnswer5;
            this.RtbSumAnswersToBeSelected[5] = this.rrtb_sumAnswer6;
            this.RtbSumAnswersToBeSelected[6] = this.rrtb_sumAnswer7;
            this.RtbSumAnswersToBeSelected[7] = this.rrtb_sumAnswer8;
            this.RtbSumAnswersToBeSelected[8] = this.rrtb_sumAnswer9;
            this.RtbSumAnswersToBeSelected[9] = this.rrtb_sumAnswer10;

            this.CkbSummarySelected[0] = this.rckb_SumSelected1;
            this.CkbSummarySelected[1] = this.rckb_SumSelected2;
            this.CkbSummarySelected[2] = this.rckb_SumSelected3;
            this.CkbSummarySelected[3] = this.rckb_SumSelected4;
            this.CkbSummarySelected[4] = this.rckb_SumSelected5;
            this.RtbSumSelected[0] = this.rrtb_SumSelected1;
            this.RtbSumSelected[1] = this.rrtb_SumSelected2;
            this.RtbSumSelected[2] = this.rrtb_SumSelected3;
            this.RtbSumSelected[3] = this.rrtb_SumSelected4;
            this.RtbSumSelected[4] = this.rrtb_SumSelected5;

            for (int num = 0; num < 8; num++)
            {
                this.RtbReadingAnswers[num].TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
                this.CkbReading[num].CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
                
            }

            for (int num = 0; num < 10; num++)
            {
                this.RtbSumAnswersToBeSelected[num].TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
                this.CkbSummary[num].CheckedChanged += new EventHandler(this.CkbSummary_CheckedChanged);
            }

            for (int num = 0; num < 5; num++)
            {
                this.RtbSumSelected[num].Click += new EventHandler(this.RtbSumSelected_Click);
                this.RtbSumSelected[num].TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
                this.CkbSummarySelected[num].CheckedChanged += new EventHandler(this.CkbSummarySelected_CheckedChanged);
            }

            this.rrtb_question.TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
            this.rrtb_sumQuestion.TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
        }

        private void TabControlReading_Load(object sender, EventArgs e)
        {
            //this.tabf_Reading.Region = new Region(new RectangleF((float)this.tabf_test.TabPages[0].Left, (float)this.tabf_test.TabPages[0].Top, (float)this.tabf_Reading.TabPages[0].Width, (float)this.tabf_Reading.TabPages[0].Height));
        }
    }
}
