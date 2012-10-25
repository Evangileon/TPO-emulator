namespace TPO.UI
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using TPO.Common;
    using TPO.Media;
    using TPO.Quiz;
    using TPO.TPOFile;
    using TPO.Utility;

    public class MainForm : TestBaseForm
    {
        private ImageList bgimagelist;
        private Button bn_readText;
        private Button btn_Answer01;
        private Button btn_Answer02;
        private Button btn_Answer03;
        private Button btn_Answer04;
        private Button btn_Answer05;
        private Button btn_Answer06;
        private Button btn_Answer07;
        private Button btn_Answer08;
        private Button btn_Answer09;
        private Button btn_Answer10;
        private Button btn_LastPage;
        private Button btn_LoadListening01;
        private Button btn_LoadListening02;
        private Button btn_LoadListening03;
        private Button btn_LoadListening04;
        private Button btn_LoadListening05;
        private Button btn_LoadListening06;
        private Button btn_LoadListening07;
        private Button btn_LoadListening08;
        private Button btn_LoadListening09;
        private Button btn_LoadListening10;
        private Button btn_LoadReading01;
        private Button btn_LoadReading02;
        private Button btn_LoadReading03;
        private Button btn_LoadReading04;
        private Button btn_LoadReading05;
        private Button btn_LoadReading06;
        private Button btn_LoadReading07;
        private Button btn_LoadReading08;
        private Button btn_LoadReading09;
        private Button btn_LoadReading10;
        private Button btn_LoadSpeaking01;
        private Button btn_LoadSpeaking02;
        private Button btn_LoadSpeaking03;
        private Button btn_LoadSpeaking04;
        private Button btn_LoadSpeaking05;
        private Button btn_LoadSpeaking06;
        private Button btn_LoadSpeaking07;
        private Button btn_LoadSpeaking08;
        private Button btn_LoadSpeaking09;
        private Button btn_LoadSpeaking10;
        private Button btn_LoadWriting01;
        private Button btn_LoadWriting02;
        private Button btn_LoadWriting03;
        private Button btn_LoadWriting04;
        private Button btn_LoadWriting05;
        private Button btn_LoadWriting06;
        private Button btn_LoadWriting07;
        private Button btn_LoadWriting08;
        private Button btn_LoadWriting09;
        private Button btn_LoadWriting10;
        private Button btn_NexPage;
        private Button btn_pause;
        private Button btn_QUITapp;
        private Button btn_Review01;
        private Button btn_Review02;
        private Button btn_Review03;
        private Button btn_Review04;
        private Button btn_Review05;
        private Button btn_Review06;
        private Button btn_Review07;
        private Button btn_Review08;
        private Button btn_Review09;
        private Button btn_Review10;
        private Button btn_showexplanation;
        private Button btn_ShowText;
        private Button btn_showtranslation;
        private Button btn_speakinganswer1;
        private Button btn_speakinganswer2;
        private Button btn_speakinganswer3;
        private Button btn_speakinganswer4;
        private Button btn_speakinganswer5;
        private Button btn_speakinganswer6;
        private Button btn_stopReading;
        private Button[] BtnLoadTest;
        private CheckBox ckb_A;
        private CheckBox ckb_B;
        private CheckBox ckb_C;
        private CheckBox ckb_D;
        private CheckBox ckb_E;
        private CheckBox ckb_F;
        private CheckBox ckb_G;
        private CheckBox ckb_H;
        private CheckBox ckb_ShowAnswer;
        private CheckBox ckb_sumAnswer1;
        private CheckBox ckb_sumAnswer10;
        private CheckBox ckb_sumAnswer2;
        private CheckBox ckb_sumAnswer3;
        private CheckBox ckb_sumAnswer4;
        private CheckBox ckb_sumAnswer5;
        private CheckBox ckb_sumAnswer6;
        private CheckBox ckb_sumAnswer7;
        private CheckBox ckb_sumAnswer8;
        private CheckBox ckb_sumAnswer9;
        private CheckBox ckb_SumSelected1;
        private CheckBox ckb_SumSelected2;
        private CheckBox ckb_SumSelected3;
        private CheckBox ckb_SumSelected4;
        private CheckBox ckb_SumSelected5;
        private CheckBox ckb_viewSpeakingText;
        private CheckBox[] CkbReading;
        private CheckBox[] CkbSummary;
        private CheckBox[] CkbSummarySelected;
        private IContainer components;
        private bool CONTINUECLICKED;
        private static int COVERFORM = 0;
        private int CurrentReadingPassage;
        private int CurrentReadingStep;
        private int CurrentSpeakingStep;
        private int CurrentTPOPage;
        private int CurrentWritingStep;
        private DataGridView dgv_listeninganswers;
        private DataGridView dgv_readinganswers;
        private DataGridView dgv_readingReview;
        private ExplanationUI EXP;
        public static string EXPLANATION = "";
        private Timer flash_timer;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flp_passage;
        public bool HasClickedNext;
        private bool HasLoadMP3;
        private int IBTScore;
        private string InsertSetenceRtf;
        public static bool ISACTIVED = false;
        private bool IsPassageMP3;
        public bool IsPause;
        private bool IsQuestionAfter;
        private bool IsRepeated;
        private SplitContainer l_splitContainer;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbl_listeningScorereport;
        private Label lbl_readingIndication;
        private Label lbl_readingscorereport;
        private Label lbl_rightAnswered;
        private Label lbl_scoreReport;
        private Label lbl_tableAnswer;
        private Label lbl_testingSection;
        private Label lbl_top1;
        private Label lbl_top10;
        private Label lbl_top2;
        private Label lbl_top3;
        private Label lbl_top4;
        private Label lbl_top5;
        private Label lbl_top6;
        private Label lbl_top7;
        private Label lbl_top8;
        private Label lbl_top9;
        private Label lbl_writeDirection;
        private Label lbl_wrongAnswered;
        private CheckBox lckb_A;
        private CheckBox lckb_B;
        private CheckBox lckb_C;
        private CheckBox lckb_D;
        private CheckBox lckb_E;
        private CheckBox lckb_F;
        private CheckBox lckb_G;
        private CheckBox lckb_H;
        private CheckBox[] LCkbAnswers;
        private CheckBox[][] LCkbTable;
        private CheckBox lckbTable11;
        private CheckBox lckbTable12;
        private CheckBox lckbTable13;
        private CheckBox lckbTable14;
        private CheckBox lckbTable15;
        private CheckBox lckbTable21;
        private CheckBox lckbTable22;
        private CheckBox lckbTable23;
        private CheckBox lckbTable24;
        private CheckBox lckbTable25;
        private CheckBox lckbTable31;
        private CheckBox lckbTable32;
        private CheckBox lckbTable33;
        private CheckBox lckbTable34;
        private CheckBox lckbTable35;
        private CheckBox lckbTable41;
        private CheckBox lckbTable42;
        private CheckBox lckbTable43;
        private CheckBox lckbTable44;
        private CheckBox lckbTable45;
        private CheckBox lckbTable51;
        private CheckBox lckbTable52;
        private CheckBox lckbTable53;
        private CheckBox lckbTable54;
        private CheckBox lckbTable55;
        private CheckBox lckbTable61;
        private CheckBox lckbTable62;
        private CheckBox lckbTable63;
        private CheckBox lckbTable64;
        private CheckBox lckbTable65;
        private CheckBox lckbTable71;
        private CheckBox lckbTable72;
        private CheckBox lckbTable73;
        private CheckBox lckbTable74;
        private CheckBox lckbTable75;
        private CheckBox lckbTable81;
        private CheckBox lckbTable82;
        private CheckBox lckbTable83;
        private CheckBox lckbTable84;
        private CheckBox lckbTable85;
        private CheckBox lckbTable91;
        private CheckBox lckbTable92;
        private CheckBox lckbTable93;
        private CheckBox lckbTable94;
        private CheckBox lckbTable95;
        private static int LDIRECTION1 = 0;
        private static int LDIRECTION2 = 1;
        private static int LISTENING = 2;
        private Label llbl_rightAnswer;
        private TPOPassage LMaterial;
        private static int LMATERIALS = 2;
        private TabPage lMaterials1;
        private static int LMATERIALS1 = 3;
        private LinkLabel lnk_passage;
        public bool LOADLASTQUESTION;
        private static int LQUESTIONS = 4;
        private RichTextBox lrtb_answerA;
        private RichTextBox lrtb_answerB;
        private RichTextBox lrtb_answerC;
        private RichTextBox lrtb_answerD;
        private RichTextBox lrtb_answerE;
        private RichTextBox lrtb_answerF;
        private RichTextBox lrtb_answerG;
        private RichTextBox lrtb_answerH;
        private RichTextBox lrtb_question;
        private RichTextBox[] LRtbAnswers;
        private RichTextBox[] LRtbTableCol;
        private RichTextBox lrtbTableCol1;
        private RichTextBox lrtbTableCol2;
        private RichTextBox lrtbTableCol3;
        private RichTextBox lrtbTableCol4;
        private RichTextBox lrtbTableCol5;
        private RichTextBox lrtbTableQuestion;
        private RichTextBox[] LRtbTableRow;
        private RichTextBox lrtbTableRow1;
        private RichTextBox lrtbTableRow2;
        private RichTextBox lrtbTableRow3;
        private RichTextBox lrtbTableRow4;
        private RichTextBox lrtbTableRow5;
        private RichTextBox lrtbTableRow6;
        private RichTextBox lrtbTableRow7;
        private RichTextBox lrtbTableRow8;
        private RichTextBox lrtbTableRow9;
        private TabPage ltab_Direction1;
        private TabPage ltab_Direction2;
        private TabPage ltab_Materials;
        private TabPage ltab_Question;
        private TabPage lTableQuestion;
        private static int LTABLEQUESTION = 5;
        private TableLayoutPanel ltlp_table;
        private MP3MCI MP3Player;
        private MP3Record MP3Recorder;
        private int NotAnsweredQuestions;
        private OpenFileDialog openMp3File;
        private Panel panel1;
        private int PartCount;
        private int PartLastPassageIndex;
        private int PartNO;
        private int PassageCount;
        private int PassageLastQuestionIndex;
        private int PassageNO;
        private ProgressBar pb_currentpos;
        private ProgressBar pb_currentpos1;
        private PictureBox pb_ListenScene;
        private PictureBox pb_ListenScene1;
        private PictureBox pb_rightAnswered;
        private PictureBox pb_speakingScene;
        private PictureBox pb_writingScene;
        private PictureBox pb_wrongAnswered;
        private PictureBox pictureBox1;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label PlayFileName;
        private int PreFormHeight;
        private int PreFormWidth;
        private int PreInsertPosition;
        private int QuestionCount;
        private int QuestionNO;
        private RadioButton rb_PracticeMode;
        private RadioButton rb_TestMode;
        private static int RDIRECTION = 0;
        private static int READING = 1;
        private int ReadingPassageNo;
        private int ReviewSelectedQuestionNO;
        private int RightAnsweredQuestions;
        private TPOPassage RMaterial;
        private static int RNORMALQUESTION = 1;
        private static int RREVIEW = 3;
        private int RSpiltQuestionNO;
        private static int RSUMMARYQUESTION = 2;
        private TabPage rtab_Direction;
        private TabPage rtab_NormalQuestion;
        private TabPage rtab_Review;
        private TabPage rtab_SumQuestion;
        private RichTextBox rtb_answerA;
        private RichTextBox rtb_answerB;
        private RichTextBox rtb_answerC;
        private RichTextBox rtb_answerD;
        private RichTextBox rtb_answerE;
        private RichTextBox rtb_answerF;
        private RichTextBox rtb_answerG;
        private RichTextBox rtb_answerH;
        private RichTextBox rtb_Passage;
        private RichTextBox rtb_question;
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
        private RichTextBox RtbPreviousSelected;
        private RichTextBox[] RtbReadingAnswers;
        private RichTextBox[] RtbSumAnswersToBeSelected;
        private RichTextBox[] RtbSumSelected;
        private TabPage sDirection;
        private static int SDIRECTION = 0;
        private bool ShowPassage;
        private TabPage sNormalQuestions;
        private ProgressBar spb;
        private static int SPEAKING = 3;
        private string[] SpeakingQuestions;
        private string[] SPicturePaths;
        private string[] SPictureTimeLines;
        private static int SQUESTION = 1;
        private string[] SReadingMaterials;
        private RichTextBox srtb_introduction;
        private Label srtb_timeindicator;
        private Label srtb_timer;
        private int SummarySelectedAnswerIndex;
        private int[] SummarySelectedAnswers;
        private TabPage tab_CoverForm;
        private TabPage tab_Listening;
        private TabPage tab_listeninganswers;
        private TabPage tab_Reading;
        private TabPage tab_readinganswer;
        private TabPage tab_Speaking;
        private TabPage tab_speakinganswers;
        private TabPage tab_Writing;
        private TabPage tab_writinganswers;
        private TabControl tabf_answer;
        private TabControl tabf_Listening;
        private TabControl tabf_Reading;
        private TabControl tabf_speaking;
        private TabControl tabf_test;
        private TabControl tabf_tposelection;
        private TabControl tabf_writing;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TabPage tabPage1;
        private TrackBar tb_currentpos;
        private TrackBar tb_currentpos1;
        private TrackBar tb_reading;
        private int TestMode;
        private TPOQuestions TestQuestions;
        private TestingSection TestSection;
        private DateTime TimeLimitation;
        private Timer Timer_Listening;
        private Timer Timer_reading;
        private Timer Timer_Speaking;
        private TableLayoutPanel tlp_answers;
        private TableLayoutPanel tlp_sumAnswers;
        private TableLayoutPanel tlp_Summary;
        private int TotalQuestions;
        private int TotalScore;
        private TabPage TPO10;
        private int TPONO;
        public static string TRANSLATION = "";
        private TranslationUI TRANSUI;
        private static int USERANSWERS = 5;
        public static string USERNAME = "";
        private Button wbtn_cut;
        private Button wbtn_paste;
        private Button wbtn_redo;
        private Button wbtn_undo;
        private Button wbtn_wordcount;
        private TabPage wDirection;
        private static int WDIRECTION = 0;
        private static int WINDEPENDENT = 3;
        private static int WINTERGRATED = 1;
        private Label wlbl_wordcount;
        private Panel wpanel;
        private ProgressBar wpb_speak;
        private TabPage wReading;
        private static int WRITING = 4;
        private string[] WritingQuestions;
        private int WrongAnsweredQuestions;
        private RichTextBox wrtb_reading;
        private RichTextBox wrtb_writing1;
        private RichTextBox wrtb_writing2;
        private RichTextBox wrtbQuestion2;
        private TabPage wSpeakingPassage;
        private static int WSPEECH = 2;
        private TrackBar wtb_speak;
        private TabPage wWriting2;

        public MainForm()
        {
            int num;
            this.components = null;
            this.IsPassageMP3 = false;
            this.CurrentReadingStep = 0;
            this.PreFormHeight = 0x268;
            this.PreFormWidth = 0x31a;
            this.CurrentTPOPage = 1;
            this.TPONO = 0;
            this.PassageNO = 0;
            this.PartNO = 0;
            this.QuestionNO = 0;
            this.RSpiltQuestionNO = 0;
            this.ReviewSelectedQuestionNO = -1;
            this.TestMode = 0;
            this.PartCount = 0;
            this.PassageCount = 0;
            this.QuestionCount = 0;
            this.PassageLastQuestionIndex = 0;
            this.PartLastPassageIndex = 0;
            this.InsertSetenceRtf = "";
            this.PreInsertPosition = -1;
            this.MP3Player = new MP3MCI();
            this.IsRepeated = false;
            this.IsQuestionAfter = false;
            this.HasLoadMP3 = false;
            this.CurrentSpeakingStep = 0;
            this.CurrentWritingStep = 0;
            this.BtnLoadTest = new Button[0x3d];
            this.CkbReading = new CheckBox[8];
            this.RtbReadingAnswers = new RichTextBox[8];
            this.CkbSummary = new CheckBox[10];
            this.CkbSummarySelected = new CheckBox[5];
            this.RtbSumAnswersToBeSelected = new RichTextBox[10];
            this.RtbSumSelected = new RichTextBox[5];
            this.SummarySelectedAnswerIndex = -1;
            this.ShowPassage = false;
            this.SummarySelectedAnswers = new int[5];
            this.LCkbAnswers = new CheckBox[8];
            this.LRtbAnswers = new RichTextBox[8];
            this.LRtbTableRow = new RichTextBox[9];
            this.LRtbTableCol = new RichTextBox[5];
            this.LCkbTable = new CheckBox[9][];
            this.IsPause = false;
            this.LOADLASTQUESTION = false;
            this.HasClickedNext = false;
            this.ReadingPassageNo = 1;
            this.CONTINUECLICKED = false;
            this.TotalScore = 0;
            this.RightAnsweredQuestions = 0;
            this.WrongAnsweredQuestions = 0;
            this.NotAnsweredQuestions = 0;
            this.TotalQuestions = 0;
            this.IBTScore = 0;
            this.EXP = new ExplanationUI();
            this.TRANSUI = new TranslationUI();
            this.CurrentReadingPassage = 1;
            this.InitializeComponent();
            this.PreFormHeight = base.Height;
            this.PreFormWidth = base.Width;
            base.WindowState = FormWindowState.Maximized;
            this.CkbReading[0] = this.ckb_A;
            this.CkbReading[1] = this.ckb_B;
            this.CkbReading[2] = this.ckb_C;
            this.CkbReading[3] = this.ckb_D;
            this.CkbReading[4] = this.ckb_E;
            this.CkbReading[5] = this.ckb_F;
            this.CkbReading[6] = this.ckb_G;
            this.CkbReading[7] = this.ckb_H;
            this.LCkbAnswers[0] = this.lckb_A;
            this.LCkbAnswers[1] = this.lckb_B;
            this.LCkbAnswers[2] = this.lckb_C;
            this.LCkbAnswers[3] = this.lckb_D;
            this.LCkbAnswers[4] = this.lckb_E;
            this.LCkbAnswers[5] = this.lckb_F;
            this.LCkbAnswers[6] = this.lckb_G;
            this.LCkbAnswers[7] = this.lckb_H;
            this.RtbReadingAnswers[0] = this.rtb_answerA;
            this.RtbReadingAnswers[1] = this.rtb_answerB;
            this.RtbReadingAnswers[2] = this.rtb_answerC;
            this.RtbReadingAnswers[3] = this.rtb_answerD;
            this.RtbReadingAnswers[4] = this.rtb_answerE;
            this.RtbReadingAnswers[5] = this.rtb_answerF;
            this.RtbReadingAnswers[6] = this.rtb_answerG;
            this.RtbReadingAnswers[7] = this.rtb_answerH;
            this.LRtbAnswers[0] = this.lrtb_answerA;
            this.LRtbAnswers[1] = this.lrtb_answerB;
            this.LRtbAnswers[2] = this.lrtb_answerC;
            this.LRtbAnswers[3] = this.lrtb_answerD;
            this.LRtbAnswers[4] = this.lrtb_answerE;
            this.LRtbAnswers[5] = this.lrtb_answerF;
            this.LRtbAnswers[6] = this.lrtb_answerG;
            this.LRtbAnswers[7] = this.lrtb_answerH;
            for (num = 0; num < 9; num++)
            {
                this.LCkbTable[num] = new CheckBox[5];
                for (int i = 0; i < 5; i++)
                {
                    this.LCkbTable[num][i] = new CheckBox();
                }
            }
            this.LCkbTable[0][0] = this.lckbTable11;
            this.LCkbTable[0][1] = this.lckbTable12;
            this.LCkbTable[0][2] = this.lckbTable13;
            this.LCkbTable[0][3] = this.lckbTable14;
            this.LCkbTable[0][4] = this.lckbTable15;
            this.LCkbTable[1][0] = this.lckbTable21;
            this.LCkbTable[1][1] = this.lckbTable22;
            this.LCkbTable[1][2] = this.lckbTable23;
            this.LCkbTable[1][3] = this.lckbTable24;
            this.LCkbTable[1][4] = this.lckbTable25;
            this.LCkbTable[2][0] = this.lckbTable31;
            this.LCkbTable[2][1] = this.lckbTable32;
            this.LCkbTable[2][2] = this.lckbTable33;
            this.LCkbTable[2][3] = this.lckbTable34;
            this.LCkbTable[2][4] = this.lckbTable35;
            this.LCkbTable[3][0] = this.lckbTable41;
            this.LCkbTable[3][1] = this.lckbTable42;
            this.LCkbTable[3][2] = this.lckbTable43;
            this.LCkbTable[3][3] = this.lckbTable44;
            this.LCkbTable[3][4] = this.lckbTable45;
            this.LCkbTable[4][0] = this.lckbTable51;
            this.LCkbTable[4][1] = this.lckbTable52;
            this.LCkbTable[4][2] = this.lckbTable53;
            this.LCkbTable[4][3] = this.lckbTable54;
            this.LCkbTable[4][4] = this.lckbTable55;
            this.LCkbTable[5][0] = this.lckbTable61;
            this.LCkbTable[5][1] = this.lckbTable62;
            this.LCkbTable[5][2] = this.lckbTable63;
            this.LCkbTable[5][3] = this.lckbTable64;
            this.LCkbTable[5][4] = this.lckbTable65;
            this.LCkbTable[6][0] = this.lckbTable71;
            this.LCkbTable[6][1] = this.lckbTable72;
            this.LCkbTable[6][2] = this.lckbTable73;
            this.LCkbTable[6][3] = this.lckbTable74;
            this.LCkbTable[6][4] = this.lckbTable75;
            this.LCkbTable[7][0] = this.lckbTable81;
            this.LCkbTable[7][1] = this.lckbTable82;
            this.LCkbTable[7][2] = this.lckbTable83;
            this.LCkbTable[7][3] = this.lckbTable84;
            this.LCkbTable[7][4] = this.lckbTable85;
            this.LCkbTable[8][0] = this.lckbTable91;
            this.LCkbTable[8][1] = this.lckbTable92;
            this.LCkbTable[8][2] = this.lckbTable93;
            this.LCkbTable[8][3] = this.lckbTable94;
            this.LCkbTable[8][4] = this.lckbTable95;
            this.LRtbTableRow[0] = this.lrtbTableRow1;
            this.LRtbTableRow[1] = this.lrtbTableRow2;
            this.LRtbTableRow[2] = this.lrtbTableRow3;
            this.LRtbTableRow[3] = this.lrtbTableRow4;
            this.LRtbTableRow[4] = this.lrtbTableRow5;
            this.LRtbTableRow[5] = this.lrtbTableRow6;
            this.LRtbTableRow[6] = this.lrtbTableRow7;
            this.LRtbTableRow[7] = this.lrtbTableRow8;
            this.LRtbTableRow[8] = this.lrtbTableRow9;
            this.LRtbTableCol[0] = this.lrtbTableCol1;
            this.LRtbTableCol[1] = this.lrtbTableCol2;
            this.LRtbTableCol[2] = this.lrtbTableCol3;
            this.LRtbTableCol[3] = this.lrtbTableCol4;
            this.LRtbTableCol[4] = this.lrtbTableCol5;
            for (num = 0; num < 8; num++)
            {
                this.RtbReadingAnswers[num].TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
                this.CkbReading[num].CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
                this.LCkbAnswers[num].CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            }
            this.CkbSummary[0] = this.ckb_sumAnswer1;
            this.CkbSummary[1] = this.ckb_sumAnswer2;
            this.CkbSummary[2] = this.ckb_sumAnswer3;
            this.CkbSummary[3] = this.ckb_sumAnswer4;
            this.CkbSummary[4] = this.ckb_sumAnswer5;
            this.CkbSummary[5] = this.ckb_sumAnswer6;
            this.CkbSummary[6] = this.ckb_sumAnswer7;
            this.CkbSummary[7] = this.ckb_sumAnswer8;
            this.CkbSummary[8] = this.ckb_sumAnswer9;
            this.CkbSummary[9] = this.ckb_sumAnswer10;
            this.RtbSumAnswersToBeSelected[0] = this.rtb_sumAnswer1;
            this.RtbSumAnswersToBeSelected[1] = this.rtb_sumAnswer2;
            this.RtbSumAnswersToBeSelected[2] = this.rtb_sumAnswer3;
            this.RtbSumAnswersToBeSelected[3] = this.rtb_sumAnswer4;
            this.RtbSumAnswersToBeSelected[4] = this.rtb_sumAnswer5;
            this.RtbSumAnswersToBeSelected[5] = this.rtb_sumAnswer6;
            this.RtbSumAnswersToBeSelected[6] = this.rtb_sumAnswer7;
            this.RtbSumAnswersToBeSelected[7] = this.rtb_sumAnswer8;
            this.RtbSumAnswersToBeSelected[8] = this.rtb_sumAnswer9;
            this.RtbSumAnswersToBeSelected[9] = this.rtb_sumAnswer10;
            for (num = 0; num < 10; num++)
            {
                this.RtbSumAnswersToBeSelected[num].TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
                this.CkbSummary[num].CheckedChanged += new EventHandler(this.CkbSummary_CheckedChanged);
            }
            this.CkbSummarySelected[0] = this.ckb_SumSelected1;
            this.CkbSummarySelected[1] = this.ckb_SumSelected2;
            this.CkbSummarySelected[2] = this.ckb_SumSelected3;
            this.CkbSummarySelected[3] = this.ckb_SumSelected4;
            this.CkbSummarySelected[4] = this.ckb_SumSelected5;
            this.RtbSumSelected[0] = this.rtb_SumSelected1;
            this.RtbSumSelected[1] = this.rtb_SumSelected2;
            this.RtbSumSelected[2] = this.rtb_SumSelected3;
            this.RtbSumSelected[3] = this.rtb_SumSelected4;
            this.RtbSumSelected[4] = this.rtb_SumSelected5;
            for (num = 0; num < 5; num++)
            {
                this.RtbSumSelected[num].Click += new EventHandler(this.RtbSumSelected_Click);
                this.RtbSumSelected[num].TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
                this.CkbSummarySelected[num].CheckedChanged += new EventHandler(this.CkbSummarySelected_CheckedChanged);
            }
            this.rtb_question.TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
            this.rtb_sumQuestion.TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
            this.BtnLoadTest[1] = this.btn_LoadReading01;
            this.BtnLoadTest[2] = this.btn_LoadReading02;
            this.BtnLoadTest[3] = this.btn_LoadReading03;
            this.BtnLoadTest[4] = this.btn_LoadReading04;
            this.BtnLoadTest[5] = this.btn_LoadReading05;
            this.BtnLoadTest[6] = this.btn_LoadReading06;
            this.BtnLoadTest[7] = this.btn_LoadReading07;
            this.BtnLoadTest[8] = this.btn_LoadReading08;
            this.BtnLoadTest[9] = this.btn_LoadReading09;
            this.BtnLoadTest[10] = this.btn_LoadReading10;
            this.BtnLoadTest[11] = this.btn_LoadListening01;
            this.BtnLoadTest[12] = this.btn_LoadListening02;
            this.BtnLoadTest[13] = this.btn_LoadListening03;
            this.BtnLoadTest[14] = this.btn_LoadListening04;
            this.BtnLoadTest[15] = this.btn_LoadListening05;
            this.BtnLoadTest[0x10] = this.btn_LoadListening06;
            this.BtnLoadTest[0x11] = this.btn_LoadListening07;
            this.BtnLoadTest[0x12] = this.btn_LoadListening08;
            this.BtnLoadTest[0x13] = this.btn_LoadListening09;
            this.BtnLoadTest[20] = this.btn_LoadListening10;
            this.BtnLoadTest[0x15] = this.btn_LoadSpeaking01;
            this.BtnLoadTest[0x16] = this.btn_LoadSpeaking02;
            this.BtnLoadTest[0x17] = this.btn_LoadSpeaking03;
            this.BtnLoadTest[0x18] = this.btn_LoadSpeaking04;
            this.BtnLoadTest[0x19] = this.btn_LoadSpeaking05;
            this.BtnLoadTest[0x1a] = this.btn_LoadSpeaking06;
            this.BtnLoadTest[0x1b] = this.btn_LoadSpeaking07;
            this.BtnLoadTest[0x1c] = this.btn_LoadSpeaking08;
            this.BtnLoadTest[0x1d] = this.btn_LoadSpeaking09;
            this.BtnLoadTest[30] = this.btn_LoadSpeaking10;
            this.BtnLoadTest[0x1f] = this.btn_LoadWriting01;
            this.BtnLoadTest[0x20] = this.btn_LoadWriting02;
            this.BtnLoadTest[0x21] = this.btn_LoadWriting03;
            this.BtnLoadTest[0x22] = this.btn_LoadWriting04;
            this.BtnLoadTest[0x23] = this.btn_LoadWriting05;
            this.BtnLoadTest[0x24] = this.btn_LoadWriting06;
            this.BtnLoadTest[0x25] = this.btn_LoadWriting07;
            this.BtnLoadTest[0x26] = this.btn_LoadWriting08;
            this.BtnLoadTest[0x27] = this.btn_LoadWriting09;
            this.BtnLoadTest[40] = this.btn_LoadWriting10;
            this.BtnLoadTest[0x29] = this.btn_Review01;
            this.BtnLoadTest[0x2a] = this.btn_Review02;
            this.BtnLoadTest[0x2b] = this.btn_Review03;
            this.BtnLoadTest[0x2c] = this.btn_Review04;
            this.BtnLoadTest[0x2d] = this.btn_Review05;
            this.BtnLoadTest[0x2e] = this.btn_Review06;
            this.BtnLoadTest[0x2f] = this.btn_Review07;
            this.BtnLoadTest[0x30] = this.btn_Review08;
            this.BtnLoadTest[0x31] = this.btn_Review09;
            this.BtnLoadTest[50] = this.btn_Review10;
            this.BtnLoadTest[0x33] = this.btn_Answer01;
            this.BtnLoadTest[0x34] = this.btn_Answer02;
            this.BtnLoadTest[0x35] = this.btn_Answer03;
            this.BtnLoadTest[0x36] = this.btn_Answer04;
            this.BtnLoadTest[0x37] = this.btn_Answer05;
            this.BtnLoadTest[0x38] = this.btn_Answer06;
            this.BtnLoadTest[0x39] = this.btn_Answer07;
            this.BtnLoadTest[0x3a] = this.btn_Answer08;
            this.BtnLoadTest[0x3b] = this.btn_Answer09;
            this.BtnLoadTest[60] = this.btn_Answer10;
        }

        private void Antuorization()
        {
            int num;
            ISACTIVED = true;
            string str = "1B3F1E4B5F1B3F5F80300206A7";
            Encode encode = new Encode();
            string hardDiskID = encode.GetHardDiskID();
            string cPUID = encode.GetCPUID();
            str = str + encode.GetSHA1MachineCode(hardDiskID + cPUID);
            for (num = 0; num < 0x18; num++)
            {
                ConstantValues.TPOACTIVED[num] = false;
                ConstantValues.TPOEXPLANATION[num] = false;
            }
            XMLFileReader reader = new XMLFileReader("license.xml");
            for (num = 1; num < 0x1c; num++)
            {
                string attr = reader.GetAttr("//licenses/license[@name='TPO" + num.ToString() + "']/@value");
                try
                {
                    string str5 = encode.Decode(attr);
                    if (str5.Contains(str + "TPO" + num.ToString()))
                    {
                        ConstantValues.TPOACTIVED[num] = true;
                    }
                    if (str5.Contains("EXP"))
                    {
                        ConstantValues.TPOEXPLANATION[num] = true;
                    }
                }
                catch
                {
                }
            }
            ConstantValues.TPOACTIVED[1] = true;
            ConstantValues.TPOACTIVED[0x12] = true;
            ConstantValues.TPOEXPLANATION[1] = true;
            ConstantValues.TPOEXPLANATION[0x12] = true;
        }

        private void bn_readText_Click(object sender, EventArgs e)
        {
            this.CurrentReadingPassage = this.ReadingPassageNo;
            try
            {
                this.MP3Player.StopT();
                this.MP3Player = new MP3MCI();
                string path = Application.StartupPath + @"\Explanations\" + this.TPONO.ToString() + @"\Reading\" + this.ReadingPassageNo.ToString() + ".mp3";
                if (File.Exists(path))
                {
                    this.MP3Player.FileName = path;
                    this.MP3Player.play();
                    this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                    this.bn_readText.Enabled = false;
                    this.btn_stopReading.Visible = true;
                    this.tb_reading.Visible = true;
                    this.tb_reading.Maximum = this.MP3Player.Duration;
                    this.Timer_reading.Start();
                }
            }
            catch
            {
            }
        }

        private void BottonsStatus()
        {
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    if (!this.rb_PracticeMode.Checked)
                    {
                        this.lbl_scoreReport.Visible = false;
                        break;
                    }
                    this.lbl_scoreReport.Visible = true;
                    break;

                case TestingSection.LISTENING:
                    base.btn_preQuestion.BackgroundImage = Image.FromFile(@"Tests\Direction\OK.jpg");
                    base.btn_nextQuestion.BackgroundImage = Image.FromFile(@"Tests\Direction\next1.jpg");
                    this.btn_LastPage.Visible = false;
                    this.btn_QUITapp.Visible = false;
                    this.btn_NexPage.Visible = false;
                    base.btn_mainmenu.Visible = true;
                    base.btn_quit.Visible = true;
                    this.lbl_testingSection.Visible = true;
                    this.btn_ShowText.Visible = false;
                    base.lbl_mode.Visible = true;
                    base.lbl_questionNO.Visible = true;
                    base.Sound_icon.Visible = true;
                    base.tb_sound.Visible = false;
                    base.btn_review.Visible = false;
                    base.btn_preQuestion.Visible = true;
                    base.btn_nextQuestion.Visible = true;
                    if (this.QuestionNO <= 1)
                    {
                        base.button1.Visible = true;
                        base.lbl_timeremain.Visible = true;
                    }
                    goto Label_05D5;

                case TestingSection.SPEAKING:
                    this.btn_LastPage.Visible = false;
                    this.btn_QUITapp.Visible = false;
                    this.btn_NexPage.Visible = false;
                    base.btn_mainmenu.Visible = true;
                    base.btn_quit.Visible = true;
                    this.lbl_testingSection.Visible = true;
                    this.btn_ShowText.Visible = false;
                    base.lbl_mode.Visible = true;
                    base.lbl_questionNO.Visible = true;
                    base.Sound_icon.Visible = true;
                    base.tb_sound.Visible = false;
                    base.btn_review.Visible = false;
                    base.btn_preQuestion.Visible = false;
                    base.btn_nextQuestion.Visible = false;
                    base.button1.Visible = false;
                    base.lbl_timeremain.Visible = false;
                    goto Label_05D5;

                case TestingSection.WRITING:
                    if (!this.rb_PracticeMode.Checked)
                    {
                        base.btn_preQuestion.Enabled = false;
                        base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back.jpg");
                        base.btn_preQuestion.Visible = true;
                    }
                    else
                    {
                        base.btn_preQuestion.Enabled = false;
                        base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back.jpg");
                        base.btn_preQuestion.Visible = true;
                    }
                    this.btn_LastPage.Visible = false;
                    this.btn_NexPage.Visible = false;
                    this.btn_QUITapp.Visible = false;
                    base.btn_mainmenu.Visible = true;
                    base.btn_quit.Visible = true;
                    this.lbl_testingSection.Visible = true;
                    this.btn_ShowText.Visible = false;
                    base.lbl_mode.Visible = true;
                    base.lbl_questionNO.Visible = true;
                    base.Sound_icon.Visible = true;
                    base.tb_sound.Visible = false;
                    base.btn_review.Visible = false;
                    base.btn_nextQuestion.Visible = true;
                    base.button1.Visible = true;
                    base.lbl_timeremain.Visible = true;
                    goto Label_05D5;

                default:
                    goto Label_05D5;
            }
            this.btn_LastPage.Visible = false;
            this.btn_NexPage.Visible = false;
            this.btn_QUITapp.Visible = false;
            base.lbl_mode.Visible = true;
            if (this.QuestionNO <= 1)
            {
                base.button1.Visible = true;
            }
            base.btn_nextQuestion.Visible = true;
            base.btn_preQuestion.Visible = true;
            if (this.QuestionNO <= 1)
            {
                base.lbl_timeremain.Visible = true;
            }
            base.btn_review.Visible = true;
            base.btn_mainmenu.Visible = true;
            base.btn_quit.Visible = true;
            base.lbl_questionNO.Visible = true;
            base.Sound_icon.Visible = true;
            base.tb_sound.Visible = false;
            if (this.QuestionNO < 1)
            {
                base.btn_review.Enabled = false;
            }
            else
            {
                base.btn_review.Enabled = true;
            }
            if (this.QuestionNO > 0)
            {
                Question question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
                if ((question.QuestionType == QuestionType.SUMMARY) || (question.QuestionType == QuestionType.TABEL))
                {
                    this.btn_ShowText.Visible = true;
                }
                else
                {
                    this.btn_ShowText.Visible = false;
                }
            }
            else
            {
                this.btn_ShowText.Visible = false;
            }
            if (this.QuestionNO < 1)
            {
                base.btn_preQuestion.Enabled = false;
                base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back.jpg");
                base.btn_nextQuestion.Enabled = false;
                base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next.jpg");
            }
            else
            {
                base.btn_nextQuestion.Enabled = true;
                base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next1.jpg");
                if (this.QuestionNO == 1)
                {
                    base.btn_preQuestion.Enabled = false;
                    base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back.jpg");
                }
                else
                {
                    base.btn_preQuestion.Enabled = true;
                    base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back1.jpg");
                }
            }
        Label_05D5:
            if (this.rb_PracticeMode.Checked)
            {
                this.wtb_speak.Visible = true;
            }
            else
            {
                this.tb_currentpos1.Visible = false;
                this.wtb_speak.Visible = false;
            }
            if (base.btn_continue.Visible)
            {
                base.btn_review.Visible = false;
                base.btn_nextQuestion.Visible = false;
                base.btn_preQuestion.Visible = false;
            }
            if (this.TestSection != TestingSection.READING)
            {
                this.btn_showexplanation.Visible = false;
                this.btn_showtranslation.Visible = false;
            }
            else if (ConstantValues.TPOEXPLANATION[this.TPONO])
            {
                this.btn_showexplanation.Visible = this.ckb_ShowAnswer.Visible;
                this.btn_showtranslation.Visible = this.ckb_ShowAnswer.Visible;
            }
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            this.CONTINUECLICKED = true;
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    if (this.CurrentReadingStep != 0)
                    {
                        if ((this.CurrentReadingStep == 1) && (this.QuestionNO < 1))
                        {
                            this.tabf_test.SelectedIndex = READING;
                            this.tabf_Reading.SelectedIndex = RNORMALQUESTION;
                            this.QuestionNO = 1;
                            base.btn_continue.Visible = false;
                            base.btn_nextQuestion.Visible = true;
                            base.btn_preQuestion.Visible = true;
                            this.btn_pause.Visible = this.rb_PracticeMode.Checked;
                            this.LoadReadingMaterialAndQA();
                            this.Timer_Listening.Start();
                        }
                        break;
                    }
                    this.tabf_test.SelectedIndex = READING;
                    this.tabf_Reading.SelectedIndex = RNORMALQUESTION;
                    this.CurrentReadingStep++;
                    break;

                case TestingSection.LISTENING:
                    this.QuestionNO++;
                    this.IsQuestionAfter = true;
                    base.btn_preQuestion.Enabled = true;
                    base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/ok1.jpg");
                    this.btn_pause.Visible = this.rb_PracticeMode.Checked;
                    base.btn_continue.Visible = false;
                    base.btn_nextQuestion.Visible = true;
                    base.btn_preQuestion.Visible = true;
                    base.button1.Visible = true;
                    this.LoadListeningMaterial();
                    break;

                case TestingSection.SPEAKING:
                    this.tabf_test.SelectedIndex = LISTENING;
                    this.tabf_speaking.SelectedIndex = SQUESTION;
                    this.CurrentSpeakingStep = 1;
                    this.MP3Player.StopT();
                    this.HasLoadMP3 = false;
                    base.btn_continue.Visible = false;
                    base.btn_nextQuestion.Visible = true;
                    base.btn_preQuestion.Visible = true;
                    base.button1.Visible = true;
                    if (this.rb_PracticeMode.Checked)
                    {
                        base.btn_preQuestion.Visible = true;
                        base.btn_preQuestion.Enabled = false;
                        base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back.jpg");
                        base.btn_nextQuestion.Visible = true;
                        base.btn_nextQuestion.Enabled = true;
                        base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next1.jpg");
                        base.btn_preQuestion.BackgroundImage = Image.FromFile(@"Tests\Direction\back.jpg");
                        base.btn_nextQuestion.BackgroundImage = Image.FromFile(@"Tests\Direction\next1.jpg");
                    }
                    break;

                case TestingSection.WRITING:
                    this.CurrentWritingStep++;
                    this.HasLoadMP3 = false;
                    base.btn_continue.Visible = false;
                    base.btn_nextQuestion.Visible = true;
                    base.btn_preQuestion.Visible = true;
                    base.button1.Visible = true;
                    break;
            }
        }

        private void btn_LastPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentTPOPage == 2)
            {
                this.btn_NexPage.Enabled = true;
                this.CurrentTPOPage = 1;
                this.lbl_top1.Text = "TPO 01";
                this.lbl_top2.Text = "TPO 02";
                this.lbl_top3.Text = "TPO 03";
                this.lbl_top4.Text = "TPO 04";
                this.lbl_top5.Text = "TPO 05";
                this.lbl_top6.Text = "TPO 06";
                this.lbl_top7.Text = "TPO 07";
                this.lbl_top8.Text = "TPO 08";
                this.lbl_top9.Text = "TPO 09";
                this.lbl_top10.Text = "TPO 10";
                this.btn_LastPage.Enabled = false;
            }
            else if (this.CurrentTPOPage == 3)
            {
                this.CurrentTPOPage = 2;
                this.btn_NexPage.Enabled = true;
                for (int i = 5; i < 11; i++)
                {
                    this.BtnLoadTest[i].Enabled = true;
                    this.BtnLoadTest[i + 10].Enabled = true;
                    this.BtnLoadTest[i + 20].Enabled = true;
                    this.BtnLoadTest[i + 30].Enabled = true;
                    this.BtnLoadTest[i + 40].Enabled = true;
                    this.BtnLoadTest[i + 50].Enabled = true;
                }
                this.lbl_top1.Text = "TPO 11";
                this.lbl_top2.Text = "TPO 12";
                this.lbl_top3.Text = "TPO 13";
                this.lbl_top4.Text = "TPO 14";
                this.lbl_top5.Text = "TPO 15";
                this.lbl_top6.Text = "TPO 16";
                this.lbl_top7.Text = "TPO 17";
                this.lbl_top8.Text = "TPO 18";
                this.lbl_top9.Text = "TPO 19";
                this.lbl_top10.Text = "TPO 20";
            }
        }

        private void btn_LoadTest_Click(object sender, EventArgs e)
        {
            this.rtb_writinganswers.Text = "";
            try
            {
                for (int i = 1; i < 0x1c; i++)
                {
                    string path = @"users\" + USERNAME + @"\" + i.ToString();
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
                this.InitialParas();
                this.flash_timer.Stop();
                Button button = (Button) sender;
                string name = button.Name;
                if (name.Contains("Reading"))
                {
                    this.TestSection = TestingSection.READING;
                }
                if (name.Contains("Listening"))
                {
                    this.TestSection = TestingSection.LISTENING;
                }
                if (name.Contains("Speaking"))
                {
                    this.TestSection = TestingSection.SPEAKING;
                }
                if (name.Contains("Writing"))
                {
                    this.TestSection = TestingSection.WRITING;
                }
                if (name.Contains("Review"))
                {
                    this.TestSection = TestingSection.REVIEW;
                }
                if (name.Contains("Answer"))
                {
                    this.TestSection = TestingSection.VIEWANSWERS;
                }
                if (this.TPONO <= 0)
                {
                    this.TPONO = Convert.ToInt16(name.Substring(name.Length - 2)) + ((this.CurrentTPOPage - 1) * 10);
                }
                if (this.PartNO <= 0)
                {
                    this.PartNO = 1;
                }
                if (this.PassageNO <= 0)
                {
                    this.PassageNO = 1;
                }
                if (!ConstantValues.TPOACTIVED[this.TPONO])
                {
                    if (MessageBox.Show("The TPO" + this.TPONO.ToString() + " is not actived yet, Do you want to buy the product?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                    {
                        Process.Start("http://item.taobao.com/item.htm?id=12627161348");
                        new RegisterForm().Show();
                    }
                    this.TPONO = 0;
                    this.PartNO = 0;
                    this.PassageNO = 0;
                    this.QuestionNO = 0;
                }
                else if (this.CheckFileConsistence())
                {
                    base.btn_continue.Enabled = true;
                    base.btn_continue.Visible = true;
                    this.BottonsStatus();
                    this.rb_PracticeMode.Visible = false;
                    this.rb_TestMode.Visible = false;
                    if (this.rb_PracticeMode.Checked)
                    {
                        base.lbl_mode.Text = "PRACTICE MODE";
                    }
                    else
                    {
                        base.lbl_mode.Text = "TEST MODE";
                    }
                    XMLFileReader reader = new XMLFileReader();
                    switch (this.TestSection)
                    {
                        case TestingSection.READING:
                            this.Timer_Listening.Start();
                            this.lbl_testingSection.Visible = true;
                            this.lbl_testingSection.Text = "Reading Section";
                            base.lbl_timeremain.ForeColor = SystemColors.ControlText;
                            base.lbl_timeremain.Text = "20:00";
                            this.ReadingPassageNo = 1;
                            this.QuestionNO = 0;
                            this.tabf_test.SelectedIndex = READING;
                            this.tabf_Reading.SelectedIndex = RDIRECTION;
                            reader = new XMLFileReader(@"Tests\" + this.TPONO + @"\Reading\config.xml");
                            this.RSpiltQuestionNO = int.Parse(reader.GetAttr("//Passage[@NO=" + this.PassageNO + "]/@spiltQuestionNO"));
                            this.PassageCount = int.Parse(reader.GetAttr("//@passageCount"));
                            base.lbl_timeremain.Text = reader.GetAttr("//Passage[@NO=" + this.PassageNO + "]/@time");
                            this.RMaterial = new TPOPassage(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\" + this.PassageNO.ToString() + ".txt").Substring(0xb5), RtfReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\P" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
                            if (!File.Exists(@"Explanations\" + this.TPONO.ToString() + @"\Reading\" + this.ReadingPassageNo.ToString() + ".mp3") || !ConstantValues.TPOEXPLANATION[this.TPONO])
                            {
                                goto Label_0597;
                            }
                            this.bn_readText.Visible = true;
                            this.bn_readText.Enabled = true;
                            goto Label_05A6;

                        case TestingSection.LISTENING:
                        {
                            this.lbl_testingSection.Visible = true;
                            base.btn_nextQuestion.Enabled = false;
                            base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next.jpg");
                            base.btn_preQuestion.Enabled = false;
                            base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/ok.jpg");
                            base.lbl_timeremain.ForeColor = SystemColors.ControlText;
                            base.lbl_timeremain.Text = "10:00";
                            this.lbl_testingSection.Text = "Listening Section";
                            reader = new XMLFileReader(@"Tests\" + this.TPONO + @"\Listening\questions.xml");
                            this.PartCount = int.Parse(reader.GetAttr("//parts/@partCount"));
                            string attr = reader.GetAttr("//passage[@NO=" + 2 + "]/pictures/picture/@pictureName");
                            base.lbl_timeremain.Text = reader.GetAttr("//part[@NO=" + this.PartNO + "]/@timeLimitation");
                            this.TimeLimitation = DateTime.ParseExact(reader.GetAttr("//part[@NO=" + this.PartNO + "]/@timeLimitation"), "mm:ss", null);
                            this.QuestionCount = int.Parse(reader.GetAttr("//part[@NO=" + this.PartNO + "]/@questionCount"));
                            this.tabf_test.SelectedIndex = LISTENING;
                            this.tabf_Listening.SelectedIndex = LDIRECTION1;
                            if (this.PassageNO <= 1)
                            {
                                this.TestQuestions = new TPOQuestions(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Listening\questions.rtf"), @"Tests\" + this.TPONO.ToString() + @"\Listening\questions.xml", "");
                            }
                            string str4 = reader.GetAttr("//part[@NO=" + this.PartNO + "]/@partDirection");
                            try
                            {
                                this.MP3Player = new MP3MCI();
                                string str5 = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Listening\", str4 });
                                this.MP3Player.FileName = str5;
                                this.PlayFileName.Text = str5;
                                this.pb_currentpos.Maximum = this.MP3Player.Duration;
                                this.pb_currentpos1.Maximum = this.MP3Player.Duration;
                                this.tb_currentpos.Maximum = this.MP3Player.Duration;
                                this.tb_currentpos1.Maximum = this.MP3Player.Duration;
                                this.MP3Player.play();
                                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                this.Timer_Listening.Start();
                            }
                            catch
                            {
                                MessageBox.Show("open出错!");
                            }
                            break;
                        }
                        case TestingSection.SPEAKING:
                            this.lbl_testingSection.Visible = true;
                            this.lbl_testingSection.Text = "Speaking Section";
                            base.btn_nextQuestion.Visible = false;
                            base.btn_preQuestion.Visible = false;
                            this.LoadSpeakingQuestion();
                            this.tabf_test.SelectedIndex = SPEAKING;
                            this.tabf_speaking.SelectedIndex = SDIRECTION;
                            this.QuestionNO = 1;
                            this.CurrentSpeakingStep = 0;
                            this.Timer_Speaking.Start();
                            break;

                        case TestingSection.WRITING:
                            this.Timer_Listening.Start();
                            this.lbl_testingSection.Visible = true;
                            base.btn_nextQuestion.Enabled = false;
                            base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next.jpg");
                            base.lbl_timeremain.ForeColor = SystemColors.ControlText;
                            base.lbl_timeremain.Text = "03:00";
                            this.lbl_testingSection.Text = "Writing Section";
                            base.lbl_questionNO.Text = "Question 1 of 2";
                            this.LoadWritingQuestion();
                            this.tabf_test.SelectedIndex = WRITING;
                            this.tabf_writing.SelectedIndex = WDIRECTION;
                            this.CurrentWritingStep = 0;
                            this.Timer_Speaking.Start();
                            break;

                        case TestingSection.REVIEW:
                        {
                            this.rb_TestMode.Checked = true;
                            int index = this.TPONO % 10;
                            if (index == 0)
                            {
                                index = 10;
                            }
                            this.btn_LoadTest_Click(this.BtnLoadTest[index], e);
                            break;
                        }
                        case TestingSection.VIEWANSWERS:
                            base.btn_continue.Visible = false;
                            this.ReportingScores();
                            this.tabf_test.SelectedIndex = USERANSWERS;
                            this.btn_NexPage.Visible = false;
                            this.btn_LastPage.Visible = false;
                            base.btn_mainmenu.Visible = true;
                            break;
                    }
                }
                return;
            Label_0597:
                this.bn_readText.Visible = false;
            Label_05A6:;
                this.TestQuestions = new TPOQuestions(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\questions" + this.PassageNO.ToString() + ".txt").Substring(0xb5), "", RtfReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\Q" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
                this.QuestionCount = this.TestQuestions.QuestionCount;
                this.LoadReadingMaterialAndQA();
                if (this.rb_PracticeMode.Checked && (MessageBox.Show("Do you want to load the answers you saved last time?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK))
                {
                    this.LoadUserAnswer();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace);
            }
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to QUIT the TEST. Once you quit you CANNOT return!\nClick on OK to go on.\n", "Quit Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.btn_showtranslation.Visible = false;
                this.btn_showexplanation.Visible = false;
                this.InitialParas();
                base.btn_continue.Visible = false;
                for (int i = 4; i < 11; i++)
                {
                    this.BtnLoadTest[i].Enabled = true;
                    this.BtnLoadTest[i + 10].Enabled = true;
                    this.BtnLoadTest[i + 20].Enabled = true;
                    this.BtnLoadTest[i + 30].Enabled = true;
                    this.BtnLoadTest[i + 40].Enabled = true;
                    this.BtnLoadTest[i + 50].Enabled = true;
                }
                this.btn_NexPage.Enabled = true;
                this.TPONO = 0;
                this.PartNO = 0;
                this.PassageNO = 0;
                this.QuestionNO = 0;
                this.rtb_question.Text = "";
                this.rb_TestMode.Visible = true;
                this.rb_PracticeMode.Visible = true;
                this.btn_NexPage.Visible = true;
                this.btn_QUITapp.Visible = true;
                this.btn_LastPage.Visible = true;
                this.CurrentTPOPage = 1;
                this.lbl_top1.Text = "TPO 01";
                this.lbl_top2.Text = "TPO 02";
                this.lbl_top3.Text = "TPO 03";
                this.lbl_top4.Text = "TPO 04";
                this.lbl_top5.Text = "TPO 05";
                this.lbl_top6.Text = "TPO 06";
                this.lbl_top7.Text = "TPO 07";
                this.lbl_top8.Text = "TPO 08";
                this.lbl_top9.Text = "TPO 09";
                this.lbl_top10.Text = "TPO 10";
                this.btn_LastPage.Enabled = false;
                this.tabf_test.SelectedIndex = COVERFORM;
            }
        }

        private void btn_NexPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentTPOPage == 1)
            {
                this.btn_LastPage.Enabled = true;
                this.CurrentTPOPage = 2;
                this.lbl_top1.Text = "TPO 11";
                this.lbl_top2.Text = "TPO 12";
                this.lbl_top3.Text = "TPO 13";
                this.lbl_top4.Text = "TPO 14";
                this.lbl_top5.Text = "TPO 15";
                this.lbl_top6.Text = "TPO 16";
                this.lbl_top7.Text = "TPO 17";
                this.lbl_top8.Text = "TPO 18";
                this.lbl_top9.Text = "TPO 19";
                this.lbl_top10.Text = "TPO 20";
            }
            else if (this.CurrentTPOPage == 2)
            {
                this.CurrentTPOPage = 3;
                this.btn_LastPage.Enabled = true;
                this.btn_NexPage.Enabled = false;
                this.lbl_top1.Text = "TPO 21";
                this.lbl_top2.Text = "TPO 22";
                this.lbl_top3.Text = "TPO 23";
                this.lbl_top4.Text = "TPO 24";
                this.lbl_top5.Text = "TPO 25";
                this.lbl_top6.Text = "TPO 26";
                this.lbl_top7.Text = "TPO 27";
                this.lbl_top8.Text = "TPO 28";
                this.lbl_top9.Text = "TPO 29";
                this.lbl_top10.Text = "TPO 30";
                for (int i = 5; i < 11; i++)
                {
                    this.BtnLoadTest[i].Enabled = false;
                    this.BtnLoadTest[i + 10].Enabled = false;
                    this.BtnLoadTest[i + 20].Enabled = false;
                    this.BtnLoadTest[i + 30].Enabled = false;
                    this.BtnLoadTest[i + 40].Enabled = false;
                    this.BtnLoadTest[i + 50].Enabled = false;
                }
            }
        }

        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    this.RBtn_nextQuestion(e);
                    break;

                case TestingSection.LISTENING:
                    base.btn_preQuestion.Enabled = true;
                    base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/ok1.jpg");
                    base.btn_nextQuestion.Enabled = false;
                    base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next.jpg");
                    this.HasClickedNext = true;
                    break;

                case TestingSection.SPEAKING:
                    base.btn_preQuestion.Enabled = true;
                    base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back1.jpg");
                    if (this.QuestionNO >= 6)
                    {
                        base.btn_nextQuestion.Enabled = false;
                        base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next.jpg");
                        break;
                    }
                    this.QuestionNO++;
                    this.HasLoadMP3 = false;
                    this.CurrentSpeakingStep = 1;
                    break;

                case TestingSection.WRITING:
                    if (!this.rb_PracticeMode.Checked)
                    {
                        this.CurrentWritingStep = 6;
                        base.btn_nextQuestion.Enabled = false;
                        base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next.jpg");
                        this.HasLoadMP3 = false;
                        break;
                    }
                    this.CurrentWritingStep++;
                    base.btn_nextQuestion.Enabled = false;
                    base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next.jpg");
                    this.HasLoadMP3 = false;
                    break;
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (!this.IsPause)
            {
                this.IsPause = true;
                this.MP3Player.Puase();
                this.Timer_Listening.Stop();
                this.Timer_Speaking.Stop();
                this.btn_pause.BackgroundImage = Image.FromFile(@"Tests\Direction\resume.jpg");
            }
            else
            {
                this.IsPause = false;
                this.MP3Player.play();
                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                this.Timer_Listening.Start();
                this.Timer_Speaking.Start();
                this.btn_pause.BackgroundImage = Image.FromFile(@"Tests\Direction\pause.jpg");
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            try
            {
                this.MP3Player.play();
                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                this.Timer_Listening.Start();
            }
            catch
            {
                MessageBox.Show("play出错错误!");
            }
        }

        private void btn_preQuestion_Click(object sender, EventArgs e)
        {
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    if (this.QuestionNO == (this.RSpiltQuestionNO + 1))
                    {
                        this.PreInsertPosition = -1;
                    }
                    this.SaveUserAnswers();
                    this.QuestionNO--;
                    this.LoadReadingMaterialAndQA();
                    break;

                case TestingSection.LISTENING:
                    if (!this.rb_TestMode.Checked || this.HasAnswered())
                    {
                        this.SaveUserAnswers();
                        this.HasClickedNext = false;
                        this.Timer_Listening.Start();
                        if (this.QuestionNO >= this.PassageLastQuestionIndex)
                        {
                            if (this.PassageNO >= this.PartLastPassageIndex)
                            {
                                if (this.PartNO >= this.PartCount)
                                {
                                    if (MessageBox.Show("You have seen all the questions in this listening section.\nClick on Cancel to continue working.\nClick on OK to go on.\nOnce you leave the listening section, you WILL NOT be able to return to it", "Finish Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                                    {
                                        this.PartNO = 0;
                                        this.PassageNO = 0;
                                        this.QuestionNO = 0;
                                        this.TestSection = TestingSection.SPEAKING;
                                        this.btn_LoadTest_Click(sender, e);
                                    }
                                }
                                else if (MessageBox.Show("You have seen all the questions in this part of listening section.\nClick on Cancel to continue working.\nClick on OK to go on.\nOnce you leave the part, you WILL NOT be able to return to it", "Finish Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                                {
                                    this.scoreReport(2);
                                    this.PartNO++;
                                    this.PassageNO++;
                                    this.btn_LoadTest_Click(sender, e);
                                }
                            }
                            else
                            {
                                this.PassageNO++;
                                this.IsQuestionAfter = true;
                                this.QuestionNO++;
                                this.LoadListeningMaterial();
                            }
                        }
                        else
                        {
                            this.QuestionNO++;
                            if (this.IsQuestionAfter)
                            {
                                this.QuestionNO--;
                                this.IsQuestionAfter = false;
                            }
                            this.LoadListeningQA();
                            base.btn_nextQuestion.Enabled = false;
                            base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next.jpg");
                        }
                        break;
                    }
                    MessageBox.Show("You must answer the question!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case TestingSection.SPEAKING:
                    base.btn_nextQuestion.Enabled = true;
                    base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next1.jpg");
                    if (this.QuestionNO > 1)
                    {
                        this.QuestionNO--;
                        this.CurrentSpeakingStep = 1;
                        this.HasLoadMP3 = false;
                    }
                    if (this.QuestionNO <= 1)
                    {
                        base.btn_preQuestion.Enabled = false;
                        base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back.jpg");
                    }
                    break;

                case TestingSection.WRITING:
                    this.CurrentWritingStep--;
                    base.btn_preQuestion.Enabled = false;
                    base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back.jpg");
                    this.HasLoadMP3 = false;
                    break;
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            int num;
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    if (MessageBox.Show("Are you sure you want to QUIT this section. Once you quit you CANNOT return and you will begin the LISTENING Section!\nClick on OK to go on.\n", "Quit Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        num = this.TPONO % 10;
                        if (num == 0)
                        {
                            num = 10;
                        }
                        this.btn_LoadTest_Click(this.BtnLoadTest[10 + num], e);
                        this.PartNO = 1;
                        this.PassageNO = 1;
                        this.QuestionNO = 0;
                    }
                    break;

                case TestingSection.LISTENING:
                    if (MessageBox.Show("Are you sure you want to QUIT this section. Once you quit you CANNOT return and you will begin the SPEAKING Section!\nClick on OK to go on.\n", "Quit Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        num = this.TPONO % 10;
                        if (num == 0)
                        {
                            num = 10;
                        }
                        this.btn_LoadTest_Click(this.BtnLoadTest[20 + num], e);
                        this.PartNO = 1;
                        this.PassageNO = 1;
                        this.QuestionNO = 1;
                    }
                    break;

                case TestingSection.SPEAKING:
                    if (MessageBox.Show("Are you sure you want to QUIT this section. Once you quit you CANNOT return and you will begin the WRITING Section!\nClick on OK to go on.\n", "Quit Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        num = this.TPONO % 10;
                        if (num == 0)
                        {
                            num = 10;
                        }
                        this.btn_LoadTest_Click(this.BtnLoadTest[30 + num], e);
                        this.PartNO = 1;
                        this.PassageNO = 1;
                        this.QuestionNO = 1;
                    }
                    break;

                case TestingSection.WRITING:
                    if (MessageBox.Show("Are you sure you want to QUIT this section. Once you quit you CANNOT return!\nClick on OK to go on.\n", "Quit Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        this.btn_mainmenu_Click(sender, e);
                    }
                    break;
            }
        }

        private void btn_QUITapp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            this.SaveUserAnswers();
            if (this.PartNO == 1)
            {
                this.lbl_scoreReport.Text = this.scoreReport(1);
            }
            else
            {
                this.lbl_scoreReport.Text = this.scoreReport(3);
            }
            this.tabf_test.SelectedIndex = READING;
            this.tabf_Reading.SelectedIndex = RREVIEW;
            if (this.rb_PracticeMode.Checked)
            {
                this.lbl_wrongAnswered.Visible = true;
                this.pb_wrongAnswered.Visible = true;
                this.lbl_rightAnswered.Visible = true;
                this.pb_rightAnswered.Visible = true;
            }
            else
            {
                this.lbl_wrongAnswered.Visible = false;
                this.pb_wrongAnswered.Visible = false;
                this.lbl_rightAnswered.Visible = false;
                this.pb_rightAnswered.Visible = false;
            }
            if (this.TestSection == TestingSection.READING)
            {
                DataTable table = new DataTable();
                DataColumn column = new DataColumn("QuestionID", typeof(int));
                table.Columns.Add(column);
                column = new DataColumn("QuestionExcerpt", typeof(string));
                table.Columns.Add(column);
                column = new DataColumn("QuestionStatus", typeof(string));
                table.Columns.Add(column);
                column = new DataColumn("MyAnswer", typeof(string));
                table.Columns.Add(column);
                if (this.rb_PracticeMode.Checked)
                {
                    column = new DataColumn("StandardAnswer", typeof(string));
                    table.Columns.Add(column);
                }
                RichTextBox box = new RichTextBox();
                for (int i = 0; i < this.TestQuestions.QuestionCount; i++)
                {
                    DataRow row = table.NewRow();
                    Question question = (Question) this.TestQuestions.Questions[i];
                    row["QuestionID"] = question.ID;
                    box.Rtf = question.QuestionTitle;
                    string text = box.Text;
                    if (text.Length > 100)
                    {
                        row["QuestionExcerpt"] = text.Substring(0, 100) + "...";
                    }
                    else
                    {
                        row["QuestionExcerpt"] = text;
                    }
                    if (question.IsAnswered)
                    {
                        row["QuestionStatus"] = "Answered";
                    }
                    else
                    {
                        row["QuestionStatus"] = "Not Answered";
                    }
                    row["MyAnswer"] = question.UserAnswersStr;
                    if (this.rb_PracticeMode.Checked)
                    {
                        row["StandardAnswer"] = question.RightAnswersStr;
                    }
                    table.Rows.Add(row);
                }
                this.dgv_readingReview.DataSource = table;
            }
        }

        private void btn_showexplanation_Click(object sender, EventArgs e)
        {
            this.EXP = new ExplanationUI();
            this.EXP.Show();
        }

        private void btn_ShowText_Click(object sender, EventArgs e)
        {
            this.ShowPassage = !this.ShowPassage;
            this.rtb_sumQuestion.Visible = !this.ShowPassage;
            this.rtb_sumPassage.Visible = this.ShowPassage;
            this.tlp_sumAnswers.Visible = !this.ShowPassage;
            this.tlp_Summary.Visible = !this.ShowPassage;
            if (this.ShowPassage)
            {
                this.tabf_test.SelectedIndex = READING;
                this.tabf_Reading.SelectedIndex = RSUMMARYQUESTION;
                this.btn_ShowText.BackgroundImage = Image.FromFile(@"Tests\Direction\viewquestion.jpg");
            }
            else
            {
                this.btn_ShowText.BackgroundImage = Image.FromFile(@"Tests\Direction\viewtext.jpg");
                Question question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
                if (question.QuestionType == QuestionType.TABEL)
                {
                    this.tabf_test.SelectedIndex = LISTENING;
                    this.tabf_Listening.SelectedIndex = LTABLEQUESTION;
                }
            }
        }

        private void btn_showtranslation_Click(object sender, EventArgs e)
        {
            this.TRANSUI = new TranslationUI();
            this.TRANSUI.Show();
        }

        private void btn_speakinganswer_Click(object sender, EventArgs e)
        {
            this.MP3Player.StopT();
            this.MP3Player = new MP3MCI();
            Button button = (Button) sender;
            string str = button.Name.Substring(button.Name.Length - 1);
            string path = string.Concat(new object[] { Application.StartupPath, @"\users\", USERNAME, @"\", this.TPONO, @"\SpeakingAnswer", str, ".wav" });
            if (File.Exists(path))
            {
                this.MP3Player.FileName = path;
                this.MP3Player.play();
                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
            }
            else
            {
                MessageBox.Show("You didn't answer this question yet!");
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                this.MP3Player.StopT();
            }
            catch
            {
                MessageBox.Show("stop出错错误!");
            }
        }

        private void btn_stopReading_Click(object sender, EventArgs e)
        {
            this.MP3Player.StopT();
            this.MP3Player = new MP3MCI();
            this.bn_readText.Enabled = true;
            this.btn_stopReading.Visible = false;
            this.tb_reading.Visible = false;
            this.Timer_reading.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (base.lbl_timeremain.Visible)
            {
                base.lbl_timeremain.Visible = false;
                base.button1.BackgroundImage = Image.FromFile("Tests/Direction/Showtimer.jpg");
            }
            else
            {
                base.lbl_timeremain.Visible = true;
                base.button1.BackgroundImage = Image.FromFile("Tests/Direction/hidetimer.jpg");
            }
        }

        private void ChangeControlSize(Control control, double scale1, double scale2)
        {
            foreach (Control control2 in control.Controls)
            {
                control2.Top = Convert.ToInt16((double) (Convert.ToDouble(control2.Top) * scale1));
                control2.Left = Convert.ToInt16((double) (Convert.ToDouble(control2.Left) * scale2));
                if (control2.BackgroundImage == null)
                {
                    control2.Height = Convert.ToInt16((double) (Convert.ToDouble(control2.Height) * scale1));
                    control2.Width = Convert.ToInt16((double) (Convert.ToDouble(control2.Width) * scale2));
                }
                this.ChangeControlSize(control2, scale1, scale2);
            }
        }

        private bool CheckFileConsistence()
        {
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    if (MD5Generate.md5_hash(@"Tests\" + this.TPONO.ToString() + @"\Reading\1.txt").Equals(ConstantValues.RMD5[this.TPONO]))
                    {
                        break;
                    }
                    MessageBox.Show("Files load error! You can't edit the files in the fold.");
                    this.TPONO = 0;
                    this.PartNO = 0;
                    this.PassageNO = 0;
                    this.QuestionNO = 0;
                    return false;

                case TestingSection.LISTENING:
                    if (MD5Generate.md5_hash(@"Tests\" + this.TPONO.ToString() + @"\Listening\questions.rtf").Equals(ConstantValues.LMD5[this.TPONO]))
                    {
                        break;
                    }
                    MessageBox.Show("Files load error! You can't edit the files in the fold.");
                    this.TPONO = 0;
                    this.PartNO = 0;
                    this.PassageNO = 0;
                    this.QuestionNO = 0;
                    return false;

                case TestingSection.SPEAKING:
                    if (MD5Generate.md5_hash(@"Tests\" + this.TPONO.ToString() + @"\Speaking\questions.rtf").Equals(ConstantValues.SMD5[this.TPONO]))
                    {
                        break;
                    }
                    MessageBox.Show("Files load error! You can't edit the files in the fold.");
                    this.TPONO = 0;
                    this.PartNO = 0;
                    this.PassageNO = 0;
                    this.QuestionNO = 0;
                    return false;

                case TestingSection.WRITING:
                    if (MD5Generate.md5_hash(@"Tests\" + this.TPONO.ToString() + @"\Writing\Speech.mp3").Equals(ConstantValues.WMD5[this.TPONO]))
                    {
                        break;
                    }
                    MessageBox.Show("Files load error! You can't edit the files in the fold.");
                    this.TPONO = 0;
                    this.PartNO = 0;
                    this.PassageNO = 0;
                    this.QuestionNO = 0;
                    return false;
            }
            return true;
        }

        public void Ckb_CheckedChanged(object sender, EventArgs e)
        {
            Question question;
            int num;
            CheckBox ckb = (CheckBox) sender;
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    if (!ckb.Checked)
                    {
                        return;
                    }
                    question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
                    this.SaveUserAnswers();
                    if (question.RightAnswers.Length == 1)
                    {
                        ckb.Enabled = false;
                        for (num = 0; num < this.CkbReading.Length; num++)
                        {
                            if (ckb != this.CkbReading[num])
                            {
                                this.CkbReading[num].Checked = false;
                                this.CkbReading[num].Enabled = true;
                            }
                        }
                    }
                    break;

                case TestingSection.LISTENING:
                    if (ckb.Checked)
                    {
                        question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
                        num = 0;
                        while (num < 9)
                        {
                            this.OnlyOneCheck(this.LCkbTable[num], ckb);
                            num++;
                        }
                        if (question.RightAnswers.Length == 1)
                        {
                            ckb.Enabled = false;
                            for (num = 0; num < this.LCkbAnswers.Length; num++)
                            {
                                if (ckb != this.LCkbAnswers[num])
                                {
                                    this.LCkbAnswers[num].Checked = false;
                                    this.LCkbAnswers[num].Enabled = true;
                                }
                            }
                        }
                    }
                    return;

                default:
                    return;
            }
            for (num = 0; num < 9; num++)
            {
                this.OnlyOneCheck(this.LCkbTable[num], ckb);
            }
        }

        private void ckb_ShowAnswer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int num;
                Question question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
                if (this.TestSection != TestingSection.READING)
                {
                    goto Label_0185;
                }
                switch (question.QuestionType)
                {
                    case QuestionType.SUMMARY:
                        num = 0;
                        goto Label_00C0;

                    case QuestionType.TABEL:
                        if (!this.ckb_ShowAnswer.Checked)
                        {
                            goto Label_0109;
                        }
                        this.lbl_tableAnswer.Visible = true;
                        this.lbl_tableAnswer.Text = question.RightAnswersStr;
                        return;

                    default:
                        num = 0;
                        while (num < question.RightAnswers.Length)
                        {
                            if (this.ckb_ShowAnswer.Checked)
                            {
                                this.RtbReadingAnswers[question.RightAnswers[num] - 1].BackColor = Color.LightPink;
                            }
                            else
                            {
                                this.RtbReadingAnswers[question.RightAnswers[num] - 1].BackColor = SystemColors.ControlLight;
                            }
                            num++;
                        }
                        return;
                }
            Label_0054:
                if (this.ckb_ShowAnswer.Checked)
                {
                    this.RtbSumAnswersToBeSelected[question.RightAnswers[num] - 1].Visible = true;
                    this.RtbSumAnswersToBeSelected[question.RightAnswers[num] - 1].BackColor = Color.LightPink;
                }
                else
                {
                    this.RtbSumAnswersToBeSelected[question.RightAnswers[num] - 1].BackColor = SystemColors.ControlLightLight;
                }
                num++;
            Label_00C0:
                if (num < question.RightAnswers.Length)
                {
                    goto Label_0054;
                }
                return;
            Label_0109:
                this.lbl_tableAnswer.Visible = false;
                return;
            Label_0185:
                if (this.TestSection == TestingSection.LISTENING)
                {
                    switch (question.QuestionType)
                    {
                        case QuestionType.TABEL:
                            if (!this.ckb_ShowAnswer.Checked)
                            {
                                goto Label_0233;
                            }
                            this.lbl_tableAnswer.Visible = true;
                            this.lbl_tableAnswer.Text = question.RightAnswersStr;
                            return;

                        case QuestionType.SORT:
                            if (!this.ckb_ShowAnswer.Checked)
                            {
                                break;
                            }
                            this.llbl_rightAnswer.Text = question.RightAnswersStr;
                            this.llbl_rightAnswer.Visible = true;
                            return;

                        default:
                            goto Label_0242;
                    }
                    this.llbl_rightAnswer.Visible = false;
                }
                return;
            Label_0233:
                this.lbl_tableAnswer.Visible = false;
                return;
            Label_0242:
                num = 0;
                while (num < question.RightAnswers.Length)
                {
                    if (this.ckb_ShowAnswer.Checked)
                    {
                        this.LRtbAnswers[question.RightAnswers[num] - 1].BackColor = Color.LightPink;
                    }
                    else
                    {
                        this.LRtbAnswers[question.RightAnswers[num] - 1].BackColor = SystemColors.ControlLight;
                    }
                    num++;
                }
            }
            catch
            {
            }
        }

        private void ckb_viewSpeakingText_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckb_viewSpeakingText.Checked)
            {
                this.tabf_Listening.SelectedIndex = LMATERIALS;
            }
            else
            {
                this.tabf_Listening.SelectedIndex = LMATERIALS1;
            }
        }

        private void CkbSummary_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox) sender;
            if (box.Checked)
            {
                string name = box.Name;
                int num = Convert.ToInt16(name.Substring(name.Length - 1));
                this.SummarySelectedAnswers[this.SummarySelectedAnswerIndex - 1] = num;
                this.CkbSummarySelected[this.SummarySelectedAnswerIndex - 1].Visible = true;
                this.CkbSummarySelected[this.SummarySelectedAnswerIndex - 1].Text = box.Text;
                this.RtbSumSelected[this.SummarySelectedAnswerIndex - 1].Visible = true;
                this.RtbSumSelected[this.SummarySelectedAnswerIndex - 1].Rtf = this.RtbSumAnswersToBeSelected[num - 1].Rtf;
                if (!this.ckb_ShowAnswer.Checked)
                {
                    this.RtbSumAnswersToBeSelected[num - 1].Visible = false;
                }
                box.Visible = false;
                box.Checked = false;
                this.SummarySelectedAnswerIndex = -1;
                if (this.RtbPreviousSelected != null)
                {
                    this.RtbPreviousSelected.BackColor = Color.LightGray;
                }
                this.RtbPreviousSelected = null;
                for (int i = 0; i < 10; i++)
                {
                    this.CkbSummary[i].Enabled = false;
                }
            }
        }

        private void CkbSummarySelected_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox) sender;
            if (!box.Checked)
            {
                string name = box.Name;
                int num = Convert.ToInt16(name.Substring(name.Length - 1));
                int num2 = this.SummarySelectedAnswers[num - 1];
                this.SummarySelectedAnswers[num - 1] = 0;
                box.Visible = false;
                box.Text = "";
                this.RtbSumSelected[num - 1].Text = "";
                this.RtbSumAnswersToBeSelected[num2 - 1].Visible = true;
                this.CkbSummary[num2 - 1].Visible = true;
                box.Checked = true;
                this.SummarySelectedAnswerIndex = -1;
                if (this.RtbPreviousSelected != null)
                {
                    this.RtbPreviousSelected.BackColor = Color.LightGray;
                }
                this.RtbPreviousSelected = null;
                for (int i = 0; i < 10; i++)
                {
                    this.CkbSummary[i].Enabled = false;
                }
            }
        }

        private void dgv_readinganswers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView view = (DataGridView) sender;
            for (int i = 0; i < view.Rows.Count; i++)
            {
                DataGridViewRow row = view.Rows[i];
                if ((i % 2) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
                if (row.Cells["MyAnswer"].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                if (row.Cells["MyAnswer"].Value.ToString().Equals(row.Cells["StandardAnswer"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else if (!row.Cells["MyAnswer"].Value.ToString().Equals(""))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void dgv_readingReview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((this.dgv_readingReview.SelectedRows != null) && (this.dgv_readingReview.SelectedRows.Count > 0))
            {
                this.ReviewSelectedQuestionNO = Convert.ToInt16(this.dgv_readingReview.SelectedRows[0].Cells["QuestionID"].Value);
                if (this.ReviewSelectedQuestionNO != -1)
                {
                    int num;
                    if ((this.QuestionNO <= this.RSpiltQuestionNO) && (this.ReviewSelectedQuestionNO > this.RSpiltQuestionNO))
                    {
                        this.ReadingPassageNo = 3;
                        this.PreInsertPosition = -1;
                    }
                    if ((this.QuestionNO > this.RSpiltQuestionNO) && (this.ReviewSelectedQuestionNO <= this.RSpiltQuestionNO))
                    {
                        this.ReadingPassageNo = 2;
                        this.PreInsertPosition = -1;
                    }
                    this.QuestionNO = this.ReviewSelectedQuestionNO;
                    for (num = 0; num < this.CkbReading.Length; num++)
                    {
                        this.CkbReading[num].Visible = false;
                    }
                    for (num = 0; num < this.RtbReadingAnswers.Length; num++)
                    {
                        this.RtbReadingAnswers[num].Visible = false;
                    }
                    this.LoadReadingMaterialAndQA();
                }
            }
        }

        private void dgv_readingReview_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dgv_readingReview.ClearSelection();
            this.ReviewSelectedQuestionNO = -1;
        }

        private void dgv_readingReview_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.dgv_readingReview.Rows.Count; i++)
            {
                DataGridViewRow row = this.dgv_readingReview.Rows[i];
                if ((i % 2) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
                if (row.Cells["MyAnswer"].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (this.rb_PracticeMode.Checked)
                {
                    if (row.Cells["MyAnswer"].Value.ToString().Equals(row.Cells["StandardAnswer"].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void flash_timer_Tick(object sender, EventArgs e)
        {
            if (base.lbl_timeremain.Visible)
            {
                base.lbl_timeremain.Visible = false;
                this.flash_timer.Interval = 250;
            }
            else
            {
                base.lbl_timeremain.Visible = true;
                this.flash_timer.Interval = 750;
            }
        }

        private bool HasAnswered()
        {
            int num;
            Question question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
            if ((question.QuestionType == QuestionType.SINGLE) || (question.QuestionType == QuestionType.MULTIPLE))
            {
                for (num = 0; num < this.LCkbAnswers.Length; num++)
                {
                    if (this.LCkbAnswers[num].Checked)
                    {
                        return true;
                    }
                }
            }
            else if (question.QuestionType == QuestionType.TABEL)
            {
                for (num = 0; num < this.LCkbTable.Length; num++)
                {
                    for (int i = 0; i < this.LCkbTable[num].Length; i++)
                    {
                        if (this.LCkbTable[num][i].Checked)
                        {
                            return true;
                        }
                    }
                }
            }
            else if (question.QuestionType == QuestionType.SORT)
            {
                return true;
            }
            return false;
        }

        private bool HasReachedEndOfSection()
        {
            return (this.QuestionNO == this.QuestionCount);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(MainForm));
            this.openMp3File = new OpenFileDialog();
            this.Timer_Listening = new Timer(this.components);
            this.tabf_test = new TabControl();
            this.tab_CoverForm = new TabPage();
            this.tabf_tposelection = new TabControl();
            this.TPO10 = new TabPage();
            this.btn_Review10 = new Button();
            this.btn_Review09 = new Button();
            this.btn_Review08 = new Button();
            this.btn_Review07 = new Button();
            this.btn_Review06 = new Button();
            this.btn_Review05 = new Button();
            this.btn_Review04 = new Button();
            this.btn_Review03 = new Button();
            this.btn_Review02 = new Button();
            this.btn_Review01 = new Button();
            this.btn_Answer10 = new Button();
            this.btn_Answer09 = new Button();
            this.btn_Answer08 = new Button();
            this.btn_Answer07 = new Button();
            this.btn_Answer06 = new Button();
            this.btn_Answer05 = new Button();
            this.btn_Answer04 = new Button();
            this.btn_Answer03 = new Button();
            this.btn_Answer02 = new Button();
            this.btn_Answer01 = new Button();
            this.btn_LoadSpeaking10 = new Button();
            this.btn_LoadWriting10 = new Button();
            this.btn_LoadListening10 = new Button();
            this.btn_LoadReading10 = new Button();
            this.btn_LoadSpeaking09 = new Button();
            this.btn_LoadWriting09 = new Button();
            this.btn_LoadListening09 = new Button();
            this.btn_LoadReading09 = new Button();
            this.btn_LoadSpeaking08 = new Button();
            this.btn_LoadWriting08 = new Button();
            this.btn_LoadListening08 = new Button();
            this.btn_LoadReading08 = new Button();
            this.btn_LoadSpeaking07 = new Button();
            this.btn_LoadWriting07 = new Button();
            this.btn_LoadListening07 = new Button();
            this.btn_LoadReading07 = new Button();
            this.btn_LoadSpeaking06 = new Button();
            this.btn_LoadWriting06 = new Button();
            this.btn_LoadListening06 = new Button();
            this.btn_LoadReading06 = new Button();
            this.btn_LoadSpeaking05 = new Button();
            this.btn_LoadWriting05 = new Button();
            this.btn_LoadListening05 = new Button();
            this.btn_LoadReading05 = new Button();
            this.btn_LoadSpeaking04 = new Button();
            this.btn_LoadWriting04 = new Button();
            this.btn_LoadListening04 = new Button();
            this.btn_LoadReading04 = new Button();
            this.btn_LoadSpeaking03 = new Button();
            this.btn_LoadWriting03 = new Button();
            this.btn_LoadListening03 = new Button();
            this.btn_LoadReading03 = new Button();
            this.btn_LoadSpeaking02 = new Button();
            this.btn_LoadWriting02 = new Button();
            this.btn_LoadListening02 = new Button();
            this.btn_LoadReading02 = new Button();
            this.btn_LoadSpeaking01 = new Button();
            this.btn_LoadWriting01 = new Button();
            this.btn_LoadListening01 = new Button();
            this.btn_LoadReading01 = new Button();
            this.lbl_top5 = new Label();
            this.lbl_top8 = new Label();
            this.lbl_top10 = new Label();
            this.lbl_top9 = new Label();
            this.lbl_top7 = new Label();
            this.lbl_top6 = new Label();
            this.lbl_top4 = new Label();
            this.lbl_top3 = new Label();
            this.lbl_top2 = new Label();
            this.lbl_top1 = new Label();
            this.tab_Reading = new TabPage();
            this.tabf_Reading = new TabControl();
            this.rtab_Direction = new TabPage();
            this.pictureBox2 = new PictureBox();
            this.rtab_NormalQuestion = new TabPage();
            this.tb_reading = new TrackBar();
            this.rtb_Passage = new RichTextBox();
            this.flowLayoutPanel1 = new FlowLayoutPanel();
            this.rtb_question = new RichTextBox();
            this.tlp_answers = new TableLayoutPanel();
            this.rtb_answerE = new RichTextBox();
            this.rtb_answerD = new RichTextBox();
            this.rtb_answerC = new RichTextBox();
            this.rtb_answerB = new RichTextBox();
            this.ckb_A = new CheckBox();
            this.ckb_B = new CheckBox();
            this.ckb_C = new CheckBox();
            this.ckb_D = new CheckBox();
            this.ckb_E = new CheckBox();
            this.rtb_answerA = new RichTextBox();
            this.ckb_F = new CheckBox();
            this.ckb_G = new CheckBox();
            this.ckb_H = new CheckBox();
            this.rtb_answerF = new RichTextBox();
            this.rtb_answerG = new RichTextBox();
            this.rtb_answerH = new RichTextBox();
            this.btn_stopReading = new Button();
            this.bn_readText = new Button();
            this.lbl_readingIndication = new Label();
            this.rtab_SumQuestion = new TabPage();
            this.llbl_rightAnswer = new Label();
            this.flowLayoutPanel2 = new FlowLayoutPanel();
            this.rtb_sumPassage = new RichTextBox();
            this.rtb_sumQuestion = new RichTextBox();
            this.tlp_sumAnswers = new TableLayoutPanel();
            this.rtb_SumSelected5 = new RichTextBox();
            this.rtb_SumSelected1 = new RichTextBox();
            this.rtb_SumSelected2 = new RichTextBox();
            this.rtb_SumSelected3 = new RichTextBox();
            this.rtb_SumSelected4 = new RichTextBox();
            this.ckb_SumSelected1 = new CheckBox();
            this.ckb_SumSelected2 = new CheckBox();
            this.ckb_SumSelected3 = new CheckBox();
            this.ckb_SumSelected4 = new CheckBox();
            this.ckb_SumSelected5 = new CheckBox();
            this.tlp_Summary = new TableLayoutPanel();
            this.rtb_sumAnswer5 = new RichTextBox();
            this.rtb_sumAnswer1 = new RichTextBox();
            this.rtb_sumAnswer2 = new RichTextBox();
            this.rtb_sumAnswer3 = new RichTextBox();
            this.rtb_sumAnswer4 = new RichTextBox();
            this.ckb_sumAnswer1 = new CheckBox();
            this.ckb_sumAnswer2 = new CheckBox();
            this.ckb_sumAnswer3 = new CheckBox();
            this.ckb_sumAnswer4 = new CheckBox();
            this.ckb_sumAnswer5 = new CheckBox();
            this.ckb_sumAnswer6 = new CheckBox();
            this.rtb_sumAnswer6 = new RichTextBox();
            this.ckb_sumAnswer7 = new CheckBox();
            this.ckb_sumAnswer8 = new CheckBox();
            this.rtb_sumAnswer7 = new RichTextBox();
            this.rtb_sumAnswer8 = new RichTextBox();
            this.ckb_sumAnswer9 = new CheckBox();
            this.ckb_sumAnswer10 = new CheckBox();
            this.rtb_sumAnswer9 = new RichTextBox();
            this.rtb_sumAnswer10 = new RichTextBox();
            this.rtab_Review = new TabPage();
            this.lbl_scoreReport = new Label();
            this.lbl_wrongAnswered = new Label();
            this.pb_wrongAnswered = new PictureBox();
            this.lbl_rightAnswered = new Label();
            this.pb_rightAnswered = new PictureBox();
            this.label1 = new Label();
            this.pictureBox5 = new PictureBox();
            this.dgv_readingReview = new DataGridView();
            this.tab_Listening = new TabPage();
            this.tabf_Listening = new TabControl();
            this.ltab_Direction1 = new TabPage();
            this.pictureBox1 = new PictureBox();
            this.ltab_Direction2 = new TabPage();
            this.ltab_Materials = new TabPage();
            this.l_splitContainer = new SplitContainer();
            this.pb_currentpos = new ProgressBar();
            this.tb_currentpos = new TrackBar();
            this.PlayFileName = new Label();
            this.pb_ListenScene = new PictureBox();
            this.panel1 = new Panel();
            this.flp_passage = new FlowLayoutPanel();
            this.lnk_passage = new LinkLabel();
            this.lMaterials1 = new TabPage();
            this.tb_currentpos1 = new TrackBar();
            this.pb_currentpos1 = new ProgressBar();
            this.pb_ListenScene1 = new PictureBox();
            this.ltab_Question = new TabPage();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.lrtb_question = new RichTextBox();
            this.lrtb_answerE = new RichTextBox();
            this.lrtb_answerD = new RichTextBox();
            this.lrtb_answerC = new RichTextBox();
            this.lrtb_answerB = new RichTextBox();
            this.lckb_A = new CheckBox();
            this.lckb_B = new CheckBox();
            this.lckb_C = new CheckBox();
            this.lckb_D = new CheckBox();
            this.lckb_E = new CheckBox();
            this.lckb_F = new CheckBox();
            this.lckb_G = new CheckBox();
            this.lckb_H = new CheckBox();
            this.lrtb_answerF = new RichTextBox();
            this.lrtb_answerG = new RichTextBox();
            this.lrtb_answerH = new RichTextBox();
            this.lrtb_answerA = new RichTextBox();
            this.lTableQuestion = new TabPage();
            this.lbl_tableAnswer = new Label();
            this.lrtbTableQuestion = new RichTextBox();
            this.ltlp_table = new TableLayoutPanel();
            this.lckbTable11 = new CheckBox();
            this.lckbTable12 = new CheckBox();
            this.lckbTable13 = new CheckBox();
            this.lckbTable14 = new CheckBox();
            this.lckbTable15 = new CheckBox();
            this.lckbTable25 = new CheckBox();
            this.lckbTable24 = new CheckBox();
            this.lckbTable23 = new CheckBox();
            this.lckbTable22 = new CheckBox();
            this.lckbTable21 = new CheckBox();
            this.lckbTable32 = new CheckBox();
            this.lckbTable33 = new CheckBox();
            this.lckbTable34 = new CheckBox();
            this.lckbTable35 = new CheckBox();
            this.lckbTable43 = new CheckBox();
            this.lckbTable41 = new CheckBox();
            this.lckbTable31 = new CheckBox();
            this.lckbTable42 = new CheckBox();
            this.lckbTable44 = new CheckBox();
            this.lckbTable45 = new CheckBox();
            this.lckbTable55 = new CheckBox();
            this.lckbTable54 = new CheckBox();
            this.lckbTable53 = new CheckBox();
            this.lckbTable52 = new CheckBox();
            this.lckbTable51 = new CheckBox();
            this.lckbTable61 = new CheckBox();
            this.lckbTable62 = new CheckBox();
            this.lckbTable63 = new CheckBox();
            this.lckbTable64 = new CheckBox();
            this.lckbTable65 = new CheckBox();
            this.lckbTable71 = new CheckBox();
            this.lckbTable72 = new CheckBox();
            this.lckbTable73 = new CheckBox();
            this.lckbTable74 = new CheckBox();
            this.lckbTable75 = new CheckBox();
            this.lckbTable85 = new CheckBox();
            this.lckbTable84 = new CheckBox();
            this.lckbTable83 = new CheckBox();
            this.lckbTable82 = new CheckBox();
            this.lckbTable81 = new CheckBox();
            this.lckbTable91 = new CheckBox();
            this.lckbTable92 = new CheckBox();
            this.lckbTable93 = new CheckBox();
            this.lckbTable94 = new CheckBox();
            this.lckbTable95 = new CheckBox();
            this.lrtbTableCol1 = new RichTextBox();
            this.lrtbTableCol2 = new RichTextBox();
            this.lrtbTableCol3 = new RichTextBox();
            this.lrtbTableCol5 = new RichTextBox();
            this.lrtbTableRow1 = new RichTextBox();
            this.lrtbTableRow2 = new RichTextBox();
            this.lrtbTableRow3 = new RichTextBox();
            this.lrtbTableRow4 = new RichTextBox();
            this.lrtbTableRow5 = new RichTextBox();
            this.lrtbTableRow6 = new RichTextBox();
            this.lrtbTableRow7 = new RichTextBox();
            this.lrtbTableRow8 = new RichTextBox();
            this.lrtbTableRow9 = new RichTextBox();
            this.lrtbTableCol4 = new RichTextBox();
            this.tab_Speaking = new TabPage();
            this.tabf_speaking = new TabControl();
            this.sDirection = new TabPage();
            this.pictureBox3 = new PictureBox();
            this.sNormalQuestions = new TabPage();
            this.spb = new ProgressBar();
            this.tableLayoutPanel3 = new TableLayoutPanel();
            this.srtb_timer = new Label();
            this.srtb_timeindicator = new Label();
            this.srtb_introduction = new RichTextBox();
            this.pb_speakingScene = new PictureBox();
            this.tab_Writing = new TabPage();
            this.tabf_writing = new TabControl();
            this.wDirection = new TabPage();
            this.pictureBox4 = new PictureBox();
            this.wReading = new TabPage();
            this.wrtb_writing1 = new RichTextBox();
            this.wrtb_reading = new RichTextBox();
            this.wSpeakingPassage = new TabPage();
            this.wpb_speak = new ProgressBar();
            this.wtb_speak = new TrackBar();
            this.pb_writingScene = new PictureBox();
            this.wWriting2 = new TabPage();
            this.lbl_writeDirection = new Label();
            this.wrtb_writing2 = new RichTextBox();
            this.wrtbQuestion2 = new RichTextBox();
            this.wpanel = new Panel();
            this.wlbl_wordcount = new Label();
            this.wbtn_wordcount = new Button();
            this.wbtn_redo = new Button();
            this.wbtn_undo = new Button();
            this.wbtn_paste = new Button();
            this.wbtn_cut = new Button();
            this.tabPage1 = new TabPage();
            this.tabf_answer = new TabControl();
            this.tab_readinganswer = new TabPage();
            this.label2 = new Label();
            this.lbl_readingscorereport = new Label();
            this.label3 = new Label();
            this.pictureBox6 = new PictureBox();
            this.label4 = new Label();
            this.pictureBox7 = new PictureBox();
            this.label5 = new Label();
            this.pictureBox8 = new PictureBox();
            this.dgv_readinganswers = new DataGridView();
            this.tab_listeninganswers = new TabPage();
            this.label16 = new Label();
            this.dgv_listeninganswers = new DataGridView();
            this.lbl_listeningScorereport = new Label();
            this.label7 = new Label();
            this.pictureBox9 = new PictureBox();
            this.label8 = new Label();
            this.pictureBox10 = new PictureBox();
            this.label9 = new Label();
            this.pictureBox11 = new PictureBox();
            this.tab_speakinganswers = new TabPage();
            this.tableLayoutPanel2 = new TableLayoutPanel();
            this.label10 = new Label();
            this.label11 = new Label();
            this.label12 = new Label();
            this.label13 = new Label();
            this.label14 = new Label();
            this.label15 = new Label();
            this.btn_speakinganswer1 = new Button();
            this.btn_speakinganswer2 = new Button();
            this.btn_speakinganswer3 = new Button();
            this.btn_speakinganswer4 = new Button();
            this.btn_speakinganswer5 = new Button();
            this.btn_speakinganswer6 = new Button();
            this.tab_writinganswers = new TabPage();
            this.rtb_writinganswers = new RichTextBox();
            this.rtb_writing2 = new RadioButton();
            this.rtb_writing1 = new RadioButton();
            this.btn_ShowText = new Button();
            this.flash_timer = new Timer(this.components);
            this.Timer_Speaking = new Timer(this.components);
            this.ckb_viewSpeakingText = new CheckBox();
            this.lbl_testingSection = new Label();
            this.btn_LastPage = new Button();
            this.btn_NexPage = new Button();
            this.rb_PracticeMode = new RadioButton();
            this.rb_TestMode = new RadioButton();
            this.ckb_ShowAnswer = new CheckBox();
            this.btn_pause = new Button();
            this.btn_QUITapp = new Button();
            this.bgimagelist = new ImageList(this.components);
            this.btn_showexplanation = new Button();
            this.btn_showtranslation = new Button();
            this.Timer_reading = new Timer(this.components);
            base.tb_sound.BeginInit();
            this.tabf_test.SuspendLayout();
            this.tab_CoverForm.SuspendLayout();
            this.tabf_tposelection.SuspendLayout();
            this.TPO10.SuspendLayout();
            this.tab_Reading.SuspendLayout();
            this.tabf_Reading.SuspendLayout();
            this.rtab_Direction.SuspendLayout();
            ((ISupportInitialize) this.pictureBox2).BeginInit();
            this.rtab_NormalQuestion.SuspendLayout();
            this.tb_reading.BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tlp_answers.SuspendLayout();
            this.rtab_SumQuestion.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tlp_sumAnswers.SuspendLayout();
            this.tlp_Summary.SuspendLayout();
            this.rtab_Review.SuspendLayout();
            ((ISupportInitialize) this.pb_wrongAnswered).BeginInit();
            ((ISupportInitialize) this.pb_rightAnswered).BeginInit();
            ((ISupportInitialize) this.pictureBox5).BeginInit();
            ((ISupportInitialize) this.dgv_readingReview).BeginInit();
            this.tab_Listening.SuspendLayout();
            this.tabf_Listening.SuspendLayout();
            this.ltab_Direction1.SuspendLayout();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            this.ltab_Materials.SuspendLayout();
            this.l_splitContainer.Panel1.SuspendLayout();
            this.l_splitContainer.Panel2.SuspendLayout();
            this.l_splitContainer.SuspendLayout();
            this.tb_currentpos.BeginInit();
            ((ISupportInitialize) this.pb_ListenScene).BeginInit();
            this.panel1.SuspendLayout();
            this.flp_passage.SuspendLayout();
            this.lMaterials1.SuspendLayout();
            this.tb_currentpos1.BeginInit();
            ((ISupportInitialize) this.pb_ListenScene1).BeginInit();
            this.ltab_Question.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.lTableQuestion.SuspendLayout();
            this.ltlp_table.SuspendLayout();
            this.tab_Speaking.SuspendLayout();
            this.tabf_speaking.SuspendLayout();
            this.sDirection.SuspendLayout();
            ((ISupportInitialize) this.pictureBox3).BeginInit();
            this.sNormalQuestions.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((ISupportInitialize) this.pb_speakingScene).BeginInit();
            this.tab_Writing.SuspendLayout();
            this.tabf_writing.SuspendLayout();
            this.wDirection.SuspendLayout();
            ((ISupportInitialize) this.pictureBox4).BeginInit();
            this.wReading.SuspendLayout();
            this.wSpeakingPassage.SuspendLayout();
            this.wtb_speak.BeginInit();
            ((ISupportInitialize) this.pb_writingScene).BeginInit();
            this.wWriting2.SuspendLayout();
            this.wpanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabf_answer.SuspendLayout();
            this.tab_readinganswer.SuspendLayout();
            ((ISupportInitialize) this.pictureBox6).BeginInit();
            ((ISupportInitialize) this.pictureBox7).BeginInit();
            ((ISupportInitialize) this.pictureBox8).BeginInit();
            ((ISupportInitialize) this.dgv_readinganswers).BeginInit();
            this.tab_listeninganswers.SuspendLayout();
            ((ISupportInitialize) this.dgv_listeninganswers).BeginInit();
            ((ISupportInitialize) this.pictureBox9).BeginInit();
            ((ISupportInitialize) this.pictureBox10).BeginInit();
            ((ISupportInitialize) this.pictureBox11).BeginInit();
            this.tab_speakinganswers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tab_writinganswers.SuspendLayout();
            base.SuspendLayout();
            base.btn_mainmenu.BackgroundImage = (Image) manager.GetObject("btn_mainmenu.BackgroundImage");
            base.btn_mainmenu.BackgroundImageLayout = ImageLayout.Stretch;
            base.btn_mainmenu.FlatAppearance.BorderSize = 0;
            base.btn_mainmenu.FlatStyle = FlatStyle.Flat;
            base.btn_mainmenu.Location = new Point(3, 0x1d);
            base.btn_mainmenu.TabStop = false;
            base.btn_mainmenu.Text = "";
            base.btn_mainmenu.Visible = false;
            base.btn_mainmenu.Click += new EventHandler(this.btn_mainmenu_Click);
            base.btn_quit.BackgroundImage = (Image) manager.GetObject("btn_quit.BackgroundImage");
            base.btn_quit.BackgroundImageLayout = ImageLayout.Stretch;
            base.btn_quit.FlatAppearance.BorderSize = 0;
            base.btn_quit.FlatStyle = FlatStyle.Flat;
            base.btn_quit.Location = new Point(0x34, 0x1d);
            base.btn_quit.TabStop = false;
            base.btn_quit.Text = "";
            base.btn_quit.Visible = false;
            base.btn_quit.Click += new EventHandler(this.btn_quit_Click);
            base.tb_sound.BackColor = Color.Silver;
            base.tb_sound.Location = new Point(490, 0x2e);
            base.tb_sound.Maximum = 0x7d0;
            base.tb_sound.Size = new Size(110, 0x20);
            base.tb_sound.SmallChange = 100;
            base.tb_sound.TickFrequency = 10;
            base.tb_sound.TickStyle = TickStyle.None;
            base.tb_sound.Value = 0x3e8;
            base.tb_sound.Visible = false;
            base.tb_sound.Scroll += new EventHandler(this.tb_sound_Scroll);
            base.Sound_icon.BackgroundImage = (Image) manager.GetObject("Sound_icon.BackgroundImage");
            base.Sound_icon.Location = new Point(0x255, 0x27);
            base.Sound_icon.Size = new Size(0x4a, 0x27);
            base.Sound_icon.Visible = false;
            base.Sound_icon.MouseClick += new MouseEventHandler(this.Sound_icon_MouseClick);
            base.lbl_mode.BackColor = Color.Transparent;
            base.lbl_mode.BorderStyle = BorderStyle.None;
            base.lbl_mode.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            base.lbl_mode.Location = new Point(0x151, 0x2b);
            base.lbl_mode.Size = new Size(0x6f, 0x11);
            base.lbl_mode.Visible = false;
            base.lbl_questionNO.BackColor = Color.Transparent;
            base.lbl_questionNO.BorderStyle = BorderStyle.None;
            base.lbl_questionNO.Font = new Font("SimSun", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            base.lbl_questionNO.Location = new Point(0x155, 60);
            base.lbl_questionNO.Text = "";
            base.lbl_questionNO.Visible = false;
            base.button1.BackgroundImage = (Image) manager.GetObject("button1.BackgroundImage");
            base.button1.BackgroundImageLayout = ImageLayout.Stretch;
            base.button1.FlatAppearance.BorderSize = 0;
            base.button1.FlatStyle = FlatStyle.Flat;
            base.button1.Location = new Point(0x28c, 0x2e);
            base.button1.Size = new Size(90, 0x20);
            base.button1.TabStop = false;
            base.button1.Text = "";
            base.button1.Visible = false;
            base.button1.Click += new EventHandler(this.button1_Click);
            base.lbl_timeremain.BackColor = Color.Transparent;
            base.lbl_timeremain.BorderStyle = BorderStyle.None;
            base.lbl_timeremain.Location = new Point(0x2d2, 0x36);
            base.lbl_timeremain.Size = new Size(50, 0x11);
            base.lbl_timeremain.Visible = false;
            base.btn_continue.BackgroundImage = (Image) manager.GetObject("btn_continue.BackgroundImage");
            base.btn_continue.BackgroundImageLayout = ImageLayout.Stretch;
            base.btn_continue.FlatAppearance.BorderSize = 0;
            base.btn_continue.FlatStyle = FlatStyle.Flat;
            base.btn_continue.Location = new Point(0x2bd, 1);
            base.btn_continue.Size = new Size(0x56, 0x25);
            base.btn_continue.TabStop = false;
            base.btn_continue.Text = "";
            base.btn_continue.Visible = false;
            base.btn_continue.Click += new EventHandler(this.btn_continue_Click);
            base.btn_review.BackgroundImage = (Image) manager.GetObject("btn_review.BackgroundImage");
            base.btn_review.BackgroundImageLayout = ImageLayout.Stretch;
            base.btn_review.FlatAppearance.BorderSize = 0;
            base.btn_review.FlatStyle = FlatStyle.Flat;
            base.btn_review.Location = new Point(0x24a, 1);
            base.btn_review.Size = new Size(80, 0x30);
            base.btn_review.TabStop = false;
            base.btn_review.Text = "";
            base.btn_review.Visible = false;
            base.btn_review.Click += new EventHandler(this.btn_review_Click);
            base.btn_preQuestion.BackgroundImage = (Image) manager.GetObject("btn_preQuestion.BackgroundImage");
            base.btn_preQuestion.BackgroundImageLayout = ImageLayout.Stretch;
            base.btn_preQuestion.FlatAppearance.BorderSize = 0;
            base.btn_preQuestion.FlatStyle = FlatStyle.Flat;
            base.btn_preQuestion.Location = new Point(0x289, 1);
            base.btn_preQuestion.Size = new Size(80, 0x30);
            base.btn_preQuestion.TabStop = false;
            base.btn_preQuestion.Text = "";
            base.btn_preQuestion.Visible = false;
            base.btn_preQuestion.Click += new EventHandler(this.btn_preQuestion_Click);
            base.btn_nextQuestion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            base.btn_nextQuestion.BackColor = Color.White;
            base.btn_nextQuestion.BackgroundImage = (Image) manager.GetObject("btn_nextQuestion.BackgroundImage");
            base.btn_nextQuestion.BackgroundImageLayout = ImageLayout.Stretch;
            base.btn_nextQuestion.FlatAppearance.BorderSize = 0;
            base.btn_nextQuestion.FlatStyle = FlatStyle.Flat;
            base.btn_nextQuestion.ForeColor = Color.Black;
            base.btn_nextQuestion.Location = new Point(0x2c3, 1);
            base.btn_nextQuestion.Size = new Size(80, 0x30);
            base.btn_nextQuestion.TabStop = false;
            base.btn_nextQuestion.Text = "";
            base.btn_nextQuestion.UseVisualStyleBackColor = false;
            base.btn_nextQuestion.Visible = false;
            base.btn_nextQuestion.Click += new EventHandler(this.btn_nextQuestion_Click);
            this.openMp3File.FileName = "openMp3File";
            this.Timer_Listening.Interval = 0x3e8;
            this.Timer_Listening.Tick += new EventHandler(this.Timer_Listening_Tick);
            this.tabf_test.Controls.Add(this.tab_CoverForm);
            this.tabf_test.Controls.Add(this.tab_Reading);
            this.tabf_test.Controls.Add(this.tab_Listening);
            this.tabf_test.Controls.Add(this.tab_Speaking);
            this.tabf_test.Controls.Add(this.tab_Writing);
            this.tabf_test.Controls.Add(this.tabPage1);
            this.tabf_test.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabf_test.Location = new Point(-1, 0x4f);
            this.tabf_test.Multiline = true;
            this.tabf_test.Name = "tabf_test";
            this.tabf_test.SelectedIndex = 0;
            this.tabf_test.Size = new Size(0x314, 0x229);
            this.tabf_test.TabIndex = 15;
            this.tabf_test.TabStop = false;
            this.tab_CoverForm.Controls.Add(this.tabf_tposelection);
            this.tab_CoverForm.Location = new Point(4, 0x16);
            this.tab_CoverForm.Name = "tab_CoverForm";
            this.tab_CoverForm.Padding = new Padding(3);
            this.tab_CoverForm.Size = new Size(780, 0x20f);
            this.tab_CoverForm.TabIndex = 4;
            this.tab_CoverForm.Text = "CoverForm";
            this.tabf_tposelection.Controls.Add(this.TPO10);
            this.tabf_tposelection.Location = new Point(-4, -22);
            this.tabf_tposelection.Name = "tabf_tposelection";
            this.tabf_tposelection.SelectedIndex = 0;
            this.tabf_tposelection.Size = new Size(790, 0x21d);
            this.tabf_tposelection.TabIndex = 1;
            this.tabf_tposelection.TabStop = false;
            this.TPO10.BackColor = Color.White;
            this.TPO10.BackgroundImageLayout = ImageLayout.Stretch;
            this.TPO10.Controls.Add(this.btn_Review10);
            this.TPO10.Controls.Add(this.btn_Review09);
            this.TPO10.Controls.Add(this.btn_Review08);
            this.TPO10.Controls.Add(this.btn_Review07);
            this.TPO10.Controls.Add(this.btn_Review06);
            this.TPO10.Controls.Add(this.btn_Review05);
            this.TPO10.Controls.Add(this.btn_Review04);
            this.TPO10.Controls.Add(this.btn_Review03);
            this.TPO10.Controls.Add(this.btn_Review02);
            this.TPO10.Controls.Add(this.btn_Review01);
            this.TPO10.Controls.Add(this.btn_Answer10);
            this.TPO10.Controls.Add(this.btn_Answer09);
            this.TPO10.Controls.Add(this.btn_Answer08);
            this.TPO10.Controls.Add(this.btn_Answer07);
            this.TPO10.Controls.Add(this.btn_Answer06);
            this.TPO10.Controls.Add(this.btn_Answer05);
            this.TPO10.Controls.Add(this.btn_Answer04);
            this.TPO10.Controls.Add(this.btn_Answer03);
            this.TPO10.Controls.Add(this.btn_Answer02);
            this.TPO10.Controls.Add(this.btn_Answer01);
            this.TPO10.Controls.Add(this.btn_LoadSpeaking10);
            this.TPO10.Controls.Add(this.btn_LoadWriting10);
            this.TPO10.Controls.Add(this.btn_LoadListening10);
            this.TPO10.Controls.Add(this.btn_LoadReading10);
            this.TPO10.Controls.Add(this.btn_LoadSpeaking09);
            this.TPO10.Controls.Add(this.btn_LoadWriting09);
            this.TPO10.Controls.Add(this.btn_LoadListening09);
            this.TPO10.Controls.Add(this.btn_LoadReading09);
            this.TPO10.Controls.Add(this.btn_LoadSpeaking08);
            this.TPO10.Controls.Add(this.btn_LoadWriting08);
            this.TPO10.Controls.Add(this.btn_LoadListening08);
            this.TPO10.Controls.Add(this.btn_LoadReading08);
            this.TPO10.Controls.Add(this.btn_LoadSpeaking07);
            this.TPO10.Controls.Add(this.btn_LoadWriting07);
            this.TPO10.Controls.Add(this.btn_LoadListening07);
            this.TPO10.Controls.Add(this.btn_LoadReading07);
            this.TPO10.Controls.Add(this.btn_LoadSpeaking06);
            this.TPO10.Controls.Add(this.btn_LoadWriting06);
            this.TPO10.Controls.Add(this.btn_LoadListening06);
            this.TPO10.Controls.Add(this.btn_LoadReading06);
            this.TPO10.Controls.Add(this.btn_LoadSpeaking05);
            this.TPO10.Controls.Add(this.btn_LoadWriting05);
            this.TPO10.Controls.Add(this.btn_LoadListening05);
            this.TPO10.Controls.Add(this.btn_LoadReading05);
            this.TPO10.Controls.Add(this.btn_LoadSpeaking04);
            this.TPO10.Controls.Add(this.btn_LoadWriting04);
            this.TPO10.Controls.Add(this.btn_LoadListening04);
            this.TPO10.Controls.Add(this.btn_LoadReading04);
            this.TPO10.Controls.Add(this.btn_LoadSpeaking03);
            this.TPO10.Controls.Add(this.btn_LoadWriting03);
            this.TPO10.Controls.Add(this.btn_LoadListening03);
            this.TPO10.Controls.Add(this.btn_LoadReading03);
            this.TPO10.Controls.Add(this.btn_LoadSpeaking02);
            this.TPO10.Controls.Add(this.btn_LoadWriting02);
            this.TPO10.Controls.Add(this.btn_LoadListening02);
            this.TPO10.Controls.Add(this.btn_LoadReading02);
            this.TPO10.Controls.Add(this.btn_LoadSpeaking01);
            this.TPO10.Controls.Add(this.btn_LoadWriting01);
            this.TPO10.Controls.Add(this.btn_LoadListening01);
            this.TPO10.Controls.Add(this.btn_LoadReading01);
            this.TPO10.Controls.Add(this.lbl_top5);
            this.TPO10.Controls.Add(this.lbl_top8);
            this.TPO10.Controls.Add(this.lbl_top10);
            this.TPO10.Controls.Add(this.lbl_top9);
            this.TPO10.Controls.Add(this.lbl_top7);
            this.TPO10.Controls.Add(this.lbl_top6);
            this.TPO10.Controls.Add(this.lbl_top4);
            this.TPO10.Controls.Add(this.lbl_top3);
            this.TPO10.Controls.Add(this.lbl_top2);
            this.TPO10.Controls.Add(this.lbl_top1);
            this.TPO10.Location = new Point(4, 0x16);
            this.TPO10.Name = "TPO10";
            this.TPO10.Padding = new Padding(3);
            this.TPO10.Size = new Size(0x30e, 0x203);
            this.TPO10.TabIndex = 0;
            this.TPO10.Text = "TPO1-10";
            this.btn_Review10.FlatAppearance.BorderColor = Color.Black;
            this.btn_Review10.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review10.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review10.FlatStyle = FlatStyle.Flat;
            this.btn_Review10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Review10.Location = new Point(0x215, 0x1ca);
            this.btn_Review10.Name = "btn_Review10";
            this.btn_Review10.Size = new Size(100, 0x21);
            this.btn_Review10.TabIndex = 0x39;
            this.btn_Review10.TabStop = false;
            this.btn_Review10.Text = "START TEST";
            this.btn_Review10.UseVisualStyleBackColor = true;
            this.btn_Review10.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Review09.FlatAppearance.BorderColor = Color.Black;
            this.btn_Review09.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review09.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review09.FlatStyle = FlatStyle.Flat;
            this.btn_Review09.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Review09.Location = new Point(0x215, 0x1a0);
            this.btn_Review09.Name = "btn_Review09";
            this.btn_Review09.Size = new Size(100, 0x21);
            this.btn_Review09.TabIndex = 0x38;
            this.btn_Review09.TabStop = false;
            this.btn_Review09.Text = "START TEST";
            this.btn_Review09.UseVisualStyleBackColor = true;
            this.btn_Review09.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Review08.FlatAppearance.BorderColor = Color.Black;
            this.btn_Review08.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review08.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review08.FlatStyle = FlatStyle.Flat;
            this.btn_Review08.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Review08.Location = new Point(0x215, 0x170);
            this.btn_Review08.Name = "btn_Review08";
            this.btn_Review08.Size = new Size(100, 0x21);
            this.btn_Review08.TabIndex = 0x37;
            this.btn_Review08.TabStop = false;
            this.btn_Review08.Text = "START TEST";
            this.btn_Review08.UseVisualStyleBackColor = true;
            this.btn_Review08.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Review07.FlatAppearance.BorderColor = Color.Black;
            this.btn_Review07.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review07.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review07.FlatStyle = FlatStyle.Flat;
            this.btn_Review07.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Review07.Location = new Point(0x215, 0x13f);
            this.btn_Review07.Name = "btn_Review07";
            this.btn_Review07.Size = new Size(100, 0x21);
            this.btn_Review07.TabIndex = 0x36;
            this.btn_Review07.TabStop = false;
            this.btn_Review07.Text = "START TEST";
            this.btn_Review07.UseVisualStyleBackColor = true;
            this.btn_Review07.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Review06.FlatAppearance.BorderColor = Color.Black;
            this.btn_Review06.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review06.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review06.FlatStyle = FlatStyle.Flat;
            this.btn_Review06.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Review06.Location = new Point(0x215, 0x10d);
            this.btn_Review06.Name = "btn_Review06";
            this.btn_Review06.Size = new Size(100, 0x21);
            this.btn_Review06.TabIndex = 0x35;
            this.btn_Review06.TabStop = false;
            this.btn_Review06.Text = "START TEST";
            this.btn_Review06.UseVisualStyleBackColor = true;
            this.btn_Review06.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Review05.FlatAppearance.BorderColor = Color.Black;
            this.btn_Review05.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review05.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review05.FlatStyle = FlatStyle.Flat;
            this.btn_Review05.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Review05.Location = new Point(0x215, 0xdb);
            this.btn_Review05.Name = "btn_Review05";
            this.btn_Review05.Size = new Size(100, 0x21);
            this.btn_Review05.TabIndex = 0x34;
            this.btn_Review05.TabStop = false;
            this.btn_Review05.Text = "START TEST";
            this.btn_Review05.UseVisualStyleBackColor = true;
            this.btn_Review05.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Review04.FlatAppearance.BorderColor = Color.Black;
            this.btn_Review04.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review04.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review04.FlatStyle = FlatStyle.Flat;
            this.btn_Review04.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Review04.Location = new Point(0x215, 0xac);
            this.btn_Review04.Name = "btn_Review04";
            this.btn_Review04.Size = new Size(100, 0x21);
            this.btn_Review04.TabIndex = 0x33;
            this.btn_Review04.TabStop = false;
            this.btn_Review04.Text = "START TEST";
            this.btn_Review04.UseVisualStyleBackColor = true;
            this.btn_Review04.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Review03.FlatAppearance.BorderColor = Color.Black;
            this.btn_Review03.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review03.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review03.FlatStyle = FlatStyle.Flat;
            this.btn_Review03.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Review03.Location = new Point(0x215, 0x76);
            this.btn_Review03.Name = "btn_Review03";
            this.btn_Review03.Size = new Size(100, 0x21);
            this.btn_Review03.TabIndex = 50;
            this.btn_Review03.TabStop = false;
            this.btn_Review03.Text = "START TEST";
            this.btn_Review03.UseVisualStyleBackColor = true;
            this.btn_Review03.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Review02.FlatAppearance.BorderColor = Color.Black;
            this.btn_Review02.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review02.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review02.FlatStyle = FlatStyle.Flat;
            this.btn_Review02.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Review02.Location = new Point(0x215, 0x3f);
            this.btn_Review02.Name = "btn_Review02";
            this.btn_Review02.Size = new Size(100, 0x21);
            this.btn_Review02.TabIndex = 0x31;
            this.btn_Review02.TabStop = false;
            this.btn_Review02.Text = "START TEST";
            this.btn_Review02.UseVisualStyleBackColor = true;
            this.btn_Review02.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Review01.FlatAppearance.BorderColor = Color.Black;
            this.btn_Review01.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review01.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Review01.FlatStyle = FlatStyle.Flat;
            this.btn_Review01.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Review01.Location = new Point(0x215, 0x12);
            this.btn_Review01.Name = "btn_Review01";
            this.btn_Review01.Size = new Size(100, 0x21);
            this.btn_Review01.TabIndex = 0x30;
            this.btn_Review01.TabStop = false;
            this.btn_Review01.Text = "START TEST";
            this.btn_Review01.UseVisualStyleBackColor = true;
            this.btn_Review01.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Answer10.FlatAppearance.BorderColor = Color.Black;
            this.btn_Answer10.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer10.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer10.FlatStyle = FlatStyle.Flat;
            this.btn_Answer10.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Answer10.Location = new Point(0x282, 0x1ca);
            this.btn_Answer10.Name = "btn_Answer10";
            this.btn_Answer10.Size = new Size(80, 0x21);
            this.btn_Answer10.TabIndex = 0x2f;
            this.btn_Answer10.TabStop = false;
            this.btn_Answer10.Text = "VIEW ANSWERS";
            this.btn_Answer10.UseVisualStyleBackColor = true;
            this.btn_Answer10.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Answer09.FlatAppearance.BorderColor = Color.Black;
            this.btn_Answer09.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer09.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer09.FlatStyle = FlatStyle.Flat;
            this.btn_Answer09.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Answer09.Location = new Point(0x282, 0x1a0);
            this.btn_Answer09.Name = "btn_Answer09";
            this.btn_Answer09.Size = new Size(80, 0x21);
            this.btn_Answer09.TabIndex = 0x2e;
            this.btn_Answer09.TabStop = false;
            this.btn_Answer09.Text = "VIEW ANSWERS";
            this.btn_Answer09.UseVisualStyleBackColor = true;
            this.btn_Answer09.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Answer08.FlatAppearance.BorderColor = Color.Black;
            this.btn_Answer08.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer08.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer08.FlatStyle = FlatStyle.Flat;
            this.btn_Answer08.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Answer08.Location = new Point(0x282, 0x170);
            this.btn_Answer08.Name = "btn_Answer08";
            this.btn_Answer08.Size = new Size(80, 0x21);
            this.btn_Answer08.TabIndex = 0x2d;
            this.btn_Answer08.TabStop = false;
            this.btn_Answer08.Text = "VIEW ANSWERS";
            this.btn_Answer08.UseVisualStyleBackColor = true;
            this.btn_Answer08.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Answer07.FlatAppearance.BorderColor = Color.Black;
            this.btn_Answer07.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer07.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer07.FlatStyle = FlatStyle.Flat;
            this.btn_Answer07.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Answer07.Location = new Point(0x282, 0x13f);
            this.btn_Answer07.Name = "btn_Answer07";
            this.btn_Answer07.Size = new Size(80, 0x21);
            this.btn_Answer07.TabIndex = 0x2c;
            this.btn_Answer07.TabStop = false;
            this.btn_Answer07.Text = "VIEW ANSWERS";
            this.btn_Answer07.UseVisualStyleBackColor = true;
            this.btn_Answer07.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Answer06.FlatAppearance.BorderColor = Color.Black;
            this.btn_Answer06.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer06.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer06.FlatStyle = FlatStyle.Flat;
            this.btn_Answer06.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Answer06.Location = new Point(0x282, 0x10d);
            this.btn_Answer06.Name = "btn_Answer06";
            this.btn_Answer06.Size = new Size(80, 0x21);
            this.btn_Answer06.TabIndex = 0x2b;
            this.btn_Answer06.TabStop = false;
            this.btn_Answer06.Text = "VIEW ANSWERS";
            this.btn_Answer06.UseVisualStyleBackColor = true;
            this.btn_Answer06.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Answer05.FlatAppearance.BorderColor = Color.Black;
            this.btn_Answer05.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer05.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer05.FlatStyle = FlatStyle.Flat;
            this.btn_Answer05.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Answer05.Location = new Point(0x282, 0xdb);
            this.btn_Answer05.Name = "btn_Answer05";
            this.btn_Answer05.Size = new Size(80, 0x21);
            this.btn_Answer05.TabIndex = 0x2a;
            this.btn_Answer05.TabStop = false;
            this.btn_Answer05.Text = "VIEW ANSWERS";
            this.btn_Answer05.UseVisualStyleBackColor = true;
            this.btn_Answer05.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Answer04.FlatAppearance.BorderColor = Color.Black;
            this.btn_Answer04.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer04.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer04.FlatStyle = FlatStyle.Flat;
            this.btn_Answer04.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Answer04.Location = new Point(0x282, 0xac);
            this.btn_Answer04.Name = "btn_Answer04";
            this.btn_Answer04.Size = new Size(80, 0x21);
            this.btn_Answer04.TabIndex = 0x29;
            this.btn_Answer04.TabStop = false;
            this.btn_Answer04.Text = "VIEW ANSWERS";
            this.btn_Answer04.UseVisualStyleBackColor = true;
            this.btn_Answer04.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Answer03.FlatAppearance.BorderColor = Color.Black;
            this.btn_Answer03.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer03.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer03.FlatStyle = FlatStyle.Flat;
            this.btn_Answer03.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Answer03.Location = new Point(0x282, 0x76);
            this.btn_Answer03.Name = "btn_Answer03";
            this.btn_Answer03.Size = new Size(80, 0x21);
            this.btn_Answer03.TabIndex = 40;
            this.btn_Answer03.TabStop = false;
            this.btn_Answer03.Text = "VIEW ANSWERS";
            this.btn_Answer03.UseVisualStyleBackColor = true;
            this.btn_Answer03.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Answer02.FlatAppearance.BorderColor = Color.Black;
            this.btn_Answer02.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer02.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer02.FlatStyle = FlatStyle.Flat;
            this.btn_Answer02.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Answer02.Location = new Point(0x282, 0x3f);
            this.btn_Answer02.Name = "btn_Answer02";
            this.btn_Answer02.Size = new Size(80, 0x21);
            this.btn_Answer02.TabIndex = 0x27;
            this.btn_Answer02.TabStop = false;
            this.btn_Answer02.Text = "VIEW ANSWERS";
            this.btn_Answer02.UseVisualStyleBackColor = true;
            this.btn_Answer02.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_Answer01.FlatAppearance.BorderColor = Color.Black;
            this.btn_Answer01.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer01.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_Answer01.FlatStyle = FlatStyle.Flat;
            this.btn_Answer01.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_Answer01.Location = new Point(0x282, 0x12);
            this.btn_Answer01.Name = "btn_Answer01";
            this.btn_Answer01.Size = new Size(80, 0x21);
            this.btn_Answer01.TabIndex = 0x26;
            this.btn_Answer01.TabStop = false;
            this.btn_Answer01.Text = "VIEW ANSWERS";
            this.btn_Answer01.UseVisualStyleBackColor = true;
            this.btn_Answer01.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadSpeaking10.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadSpeaking10.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking10.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking10.FlatStyle = FlatStyle.Flat;
            this.btn_LoadSpeaking10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadSpeaking10.Location = new Point(310, 0x1ca);
            this.btn_LoadSpeaking10.Name = "btn_LoadSpeaking10";
            this.btn_LoadSpeaking10.Size = new Size(80, 0x21);
            this.btn_LoadSpeaking10.TabIndex = 0x24;
            this.btn_LoadSpeaking10.TabStop = false;
            this.btn_LoadSpeaking10.Text = "SPEAKING";
            this.btn_LoadSpeaking10.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking10.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadWriting10.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadWriting10.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting10.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting10.FlatStyle = FlatStyle.Flat;
            this.btn_LoadWriting10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadWriting10.Location = new Point(0x1a7, 0x1ca);
            this.btn_LoadWriting10.Name = "btn_LoadWriting10";
            this.btn_LoadWriting10.Size = new Size(80, 0x21);
            this.btn_LoadWriting10.TabIndex = 0x25;
            this.btn_LoadWriting10.TabStop = false;
            this.btn_LoadWriting10.Text = "WRITING";
            this.btn_LoadWriting10.UseVisualStyleBackColor = true;
            this.btn_LoadWriting10.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadListening10.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadListening10.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening10.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening10.FlatStyle = FlatStyle.Flat;
            this.btn_LoadListening10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadListening10.Location = new Point(0xc5, 0x1ca);
            this.btn_LoadListening10.Name = "btn_LoadListening10";
            this.btn_LoadListening10.Size = new Size(80, 0x21);
            this.btn_LoadListening10.TabIndex = 0x22;
            this.btn_LoadListening10.TabStop = false;
            this.btn_LoadListening10.Text = "LISTENING";
            this.btn_LoadListening10.UseVisualStyleBackColor = true;
            this.btn_LoadListening10.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadReading10.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadReading10.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading10.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading10.FlatStyle = FlatStyle.Flat;
            this.btn_LoadReading10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadReading10.Location = new Point(80, 0x1ca);
            this.btn_LoadReading10.Name = "btn_LoadReading10";
            this.btn_LoadReading10.Size = new Size(80, 0x21);
            this.btn_LoadReading10.TabIndex = 0x23;
            this.btn_LoadReading10.TabStop = false;
            this.btn_LoadReading10.Text = "READING";
            this.btn_LoadReading10.UseVisualStyleBackColor = true;
            this.btn_LoadReading10.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadSpeaking09.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadSpeaking09.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking09.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking09.FlatStyle = FlatStyle.Flat;
            this.btn_LoadSpeaking09.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadSpeaking09.Location = new Point(310, 0x1a0);
            this.btn_LoadSpeaking09.Name = "btn_LoadSpeaking09";
            this.btn_LoadSpeaking09.Size = new Size(80, 0x21);
            this.btn_LoadSpeaking09.TabIndex = 0x20;
            this.btn_LoadSpeaking09.TabStop = false;
            this.btn_LoadSpeaking09.Text = "SPEAKING";
            this.btn_LoadSpeaking09.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking09.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadWriting09.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadWriting09.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting09.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting09.FlatStyle = FlatStyle.Flat;
            this.btn_LoadWriting09.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadWriting09.Location = new Point(0x1a7, 0x1a0);
            this.btn_LoadWriting09.Name = "btn_LoadWriting09";
            this.btn_LoadWriting09.Size = new Size(80, 0x21);
            this.btn_LoadWriting09.TabIndex = 0x21;
            this.btn_LoadWriting09.TabStop = false;
            this.btn_LoadWriting09.Text = "WRITING";
            this.btn_LoadWriting09.UseVisualStyleBackColor = true;
            this.btn_LoadWriting09.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadListening09.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadListening09.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening09.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening09.FlatStyle = FlatStyle.Flat;
            this.btn_LoadListening09.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadListening09.Location = new Point(0xc5, 0x1a0);
            this.btn_LoadListening09.Name = "btn_LoadListening09";
            this.btn_LoadListening09.Size = new Size(80, 0x21);
            this.btn_LoadListening09.TabIndex = 30;
            this.btn_LoadListening09.TabStop = false;
            this.btn_LoadListening09.Text = "LISTENING";
            this.btn_LoadListening09.UseVisualStyleBackColor = true;
            this.btn_LoadListening09.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadReading09.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadReading09.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading09.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading09.FlatStyle = FlatStyle.Flat;
            this.btn_LoadReading09.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadReading09.Location = new Point(80, 0x1a0);
            this.btn_LoadReading09.Name = "btn_LoadReading09";
            this.btn_LoadReading09.Size = new Size(80, 0x21);
            this.btn_LoadReading09.TabIndex = 0x1f;
            this.btn_LoadReading09.TabStop = false;
            this.btn_LoadReading09.Text = "READING";
            this.btn_LoadReading09.UseVisualStyleBackColor = true;
            this.btn_LoadReading09.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadSpeaking08.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadSpeaking08.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking08.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking08.FlatStyle = FlatStyle.Flat;
            this.btn_LoadSpeaking08.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadSpeaking08.Location = new Point(310, 0x170);
            this.btn_LoadSpeaking08.Name = "btn_LoadSpeaking08";
            this.btn_LoadSpeaking08.Size = new Size(80, 0x21);
            this.btn_LoadSpeaking08.TabIndex = 0x1c;
            this.btn_LoadSpeaking08.TabStop = false;
            this.btn_LoadSpeaking08.Text = "SPEAKING";
            this.btn_LoadSpeaking08.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking08.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadWriting08.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadWriting08.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting08.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting08.FlatStyle = FlatStyle.Flat;
            this.btn_LoadWriting08.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadWriting08.Location = new Point(0x1a7, 0x170);
            this.btn_LoadWriting08.Name = "btn_LoadWriting08";
            this.btn_LoadWriting08.Size = new Size(80, 0x21);
            this.btn_LoadWriting08.TabIndex = 0x1d;
            this.btn_LoadWriting08.TabStop = false;
            this.btn_LoadWriting08.Text = "WRITING";
            this.btn_LoadWriting08.UseVisualStyleBackColor = true;
            this.btn_LoadWriting08.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadListening08.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadListening08.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening08.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening08.FlatStyle = FlatStyle.Flat;
            this.btn_LoadListening08.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadListening08.Location = new Point(0xc5, 0x170);
            this.btn_LoadListening08.Name = "btn_LoadListening08";
            this.btn_LoadListening08.Size = new Size(80, 0x21);
            this.btn_LoadListening08.TabIndex = 0x1a;
            this.btn_LoadListening08.TabStop = false;
            this.btn_LoadListening08.Text = "LISTENING";
            this.btn_LoadListening08.UseVisualStyleBackColor = true;
            this.btn_LoadListening08.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadReading08.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadReading08.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading08.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading08.FlatStyle = FlatStyle.Flat;
            this.btn_LoadReading08.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadReading08.Location = new Point(80, 0x170);
            this.btn_LoadReading08.Name = "btn_LoadReading08";
            this.btn_LoadReading08.Size = new Size(80, 0x21);
            this.btn_LoadReading08.TabIndex = 0x1b;
            this.btn_LoadReading08.TabStop = false;
            this.btn_LoadReading08.Text = "READING";
            this.btn_LoadReading08.UseVisualStyleBackColor = true;
            this.btn_LoadReading08.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadSpeaking07.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadSpeaking07.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking07.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking07.FlatStyle = FlatStyle.Flat;
            this.btn_LoadSpeaking07.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadSpeaking07.Location = new Point(310, 0x13f);
            this.btn_LoadSpeaking07.Name = "btn_LoadSpeaking07";
            this.btn_LoadSpeaking07.Size = new Size(80, 0x21);
            this.btn_LoadSpeaking07.TabIndex = 0x18;
            this.btn_LoadSpeaking07.TabStop = false;
            this.btn_LoadSpeaking07.Text = "SPEAKING";
            this.btn_LoadSpeaking07.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking07.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadWriting07.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadWriting07.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting07.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting07.FlatStyle = FlatStyle.Flat;
            this.btn_LoadWriting07.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadWriting07.Location = new Point(0x1a7, 0x13f);
            this.btn_LoadWriting07.Name = "btn_LoadWriting07";
            this.btn_LoadWriting07.Size = new Size(80, 0x21);
            this.btn_LoadWriting07.TabIndex = 0x19;
            this.btn_LoadWriting07.TabStop = false;
            this.btn_LoadWriting07.Text = "WRITING";
            this.btn_LoadWriting07.UseVisualStyleBackColor = true;
            this.btn_LoadWriting07.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadListening07.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadListening07.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening07.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening07.FlatStyle = FlatStyle.Flat;
            this.btn_LoadListening07.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadListening07.Location = new Point(0xc5, 0x13f);
            this.btn_LoadListening07.Name = "btn_LoadListening07";
            this.btn_LoadListening07.Size = new Size(80, 0x21);
            this.btn_LoadListening07.TabIndex = 0x16;
            this.btn_LoadListening07.TabStop = false;
            this.btn_LoadListening07.Text = "LISTENING";
            this.btn_LoadListening07.UseVisualStyleBackColor = true;
            this.btn_LoadListening07.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadReading07.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadReading07.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading07.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading07.FlatStyle = FlatStyle.Flat;
            this.btn_LoadReading07.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadReading07.Location = new Point(80, 0x13f);
            this.btn_LoadReading07.Name = "btn_LoadReading07";
            this.btn_LoadReading07.Size = new Size(80, 0x21);
            this.btn_LoadReading07.TabIndex = 0x17;
            this.btn_LoadReading07.TabStop = false;
            this.btn_LoadReading07.Text = "READING";
            this.btn_LoadReading07.UseVisualStyleBackColor = true;
            this.btn_LoadReading07.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadSpeaking06.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadSpeaking06.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking06.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking06.FlatStyle = FlatStyle.Flat;
            this.btn_LoadSpeaking06.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadSpeaking06.Location = new Point(310, 0x10d);
            this.btn_LoadSpeaking06.Name = "btn_LoadSpeaking06";
            this.btn_LoadSpeaking06.Size = new Size(80, 0x21);
            this.btn_LoadSpeaking06.TabIndex = 20;
            this.btn_LoadSpeaking06.TabStop = false;
            this.btn_LoadSpeaking06.Text = "SPEAKING";
            this.btn_LoadSpeaking06.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking06.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadWriting06.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadWriting06.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting06.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting06.FlatStyle = FlatStyle.Flat;
            this.btn_LoadWriting06.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadWriting06.Location = new Point(0x1a7, 0x10d);
            this.btn_LoadWriting06.Name = "btn_LoadWriting06";
            this.btn_LoadWriting06.Size = new Size(80, 0x21);
            this.btn_LoadWriting06.TabIndex = 0x15;
            this.btn_LoadWriting06.TabStop = false;
            this.btn_LoadWriting06.Text = "WRITING";
            this.btn_LoadWriting06.UseVisualStyleBackColor = true;
            this.btn_LoadWriting06.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadListening06.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadListening06.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening06.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening06.FlatStyle = FlatStyle.Flat;
            this.btn_LoadListening06.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadListening06.Location = new Point(0xc5, 0x10d);
            this.btn_LoadListening06.Name = "btn_LoadListening06";
            this.btn_LoadListening06.Size = new Size(80, 0x21);
            this.btn_LoadListening06.TabIndex = 0x12;
            this.btn_LoadListening06.TabStop = false;
            this.btn_LoadListening06.Text = "LISTENING";
            this.btn_LoadListening06.UseVisualStyleBackColor = true;
            this.btn_LoadListening06.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadReading06.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadReading06.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading06.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading06.FlatStyle = FlatStyle.Flat;
            this.btn_LoadReading06.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadReading06.Location = new Point(80, 0x10d);
            this.btn_LoadReading06.Name = "btn_LoadReading06";
            this.btn_LoadReading06.Size = new Size(80, 0x21);
            this.btn_LoadReading06.TabIndex = 0x13;
            this.btn_LoadReading06.TabStop = false;
            this.btn_LoadReading06.Text = "READING";
            this.btn_LoadReading06.UseVisualStyleBackColor = true;
            this.btn_LoadReading06.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadSpeaking05.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadSpeaking05.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking05.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking05.FlatStyle = FlatStyle.Flat;
            this.btn_LoadSpeaking05.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadSpeaking05.Location = new Point(310, 0xdb);
            this.btn_LoadSpeaking05.Name = "btn_LoadSpeaking05";
            this.btn_LoadSpeaking05.Size = new Size(80, 0x21);
            this.btn_LoadSpeaking05.TabIndex = 0x10;
            this.btn_LoadSpeaking05.TabStop = false;
            this.btn_LoadSpeaking05.Text = "SPEAKING";
            this.btn_LoadSpeaking05.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking05.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadWriting05.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadWriting05.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting05.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting05.FlatStyle = FlatStyle.Flat;
            this.btn_LoadWriting05.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadWriting05.Location = new Point(0x1a7, 0xdb);
            this.btn_LoadWriting05.Name = "btn_LoadWriting05";
            this.btn_LoadWriting05.Size = new Size(80, 0x21);
            this.btn_LoadWriting05.TabIndex = 0x11;
            this.btn_LoadWriting05.TabStop = false;
            this.btn_LoadWriting05.Text = "WRITING";
            this.btn_LoadWriting05.UseVisualStyleBackColor = true;
            this.btn_LoadWriting05.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadListening05.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadListening05.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening05.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening05.FlatStyle = FlatStyle.Flat;
            this.btn_LoadListening05.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadListening05.Location = new Point(0xc5, 0xdb);
            this.btn_LoadListening05.Name = "btn_LoadListening05";
            this.btn_LoadListening05.Size = new Size(80, 0x21);
            this.btn_LoadListening05.TabIndex = 14;
            this.btn_LoadListening05.TabStop = false;
            this.btn_LoadListening05.Text = "LISTENING";
            this.btn_LoadListening05.UseVisualStyleBackColor = true;
            this.btn_LoadListening05.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadReading05.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadReading05.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading05.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading05.FlatStyle = FlatStyle.Flat;
            this.btn_LoadReading05.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadReading05.Location = new Point(80, 0xdb);
            this.btn_LoadReading05.Name = "btn_LoadReading05";
            this.btn_LoadReading05.Size = new Size(80, 0x21);
            this.btn_LoadReading05.TabIndex = 15;
            this.btn_LoadReading05.TabStop = false;
            this.btn_LoadReading05.Text = "READING";
            this.btn_LoadReading05.UseVisualStyleBackColor = true;
            this.btn_LoadReading05.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadSpeaking04.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadSpeaking04.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking04.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking04.FlatStyle = FlatStyle.Flat;
            this.btn_LoadSpeaking04.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadSpeaking04.Location = new Point(310, 0xac);
            this.btn_LoadSpeaking04.Name = "btn_LoadSpeaking04";
            this.btn_LoadSpeaking04.Size = new Size(80, 0x21);
            this.btn_LoadSpeaking04.TabIndex = 12;
            this.btn_LoadSpeaking04.TabStop = false;
            this.btn_LoadSpeaking04.Text = "SPEAKING";
            this.btn_LoadSpeaking04.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking04.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadWriting04.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadWriting04.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting04.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting04.FlatStyle = FlatStyle.Flat;
            this.btn_LoadWriting04.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadWriting04.Location = new Point(0x1a7, 0xac);
            this.btn_LoadWriting04.Name = "btn_LoadWriting04";
            this.btn_LoadWriting04.Size = new Size(80, 0x21);
            this.btn_LoadWriting04.TabIndex = 13;
            this.btn_LoadWriting04.TabStop = false;
            this.btn_LoadWriting04.Text = "WRITING";
            this.btn_LoadWriting04.UseVisualStyleBackColor = true;
            this.btn_LoadWriting04.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadListening04.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadListening04.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening04.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening04.FlatStyle = FlatStyle.Flat;
            this.btn_LoadListening04.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadListening04.Location = new Point(0xc5, 0xac);
            this.btn_LoadListening04.Name = "btn_LoadListening04";
            this.btn_LoadListening04.Size = new Size(80, 0x21);
            this.btn_LoadListening04.TabIndex = 10;
            this.btn_LoadListening04.TabStop = false;
            this.btn_LoadListening04.Text = "LISTENING";
            this.btn_LoadListening04.UseVisualStyleBackColor = true;
            this.btn_LoadListening04.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadReading04.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadReading04.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading04.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading04.FlatStyle = FlatStyle.Flat;
            this.btn_LoadReading04.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadReading04.Location = new Point(80, 0xac);
            this.btn_LoadReading04.Name = "btn_LoadReading04";
            this.btn_LoadReading04.Size = new Size(80, 0x21);
            this.btn_LoadReading04.TabIndex = 11;
            this.btn_LoadReading04.TabStop = false;
            this.btn_LoadReading04.Text = "READING";
            this.btn_LoadReading04.UseVisualStyleBackColor = true;
            this.btn_LoadReading04.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadSpeaking03.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadSpeaking03.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking03.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking03.FlatStyle = FlatStyle.Flat;
            this.btn_LoadSpeaking03.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadSpeaking03.Location = new Point(310, 0x76);
            this.btn_LoadSpeaking03.Name = "btn_LoadSpeaking03";
            this.btn_LoadSpeaking03.Size = new Size(80, 0x21);
            this.btn_LoadSpeaking03.TabIndex = 8;
            this.btn_LoadSpeaking03.TabStop = false;
            this.btn_LoadSpeaking03.Text = "SPEAKING";
            this.btn_LoadSpeaking03.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking03.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadWriting03.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadWriting03.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting03.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting03.FlatStyle = FlatStyle.Flat;
            this.btn_LoadWriting03.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadWriting03.Location = new Point(0x1a7, 0x76);
            this.btn_LoadWriting03.Name = "btn_LoadWriting03";
            this.btn_LoadWriting03.Size = new Size(80, 0x21);
            this.btn_LoadWriting03.TabIndex = 9;
            this.btn_LoadWriting03.TabStop = false;
            this.btn_LoadWriting03.Text = "WRITING";
            this.btn_LoadWriting03.UseVisualStyleBackColor = true;
            this.btn_LoadWriting03.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadListening03.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadListening03.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening03.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening03.FlatStyle = FlatStyle.Flat;
            this.btn_LoadListening03.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadListening03.Location = new Point(0xc5, 0x76);
            this.btn_LoadListening03.Name = "btn_LoadListening03";
            this.btn_LoadListening03.Size = new Size(80, 0x21);
            this.btn_LoadListening03.TabIndex = 6;
            this.btn_LoadListening03.TabStop = false;
            this.btn_LoadListening03.Text = "LISTENING";
            this.btn_LoadListening03.UseVisualStyleBackColor = true;
            this.btn_LoadListening03.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadReading03.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadReading03.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading03.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading03.FlatStyle = FlatStyle.Flat;
            this.btn_LoadReading03.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadReading03.Location = new Point(80, 0x76);
            this.btn_LoadReading03.Name = "btn_LoadReading03";
            this.btn_LoadReading03.Size = new Size(80, 0x21);
            this.btn_LoadReading03.TabIndex = 7;
            this.btn_LoadReading03.TabStop = false;
            this.btn_LoadReading03.Text = "READING";
            this.btn_LoadReading03.UseVisualStyleBackColor = true;
            this.btn_LoadReading03.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadSpeaking02.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadSpeaking02.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking02.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking02.FlatStyle = FlatStyle.Flat;
            this.btn_LoadSpeaking02.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadSpeaking02.Location = new Point(310, 0x3f);
            this.btn_LoadSpeaking02.Name = "btn_LoadSpeaking02";
            this.btn_LoadSpeaking02.Size = new Size(80, 0x21);
            this.btn_LoadSpeaking02.TabIndex = 4;
            this.btn_LoadSpeaking02.TabStop = false;
            this.btn_LoadSpeaking02.Text = "SPEAKING";
            this.btn_LoadSpeaking02.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking02.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadWriting02.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadWriting02.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting02.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting02.FlatStyle = FlatStyle.Flat;
            this.btn_LoadWriting02.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadWriting02.Location = new Point(0x1a7, 0x3f);
            this.btn_LoadWriting02.Name = "btn_LoadWriting02";
            this.btn_LoadWriting02.Size = new Size(80, 0x21);
            this.btn_LoadWriting02.TabIndex = 5;
            this.btn_LoadWriting02.TabStop = false;
            this.btn_LoadWriting02.Text = "WRITING";
            this.btn_LoadWriting02.UseVisualStyleBackColor = true;
            this.btn_LoadWriting02.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadListening02.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadListening02.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening02.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening02.FlatStyle = FlatStyle.Flat;
            this.btn_LoadListening02.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadListening02.Location = new Point(0xc5, 0x3f);
            this.btn_LoadListening02.Name = "btn_LoadListening02";
            this.btn_LoadListening02.Size = new Size(80, 0x21);
            this.btn_LoadListening02.TabIndex = 2;
            this.btn_LoadListening02.TabStop = false;
            this.btn_LoadListening02.Text = "LISTENING";
            this.btn_LoadListening02.UseVisualStyleBackColor = true;
            this.btn_LoadListening02.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadReading02.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadReading02.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading02.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading02.FlatStyle = FlatStyle.Flat;
            this.btn_LoadReading02.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadReading02.Location = new Point(80, 0x3f);
            this.btn_LoadReading02.Name = "btn_LoadReading02";
            this.btn_LoadReading02.Size = new Size(80, 0x21);
            this.btn_LoadReading02.TabIndex = 3;
            this.btn_LoadReading02.TabStop = false;
            this.btn_LoadReading02.Text = "READING";
            this.btn_LoadReading02.UseVisualStyleBackColor = true;
            this.btn_LoadReading02.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadSpeaking01.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadSpeaking01.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking01.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadSpeaking01.FlatStyle = FlatStyle.Flat;
            this.btn_LoadSpeaking01.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadSpeaking01.Location = new Point(310, 0x12);
            this.btn_LoadSpeaking01.Name = "btn_LoadSpeaking01";
            this.btn_LoadSpeaking01.Size = new Size(80, 0x21);
            this.btn_LoadSpeaking01.TabIndex = 1;
            this.btn_LoadSpeaking01.TabStop = false;
            this.btn_LoadSpeaking01.Text = "SPEAKING";
            this.btn_LoadSpeaking01.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking01.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadWriting01.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadWriting01.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting01.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadWriting01.FlatStyle = FlatStyle.Flat;
            this.btn_LoadWriting01.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadWriting01.Location = new Point(0x1a7, 0x12);
            this.btn_LoadWriting01.Name = "btn_LoadWriting01";
            this.btn_LoadWriting01.Size = new Size(80, 0x21);
            this.btn_LoadWriting01.TabIndex = 1;
            this.btn_LoadWriting01.TabStop = false;
            this.btn_LoadWriting01.Text = "WRITING";
            this.btn_LoadWriting01.UseVisualStyleBackColor = true;
            this.btn_LoadWriting01.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadListening01.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadListening01.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening01.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadListening01.FlatStyle = FlatStyle.Flat;
            this.btn_LoadListening01.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadListening01.Location = new Point(0xc5, 0x12);
            this.btn_LoadListening01.Name = "btn_LoadListening01";
            this.btn_LoadListening01.Size = new Size(80, 0x21);
            this.btn_LoadListening01.TabIndex = 1;
            this.btn_LoadListening01.TabStop = false;
            this.btn_LoadListening01.Text = "LISTENING";
            this.btn_LoadListening01.UseVisualStyleBackColor = true;
            this.btn_LoadListening01.Click += new EventHandler(this.btn_LoadTest_Click);
            this.btn_LoadReading01.FlatAppearance.BorderColor = Color.Black;
            this.btn_LoadReading01.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading01.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.btn_LoadReading01.FlatStyle = FlatStyle.Flat;
            this.btn_LoadReading01.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_LoadReading01.Location = new Point(80, 0x12);
            this.btn_LoadReading01.Name = "btn_LoadReading01";
            this.btn_LoadReading01.Size = new Size(80, 0x21);
            this.btn_LoadReading01.TabIndex = 0;
            this.btn_LoadReading01.TabStop = false;
            this.btn_LoadReading01.Text = "READING";
            this.btn_LoadReading01.UseVisualStyleBackColor = true;
            this.btn_LoadReading01.Click += new EventHandler(this.btn_LoadTest_Click);
            this.lbl_top5.AutoSize = true;
            this.lbl_top5.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_top5.Location = new Point(0x11, 0xdf);
            this.lbl_top5.Name = "lbl_top5";
            this.lbl_top5.Size = new Size(0x40, 0x13);
            this.lbl_top5.TabIndex = 0;
            this.lbl_top5.Text = "TPO 05";
            this.lbl_top8.AutoSize = true;
            this.lbl_top8.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_top8.Location = new Point(0x11, 0x174);
            this.lbl_top8.Name = "lbl_top8";
            this.lbl_top8.Size = new Size(0x40, 0x13);
            this.lbl_top8.TabIndex = 0;
            this.lbl_top8.Text = "TPO 08";
            this.lbl_top10.AutoSize = true;
            this.lbl_top10.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_top10.Location = new Point(0x11, 0x1d3);
            this.lbl_top10.Name = "lbl_top10";
            this.lbl_top10.Size = new Size(0x40, 0x13);
            this.lbl_top10.TabIndex = 0;
            this.lbl_top10.Text = "TPO 10";
            this.lbl_top9.AutoSize = true;
            this.lbl_top9.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_top9.Location = new Point(0x11, 420);
            this.lbl_top9.Name = "lbl_top9";
            this.lbl_top9.Size = new Size(0x40, 0x13);
            this.lbl_top9.TabIndex = 0;
            this.lbl_top9.Text = "TPO 09";
            this.lbl_top7.AutoSize = true;
            this.lbl_top7.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_top7.Location = new Point(0x11, 0x143);
            this.lbl_top7.Name = "lbl_top7";
            this.lbl_top7.Size = new Size(0x40, 0x13);
            this.lbl_top7.TabIndex = 0;
            this.lbl_top7.Text = "TPO 07";
            this.lbl_top6.AutoSize = true;
            this.lbl_top6.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_top6.Location = new Point(0x11, 0x111);
            this.lbl_top6.Name = "lbl_top6";
            this.lbl_top6.Size = new Size(0x40, 0x13);
            this.lbl_top6.TabIndex = 0;
            this.lbl_top6.Text = "TPO 06";
            this.lbl_top4.AutoSize = true;
            this.lbl_top4.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_top4.Location = new Point(0x11, 0xb0);
            this.lbl_top4.Name = "lbl_top4";
            this.lbl_top4.Size = new Size(0x40, 0x13);
            this.lbl_top4.TabIndex = 0;
            this.lbl_top4.Text = "TPO 04";
            this.lbl_top3.AutoSize = true;
            this.lbl_top3.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_top3.Location = new Point(0x11, 0x7e);
            this.lbl_top3.Name = "lbl_top3";
            this.lbl_top3.Size = new Size(0x40, 0x13);
            this.lbl_top3.TabIndex = 0;
            this.lbl_top3.Text = "TPO 03";
            this.lbl_top2.AutoSize = true;
            this.lbl_top2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_top2.Location = new Point(0x11, 0x47);
            this.lbl_top2.Name = "lbl_top2";
            this.lbl_top2.Size = new Size(0x40, 0x13);
            this.lbl_top2.TabIndex = 0;
            this.lbl_top2.Text = "TPO 02";
            this.lbl_top1.AutoSize = true;
            this.lbl_top1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_top1.Location = new Point(0x11, 0x1a);
            this.lbl_top1.Name = "lbl_top1";
            this.lbl_top1.Size = new Size(0x40, 0x13);
            this.lbl_top1.TabIndex = 0;
            this.lbl_top1.Text = "TPO 01";
            this.tab_Reading.Controls.Add(this.tabf_Reading);
            this.tab_Reading.Location = new Point(4, 0x16);
            this.tab_Reading.Name = "tab_Reading";
            this.tab_Reading.Padding = new Padding(3);
            this.tab_Reading.Size = new Size(780, 0x20f);
            this.tab_Reading.TabIndex = 0;
            this.tab_Reading.Text = "Reading";
            this.tab_Reading.UseVisualStyleBackColor = true;
            this.tabf_Reading.Appearance = TabAppearance.Buttons;
            this.tabf_Reading.Controls.Add(this.rtab_Direction);
            this.tabf_Reading.Controls.Add(this.rtab_NormalQuestion);
            this.tabf_Reading.Controls.Add(this.rtab_SumQuestion);
            this.tabf_Reading.Controls.Add(this.rtab_Review);
            this.tabf_Reading.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabf_Reading.Location = new Point(3, -20);
            this.tabf_Reading.Name = "tabf_Reading";
            this.tabf_Reading.SelectedIndex = 0;
            this.tabf_Reading.Size = new Size(0x303, 0x229);
            this.tabf_Reading.TabIndex = 0;
            this.tabf_Reading.TabStop = false;
            this.rtab_Direction.BackColor = Color.White;
            this.rtab_Direction.Controls.Add(this.pictureBox2);
            this.rtab_Direction.Location = new Point(4, 0x19);
            this.rtab_Direction.Name = "rtab_Direction";
            this.rtab_Direction.Size = new Size(0x2fb, 0x20c);
            this.rtab_Direction.TabIndex = 3;
            this.rtab_Direction.Text = "rDirection";
            this.pictureBox2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.pictureBox2.Image = (Image) manager.GetObject("pictureBox2.Image");
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new Point(30, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(0x445, 0x1fa);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0x11;
            this.pictureBox2.TabStop = false;
            this.rtab_NormalQuestion.Controls.Add(this.tb_reading);
            this.rtab_NormalQuestion.Controls.Add(this.rtb_Passage);
            this.rtab_NormalQuestion.Controls.Add(this.flowLayoutPanel1);
            this.rtab_NormalQuestion.Controls.Add(this.btn_stopReading);
            this.rtab_NormalQuestion.Controls.Add(this.bn_readText);
            this.rtab_NormalQuestion.Controls.Add(this.lbl_readingIndication);
            this.rtab_NormalQuestion.Location = new Point(4, 0x19);
            this.rtab_NormalQuestion.Name = "rtab_NormalQuestion";
            this.rtab_NormalQuestion.Padding = new Padding(3);
            this.rtab_NormalQuestion.Size = new Size(0x2fb, 0x20c);
            this.rtab_NormalQuestion.TabIndex = 0;
            this.rtab_NormalQuestion.Text = "rNormalQuestions";
            this.rtab_NormalQuestion.UseVisualStyleBackColor = true;
            this.tb_reading.AutoSize = false;
            this.tb_reading.Location = new Point(0x1aa, 0);
            this.tb_reading.Name = "tb_reading";
            this.tb_reading.Size = new Size(0x11a, 0x15);
            this.tb_reading.TabIndex = 0x19;
            this.tb_reading.TickStyle = TickStyle.None;
            this.tb_reading.Visible = false;
            this.tb_reading.Scroll += new EventHandler(this.tb_reading_Scroll);
            this.rtb_Passage.BackColor = SystemColors.ButtonHighlight;
            this.rtb_Passage.EnableAutoDragDrop = true;
            this.rtb_Passage.Location = new Point(0x15c, 0x15);
            this.rtb_Passage.Name = "rtb_Passage";
            this.rtb_Passage.ReadOnly = true;
            this.rtb_Passage.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.rtb_Passage.ShortcutsEnabled = false;
            this.rtb_Passage.Size = new Size(0x19c, 0x1d8);
            this.rtb_Passage.TabIndex = 4;
            this.rtb_Passage.TabStop = false;
            this.rtb_Passage.Text = "";
            this.rtb_Passage.MouseClick += new MouseEventHandler(this.rtb_Passage_MouseClick);
            this.rtb_Passage.MouseMove += new MouseEventHandler(this.rtb_Passage_MouseMove);
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = SystemColors.ControlLight;
            this.flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.rtb_question);
            this.flowLayoutPanel1.Controls.Add(this.tlp_answers);
            this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new Point(4, 0x12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new Size(0x15a, 0x213);
            this.flowLayoutPanel1.TabIndex = 3;
            this.rtb_question.BackColor = SystemColors.ControlLight;
            this.rtb_question.BorderStyle = BorderStyle.None;
            this.rtb_question.Location = new Point(3, 3);
            this.rtb_question.Name = "rtb_question";
            this.rtb_question.ReadOnly = true;
            this.rtb_question.ScrollBars = RichTextBoxScrollBars.None;
            this.rtb_question.Size = new Size(0x14b, 0x2f);
            this.rtb_question.TabIndex = 0;
            this.rtb_question.TabStop = false;
            this.rtb_question.Text = "";
            this.tlp_answers.AutoSize = true;
            this.tlp_answers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tlp_answers.ColumnCount = 2;
            this.tlp_answers.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40f));
            this.tlp_answers.ColumnStyles.Add(new ColumnStyle());
            this.tlp_answers.Controls.Add(this.rtb_answerE, 1, 4);
            this.tlp_answers.Controls.Add(this.rtb_answerD, 1, 3);
            this.tlp_answers.Controls.Add(this.rtb_answerC, 1, 2);
            this.tlp_answers.Controls.Add(this.rtb_answerB, 1, 1);
            this.tlp_answers.Controls.Add(this.ckb_A, 0, 0);
            this.tlp_answers.Controls.Add(this.ckb_B, 0, 1);
            this.tlp_answers.Controls.Add(this.ckb_C, 0, 2);
            this.tlp_answers.Controls.Add(this.ckb_D, 0, 3);
            this.tlp_answers.Controls.Add(this.ckb_E, 0, 4);
            this.tlp_answers.Controls.Add(this.rtb_answerA, 1, 0);
            this.tlp_answers.Controls.Add(this.ckb_F, 0, 5);
            this.tlp_answers.Controls.Add(this.ckb_G, 0, 6);
            this.tlp_answers.Controls.Add(this.ckb_H, 0, 7);
            this.tlp_answers.Controls.Add(this.rtb_answerF, 1, 5);
            this.tlp_answers.Controls.Add(this.rtb_answerG, 1, 6);
            this.tlp_answers.Controls.Add(this.rtb_answerH, 1, 7);
            this.tlp_answers.Location = new Point(3, 0x38);
            this.tlp_answers.Name = "tlp_answers";
            this.tlp_answers.RowCount = 8;
            this.tlp_answers.RowStyles.Add(new RowStyle());
            this.tlp_answers.RowStyles.Add(new RowStyle());
            this.tlp_answers.RowStyles.Add(new RowStyle());
            this.tlp_answers.RowStyles.Add(new RowStyle());
            this.tlp_answers.RowStyles.Add(new RowStyle());
            this.tlp_answers.RowStyles.Add(new RowStyle());
            this.tlp_answers.RowStyles.Add(new RowStyle());
            this.tlp_answers.RowStyles.Add(new RowStyle());
            this.tlp_answers.Size = new Size(0x150, 0x188);
            this.tlp_answers.TabIndex = 1;
            this.rtb_answerE.BackColor = SystemColors.ControlLight;
            this.rtb_answerE.BorderStyle = BorderStyle.None;
            this.rtb_answerE.Location = new Point(0x2b, 0xc7);
            this.rtb_answerE.Name = "rtb_answerE";
            this.rtb_answerE.ReadOnly = true;
            this.rtb_answerE.ShortcutsEnabled = false;
            this.rtb_answerE.Size = new Size(290, 0x2b);
            this.rtb_answerE.TabIndex = 9;
            this.rtb_answerE.TabStop = false;
            this.rtb_answerE.Text = "";
            this.rtb_answerE.Visible = false;
            this.rtb_answerD.BackColor = SystemColors.ControlLight;
            this.rtb_answerD.BorderStyle = BorderStyle.None;
            this.rtb_answerD.Location = new Point(0x2b, 150);
            this.rtb_answerD.Name = "rtb_answerD";
            this.rtb_answerD.ReadOnly = true;
            this.rtb_answerD.ShortcutsEnabled = false;
            this.rtb_answerD.Size = new Size(290, 0x2b);
            this.rtb_answerD.TabIndex = 8;
            this.rtb_answerD.TabStop = false;
            this.rtb_answerD.Text = "";
            this.rtb_answerD.Visible = false;
            this.rtb_answerC.BackColor = SystemColors.ControlLight;
            this.rtb_answerC.BorderStyle = BorderStyle.None;
            this.rtb_answerC.Location = new Point(0x2b, 0x65);
            this.rtb_answerC.Name = "rtb_answerC";
            this.rtb_answerC.ReadOnly = true;
            this.rtb_answerC.ShortcutsEnabled = false;
            this.rtb_answerC.Size = new Size(290, 0x2b);
            this.rtb_answerC.TabIndex = 7;
            this.rtb_answerC.TabStop = false;
            this.rtb_answerC.Text = "";
            this.rtb_answerC.Visible = false;
            this.rtb_answerB.BackColor = SystemColors.ControlLight;
            this.rtb_answerB.BorderStyle = BorderStyle.None;
            this.rtb_answerB.Location = new Point(0x2b, 0x34);
            this.rtb_answerB.Name = "rtb_answerB";
            this.rtb_answerB.ReadOnly = true;
            this.rtb_answerB.ShortcutsEnabled = false;
            this.rtb_answerB.Size = new Size(290, 0x2b);
            this.rtb_answerB.TabIndex = 6;
            this.rtb_answerB.TabStop = false;
            this.rtb_answerB.Text = "";
            this.rtb_answerB.Visible = false;
            this.ckb_A.Appearance = Appearance.Button;
            this.ckb_A.AutoSize = true;
            this.ckb_A.FlatAppearance.CheckedBackColor = Color.Gray;
            this.ckb_A.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.ckb_A.FlatStyle = FlatStyle.Flat;
            this.ckb_A.Location = new Point(3, 3);
            this.ckb_A.Name = "ckb_A";
            this.ckb_A.Size = new Size(0x18, 0x17);
            this.ckb_A.TabIndex = 0;
            this.ckb_A.TabStop = false;
            this.ckb_A.Text = "A";
            this.ckb_A.UseVisualStyleBackColor = true;
            this.ckb_A.Visible = false;
            this.ckb_B.Appearance = Appearance.Button;
            this.ckb_B.AutoSize = true;
            this.ckb_B.FlatAppearance.CheckedBackColor = Color.Gray;
            this.ckb_B.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.ckb_B.FlatStyle = FlatStyle.Flat;
            this.ckb_B.Location = new Point(3, 0x34);
            this.ckb_B.Name = "ckb_B";
            this.ckb_B.Size = new Size(0x18, 0x17);
            this.ckb_B.TabIndex = 1;
            this.ckb_B.TabStop = false;
            this.ckb_B.Text = "B";
            this.ckb_B.UseVisualStyleBackColor = true;
            this.ckb_B.Visible = false;
            this.ckb_C.Appearance = Appearance.Button;
            this.ckb_C.AutoSize = true;
            this.ckb_C.FlatAppearance.CheckedBackColor = Color.Gray;
            this.ckb_C.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.ckb_C.FlatStyle = FlatStyle.Flat;
            this.ckb_C.Location = new Point(3, 0x65);
            this.ckb_C.Name = "ckb_C";
            this.ckb_C.Size = new Size(0x18, 0x17);
            this.ckb_C.TabIndex = 2;
            this.ckb_C.TabStop = false;
            this.ckb_C.Text = "C";
            this.ckb_C.UseVisualStyleBackColor = true;
            this.ckb_C.Visible = false;
            this.ckb_D.Appearance = Appearance.Button;
            this.ckb_D.AutoSize = true;
            this.ckb_D.FlatAppearance.CheckedBackColor = Color.Gray;
            this.ckb_D.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.ckb_D.FlatStyle = FlatStyle.Flat;
            this.ckb_D.Location = new Point(3, 150);
            this.ckb_D.Name = "ckb_D";
            this.ckb_D.Size = new Size(0x19, 0x17);
            this.ckb_D.TabIndex = 3;
            this.ckb_D.TabStop = false;
            this.ckb_D.Text = "D";
            this.ckb_D.UseVisualStyleBackColor = true;
            this.ckb_D.Visible = false;
            this.ckb_E.Appearance = Appearance.Button;
            this.ckb_E.AutoSize = true;
            this.ckb_E.FlatAppearance.CheckedBackColor = Color.Gray;
            this.ckb_E.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.ckb_E.FlatStyle = FlatStyle.Flat;
            this.ckb_E.Location = new Point(3, 0xc7);
            this.ckb_E.Name = "ckb_E";
            this.ckb_E.Size = new Size(0x18, 0x17);
            this.ckb_E.TabIndex = 4;
            this.ckb_E.TabStop = false;
            this.ckb_E.Text = "E";
            this.ckb_E.UseVisualStyleBackColor = true;
            this.ckb_E.Visible = false;
            this.rtb_answerA.BackColor = SystemColors.ControlLight;
            this.rtb_answerA.BorderStyle = BorderStyle.None;
            this.rtb_answerA.Location = new Point(0x2b, 3);
            this.rtb_answerA.Name = "rtb_answerA";
            this.rtb_answerA.ReadOnly = true;
            this.rtb_answerA.ShortcutsEnabled = false;
            this.rtb_answerA.Size = new Size(290, 0x2b);
            this.rtb_answerA.TabIndex = 5;
            this.rtb_answerA.TabStop = false;
            this.rtb_answerA.Text = "";
            this.rtb_answerA.Visible = false;
            this.ckb_F.Appearance = Appearance.Button;
            this.ckb_F.AutoSize = true;
            this.ckb_F.FlatAppearance.CheckedBackColor = Color.Gray;
            this.ckb_F.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.ckb_F.FlatStyle = FlatStyle.Flat;
            this.ckb_F.Location = new Point(3, 0xf8);
            this.ckb_F.Name = "ckb_F";
            this.ckb_F.Size = new Size(0x17, 0x17);
            this.ckb_F.TabIndex = 4;
            this.ckb_F.TabStop = false;
            this.ckb_F.Text = "F";
            this.ckb_F.UseVisualStyleBackColor = true;
            this.ckb_F.Visible = false;
            this.ckb_G.Appearance = Appearance.Button;
            this.ckb_G.AutoSize = true;
            this.ckb_G.FlatAppearance.CheckedBackColor = Color.Gray;
            this.ckb_G.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.ckb_G.FlatStyle = FlatStyle.Flat;
            this.ckb_G.Location = new Point(3, 0x129);
            this.ckb_G.Name = "ckb_G";
            this.ckb_G.Size = new Size(0x19, 0x17);
            this.ckb_G.TabIndex = 4;
            this.ckb_G.TabStop = false;
            this.ckb_G.Text = "G";
            this.ckb_G.UseVisualStyleBackColor = true;
            this.ckb_G.Visible = false;
            this.ckb_H.Appearance = Appearance.Button;
            this.ckb_H.AutoSize = true;
            this.ckb_H.FlatAppearance.CheckedBackColor = Color.Gray;
            this.ckb_H.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.ckb_H.FlatStyle = FlatStyle.Flat;
            this.ckb_H.Location = new Point(3, 0x15a);
            this.ckb_H.Name = "ckb_H";
            this.ckb_H.Size = new Size(0x19, 0x17);
            this.ckb_H.TabIndex = 4;
            this.ckb_H.TabStop = false;
            this.ckb_H.Text = "H";
            this.ckb_H.UseVisualStyleBackColor = true;
            this.ckb_H.Visible = false;
            this.rtb_answerF.BackColor = SystemColors.ControlLight;
            this.rtb_answerF.BorderStyle = BorderStyle.None;
            this.rtb_answerF.Location = new Point(0x2b, 0xf8);
            this.rtb_answerF.Name = "rtb_answerF";
            this.rtb_answerF.ReadOnly = true;
            this.rtb_answerF.ShortcutsEnabled = false;
            this.rtb_answerF.Size = new Size(290, 0x2b);
            this.rtb_answerF.TabIndex = 9;
            this.rtb_answerF.TabStop = false;
            this.rtb_answerF.Text = "";
            this.rtb_answerF.Visible = false;
            this.rtb_answerG.BackColor = SystemColors.ControlLight;
            this.rtb_answerG.BorderStyle = BorderStyle.None;
            this.rtb_answerG.Location = new Point(0x2b, 0x129);
            this.rtb_answerG.Name = "rtb_answerG";
            this.rtb_answerG.ReadOnly = true;
            this.rtb_answerG.ShortcutsEnabled = false;
            this.rtb_answerG.Size = new Size(290, 0x2b);
            this.rtb_answerG.TabIndex = 9;
            this.rtb_answerG.TabStop = false;
            this.rtb_answerG.Text = "";
            this.rtb_answerG.Visible = false;
            this.rtb_answerH.BackColor = SystemColors.ControlLight;
            this.rtb_answerH.BorderStyle = BorderStyle.None;
            this.rtb_answerH.Location = new Point(0x2b, 0x15a);
            this.rtb_answerH.Name = "rtb_answerH";
            this.rtb_answerH.ReadOnly = true;
            this.rtb_answerH.ShortcutsEnabled = false;
            this.rtb_answerH.Size = new Size(290, 0x2b);
            this.rtb_answerH.TabIndex = 9;
            this.rtb_answerH.TabStop = false;
            this.rtb_answerH.Text = "";
            this.rtb_answerH.Visible = false;
            this.btn_stopReading.BackColor = Color.Transparent;
            this.btn_stopReading.FlatStyle = FlatStyle.Popup;
            this.btn_stopReading.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.btn_stopReading.Location = new Point(0x2c7, 0);
            this.btn_stopReading.Name = "btn_stopReading";
            this.btn_stopReading.Size = new Size(0x37, 0x15);
            this.btn_stopReading.TabIndex = 0x18;
            this.btn_stopReading.Text = "Stop";
            this.btn_stopReading.UseVisualStyleBackColor = false;
            this.btn_stopReading.Visible = false;
            this.btn_stopReading.Click += new EventHandler(this.btn_stopReading_Click);
            this.bn_readText.BackColor = Color.Transparent;
            this.bn_readText.FlatStyle = FlatStyle.Popup;
            this.bn_readText.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.bn_readText.Location = new Point(0x15c, -1);
            this.bn_readText.Name = "bn_readText";
            this.bn_readText.Size = new Size(0x4b, 0x15);
            this.bn_readText.TabIndex = 0x18;
            this.bn_readText.Text = "ReadText";
            this.bn_readText.UseVisualStyleBackColor = false;
            this.bn_readText.Click += new EventHandler(this.bn_readText_Click);
            this.lbl_readingIndication.BackColor = Color.Teal;
            this.lbl_readingIndication.BorderStyle = BorderStyle.Fixed3D;
            this.lbl_readingIndication.Font = new Font("SimSun", 12f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.lbl_readingIndication.ForeColor = SystemColors.ActiveCaptionText;
            this.lbl_readingIndication.Location = new Point(0x15c, -1);
            this.lbl_readingIndication.Name = "lbl_readingIndication";
            this.lbl_readingIndication.RightToLeft = RightToLeft.Yes;
            this.lbl_readingIndication.Size = new Size(0x1a0, 0x16);
            this.lbl_readingIndication.TabIndex = 5;
            this.lbl_readingIndication.Text = "Beginning";
            this.rtab_SumQuestion.Controls.Add(this.llbl_rightAnswer);
            this.rtab_SumQuestion.Controls.Add(this.flowLayoutPanel2);
            this.rtab_SumQuestion.Location = new Point(4, 0x19);
            this.rtab_SumQuestion.Name = "rtab_SumQuestion";
            this.rtab_SumQuestion.Padding = new Padding(3);
            this.rtab_SumQuestion.Size = new Size(0x2fb, 0x20c);
            this.rtab_SumQuestion.TabIndex = 1;
            this.rtab_SumQuestion.Text = "rSumQuestion";
            this.rtab_SumQuestion.UseVisualStyleBackColor = true;
            this.llbl_rightAnswer.AutoSize = true;
            this.llbl_rightAnswer.Location = new Point(7, 0x68);
            this.llbl_rightAnswer.Name = "llbl_rightAnswer";
            this.llbl_rightAnswer.Size = new Size(0x3e, 13);
            this.llbl_rightAnswer.TabIndex = 2;
            this.llbl_rightAnswer.Text = "rightAnswer";
            this.llbl_rightAnswer.Visible = false;
            this.flowLayoutPanel2.Controls.Add(this.rtb_sumPassage);
            this.flowLayoutPanel2.Controls.Add(this.rtb_sumQuestion);
            this.flowLayoutPanel2.Controls.Add(this.tlp_sumAnswers);
            this.flowLayoutPanel2.Controls.Add(this.tlp_Summary);
            this.flowLayoutPanel2.Location = new Point(0x4d, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new Size(0x26b, 0x202);
            this.flowLayoutPanel2.TabIndex = 1;
            this.rtb_sumPassage.BackColor = SystemColors.Window;
            this.rtb_sumPassage.BorderStyle = BorderStyle.None;
            this.rtb_sumPassage.Location = new Point(3, 3);
            this.rtb_sumPassage.Name = "rtb_sumPassage";
            this.rtb_sumPassage.ReadOnly = true;
            this.rtb_sumPassage.ShortcutsEnabled = false;
            this.rtb_sumPassage.Size = new Size(0x265, 0x16);
            this.rtb_sumPassage.TabIndex = 5;
            this.rtb_sumPassage.TabStop = false;
            this.rtb_sumPassage.Text = "";
            this.rtb_sumPassage.Visible = false;
            this.rtb_sumQuestion.BackColor = SystemColors.Window;
            this.rtb_sumQuestion.BorderStyle = BorderStyle.None;
            this.rtb_sumQuestion.Location = new Point(3, 0x1f);
            this.rtb_sumQuestion.Name = "rtb_sumQuestion";
            this.rtb_sumQuestion.ReadOnly = true;
            this.rtb_sumQuestion.Size = new Size(0x265, 0x12);
            this.rtb_sumQuestion.TabIndex = 2;
            this.rtb_sumQuestion.TabStop = false;
            this.rtb_sumQuestion.Text = "";
            this.rtb_sumQuestion.Visible = false;
            this.tlp_sumAnswers.AutoSize = true;
            this.tlp_sumAnswers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tlp_sumAnswers.BackColor = Color.Transparent;
            this.tlp_sumAnswers.ColumnCount = 2;
            this.tlp_sumAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40f));
            this.tlp_sumAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tlp_sumAnswers.Controls.Add(this.rtb_SumSelected5, 1, 4);
            this.tlp_sumAnswers.Controls.Add(this.rtb_SumSelected1, 1, 0);
            this.tlp_sumAnswers.Controls.Add(this.rtb_SumSelected2, 1, 1);
            this.tlp_sumAnswers.Controls.Add(this.rtb_SumSelected3, 1, 2);
            this.tlp_sumAnswers.Controls.Add(this.rtb_SumSelected4, 1, 3);
            this.tlp_sumAnswers.Controls.Add(this.ckb_SumSelected1, 0, 0);
            this.tlp_sumAnswers.Controls.Add(this.ckb_SumSelected2, 0, 1);
            this.tlp_sumAnswers.Controls.Add(this.ckb_SumSelected3, 0, 2);
            this.tlp_sumAnswers.Controls.Add(this.ckb_SumSelected4, 0, 3);
            this.tlp_sumAnswers.Controls.Add(this.ckb_SumSelected5, 0, 4);
            this.tlp_sumAnswers.Location = new Point(3, 0x37);
            this.tlp_sumAnswers.Name = "tlp_sumAnswers";
            this.tlp_sumAnswers.RowCount = 5;
            this.tlp_sumAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
            this.tlp_sumAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
            this.tlp_sumAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
            this.tlp_sumAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
            this.tlp_sumAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
            this.tlp_sumAnswers.Size = new Size(0x265, 140);
            this.tlp_sumAnswers.TabIndex = 3;
            this.rtb_SumSelected5.BackColor = Color.LightGray;
            this.rtb_SumSelected5.BorderStyle = BorderStyle.None;
            this.rtb_SumSelected5.Cursor = Cursors.Hand;
            this.rtb_SumSelected5.Location = new Point(0x2b, 0x73);
            this.rtb_SumSelected5.Name = "rtb_SumSelected5";
            this.rtb_SumSelected5.ReadOnly = true;
            this.rtb_SumSelected5.ShortcutsEnabled = false;
            this.rtb_SumSelected5.Size = new Size(0x237, 0x16);
            this.rtb_SumSelected5.TabIndex = 1;
            this.rtb_SumSelected5.TabStop = false;
            this.rtb_SumSelected5.Text = "";
            this.rtb_SumSelected5.Visible = false;
            this.rtb_SumSelected1.BackColor = Color.LightGray;
            this.rtb_SumSelected1.BorderStyle = BorderStyle.None;
            this.rtb_SumSelected1.Cursor = Cursors.Hand;
            this.rtb_SumSelected1.Location = new Point(0x2b, 3);
            this.rtb_SumSelected1.Name = "rtb_SumSelected1";
            this.rtb_SumSelected1.ReadOnly = true;
            this.rtb_SumSelected1.ShortcutsEnabled = false;
            this.rtb_SumSelected1.Size = new Size(0x237, 0x12);
            this.rtb_SumSelected1.TabIndex = 0;
            this.rtb_SumSelected1.TabStop = false;
            this.rtb_SumSelected1.Text = "";
            this.rtb_SumSelected1.Visible = false;
            this.rtb_SumSelected2.BackColor = Color.LightGray;
            this.rtb_SumSelected2.BorderStyle = BorderStyle.None;
            this.rtb_SumSelected2.Cursor = Cursors.Hand;
            this.rtb_SumSelected2.Location = new Point(0x2b, 0x1f);
            this.rtb_SumSelected2.Name = "rtb_SumSelected2";
            this.rtb_SumSelected2.ReadOnly = true;
            this.rtb_SumSelected2.ShortcutsEnabled = false;
            this.rtb_SumSelected2.Size = new Size(0x237, 0x12);
            this.rtb_SumSelected2.TabIndex = 0;
            this.rtb_SumSelected2.TabStop = false;
            this.rtb_SumSelected2.Text = "";
            this.rtb_SumSelected2.Visible = false;
            this.rtb_SumSelected3.BackColor = Color.LightGray;
            this.rtb_SumSelected3.BorderStyle = BorderStyle.None;
            this.rtb_SumSelected3.Cursor = Cursors.Hand;
            this.rtb_SumSelected3.Location = new Point(0x2b, 0x3b);
            this.rtb_SumSelected3.Name = "rtb_SumSelected3";
            this.rtb_SumSelected3.ReadOnly = true;
            this.rtb_SumSelected3.ShortcutsEnabled = false;
            this.rtb_SumSelected3.Size = new Size(0x237, 0x12);
            this.rtb_SumSelected3.TabIndex = 0;
            this.rtb_SumSelected3.TabStop = false;
            this.rtb_SumSelected3.Text = "";
            this.rtb_SumSelected3.Visible = false;
            this.rtb_SumSelected4.BackColor = Color.LightGray;
            this.rtb_SumSelected4.BorderStyle = BorderStyle.None;
            this.rtb_SumSelected4.Cursor = Cursors.Hand;
            this.rtb_SumSelected4.Location = new Point(0x2b, 0x57);
            this.rtb_SumSelected4.Name = "rtb_SumSelected4";
            this.rtb_SumSelected4.ReadOnly = true;
            this.rtb_SumSelected4.ShortcutsEnabled = false;
            this.rtb_SumSelected4.Size = new Size(0x237, 0x12);
            this.rtb_SumSelected4.TabIndex = 0;
            this.rtb_SumSelected4.TabStop = false;
            this.rtb_SumSelected4.Text = "";
            this.rtb_SumSelected4.Visible = false;
            this.ckb_SumSelected1.AutoSize = true;
            this.ckb_SumSelected1.BackColor = Color.LightGray;
            this.ckb_SumSelected1.Checked = true;
            this.ckb_SumSelected1.CheckState = CheckState.Checked;
            this.ckb_SumSelected1.Location = new Point(3, 3);
            this.ckb_SumSelected1.Name = "ckb_SumSelected1";
            this.ckb_SumSelected1.Size = new Size(15, 14);
            this.ckb_SumSelected1.TabIndex = 2;
            this.ckb_SumSelected1.TabStop = false;
            this.ckb_SumSelected1.UseVisualStyleBackColor = false;
            this.ckb_SumSelected1.Visible = false;
            this.ckb_SumSelected2.AutoSize = true;
            this.ckb_SumSelected2.BackColor = Color.LightGray;
            this.ckb_SumSelected2.Checked = true;
            this.ckb_SumSelected2.CheckState = CheckState.Checked;
            this.ckb_SumSelected2.Location = new Point(3, 0x1f);
            this.ckb_SumSelected2.Name = "ckb_SumSelected2";
            this.ckb_SumSelected2.Size = new Size(15, 14);
            this.ckb_SumSelected2.TabIndex = 2;
            this.ckb_SumSelected2.TabStop = false;
            this.ckb_SumSelected2.UseVisualStyleBackColor = false;
            this.ckb_SumSelected2.Visible = false;
            this.ckb_SumSelected3.AutoSize = true;
            this.ckb_SumSelected3.BackColor = Color.LightGray;
            this.ckb_SumSelected3.Checked = true;
            this.ckb_SumSelected3.CheckState = CheckState.Checked;
            this.ckb_SumSelected3.Location = new Point(3, 0x3b);
            this.ckb_SumSelected3.Name = "ckb_SumSelected3";
            this.ckb_SumSelected3.Size = new Size(15, 14);
            this.ckb_SumSelected3.TabIndex = 2;
            this.ckb_SumSelected3.TabStop = false;
            this.ckb_SumSelected3.UseVisualStyleBackColor = false;
            this.ckb_SumSelected3.Visible = false;
            this.ckb_SumSelected4.AutoSize = true;
            this.ckb_SumSelected4.BackColor = Color.LightGray;
            this.ckb_SumSelected4.Checked = true;
            this.ckb_SumSelected4.CheckState = CheckState.Checked;
            this.ckb_SumSelected4.Location = new Point(3, 0x57);
            this.ckb_SumSelected4.Name = "ckb_SumSelected4";
            this.ckb_SumSelected4.Size = new Size(15, 14);
            this.ckb_SumSelected4.TabIndex = 2;
            this.ckb_SumSelected4.TabStop = false;
            this.ckb_SumSelected4.UseVisualStyleBackColor = false;
            this.ckb_SumSelected4.Visible = false;
            this.ckb_SumSelected5.AutoSize = true;
            this.ckb_SumSelected5.BackColor = Color.LightGray;
            this.ckb_SumSelected5.Checked = true;
            this.ckb_SumSelected5.CheckState = CheckState.Checked;
            this.ckb_SumSelected5.Location = new Point(3, 0x73);
            this.ckb_SumSelected5.Name = "ckb_SumSelected5";
            this.ckb_SumSelected5.Size = new Size(15, 14);
            this.ckb_SumSelected5.TabIndex = 2;
            this.ckb_SumSelected5.TabStop = false;
            this.ckb_SumSelected5.UseVisualStyleBackColor = false;
            this.ckb_SumSelected5.Visible = false;
            this.tlp_Summary.AutoSize = true;
            this.tlp_Summary.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tlp_Summary.ColumnCount = 2;
            this.tlp_Summary.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40f));
            this.tlp_Summary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tlp_Summary.Controls.Add(this.rtb_sumAnswer5, 1, 4);
            this.tlp_Summary.Controls.Add(this.rtb_sumAnswer1, 1, 0);
            this.tlp_Summary.Controls.Add(this.rtb_sumAnswer2, 1, 1);
            this.tlp_Summary.Controls.Add(this.rtb_sumAnswer3, 1, 2);
            this.tlp_Summary.Controls.Add(this.rtb_sumAnswer4, 1, 3);
            this.tlp_Summary.Controls.Add(this.ckb_sumAnswer1, 0, 0);
            this.tlp_Summary.Controls.Add(this.ckb_sumAnswer2, 0, 1);
            this.tlp_Summary.Controls.Add(this.ckb_sumAnswer3, 0, 2);
            this.tlp_Summary.Controls.Add(this.ckb_sumAnswer4, 0, 3);
            this.tlp_Summary.Controls.Add(this.ckb_sumAnswer5, 0, 4);
            this.tlp_Summary.Controls.Add(this.ckb_sumAnswer6, 0, 5);
            this.tlp_Summary.Controls.Add(this.rtb_sumAnswer6, 1, 5);
            this.tlp_Summary.Controls.Add(this.ckb_sumAnswer7, 0, 6);
            this.tlp_Summary.Controls.Add(this.ckb_sumAnswer8, 0, 7);
            this.tlp_Summary.Controls.Add(this.rtb_sumAnswer7, 1, 6);
            this.tlp_Summary.Controls.Add(this.rtb_sumAnswer8, 1, 7);
            this.tlp_Summary.Controls.Add(this.ckb_sumAnswer9, 0, 8);
            this.tlp_Summary.Controls.Add(this.ckb_sumAnswer10, 0, 9);
            this.tlp_Summary.Controls.Add(this.rtb_sumAnswer9, 1, 8);
            this.tlp_Summary.Controls.Add(this.rtb_sumAnswer10, 1, 9);
            this.tlp_Summary.Location = new Point(3, 0xc9);
            this.tlp_Summary.Name = "tlp_Summary";
            this.tlp_Summary.RowCount = 10;
            this.tlp_Summary.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tlp_Summary.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tlp_Summary.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tlp_Summary.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tlp_Summary.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tlp_Summary.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tlp_Summary.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tlp_Summary.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tlp_Summary.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tlp_Summary.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.tlp_Summary.Size = new Size(0x265, 280);
            this.tlp_Summary.TabIndex = 4;
            this.rtb_sumAnswer5.BackColor = SystemColors.ControlLightLight;
            this.rtb_sumAnswer5.BorderStyle = BorderStyle.None;
            this.rtb_sumAnswer5.Location = new Point(0x2b, 0x73);
            this.rtb_sumAnswer5.Name = "rtb_sumAnswer5";
            this.rtb_sumAnswer5.ReadOnly = true;
            this.rtb_sumAnswer5.ShortcutsEnabled = false;
            this.rtb_sumAnswer5.Size = new Size(0x237, 0x16);
            this.rtb_sumAnswer5.TabIndex = 1;
            this.rtb_sumAnswer5.TabStop = false;
            this.rtb_sumAnswer5.Text = "";
            this.rtb_sumAnswer5.Visible = false;
            this.rtb_sumAnswer1.BackColor = SystemColors.ControlLightLight;
            this.rtb_sumAnswer1.BorderStyle = BorderStyle.None;
            this.rtb_sumAnswer1.Location = new Point(0x2b, 3);
            this.rtb_sumAnswer1.Name = "rtb_sumAnswer1";
            this.rtb_sumAnswer1.ReadOnly = true;
            this.rtb_sumAnswer1.ShortcutsEnabled = false;
            this.rtb_sumAnswer1.Size = new Size(0x237, 0x16);
            this.rtb_sumAnswer1.TabIndex = 0;
            this.rtb_sumAnswer1.TabStop = false;
            this.rtb_sumAnswer1.Text = "";
            this.rtb_sumAnswer1.Visible = false;
            this.rtb_sumAnswer2.BackColor = SystemColors.ControlLightLight;
            this.rtb_sumAnswer2.BorderStyle = BorderStyle.None;
            this.rtb_sumAnswer2.Location = new Point(0x2b, 0x1f);
            this.rtb_sumAnswer2.Name = "rtb_sumAnswer2";
            this.rtb_sumAnswer2.ReadOnly = true;
            this.rtb_sumAnswer2.ShortcutsEnabled = false;
            this.rtb_sumAnswer2.Size = new Size(0x237, 0x16);
            this.rtb_sumAnswer2.TabIndex = 0;
            this.rtb_sumAnswer2.TabStop = false;
            this.rtb_sumAnswer2.Text = "";
            this.rtb_sumAnswer2.Visible = false;
            this.rtb_sumAnswer3.BackColor = SystemColors.ControlLightLight;
            this.rtb_sumAnswer3.BorderStyle = BorderStyle.None;
            this.rtb_sumAnswer3.Location = new Point(0x2b, 0x3b);
            this.rtb_sumAnswer3.Name = "rtb_sumAnswer3";
            this.rtb_sumAnswer3.ReadOnly = true;
            this.rtb_sumAnswer3.ShortcutsEnabled = false;
            this.rtb_sumAnswer3.Size = new Size(0x237, 0x16);
            this.rtb_sumAnswer3.TabIndex = 0;
            this.rtb_sumAnswer3.TabStop = false;
            this.rtb_sumAnswer3.Text = "";
            this.rtb_sumAnswer3.Visible = false;
            this.rtb_sumAnswer4.BackColor = SystemColors.ControlLightLight;
            this.rtb_sumAnswer4.BorderStyle = BorderStyle.None;
            this.rtb_sumAnswer4.Location = new Point(0x2b, 0x57);
            this.rtb_sumAnswer4.Name = "rtb_sumAnswer4";
            this.rtb_sumAnswer4.ReadOnly = true;
            this.rtb_sumAnswer4.ShortcutsEnabled = false;
            this.rtb_sumAnswer4.Size = new Size(0x237, 0x16);
            this.rtb_sumAnswer4.TabIndex = 0;
            this.rtb_sumAnswer4.TabStop = false;
            this.rtb_sumAnswer4.Text = "";
            this.rtb_sumAnswer4.Visible = false;
            this.ckb_sumAnswer1.AutoSize = true;
            this.ckb_sumAnswer1.Enabled = false;
            this.ckb_sumAnswer1.Location = new Point(3, 3);
            this.ckb_sumAnswer1.Name = "ckb_sumAnswer1";
            this.ckb_sumAnswer1.Size = new Size(0x21, 0x11);
            this.ckb_sumAnswer1.TabIndex = 2;
            this.ckb_sumAnswer1.TabStop = false;
            this.ckb_sumAnswer1.Text = "A";
            this.ckb_sumAnswer1.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer1.Visible = false;
            this.ckb_sumAnswer2.AutoSize = true;
            this.ckb_sumAnswer2.Enabled = false;
            this.ckb_sumAnswer2.Location = new Point(3, 0x1f);
            this.ckb_sumAnswer2.Name = "ckb_sumAnswer2";
            this.ckb_sumAnswer2.Size = new Size(0x21, 0x11);
            this.ckb_sumAnswer2.TabIndex = 2;
            this.ckb_sumAnswer2.TabStop = false;
            this.ckb_sumAnswer2.Text = "B";
            this.ckb_sumAnswer2.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer2.Visible = false;
            this.ckb_sumAnswer3.AutoSize = true;
            this.ckb_sumAnswer3.Enabled = false;
            this.ckb_sumAnswer3.Location = new Point(3, 0x3b);
            this.ckb_sumAnswer3.Name = "ckb_sumAnswer3";
            this.ckb_sumAnswer3.Size = new Size(0x21, 0x11);
            this.ckb_sumAnswer3.TabIndex = 2;
            this.ckb_sumAnswer3.TabStop = false;
            this.ckb_sumAnswer3.Text = "C";
            this.ckb_sumAnswer3.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer3.Visible = false;
            this.ckb_sumAnswer4.AutoSize = true;
            this.ckb_sumAnswer4.Enabled = false;
            this.ckb_sumAnswer4.Location = new Point(3, 0x57);
            this.ckb_sumAnswer4.Name = "ckb_sumAnswer4";
            this.ckb_sumAnswer4.Size = new Size(0x22, 0x11);
            this.ckb_sumAnswer4.TabIndex = 2;
            this.ckb_sumAnswer4.TabStop = false;
            this.ckb_sumAnswer4.Text = "D";
            this.ckb_sumAnswer4.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer4.Visible = false;
            this.ckb_sumAnswer5.AutoSize = true;
            this.ckb_sumAnswer5.Enabled = false;
            this.ckb_sumAnswer5.Location = new Point(3, 0x73);
            this.ckb_sumAnswer5.Name = "ckb_sumAnswer5";
            this.ckb_sumAnswer5.Size = new Size(0x21, 0x11);
            this.ckb_sumAnswer5.TabIndex = 2;
            this.ckb_sumAnswer5.TabStop = false;
            this.ckb_sumAnswer5.Text = "E";
            this.ckb_sumAnswer5.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer5.Visible = false;
            this.ckb_sumAnswer6.AutoSize = true;
            this.ckb_sumAnswer6.Enabled = false;
            this.ckb_sumAnswer6.Location = new Point(3, 0x8f);
            this.ckb_sumAnswer6.Name = "ckb_sumAnswer6";
            this.ckb_sumAnswer6.Size = new Size(0x20, 0x11);
            this.ckb_sumAnswer6.TabIndex = 2;
            this.ckb_sumAnswer6.TabStop = false;
            this.ckb_sumAnswer6.Text = "F";
            this.ckb_sumAnswer6.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer6.Visible = false;
            this.rtb_sumAnswer6.BackColor = SystemColors.ControlLightLight;
            this.rtb_sumAnswer6.BorderStyle = BorderStyle.None;
            this.rtb_sumAnswer6.Location = new Point(0x2b, 0x8f);
            this.rtb_sumAnswer6.Name = "rtb_sumAnswer6";
            this.rtb_sumAnswer6.ReadOnly = true;
            this.rtb_sumAnswer6.ShortcutsEnabled = false;
            this.rtb_sumAnswer6.Size = new Size(0x237, 0x16);
            this.rtb_sumAnswer6.TabIndex = 1;
            this.rtb_sumAnswer6.TabStop = false;
            this.rtb_sumAnswer6.Text = "";
            this.rtb_sumAnswer6.Visible = false;
            this.ckb_sumAnswer7.AutoSize = true;
            this.ckb_sumAnswer7.Enabled = false;
            this.ckb_sumAnswer7.Location = new Point(3, 0xab);
            this.ckb_sumAnswer7.Name = "ckb_sumAnswer7";
            this.ckb_sumAnswer7.Size = new Size(0x22, 0x11);
            this.ckb_sumAnswer7.TabIndex = 2;
            this.ckb_sumAnswer7.TabStop = false;
            this.ckb_sumAnswer7.Text = "G";
            this.ckb_sumAnswer7.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer7.Visible = false;
            this.ckb_sumAnswer8.AutoSize = true;
            this.ckb_sumAnswer8.Enabled = false;
            this.ckb_sumAnswer8.Location = new Point(3, 0xc7);
            this.ckb_sumAnswer8.Name = "ckb_sumAnswer8";
            this.ckb_sumAnswer8.Size = new Size(0x22, 0x11);
            this.ckb_sumAnswer8.TabIndex = 2;
            this.ckb_sumAnswer8.TabStop = false;
            this.ckb_sumAnswer8.Text = "H";
            this.ckb_sumAnswer8.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer8.Visible = false;
            this.rtb_sumAnswer7.BackColor = SystemColors.ControlLightLight;
            this.rtb_sumAnswer7.BorderStyle = BorderStyle.None;
            this.rtb_sumAnswer7.Location = new Point(0x2b, 0xab);
            this.rtb_sumAnswer7.Name = "rtb_sumAnswer7";
            this.rtb_sumAnswer7.ReadOnly = true;
            this.rtb_sumAnswer7.ShortcutsEnabled = false;
            this.rtb_sumAnswer7.Size = new Size(0x237, 0x16);
            this.rtb_sumAnswer7.TabIndex = 1;
            this.rtb_sumAnswer7.TabStop = false;
            this.rtb_sumAnswer7.Text = "";
            this.rtb_sumAnswer7.Visible = false;
            this.rtb_sumAnswer8.BackColor = SystemColors.ControlLightLight;
            this.rtb_sumAnswer8.BorderStyle = BorderStyle.None;
            this.rtb_sumAnswer8.Location = new Point(0x2b, 0xc7);
            this.rtb_sumAnswer8.Name = "rtb_sumAnswer8";
            this.rtb_sumAnswer8.ReadOnly = true;
            this.rtb_sumAnswer8.ShortcutsEnabled = false;
            this.rtb_sumAnswer8.Size = new Size(0x237, 0x16);
            this.rtb_sumAnswer8.TabIndex = 1;
            this.rtb_sumAnswer8.TabStop = false;
            this.rtb_sumAnswer8.Text = "";
            this.rtb_sumAnswer8.Visible = false;
            this.ckb_sumAnswer9.AutoSize = true;
            this.ckb_sumAnswer9.Enabled = false;
            this.ckb_sumAnswer9.Location = new Point(3, 0xe3);
            this.ckb_sumAnswer9.Name = "ckb_sumAnswer9";
            this.ckb_sumAnswer9.Size = new Size(0x1d, 0x11);
            this.ckb_sumAnswer9.TabIndex = 2;
            this.ckb_sumAnswer9.TabStop = false;
            this.ckb_sumAnswer9.Text = "I";
            this.ckb_sumAnswer9.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer9.Visible = false;
            this.ckb_sumAnswer10.AutoSize = true;
            this.ckb_sumAnswer10.Enabled = false;
            this.ckb_sumAnswer10.Location = new Point(3, 0xff);
            this.ckb_sumAnswer10.Name = "ckb_sumAnswer10";
            this.ckb_sumAnswer10.Size = new Size(0x1f, 0x11);
            this.ckb_sumAnswer10.TabIndex = 2;
            this.ckb_sumAnswer10.Text = "J";
            this.ckb_sumAnswer10.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer10.Visible = false;
            this.rtb_sumAnswer9.BackColor = SystemColors.ControlLightLight;
            this.rtb_sumAnswer9.BorderStyle = BorderStyle.None;
            this.rtb_sumAnswer9.Location = new Point(0x2b, 0xe3);
            this.rtb_sumAnswer9.Name = "rtb_sumAnswer9";
            this.rtb_sumAnswer9.ReadOnly = true;
            this.rtb_sumAnswer9.ShortcutsEnabled = false;
            this.rtb_sumAnswer9.Size = new Size(0x237, 0x16);
            this.rtb_sumAnswer9.TabIndex = 1;
            this.rtb_sumAnswer9.TabStop = false;
            this.rtb_sumAnswer9.Text = "";
            this.rtb_sumAnswer9.Visible = false;
            this.rtb_sumAnswer10.BackColor = SystemColors.ControlLightLight;
            this.rtb_sumAnswer10.BorderStyle = BorderStyle.None;
            this.rtb_sumAnswer10.Location = new Point(0x2b, 0xff);
            this.rtb_sumAnswer10.Name = "rtb_sumAnswer10";
            this.rtb_sumAnswer10.ReadOnly = true;
            this.rtb_sumAnswer10.ShortcutsEnabled = false;
            this.rtb_sumAnswer10.Size = new Size(0x237, 0x16);
            this.rtb_sumAnswer10.TabIndex = 1;
            this.rtb_sumAnswer10.Text = "";
            this.rtb_sumAnswer10.Visible = false;
            this.rtab_Review.Controls.Add(this.lbl_scoreReport);
            this.rtab_Review.Controls.Add(this.lbl_wrongAnswered);
            this.rtab_Review.Controls.Add(this.pb_wrongAnswered);
            this.rtab_Review.Controls.Add(this.lbl_rightAnswered);
            this.rtab_Review.Controls.Add(this.pb_rightAnswered);
            this.rtab_Review.Controls.Add(this.label1);
            this.rtab_Review.Controls.Add(this.pictureBox5);
            this.rtab_Review.Controls.Add(this.dgv_readingReview);
            this.rtab_Review.Location = new Point(4, 0x19);
            this.rtab_Review.Name = "rtab_Review";
            this.rtab_Review.Size = new Size(0x2fb, 0x20c);
            this.rtab_Review.TabIndex = 2;
            this.rtab_Review.Text = "rReview";
            this.rtab_Review.UseVisualStyleBackColor = true;
            this.lbl_scoreReport.AutoSize = true;
            this.lbl_scoreReport.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.lbl_scoreReport.Location = new Point(0x44, 0x15);
            this.lbl_scoreReport.Name = "lbl_scoreReport";
            this.lbl_scoreReport.Size = new Size(0x61, 0x11);
            this.lbl_scoreReport.TabIndex = 5;
            this.lbl_scoreReport.Text = "scoreReport";
            this.lbl_wrongAnswered.AutoSize = true;
            this.lbl_wrongAnswered.Location = new Point(0x153, 0x39);
            this.lbl_wrongAnswered.Name = "lbl_wrongAnswered";
            this.lbl_wrongAnswered.Size = new Size(0x59, 13);
            this.lbl_wrongAnswered.TabIndex = 4;
            this.lbl_wrongAnswered.Text = "Wrong Answered";
            this.pb_wrongAnswered.BackColor = Color.Yellow;
            this.pb_wrongAnswered.Location = new Point(0x132, 0x30);
            this.pb_wrongAnswered.Name = "pb_wrongAnswered";
            this.pb_wrongAnswered.Size = new Size(0x1b, 0x16);
            this.pb_wrongAnswered.TabIndex = 3;
            this.pb_wrongAnswered.TabStop = false;
            this.lbl_rightAnswered.AutoSize = true;
            this.lbl_rightAnswered.Location = new Point(0xde, 0x39);
            this.lbl_rightAnswered.Name = "lbl_rightAnswered";
            this.lbl_rightAnswered.Size = new Size(0x52, 13);
            this.lbl_rightAnswered.TabIndex = 4;
            this.lbl_rightAnswered.Text = "Right Answered";
            this.pb_rightAnswered.BackColor = Color.Green;
            this.pb_rightAnswered.Location = new Point(0xbd, 0x30);
            this.pb_rightAnswered.Name = "pb_rightAnswered";
            this.pb_rightAnswered.Size = new Size(0x1b, 0x16);
            this.pb_rightAnswered.TabIndex = 3;
            this.pb_rightAnswered.TabStop = false;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(0x68, 0x39);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x4a, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Not Answered";
            this.pictureBox5.BackColor = Color.Red;
            this.pictureBox5.Location = new Point(0x47, 0x30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new Size(0x1b, 0x16);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.dgv_readingReview.AllowUserToAddRows = false;
            this.dgv_readingReview.AllowUserToDeleteRows = false;
            this.dgv_readingReview.AllowUserToResizeColumns = false;
            this.dgv_readingReview.AllowUserToResizeRows = false;
            this.dgv_readingReview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_readingReview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_readingReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_readingReview.Location = new Point(0x47, 0x4c);
            this.dgv_readingReview.MultiSelect = false;
            this.dgv_readingReview.Name = "dgv_readingReview";
            this.dgv_readingReview.ReadOnly = true;
            this.dgv_readingReview.RowHeadersVisible = false;
            this.dgv_readingReview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_readingReview.RowTemplate.Height = 0x17;
            this.dgv_readingReview.RowTemplate.ReadOnly = true;
            this.dgv_readingReview.RowTemplate.Resizable = DataGridViewTriState.False;
            this.dgv_readingReview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_readingReview.Size = new Size(0x284, 0x153);
            this.dgv_readingReview.TabIndex = 2;
            this.dgv_readingReview.TabStop = false;
            this.dgv_readingReview.CellContentClick += new DataGridViewCellEventHandler(this.dgv_readingReview_CellContentClick);
            this.dgv_readingReview.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.dgv_readingReview_ColumnHeaderMouseClick);
            this.dgv_readingReview.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dgv_readingReview_DataBindingComplete);
            this.tab_Listening.Controls.Add(this.tabf_Listening);
            this.tab_Listening.Location = new Point(4, 0x16);
            this.tab_Listening.Name = "tab_Listening";
            this.tab_Listening.Padding = new Padding(3);
            this.tab_Listening.Size = new Size(780, 0x20f);
            this.tab_Listening.TabIndex = 1;
            this.tab_Listening.Text = "Listening";
            this.tab_Listening.UseVisualStyleBackColor = true;
            this.tabf_Listening.Appearance = TabAppearance.Buttons;
            this.tabf_Listening.Controls.Add(this.ltab_Direction1);
            this.tabf_Listening.Controls.Add(this.ltab_Direction2);
            this.tabf_Listening.Controls.Add(this.ltab_Materials);
            this.tabf_Listening.Controls.Add(this.lMaterials1);
            this.tabf_Listening.Controls.Add(this.ltab_Question);
            this.tabf_Listening.Controls.Add(this.lTableQuestion);
            this.tabf_Listening.Location = new Point(4, -26);
            this.tabf_Listening.Name = "tabf_Listening";
            this.tabf_Listening.SelectedIndex = 0;
            this.tabf_Listening.Size = new Size(780, 0x22d);
            this.tabf_Listening.TabIndex = 1;
            this.tabf_Listening.TabStop = false;
            this.ltab_Direction1.Controls.Add(this.pictureBox1);
            this.ltab_Direction1.Location = new Point(4, 0x19);
            this.ltab_Direction1.Name = "ltab_Direction1";
            this.ltab_Direction1.Padding = new Padding(3);
            this.ltab_Direction1.Size = new Size(0x304, 0x210);
            this.ltab_Direction1.TabIndex = 0;
            this.ltab_Direction1.Text = "lDirection1";
            this.ltab_Direction1.UseVisualStyleBackColor = true;
            this.pictureBox1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.None;
            this.pictureBox1.Image = (Image) manager.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(0x1c, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x466, 0x215);
            this.pictureBox1.TabIndex = 0x13;
            this.pictureBox1.TabStop = false;
            this.ltab_Direction2.Location = new Point(4, 0x19);
            this.ltab_Direction2.Name = "ltab_Direction2";
            this.ltab_Direction2.Size = new Size(0x304, 0x210);
            this.ltab_Direction2.TabIndex = 3;
            this.ltab_Direction2.Text = "lDirection2";
            this.ltab_Direction2.UseVisualStyleBackColor = true;
            this.ltab_Materials.Controls.Add(this.l_splitContainer);
            this.ltab_Materials.Location = new Point(4, 0x19);
            this.ltab_Materials.Name = "ltab_Materials";
            this.ltab_Materials.Padding = new Padding(3);
            this.ltab_Materials.Size = new Size(0x304, 0x210);
            this.ltab_Materials.TabIndex = 1;
            this.ltab_Materials.Text = "lMaterials";
            this.ltab_Materials.UseVisualStyleBackColor = true;
            this.l_splitContainer.Dock = DockStyle.Fill;
            this.l_splitContainer.IsSplitterFixed = true;
            this.l_splitContainer.Location = new Point(3, 3);
            this.l_splitContainer.Name = "l_splitContainer";
            this.l_splitContainer.Panel1.Controls.Add(this.pb_currentpos);
            this.l_splitContainer.Panel1.Controls.Add(this.tb_currentpos);
            this.l_splitContainer.Panel1.Controls.Add(this.PlayFileName);
            this.l_splitContainer.Panel1.Controls.Add(this.pb_ListenScene);
            this.l_splitContainer.Panel2.AutoScroll = true;
            this.l_splitContainer.Panel2.AutoScrollMargin = new Size(10, 10);
            this.l_splitContainer.Panel2.Controls.Add(this.panel1);
            this.l_splitContainer.Size = new Size(0x2fe, 0x20a);
            this.l_splitContainer.SplitterDistance = 0x156;
            this.l_splitContainer.TabIndex = 1;
            this.pb_currentpos.Location = new Point(0x12, 0x19c);
            this.pb_currentpos.Name = "pb_currentpos";
            this.pb_currentpos.Size = new Size(0x134, 0x17);
            this.pb_currentpos.TabIndex = 0x26;
            this.tb_currentpos.AutoSize = false;
            this.tb_currentpos.Location = new Point(0x12, 8);
            this.tb_currentpos.Name = "tb_currentpos";
            this.tb_currentpos.Size = new Size(0x134, 20);
            this.tb_currentpos.TabIndex = 0x24;
            this.tb_currentpos.TabStop = false;
            this.tb_currentpos.TickStyle = TickStyle.None;
            this.tb_currentpos.Visible = false;
            this.tb_currentpos.Scroll += new EventHandler(this.tb_currentpos_Scroll);
            this.PlayFileName.AutoSize = true;
            this.PlayFileName.Location = new Point(-25, 480);
            this.PlayFileName.Name = "PlayFileName";
            this.PlayFileName.Size = new Size(0x23, 13);
            this.PlayFileName.TabIndex = 0x23;
            this.PlayFileName.Text = "label1";
            this.pb_ListenScene.Location = new Point(0x12, 0x33);
            this.pb_ListenScene.Name = "pb_ListenScene";
            this.pb_ListenScene.Size = new Size(0x134, 0x135);
            this.pb_ListenScene.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb_ListenScene.TabIndex = 0x25;
            this.pb_ListenScene.TabStop = false;
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flp_passage);
            this.panel1.Location = new Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x18c, 0x1c8);
            this.panel1.TabIndex = 0x1d;
            this.flp_passage.Controls.Add(this.lnk_passage);
            this.flp_passage.FlowDirection = FlowDirection.TopDown;
            this.flp_passage.Location = new Point(3, 12);
            this.flp_passage.Name = "flp_passage";
            this.flp_passage.Size = new Size(0x176, 0x4b0);
            this.flp_passage.TabIndex = 0x1c;
            this.lnk_passage.ActiveLinkColor = Color.Black;
            this.lnk_passage.AutoSize = true;
            this.lnk_passage.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lnk_passage.LinkBehavior = LinkBehavior.NeverUnderline;
            this.lnk_passage.LinkColor = Color.Black;
            this.lnk_passage.Location = new Point(3, 0);
            this.lnk_passage.Name = "lnk_passage";
            this.lnk_passage.Size = new Size(0x1a, 0x11);
            this.lnk_passage.TabIndex = 0;
            this.lnk_passage.TabStop = true;
            this.lnk_passage.Text = "lnk\r\n";
            this.lMaterials1.Controls.Add(this.tb_currentpos1);
            this.lMaterials1.Controls.Add(this.pb_currentpos1);
            this.lMaterials1.Controls.Add(this.pb_ListenScene1);
            this.lMaterials1.Location = new Point(4, 0x19);
            this.lMaterials1.Name = "lMaterials1";
            this.lMaterials1.Size = new Size(0x304, 0x210);
            this.lMaterials1.TabIndex = 5;
            this.lMaterials1.Text = "lMaterials1";
            this.lMaterials1.UseVisualStyleBackColor = true;
            this.tb_currentpos1.AutoSize = false;
            this.tb_currentpos1.LargeChange = 1;
            this.tb_currentpos1.Location = new Point(0xcc, 12);
            this.tb_currentpos1.Name = "tb_currentpos1";
            this.tb_currentpos1.Size = new Size(400, 20);
            this.tb_currentpos1.TabIndex = 0x26;
            this.tb_currentpos1.TabStop = false;
            this.tb_currentpos1.TickStyle = TickStyle.None;
            this.tb_currentpos1.Visible = false;
            this.tb_currentpos1.Scroll += new EventHandler(this.tb_currentpos1_Scroll);
            this.pb_currentpos1.Location = new Point(0xcc, 0x1b7);
            this.pb_currentpos1.Name = "pb_currentpos1";
            this.pb_currentpos1.Size = new Size(400, 0x17);
            this.pb_currentpos1.Style = ProgressBarStyle.Continuous;
            this.pb_currentpos1.TabIndex = 40;
            this.pb_ListenScene1.Location = new Point(0xcc, 0x21);
            this.pb_ListenScene1.Name = "pb_ListenScene1";
            this.pb_ListenScene1.Size = new Size(400, 400);
            this.pb_ListenScene1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb_ListenScene1.TabIndex = 0x27;
            this.pb_ListenScene1.TabStop = false;
            this.ltab_Question.BackColor = SystemColors.ControlLight;
            this.ltab_Question.Controls.Add(this.tableLayoutPanel1);
            this.ltab_Question.Location = new Point(4, 0x19);
            this.ltab_Question.Name = "ltab_Question";
            this.ltab_Question.Size = new Size(0x304, 0x210);
            this.ltab_Question.TabIndex = 2;
            this.ltab_Question.Text = "lQuestion";
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40f));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lrtb_question, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lrtb_answerE, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lrtb_answerD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lrtb_answerC, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lrtb_answerB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lckb_A, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lckb_B, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lckb_C, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lckb_D, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lckb_E, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lckb_F, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lckb_G, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lckb_H, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lrtb_answerF, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lrtb_answerG, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lrtb_answerH, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lrtb_answerA, 1, 1);
            this.tableLayoutPanel1.Location = new Point(0x57, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.Size = new Size(620, 0x1cf);
            this.tableLayoutPanel1.TabIndex = 2;
            this.lrtb_question.BackColor = SystemColors.ControlLight;
            this.lrtb_question.BorderStyle = BorderStyle.None;
            this.lrtb_question.Location = new Point(0x2b, 3);
            this.lrtb_question.Name = "lrtb_question";
            this.lrtb_question.ReadOnly = true;
            this.lrtb_question.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtb_question.ShortcutsEnabled = false;
            this.lrtb_question.Size = new Size(0x23e, 0x41);
            this.lrtb_question.TabIndex = 3;
            this.lrtb_question.TabStop = false;
            this.lrtb_question.Text = "";
            this.lrtb_answerE.BackColor = SystemColors.ControlLight;
            this.lrtb_answerE.BorderStyle = BorderStyle.None;
            this.lrtb_answerE.Location = new Point(0x2b, 270);
            this.lrtb_answerE.Name = "lrtb_answerE";
            this.lrtb_answerE.ReadOnly = true;
            this.lrtb_answerE.ShortcutsEnabled = false;
            this.lrtb_answerE.Size = new Size(0x23e, 0x2b);
            this.lrtb_answerE.TabIndex = 9;
            this.lrtb_answerE.TabStop = false;
            this.lrtb_answerE.Text = "";
            this.lrtb_answerE.Visible = false;
            this.lrtb_answerD.BackColor = SystemColors.ControlLight;
            this.lrtb_answerD.BorderStyle = BorderStyle.None;
            this.lrtb_answerD.Location = new Point(0x2b, 0xdd);
            this.lrtb_answerD.Name = "lrtb_answerD";
            this.lrtb_answerD.ReadOnly = true;
            this.lrtb_answerD.ShortcutsEnabled = false;
            this.lrtb_answerD.Size = new Size(0x23e, 0x2b);
            this.lrtb_answerD.TabIndex = 8;
            this.lrtb_answerD.TabStop = false;
            this.lrtb_answerD.Text = "";
            this.lrtb_answerD.Visible = false;
            this.lrtb_answerC.BackColor = SystemColors.ControlLight;
            this.lrtb_answerC.BorderStyle = BorderStyle.None;
            this.lrtb_answerC.Location = new Point(0x2b, 0xac);
            this.lrtb_answerC.Name = "lrtb_answerC";
            this.lrtb_answerC.ReadOnly = true;
            this.lrtb_answerC.ShortcutsEnabled = false;
            this.lrtb_answerC.Size = new Size(0x23e, 0x2b);
            this.lrtb_answerC.TabIndex = 7;
            this.lrtb_answerC.TabStop = false;
            this.lrtb_answerC.Text = "";
            this.lrtb_answerC.Visible = false;
            this.lrtb_answerB.BackColor = SystemColors.ControlLight;
            this.lrtb_answerB.BorderStyle = BorderStyle.None;
            this.lrtb_answerB.Location = new Point(0x2b, 0x7b);
            this.lrtb_answerB.Name = "lrtb_answerB";
            this.lrtb_answerB.ReadOnly = true;
            this.lrtb_answerB.ShortcutsEnabled = false;
            this.lrtb_answerB.Size = new Size(0x23e, 0x2b);
            this.lrtb_answerB.TabIndex = 6;
            this.lrtb_answerB.TabStop = false;
            this.lrtb_answerB.Text = "";
            this.lrtb_answerB.Visible = false;
            this.lckb_A.Appearance = Appearance.Button;
            this.lckb_A.AutoSize = true;
            this.lckb_A.FlatAppearance.CheckedBackColor = Color.Gray;
            this.lckb_A.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.lckb_A.FlatStyle = FlatStyle.Flat;
            this.lckb_A.Location = new Point(3, 0x4a);
            this.lckb_A.Name = "lckb_A";
            this.lckb_A.Size = new Size(0x18, 0x17);
            this.lckb_A.TabIndex = 0;
            this.lckb_A.TabStop = false;
            this.lckb_A.Text = "A";
            this.lckb_A.UseVisualStyleBackColor = true;
            this.lckb_A.Visible = false;
            this.lckb_B.Appearance = Appearance.Button;
            this.lckb_B.AutoSize = true;
            this.lckb_B.FlatAppearance.CheckedBackColor = Color.Gray;
            this.lckb_B.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.lckb_B.FlatStyle = FlatStyle.Flat;
            this.lckb_B.Location = new Point(3, 0x7b);
            this.lckb_B.Name = "lckb_B";
            this.lckb_B.Size = new Size(0x18, 0x17);
            this.lckb_B.TabIndex = 1;
            this.lckb_B.TabStop = false;
            this.lckb_B.Text = "B";
            this.lckb_B.UseVisualStyleBackColor = true;
            this.lckb_B.Visible = false;
            this.lckb_C.Appearance = Appearance.Button;
            this.lckb_C.AutoSize = true;
            this.lckb_C.FlatAppearance.CheckedBackColor = Color.Gray;
            this.lckb_C.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.lckb_C.FlatStyle = FlatStyle.Flat;
            this.lckb_C.Location = new Point(3, 0xac);
            this.lckb_C.Name = "lckb_C";
            this.lckb_C.Size = new Size(0x18, 0x17);
            this.lckb_C.TabIndex = 2;
            this.lckb_C.TabStop = false;
            this.lckb_C.Text = "C";
            this.lckb_C.UseVisualStyleBackColor = true;
            this.lckb_C.Visible = false;
            this.lckb_D.Appearance = Appearance.Button;
            this.lckb_D.AutoSize = true;
            this.lckb_D.FlatAppearance.CheckedBackColor = Color.Gray;
            this.lckb_D.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.lckb_D.FlatStyle = FlatStyle.Flat;
            this.lckb_D.Location = new Point(3, 0xdd);
            this.lckb_D.Name = "lckb_D";
            this.lckb_D.Size = new Size(0x19, 0x17);
            this.lckb_D.TabIndex = 3;
            this.lckb_D.TabStop = false;
            this.lckb_D.Text = "D";
            this.lckb_D.UseVisualStyleBackColor = true;
            this.lckb_D.Visible = false;
            this.lckb_E.Appearance = Appearance.Button;
            this.lckb_E.AutoSize = true;
            this.lckb_E.FlatAppearance.CheckedBackColor = Color.Gray;
            this.lckb_E.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.lckb_E.FlatStyle = FlatStyle.Flat;
            this.lckb_E.Location = new Point(3, 270);
            this.lckb_E.Name = "lckb_E";
            this.lckb_E.Size = new Size(0x18, 0x17);
            this.lckb_E.TabIndex = 4;
            this.lckb_E.TabStop = false;
            this.lckb_E.Text = "E";
            this.lckb_E.UseVisualStyleBackColor = true;
            this.lckb_E.Visible = false;
            this.lckb_F.Appearance = Appearance.Button;
            this.lckb_F.AutoSize = true;
            this.lckb_F.FlatAppearance.CheckedBackColor = Color.Gray;
            this.lckb_F.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.lckb_F.FlatStyle = FlatStyle.Flat;
            this.lckb_F.Location = new Point(3, 0x13f);
            this.lckb_F.Name = "lckb_F";
            this.lckb_F.Size = new Size(0x17, 0x17);
            this.lckb_F.TabIndex = 4;
            this.lckb_F.TabStop = false;
            this.lckb_F.Text = "F";
            this.lckb_F.UseVisualStyleBackColor = true;
            this.lckb_F.Visible = false;
            this.lckb_G.Appearance = Appearance.Button;
            this.lckb_G.AutoSize = true;
            this.lckb_G.FlatAppearance.CheckedBackColor = Color.Gray;
            this.lckb_G.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.lckb_G.FlatStyle = FlatStyle.Flat;
            this.lckb_G.Location = new Point(3, 0x170);
            this.lckb_G.Name = "lckb_G";
            this.lckb_G.Size = new Size(0x19, 0x17);
            this.lckb_G.TabIndex = 4;
            this.lckb_G.TabStop = false;
            this.lckb_G.Text = "G";
            this.lckb_G.UseVisualStyleBackColor = true;
            this.lckb_G.Visible = false;
            this.lckb_H.Appearance = Appearance.Button;
            this.lckb_H.AutoSize = true;
            this.lckb_H.FlatAppearance.CheckedBackColor = Color.Gray;
            this.lckb_H.FlatAppearance.MouseOverBackColor = Color.Gray;
            this.lckb_H.FlatStyle = FlatStyle.Flat;
            this.lckb_H.Location = new Point(3, 0x1a1);
            this.lckb_H.Name = "lckb_H";
            this.lckb_H.Size = new Size(0x19, 0x17);
            this.lckb_H.TabIndex = 4;
            this.lckb_H.TabStop = false;
            this.lckb_H.Text = "H";
            this.lckb_H.UseVisualStyleBackColor = true;
            this.lckb_H.Visible = false;
            this.lrtb_answerF.BackColor = SystemColors.ControlLight;
            this.lrtb_answerF.BorderStyle = BorderStyle.None;
            this.lrtb_answerF.Location = new Point(0x2b, 0x13f);
            this.lrtb_answerF.Name = "lrtb_answerF";
            this.lrtb_answerF.ReadOnly = true;
            this.lrtb_answerF.ShortcutsEnabled = false;
            this.lrtb_answerF.Size = new Size(0x23e, 0x2b);
            this.lrtb_answerF.TabIndex = 9;
            this.lrtb_answerF.TabStop = false;
            this.lrtb_answerF.Text = "";
            this.lrtb_answerF.Visible = false;
            this.lrtb_answerG.BackColor = SystemColors.ControlLight;
            this.lrtb_answerG.BorderStyle = BorderStyle.None;
            this.lrtb_answerG.Location = new Point(0x2b, 0x170);
            this.lrtb_answerG.Name = "lrtb_answerG";
            this.lrtb_answerG.ReadOnly = true;
            this.lrtb_answerG.ShortcutsEnabled = false;
            this.lrtb_answerG.Size = new Size(0x23e, 0x2b);
            this.lrtb_answerG.TabIndex = 9;
            this.lrtb_answerG.TabStop = false;
            this.lrtb_answerG.Text = "";
            this.lrtb_answerG.Visible = false;
            this.lrtb_answerH.BackColor = SystemColors.ControlLight;
            this.lrtb_answerH.BorderStyle = BorderStyle.None;
            this.lrtb_answerH.Location = new Point(0x2b, 0x1a1);
            this.lrtb_answerH.Name = "lrtb_answerH";
            this.lrtb_answerH.ReadOnly = true;
            this.lrtb_answerH.ShortcutsEnabled = false;
            this.lrtb_answerH.Size = new Size(0x23e, 0x2b);
            this.lrtb_answerH.TabIndex = 9;
            this.lrtb_answerH.TabStop = false;
            this.lrtb_answerH.Text = "";
            this.lrtb_answerH.Visible = false;
            this.lrtb_answerA.BackColor = SystemColors.ControlLight;
            this.lrtb_answerA.BorderStyle = BorderStyle.None;
            this.lrtb_answerA.Location = new Point(0x2b, 0x4a);
            this.lrtb_answerA.Name = "lrtb_answerA";
            this.lrtb_answerA.ReadOnly = true;
            this.lrtb_answerA.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtb_answerA.ShortcutsEnabled = false;
            this.lrtb_answerA.Size = new Size(0x23e, 0x2b);
            this.lrtb_answerA.TabIndex = 5;
            this.lrtb_answerA.TabStop = false;
            this.lrtb_answerA.Text = "";
            this.lrtb_answerA.Visible = false;
            this.lTableQuestion.Controls.Add(this.lbl_tableAnswer);
            this.lTableQuestion.Controls.Add(this.lrtbTableQuestion);
            this.lTableQuestion.Controls.Add(this.ltlp_table);
            this.lTableQuestion.Location = new Point(4, 0x19);
            this.lTableQuestion.Name = "lTableQuestion";
            this.lTableQuestion.Padding = new Padding(3);
            this.lTableQuestion.Size = new Size(0x304, 0x210);
            this.lTableQuestion.TabIndex = 4;
            this.lTableQuestion.Text = "lTableQuestion";
            this.lTableQuestion.UseVisualStyleBackColor = true;
            this.lbl_tableAnswer.AutoSize = true;
            this.lbl_tableAnswer.Location = new Point(13, 7);
            this.lbl_tableAnswer.Name = "lbl_tableAnswer";
            this.lbl_tableAnswer.Size = new Size(0x23, 13);
            this.lbl_tableAnswer.TabIndex = 5;
            this.lbl_tableAnswer.Text = "label6";
            this.lrtbTableQuestion.BackColor = SystemColors.ControlLight;
            this.lrtbTableQuestion.BorderStyle = BorderStyle.None;
            this.lrtbTableQuestion.Location = new Point(13, 0x18);
            this.lrtbTableQuestion.Name = "lrtbTableQuestion";
            this.lrtbTableQuestion.ReadOnly = true;
            this.lrtbTableQuestion.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableQuestion.ShortcutsEnabled = false;
            this.lrtbTableQuestion.Size = new Size(0x2f1, 0x30);
            this.lrtbTableQuestion.TabIndex = 4;
            this.lrtbTableQuestion.TabStop = false;
            this.lrtbTableQuestion.Text = "";
            this.ltlp_table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.ltlp_table.ColumnCount = 6;
            this.ltlp_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.83333f));
            this.ltlp_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.83333f));
            this.ltlp_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.83333f));
            this.ltlp_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.83333f));
            this.ltlp_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333332f));
            this.ltlp_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333332f));
            this.ltlp_table.Controls.Add(this.lckbTable11, 1, 1);
            this.ltlp_table.Controls.Add(this.lckbTable12, 2, 1);
            this.ltlp_table.Controls.Add(this.lckbTable13, 3, 1);
            this.ltlp_table.Controls.Add(this.lckbTable14, 4, 1);
            this.ltlp_table.Controls.Add(this.lckbTable15, 5, 1);
            this.ltlp_table.Controls.Add(this.lckbTable25, 5, 2);
            this.ltlp_table.Controls.Add(this.lckbTable24, 4, 2);
            this.ltlp_table.Controls.Add(this.lckbTable23, 3, 2);
            this.ltlp_table.Controls.Add(this.lckbTable22, 2, 2);
            this.ltlp_table.Controls.Add(this.lckbTable21, 1, 2);
            this.ltlp_table.Controls.Add(this.lckbTable32, 2, 3);
            this.ltlp_table.Controls.Add(this.lckbTable33, 3, 3);
            this.ltlp_table.Controls.Add(this.lckbTable34, 4, 3);
            this.ltlp_table.Controls.Add(this.lckbTable35, 5, 3);
            this.ltlp_table.Controls.Add(this.lckbTable43, 3, 4);
            this.ltlp_table.Controls.Add(this.lckbTable41, 1, 4);
            this.ltlp_table.Controls.Add(this.lckbTable31, 1, 3);
            this.ltlp_table.Controls.Add(this.lckbTable42, 2, 4);
            this.ltlp_table.Controls.Add(this.lckbTable44, 4, 4);
            this.ltlp_table.Controls.Add(this.lckbTable45, 5, 4);
            this.ltlp_table.Controls.Add(this.lckbTable55, 5, 5);
            this.ltlp_table.Controls.Add(this.lckbTable54, 4, 5);
            this.ltlp_table.Controls.Add(this.lckbTable53, 3, 5);
            this.ltlp_table.Controls.Add(this.lckbTable52, 2, 5);
            this.ltlp_table.Controls.Add(this.lckbTable51, 1, 5);
            this.ltlp_table.Controls.Add(this.lckbTable61, 1, 6);
            this.ltlp_table.Controls.Add(this.lckbTable62, 2, 6);
            this.ltlp_table.Controls.Add(this.lckbTable63, 3, 6);
            this.ltlp_table.Controls.Add(this.lckbTable64, 4, 6);
            this.ltlp_table.Controls.Add(this.lckbTable65, 5, 6);
            this.ltlp_table.Controls.Add(this.lckbTable71, 1, 7);
            this.ltlp_table.Controls.Add(this.lckbTable72, 2, 7);
            this.ltlp_table.Controls.Add(this.lckbTable73, 3, 7);
            this.ltlp_table.Controls.Add(this.lckbTable74, 4, 7);
            this.ltlp_table.Controls.Add(this.lckbTable75, 5, 7);
            this.ltlp_table.Controls.Add(this.lckbTable85, 5, 8);
            this.ltlp_table.Controls.Add(this.lckbTable84, 4, 8);
            this.ltlp_table.Controls.Add(this.lckbTable83, 3, 8);
            this.ltlp_table.Controls.Add(this.lckbTable82, 2, 8);
            this.ltlp_table.Controls.Add(this.lckbTable81, 1, 8);
            this.ltlp_table.Controls.Add(this.lckbTable91, 1, 9);
            this.ltlp_table.Controls.Add(this.lckbTable92, 2, 9);
            this.ltlp_table.Controls.Add(this.lckbTable93, 3, 9);
            this.ltlp_table.Controls.Add(this.lckbTable94, 4, 9);
            this.ltlp_table.Controls.Add(this.lckbTable95, 5, 9);
            this.ltlp_table.Controls.Add(this.lrtbTableCol1, 1, 0);
            this.ltlp_table.Controls.Add(this.lrtbTableCol2, 2, 0);
            this.ltlp_table.Controls.Add(this.lrtbTableCol3, 3, 0);
            this.ltlp_table.Controls.Add(this.lrtbTableCol5, 5, 0);
            this.ltlp_table.Controls.Add(this.lrtbTableRow1, 0, 1);
            this.ltlp_table.Controls.Add(this.lrtbTableRow2, 0, 2);
            this.ltlp_table.Controls.Add(this.lrtbTableRow3, 0, 3);
            this.ltlp_table.Controls.Add(this.lrtbTableRow4, 0, 4);
            this.ltlp_table.Controls.Add(this.lrtbTableRow5, 0, 5);
            this.ltlp_table.Controls.Add(this.lrtbTableRow6, 0, 6);
            this.ltlp_table.Controls.Add(this.lrtbTableRow7, 0, 7);
            this.ltlp_table.Controls.Add(this.lrtbTableRow8, 0, 8);
            this.ltlp_table.Controls.Add(this.lrtbTableRow9, 0, 9);
            this.ltlp_table.Controls.Add(this.lrtbTableCol4, 4, 0);
            this.ltlp_table.Location = new Point(12, 0x4c);
            this.ltlp_table.Name = "ltlp_table";
            this.ltlp_table.RowCount = 10;
            this.ltlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.90476f));
            this.ltlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.90476f));
            this.ltlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.90476f));
            this.ltlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.90476f));
            this.ltlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.90476f));
            this.ltlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 11.90476f));
            this.ltlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857f));
            this.ltlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857f));
            this.ltlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857f));
            this.ltlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857f));
            this.ltlp_table.Size = new Size(0x2f2, 0x18f);
            this.ltlp_table.TabIndex = 0;
            this.lckbTable11.FlatStyle = FlatStyle.Flat;
            this.lckbTable11.Location = new Point(160, 0x33);
            this.lckbTable11.Name = "lckbTable11";
            this.lckbTable11.Size = new Size(0x5e, 30);
            this.lckbTable11.TabIndex = 0;
            this.lckbTable11.TabStop = false;
            this.lckbTable11.UseVisualStyleBackColor = false;
            this.lckbTable11.Visible = false;
            this.lckbTable11.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable12.FlatStyle = FlatStyle.Flat;
            this.lckbTable12.Location = new Point(0x13c, 0x33);
            this.lckbTable12.Name = "lckbTable12";
            this.lckbTable12.Size = new Size(0x5e, 30);
            this.lckbTable12.TabIndex = 0;
            this.lckbTable12.TabStop = false;
            this.lckbTable12.UseVisualStyleBackColor = false;
            this.lckbTable12.Visible = false;
            this.lckbTable12.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable13.FlatStyle = FlatStyle.Flat;
            this.lckbTable13.Location = new Point(0x1d8, 0x33);
            this.lckbTable13.Name = "lckbTable13";
            this.lckbTable13.Size = new Size(0x3e, 0x1b);
            this.lckbTable13.TabIndex = 0;
            this.lckbTable13.TabStop = false;
            this.lckbTable13.UseVisualStyleBackColor = false;
            this.lckbTable13.Visible = false;
            this.lckbTable13.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable14.FlatStyle = FlatStyle.Flat;
            this.lckbTable14.Location = new Point(0x274, 0x33);
            this.lckbTable14.Name = "lckbTable14";
            this.lckbTable14.Size = new Size(0x38, 30);
            this.lckbTable14.TabIndex = 0;
            this.lckbTable14.TabStop = false;
            this.lckbTable14.UseVisualStyleBackColor = false;
            this.lckbTable14.Visible = false;
            this.lckbTable14.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable15.FlatStyle = FlatStyle.Flat;
            this.lckbTable15.Location = new Point(0x2b3, 0x33);
            this.lckbTable15.Name = "lckbTable15";
            this.lckbTable15.Size = new Size(0x3b, 30);
            this.lckbTable15.TabIndex = 0;
            this.lckbTable15.TabStop = false;
            this.lckbTable15.UseVisualStyleBackColor = false;
            this.lckbTable15.Visible = false;
            this.lckbTable15.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable25.FlatStyle = FlatStyle.Flat;
            this.lckbTable25.Location = new Point(0x2b3, 0x62);
            this.lckbTable25.Name = "lckbTable25";
            this.lckbTable25.Size = new Size(0x3b, 30);
            this.lckbTable25.TabIndex = 0;
            this.lckbTable25.TabStop = false;
            this.lckbTable25.UseVisualStyleBackColor = false;
            this.lckbTable25.Visible = false;
            this.lckbTable25.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable24.FlatStyle = FlatStyle.Flat;
            this.lckbTable24.Location = new Point(0x274, 0x62);
            this.lckbTable24.Name = "lckbTable24";
            this.lckbTable24.Size = new Size(0x38, 30);
            this.lckbTable24.TabIndex = 0;
            this.lckbTable24.TabStop = false;
            this.lckbTable24.UseVisualStyleBackColor = false;
            this.lckbTable24.Visible = false;
            this.lckbTable24.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable23.FlatStyle = FlatStyle.Flat;
            this.lckbTable23.Location = new Point(0x1d8, 0x62);
            this.lckbTable23.Name = "lckbTable23";
            this.lckbTable23.Size = new Size(0x5e, 30);
            this.lckbTable23.TabIndex = 0;
            this.lckbTable23.TabStop = false;
            this.lckbTable23.UseVisualStyleBackColor = false;
            this.lckbTable23.Visible = false;
            this.lckbTable23.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable22.FlatStyle = FlatStyle.Flat;
            this.lckbTable22.Location = new Point(0x13c, 0x62);
            this.lckbTable22.Name = "lckbTable22";
            this.lckbTable22.Size = new Size(0x5e, 30);
            this.lckbTable22.TabIndex = 0;
            this.lckbTable22.TabStop = false;
            this.lckbTable22.UseVisualStyleBackColor = false;
            this.lckbTable22.Visible = false;
            this.lckbTable22.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable21.FlatStyle = FlatStyle.Flat;
            this.lckbTable21.Location = new Point(160, 0x62);
            this.lckbTable21.Name = "lckbTable21";
            this.lckbTable21.Size = new Size(0x5e, 30);
            this.lckbTable21.TabIndex = 0;
            this.lckbTable21.TabStop = false;
            this.lckbTable21.UseVisualStyleBackColor = false;
            this.lckbTable21.Visible = false;
            this.lckbTable21.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable32.FlatStyle = FlatStyle.Flat;
            this.lckbTable32.Location = new Point(0x13c, 0x91);
            this.lckbTable32.Name = "lckbTable32";
            this.lckbTable32.Size = new Size(0x5e, 30);
            this.lckbTable32.TabIndex = 0;
            this.lckbTable32.TabStop = false;
            this.lckbTable32.UseVisualStyleBackColor = false;
            this.lckbTable32.Visible = false;
            this.lckbTable32.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable33.FlatStyle = FlatStyle.Flat;
            this.lckbTable33.Location = new Point(0x1d8, 0x91);
            this.lckbTable33.Name = "lckbTable33";
            this.lckbTable33.Size = new Size(0x5e, 30);
            this.lckbTable33.TabIndex = 0;
            this.lckbTable33.TabStop = false;
            this.lckbTable33.UseVisualStyleBackColor = false;
            this.lckbTable33.Visible = false;
            this.lckbTable33.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable34.FlatStyle = FlatStyle.Flat;
            this.lckbTable34.Location = new Point(0x274, 0x91);
            this.lckbTable34.Name = "lckbTable34";
            this.lckbTable34.Size = new Size(0x38, 30);
            this.lckbTable34.TabIndex = 0;
            this.lckbTable34.TabStop = false;
            this.lckbTable34.UseVisualStyleBackColor = false;
            this.lckbTable34.Visible = false;
            this.lckbTable34.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable35.FlatStyle = FlatStyle.Flat;
            this.lckbTable35.Location = new Point(0x2b3, 0x91);
            this.lckbTable35.Name = "lckbTable35";
            this.lckbTable35.Size = new Size(0x3b, 30);
            this.lckbTable35.TabIndex = 0;
            this.lckbTable35.TabStop = false;
            this.lckbTable35.UseVisualStyleBackColor = false;
            this.lckbTable35.Visible = false;
            this.lckbTable35.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable43.FlatStyle = FlatStyle.Flat;
            this.lckbTable43.Location = new Point(0x1d8, 0xc0);
            this.lckbTable43.Name = "lckbTable43";
            this.lckbTable43.Size = new Size(0x5e, 30);
            this.lckbTable43.TabIndex = 0;
            this.lckbTable43.TabStop = false;
            this.lckbTable43.UseVisualStyleBackColor = false;
            this.lckbTable43.Visible = false;
            this.lckbTable43.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable41.FlatStyle = FlatStyle.Flat;
            this.lckbTable41.Location = new Point(160, 0xc0);
            this.lckbTable41.Name = "lckbTable41";
            this.lckbTable41.Size = new Size(0x5e, 30);
            this.lckbTable41.TabIndex = 0;
            this.lckbTable41.TabStop = false;
            this.lckbTable41.UseVisualStyleBackColor = false;
            this.lckbTable41.Visible = false;
            this.lckbTable41.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable31.FlatStyle = FlatStyle.Flat;
            this.lckbTable31.Location = new Point(160, 0x91);
            this.lckbTable31.Name = "lckbTable31";
            this.lckbTable31.Size = new Size(0x5e, 30);
            this.lckbTable31.TabIndex = 0;
            this.lckbTable31.TabStop = false;
            this.lckbTable31.UseVisualStyleBackColor = false;
            this.lckbTable31.Visible = false;
            this.lckbTable31.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable42.FlatStyle = FlatStyle.Flat;
            this.lckbTable42.Location = new Point(0x13c, 0xc0);
            this.lckbTable42.Name = "lckbTable42";
            this.lckbTable42.Size = new Size(0x5e, 30);
            this.lckbTable42.TabIndex = 0;
            this.lckbTable42.TabStop = false;
            this.lckbTable42.UseVisualStyleBackColor = false;
            this.lckbTable42.Visible = false;
            this.lckbTable42.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable44.FlatStyle = FlatStyle.Flat;
            this.lckbTable44.Location = new Point(0x274, 0xc0);
            this.lckbTable44.Name = "lckbTable44";
            this.lckbTable44.Size = new Size(0x38, 30);
            this.lckbTable44.TabIndex = 0;
            this.lckbTable44.TabStop = false;
            this.lckbTable44.UseVisualStyleBackColor = false;
            this.lckbTable44.Visible = false;
            this.lckbTable44.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable45.FlatStyle = FlatStyle.Flat;
            this.lckbTable45.Location = new Point(0x2b3, 0xc0);
            this.lckbTable45.Name = "lckbTable45";
            this.lckbTable45.Size = new Size(0x3b, 30);
            this.lckbTable45.TabIndex = 0;
            this.lckbTable45.TabStop = false;
            this.lckbTable45.UseVisualStyleBackColor = false;
            this.lckbTable45.Visible = false;
            this.lckbTable45.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable55.FlatStyle = FlatStyle.Flat;
            this.lckbTable55.Location = new Point(0x2b3, 0xef);
            this.lckbTable55.Name = "lckbTable55";
            this.lckbTable55.Size = new Size(0x3b, 30);
            this.lckbTable55.TabIndex = 0;
            this.lckbTable55.TabStop = false;
            this.lckbTable55.UseVisualStyleBackColor = false;
            this.lckbTable55.Visible = false;
            this.lckbTable55.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable54.FlatStyle = FlatStyle.Flat;
            this.lckbTable54.Location = new Point(0x274, 0xef);
            this.lckbTable54.Name = "lckbTable54";
            this.lckbTable54.Size = new Size(0x38, 30);
            this.lckbTable54.TabIndex = 0;
            this.lckbTable54.TabStop = false;
            this.lckbTable54.UseVisualStyleBackColor = false;
            this.lckbTable54.Visible = false;
            this.lckbTable54.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable53.FlatStyle = FlatStyle.Flat;
            this.lckbTable53.Location = new Point(0x1d8, 0xef);
            this.lckbTable53.Name = "lckbTable53";
            this.lckbTable53.Size = new Size(0x5e, 30);
            this.lckbTable53.TabIndex = 0;
            this.lckbTable53.TabStop = false;
            this.lckbTable53.UseVisualStyleBackColor = false;
            this.lckbTable53.Visible = false;
            this.lckbTable53.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable52.FlatStyle = FlatStyle.Flat;
            this.lckbTable52.Location = new Point(0x13c, 0xef);
            this.lckbTable52.Name = "lckbTable52";
            this.lckbTable52.Size = new Size(0x5e, 30);
            this.lckbTable52.TabIndex = 0;
            this.lckbTable52.TabStop = false;
            this.lckbTable52.UseVisualStyleBackColor = false;
            this.lckbTable52.Visible = false;
            this.lckbTable52.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable51.FlatStyle = FlatStyle.Flat;
            this.lckbTable51.Location = new Point(160, 0xef);
            this.lckbTable51.Name = "lckbTable51";
            this.lckbTable51.Size = new Size(0x5e, 30);
            this.lckbTable51.TabIndex = 0;
            this.lckbTable51.TabStop = false;
            this.lckbTable51.UseVisualStyleBackColor = false;
            this.lckbTable51.Visible = false;
            this.lckbTable51.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable61.FlatStyle = FlatStyle.Flat;
            this.lckbTable61.Location = new Point(160, 0x11e);
            this.lckbTable61.Name = "lckbTable61";
            this.lckbTable61.Size = new Size(0x5e, 0x15);
            this.lckbTable61.TabIndex = 0;
            this.lckbTable61.TabStop = false;
            this.lckbTable61.UseVisualStyleBackColor = false;
            this.lckbTable61.Visible = false;
            this.lckbTable61.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable62.FlatStyle = FlatStyle.Flat;
            this.lckbTable62.Location = new Point(0x13c, 0x11e);
            this.lckbTable62.Name = "lckbTable62";
            this.lckbTable62.Size = new Size(0x5e, 0x15);
            this.lckbTable62.TabIndex = 0;
            this.lckbTable62.TabStop = false;
            this.lckbTable62.UseVisualStyleBackColor = false;
            this.lckbTable62.Visible = false;
            this.lckbTable62.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable63.FlatStyle = FlatStyle.Flat;
            this.lckbTable63.Location = new Point(0x1d8, 0x11e);
            this.lckbTable63.Name = "lckbTable63";
            this.lckbTable63.Size = new Size(0x5e, 0x15);
            this.lckbTable63.TabIndex = 0;
            this.lckbTable63.TabStop = false;
            this.lckbTable63.UseVisualStyleBackColor = false;
            this.lckbTable63.Visible = false;
            this.lckbTable63.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable64.FlatStyle = FlatStyle.Flat;
            this.lckbTable64.Location = new Point(0x274, 0x11e);
            this.lckbTable64.Name = "lckbTable64";
            this.lckbTable64.Size = new Size(0x38, 0x15);
            this.lckbTable64.TabIndex = 0;
            this.lckbTable64.TabStop = false;
            this.lckbTable64.UseVisualStyleBackColor = false;
            this.lckbTable64.Visible = false;
            this.lckbTable64.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable65.FlatStyle = FlatStyle.Flat;
            this.lckbTable65.Location = new Point(0x2b3, 0x11e);
            this.lckbTable65.Name = "lckbTable65";
            this.lckbTable65.Size = new Size(0x3b, 0x15);
            this.lckbTable65.TabIndex = 0;
            this.lckbTable65.TabStop = false;
            this.lckbTable65.UseVisualStyleBackColor = false;
            this.lckbTable65.Visible = false;
            this.lckbTable65.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable71.FlatStyle = FlatStyle.Flat;
            this.lckbTable71.Location = new Point(160, 0x13a);
            this.lckbTable71.Name = "lckbTable71";
            this.lckbTable71.Size = new Size(0x3e, 0x15);
            this.lckbTable71.TabIndex = 0;
            this.lckbTable71.TabStop = false;
            this.lckbTable71.UseVisualStyleBackColor = false;
            this.lckbTable71.Visible = false;
            this.lckbTable71.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable72.FlatStyle = FlatStyle.Flat;
            this.lckbTable72.Location = new Point(0x13c, 0x13a);
            this.lckbTable72.Name = "lckbTable72";
            this.lckbTable72.Size = new Size(0x3e, 0x15);
            this.lckbTable72.TabIndex = 0;
            this.lckbTable72.TabStop = false;
            this.lckbTable72.UseVisualStyleBackColor = false;
            this.lckbTable72.Visible = false;
            this.lckbTable72.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable73.FlatStyle = FlatStyle.Flat;
            this.lckbTable73.Location = new Point(0x1d8, 0x13a);
            this.lckbTable73.Name = "lckbTable73";
            this.lckbTable73.Size = new Size(0x3e, 0x15);
            this.lckbTable73.TabIndex = 0;
            this.lckbTable73.TabStop = false;
            this.lckbTable73.UseVisualStyleBackColor = false;
            this.lckbTable73.Visible = false;
            this.lckbTable73.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable74.FlatStyle = FlatStyle.Flat;
            this.lckbTable74.Location = new Point(0x274, 0x13a);
            this.lckbTable74.Name = "lckbTable74";
            this.lckbTable74.Size = new Size(0x38, 0x15);
            this.lckbTable74.TabIndex = 0;
            this.lckbTable74.TabStop = false;
            this.lckbTable74.UseVisualStyleBackColor = false;
            this.lckbTable74.Visible = false;
            this.lckbTable74.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable75.FlatStyle = FlatStyle.Flat;
            this.lckbTable75.Location = new Point(0x2b3, 0x13a);
            this.lckbTable75.Name = "lckbTable75";
            this.lckbTable75.Size = new Size(0x3b, 0x15);
            this.lckbTable75.TabIndex = 0;
            this.lckbTable75.TabStop = false;
            this.lckbTable75.UseVisualStyleBackColor = false;
            this.lckbTable75.Visible = false;
            this.lckbTable75.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable85.FlatStyle = FlatStyle.Flat;
            this.lckbTable85.Location = new Point(0x2b3, 0x156);
            this.lckbTable85.Name = "lckbTable85";
            this.lckbTable85.Size = new Size(0x3b, 0x15);
            this.lckbTable85.TabIndex = 0;
            this.lckbTable85.TabStop = false;
            this.lckbTable85.UseVisualStyleBackColor = false;
            this.lckbTable85.Visible = false;
            this.lckbTable85.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable84.FlatStyle = FlatStyle.Flat;
            this.lckbTable84.Location = new Point(0x274, 0x156);
            this.lckbTable84.Name = "lckbTable84";
            this.lckbTable84.Size = new Size(0x38, 0x15);
            this.lckbTable84.TabIndex = 0;
            this.lckbTable84.TabStop = false;
            this.lckbTable84.UseVisualStyleBackColor = false;
            this.lckbTable84.Visible = false;
            this.lckbTable84.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable83.FlatStyle = FlatStyle.Flat;
            this.lckbTable83.Location = new Point(0x1d8, 0x156);
            this.lckbTable83.Name = "lckbTable83";
            this.lckbTable83.Size = new Size(0x3e, 0x15);
            this.lckbTable83.TabIndex = 0;
            this.lckbTable83.TabStop = false;
            this.lckbTable83.UseVisualStyleBackColor = false;
            this.lckbTable83.Visible = false;
            this.lckbTable83.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable82.FlatStyle = FlatStyle.Flat;
            this.lckbTable82.Location = new Point(0x13c, 0x156);
            this.lckbTable82.Name = "lckbTable82";
            this.lckbTable82.Size = new Size(0x3e, 0x15);
            this.lckbTable82.TabIndex = 0;
            this.lckbTable82.TabStop = false;
            this.lckbTable82.UseVisualStyleBackColor = false;
            this.lckbTable82.Visible = false;
            this.lckbTable82.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable81.FlatStyle = FlatStyle.Flat;
            this.lckbTable81.Location = new Point(160, 0x156);
            this.lckbTable81.Name = "lckbTable81";
            this.lckbTable81.Size = new Size(0x3e, 0x15);
            this.lckbTable81.TabIndex = 0;
            this.lckbTable81.TabStop = false;
            this.lckbTable81.UseVisualStyleBackColor = false;
            this.lckbTable81.Visible = false;
            this.lckbTable81.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable91.FlatStyle = FlatStyle.Flat;
            this.lckbTable91.Location = new Point(160, 370);
            this.lckbTable91.Name = "lckbTable91";
            this.lckbTable91.Size = new Size(0x3e, 0x19);
            this.lckbTable91.TabIndex = 0;
            this.lckbTable91.TabStop = false;
            this.lckbTable91.UseVisualStyleBackColor = false;
            this.lckbTable91.Visible = false;
            this.lckbTable91.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable92.FlatStyle = FlatStyle.Flat;
            this.lckbTable92.Location = new Point(0x13c, 370);
            this.lckbTable92.Name = "lckbTable92";
            this.lckbTable92.Size = new Size(0x3e, 0x19);
            this.lckbTable92.TabIndex = 0;
            this.lckbTable92.TabStop = false;
            this.lckbTable92.UseVisualStyleBackColor = false;
            this.lckbTable92.Visible = false;
            this.lckbTable92.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable93.FlatStyle = FlatStyle.Flat;
            this.lckbTable93.Location = new Point(0x1d8, 370);
            this.lckbTable93.Name = "lckbTable93";
            this.lckbTable93.Size = new Size(0x3e, 0x19);
            this.lckbTable93.TabIndex = 0;
            this.lckbTable93.TabStop = false;
            this.lckbTable93.UseVisualStyleBackColor = false;
            this.lckbTable93.Visible = false;
            this.lckbTable93.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable94.FlatStyle = FlatStyle.Flat;
            this.lckbTable94.Location = new Point(0x274, 370);
            this.lckbTable94.Name = "lckbTable94";
            this.lckbTable94.Size = new Size(0x38, 0x19);
            this.lckbTable94.TabIndex = 0;
            this.lckbTable94.TabStop = false;
            this.lckbTable94.UseVisualStyleBackColor = false;
            this.lckbTable94.Visible = false;
            this.lckbTable94.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lckbTable95.FlatStyle = FlatStyle.Flat;
            this.lckbTable95.Location = new Point(0x2b3, 370);
            this.lckbTable95.Name = "lckbTable95";
            this.lckbTable95.Size = new Size(0x3b, 0x19);
            this.lckbTable95.TabIndex = 0;
            this.lckbTable95.TabStop = false;
            this.lckbTable95.UseVisualStyleBackColor = false;
            this.lckbTable95.Visible = false;
            this.lckbTable95.CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            this.lrtbTableCol1.BackColor = SystemColors.ControlLight;
            this.lrtbTableCol1.BorderStyle = BorderStyle.None;
            this.lrtbTableCol1.Location = new Point(160, 4);
            this.lrtbTableCol1.Name = "lrtbTableCol1";
            this.lrtbTableCol1.ReadOnly = true;
            this.lrtbTableCol1.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableCol1.ShortcutsEnabled = false;
            this.lrtbTableCol1.Size = new Size(0x95, 40);
            this.lrtbTableCol1.TabIndex = 1;
            this.lrtbTableCol1.TabStop = false;
            this.lrtbTableCol1.Text = "";
            this.lrtbTableCol1.Visible = false;
            this.lrtbTableCol2.BackColor = SystemColors.ControlLight;
            this.lrtbTableCol2.BorderStyle = BorderStyle.None;
            this.lrtbTableCol2.Location = new Point(0x13c, 4);
            this.lrtbTableCol2.Name = "lrtbTableCol2";
            this.lrtbTableCol2.ReadOnly = true;
            this.lrtbTableCol2.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableCol2.ShortcutsEnabled = false;
            this.lrtbTableCol2.Size = new Size(0x95, 40);
            this.lrtbTableCol2.TabIndex = 1;
            this.lrtbTableCol2.TabStop = false;
            this.lrtbTableCol2.Text = "";
            this.lrtbTableCol2.Visible = false;
            this.lrtbTableCol3.BackColor = SystemColors.ControlLight;
            this.lrtbTableCol3.BorderStyle = BorderStyle.None;
            this.lrtbTableCol3.Location = new Point(0x1d8, 4);
            this.lrtbTableCol3.Name = "lrtbTableCol3";
            this.lrtbTableCol3.ReadOnly = true;
            this.lrtbTableCol3.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableCol3.ShortcutsEnabled = false;
            this.lrtbTableCol3.Size = new Size(0x95, 40);
            this.lrtbTableCol3.TabIndex = 1;
            this.lrtbTableCol3.TabStop = false;
            this.lrtbTableCol3.Text = "";
            this.lrtbTableCol3.Visible = false;
            this.lrtbTableCol5.BackColor = SystemColors.ControlLight;
            this.lrtbTableCol5.BorderStyle = BorderStyle.None;
            this.lrtbTableCol5.Font = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.lrtbTableCol5.Location = new Point(0x2b3, 4);
            this.lrtbTableCol5.Name = "lrtbTableCol5";
            this.lrtbTableCol5.ReadOnly = true;
            this.lrtbTableCol5.ShortcutsEnabled = false;
            this.lrtbTableCol5.Size = new Size(0x24, 30);
            this.lrtbTableCol5.TabIndex = 1;
            this.lrtbTableCol5.TabStop = false;
            this.lrtbTableCol5.Text = "";
            this.lrtbTableCol5.Visible = false;
            this.lrtbTableRow1.BackColor = SystemColors.ControlLight;
            this.lrtbTableRow1.BorderStyle = BorderStyle.None;
            this.lrtbTableRow1.Location = new Point(4, 0x33);
            this.lrtbTableRow1.Name = "lrtbTableRow1";
            this.lrtbTableRow1.ReadOnly = true;
            this.lrtbTableRow1.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableRow1.ShortcutsEnabled = false;
            this.lrtbTableRow1.Size = new Size(0x95, 40);
            this.lrtbTableRow1.TabIndex = 1;
            this.lrtbTableRow1.TabStop = false;
            this.lrtbTableRow1.Text = "";
            this.lrtbTableRow1.Visible = false;
            this.lrtbTableRow2.BackColor = SystemColors.ControlLight;
            this.lrtbTableRow2.BorderStyle = BorderStyle.None;
            this.lrtbTableRow2.Location = new Point(4, 0x62);
            this.lrtbTableRow2.Name = "lrtbTableRow2";
            this.lrtbTableRow2.ReadOnly = true;
            this.lrtbTableRow2.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableRow2.ShortcutsEnabled = false;
            this.lrtbTableRow2.Size = new Size(0x95, 40);
            this.lrtbTableRow2.TabIndex = 1;
            this.lrtbTableRow2.TabStop = false;
            this.lrtbTableRow2.Text = "";
            this.lrtbTableRow2.Visible = false;
            this.lrtbTableRow3.BackColor = SystemColors.ControlLight;
            this.lrtbTableRow3.BorderStyle = BorderStyle.None;
            this.lrtbTableRow3.Location = new Point(4, 0x91);
            this.lrtbTableRow3.Name = "lrtbTableRow3";
            this.lrtbTableRow3.ReadOnly = true;
            this.lrtbTableRow3.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableRow3.ShortcutsEnabled = false;
            this.lrtbTableRow3.Size = new Size(0x95, 40);
            this.lrtbTableRow3.TabIndex = 1;
            this.lrtbTableRow3.TabStop = false;
            this.lrtbTableRow3.Text = "";
            this.lrtbTableRow3.Visible = false;
            this.lrtbTableRow4.BackColor = SystemColors.ControlLight;
            this.lrtbTableRow4.BorderStyle = BorderStyle.None;
            this.lrtbTableRow4.Location = new Point(4, 0xc0);
            this.lrtbTableRow4.Name = "lrtbTableRow4";
            this.lrtbTableRow4.ReadOnly = true;
            this.lrtbTableRow4.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableRow4.ShortcutsEnabled = false;
            this.lrtbTableRow4.Size = new Size(0x95, 40);
            this.lrtbTableRow4.TabIndex = 1;
            this.lrtbTableRow4.TabStop = false;
            this.lrtbTableRow4.Text = "";
            this.lrtbTableRow4.Visible = false;
            this.lrtbTableRow5.BackColor = SystemColors.ControlLight;
            this.lrtbTableRow5.BorderStyle = BorderStyle.None;
            this.lrtbTableRow5.Location = new Point(4, 0xef);
            this.lrtbTableRow5.Name = "lrtbTableRow5";
            this.lrtbTableRow5.ReadOnly = true;
            this.lrtbTableRow5.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableRow5.ShortcutsEnabled = false;
            this.lrtbTableRow5.Size = new Size(0x95, 40);
            this.lrtbTableRow5.TabIndex = 1;
            this.lrtbTableRow5.TabStop = false;
            this.lrtbTableRow5.Text = "";
            this.lrtbTableRow5.Visible = false;
            this.lrtbTableRow6.BackColor = SystemColors.ControlLight;
            this.lrtbTableRow6.BorderStyle = BorderStyle.None;
            this.lrtbTableRow6.Font = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.lrtbTableRow6.Location = new Point(4, 0x11e);
            this.lrtbTableRow6.Name = "lrtbTableRow6";
            this.lrtbTableRow6.ReadOnly = true;
            this.lrtbTableRow6.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableRow6.ShortcutsEnabled = false;
            this.lrtbTableRow6.Size = new Size(0x95, 0x15);
            this.lrtbTableRow6.TabIndex = 1;
            this.lrtbTableRow6.TabStop = false;
            this.lrtbTableRow6.Text = "";
            this.lrtbTableRow6.Visible = false;
            this.lrtbTableRow7.BackColor = SystemColors.ControlLight;
            this.lrtbTableRow7.BorderStyle = BorderStyle.None;
            this.lrtbTableRow7.Font = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.lrtbTableRow7.Location = new Point(4, 0x13a);
            this.lrtbTableRow7.Name = "lrtbTableRow7";
            this.lrtbTableRow7.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableRow7.ShortcutsEnabled = false;
            this.lrtbTableRow7.Size = new Size(0x95, 0x15);
            this.lrtbTableRow7.TabIndex = 1;
            this.lrtbTableRow7.TabStop = false;
            this.lrtbTableRow7.Text = "";
            this.lrtbTableRow7.Visible = false;
            this.lrtbTableRow7.TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
            this.lrtbTableRow8.BackColor = SystemColors.ControlLight;
            this.lrtbTableRow8.BorderStyle = BorderStyle.None;
            this.lrtbTableRow8.Font = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.lrtbTableRow8.Location = new Point(4, 0x156);
            this.lrtbTableRow8.Name = "lrtbTableRow8";
            this.lrtbTableRow8.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableRow8.ShortcutsEnabled = false;
            this.lrtbTableRow8.Size = new Size(0x95, 0x15);
            this.lrtbTableRow8.TabIndex = 1;
            this.lrtbTableRow8.TabStop = false;
            this.lrtbTableRow8.Text = "";
            this.lrtbTableRow8.Visible = false;
            this.lrtbTableRow8.TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
            this.lrtbTableRow9.BackColor = SystemColors.ControlLight;
            this.lrtbTableRow9.BorderStyle = BorderStyle.None;
            this.lrtbTableRow9.Font = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.lrtbTableRow9.Location = new Point(4, 370);
            this.lrtbTableRow9.Name = "lrtbTableRow9";
            this.lrtbTableRow9.ShortcutsEnabled = false;
            this.lrtbTableRow9.Size = new Size(0x95, 0x19);
            this.lrtbTableRow9.TabIndex = 1;
            this.lrtbTableRow9.TabStop = false;
            this.lrtbTableRow9.Text = "";
            this.lrtbTableRow9.Visible = false;
            this.lrtbTableRow9.TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
            this.lrtbTableCol4.BackColor = SystemColors.ControlLight;
            this.lrtbTableCol4.BorderStyle = BorderStyle.None;
            this.lrtbTableCol4.Font = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.lrtbTableCol4.Location = new Point(0x274, 4);
            this.lrtbTableCol4.Name = "lrtbTableCol4";
            this.lrtbTableCol4.ReadOnly = true;
            this.lrtbTableCol4.ScrollBars = RichTextBoxScrollBars.None;
            this.lrtbTableCol4.ShortcutsEnabled = false;
            this.lrtbTableCol4.Size = new Size(0x38, 40);
            this.lrtbTableCol4.TabIndex = 1;
            this.lrtbTableCol4.TabStop = false;
            this.lrtbTableCol4.Text = "";
            this.lrtbTableCol4.Visible = false;
            this.tab_Speaking.Controls.Add(this.tabf_speaking);
            this.tab_Speaking.Location = new Point(4, 0x16);
            this.tab_Speaking.Name = "tab_Speaking";
            this.tab_Speaking.Size = new Size(780, 0x20f);
            this.tab_Speaking.TabIndex = 2;
            this.tab_Speaking.Text = "Speaking";
            this.tab_Speaking.UseVisualStyleBackColor = true;
            this.tabf_speaking.Appearance = TabAppearance.Buttons;
            this.tabf_speaking.Controls.Add(this.sDirection);
            this.tabf_speaking.Controls.Add(this.sNormalQuestions);
            this.tabf_speaking.Location = new Point(5, -25);
            this.tabf_speaking.Name = "tabf_speaking";
            this.tabf_speaking.SelectedIndex = 0;
            this.tabf_speaking.Size = new Size(0x303, 0x205);
            this.tabf_speaking.TabIndex = 1;
            this.tabf_speaking.TabStop = false;
            this.sDirection.Controls.Add(this.pictureBox3);
            this.sDirection.Location = new Point(4, 0x19);
            this.sDirection.Name = "sDirection";
            this.sDirection.Size = new Size(0x2fb, 0x1e8);
            this.sDirection.TabIndex = 3;
            this.sDirection.Text = "sDirection";
            this.sDirection.UseVisualStyleBackColor = true;
            this.pictureBox3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.pictureBox3.Image = (Image) manager.GetObject("pictureBox3.Image");
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new Point(3, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(0x388, 0x20b);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0x11;
            this.pictureBox3.TabStop = false;
            this.sNormalQuestions.Controls.Add(this.spb);
            this.sNormalQuestions.Controls.Add(this.tableLayoutPanel3);
            this.sNormalQuestions.Controls.Add(this.srtb_introduction);
            this.sNormalQuestions.Controls.Add(this.pb_speakingScene);
            this.sNormalQuestions.Location = new Point(4, 0x19);
            this.sNormalQuestions.Name = "sNormalQuestions";
            this.sNormalQuestions.Padding = new Padding(3);
            this.sNormalQuestions.Size = new Size(0x2fb, 0x1e8);
            this.sNormalQuestions.TabIndex = 0;
            this.sNormalQuestions.Text = "sNormalQuestions";
            this.sNormalQuestions.UseVisualStyleBackColor = true;
            this.spb.Location = new Point(190, 0x192);
            this.spb.Name = "spb";
            this.spb.Size = new Size(350, 0x17);
            this.spb.TabIndex = 0x29;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.srtb_timer, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.srtb_timeindicator, 0, 0);
            this.tableLayoutPanel3.Location = new Point(0x10b, 0xf7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel3.Size = new Size(200, 0x4e);
            this.tableLayoutPanel3.TabIndex = 4;
            this.srtb_timer.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.srtb_timer.Location = new Point(3, 0x27);
            this.srtb_timer.Name = "srtb_timer";
            this.srtb_timer.Size = new Size(0xc2, 0x27);
            this.srtb_timer.TabIndex = 1;
            this.srtb_timer.Text = "label1";
            this.srtb_timer.TextAlign = ContentAlignment.MiddleCenter;
            this.srtb_timeindicator.BackColor = SystemColors.ActiveCaptionText;
            this.srtb_timeindicator.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.srtb_timeindicator.ForeColor = SystemColors.ButtonHighlight;
            this.srtb_timeindicator.Location = new Point(3, 0);
            this.srtb_timeindicator.Name = "srtb_timeindicator";
            this.srtb_timeindicator.Size = new Size(0xc2, 0x27);
            this.srtb_timeindicator.TabIndex = 1;
            this.srtb_timeindicator.Text = "PREPARATION TIME";
            this.srtb_timeindicator.TextAlign = ContentAlignment.MiddleCenter;
            this.srtb_introduction.BorderStyle = BorderStyle.None;
            this.srtb_introduction.Location = new Point(0x81, 0x4b);
            this.srtb_introduction.Name = "srtb_introduction";
            this.srtb_introduction.ReadOnly = true;
            this.srtb_introduction.ShortcutsEnabled = false;
            this.srtb_introduction.Size = new Size(0x1cd, 0x61);
            this.srtb_introduction.TabIndex = 3;
            this.srtb_introduction.TabStop = false;
            this.srtb_introduction.Text = "Introduction";
            this.srtb_introduction.Visible = false;
            this.srtb_introduction.TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
            this.pb_speakingScene.BackgroundImageLayout = ImageLayout.None;
            this.pb_speakingScene.Image = (Image) manager.GetObject("pb_speakingScene.Image");
            this.pb_speakingScene.Location = new Point(190, 20);
            this.pb_speakingScene.Name = "pb_speakingScene";
            this.pb_speakingScene.Size = new Size(350, 350);
            this.pb_speakingScene.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb_speakingScene.TabIndex = 0;
            this.pb_speakingScene.TabStop = false;
            this.tab_Writing.Controls.Add(this.tabf_writing);
            this.tab_Writing.Location = new Point(4, 0x16);
            this.tab_Writing.Name = "tab_Writing";
            this.tab_Writing.Size = new Size(780, 0x20f);
            this.tab_Writing.TabIndex = 3;
            this.tab_Writing.Text = "Writing";
            this.tab_Writing.UseVisualStyleBackColor = true;
            this.tabf_writing.Appearance = TabAppearance.Buttons;
            this.tabf_writing.Controls.Add(this.wDirection);
            this.tabf_writing.Controls.Add(this.wReading);
            this.tabf_writing.Controls.Add(this.wSpeakingPassage);
            this.tabf_writing.Controls.Add(this.wWriting2);
            this.tabf_writing.Location = new Point(5, -27);
            this.tabf_writing.Name = "tabf_writing";
            this.tabf_writing.SelectedIndex = 0;
            this.tabf_writing.Size = new Size(0x303, 0x205);
            this.tabf_writing.TabIndex = 2;
            this.tabf_writing.TabStop = false;
            this.tabf_writing.DrawItem += new DrawItemEventHandler(this.tabControl_DrawItem);
            this.wDirection.Controls.Add(this.pictureBox4);
            this.wDirection.Location = new Point(4, 0x19);
            this.wDirection.Name = "wDirection";
            this.wDirection.Size = new Size(0x2fb, 0x1e8);
            this.wDirection.TabIndex = 3;
            this.wDirection.Text = "wDirection";
            this.wDirection.UseVisualStyleBackColor = true;
            this.pictureBox4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = (Image) manager.GetObject("pictureBox4.Image");
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(0x439, 490);
            this.pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 0x11;
            this.pictureBox4.TabStop = false;
            this.wReading.Controls.Add(this.wrtb_writing1);
            this.wReading.Controls.Add(this.wrtb_reading);
            this.wReading.Location = new Point(4, 0x19);
            this.wReading.Name = "wReading";
            this.wReading.Size = new Size(0x2fb, 0x1e8);
            this.wReading.TabIndex = 5;
            this.wReading.Text = "wReading";
            this.wReading.UseVisualStyleBackColor = true;
            this.wrtb_writing1.BackColor = SystemColors.ControlLightLight;
            this.wrtb_writing1.Font = new Font("Times New Roman", 13f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.wrtb_writing1.Location = new Point(0x183, 3);
            this.wrtb_writing1.Name = "wrtb_writing1";
            this.wrtb_writing1.ShortcutsEnabled = false;
            this.wrtb_writing1.Size = new Size(0x175, 480);
            this.wrtb_writing1.TabIndex = 4;
            this.wrtb_writing1.TabStop = false;
            this.wrtb_writing1.Text = "Introduction";
            this.wrtb_reading.BackColor = SystemColors.Control;
            this.wrtb_reading.Font = new Font("Times New Roman", 13f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.wrtb_reading.Location = new Point(3, 3);
            this.wrtb_reading.Name = "wrtb_reading";
            this.wrtb_reading.ReadOnly = true;
            this.wrtb_reading.ShortcutsEnabled = false;
            this.wrtb_reading.Size = new Size(0x180, 480);
            this.wrtb_reading.TabIndex = 4;
            this.wrtb_reading.TabStop = false;
            this.wrtb_reading.Text = "Introduction";
            this.wSpeakingPassage.Controls.Add(this.wpb_speak);
            this.wSpeakingPassage.Controls.Add(this.wtb_speak);
            this.wSpeakingPassage.Controls.Add(this.pb_writingScene);
            this.wSpeakingPassage.Location = new Point(4, 0x19);
            this.wSpeakingPassage.Name = "wSpeakingPassage";
            this.wSpeakingPassage.Padding = new Padding(3);
            this.wSpeakingPassage.Size = new Size(0x2fb, 0x1e8);
            this.wSpeakingPassage.TabIndex = 0;
            this.wSpeakingPassage.Text = "wSpeakingPassage";
            this.wSpeakingPassage.UseVisualStyleBackColor = true;
            this.wpb_speak.Location = new Point(0xce, 420);
            this.wpb_speak.Name = "wpb_speak";
            this.wpb_speak.Size = new Size(350, 0x17);
            this.wpb_speak.TabIndex = 40;
            this.wtb_speak.AutoSize = false;
            this.wtb_speak.LargeChange = 1;
            this.wtb_speak.Location = new Point(0xce, 0x13);
            this.wtb_speak.Name = "wtb_speak";
            this.wtb_speak.Size = new Size(350, 0x19);
            this.wtb_speak.TabIndex = 0x27;
            this.wtb_speak.TabStop = false;
            this.wtb_speak.TickStyle = TickStyle.None;
            this.wtb_speak.Scroll += new EventHandler(this.wtb_speak_Scroll);
            this.pb_writingScene.BackgroundImageLayout = ImageLayout.None;
            this.pb_writingScene.Image = (Image) manager.GetObject("pb_writingScene.Image");
            this.pb_writingScene.Location = new Point(0xce, 50);
            this.pb_writingScene.Name = "pb_writingScene";
            this.pb_writingScene.Size = new Size(350, 350);
            this.pb_writingScene.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb_writingScene.TabIndex = 1;
            this.pb_writingScene.TabStop = false;
            this.wWriting2.Controls.Add(this.lbl_writeDirection);
            this.wWriting2.Controls.Add(this.wrtb_writing2);
            this.wWriting2.Controls.Add(this.wrtbQuestion2);
            this.wWriting2.Controls.Add(this.wpanel);
            this.wWriting2.Location = new Point(4, 0x19);
            this.wWriting2.Name = "wWriting2";
            this.wWriting2.Size = new Size(0x2fb, 0x1e8);
            this.wWriting2.TabIndex = 4;
            this.wWriting2.Text = "wWriting2";
            this.wWriting2.UseVisualStyleBackColor = true;
            this.lbl_writeDirection.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbl_writeDirection.Location = new Point(3, 0x17);
            this.lbl_writeDirection.Name = "lbl_writeDirection";
            this.lbl_writeDirection.Size = new Size(760, 0x31);
            this.lbl_writeDirection.TabIndex = 8;
            this.lbl_writeDirection.Text = manager.GetString("lbl_writeDirection.Text");
            this.wrtb_writing2.BackColor = SystemColors.ControlLightLight;
            this.wrtb_writing2.Font = new Font("Times New Roman", 13f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.wrtb_writing2.Location = new Point(0x15f, 0x73);
            this.wrtb_writing2.Name = "wrtb_writing2";
            this.wrtb_writing2.ShortcutsEnabled = false;
            this.wrtb_writing2.Size = new Size(0x1a1, 0x175);
            this.wrtb_writing2.TabIndex = 6;
            this.wrtb_writing2.TabStop = false;
            this.wrtb_writing2.Text = "";
            this.wrtb_writing2.TextChanged += new EventHandler(this.wrtb_writing2_TextChanged);
            this.wrtbQuestion2.BackColor = SystemColors.Control;
            this.wrtbQuestion2.Font = new Font("Times New Roman", 13f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.wrtbQuestion2.Location = new Point(3, 0x4b);
            this.wrtbQuestion2.Name = "wrtbQuestion2";
            this.wrtbQuestion2.ReadOnly = true;
            this.wrtbQuestion2.ShortcutsEnabled = false;
            this.wrtbQuestion2.Size = new Size(0x15b, 0x19c);
            this.wrtbQuestion2.TabIndex = 5;
            this.wrtbQuestion2.TabStop = false;
            this.wrtbQuestion2.Text = "Introduction";
            this.wpanel.BackColor = Color.LightGray;
            this.wpanel.Controls.Add(this.wlbl_wordcount);
            this.wpanel.Controls.Add(this.wbtn_wordcount);
            this.wpanel.Controls.Add(this.wbtn_redo);
            this.wpanel.Controls.Add(this.wbtn_undo);
            this.wpanel.Controls.Add(this.wbtn_paste);
            this.wpanel.Controls.Add(this.wbtn_cut);
            this.wpanel.Location = new Point(350, 0x4b);
            this.wpanel.Name = "wpanel";
            this.wpanel.Size = new Size(0x1a9, 0x29);
            this.wpanel.TabIndex = 7;
            this.wlbl_wordcount.AutoSize = true;
            this.wlbl_wordcount.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.wlbl_wordcount.Location = new Point(0x173, 8);
            this.wlbl_wordcount.Name = "wlbl_wordcount";
            this.wlbl_wordcount.Size = new Size(0x13, 20);
            this.wlbl_wordcount.TabIndex = 1;
            this.wlbl_wordcount.Text = "0";
            this.wbtn_wordcount.Location = new Point(0xf6, 5);
            this.wbtn_wordcount.Name = "wbtn_wordcount";
            this.wbtn_wordcount.Size = new Size(0x77, 0x1d);
            this.wbtn_wordcount.TabIndex = 0;
            this.wbtn_wordcount.TabStop = false;
            this.wbtn_wordcount.Text = "Hide Word Count";
            this.wbtn_wordcount.UseVisualStyleBackColor = true;
            this.wbtn_wordcount.Click += new EventHandler(this.wbtn_wordcount_Click);
            this.wbtn_redo.Location = new Point(0xae, 5);
            this.wbtn_redo.Name = "wbtn_redo";
            this.wbtn_redo.Size = new Size(0x2d, 0x1d);
            this.wbtn_redo.TabIndex = 0;
            this.wbtn_redo.TabStop = false;
            this.wbtn_redo.Text = "Redo";
            this.wbtn_redo.UseVisualStyleBackColor = true;
            this.wbtn_redo.Click += new EventHandler(this.wbtn_redo_Click);
            this.wbtn_undo.Location = new Point(0x73, 5);
            this.wbtn_undo.Name = "wbtn_undo";
            this.wbtn_undo.Size = new Size(0x2d, 0x1d);
            this.wbtn_undo.TabIndex = 0;
            this.wbtn_undo.TabStop = false;
            this.wbtn_undo.Text = "Undo";
            this.wbtn_undo.UseVisualStyleBackColor = true;
            this.wbtn_undo.Click += new EventHandler(this.wbtn_undo_Click);
            this.wbtn_paste.Location = new Point(0x3b, 5);
            this.wbtn_paste.Name = "wbtn_paste";
            this.wbtn_paste.Size = new Size(0x2d, 0x1d);
            this.wbtn_paste.TabIndex = 0;
            this.wbtn_paste.TabStop = false;
            this.wbtn_paste.Text = "Paste";
            this.wbtn_paste.UseVisualStyleBackColor = true;
            this.wbtn_paste.Click += new EventHandler(this.wbtn_paste_Click);
            this.wbtn_cut.Location = new Point(6, 5);
            this.wbtn_cut.Name = "wbtn_cut";
            this.wbtn_cut.Size = new Size(0x2d, 0x1d);
            this.wbtn_cut.TabIndex = 0;
            this.wbtn_cut.TabStop = false;
            this.wbtn_cut.Text = "Cut";
            this.wbtn_cut.UseVisualStyleBackColor = true;
            this.wbtn_cut.Click += new EventHandler(this.wbtn_cut_Click);
            this.tabPage1.Controls.Add(this.tabf_answer);
            this.tabPage1.Location = new Point(4, 0x16);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new Size(780, 0x20f);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "tab_anwers";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabf_answer.Controls.Add(this.tab_readinganswer);
            this.tabf_answer.Controls.Add(this.tab_listeninganswers);
            this.tabf_answer.Controls.Add(this.tab_speakinganswers);
            this.tabf_answer.Controls.Add(this.tab_writinganswers);
            this.tabf_answer.Location = new Point(3, 0);
            this.tabf_answer.Name = "tabf_answer";
            this.tabf_answer.SelectedIndex = 0;
            this.tabf_answer.Size = new Size(0x309, 0x228);
            this.tabf_answer.TabIndex = 0;
            this.tab_readinganswer.Controls.Add(this.label2);
            this.tab_readinganswer.Controls.Add(this.lbl_readingscorereport);
            this.tab_readinganswer.Controls.Add(this.label3);
            this.tab_readinganswer.Controls.Add(this.pictureBox6);
            this.tab_readinganswer.Controls.Add(this.label4);
            this.tab_readinganswer.Controls.Add(this.pictureBox7);
            this.tab_readinganswer.Controls.Add(this.label5);
            this.tab_readinganswer.Controls.Add(this.pictureBox8);
            this.tab_readinganswer.Controls.Add(this.dgv_readinganswers);
            this.tab_readinganswer.Location = new Point(4, 0x16);
            this.tab_readinganswer.Name = "tab_readinganswer";
            this.tab_readinganswer.Padding = new Padding(3);
            this.tab_readinganswer.Size = new Size(0x301, 0x20e);
            this.tab_readinganswer.TabIndex = 0;
            this.tab_readinganswer.Text = "Reading";
            this.tab_readinganswer.UseVisualStyleBackColor = true;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(0x1a, 0x1c7);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x2c5, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Note: Because the real IBT scoring policy will take all the students' performance into account, the standard score gained here can't be very accurate!";
            this.lbl_readingscorereport.AutoSize = true;
            this.lbl_readingscorereport.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.lbl_readingscorereport.Location = new Point(0x3d, 14);
            this.lbl_readingscorereport.Name = "lbl_readingscorereport";
            this.lbl_readingscorereport.Size = new Size(0x61, 0x11);
            this.lbl_readingscorereport.TabIndex = 13;
            this.lbl_readingscorereport.Text = "scoreReport";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(0x14c, 50);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wrong Answered";
            this.pictureBox6.BackColor = Color.Yellow;
            this.pictureBox6.Location = new Point(0x12b, 0x29);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new Size(0x1b, 0x16);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(0xd7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Right Answered";
            this.pictureBox7.BackColor = Color.Green;
            this.pictureBox7.Location = new Point(0xb6, 0x29);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new Size(0x1b, 0x16);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(0x61, 50);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x4a, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Not Answered";
            this.pictureBox8.BackColor = Color.Red;
            this.pictureBox8.Location = new Point(0x40, 0x29);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new Size(0x1b, 0x16);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            this.dgv_readinganswers.AllowUserToAddRows = false;
            this.dgv_readinganswers.AllowUserToDeleteRows = false;
            this.dgv_readinganswers.AllowUserToResizeColumns = false;
            this.dgv_readinganswers.AllowUserToResizeRows = false;
            this.dgv_readinganswers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_readinganswers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_readinganswers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_readinganswers.Location = new Point(0x40, 0x45);
            this.dgv_readinganswers.MultiSelect = false;
            this.dgv_readinganswers.Name = "dgv_readinganswers";
            this.dgv_readinganswers.ReadOnly = true;
            this.dgv_readinganswers.RowHeadersVisible = false;
            this.dgv_readinganswers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_readinganswers.RowTemplate.Height = 0x17;
            this.dgv_readinganswers.RowTemplate.ReadOnly = true;
            this.dgv_readinganswers.RowTemplate.Resizable = DataGridViewTriState.False;
            this.dgv_readinganswers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_readinganswers.Size = new Size(0x284, 0x171);
            this.dgv_readinganswers.TabIndex = 6;
            this.dgv_readinganswers.TabStop = false;
            this.dgv_readinganswers.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dgv_readinganswers_DataBindingComplete);
            this.tab_listeninganswers.Controls.Add(this.label16);
            this.tab_listeninganswers.Controls.Add(this.dgv_listeninganswers);
            this.tab_listeninganswers.Controls.Add(this.lbl_listeningScorereport);
            this.tab_listeninganswers.Controls.Add(this.label7);
            this.tab_listeninganswers.Controls.Add(this.pictureBox9);
            this.tab_listeninganswers.Controls.Add(this.label8);
            this.tab_listeninganswers.Controls.Add(this.pictureBox10);
            this.tab_listeninganswers.Controls.Add(this.label9);
            this.tab_listeninganswers.Controls.Add(this.pictureBox11);
            this.tab_listeninganswers.Location = new Point(4, 0x16);
            this.tab_listeninganswers.Name = "tab_listeninganswers";
            this.tab_listeninganswers.Padding = new Padding(3);
            this.tab_listeninganswers.Size = new Size(0x301, 0x20e);
            this.tab_listeninganswers.TabIndex = 1;
            this.tab_listeninganswers.Text = "Listening";
            this.tab_listeninganswers.UseVisualStyleBackColor = true;
            this.label16.AutoSize = true;
            this.label16.Location = new Point(0x1a, 0x1c9);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x2c5, 13);
            this.label16.TabIndex = 0x17;
            this.label16.Text = "Note: Because the real IBT scoring policy will take all the students' performance into account, the standard score gained here can't be very accurate!";
            this.dgv_listeninganswers.AllowUserToAddRows = false;
            this.dgv_listeninganswers.AllowUserToDeleteRows = false;
            this.dgv_listeninganswers.AllowUserToResizeColumns = false;
            this.dgv_listeninganswers.AllowUserToResizeRows = false;
            this.dgv_listeninganswers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_listeninganswers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_listeninganswers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_listeninganswers.Location = new Point(0x3e, 0x43);
            this.dgv_listeninganswers.MultiSelect = false;
            this.dgv_listeninganswers.Name = "dgv_listeninganswers";
            this.dgv_listeninganswers.ReadOnly = true;
            this.dgv_listeninganswers.RowHeadersVisible = false;
            this.dgv_listeninganswers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_listeninganswers.RowTemplate.Height = 0x17;
            this.dgv_listeninganswers.RowTemplate.ReadOnly = true;
            this.dgv_listeninganswers.RowTemplate.Resizable = DataGridViewTriState.False;
            this.dgv_listeninganswers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listeninganswers.Size = new Size(0x284, 0x171);
            this.dgv_listeninganswers.TabIndex = 0x16;
            this.dgv_listeninganswers.TabStop = false;
            this.dgv_listeninganswers.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dgv_readinganswers_DataBindingComplete);
            this.lbl_listeningScorereport.AutoSize = true;
            this.lbl_listeningScorereport.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.lbl_listeningScorereport.Location = new Point(0x3d, 10);
            this.lbl_listeningScorereport.Name = "lbl_listeningScorereport";
            this.lbl_listeningScorereport.Size = new Size(0x61, 0x11);
            this.lbl_listeningScorereport.TabIndex = 0x15;
            this.lbl_listeningScorereport.Text = "scoreReport";
            this.label7.AutoSize = true;
            this.label7.Location = new Point(0x14c, 0x2e);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x59, 13);
            this.label7.TabIndex = 0x13;
            this.label7.Text = "Wrong Answered";
            this.pictureBox9.BackColor = Color.Yellow;
            this.pictureBox9.Location = new Point(0x12b, 0x25);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new Size(0x1b, 0x16);
            this.pictureBox9.TabIndex = 0x10;
            this.pictureBox9.TabStop = false;
            this.label8.AutoSize = true;
            this.label8.Location = new Point(0xd7, 0x2e);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x52, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Right Answered";
            this.pictureBox10.BackColor = Color.Green;
            this.pictureBox10.Location = new Point(0xb6, 0x25);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new Size(0x1b, 0x16);
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            this.label9.AutoSize = true;
            this.label9.Location = new Point(0x61, 0x2e);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x4a, 13);
            this.label9.TabIndex = 0x12;
            this.label9.Text = "Not Answered";
            this.pictureBox11.BackColor = Color.Red;
            this.pictureBox11.Location = new Point(0x40, 0x25);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new Size(0x1b, 0x16);
            this.pictureBox11.TabIndex = 0x11;
            this.pictureBox11.TabStop = false;
            this.tab_speakinganswers.AutoScroll = true;
            this.tab_speakinganswers.Controls.Add(this.tableLayoutPanel2);
            this.tab_speakinganswers.Location = new Point(4, 0x16);
            this.tab_speakinganswers.Name = "tab_speakinganswers";
            this.tab_speakinganswers.Size = new Size(0x301, 0x20e);
            this.tab_speakinganswers.TabIndex = 2;
            this.tab_speakinganswers.Text = "Speaking";
            this.tab_speakinganswers.UseVisualStyleBackColor = true;
            this.tab_speakinganswers.Click += new EventHandler(this.tab_speakinganswers_Click);
            this.tab_speakinganswers.Leave += new EventHandler(this.tab_speakinganswers_Leave);
            this.tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70f));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn_speakinganswer1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_speakinganswer2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_speakinganswer3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_speakinganswer4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_speakinganswer5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_speakinganswer6, 1, 5);
            this.tableLayoutPanel2.Location = new Point(0x54, 0x13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            this.tableLayoutPanel2.Size = new Size(0x270, 0x1c9);
            this.tableLayoutPanel2.TabIndex = 0;
            this.label10.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.label10.Location = new Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x55, 0x48);
            this.label10.TabIndex = 0;
            this.label10.Text = "SPEAKING 1";
            this.label10.TextAlign = ContentAlignment.MiddleCenter;
            this.label11.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.label11.Location = new Point(6, 0x4e);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x55, 0x48);
            this.label11.TabIndex = 0;
            this.label11.Text = "SPEAKING 2";
            this.label11.TextAlign = ContentAlignment.MiddleCenter;
            this.label12.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.label12.Location = new Point(6, 0x99);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x55, 0x48);
            this.label12.TabIndex = 0;
            this.label12.Text = "SPEAKING 3";
            this.label12.TextAlign = ContentAlignment.MiddleCenter;
            this.label13.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.label13.Location = new Point(6, 0xe4);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x55, 0x48);
            this.label13.TabIndex = 0;
            this.label13.Text = "SPEAKING 4";
            this.label13.TextAlign = ContentAlignment.MiddleCenter;
            this.label14.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.label14.Location = new Point(6, 0x12f);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x55, 0x48);
            this.label14.TabIndex = 0;
            this.label14.Text = "SPEAKING 5";
            this.label14.TextAlign = ContentAlignment.MiddleCenter;
            this.label15.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.label15.Location = new Point(6, 0x17a);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x55, 0x4c);
            this.label15.TabIndex = 0;
            this.label15.Text = "SPEAKING 6";
            this.label15.TextAlign = ContentAlignment.MiddleCenter;
            this.btn_speakinganswer1.BackgroundImage = (Image) manager.GetObject("btn_speakinganswer1.BackgroundImage");
            this.btn_speakinganswer1.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_speakinganswer1.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer1.FlatStyle = FlatStyle.Flat;
            this.btn_speakinganswer1.Location = new Point(100, 6);
            this.btn_speakinganswer1.Name = "btn_speakinganswer1";
            this.btn_speakinganswer1.Size = new Size(0x55, 0x42);
            this.btn_speakinganswer1.TabIndex = 1;
            this.btn_speakinganswer1.UseVisualStyleBackColor = true;
            this.btn_speakinganswer1.Click += new EventHandler(this.btn_speakinganswer_Click);
            this.btn_speakinganswer2.BackgroundImage = (Image) manager.GetObject("btn_speakinganswer2.BackgroundImage");
            this.btn_speakinganswer2.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_speakinganswer2.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer2.FlatStyle = FlatStyle.Flat;
            this.btn_speakinganswer2.Location = new Point(100, 0x51);
            this.btn_speakinganswer2.Name = "btn_speakinganswer2";
            this.btn_speakinganswer2.Size = new Size(0x55, 0x42);
            this.btn_speakinganswer2.TabIndex = 1;
            this.btn_speakinganswer2.UseVisualStyleBackColor = true;
            this.btn_speakinganswer2.Click += new EventHandler(this.btn_speakinganswer_Click);
            this.btn_speakinganswer3.BackgroundImage = (Image) manager.GetObject("btn_speakinganswer3.BackgroundImage");
            this.btn_speakinganswer3.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_speakinganswer3.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer3.FlatStyle = FlatStyle.Flat;
            this.btn_speakinganswer3.Location = new Point(100, 0x9c);
            this.btn_speakinganswer3.Name = "btn_speakinganswer3";
            this.btn_speakinganswer3.Size = new Size(0x55, 0x42);
            this.btn_speakinganswer3.TabIndex = 1;
            this.btn_speakinganswer3.UseVisualStyleBackColor = true;
            this.btn_speakinganswer3.Click += new EventHandler(this.btn_speakinganswer_Click);
            this.btn_speakinganswer4.BackgroundImage = (Image) manager.GetObject("btn_speakinganswer4.BackgroundImage");
            this.btn_speakinganswer4.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_speakinganswer4.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer4.FlatStyle = FlatStyle.Flat;
            this.btn_speakinganswer4.Location = new Point(100, 0xe7);
            this.btn_speakinganswer4.Name = "btn_speakinganswer4";
            this.btn_speakinganswer4.Size = new Size(0x55, 0x42);
            this.btn_speakinganswer4.TabIndex = 1;
            this.btn_speakinganswer4.UseVisualStyleBackColor = true;
            this.btn_speakinganswer4.Click += new EventHandler(this.btn_speakinganswer_Click);
            this.btn_speakinganswer5.BackgroundImage = (Image) manager.GetObject("btn_speakinganswer5.BackgroundImage");
            this.btn_speakinganswer5.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_speakinganswer5.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer5.FlatStyle = FlatStyle.Flat;
            this.btn_speakinganswer5.Location = new Point(100, 0x132);
            this.btn_speakinganswer5.Name = "btn_speakinganswer5";
            this.btn_speakinganswer5.Size = new Size(0x55, 0x42);
            this.btn_speakinganswer5.TabIndex = 1;
            this.btn_speakinganswer5.UseVisualStyleBackColor = true;
            this.btn_speakinganswer5.Click += new EventHandler(this.btn_speakinganswer_Click);
            this.btn_speakinganswer6.BackgroundImage = (Image) manager.GetObject("btn_speakinganswer6.BackgroundImage");
            this.btn_speakinganswer6.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_speakinganswer6.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer6.FlatStyle = FlatStyle.Flat;
            this.btn_speakinganswer6.Location = new Point(100, 0x17d);
            this.btn_speakinganswer6.Name = "btn_speakinganswer6";
            this.btn_speakinganswer6.Size = new Size(0x55, 0x42);
            this.btn_speakinganswer6.TabIndex = 1;
            this.btn_speakinganswer6.UseVisualStyleBackColor = true;
            this.btn_speakinganswer6.Click += new EventHandler(this.btn_speakinganswer_Click);
            this.tab_writinganswers.Controls.Add(this.rtb_writinganswers);
            this.tab_writinganswers.Controls.Add(this.rtb_writing2);
            this.tab_writinganswers.Controls.Add(this.rtb_writing1);
            this.tab_writinganswers.Location = new Point(4, 0x16);
            this.tab_writinganswers.Name = "tab_writinganswers";
            this.tab_writinganswers.Size = new Size(0x301, 0x20e);
            this.tab_writinganswers.TabIndex = 3;
            this.tab_writinganswers.Text = "Writing";
            this.tab_writinganswers.UseVisualStyleBackColor = true;
            this.rtb_writinganswers.Location = new Point(0x37, 0x2b);
            this.rtb_writinganswers.Name = "rtb_writinganswers";
            this.rtb_writinganswers.Size = new Size(0x281, 0x1aa);
            this.rtb_writinganswers.TabIndex = 1;
            this.rtb_writinganswers.Text = "";
            this.rtb_writing2.AutoSize = true;
            this.rtb_writing2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.rtb_writing2.Location = new Point(0xd5, 0x10);
            this.rtb_writing2.Name = "rtb_writing2";
            this.rtb_writing2.Size = new Size(0xac, 0x15);
            this.rtb_writing2.TabIndex = 0;
            this.rtb_writing2.Text = "Independent Writing";
            this.rtb_writing2.UseVisualStyleBackColor = true;
            this.rtb_writing2.CheckedChanged += new EventHandler(this.rtb_writing2_CheckedChanged);
            this.rtb_writing1.AutoSize = true;
            this.rtb_writing1.Checked = true;
            this.rtb_writing1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.rtb_writing1.Location = new Point(0x37, 0x10);
            this.rtb_writing1.Name = "rtb_writing1";
            this.rtb_writing1.Size = new Size(0x98, 0x15);
            this.rtb_writing1.TabIndex = 0;
            this.rtb_writing1.TabStop = true;
            this.rtb_writing1.Text = "Integrated Wrting";
            this.rtb_writing1.UseVisualStyleBackColor = true;
            this.btn_ShowText.BackgroundImage = (Image) manager.GetObject("btn_ShowText.BackgroundImage");
            this.btn_ShowText.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_ShowText.FlatAppearance.BorderSize = 0;
            this.btn_ShowText.FlatStyle = FlatStyle.Flat;
            this.btn_ShowText.Location = new Point(0x20b, 11);
            this.btn_ShowText.Name = "btn_ShowText";
            this.btn_ShowText.Size = new Size(0x4a, 0x22);
            this.btn_ShowText.TabIndex = 0x10;
            this.btn_ShowText.TabStop = false;
            this.btn_ShowText.UseVisualStyleBackColor = true;
            this.btn_ShowText.Visible = false;
            this.btn_ShowText.Click += new EventHandler(this.btn_ShowText_Click);
            this.flash_timer.Interval = 300;
            this.flash_timer.Tick += new EventHandler(this.flash_timer_Tick);
            this.Timer_Speaking.Interval = 0x3e8;
            this.Timer_Speaking.Tick += new EventHandler(this.Timer_Speaking_Tick);
            this.ckb_viewSpeakingText.BackColor = Color.Transparent;
            this.ckb_viewSpeakingText.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ckb_viewSpeakingText.Location = new Point(0x1ce, 0x37);
            this.ckb_viewSpeakingText.Name = "ckb_viewSpeakingText";
            this.ckb_viewSpeakingText.Size = new Size(0x70, 0x17);
            this.ckb_viewSpeakingText.TabIndex = 0x11;
            this.ckb_viewSpeakingText.TabStop = false;
            this.ckb_viewSpeakingText.Text = "Show Scripts";
            this.ckb_viewSpeakingText.UseVisualStyleBackColor = false;
            this.ckb_viewSpeakingText.Visible = false;
            this.ckb_viewSpeakingText.CheckedChanged += new EventHandler(this.ckb_viewSpeakingText_CheckedChanged);
            this.lbl_testingSection.AutoSize = true;
            this.lbl_testingSection.BackColor = Color.Transparent;
            this.lbl_testingSection.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_testingSection.Location = new Point(10, 2);
            this.lbl_testingSection.Name = "lbl_testingSection";
            this.lbl_testingSection.Size = new Size(0xae, 0x18);
            this.lbl_testingSection.TabIndex = 0x12;
            this.lbl_testingSection.Text = "lbl_testingSection";
            this.lbl_testingSection.Visible = false;
            this.btn_LastPage.BackgroundImage = (Image) manager.GetObject("btn_LastPage.BackgroundImage");
            this.btn_LastPage.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_LastPage.Enabled = false;
            this.btn_LastPage.FlatAppearance.BorderSize = 0;
            this.btn_LastPage.FlatStyle = FlatStyle.Flat;
            this.btn_LastPage.Location = new Point(7, 0x1d);
            this.btn_LastPage.Name = "btn_LastPage";
            this.btn_LastPage.Size = new Size(0x55, 0x21);
            this.btn_LastPage.TabIndex = 0x13;
            this.btn_LastPage.TabStop = false;
            this.btn_LastPage.UseVisualStyleBackColor = true;
            this.btn_LastPage.Click += new EventHandler(this.btn_LastPage_Click);
            this.btn_NexPage.BackgroundImage = (Image) manager.GetObject("btn_NexPage.BackgroundImage");
            this.btn_NexPage.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_NexPage.FlatAppearance.BorderSize = 0;
            this.btn_NexPage.FlatStyle = FlatStyle.Flat;
            this.btn_NexPage.Location = new Point(0x43, 0x1d);
            this.btn_NexPage.Name = "btn_NexPage";
            this.btn_NexPage.Size = new Size(0x55, 0x21);
            this.btn_NexPage.TabIndex = 0x13;
            this.btn_NexPage.TabStop = false;
            this.btn_NexPage.UseVisualStyleBackColor = true;
            this.btn_NexPage.Click += new EventHandler(this.btn_NexPage_Click);
            this.rb_PracticeMode.AutoSize = true;
            this.rb_PracticeMode.BackColor = Color.Transparent;
            this.rb_PracticeMode.Checked = true;
            this.rb_PracticeMode.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.rb_PracticeMode.Location = new Point(0x109, 12);
            this.rb_PracticeMode.Name = "rb_PracticeMode";
            this.rb_PracticeMode.Size = new Size(0x97, 0x15);
            this.rb_PracticeMode.TabIndex = 20;
            this.rb_PracticeMode.TabStop = true;
            this.rb_PracticeMode.Text = "PRACTICE MODE";
            this.rb_PracticeMode.UseVisualStyleBackColor = false;
            this.rb_TestMode.AutoSize = true;
            this.rb_TestMode.BackColor = Color.Transparent;
            this.rb_TestMode.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.rb_TestMode.Location = new Point(0x109, 0x29);
            this.rb_TestMode.Name = "rb_TestMode";
            this.rb_TestMode.Size = new Size(0x74, 0x15);
            this.rb_TestMode.TabIndex = 20;
            this.rb_TestMode.Text = "TEST MODE";
            this.rb_TestMode.UseVisualStyleBackColor = false;
            this.ckb_ShowAnswer.AutoSize = true;
            this.ckb_ShowAnswer.BackColor = Color.Transparent;
            this.ckb_ShowAnswer.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.ckb_ShowAnswer.Location = new Point(0xcb, 0x3b);
            this.ckb_ShowAnswer.Name = "ckb_ShowAnswer";
            this.ckb_ShowAnswer.Size = new Size(0x6f, 0x13);
            this.ckb_ShowAnswer.TabIndex = 0x16;
            this.ckb_ShowAnswer.TabStop = false;
            this.ckb_ShowAnswer.Text = "Show Answer";
            this.ckb_ShowAnswer.UseVisualStyleBackColor = false;
            this.ckb_ShowAnswer.Visible = false;
            this.ckb_ShowAnswer.CheckedChanged += new EventHandler(this.ckb_ShowAnswer_CheckedChanged);
            this.btn_pause.BackgroundImage = (Image) manager.GetObject("btn_pause.BackgroundImage");
            this.btn_pause.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_pause.FlatAppearance.BorderSize = 0;
            this.btn_pause.FlatStyle = FlatStyle.Flat;
            this.btn_pause.Location = new Point(110, 0x21);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new Size(0x45, 0x1a);
            this.btn_pause.TabIndex = 0x10;
            this.btn_pause.TabStop = false;
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Visible = false;
            this.btn_pause.Click += new EventHandler(this.btn_pause_Click);
            this.btn_QUITapp.BackgroundImage = (Image) manager.GetObject("btn_QUITapp.BackgroundImage");
            this.btn_QUITapp.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_QUITapp.FlatAppearance.BorderSize = 0;
            this.btn_QUITapp.FlatStyle = FlatStyle.Flat;
            this.btn_QUITapp.Location = new Point(0x2c3, 0);
            this.btn_QUITapp.Name = "btn_QUITapp";
            this.btn_QUITapp.Size = new Size(80, 0x30);
            this.btn_QUITapp.TabIndex = 0x17;
            this.btn_QUITapp.UseVisualStyleBackColor = true;
            this.btn_QUITapp.Click += new EventHandler(this.btn_QUITapp_Click);
            this.bgimagelist.ImageStream = (ImageListStreamer) manager.GetObject("bgimagelist.ImageStream");
            this.bgimagelist.TransparentColor = Color.Transparent;
            this.bgimagelist.Images.SetKeyName(0, "back1.jpg");
            this.bgimagelist.Images.SetKeyName(1, "continue.jpg");
            this.bgimagelist.Images.SetKeyName(2, "exit1.jpg");
            this.bgimagelist.Images.SetKeyName(3, "exit2.jpg");
            this.bgimagelist.Images.SetKeyName(4, "help.jpg");
            this.bgimagelist.Images.SetKeyName(5, "hidetimer.jpg");
            this.bgimagelist.Images.SetKeyName(6, "next.jpg");
            this.bgimagelist.Images.SetKeyName(7, "ok.jpg");
            this.bgimagelist.Images.SetKeyName(8, "Review.jpg");
            this.bgimagelist.Images.SetKeyName(9, "volumn.jpg");
            this.btn_showexplanation.BackColor = Color.Transparent;
            this.btn_showexplanation.BackgroundImage = (Image) manager.GetObject("btn_showexplanation.BackgroundImage");
            this.btn_showexplanation.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_showexplanation.FlatAppearance.BorderSize = 0;
            this.btn_showexplanation.FlatStyle = FlatStyle.Flat;
            this.btn_showexplanation.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.btn_showexplanation.Location = new Point(0x13e, 15);
            this.btn_showexplanation.Name = "btn_showexplanation";
            this.btn_showexplanation.Size = new Size(0x44, 0x1f);
            this.btn_showexplanation.TabIndex = 0x18;
            this.btn_showexplanation.UseVisualStyleBackColor = false;
            this.btn_showexplanation.Visible = false;
            this.btn_showexplanation.Click += new EventHandler(this.btn_showexplanation_Click);
            this.btn_showtranslation.BackColor = Color.Transparent;
            this.btn_showtranslation.BackgroundImage = (Image) manager.GetObject("btn_showtranslation.BackgroundImage");
            this.btn_showtranslation.BackgroundImageLayout = ImageLayout.Stretch;
            this.btn_showtranslation.FlatAppearance.BorderSize = 0;
            this.btn_showtranslation.FlatStyle = FlatStyle.Flat;
            this.btn_showtranslation.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.btn_showtranslation.Location = new Point(0x18d, 15);
            this.btn_showtranslation.Name = "btn_showtranslation";
            this.btn_showtranslation.Size = new Size(70, 30);
            this.btn_showtranslation.TabIndex = 0x18;
            this.btn_showtranslation.UseVisualStyleBackColor = false;
            this.btn_showtranslation.Visible = false;
            this.btn_showtranslation.Click += new EventHandler(this.btn_showtranslation_Click);
            this.Timer_reading.Tick += new EventHandler(this.Timer_reading_Tick);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = Color.White;
            this.BackgroundImage = (Image) manager.GetObject("$this.BackgroundImage");
            base.ClientSize = new Size(0x314, 0x296);
            base.Controls.Add(this.btn_pause);
            base.Controls.Add(this.btn_NexPage);
            base.Controls.Add(this.ckb_ShowAnswer);
            base.Controls.Add(this.btn_LastPage);
            base.Controls.Add(this.tabf_test);
            base.Controls.Add(this.btn_ShowText);
            base.Controls.Add(this.lbl_testingSection);
            base.Controls.Add(this.btn_QUITapp);
            base.Controls.Add(this.ckb_viewSpeakingText);
            base.Controls.Add(this.rb_PracticeMode);
            base.Controls.Add(this.rb_TestMode);
            base.Controls.Add(this.btn_showtranslation);
            base.Controls.Add(this.btn_showexplanation);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "MainForm";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "TPO";
            base.Load += new EventHandler(this.MainForm_Load);
            base.SizeChanged += new EventHandler(this.MainForm_SizeChanged);
            base.Controls.SetChildIndex(this.btn_showexplanation, 0);
            base.Controls.SetChildIndex(this.btn_showtranslation, 0);
            base.Controls.SetChildIndex(this.rb_TestMode, 0);
            base.Controls.SetChildIndex(this.rb_PracticeMode, 0);
            base.Controls.SetChildIndex(this.ckb_viewSpeakingText, 0);
            base.Controls.SetChildIndex(this.btn_QUITapp, 0);
            base.Controls.SetChildIndex(this.lbl_testingSection, 0);
            base.Controls.SetChildIndex(this.btn_ShowText, 0);
            base.Controls.SetChildIndex(this.tabf_test, 0);
            base.Controls.SetChildIndex(this.btn_LastPage, 0);
            base.Controls.SetChildIndex(this.ckb_ShowAnswer, 0);
            base.Controls.SetChildIndex(this.btn_NexPage, 0);
            base.Controls.SetChildIndex(this.btn_pause, 0);
            base.Controls.SetChildIndex(base.btn_mainmenu, 0);
            base.Controls.SetChildIndex(base.btn_quit, 0);
            base.Controls.SetChildIndex(base.btn_review, 0);
            base.Controls.SetChildIndex(base.Sound_icon, 0);
            base.Controls.SetChildIndex(base.tb_sound, 0);
            base.Controls.SetChildIndex(base.btn_continue, 0);
            base.Controls.SetChildIndex(base.lbl_timeremain, 0);
            base.Controls.SetChildIndex(base.btn_nextQuestion, 0);
            base.Controls.SetChildIndex(base.btn_preQuestion, 0);
            base.Controls.SetChildIndex(base.button1, 0);
            base.Controls.SetChildIndex(base.lbl_questionNO, 0);
            base.Controls.SetChildIndex(base.lbl_mode, 0);
            base.tb_sound.EndInit();
            this.tabf_test.ResumeLayout(false);
            this.tab_CoverForm.ResumeLayout(false);
            this.tabf_tposelection.ResumeLayout(false);
            this.TPO10.ResumeLayout(false);
            this.TPO10.PerformLayout();
            this.tab_Reading.ResumeLayout(false);
            this.tabf_Reading.ResumeLayout(false);
            this.rtab_Direction.ResumeLayout(false);
            this.rtab_Direction.PerformLayout();
            ((ISupportInitialize) this.pictureBox2).EndInit();
            this.rtab_NormalQuestion.ResumeLayout(false);
            this.rtab_NormalQuestion.PerformLayout();
            this.tb_reading.EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tlp_answers.ResumeLayout(false);
            this.tlp_answers.PerformLayout();
            this.rtab_SumQuestion.ResumeLayout(false);
            this.rtab_SumQuestion.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tlp_sumAnswers.ResumeLayout(false);
            this.tlp_sumAnswers.PerformLayout();
            this.tlp_Summary.ResumeLayout(false);
            this.tlp_Summary.PerformLayout();
            this.rtab_Review.ResumeLayout(false);
            this.rtab_Review.PerformLayout();
            ((ISupportInitialize) this.pb_wrongAnswered).EndInit();
            ((ISupportInitialize) this.pb_rightAnswered).EndInit();
            ((ISupportInitialize) this.pictureBox5).EndInit();
            ((ISupportInitialize) this.dgv_readingReview).EndInit();
            this.tab_Listening.ResumeLayout(false);
            this.tabf_Listening.ResumeLayout(false);
            this.ltab_Direction1.ResumeLayout(false);
            ((ISupportInitialize) this.pictureBox1).EndInit();
            this.ltab_Materials.ResumeLayout(false);
            this.l_splitContainer.Panel1.ResumeLayout(false);
            this.l_splitContainer.Panel1.PerformLayout();
            this.l_splitContainer.Panel2.ResumeLayout(false);
            this.l_splitContainer.ResumeLayout(false);
            this.tb_currentpos.EndInit();
            ((ISupportInitialize) this.pb_ListenScene).EndInit();
            this.panel1.ResumeLayout(false);
            this.flp_passage.ResumeLayout(false);
            this.flp_passage.PerformLayout();
            this.lMaterials1.ResumeLayout(false);
            this.tb_currentpos1.EndInit();
            ((ISupportInitialize) this.pb_ListenScene1).EndInit();
            this.ltab_Question.ResumeLayout(false);
            this.ltab_Question.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.lTableQuestion.ResumeLayout(false);
            this.lTableQuestion.PerformLayout();
            this.ltlp_table.ResumeLayout(false);
            this.tab_Speaking.ResumeLayout(false);
            this.tabf_speaking.ResumeLayout(false);
            this.sDirection.ResumeLayout(false);
            this.sDirection.PerformLayout();
            ((ISupportInitialize) this.pictureBox3).EndInit();
            this.sNormalQuestions.ResumeLayout(false);
            this.sNormalQuestions.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((ISupportInitialize) this.pb_speakingScene).EndInit();
            this.tab_Writing.ResumeLayout(false);
            this.tabf_writing.ResumeLayout(false);
            this.wDirection.ResumeLayout(false);
            this.wDirection.PerformLayout();
            ((ISupportInitialize) this.pictureBox4).EndInit();
            this.wReading.ResumeLayout(false);
            this.wSpeakingPassage.ResumeLayout(false);
            this.wtb_speak.EndInit();
            ((ISupportInitialize) this.pb_writingScene).EndInit();
            this.wWriting2.ResumeLayout(false);
            this.wpanel.ResumeLayout(false);
            this.wpanel.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabf_answer.ResumeLayout(false);
            this.tab_readinganswer.ResumeLayout(false);
            this.tab_readinganswer.PerformLayout();
            ((ISupportInitialize) this.pictureBox6).EndInit();
            ((ISupportInitialize) this.pictureBox7).EndInit();
            ((ISupportInitialize) this.pictureBox8).EndInit();
            ((ISupportInitialize) this.dgv_readinganswers).EndInit();
            this.tab_listeninganswers.ResumeLayout(false);
            this.tab_listeninganswers.PerformLayout();
            ((ISupportInitialize) this.dgv_listeninganswers).EndInit();
            ((ISupportInitialize) this.pictureBox9).EndInit();
            ((ISupportInitialize) this.pictureBox10).EndInit();
            ((ISupportInitialize) this.pictureBox11).EndInit();
            this.tab_speakinganswers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tab_writinganswers.ResumeLayout(false);
            this.tab_writinganswers.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public void InitialParas()
        {
            if (!ISACTIVED)
            {
                Application.Exit();
            }
            this.CONTINUECLICKED = false;
            this.MP3Player.StopT();
            this.MP3Player = new MP3MCI();
            this.MP3Recorder = new MP3Record();
            this.Timer_reading.Stop();
            this.tb_reading.Visible = false;
            this.bn_readText.Visible = false;
            this.btn_stopReading.Visible = false;
            this.Timer_Listening.Stop();
            this.flash_timer.Stop();
            this.Timer_Speaking.Stop();
            this.btn_pause.BackgroundImage = Image.FromFile(@"Tests\Direction\pause.jpg");
            this.btn_pause.Visible = false;
            this.llbl_rightAnswer.Visible = false;
            base.btn_mainmenu.Visible = false;
            base.btn_quit.Visible = false;
            this.lbl_testingSection.Visible = false;
            this.btn_ShowText.Visible = false;
            base.lbl_mode.Visible = false;
            base.lbl_questionNO.Visible = false;
            base.Sound_icon.Visible = false;
            base.tb_sound.Visible = false;
            base.btn_review.Visible = false;
            base.btn_preQuestion.Visible = false;
            base.btn_nextQuestion.Visible = false;
            this.ckb_viewSpeakingText.Visible = false;
            this.ckb_viewSpeakingText.Checked = false;
            this.ckb_ShowAnswer.Visible = false;
            this.ckb_ShowAnswer.Checked = false;
            base.lbl_timeremain.Visible = false;
            this.CurrentReadingStep = 0;
            this.RSpiltQuestionNO = 0;
            this.ReviewSelectedQuestionNO = -1;
            this.TestMode = 0;
            this.PartCount = 0;
            this.PassageCount = 0;
            this.QuestionCount = 0;
            this.PassageLastQuestionIndex = 0;
            this.PartLastPassageIndex = 0;
            this.InsertSetenceRtf = "";
            this.PreInsertPosition = -1;
            this.IsRepeated = false;
            this.IsQuestionAfter = false;
            this.HasLoadMP3 = false;
            this.CurrentSpeakingStep = 0;
            this.CurrentWritingStep = 0;
            this.SummarySelectedAnswerIndex = -1;
            this.ShowPassage = false;
        }

        private void linkLabel_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = (LinkLabel) sender;
            label.Links[label.Links.IndexOf(e.Link)].Visited = true;
            string linkData = e.Link.LinkData as string;
            this.MP3Player.SetPlayTime((long) Convert.ToInt32(linkData));
            this.Timer_Listening.Start();
        }

        public void LoadListeningMaterial()
        {
            this.IsPassageMP3 = true;
            this.tabf_test.SelectedIndex = LISTENING;
            if (this.ckb_viewSpeakingText.Checked)
            {
                this.tabf_Listening.SelectedIndex = LMATERIALS;
            }
            else
            {
                this.tabf_Listening.SelectedIndex = LMATERIALS1;
            }
            this.pb_ListenScene.Image = null;
            this.pb_ListenScene1.Image = null;
            if (this.PassageNO <= 1)
            {
                this.TestQuestions = new TPOQuestions(RtfReader.getRTF(@"Tests\" + this.TPONO + @"\Listening\questions.rtf"), @"Tests\" + this.TPONO + @"\Listening\questions.xml", "");
            }
            base.lbl_questionNO.Text = "Question " + this.QuestionNO.ToString() + " of 34";
            XMLFileReader reader = new XMLFileReader(@"Tests\" + this.TPONO + @"\Listening\questions.xml");
            string attr = reader.GetAttr(string.Concat(new object[] { "//part[@NO=", this.PartNO, "]/passage[@NO=", this.PassageNO, "]/@Content" }));
            this.PassageLastQuestionIndex = int.Parse(reader.GetAttr(string.Concat(new object[] { "//part[@NO=", this.PartNO, "]/passage[@NO=", this.PassageNO, "]/@lastQuestionIndex" })));
            this.PartLastPassageIndex = int.Parse(reader.GetAttr("//part[@NO=" + this.PartNO + "]/@lastPassageIndex"));
            int num = int.Parse(reader.GetAttr("//passage[@NO=" + this.PassageNO + "]/pictures/@pictureCount"));
            this.SPicturePaths = new string[num];
            this.SPictureTimeLines = new string[num];
            for (int i = 1; i < (num + 1); i++)
            {
                this.SPicturePaths[i - 1] = reader.GetAttr(string.Concat(new object[] { "//passage[@NO=", this.PassageNO, "]/pictures/picture[@NO=", i, "]/@pictureName" }));
                this.SPictureTimeLines[i - 1] = reader.GetAttr(string.Concat(new object[] { "//passage[@NO=", this.PassageNO, "]/pictures/picture[@NO=", i, "]/@Start" }));
            }
            this.loadLRC(string.Concat(new object[] { @"Tests\", this.TPONO, @"\Listening\", reader.GetAttr(string.Concat(new object[] { "//part[@NO=", this.PartNO, "]/passage[@NO=", this.PassageNO, "]/@passageName" })) }));
            try
            {
                this.MP3Player = new MP3MCI();
                string str2 = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Listening\", attr });
                this.MP3Player.FileName = str2;
                this.PlayFileName.Text = str2;
                this.pb_currentpos.Maximum = this.MP3Player.Duration;
                this.pb_currentpos1.Maximum = this.MP3Player.Duration;
                this.tb_currentpos.Maximum = this.MP3Player.Duration;
                this.tb_currentpos1.Maximum = this.MP3Player.Duration;
                this.MP3Player.play();
                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                this.Timer_Listening.Start();
                this.IsPassageMP3 = true;
            }
            catch
            {
                MessageBox.Show("open出错!");
            }
        }

        public void LoadListeningQA()
        {
            int length;
            if (this.LOADLASTQUESTION)
            {
                this.LoadUserAnswer();
            }
            Question question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
            base.lbl_questionNO.Text = "Question " + this.QuestionNO + " of 34";
            this.llbl_rightAnswer.Visible = this.ckb_ShowAnswer.Checked;
            this.IsPassageMP3 = false;
            switch (question.QuestionType)
            {
                case QuestionType.TABEL:
                {
                    int num5;
                    this.tabf_test.SelectedIndex = LISTENING;
                    this.tabf_Listening.SelectedIndex = LTABLEQUESTION;
                    this.lrtbTableQuestion.Rtf = question.QuestionTitle;
                    int count = question.ColStrs.Count;
                    int num4 = question.RowStrs.Count;
                    this.ltlp_table.RowCount = num4 + 1;
                    this.ltlp_table.ColumnCount = count + 1;
                    length = this.LRtbTableCol.Length;
                    while (length < this.LRtbTableCol.Length)
                    {
                        this.LRtbTableCol[length].Rtf = "";
                        this.LRtbTableCol[length].Visible = false;
                        num5 = this.LRtbTableRow.Length;
                        while (num5 < this.LRtbTableRow.Length)
                        {
                            this.LRtbTableRow[num5].Rtf = "";
                            this.LRtbTableRow[num5].Visible = false;
                            this.LCkbTable[num5][length].Visible = false;
                            this.LCkbTable[num5][length].Checked = false;
                            num5++;
                        }
                        length++;
                    }
                    for (length = 0; length < this.LRtbTableCol.Length; length++)
                    {
                        this.LRtbTableCol[length].Rtf = "";
                        this.LRtbTableCol[length].Visible = false;
                        num5 = 0;
                        while (num5 < this.LRtbTableRow.Length)
                        {
                            this.LRtbTableRow[num5].Rtf = "";
                            this.LRtbTableRow[num5].Visible = false;
                            this.LCkbTable[num5][length].Visible = false;
                            this.LCkbTable[num5][length].Checked = false;
                            num5++;
                        }
                    }
                    for (length = 0; length < count; length++)
                    {
                        this.LRtbTableCol[length].Rtf = (string) question.ColStrs[length];
                        this.LRtbTableCol[length].Visible = true;
                        num5 = 0;
                        while (num5 < num4)
                        {
                            this.LCkbTable[num5][length].Visible = true;
                            this.LCkbTable[num5][length].Checked = false;
                            num5++;
                        }
                    }
                    for (num5 = 0; num5 < num4; num5++)
                    {
                        this.LRtbTableRow[num5].Rtf = (string) question.RowStrs[num5];
                        this.LRtbTableRow[num5].Visible = true;
                    }
                    if (this.ckb_ShowAnswer.Checked)
                    {
                        this.lbl_tableAnswer.Visible = true;
                        this.lbl_tableAnswer.Text = question.RightAnswersStr;
                    }
                    else
                    {
                        this.lbl_tableAnswer.Visible = false;
                    }
                    goto Label_0656;
                }
                case QuestionType.SORT:
                    if (question.QuestionType == QuestionType.SORT)
                    {
                        this.tabf_test.SelectedIndex = READING;
                        this.tabf_Reading.SelectedIndex = RSUMMARYQUESTION;
                        this.rtb_sumQuestion.Rtf = question.QuestionTitle;
                        this.rtb_sumQuestion.Visible = true;
                        length = 0;
                        while (length < this.CkbSummarySelected.Length)
                        {
                            this.CkbSummarySelected[length].Checked = true;
                            this.CkbSummarySelected[length].Text = "";
                            this.CkbSummarySelected[length].Visible = false;
                            this.RtbSumSelected[length].Text = "";
                            this.RtbSumSelected[length].Visible = false;
                            length++;
                        }
                        for (length = 0; length < this.CkbSummary.Length; length++)
                        {
                            this.RtbSumAnswersToBeSelected[length].Text = "";
                            this.RtbSumAnswersToBeSelected[length].Visible = false;
                            this.CkbSummary[length].Checked = false;
                            this.CkbSummary[length].Visible = false;
                        }
                        length = 0;
                        while (length < question.UserAnswers.Count)
                        {
                            int num2 = Convert.ToInt16(question.UserAnswers[length]);
                            if (num2 > 0)
                            {
                                this.SummarySelectedAnswerIndex = length + 1;
                                this.CkbSummary[num2 - 1].Checked = true;
                            }
                            length++;
                        }
                    }
                    break;

                default:
                    this.tabf_test.SelectedIndex = LISTENING;
                    this.tabf_Listening.SelectedIndex = LQUESTIONS;
                    for (length = 0; length < this.LCkbAnswers.Length; length++)
                    {
                        this.LCkbAnswers[length].Visible = false;
                        this.LRtbAnswers[length].Visible = false;
                        this.LCkbAnswers[length].Checked = false;
                        this.LCkbAnswers[length].Enabled = true;
                        this.LRtbAnswers[length].BackColor = SystemColors.ControlLight;
                    }
                    this.lrtb_question.Rtf = question.QuestionTitle;
                    for (length = 0; length < question.UserAnswers.Count; length++)
                    {
                        this.LCkbAnswers[((int) question.UserAnswers[length]) - 1].Checked = true;
                    }
                    for (int i = 0; i < question.RightAnswers.Length; i++)
                    {
                        if (this.ckb_ShowAnswer.Checked)
                        {
                            this.LRtbAnswers[question.RightAnswers[i] - 1].BackColor = Color.LightPink;
                        }
                        else
                        {
                            this.LRtbAnswers[question.RightAnswers[i] - 1].BackColor = SystemColors.ControlLight;
                        }
                    }
                    goto Label_0656;
            }
            this.llbl_rightAnswer.Text = question.RightAnswersStr;
        Label_0656:
            try
            {
                this.MP3Player = new MP3MCI();
                string str = "";
                str = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Listening\", question.MP3Path });
                this.MP3Player.FileName = str;
                this.PlayFileName.Text = str;
                this.pb_currentpos.Maximum = this.MP3Player.Duration;
                this.pb_currentpos1.Maximum = this.MP3Player.Duration;
                this.tb_currentpos.Maximum = this.MP3Player.Duration;
                this.tb_currentpos1.Maximum = this.MP3Player.Duration;
                this.MP3Player.play();
                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                this.Timer_Listening.Start();
                this.BottonsStatus();
            }
            catch
            {
                MessageBox.Show("open出错!");
            }
        }

        private void loadLRC(string lrcPath)
        {
            LyricsReader reader = new LyricsReader();
            reader.ReadLRCFile(lrcPath);
            int start = 0;
            LinkLabel[] labelArray = new LinkLabel[0x20];
            int index = 0;
            int num3 = 0;
            this.flp_passage.Controls.Clear();
            while (index < 0x20)
            {
                labelArray[index] = new LinkLabel();
                labelArray[index].AutoSize = true;
                labelArray[index].Font = this.lnk_passage.Font;
                labelArray[index].LinkBehavior = this.lnk_passage.LinkBehavior;
                labelArray[index].LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel_Click);
                int num4 = 0;
                start = 0;
                while (num3 < reader.LrcList.Count)
                {
                    num4++;
                    LyricsReader.Lrc lrc = (LyricsReader.Lrc) reader.LrcList[num3];
                    string sText = lrc.sText;
                    int length = 0;
                    if (sText.TrimEnd(new char[0]).EndsWith("<BR>"))
                    {
                        sText = sText.Replace("<BR>", "");
                        length = sText.Length + 4;
                        labelArray[index].Text = labelArray[index].Text + sText + "\r\n\r\n";
                    }
                    else
                    {
                        length = sText.Length;
                        labelArray[index].Text = labelArray[index].Text + sText;
                    }
                    labelArray[index].Links.Add(start, length, lrc.iTime.ToString());
                    start += length;
                    if (num3 == (reader.LrcList.Count - 1))
                    {
                        this.flp_passage.Controls.Add(labelArray[index]);
                        break;
                    }
                    if ((num4 == 0x1f) || lrc.sText.Trim().Equals(""))
                    {
                        this.flp_passage.Controls.Add(labelArray[index]);
                        break;
                    }
                    num3++;
                }
                if (num3 >= (reader.LrcList.Count - 1))
                {
                    break;
                }
                index++;
            }
        }

        public void LoadReadingMaterialAndQA()
        {
            int num;
            if (this.CurrentReadingPassage != this.ReadingPassageNo)
            {
                this.btn_stopReading_Click(new object(), new EventArgs());
            }
            this.BottonsStatus();
            this.SummarySelectedAnswers = new int[5];
            base.lbl_questionNO.Text = "Question " + this.QuestionNO.ToString() + " of " + this.QuestionCount.ToString();
            for (num = 0; num < this.CkbReading.Length; num++)
            {
                this.CkbReading[num].Visible = false;
                this.RtbReadingAnswers[num].Visible = false;
                this.CkbReading[num].Checked = false;
                this.CkbReading[num].Enabled = true;
            }
            for (num = 0; num < this.CkbSummarySelected.Length; num++)
            {
                this.CkbSummarySelected[num].Checked = true;
                this.CkbSummarySelected[num].Text = "";
                this.CkbSummarySelected[num].Visible = false;
                this.RtbSumSelected[num].Text = "";
                this.RtbSumSelected[num].Visible = false;
            }
            for (num = 0; num < this.CkbSummary.Length; num++)
            {
                this.RtbSumAnswersToBeSelected[num].Text = "";
                this.RtbSumAnswersToBeSelected[num].Visible = false;
                this.CkbSummary[num].Checked = false;
                this.CkbSummary[num].Visible = false;
            }
            this.rtb_Passage.Rtf = this.RMaterial.ReadingPassageONQuestion(this.QuestionNO, this.RSpiltQuestionNO);
            TRANSLATION = this.RMaterial.Translation;
            if (this.rtb_Passage.Text.IndexOf("◆") >= 0)
            {
                this.rtb_Passage.SelectionStart = this.rtb_Passage.Text.IndexOf("◆");
                this.rtb_Passage.ScrollToCaret();
            }
            if (this.QuestionNO > 0)
            {
                if (this.rb_PracticeMode.Checked)
                {
                    this.ckb_ShowAnswer.Visible = true;
                    if (ConstantValues.TPOEXPLANATION[this.TPONO])
                    {
                        this.btn_showexplanation.Visible = this.ckb_ShowAnswer.Visible;
                        this.btn_showtranslation.Visible = this.ckb_ShowAnswer.Visible;
                    }
                }
                Question question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
                EXPLANATION = question.QuestionExplanation;
                if (question.QuestionType == QuestionType.SUMMARY)
                {
                    this.tabf_test.SelectedIndex = READING;
                    this.tabf_Reading.SelectedIndex = RSUMMARYQUESTION;
                    this.ShowPassage = false;
                    for (num = 0; num < this.CkbSummarySelected.Length; num++)
                    {
                        this.CkbSummarySelected[num].Checked = true;
                    }
                    for (num = 0; num < this.CkbSummary.Length; num++)
                    {
                        this.RtbSumAnswersToBeSelected[num].BackColor = SystemColors.ControlLightLight;
                        this.CkbSummary[num].Checked = false;
                    }
                    if (this.ckb_ShowAnswer.Checked)
                    {
                        for (num = 0; num < question.RightAnswers.Length; num++)
                        {
                            this.RtbSumAnswersToBeSelected[question.RightAnswers[num] - 1].BackColor = Color.LightPink;
                        }
                    }
                    this.rtb_sumPassage.Height = 500;
                    this.rtb_sumQuestion.Visible = !this.ShowPassage;
                    this.rtb_sumPassage.Visible = this.ShowPassage;
                    this.tlp_answers.Visible = !this.ShowPassage;
                    this.tlp_Summary.Visible = !this.ShowPassage;
                    this.rtb_sumQuestion.Rtf = question.QuestionTitle;
                    this.rtb_sumPassage.Rtf = this.RMaterial.ReadingPassageONQuestion(this.QuestionNO, this.RSpiltQuestionNO);
                    TRANSLATION = this.RMaterial.Translation;
                    for (num = 0; (num < question.Answers.Length) && (num < this.CkbSummary.Length); num++)
                    {
                        this.RtbSumAnswersToBeSelected[num].Visible = true;
                        this.CkbSummary[num].Visible = true;
                        this.RtbSumAnswersToBeSelected[num].Rtf = question.Answers[num];
                    }
                    for (num = 0; num < question.RightAnswers.Length; num++)
                    {
                        this.RtbSumSelected[num].Visible = true;
                    }
                    for (num = 0; num < question.UserAnswers.Count; num++)
                    {
                        int num2 = Convert.ToInt16(question.UserAnswers[num]);
                        if (num2 > 0)
                        {
                            this.SummarySelectedAnswerIndex = num + 1;
                            this.CkbSummary[num2 - 1].Checked = true;
                        }
                    }
                }
                else if (question.QuestionType == QuestionType.TABEL)
                {
                    int num5;
                    this.tabf_test.SelectedIndex = LISTENING;
                    this.tabf_Listening.SelectedIndex = LTABLEQUESTION;
                    this.rtb_sumPassage.Height = 500;
                    this.rtb_sumQuestion.Visible = !this.ShowPassage;
                    this.rtb_sumPassage.Visible = this.ShowPassage;
                    this.tlp_answers.Visible = !this.ShowPassage;
                    this.tlp_Summary.Visible = !this.ShowPassage;
                    this.rtb_sumPassage.Rtf = this.RMaterial.ReadingPassageONQuestion(this.QuestionNO, this.RSpiltQuestionNO);
                    TRANSLATION = this.RMaterial.Translation;
                    this.lrtbTableQuestion.Rtf = question.QuestionTitle;
                    int count = question.ColStrs.Count;
                    int num4 = question.RowStrs.Count;
                    this.ltlp_table.RowCount = num4 + 1;
                    this.ltlp_table.ColumnCount = count + 1;
                    for (num = 0; num < count; num++)
                    {
                        this.LRtbTableCol[num].Rtf = (string) question.ColStrs[num];
                        this.LRtbTableCol[num].Visible = true;
                        num5 = 0;
                        while (num5 < num4)
                        {
                            this.LCkbTable[num5][num].Visible = true;
                            num5++;
                        }
                    }
                    for (num5 = 0; num5 < num4; num5++)
                    {
                        this.LRtbTableRow[num5].Rtf = (string) question.RowStrs[num5];
                        this.LRtbTableRow[num5].Visible = true;
                    }
                    if (this.ckb_ShowAnswer.Checked)
                    {
                        this.lbl_tableAnswer.Visible = true;
                        this.lbl_tableAnswer.Text = question.RightAnswersStr;
                    }
                    else
                    {
                        this.lbl_tableAnswer.Visible = false;
                    }
                }
                else
                {
                    this.rtb_question.Rtf = question.QuestionTitle;
                    this.tabf_test.SelectedIndex = READING;
                    this.tabf_Reading.SelectedIndex = RNORMALQUESTION;
                    for (num = 0; (num < question.Answers.Length) && (num < this.CkbReading.Length); num++)
                    {
                        this.RtbReadingAnswers[num].Visible = true;
                        if (question.QuestionType != QuestionType.INSERT)
                        {
                            this.CkbReading[num].Visible = true;
                        }
                        this.RtbReadingAnswers[num].Rtf = question.Answers[num];
                        this.RtbReadingAnswers[num].BackColor = SystemColors.ControlLight;
                    }
                    if (this.ckb_ShowAnswer.Checked)
                    {
                        for (int i = 0; i < question.RightAnswers.Length; i++)
                        {
                            this.RtbReadingAnswers[question.RightAnswers[i] - 1].BackColor = Color.LightPink;
                        }
                    }
                    if (question.QuestionType == QuestionType.INSERT)
                    {
                        string str = "<i>";
                        string str2 = "</i>";
                        int index = this.rtb_question.Text.IndexOf(str);
                        int num8 = this.rtb_question.Text.IndexOf(str2);
                        if (index >= 0)
                        {
                            this.rtb_question.SelectionStart = index;
                            this.rtb_question.SelectionLength = str.Length;
                            this.rtb_question.SelectedText = "\n";
                        }
                        if (num8 >= 0)
                        {
                            this.rtb_question.SelectionStart = (num8 - str.Length) + 1;
                            this.rtb_question.SelectionLength = str2.Length;
                            this.rtb_question.SelectedText = "\n";
                        }
                        this.rtb_question.SelectionStart = index + 1;
                        this.rtb_question.SelectionLength = ((num8 - index) - str.Length) - 1;
                        this.InsertSetenceRtf = this.rtb_question.SelectedRtf;
                    }
                    for (num = 0; num < question.UserAnswers.Count; num++)
                    {
                        this.CkbReading[((int) question.UserAnswers[num]) - 1].Checked = true;
                        if ((question.QuestionType == QuestionType.INSERT) && (this.PreInsertPosition != -1))
                        {
                            this.rtb_Passage.SelectionStart = this.PreInsertPosition;
                            this.rtb_Passage.SelectionLength = 1;
                            this.rtb_Passage.SelectedRtf = this.InsertSetenceRtf;
                        }
                    }
                    this.EXP.Refresh();
                    this.TRANSUI.Refresh();
                }
            }
        }

        private void LoadSpeakingQuestion()
        {
            int num3;
            string str = RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Speaking\questions.rtf");
            RichTextBox box = new RichTextBox();
            box.Rtf = str;
            string[] strArray = box.Text.Split(new string[] { "</Q>" }, StringSplitOptions.RemoveEmptyEntries);
            int num = 0;
            int num2 = 0;
            this.SpeakingQuestions = new string[6];
            for (num3 = 0; num3 < strArray.Length; num3++)
            {
                num2 = strArray[num3].Length + 4;
                box.SelectionStart = num;
                box.SelectionLength = num2 - 4;
                this.SpeakingQuestions[num3] = box.SelectedRtf;
                num += num2;
            }
            str = RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Speaking\reading.rtf");
            box.Rtf = str;
            strArray = box.Text.Split(new string[] { "</R>" }, StringSplitOptions.RemoveEmptyEntries);
            num = 0;
            num2 = 0;
            this.SReadingMaterials = new string[2];
            for (num3 = 0; num3 < strArray.Length; num3++)
            {
                num2 = strArray[num3].Length + 4;
                box.SelectionStart = num;
                box.SelectionLength = num2 - 4;
                this.SReadingMaterials[num3] = box.SelectedRtf;
                num += num2;
            }
        }

        public void LoadUserAnswer()
        {
            XMLFileReader reader = new XMLFileReader();
            string path = string.Concat(new object[] { Application.StartupPath, @"\users\", USERNAME, @"\", this.TPONO });
            if (this.TestSection == TestingSection.READING)
            {
                path = path + @"\Reading" + this.PartNO.ToString() + ".txt";
            }
            else
            {
                path = path + @"\Listening.txt";
            }
            string str2 = "";
            Stream stream = null;
            StreamReader reader2 = null;
            try
            {
                int num = 0;
                stream = File.Open(path, FileMode.Open, FileAccess.Read);
                reader2 = new StreamReader(stream);
                while (!reader2.EndOfStream)
                {
                    num++;
                    str2 = reader2.ReadLine();
                    if (num >= 2)
                    {
                        Question question = (Question) this.TestQuestions.Questions[num - 2];
                        string str3 = str2.Substring(30, 15).TrimEnd(new char[0]);
                        question.UserAnswers.Clear();
                        for (int i = 0; i < str3.Length; i++)
                        {
                            char ch = str3.ToCharArray()[i];
                            int num3 = ch;
                            question.UserAnswers.Add(num3 - 0x40);
                        }
                    }
                }
                if (reader2 != null)
                {
                    reader2.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
            catch (Exception)
            {
                if ((reader2 != null) && (reader2 != null))
                {
                    reader2.Close();
                }
                if ((stream != null) && (stream != null))
                {
                    stream.Close();
                }
            }
        }

        private void LoadWritingQuestion()
        {
            string str = RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Writing\questions.rtf");
            RichTextBox box = new RichTextBox();
            box.Rtf = str;
            string[] strArray = box.Text.Split(new string[] { "</Q>" }, StringSplitOptions.RemoveEmptyEntries);
            int num = 0;
            int num2 = 0;
            this.WritingQuestions = new string[2];
            for (int i = 0; i < strArray.Length; i++)
            {
                num2 = strArray[i].Length + 4;
                box.SelectionStart = num;
                box.SelectionLength = num2 - 4;
                this.WritingQuestions[i] = box.SelectedRtf;
                num += num2;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.tabf_test.Region = new Region(new RectangleF((float) this.tabf_test.TabPages[0].Left, (float) this.tabf_test.TabPages[0].Top, (float) this.tabf_test.TabPages[0].Width, (float) this.tabf_test.TabPages[0].Height));
            this.tabf_tposelection.Region = new Region(new RectangleF((float) this.tabf_test.TabPages[0].Left, (float) this.tabf_test.TabPages[0].Top, (float) this.tabf_tposelection.TabPages[0].Width, (float) this.tabf_tposelection.TabPages[0].Height));
            this.tabf_Reading.Region = new Region(new RectangleF((float) this.tabf_test.TabPages[0].Left, (float) this.tabf_test.TabPages[0].Top, (float) this.tabf_Reading.TabPages[0].Width, (float) this.tabf_Reading.TabPages[0].Height));
            this.tabf_Listening.Region = new Region(new RectangleF((float) this.tabf_test.TabPages[0].Left, (float) this.tabf_test.TabPages[0].Top, (float) this.tabf_Listening.TabPages[0].Width, (float) this.tabf_Listening.TabPages[0].Height));
            this.tabf_speaking.Region = new Region(new RectangleF((float) this.tabf_test.TabPages[0].Left, (float) this.tabf_test.TabPages[0].Top, (float) this.tabf_speaking.TabPages[0].Width, (float) this.tabf_speaking.TabPages[0].Height));
            this.tabf_writing.Region = new Region(new RectangleF((float) this.tabf_test.TabPages[0].Left, (float) this.tabf_test.TabPages[0].Top, (float) this.tabf_writing.TabPages[0].Width, (float) this.tabf_writing.TabPages[0].Height));
            this.Antuorization();
            new Login().ShowDialog(this);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            double num = 1.0 + ((Convert.ToDouble(base.Height) - Convert.ToDouble(this.PreFormHeight)) / Convert.ToDouble(this.PreFormHeight));
            double num2 = 1.0 + ((Convert.ToDouble(base.Width) - Convert.ToDouble(this.PreFormWidth)) / Convert.ToDouble(this.PreFormWidth));
            this.PreFormHeight = base.Height;
            this.PreFormWidth = base.Width;
            this.ChangeControlSize(this, num, num2);
        }

        public void OnlyOneCheck(CheckBox[] ckbList, CheckBox ckb)
        {
            int num2;
            int length = ckbList.Length;
            bool flag = false;
            for (num2 = 0; num2 < length; num2++)
            {
                if (ckb.Equals(ckbList[num2]))
                {
                    flag = true;
                }
            }
            if (ckb.Checked && flag)
            {
                for (num2 = 0; num2 < length; num2++)
                {
                    if (!ckb.Equals(ckbList[num2]))
                    {
                        ckbList[num2].Checked = false;
                        ckbList[num2].Enabled = true;
                    }
                }
            }
        }

        private void RBtn_nextQuestion(EventArgs e)
        {
            if (this.QuestionNO == this.RSpiltQuestionNO)
            {
                this.PreInsertPosition = -1;
                if (this.RSpiltQuestionNO > 0)
                {
                    this.Timer_Listening.Stop();
                    if (MessageBox.Show("You have finished all the questions in this passage, and you will go to the NEXT PASSAGE of this READING section.\nBut you CAN return to this passage again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        this.btn_stopReading_Click(new object(), e);
                        this.ReadingPassageNo = 3;
                        try
                        {
                            this.TRANSUI.Close();
                            this.EXP.Close();
                        }
                        catch
                        {
                        }
                        base.btn_continue.Visible = false;
                        this.Timer_Listening.Start();
                    }
                }
            }
            this.SaveUserAnswers();
            if (this.HasReachedEndOfSection())
            {
                if (this.PassageNO < this.PassageCount)
                {
                    if (MessageBox.Show("You have seen all the questions in this part of the reading section.\nYou may go back and review your answers. As long as there is time remaining, you can check your work\n\nClick on Cancel to continue working.\nClick on OK to go on.\nOnce you leave this part of the reading section, you WILL NOT be able to return to it", "Finish Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        this.btn_stopReading_Click(new object(), e);
                        this.ReadingPassageNo = 2;
                        try
                        {
                            this.TRANSUI.Close();
                            this.EXP.Close();
                        }
                        catch
                        {
                        }
                        base.btn_continue.Visible = true;
                        this.scoreReport(2);
                        this.Timer_Listening.Stop();
                        this.PreInsertPosition = -1;
                        this.PassageNO++;
                        this.PartNO++;
                        XMLFileReader reader = new XMLFileReader(@"Tests\" + this.TPONO + @"\Reading\config.xml");
                        this.RSpiltQuestionNO = int.Parse(reader.GetAttr("//Passage[@NO=" + this.PassageNO + "]/@spiltQuestionNO"));
                        base.lbl_timeremain.Text = reader.GetAttr("//Passage[@NO=" + this.PassageNO + "]/@time");
                        this.tabf_test.SelectedIndex = READING;
                        this.tabf_Reading.SelectedIndex = RDIRECTION;
                        this.QuestionNO = 0;
                        this.RMaterial = new TPOPassage(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\" + this.PassageNO.ToString() + ".txt").Substring(0xb5), RtfReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\P" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
                        if (File.Exists(@"Explanations\" + this.TPONO.ToString() + @"\Reading\" + this.ReadingPassageNo.ToString() + ".mp3") && ConstantValues.TPOEXPLANATION[this.TPONO])
                        {
                            this.bn_readText.Visible = true;
                            this.bn_readText.Enabled = true;
                        }
                        else
                        {
                            this.bn_readText.Visible = false;
                        }
                        this.TestQuestions = new TPOQuestions(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\questions" + this.PassageNO.ToString() + ".txt").Substring(0xb5), "", RtfReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\Q" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
                        this.QuestionCount = this.TestQuestions.QuestionCount;
                        this.LoadReadingMaterialAndQA();
                        if (this.rb_PracticeMode.Checked && (MessageBox.Show("Do you want to load the answers you saved last time?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK))
                        {
                            this.LoadUserAnswer();
                        }
                    }
                }
                else if (MessageBox.Show("You have seen all the questions in the reading section.\nYou may go back and review your answers. As long as there is time remaining, you can check your work\n\nClick on Cancel to continue working.\nClick on OK to go on.\nOnce you leave the reading section, you WILL NOT be able to return to it", "Finish Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    this.btn_stopReading_Click(new object(), e);
                    try
                    {
                        this.TRANSUI.Close();
                        this.EXP.Close();
                    }
                    catch
                    {
                    }
                    base.btn_continue.Visible = true;
                    int num = this.TPONO % 10;
                    if (num == 0)
                    {
                        num = 10;
                    }
                    this.btn_LoadTest_Click(this.BtnLoadTest[10 + num], e);
                    this.PartNO = 1;
                    this.PassageNO = 1;
                    this.QuestionNO = 0;
                }
            }
            else
            {
                this.QuestionNO++;
                this.LoadReadingMaterialAndQA();
            }
        }

        public void ReportingScores()
        {
            DataRow row;
            string str4;
            string str5;
            string str6;
            string str7;
            string str8;
            Exception exception;
            DataTable table = new DataTable();
            DataColumn column = new DataColumn("QuestionID", typeof(string));
            table.Columns.Add(column);
            column = new DataColumn("QuestionType", typeof(string));
            table.Columns.Add(column);
            column = new DataColumn("MyAnswer", typeof(string));
            table.Columns.Add(column);
            column = new DataColumn("StandardAnswer", typeof(string));
            table.Columns.Add(column);
            column = new DataColumn("QuestionStatus", typeof(string));
            table.Columns.Add(column);
            column = new DataColumn("QuestionScore", typeof(string));
            table.Columns.Add(column);
            string str = string.Concat(new object[] { Application.StartupPath, @"\users\", USERNAME, @"\", this.TPONO, @"\Reading" });
            string str2 = "";
            int num = 0;
            string path = "";
            Stream stream = null;
            StreamReader reader = null;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            for (int i = 1; i < 3; i++)
            {
                path = str + i.ToString() + ".txt";
                if (File.Exists(path))
                {
                    num = 0;
                    try
                    {
                        stream = File.Open(path, FileMode.Open, FileAccess.Read);
                        reader = new StreamReader(stream);
                        while (!reader.EndOfStream)
                        {
                            num++;
                            str2 = reader.ReadLine();
                            if (num >= 2)
                            {
                                row = table.NewRow();
                                str4 = str2.Substring(0, 15).TrimEnd(new char[0]);
                                str5 = str2.Substring(15, 15).TrimEnd(new char[0]);
                                str6 = str2.Substring(30, 15).TrimEnd(new char[0]);
                                str7 = str2.Substring(0x2d, 15).TrimEnd(new char[0]);
                                str8 = str2.Substring(60, 15).TrimEnd(new char[0]);
                                row["QuestionID"] = str4;
                                row["QuestionType"] = str5;
                                row["MyAnswer"] = str6;
                                row["StandardAnswer"] = str7;
                                row["QuestionScore"] = str8;
                                if (str6.Equals(""))
                                {
                                    row["QuestionStatus"] = "Not Answered";
                                }
                                else
                                {
                                    row["QuestionStatus"] = "Answered";
                                }
                                table.Rows.Add(row);
                                if (str6.Equals(str7))
                                {
                                    num2++;
                                    num4 += Convert.ToInt16(str8);
                                    num5 += Convert.ToInt16(str8);
                                }
                                else
                                {
                                    if (str6.Equals(""))
                                    {
                                        num6++;
                                    }
                                    else
                                    {
                                        num3++;
                                    }
                                    num5 += Convert.ToInt16(str8);
                                }
                            }
                        }
                        if (reader != null)
                        {
                            reader.Close();
                        }
                        if (stream != null)
                        {
                            stream.Close();
                        }
                    }
                    catch (Exception exception1)
                    {
                        exception = exception1;
                        if (reader != null)
                        {
                            reader.Close();
                        }
                        if (stream != null)
                        {
                            stream.Close();
                        }
                    }
                }
            }
            this.dgv_readinganswers.DataSource = table;
            XMLFileReader reader2 = new XMLFileReader(@"Tests\Direction\Scoring.xml");
            num7 = int.Parse(reader2.GetAttr("//ScoreSections//Section[@NO=1]//Score[@TestScore='" + num4 + "']//@IBTScore"));
            string str9 = string.Concat(new object[] { "Your score is (total score): ", num4, "         Your standard score is (in 30 scores): ", num7, "\nRight answered: ", num2, "      Wrong answered: ", num3, "      Not answered: ", num6 });
            this.lbl_readingscorereport.Text = str9;
            DataTable table2 = new DataTable();
            column = new DataColumn("QuestionID", typeof(string));
            table2.Columns.Add(column);
            column = new DataColumn("QuestionType", typeof(string));
            table2.Columns.Add(column);
            column = new DataColumn("MyAnswer", typeof(string));
            table2.Columns.Add(column);
            column = new DataColumn("StandardAnswer", typeof(string));
            table2.Columns.Add(column);
            column = new DataColumn("QuestionStatus", typeof(string));
            table2.Columns.Add(column);
            column = new DataColumn("QuestionScore", typeof(string));
            table2.Columns.Add(column);
            num = 0;
            path = string.Concat(new object[] { Application.StartupPath, @"\users\", USERNAME, @"\", this.TPONO, @"\Listening.txt" });
            num2 = 0;
            num3 = 0;
            num4 = 0;
            num5 = 0;
            num6 = 0;
            num7 = 0;
            if (File.Exists(path))
            {
                try
                {
                    stream = File.Open(path, FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(stream);
                    while (!reader.EndOfStream)
                    {
                        num++;
                        str2 = reader.ReadLine();
                        if (num >= 2)
                        {
                            row = table2.NewRow();
                            str4 = str2.Substring(0, 15).TrimEnd(new char[0]);
                            str5 = str2.Substring(15, 15).TrimEnd(new char[0]);
                            str6 = str2.Substring(30, 15).TrimEnd(new char[0]);
                            str7 = str2.Substring(0x2d, 15).TrimEnd(new char[0]);
                            str8 = str2.Substring(60, 15).TrimEnd(new char[0]);
                            row["QuestionID"] = str4;
                            row["QuestionType"] = str5;
                            row["MyAnswer"] = str6;
                            row["StandardAnswer"] = str7;
                            row["QuestionScore"] = str8;
                            if (str6.Equals(""))
                            {
                                row["QuestionStatus"] = "Not Answered";
                            }
                            else
                            {
                                row["QuestionStatus"] = "Answered";
                            }
                            table2.Rows.Add(row);
                            if (str6.Equals(str7))
                            {
                                num2++;
                                num4 += Convert.ToInt16(str8);
                                num5 += Convert.ToInt16(str8);
                            }
                            else
                            {
                                if (str6.Equals(""))
                                {
                                    num6++;
                                }
                                else
                                {
                                    num3++;
                                }
                                num5 += Convert.ToInt16(str8);
                            }
                        }
                    }
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
                catch (Exception exception2)
                {
                    exception = exception2;
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
            }
            num7 = int.Parse(reader2.GetAttr("//ScoreSections//Section[@NO=2]//Score[@TestScore='" + num4 + "']//@IBTScore"));
            str9 = string.Concat(new object[] { "Your score is (total score): ", num4, "         Your standard score is (in 30 scores): ", num7, "\nRight answered: ", num2, "      Wrong answered: ", num3, "      Not answered: ", num6 });
            this.lbl_listeningScorereport.Text = str9;
            this.dgv_listeninganswers.DataSource = table2;
            num = 0;
            path = string.Concat(new object[] { Application.StartupPath, @"\users\", USERNAME, @"\", this.TPONO, @"\Writing1.txt" });
            if (File.Exists(path))
            {
                try
                {
                    stream = File.Open(path, FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(stream);
                    while (!reader.EndOfStream)
                    {
                        num++;
                        str2 = reader.ReadToEnd();
                        this.rtb_writinganswers.Text = str2;
                    }
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
                catch (Exception exception3)
                {
                    exception = exception3;
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void rtb_Passage_MouseClick(object sender, MouseEventArgs e)
        {
            int charIndexFromPosition = this.rtb_Passage.GetCharIndexFromPosition(e.Location);
            if (this.QuestionNO > 0)
            {
                Question question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
                if ((question.QuestionType == QuestionType.INSERT) && this.rtb_Passage.Text[charIndexFromPosition].Equals('█'))
                {
                    int textLength = 1;
                    if (this.PreInsertPosition != -1)
                    {
                        RichTextBox box = new RichTextBox();
                        box.Rtf = this.InsertSetenceRtf;
                        textLength = box.TextLength;
                        box.Dispose();
                        this.rtb_Passage.SelectionStart = this.PreInsertPosition;
                        this.rtb_Passage.SelectionLength = textLength;
                        this.rtb_Passage.SelectedText = "█";
                        this.rtb_Passage.DeselectAll();
                    }
                    if (this.PreInsertPosition > charIndexFromPosition)
                    {
                        this.rtb_Passage.SelectionStart = charIndexFromPosition;
                        this.rtb_Passage.SelectionLength = 1;
                        this.rtb_Passage.SelectedRtf = this.InsertSetenceRtf;
                        this.PreInsertPosition = charIndexFromPosition;
                    }
                    else if (this.PreInsertPosition < charIndexFromPosition)
                    {
                        charIndexFromPosition = (charIndexFromPosition - textLength) + 1;
                        this.rtb_Passage.SelectionStart = charIndexFromPosition;
                        this.rtb_Passage.SelectionLength = 1;
                        this.rtb_Passage.SelectedRtf = this.InsertSetenceRtf;
                        this.PreInsertPosition = charIndexFromPosition;
                    }
                    else
                    {
                        this.PreInsertPosition = -1;
                    }
                    int index = this.rtb_Passage.Text.Substring(0, charIndexFromPosition).Split(new char[] { '█' }).Length - 1;
                    this.CkbReading[index].Checked = true;
                    this.rtb_Passage.DeselectAll();
                }
            }
        }

        private void rtb_Passage_MouseMove(object sender, MouseEventArgs e)
        {
            int charIndexFromPosition = this.rtb_Passage.GetCharIndexFromPosition(e.Location);
            if (this.QuestionNO > 0)
            {
                Question question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
                if (question.QuestionType == QuestionType.INSERT)
                {
                    char ch = this.rtb_Passage.Text[charIndexFromPosition];
                    if (ch.Equals('█'))
                    {
                        Cursor.Current = Cursors.Hand;
                    }
                }
            }
        }

        private void rtb_writing2_CheckedChanged(object sender, EventArgs e)
        {
            Stream stream = null;
            StreamReader reader = null;
            try
            {
                int num = 0;
                string path = "";
                if (this.rtb_writing1.Checked)
                {
                    path = string.Concat(new object[] { Application.StartupPath, @"\users\", USERNAME, @"\", this.TPONO, @"\Write1.txt" });
                }
                else
                {
                    path = string.Concat(new object[] { Application.StartupPath, @"\users\", USERNAME, @"\", this.TPONO, @"\Write2.txt" });
                }
                stream = File.Open(path, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream);
                while (!reader.EndOfStream)
                {
                    num++;
                    this.rtb_writinganswers.Text = reader.ReadToEnd();
                }
                if (reader != null)
                {
                    reader.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
            catch (Exception)
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        private void RtbAnswers_TextChanged(object sender, EventArgs e)
        {
            RichTextBox box = (RichTextBox) sender;
            int num = box.GetPositionFromCharIndex(box.TextLength - 1).Y - box.GetPositionFromCharIndex(0).Y;
            box.Height = num + 20;
        }

        private void RtbSumSelected_Click(object sender, EventArgs e)
        {
            int num2;
            RichTextBox box = (RichTextBox) sender;
            string name = box.Name;
            int num = Convert.ToInt16(name.Substring(name.Length - 1));
            if ((this.SummarySelectedAnswerIndex != num) && (box.TextLength < 4))
            {
                this.SummarySelectedAnswerIndex = num;
                box.BackColor = Color.Tan;
                if (this.RtbPreviousSelected != null)
                {
                    this.RtbPreviousSelected.BackColor = Color.LightGray;
                }
                this.RtbPreviousSelected = box;
            }
            if (this.SummarySelectedAnswerIndex != -1)
            {
                for (num2 = 0; num2 < 10; num2++)
                {
                    this.CkbSummary[num2].Enabled = true;
                }
            }
            else
            {
                for (num2 = 0; num2 < 10; num2++)
                {
                    this.CkbSummary[num2].Enabled = false;
                }
            }
        }

        private void SaveUserAnswers()
        {
            Question question;
            int num;
            int count;
            bool flag;
            int num3;
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    if (this.QuestionNO > 0)
                    {
                        question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
                        question.UserAnswers = new ArrayList();
                        if (question.QuestionType != QuestionType.SUMMARY)
                        {
                            if (question.QuestionType == QuestionType.TABEL)
                            {
                                count = question.ColStrs.Count;
                                flag = false;
                                for (num = 0; num < question.RowStrs.Count; num++)
                                {
                                    flag = false;
                                    num3 = 0;
                                    while (num3 < question.ColStrs.Count)
                                    {
                                        if (this.LCkbTable[num][num3].Checked)
                                        {
                                            flag = true;
                                            question.UserAnswers.Add(num3 + 1);
                                            break;
                                        }
                                        num3++;
                                    }
                                    if (!flag)
                                    {
                                        question.UserAnswers.Add(count + 1);
                                    }
                                }
                            }
                            else
                            {
                                for (num = 0; num < this.CkbReading.Length; num++)
                                {
                                    if (this.CkbReading[num].Checked)
                                    {
                                        question.UserAnswers.Add(num + 1);
                                    }
                                }
                            }
                            break;
                        }
                        num = 0;
                        while (num < question.RightAnswers.Length)
                        {
                            question.UserAnswers.Add(this.SummarySelectedAnswers[num]);
                            num++;
                        }
                    }
                    break;

                case TestingSection.LISTENING:
                    if (this.QuestionNO > 0)
                    {
                        question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
                        question.UserAnswers = new ArrayList();
                        if (question.QuestionType != QuestionType.SORT)
                        {
                            if (question.QuestionType == QuestionType.TABEL)
                            {
                                count = question.ColStrs.Count;
                                flag = false;
                                for (num = 0; num < question.RowStrs.Count; num++)
                                {
                                    flag = false;
                                    for (num3 = 0; num3 < question.ColStrs.Count; num3++)
                                    {
                                        if (this.LCkbTable[num][num3].Checked)
                                        {
                                            flag = true;
                                            question.UserAnswers.Add(num3 + 1);
                                            break;
                                        }
                                    }
                                    if (!flag)
                                    {
                                        question.UserAnswers.Add(count + 1);
                                    }
                                }
                            }
                            else
                            {
                                for (num = 0; num < this.LCkbAnswers.Length; num++)
                                {
                                    if (this.LCkbAnswers[num].Checked)
                                    {
                                        question.UserAnswers.Add(num + 1);
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (num = 0; num < question.RightAnswers.Length; num++)
                            {
                                question.UserAnswers.Add(this.SummarySelectedAnswers[num]);
                            }
                        }
                    }
                    this.WriteAnswersToFile("Listening.txt");
                    return;

                default:
                    return;
            }
            this.WriteAnswersToFile("Reading" + this.PartNO + ".txt");
        }

        private string scoreReport(int type)
        {
            Question question = null;
            XMLFileReader reader = new XMLFileReader(@"Tests\Direction\Scoring.xml");
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            for (int i = 0; i < this.TestQuestions.Questions.Count; i++)
            {
                question = (Question) this.TestQuestions.Questions[i];
                if (question.UserAnswersStr.Equals(question.RightAnswersStr))
                {
                    num4 += question.Score;
                    num++;
                }
                else if (question.UserAnswersStr.Equals(""))
                {
                    num3++;
                }
                else
                {
                    num2++;
                }
            }
            string str = "";
            if (type == 1)
            {
                this.IBTScore = int.Parse(reader.GetAttr("//ScoreSections//Section[@NO=2]//Score[@TestScore='" + num4 + "']//@IBTScore"));
                return string.Concat(new object[] { "Your score is (total score): ", num4, "         Your standard score is (in 30 scores): ", this.IBTScore, "\nRight answered: ", num, "      Wrong answered: ", num2, "      Not answered: ", num3 });
            }
            if (type == 2)
            {
                this.RightAnsweredQuestions = num;
                this.WrongAnsweredQuestions = num2;
                this.NotAnsweredQuestions = num3;
                this.TotalQuestions = this.QuestionCount;
                this.TotalScore = num4;
                return str;
            }
            if (type != 3)
            {
                return str;
            }
            int num6 = this.RightAnsweredQuestions + num;
            int num7 = this.WrongAnsweredQuestions + num2;
            int num8 = this.NotAnsweredQuestions + num3;
            int num9 = this.TotalQuestions + this.QuestionCount;
            int num10 = this.TotalScore + num4;
            if (this.TestSection == TestingSection.READING)
            {
                this.IBTScore = int.Parse(reader.GetAttr("//ScoreSections//Section[@NO=1]//Score[@TestScore='" + num10 + "']//@IBTScore"));
            }
            else
            {
                this.IBTScore = int.Parse(reader.GetAttr("//ScoreSections//Section[@NO=2]//Score[@TestScore='" + num10 + "']//@IBTScore"));
            }
            return string.Concat(new object[] { "Your score is (total score): ", num10, "         Your standard score is (in 30 scores): ", this.IBTScore, "\nRight answered: ", num6, "      Wrong answered: ", num7, "      Not answered: ", num8, "      Total question count: ", num9 });
        }

        private void Sound_icon_MouseClick(object sender, MouseEventArgs e)
        {
            base.tb_sound.Visible = !base.tb_sound.Visible;
        }

        private void tab_speakinganswers_Click(object sender, EventArgs e)
        {
            string str = string.Concat(new object[] { Application.StartupPath, @"\users\", USERNAME, @"\", this.TPONO });
            if (File.Exists(str + @"\SpeakingAnswer1.wav"))
            {
                this.btn_speakinganswer1.BackgroundImage = Image.FromFile(@"Tests\Direction\horn.jpg");
            }
            else
            {
                this.btn_speakinganswer1.BackgroundImage = Image.FromFile(@"Tests\Direction\horn1.jpg");
            }
            if (File.Exists(str + @"\SpeakingAnswer2.wav"))
            {
                this.btn_speakinganswer2.BackgroundImage = Image.FromFile(@"Tests\Direction\horn.jpg");
            }
            else
            {
                this.btn_speakinganswer2.BackgroundImage = Image.FromFile(@"Tests\Direction\horn1.jpg");
            }
            if (File.Exists(str + @"\SpeakingAnswer3.wav"))
            {
                this.btn_speakinganswer3.BackgroundImage = Image.FromFile(@"Tests\Direction\horn.jpg");
            }
            else
            {
                this.btn_speakinganswer3.BackgroundImage = Image.FromFile(@"Tests\Direction\horn1.jpg");
            }
            if (File.Exists(str + @"\SpeakingAnswer4.wav"))
            {
                this.btn_speakinganswer4.BackgroundImage = Image.FromFile(@"Tests\Direction\horn.jpg");
            }
            else
            {
                this.btn_speakinganswer4.BackgroundImage = Image.FromFile(@"Tests\Direction\horn1.jpg");
            }
            if (File.Exists(str + @"\SpeakingAnswer5.wav"))
            {
                this.btn_speakinganswer5.BackgroundImage = Image.FromFile(@"Tests\Direction\horn.jpg");
            }
            else
            {
                this.btn_speakinganswer5.BackgroundImage = Image.FromFile(@"Tests\Direction\horn1.jpg");
            }
            if (File.Exists(str + @"\SpeakingAnswer6.wav"))
            {
                this.btn_speakinganswer6.BackgroundImage = Image.FromFile(@"Tests\Direction\horn.jpg");
            }
            else
            {
                this.btn_speakinganswer6.BackgroundImage = Image.FromFile(@"Tests\Direction\horn1.jpg");
            }
        }

        private void tab_speakinganswers_Leave(object sender, EventArgs e)
        {
            this.MP3Player.StopT();
            this.MP3Player = new MP3MCI();
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush brush;
            Graphics graphics = e.Graphics;
            TabControl control = (TabControl) sender;
            TabPage page = control.TabPages[e.Index];
            Rectangle tabRect = control.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                brush = new SolidBrush(Color.Red);
                graphics.FillRectangle(Brushes.Gray, e.Bounds);
                brush = new SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            else
            {
                brush = new SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            Font font = new Font("Arial", 0f, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            graphics.DrawString(page.Text, font, brush, tabRect, new StringFormat(format));
        }

        private void tb_currentpos_Scroll(object sender, EventArgs e)
        {
            this.MP3Player.SetPlayTime((long) (this.tb_currentpos.Value * 0x3e8));
        }

        private void tb_currentpos1_Scroll(object sender, EventArgs e)
        {
            this.MP3Player.SetPlayTime((long) (this.tb_currentpos1.Value * 0x3e8));
        }

        private void tb_reading_Scroll(object sender, EventArgs e)
        {
            this.MP3Player.SetPlayTime((long) (this.tb_reading.Value * 0x3e8));
        }

        private void tb_sound_Scroll(object sender, EventArgs e)
        {
            this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
        }

        private void Timer_Listening_Tick(object sender, EventArgs e)
        {
            DateTime time6;
            TimeSpan span;
            this.Timer_Listening.Interval = 0x3e8;
            int currentPosition = 0;
            if (this.TestSection == TestingSection.LISTENING)
            {
                currentPosition = this.MP3Player.CurrentPosition;
            }
            this.tb_currentpos.Value = currentPosition;
            this.pb_currentpos.Value = currentPosition;
            this.tb_currentpos1.Value = currentPosition;
            this.pb_currentpos1.Value = currentPosition;
            DateTime time = DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null);
            if (time < DateTime.ParseExact("00:01", "mm:ss", null))
            {
                this.Timer_Listening.Stop();
                this.SaveUserAnswers();
                if (this.TestSection == TestingSection.LISTENING)
                {
                    MessageBox.Show("Time over!", "Warning", MessageBoxButtons.OK);
                    this.PartNO++;
                    if (this.PartNO > this.PartCount)
                    {
                        this.PartNO = 0;
                        this.PassageNO = 0;
                        this.QuestionNO = 0;
                        this.TestSection = TestingSection.SPEAKING;
                        this.btn_LoadTest_Click(new Button(), e);
                    }
                    else
                    {
                        this.scoreReport(2);
                        this.PassageNO = 4;
                        this.QuestionNO = 0x11;
                        this.btn_LoadTest_Click(new Button(), e);
                    }
                    return;
                }
                if (this.TestSection == TestingSection.READING)
                {
                    MessageBox.Show("Time over!", "Warning", MessageBoxButtons.OK);
                    this.PassageNO++;
                    if (this.PassageNO <= this.PassageCount)
                    {
                        this.scoreReport(2);
                        this.PreInsertPosition = -1;
                        XMLFileReader reader = new XMLFileReader(@"Tests\" + this.TPONO + @"\Reading\config.xml");
                        this.RSpiltQuestionNO = int.Parse(reader.GetAttr("//Passage[@NO=" + this.PassageNO + "]/@spiltQuestionNO"));
                        base.lbl_timeremain.Text = reader.GetAttr("//Passage[@NO=" + this.PassageNO + "]/@time");
                        this.tabf_test.SelectedIndex = READING;
                        this.tabf_Reading.SelectedIndex = RDIRECTION;
                        this.QuestionNO = 0;
                        this.RMaterial = new TPOPassage(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\" + this.PassageNO.ToString() + ".txt").Substring(0xb5), RtfReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\P" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
                        if (File.Exists(@"Explanations\" + this.TPONO.ToString() + @"\Reading\" + this.ReadingPassageNo.ToString() + ".mp3") && ConstantValues.TPOEXPLANATION[this.TPONO])
                        {
                            this.bn_readText.Visible = true;
                            this.bn_readText.Enabled = true;
                        }
                        else
                        {
                            this.bn_readText.Visible = false;
                        }
                        this.TestQuestions = new TPOQuestions(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\questions" + this.PassageNO.ToString() + ".txt").Substring(0xb5), "", RtfReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\Q" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
                        this.QuestionCount = this.TestQuestions.QuestionCount;
                        this.LoadReadingMaterialAndQA();
                    }
                    else
                    {
                        int num2 = this.TPONO % 10;
                        if (num2 == 0)
                        {
                            num2 = 10;
                        }
                        this.btn_LoadTest_Click(this.BtnLoadTest[10 + num2], e);
                        this.PartNO = 1;
                        this.PassageNO = 1;
                        this.QuestionNO = 0;
                    }
                }
            }
            if (time < DateTime.ParseExact("05:00", "mm:ss", null))
            {
                base.button1.Visible = false;
                base.lbl_timeremain.Visible = true;
                this.flash_timer.Start();
            }
            if (time < DateTime.ParseExact("04:45", "mm:ss", null))
            {
                this.flash_timer.Stop();
                base.lbl_timeremain.ForeColor = Color.Red;
            }
            if (this.TestSection == TestingSection.LISTENING)
            {
                int num4;
                if (this.IsPassageMP3)
                {
                    if (this.rb_PracticeMode.Checked)
                    {
                        this.ckb_viewSpeakingText.Visible = true;
                    }
                    int length = this.SPictureTimeLines.Length;
                    DateTime time2 = DateTime.ParseExact(this.MP3Player.CurrentPosStr, "mm:ss", null);
                    if (length == 1)
                    {
                        this.pb_ListenScene.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[0]);
                        this.pb_ListenScene1.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[0]);
                    }
                    else
                    {
                        for (num4 = 1; num4 < length; num4++)
                        {
                            DateTime time3 = DateTime.ParseExact(this.SPictureTimeLines[num4 - 1], "mm:ss", null);
                            DateTime time4 = DateTime.ParseExact(this.SPictureTimeLines[num4], "mm:ss", null);
                            if ((time3 <= time2) && (time2 <= time4))
                            {
                                this.pb_ListenScene.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[num4 - 1]);
                                this.pb_ListenScene1.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[num4 - 1]);
                            }
                        }
                        DateTime time5 = DateTime.ParseExact(this.SPictureTimeLines[length - 1], "mm:ss", null);
                        if (time2 > time5)
                        {
                            this.pb_ListenScene.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[length - 1]);
                            this.pb_ListenScene1.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[length - 1]);
                        }
                    }
                }
                else
                {
                    this.ckb_viewSpeakingText.Visible = false;
                }
                if (this.rb_TestMode.Checked && ((this.MP3Player.CurrentPosition + 1) < this.MP3Player.Duration))
                {
                    base.btn_preQuestion.Enabled = false;
                    base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/ok.jpg");
                }
                if (this.MP3Player.CurrentPosition < this.MP3Player.Duration)
                {
                    this.ckb_ShowAnswer.Visible = false;
                }
                else
                {
                    if (!this.HasClickedNext)
                    {
                        base.btn_nextQuestion.Enabled = true;
                        base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next1.jpg");
                    }
                    if (this.rb_PracticeMode.Checked)
                    {
                        this.ckb_ShowAnswer.Visible = true;
                    }
                    if (this.QuestionNO > 0)
                    {
                        time6 = DateTime.ParseExact("00:01", "mm:ss", null);
                        span = (TimeSpan) (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time6);
                        base.lbl_timeremain.Text = span.Minutes.ToString().PadLeft(2, '0') + ":" + span.Seconds.ToString().PadLeft(2, '0');
                    }
                    if (this.QuestionNO >= 1)
                    {
                        Question question = (Question) this.TestQuestions.Questions[this.QuestionNO - 1];
                        switch (question.QuestionType)
                        {
                            case QuestionType.TABEL:
                                if (!this.ckb_ShowAnswer.Checked)
                                {
                                    this.lbl_tableAnswer.Visible = false;
                                    break;
                                }
                                this.lbl_tableAnswer.Visible = true;
                                this.lbl_tableAnswer.Text = question.RightAnswersStr;
                                break;

                            case QuestionType.SORT:
                                if (question.QuestionType == QuestionType.SORT)
                                {
                                    this.rtb_sumQuestion.Rtf = question.QuestionTitle;
                                    this.rtb_sumQuestion.Visible = true;
                                    num4 = 0;
                                    while ((num4 < question.Answers.Length) && (num4 < this.CkbSummary.Length))
                                    {
                                        this.RtbSumAnswersToBeSelected[num4].Visible = true;
                                        this.CkbSummary[num4].Visible = true;
                                        this.RtbSumAnswersToBeSelected[num4].Rtf = question.Answers[num4];
                                        num4++;
                                    }
                                    for (num4 = 0; num4 < question.RightAnswers.Length; num4++)
                                    {
                                        this.RtbSumSelected[num4].Visible = true;
                                    }
                                    this.Timer_Listening.Stop();
                                }
                                break;

                            default:
                                for (num4 = 0; (num4 < question.Answers.Length) && (num4 < this.CkbReading.Length); num4++)
                                {
                                    this.LRtbAnswers[num4].Visible = true;
                                    this.LCkbAnswers[num4].Visible = true;
                                    this.LRtbAnswers[num4].Rtf = question.Answers[num4];
                                }
                                break;
                        }
                        if (this.IsQuestionAfter)
                        {
                            this.tabf_Listening.SelectedIndex = LQUESTIONS;
                            this.LoadListeningQA();
                            this.IsQuestionAfter = false;
                        }
                    }
                }
            }
            if ((this.TestSection == TestingSection.READING) && (this.CurrentReadingStep >= 1))
            {
                time6 = DateTime.ParseExact("00:01", "mm:ss", null);
                span = (TimeSpan) (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time6);
                base.lbl_timeremain.Text = span.Minutes.ToString().PadLeft(2, '0') + ":" + span.Seconds.ToString().PadLeft(2, '0');
            }
        }

        private void Timer_reading_Tick(object sender, EventArgs e)
        {
            this.tb_reading.Value = this.MP3Player.CurrentPosition;
            if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
            {
                this.bn_readText.Enabled = true;
                this.bn_readText.Enabled = true;
                this.btn_stopReading.Visible = false;
                this.tb_reading.Visible = false;
                this.Timer_reading.Stop();
            }
        }

        private void Timer_Speaking_Tick(object sender, EventArgs e)
        {
            DateTime time = new DateTime();
            DateTime time2 = new DateTime();
            TimeSpan span = new TimeSpan();
            DateTime time3 = new DateTime();
            string str = "";
            if (this.TestSection != TestingSection.SPEAKING)
            {
                if (this.TestSection == TestingSection.WRITING)
                {
                    switch (this.CurrentWritingStep)
                    {
                        case 0:
                            if (!this.HasLoadMP3)
                            {
                                try
                                {
                                    this.tabf_test.SelectedIndex = WRITING;
                                    this.tabf_writing.SelectedIndex = WDIRECTION;
                                    this.MP3Player = new MP3MCI();
                                    str = @"Tests\Direction\writeA1.mp3";
                                    this.MP3Player.FileName = str;
                                    this.MP3Player.play();
                                    this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                    this.HasLoadMP3 = true;
                                }
                                catch
                                {
                                }
                            }
                            if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                            {
                                this.CurrentWritingStep = 1;
                                this.HasLoadMP3 = false;
                            }
                            break;

                        case 1:
                            if (!this.HasLoadMP3)
                            {
                                try
                                {
                                    base.btn_nextQuestion.Enabled = true;
                                    base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next1.jpg");
                                    this.tabf_test.SelectedIndex = WRITING;
                                    this.tabf_writing.SelectedIndex = WSPEECH;
                                    this.MP3Player = new MP3MCI();
                                    str = @"Tests\Direction\writeA2.mp3";
                                    this.MP3Player.FileName = str;
                                    this.MP3Player.play();
                                    this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                    this.pb_writingScene.Load(Application.StartupPath + @"\Tests\images\WaitPerson.jpg");
                                    this.wpb_speak.Maximum = this.MP3Player.Duration;
                                    this.wtb_speak.Maximum = this.MP3Player.Duration;
                                    this.HasLoadMP3 = true;
                                }
                                catch
                                {
                                }
                            }
                            this.wpb_speak.Value = this.MP3Player.CurrentPosition;
                            this.wtb_speak.Value = this.MP3Player.CurrentPosition;
                            if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                            {
                                this.CurrentWritingStep = 2;
                                this.HasLoadMP3 = false;
                            }
                            break;

                        case 2:
                            if (!this.HasLoadMP3)
                            {
                                base.btn_nextQuestion.Enabled = true;
                                base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next1.jpg");
                                base.btn_preQuestion.Enabled = false;
                                base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back.jpg");
                                this.MP3Player.StopT();
                                this.tabf_test.SelectedIndex = WRITING;
                                this.tabf_writing.SelectedIndex = WINDEPENDENT;
                                this.wrtb_writing2.ReadOnly = true;
                                this.wrtbQuestion2.Rtf = this.WritingQuestions[0];
                                base.lbl_timeremain.Text = "03:00";
                                base.lbl_timeremain.ForeColor = SystemColors.ControlText;
                                this.HasLoadMP3 = true;
                            }
                            time = DateTime.ParseExact("00:01", "mm:ss", null);
                            span = (TimeSpan) (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
                            base.lbl_timeremain.Text = span.Minutes.ToString().PadLeft(2, '0') + ":" + span.Seconds.ToString().PadLeft(2, '0');
                            if (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) <= DateTime.ParseExact("00:00", "mm:ss", null))
                            {
                                this.CurrentWritingStep = 3;
                                this.HasLoadMP3 = false;
                            }
                            break;

                        case 3:
                            if (!this.HasLoadMP3)
                            {
                                try
                                {
                                    if (this.rb_PracticeMode.Checked)
                                    {
                                        base.btn_preQuestion.Enabled = true;
                                        base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back1.jpg");
                                    }
                                    base.btn_nextQuestion.Enabled = true;
                                    base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next1.jpg");
                                    this.tabf_test.SelectedIndex = WRITING;
                                    this.tabf_writing.SelectedIndex = WSPEECH;
                                    this.MP3Player = new MP3MCI();
                                    base.lbl_timeremain.Text = "20:00";
                                    base.lbl_timeremain.ForeColor = SystemColors.ControlText;
                                    str = @"Tests\" + this.TPONO + @"\Writing\Speech.mp3";
                                    this.MP3Player.FileName = str;
                                    this.MP3Player.play();
                                    this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                    this.wpb_speak.Maximum = this.MP3Player.Duration;
                                    this.wtb_speak.Maximum = this.MP3Player.Duration;
                                    this.pb_writingScene.Load(Application.StartupPath + @"\Tests\images\write" + this.TPONO.ToString() + ".jpg");
                                    this.HasLoadMP3 = true;
                                }
                                catch
                                {
                                    MessageBox.Show("open" + str + "出错!");
                                }
                            }
                            this.wpb_speak.Value = this.MP3Player.CurrentPosition;
                            this.wtb_speak.Value = this.MP3Player.CurrentPosition;
                            if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                            {
                                this.CurrentWritingStep = 4;
                                this.HasLoadMP3 = false;
                            }
                            break;

                        case 4:
                            if (!this.HasLoadMP3)
                            {
                                try
                                {
                                    if (this.rb_PracticeMode.Checked)
                                    {
                                        base.btn_preQuestion.Enabled = true;
                                        base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back1.jpg");
                                    }
                                    base.btn_nextQuestion.Enabled = true;
                                    base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next1.jpg");
                                    this.tabf_test.SelectedIndex = WRITING;
                                    this.tabf_writing.SelectedIndex = WINDEPENDENT;
                                    this.MP3Player = new MP3MCI();
                                    str = @"Tests\Direction\writeA3.mp3";
                                    this.MP3Player.FileName = str;
                                    this.MP3Player.play();
                                    this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                    this.wrtb_writing2.ReadOnly = false;
                                    this.HasLoadMP3 = true;
                                }
                                catch
                                {
                                    MessageBox.Show("open" + str + "出错!");
                                }
                            }
                            this.wpb_speak.Value = this.MP3Player.CurrentPosition;
                            this.wtb_speak.Value = this.MP3Player.CurrentPosition;
                            if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                            {
                                this.CurrentWritingStep = 5;
                                this.HasLoadMP3 = false;
                            }
                            break;

                        case 5:
                            if (!this.HasLoadMP3)
                            {
                                if (this.rb_PracticeMode.Checked)
                                {
                                    base.btn_preQuestion.Enabled = true;
                                    base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back1.jpg");
                                }
                                base.btn_nextQuestion.Enabled = true;
                                base.btn_nextQuestion.BackgroundImage = Image.FromFile("Tests/Direction/next1.jpg");
                                this.MP3Player.StopT();
                                this.tabf_test.SelectedIndex = WRITING;
                                this.tabf_writing.SelectedIndex = WINDEPENDENT;
                                base.lbl_questionNO.Text = "Question 1 of 2";
                                this.wrtbQuestion2.Rtf = this.WritingQuestions[0];
                                this.wrtb_writing2.ReadOnly = false;
                                this.lbl_writeDirection.Text = "Directions: You have 20 minutes to plan and write your response. Your response will be judged on the basis of the quality of your writing and on how well your response presents in the lecture and their relationship to the reading passage. Typically, an effective response will be 150 to 225 words.\n Question: Summarize the points made in the lecture, being sure to explain how they cast doubt on specific points made in the reading passage.";
                                base.lbl_timeremain.Text = "20:00";
                                base.lbl_timeremain.ForeColor = SystemColors.ControlText;
                                this.HasLoadMP3 = true;
                            }
                            time = DateTime.ParseExact("00:01", "mm:ss", null);
                            span = (TimeSpan) (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
                            base.lbl_timeremain.Text = span.Minutes.ToString().PadLeft(2, '0') + ":" + span.Seconds.ToString().PadLeft(2, '0');
                            time3 = DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null);
                            this.WriteWritingAnswers("write1.txt", this.wrtb_writing2.Text);
                            if (time3 <= DateTime.ParseExact("00:00", "mm:ss", null))
                            {
                                this.Timer_Speaking.Stop();
                                if (MessageBox.Show("Time over", "Warning", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    this.Timer_Speaking.Start();
                                }
                                this.CurrentWritingStep = 6;
                                this.HasLoadMP3 = false;
                            }
                            break;

                        case 6:
                            if (!this.HasLoadMP3)
                            {
                                this.MP3Player.StopT();
                                if (this.rb_PracticeMode.Checked)
                                {
                                    base.btn_preQuestion.Enabled = true;
                                    base.btn_preQuestion.BackgroundImage = Image.FromFile("Tests/Direction/back1.jpg");
                                }
                                this.WriteWritingAnswers("write1.txt", this.wrtb_writing2.Text);
                                this.tabf_test.SelectedIndex = WRITING;
                                this.tabf_writing.SelectedIndex = WINDEPENDENT;
                                this.lbl_writeDirection.Text = "Directions: Read the question below. You have 30 minutes to plan, write, and revise your essay. Typically, an effective response will contain a minimum of 300 words.";
                                this.wrtb_writing2.Text = "";
                                this.wrtb_writing2.ReadOnly = false;
                                this.wrtbQuestion2.Rtf = this.WritingQuestions[1];
                                base.lbl_questionNO.Text = "Question 2 of 2";
                                base.lbl_timeremain.Text = "30:00";
                                base.lbl_timeremain.ForeColor = SystemColors.ControlText;
                                this.HasLoadMP3 = true;
                            }
                            this.WriteWritingAnswers("write2.txt", this.wrtb_writing2.Text);
                            time = DateTime.ParseExact("00:01", "mm:ss", null);
                            span = (TimeSpan) (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
                            base.lbl_timeremain.Text = span.Minutes.ToString().PadLeft(2, '0') + ":" + span.Seconds.ToString().PadLeft(2, '0');
                            if (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) <= DateTime.ParseExact("00:00", "mm:ss", null))
                            {
                                this.WriteWritingAnswers("write2.txt", this.wrtb_writing2.Text);
                                this.Timer_Speaking.Stop();
                                if (MessageBox.Show("Time over", "Warning", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    this.btn_mainmenu_Click(sender, e);
                                }
                                this.CurrentWritingStep = 6;
                                this.HasLoadMP3 = false;
                            }
                            break;
                    }
                }
            }
            else
            {
                XMLFileReader reader = new XMLFileReader(@"Tests\" + this.TPONO + @"\Speaking\questions.xml");
                string attr = reader.GetAttr("//question[@NO=" + this.QuestionNO + "]/@SpeakingIntro");
                string str3 = reader.GetAttr("//question[@NO=" + this.QuestionNO + "]/@SpeakingMP3");
                string str4 = reader.GetAttr("//question[@NO=" + this.QuestionNO + "]/@ReadingMP3");
                string str5 = reader.GetAttr("//question[@NO=" + this.QuestionNO + "]/@SpeakingQuestion");
                string str6 = reader.GetAttr("//question[@NO=" + this.QuestionNO + "]/@BeepPrepare");
                string str7 = reader.GetAttr("//question[@NO=" + this.QuestionNO + "]/@BeepSpeak");
                switch (this.CurrentSpeakingStep)
                {
                    case 0:
                        if (!this.HasLoadMP3)
                        {
                            try
                            {
                                this.tabf_test.SelectedIndex = SPEAKING;
                                this.tabf_speaking.SelectedIndex = SDIRECTION;
                                this.MP3Player = new MP3MCI();
                                str = @"Tests\Direction\Speaking_Introduction.mp3";
                                this.MP3Player.FileName = str;
                                this.MP3Player.play();
                                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                this.HasLoadMP3 = true;
                                this.srtb_introduction.Rtf = this.SpeakingQuestions[this.QuestionNO - 1].ToString();
                                this.srtb_introduction.Visible = true;
                                this.srtb_timeindicator.Visible = false;
                                this.srtb_timer.Visible = false;
                                this.spb.Visible = false;
                            }
                            catch
                            {
                                MessageBox.Show("open" + str + "出错!");
                            }
                        }
                        if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                        {
                            this.CurrentSpeakingStep = 1;
                            this.HasLoadMP3 = false;
                        }
                        break;

                    case 1:
                        if (this.CONTINUECLICKED)
                        {
                            if (!this.HasLoadMP3)
                            {
                                try
                                {
                                    this.pb_speakingScene.Load(Application.StartupPath + @"\Tests\images\WaitPerson.jpg");
                                    base.lbl_questionNO.Text = "Question " + this.QuestionNO + " of 6";
                                    this.tabf_test.SelectedIndex = SPEAKING;
                                    this.tabf_speaking.SelectedIndex = SQUESTION;
                                    this.pb_speakingScene.Visible = true;
                                    this.srtb_introduction.Visible = false;
                                    this.MP3Player = new MP3MCI();
                                    str = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Speaking\", attr });
                                    this.MP3Player.FileName = str;
                                    this.MP3Player.play();
                                    this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                    this.srtb_timeindicator.Visible = false;
                                    this.srtb_timer.Visible = false;
                                    this.spb.Visible = false;
                                    this.HasLoadMP3 = true;
                                }
                                catch
                                {
                                    MessageBox.Show("open" + str + "出错!");
                                }
                            }
                            if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                            {
                                if ((((this.QuestionNO == 1) || (this.QuestionNO == 2)) || (this.QuestionNO == 5)) || (this.QuestionNO == 6))
                                {
                                    this.CurrentSpeakingStep = 4;
                                }
                                else if ((this.QuestionNO == 3) || (this.QuestionNO == 4))
                                {
                                    this.CurrentSpeakingStep = 2;
                                }
                                this.HasLoadMP3 = false;
                            }
                        }
                        break;

                    case 2:
                        if (!this.HasLoadMP3)
                        {
                            try
                            {
                                this.tabf_test.SelectedIndex = SPEAKING;
                                this.tabf_speaking.SelectedIndex = SQUESTION;
                                this.MP3Player = new MP3MCI();
                                str = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Speaking\", str4 });
                                this.MP3Player.FileName = str;
                                this.MP3Player.play();
                                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                this.pb_speakingScene.Visible = false;
                                base.lbl_timeremain.Text = "00:45";
                                this.srtb_timeindicator.Text = "READING TIME";
                                this.srtb_introduction.Rtf = this.SReadingMaterials[this.QuestionNO - 3];
                                this.srtb_timer.Text = "00:" + base.lbl_timeremain.Text;
                                this.srtb_introduction.Visible = true;
                                this.srtb_timeindicator.Visible = true;
                                this.srtb_timer.Visible = true;
                                this.spb.Visible = false;
                                this.HasLoadMP3 = true;
                            }
                            catch
                            {
                                MessageBox.Show("open" + str + "出错!");
                            }
                        }
                        if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                        {
                            this.CurrentSpeakingStep = 3;
                            this.HasLoadMP3 = false;
                        }
                        break;

                    case 3:
                        if (!this.HasLoadMP3)
                        {
                            this.tabf_test.SelectedIndex = SPEAKING;
                            this.tabf_speaking.SelectedIndex = SQUESTION;
                            this.srtb_introduction.Rtf = this.SReadingMaterials[this.QuestionNO - 3];
                            this.srtb_introduction.Visible = true;
                            this.pb_speakingScene.Visible = false;
                            base.lbl_timeremain.Text = "00:45";
                            this.srtb_timeindicator.Text = "READING TIME";
                            this.srtb_timer.Text = "00:" + base.lbl_timeremain.Text;
                            this.srtb_timeindicator.Visible = true;
                            this.srtb_timer.Visible = true;
                            this.spb.Visible = false;
                            this.HasLoadMP3 = true;
                        }
                        time = DateTime.ParseExact("00:01", "mm:ss", null);
                        span = (TimeSpan) (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
                        base.lbl_timeremain.Text = span.Minutes.ToString().PadLeft(2, '0') + ":" + span.Seconds.ToString().PadLeft(2, '0');
                        this.srtb_timeindicator.Text = "READING TIME";
                        this.srtb_timer.Text = "00:" + base.lbl_timeremain.Text;
                        if (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) <= DateTime.ParseExact("00:00", "mm:ss", null))
                        {
                            this.CurrentSpeakingStep = 4;
                            this.HasLoadMP3 = false;
                        }
                        break;

                    case 4:
                        if (!this.HasLoadMP3)
                        {
                            try
                            {
                                this.tabf_test.SelectedIndex = SPEAKING;
                                this.tabf_speaking.SelectedIndex = SQUESTION;
                                this.MP3Player = new MP3MCI();
                                str = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Speaking\", str3 });
                                this.MP3Player.FileName = str;
                                this.MP3Player.play();
                                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                this.spb.Maximum = this.MP3Player.Duration;
                                if (this.QuestionNO > 2)
                                {
                                    this.spb.Visible = true;
                                }
                                else
                                {
                                    this.spb.Visible = false;
                                }
                                this.srtb_introduction.Rtf = this.SpeakingQuestions[this.QuestionNO - 1];
                                if ((this.QuestionNO == 1) || (this.QuestionNO == 2))
                                {
                                    this.srtb_introduction.Visible = true;
                                    this.pb_speakingScene.Visible = false;
                                }
                                else
                                {
                                    this.srtb_introduction.Visible = false;
                                    this.pb_speakingScene.Load(string.Concat(new object[] { Application.StartupPath, @"\Tests\images\speak", this.QuestionNO, ".jpg" }));
                                    this.srtb_timeindicator.Visible = false;
                                    this.srtb_timer.Visible = false;
                                    this.pb_speakingScene.Visible = true;
                                }
                                this.HasLoadMP3 = true;
                            }
                            catch
                            {
                                MessageBox.Show("open" + str + "出错!");
                            }
                        }
                        this.spb.Value = this.MP3Player.CurrentPosition;
                        if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                        {
                            if ((this.QuestionNO == 1) || (this.QuestionNO == 2))
                            {
                                this.CurrentSpeakingStep = 6;
                                this.spb.Visible = false;
                                base.lbl_timeremain.Text = "00:15";
                                this.srtb_timeindicator.Text = "PREPARATION TIME";
                                this.srtb_timeindicator.Visible = true;
                                this.srtb_timer.Text = "00:" + base.lbl_timeremain.Text;
                                this.srtb_timer.Visible = true;
                            }
                            else
                            {
                                this.CurrentSpeakingStep = 5;
                            }
                            this.HasLoadMP3 = false;
                        }
                        break;

                    case 5:
                        if (!this.HasLoadMP3)
                        {
                            try
                            {
                                this.tabf_test.SelectedIndex = SPEAKING;
                                this.tabf_speaking.SelectedIndex = SQUESTION;
                                this.MP3Player = new MP3MCI();
                                str = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Speaking\", str5 });
                                this.spb.Visible = false;
                                this.MP3Player.FileName = str;
                                this.MP3Player.play();
                                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                this.srtb_introduction.Rtf = this.SpeakingQuestions[this.QuestionNO - 1];
                                this.srtb_introduction.Visible = true;
                                this.pb_speakingScene.Visible = false;
                                if ((this.QuestionNO == 3) || (this.QuestionNO == 4))
                                {
                                    base.lbl_timeremain.Text = "00:30";
                                }
                                else
                                {
                                    base.lbl_timeremain.Text = "00:20";
                                }
                                this.srtb_timeindicator.Text = "PREPARATION TIME";
                                this.srtb_timeindicator.Visible = true;
                                this.srtb_timer.Text = "00:" + base.lbl_timeremain.Text;
                                this.srtb_timer.Visible = true;
                                this.HasLoadMP3 = true;
                            }
                            catch
                            {
                                MessageBox.Show("open" + str + "出错!");
                            }
                        }
                        if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                        {
                            this.CurrentSpeakingStep = 6;
                            this.HasLoadMP3 = false;
                        }
                        break;

                    case 6:
                        if (!this.HasLoadMP3)
                        {
                            try
                            {
                                this.tabf_test.SelectedIndex = SPEAKING;
                                this.tabf_speaking.SelectedIndex = SQUESTION;
                                this.MP3Player = new MP3MCI();
                                str = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Speaking\", str6 });
                                this.spb.Visible = false;
                                this.MP3Player.FileName = str;
                                this.MP3Player.play();
                                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                this.srtb_introduction.Visible = true;
                                this.pb_speakingScene.Visible = false;
                                this.HasLoadMP3 = true;
                            }
                            catch
                            {
                                MessageBox.Show("open" + str + "出错!");
                            }
                        }
                        if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                        {
                            this.CurrentSpeakingStep = 7;
                            this.HasLoadMP3 = false;
                        }
                        break;

                    case 7:
                        if (!this.HasLoadMP3)
                        {
                            this.tabf_test.SelectedIndex = SPEAKING;
                            this.tabf_speaking.SelectedIndex = SQUESTION;
                            this.srtb_introduction.Visible = true;
                            this.pb_speakingScene.Visible = false;
                            this.HasLoadMP3 = true;
                        }
                        time = DateTime.ParseExact("00:01", "mm:ss", null);
                        span = (TimeSpan) (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
                        base.lbl_timeremain.Text = span.Minutes.ToString().PadLeft(2, '0') + ":" + span.Seconds.ToString().PadLeft(2, '0');
                        this.srtb_timer.Text = "00:" + base.lbl_timeremain.Text;
                        if (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) <= DateTime.ParseExact("00:00", "mm:ss", null))
                        {
                            if ((this.QuestionNO == 1) || (this.QuestionNO == 2))
                            {
                                base.lbl_timeremain.Text = "00:45";
                            }
                            else
                            {
                                base.lbl_timeremain.Text = "01:00";
                            }
                            this.srtb_timeindicator.Visible = true;
                            this.srtb_timer.Visible = true;
                            this.srtb_timeindicator.Text = "RESPONSE TIME";
                            this.srtb_timer.Text = "00:" + base.lbl_timeremain.Text;
                            this.CurrentSpeakingStep = 8;
                            this.HasLoadMP3 = false;
                        }
                        break;

                    case 8:
                        if (!this.HasLoadMP3)
                        {
                            try
                            {
                                this.tabf_test.SelectedIndex = SPEAKING;
                                this.tabf_speaking.SelectedIndex = SQUESTION;
                                this.MP3Player = new MP3MCI();
                                str = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Speaking\", str7 });
                                this.MP3Player.FileName = str;
                                this.MP3Player.play();
                                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                this.srtb_introduction.Visible = true;
                                this.pb_speakingScene.Visible = false;
                                this.HasLoadMP3 = true;
                            }
                            catch
                            {
                                MessageBox.Show("open" + str + "出错!");
                            }
                        }
                        if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                        {
                            this.CurrentSpeakingStep = 9;
                            this.HasLoadMP3 = false;
                        }
                        break;

                    case 9:
                        if (!this.HasLoadMP3)
                        {
                            this.tabf_test.SelectedIndex = SPEAKING;
                            this.tabf_speaking.SelectedIndex = SQUESTION;
                            this.MP3Recorder = new MP3Record();
                            this.MP3Recorder.SetFilePath(string.Concat(new object[] { @"users\", USERNAME, @"\", this.TPONO, @"\SpeakingAnswer", this.QuestionNO, ".wav" }));
                            this.MP3Recorder.Start();
                            this.srtb_introduction.Visible = true;
                            this.pb_speakingScene.Visible = false;
                            this.HasLoadMP3 = true;
                        }
                        time = DateTime.ParseExact("00:01", "mm:ss", null);
                        span = (TimeSpan) (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
                        base.lbl_timeremain.Text = span.Minutes.ToString().PadLeft(2, '0') + ":" + span.Seconds.ToString().PadLeft(2, '0');
                        this.srtb_timeindicator.Visible = true;
                        this.srtb_timer.Visible = true;
                        this.srtb_timer.Text = "00:" + base.lbl_timeremain.Text;
                        if (DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) <= DateTime.ParseExact("00:00", "mm:ss", null))
                        {
                            this.CurrentSpeakingStep = 10;
                            this.MP3Recorder.Stop();
                            this.HasLoadMP3 = false;
                        }
                        break;

                    case 10:
                        if (!this.HasLoadMP3)
                        {
                            if (this.QuestionNO >= 6)
                            {
                                this.TestSection = TestingSection.WRITING;
                                this.btn_LoadTest_Click(new Button(), e);
                                break;
                            }
                            this.QuestionNO++;
                            this.CurrentSpeakingStep = 1;
                            this.srtb_introduction.Visible = false;
                            this.pb_speakingScene.Visible = true;
                            this.srtb_timeindicator.Visible = false;
                            this.srtb_timer.Visible = false;
                        }
                        break;
                }
            }
        }

        private void wbtn_cut_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Rtf, this.wrtb_writing2.SelectedRtf);
            this.wrtb_writing2.SelectedRtf = "";
        }

        private void wbtn_paste_Click(object sender, EventArgs e)
        {
            this.wrtb_writing2.Paste();
            this.wrtb_writing2.Focus();
        }

        private void wbtn_redo_Click(object sender, EventArgs e)
        {
            this.wrtb_writing2.Redo();
        }

        private void wbtn_undo_Click(object sender, EventArgs e)
        {
            this.wrtb_writing2.Undo();
        }

        private void wbtn_wordcount_Click(object sender, EventArgs e)
        {
            if (this.wlbl_wordcount.Visible)
            {
                this.wbtn_wordcount.Text = "Show Word Count";
                this.wlbl_wordcount.Visible = false;
            }
            else
            {
                this.wbtn_wordcount.Text = "Hide Word Count";
                this.wlbl_wordcount.Visible = true;
            }
        }

        private void WriteAnswersToFile(string fileName)
        {
            FileStream stream = null;
            StreamWriter writer = null;
            try
            {
                stream = new FileStream(string.Concat(new object[] { Application.StartupPath, @"\users\", USERNAME, @"\", this.TPONO, @"\", fileName }), FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(stream);
                writer.Write(string.Format("{0}{1}{2}{3}{4}\r\n", new object[] { "QuestionNo".PadRight(15), "QuestionType".PadRight(15), "YourAnswers".PadRight(15), "StandardAnswers".PadRight(15), "Score".PadRight(15) }));
                for (int i = 0; i < this.TestQuestions.QuestionCount; i++)
                {
                    Question question = (Question) this.TestQuestions.Questions[i];
                    writer.Write(string.Format("{0}{1}{2}{3}{4}\r\n", new object[] { question.ID.ToString().PadRight(15), question.QuestionType.ToString().PadRight(15), question.UserAnswersStr.ToString().PadRight(15), question.RightAnswersStr.ToString().PadRight(15), question.Score.ToString().PadRight(15) }));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        private void WriteWritingAnswers(string fileName, string answer)
        {
            FileStream stream = null;
            StreamWriter writer = null;
            try
            {
                stream = new FileStream(string.Concat(new object[] { Application.StartupPath, @"\users\", USERNAME, @"\", this.TPONO, @"\", fileName }), FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(stream);
                writer.Write(string.Format("{0}", answer));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        private void wrtb_writing2_TextChanged(object sender, EventArgs e)
        {
            MatchCollection matchs = Regex.Matches(this.wrtb_writing2.Text.ToString(), @"[a-zA-Z]+\b");
            int num = 0;
            foreach (Match match in matchs)
            {
                num++;
            }
            this.wlbl_wordcount.Text = num.ToString();
        }

        private void wtb_speak_Scroll(object sender, EventArgs e)
        {
            this.MP3Player.SetPlayTime((long) (this.wtb_speak.Value * 0x3e8));
        }
    }
}

