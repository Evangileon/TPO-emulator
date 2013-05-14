using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TPO.Quiz;

namespace TPO.UI
{
    public partial class TabControlListening : UserControl
    {
        TabControl tabf_Listening;

        private CheckBox[] LCkbAnswers;
        private CheckBox[][] LCkbTable;
        private RichTextBox[] LRtbAnswers;
        private RichTextBox[] LRtbTableCol;
        private RichTextBox[] LRtbTableRow;

        private RichTextBox lrtb_answerA;
        private RichTextBox lrtb_answerB;
        private RichTextBox lrtb_answerC;
        private RichTextBox lrtb_answerD;
        private RichTextBox lrtb_answerE;
        private RichTextBox lrtb_answerF;
        private RichTextBox lrtb_answerG;
        private RichTextBox lrtb_answerH;
        private RichTextBox lrtb_question;
        private RichTextBox lrtb_TableCol1;
        private RichTextBox lrtb_TableCol2;
        private RichTextBox lrtb_TableCol3;
        private RichTextBox lrtb_TableCol4;
        private RichTextBox lrtb_TableCol5;
        private RichTextBox lrtb_TableQuestion;
        private RichTextBox lrtb_TableRow1;
        private RichTextBox lrtb_TableRow2;
        private RichTextBox lrtb_TableRow3;
        private RichTextBox lrtb_TableRow4;
        private RichTextBox lrtb_TableRow5;
        private RichTextBox lrtb_TableRow6;
        private RichTextBox lrtb_TableRow7;
        private RichTextBox lrtb_TableRow8;
        private RichTextBox lrtb_TableRow9;
        private TabPage ltab_Direction1;
        private TabPage ltab_Direction2;
        private TabPage ltab_Materials;
        private TabPage ltab_Question;
        private TabPage ltab_TableQuestion;
        private CheckBox lckb_Table11;
        private CheckBox lckb_Table12;
        private CheckBox lckb_Table13;
        private CheckBox lckb_Table14;
        private CheckBox lckb_Table15;
        private CheckBox lckb_Table21;
        private CheckBox lckb_Table22;
        private CheckBox lckb_Table23;
        private CheckBox lckb_Table24;
        private CheckBox lckb_Table25;
        private CheckBox lckb_Table31;
        private CheckBox lckb_Table32;
        private CheckBox lckb_Table33;
        private CheckBox lckb_Table34;
        private CheckBox lckb_Table35;
        private CheckBox lckb_Table41;
        private CheckBox lckb_Table42;
        private CheckBox lckb_Table43;
        private CheckBox lckb_Table44;
        private CheckBox lckb_Table45;
        private CheckBox lckb_Table51;
        private CheckBox lckb_Table52;
        private CheckBox lckb_Table53;
        private CheckBox lckb_Table54;
        private CheckBox lckb_Table55;
        private CheckBox lckb_Table61;
        private CheckBox lckb_Table62;
        private CheckBox lckb_Table63;
        private CheckBox lckb_Table64;
        private CheckBox lckb_Table65;
        private CheckBox lckb_Table71;
        private CheckBox lckb_Table72;
        private CheckBox lckb_Table73;
        private CheckBox lckb_Table74;

        private CheckBox lckb_A;
        private CheckBox lckb_B;
        private CheckBox lckb_C;
        private CheckBox lckb_D;
        private CheckBox lckb_E;
        private CheckBox lckb_F;
        private CheckBox lckb_G;
        private CheckBox lckb_H;
        private CheckBox lckb_Table75;
        private CheckBox lckb_Table81;
        private CheckBox lckb_Table82;
        private CheckBox lckb_Table83;
        private CheckBox lckb_Table84;
        private CheckBox lckb_Table85;
        private CheckBox lckb_Table91;
        private CheckBox lckb_Table92;
        private CheckBox lckb_Table93;
        private CheckBox lckb_Table94;
        private CheckBox lckb_Table95;


        private TPOPassage LMaterial;
        private TabPage lMaterials1;
        private LinkLabel llnk_passage;
        private TableLayoutPanel ltlp_table;
        private Panel l_panel1;

        private ProgressBar lpb_currentpos;
        private ProgressBar lpb_currentpos1;
        private PictureBox lpb_ListenScene;
        private PictureBox lpb_ListenScene1;
        private PictureBox l_pictureBox1;
        private Label l_PlayFileName;
        private SplitContainer l_splitContainer;
        private FlowLayoutPanel lflp_passage;
        private Label llbl_tableAnswer;
        private TrackBar ltb_currentpos;
        private TrackBar ltb_currentpos1;
        private TableLayoutPanel l_tableLayoutPanel1;
        
        public TabControlListening()
        {
            this.LCkbAnswers = new CheckBox[8];
            this.LRtbAnswers = new RichTextBox[8];
            this.LRtbTableRow = new RichTextBox[9];
            this.LRtbTableCol = new RichTextBox[5];
            this.LCkbTable = new CheckBox[9][];
            
            InitializeComponent();


            this.LCkbAnswers[0] = this.lckb_A;
            this.LCkbAnswers[1] = this.lckb_B;
            this.LCkbAnswers[2] = this.lckb_C;
            this.LCkbAnswers[3] = this.lckb_D;
            this.LCkbAnswers[4] = this.lckb_E;
            this.LCkbAnswers[5] = this.lckb_F;
            this.LCkbAnswers[6] = this.lckb_G;
            this.LCkbAnswers[7] = this.lckb_H;


            this.LRtbAnswers[0] = this.lrtb_answerA;
            this.LRtbAnswers[1] = this.lrtb_answerB;
            this.LRtbAnswers[2] = this.lrtb_answerC;
            this.LRtbAnswers[3] = this.lrtb_answerD;
            this.LRtbAnswers[4] = this.lrtb_answerE;
            this.LRtbAnswers[5] = this.lrtb_answerF;
            this.LRtbAnswers[6] = this.lrtb_answerG;
            this.LRtbAnswers[7] = this.lrtb_answerH;

            this.LCkbTable[0][0] = this.lckb_Table11;
            this.LCkbTable[0][1] = this.lckb_Table12;
            this.LCkbTable[0][2] = this.lckb_Table13;
            this.LCkbTable[0][3] = this.lckb_Table14;
            this.LCkbTable[0][4] = this.lckb_Table15;
            this.LCkbTable[1][0] = this.lckb_Table21;
            this.LCkbTable[1][1] = this.lckb_Table22;
            this.LCkbTable[1][2] = this.lckb_Table23;
            this.LCkbTable[1][3] = this.lckb_Table24;
            this.LCkbTable[1][4] = this.lckb_Table25;
            this.LCkbTable[2][0] = this.lckb_Table31;
            this.LCkbTable[2][1] = this.lckb_Table32;
            this.LCkbTable[2][2] = this.lckb_Table33;
            this.LCkbTable[2][3] = this.lckb_Table34;
            this.LCkbTable[2][4] = this.lckb_Table35;
            this.LCkbTable[3][0] = this.lckb_Table41;
            this.LCkbTable[3][1] = this.lckb_Table42;
            this.LCkbTable[3][2] = this.lckb_Table43;
            this.LCkbTable[3][3] = this.lckb_Table44;
            this.LCkbTable[3][4] = this.lckb_Table45;
            this.LCkbTable[4][0] = this.lckb_Table51;
            this.LCkbTable[4][1] = this.lckb_Table52;
            this.LCkbTable[4][2] = this.lckb_Table53;
            this.LCkbTable[4][3] = this.lckb_Table54;
            this.LCkbTable[4][4] = this.lckb_Table55;
            this.LCkbTable[5][0] = this.lckb_Table61;
            this.LCkbTable[5][1] = this.lckb_Table62;
            this.LCkbTable[5][2] = this.lckb_Table63;
            this.LCkbTable[5][3] = this.lckb_Table64;
            this.LCkbTable[5][4] = this.lckb_Table65;
            this.LCkbTable[6][0] = this.lckb_Table71;
            this.LCkbTable[6][1] = this.lckb_Table72;
            this.LCkbTable[6][2] = this.lckb_Table73;
            this.LCkbTable[6][3] = this.lckb_Table74;
            this.LCkbTable[6][4] = this.lckb_Table75;
            this.LCkbTable[7][0] = this.lckb_Table81;
            this.LCkbTable[7][1] = this.lckb_Table82;
            this.LCkbTable[7][2] = this.lckb_Table83;
            this.LCkbTable[7][3] = this.lckb_Table84;
            this.LCkbTable[7][4] = this.lckb_Table85;
            this.LCkbTable[8][0] = this.lckb_Table91;
            this.LCkbTable[8][1] = this.lckb_Table92;
            this.LCkbTable[8][2] = this.lckb_Table93;
            this.LCkbTable[8][3] = this.lckb_Table94;
            this.LCkbTable[8][4] = this.lckb_Table95;
            this.LRtbTableRow[0] = this.lrtb_TableRow1;
            this.LRtbTableRow[1] = this.lrtb_TableRow2;
            this.LRtbTableRow[2] = this.lrtb_TableRow3;
            this.LRtbTableRow[3] = this.lrtb_TableRow4;
            this.LRtbTableRow[4] = this.lrtb_TableRow5;
            this.LRtbTableRow[5] = this.lrtb_TableRow6;
            this.LRtbTableRow[6] = this.lrtb_TableRow7;
            this.LRtbTableRow[7] = this.lrtb_TableRow8;
            this.LRtbTableRow[8] = this.lrtb_TableRow9;
            this.LRtbTableCol[0] = this.lrtb_TableCol1;
            this.LRtbTableCol[1] = this.lrtb_TableCol2;
            this.LRtbTableCol[2] = this.lrtb_TableCol3;
            this.LRtbTableCol[3] = this.lrtb_TableCol4;
            this.LRtbTableCol[4] = this.lrtb_TableCol5;
        }
    }
}
