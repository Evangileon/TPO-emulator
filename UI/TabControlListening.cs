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
            InitializeComponent();
        }
    }
}
