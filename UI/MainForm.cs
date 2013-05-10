namespace TPO.UI
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using TPO.Common;
    using TPO.Media;
    using TPO.Quiz;
    using TPO.TPOFile;
    using TPO.Utility;
    using System.Data.Common;
    using System.Data.SQLite;
    using System.Resources;
    using System.Reflection;

    public class MainForm : TestBaseForm
    {
        #region default UI interface
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
        private TabPage tab_Answers;
        private TrackBar tb_currentpos;
        private TrackBar tb_currentpos1;
        private TrackBar tb_reading;
        private int TestMode;
        private TPOTest TestQuestions;
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
        private BindingSource bindingSource_Section;
        private TabPage wWriting2;
        #endregion
        private DataGridView dgv_readingSelect;
        private DataGridView dgv_listeningSelect;

        private DbConnection dbConn;
        private BindingSource bindingSource_Set;
        private DataGridViewCheckBoxColumn isAnsweredDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn rightAnswersStrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userAnswersStrDataGridViewTextBoxColumn;
        private TPO.SQLite.SQLiteDB sqlite = new SQLite.SQLiteDB();
        private ResourceManager resmgr = new ResourceManager("Properties.Resources", Assembly.GetExecutingAssembly());

        #region event
        private event EventHandler OnClickNextButton;
        private event EventHandler OnClickPrevButton;
        #endregion event

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
            XMLReader reader = new XMLReader("license.xml");
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

        private void ButtonsStatus()
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
                    base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("OK");
                    base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
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
                        base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back");
                        base.btn_preQuestion.Visible = true;
                    }
                    else
                    {
                        base.btn_preQuestion.Enabled = false;
                        base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back");
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
                Section question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
                if ((question.QuestionType == QuestionType.SUMMARY) || (question.QuestionType == QuestionType.TABLE))
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
                base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back");
                base.btn_nextQuestion.Enabled = false;
                base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next");
            }
            else
            {
                base.btn_nextQuestion.Enabled = true;
                base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
                if (this.QuestionNO == 1)
                {
                    base.btn_preQuestion.Enabled = false;
                    base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back");
                }
                else
                {
                    base.btn_preQuestion.Enabled = true;
                    base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back1");
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
                    base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("ok1");
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
                        base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back");
                        base.btn_nextQuestion.Visible = true;
                        base.btn_nextQuestion.Enabled = true;
                        base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
                        base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back");
                        base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
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
                Button button = (Button)sender;
                string name = button.Name;
                string title = button.Text;
                switch (title)
                {
                    case "READING":
                        this.TestSection = TestingSection.READING;
                        break;
                    case "LISTENING":
                        this.TestSection = TestingSection.LISTENING;
                        break;
                    case "SPEAKING":
                        this.TestSection = TestingSection.SPEAKING;
                        break;
                    case "WRITING":
                        this.TestSection = TestingSection.WRITING;
                        break;
                    case "REVIEW":
                        this.TestSection = TestingSection.REVIEW;
                        break;
                    case "VIEWANSWERS":
                        this.TestSection = TestingSection.VIEWANSWERS;
                        break;
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

                ///不需要授权模块
                /*if (!ConstantValues.TPOACTIVED[this.TPONO])
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
                }*/
                if (!this.CheckFileConsistence())
                    return;
                base.btn_continue.Enabled = true;
                base.btn_continue.Visible = true;
                this.ButtonsStatus();
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
                XMLReader reader = new XMLReader();

                //this.tabf_test.SelectedIndex = this.
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
                        reader = new XMLReader(@"Tests\" + this.TPONO + @"\Reading\config.xml");
                        this.RSpiltQuestionNO = int.Parse(reader.GetAttr("//Passage[@NO=" + this.PassageNO + "]/@spiltQuestionNO"));
                        this.PassageCount = int.Parse(reader.GetAttr("//@passageCount"));
                        base.lbl_timeremain.Text = reader.GetAttr("//Passage[@NO=" + this.PassageNO + "]/@time");
                        this.RMaterial = new TPOPassage(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\" + this.PassageNO.ToString() + ".txt").Substring(0xb5), RtfReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\P" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
                        if (!File.Exists(@"Explanations\" + this.TPONO.ToString() + @"\Reading\" + this.ReadingPassageNo.ToString() + ".mp3") || !ConstantValues.TPOEXPLANATION[this.TPONO])
                        {
                            this.bn_readText.Visible = false;
                        }
                        this.bn_readText.Visible = true;
                        this.bn_readText.Enabled = true;
                        this.TestQuestions.AddPart(new TPOPart(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\questions" + this.PassageNO.ToString() + ".txt").Substring(0xb5), "", RtfReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\Q" + this.PassageNO.ToString() + ".txt").Substring(0xb5)));
                        //this.QuestionCount = this.TestQuestions.QuestionCount;
                        this.LoadReadingMaterialAndQA();
                        if (this.rb_PracticeMode.Checked && (MessageBox.Show("Do you want to load the answers you saved last time?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK))
                        {
                            this.LoadUserAnswer();
                        }
                        break;

                    case TestingSection.LISTENING:

                        this.lbl_testingSection.Visible = true;
                        base.btn_nextQuestion.Enabled = false;
                        base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next");
                        base.btn_preQuestion.Enabled = false;
                        base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("ok");
                        base.lbl_timeremain.ForeColor = SystemColors.ControlText;
                        base.lbl_timeremain.Text = "10:00";
                        this.lbl_testingSection.Text = "Listening Section";
                        reader = new XMLReader(@"Tests\" + this.TPONO + @"\Listening\questions.xml");
                        this.PartCount = int.Parse(reader.GetAttr("//parts/@partCount"));
                        string attr = reader.GetAttr("//passage[@NO=" + 2 + "]/pictures/picture/@pictureName");
                        base.lbl_timeremain.Text = reader.GetAttr("//part[@NO=" + this.PartNO + "]/@timeLimitation");
                        this.TimeLimitation = DateTime.ParseExact(reader.GetAttr("//part[@NO=" + this.PartNO + "]/@timeLimitation"), "mm:ss", null);
                        this.QuestionCount = int.Parse(reader.GetAttr("//part[@NO=" + this.PartNO + "]/@questionCount"));
                        //this.tabf_test.SelectedIndex = LISTENING;
                        this.tabf_Listening.SelectedIndex = LDIRECTION1;
                        if (this.PassageNO <= 1)
                        {
                            this.TestQuestions.AddPart(new TPOPart(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Listening\questions.rtf"), @"Tests\" + this.TPONO.ToString() + @"\Listening\questions.xml", ""));
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

                    case TestingSection.SPEAKING:
                        this.lbl_testingSection.Visible = true;
                        this.lbl_testingSection.Text = "Speaking Section";
                        base.btn_nextQuestion.Visible = false;
                        base.btn_preQuestion.Visible = false;
                        this.LoadSpeakingQuestion();
                        //this.tabf_test.SelectedIndex = SPEAKING;
                        this.tabf_speaking.SelectedIndex = SDIRECTION;
                        this.QuestionNO = 1;
                        this.CurrentSpeakingStep = 0;
                        this.Timer_Speaking.Start();
                        break;

                    case TestingSection.WRITING:
                        this.Timer_Listening.Start();
                        this.lbl_testingSection.Visible = true;
                        base.btn_nextQuestion.Enabled = false;
                        base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next");
                        base.lbl_timeremain.ForeColor = SystemColors.ControlText;
                        base.lbl_timeremain.Text = "03:00";
                        this.lbl_testingSection.Text = "Writing Section";
                        base.lbl_questionNO.Text = "Question 1 of 2";
                        this.LoadWritingQuestion();
                        //this.tabf_test.SelectedIndex = WRITING;
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
                        //this.tabf_test.SelectedIndex = USERANSWERS;
                        this.btn_NexPage.Visible = false;
                        this.btn_LastPage.Visible = false;
                        base.btn_mainmenu.Visible = true;
                        break;
                }

                return;

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
                    
                    break;

                case TestingSection.LISTENING:
                    
                    break;

                case TestingSection.SPEAKING:
                    base.btn_preQuestion.Enabled = true;
                    base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back1");
                    if (this.QuestionNO >= 6)
                    {
                        base.btn_nextQuestion.Enabled = false;
                        base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next");
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
                        base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next");
                        this.HasLoadMP3 = false;
                        break;
                    }
                    this.CurrentWritingStep++;
                    base.btn_nextQuestion.Enabled = false;
                    base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next");
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
                this.btn_pause.BackgroundImage = (Image)this.resmgr.GetObject("resume");
            }
            else
            {
                this.IsPause = false;
                this.MP3Player.play();
                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                this.Timer_Listening.Start();
                this.Timer_Speaking.Start();
                this.btn_pause.BackgroundImage = (Image)this.resmgr.GetObject("pause");
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


            #region too dirty
            switch (this.TestSection)
            {
                case TestingSection.READING:
                   
                    break;

                case TestingSection.LISTENING:
                    this.HasClickedNext = false;
                    base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("ok");
                    this.OnClickPrevButton(sender, e);
                    if (!this.rb_TestMode.Checked || this.HasAnswered())
                    {
                        //this.SaveUserAnswers();

                        base.btn_preQuestion.Enabled = false;
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
                            base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next");
                        }
                        break;
                    }
                    MessageBox.Show("You must answer the question!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case TestingSection.SPEAKING:
                    base.btn_nextQuestion.Enabled = true;
                    base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
                    if (this.QuestionNO > 1)
                    {
                        this.QuestionNO--;
                        this.CurrentSpeakingStep = 1;
                        this.HasLoadMP3 = false;
                    }
                    if (this.QuestionNO <= 1)
                    {
                        base.btn_preQuestion.Enabled = false;
                        base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back");
                    }
                    break;

                case TestingSection.WRITING:
                    this.CurrentWritingStep--;
                    base.btn_preQuestion.Enabled = false;
                    base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back");
                    this.HasLoadMP3 = false;
                    break;
            }
            #endregion too dirty
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
                    Section question = (Section)this.TestQuestions.Questions[i];
                    row["QuestionID"] = question.AnswerID;
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
                    row["MyAnswer"] = question.MyAnswersStr;
                    if (this.rb_PracticeMode.Checked)
                    {
                        row["StandardAnswer"] = question.CorrectAnswersStr;
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
                this.btn_ShowText.BackgroundImage = (Image)this.resmgr.GetObject("viewquestion");
            }
            else
            {
                this.btn_ShowText.BackgroundImage = (Image)this.resmgr.GetObject("viewtext");
                Section question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
                if (question.QuestionType == QuestionType.TABLE)
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
            Button button = (Button)sender;
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
                base.button1.BackgroundImage = (Image)this.resmgr.GetObject("Showtimer");
            }
            else
            {
                base.lbl_timeremain.Visible = true;
                base.button1.BackgroundImage = (Image)this.resmgr.GetObject("hidetimer");
            }
        }

        private void ChangeControlSize(Control control, double scale1, double scale2)
        {
            foreach (Control control2 in control.Controls)
            {
                control2.Top = Convert.ToInt16((double)(Convert.ToDouble(control2.Top) * scale1));
                control2.Left = Convert.ToInt16((double)(Convert.ToDouble(control2.Left) * scale2));
                if (control2.BackgroundImage == null)
                {
                    control2.Height = Convert.ToInt16((double)(Convert.ToDouble(control2.Height) * scale1));
                    control2.Width = Convert.ToInt16((double)(Convert.ToDouble(control2.Width) * scale2));
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
            Section question;
            int num;
            CheckBox ckb = (CheckBox)sender;
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    if (!ckb.Checked)
                    {
                        return;
                    }
                    question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
                    this.SaveUserAnswers();
                    if (question.CorrectAnswer.Length == 1)
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
                        question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
                        num = 0;
                        while (num < 9)
                        {
                            this.OnlyOneCheck(this.LCkbTable[num], ckb);
                            num++;
                        }
                        if (question.CorrectAnswer.Length == 1)
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
                Section question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
                if (this.TestSection != TestingSection.READING)
                {
                    goto Label_0185;
                }
                switch (question.QuestionType)
                {
                    case QuestionType.SUMMARY:
                        num = 0;
                        goto Label_00C0;

                    case QuestionType.TABLE:
                        if (!this.ckb_ShowAnswer.Checked)
                        {
                            goto Label_0109;
                        }
                        this.lbl_tableAnswer.Visible = true;
                        this.lbl_tableAnswer.Text = question.CorrectAnswersStr;
                        return;

                    default:
                        num = 0;
                        while (num < question.CorrectAnswer.Length)
                        {
                            if (this.ckb_ShowAnswer.Checked)
                            {
                                this.RtbReadingAnswers[question.CorrectAnswer[num] - 1].BackColor = Color.LightPink;
                            }
                            else
                            {
                                this.RtbReadingAnswers[question.CorrectAnswer[num] - 1].BackColor = SystemColors.ControlLight;
                            }
                            num++;
                        }
                        return;
                }
            Label_0054:
                if (this.ckb_ShowAnswer.Checked)
                {
                    this.RtbSumAnswersToBeSelected[question.CorrectAnswer[num] - 1].Visible = true;
                    this.RtbSumAnswersToBeSelected[question.CorrectAnswer[num] - 1].BackColor = Color.LightPink;
                }
                else
                {
                    this.RtbSumAnswersToBeSelected[question.CorrectAnswer[num] - 1].BackColor = SystemColors.ControlLightLight;
                }
                num++;
            Label_00C0:
                if (num < question.CorrectAnswer.Length)
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
                        case QuestionType.TABLE:
                            if (!this.ckb_ShowAnswer.Checked)
                            {
                                goto Label_0233;
                            }
                            this.lbl_tableAnswer.Visible = true;
                            this.lbl_tableAnswer.Text = question.CorrectAnswersStr;
                            return;

                        case QuestionType.SORT:
                            if (!this.ckb_ShowAnswer.Checked)
                            {
                                break;
                            }
                            this.llbl_rightAnswer.Text = question.CorrectAnswersStr;
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
                while (num < question.CorrectAnswer.Length)
                {
                    if (this.ckb_ShowAnswer.Checked)
                    {
                        this.LRtbAnswers[question.CorrectAnswer[num] - 1].BackColor = Color.LightPink;
                    }
                    else
                    {
                        this.LRtbAnswers[question.CorrectAnswer[num] - 1].BackColor = SystemColors.ControlLight;
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
            CheckBox box = (CheckBox)sender;
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
            CheckBox box = (CheckBox)sender;
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
            DataGridView view = (DataGridView)sender;
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
            Section question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
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
            else if (question.QuestionType == QuestionType.TABLE)
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openMp3File = new System.Windows.Forms.OpenFileDialog();
            this.Timer_Listening = new System.Windows.Forms.Timer(this.components);
            this.tabf_test = new System.Windows.Forms.TabControl();
            this.tab_CoverForm = new System.Windows.Forms.TabPage();
            this.tabf_tposelection = new System.Windows.Forms.TabControl();
            this.TPO10 = new System.Windows.Forms.TabPage();
            this.btn_Review10 = new System.Windows.Forms.Button();
            this.btn_Review09 = new System.Windows.Forms.Button();
            this.btn_Review08 = new System.Windows.Forms.Button();
            this.btn_Review07 = new System.Windows.Forms.Button();
            this.btn_Review06 = new System.Windows.Forms.Button();
            this.btn_Review05 = new System.Windows.Forms.Button();
            this.btn_Review04 = new System.Windows.Forms.Button();
            this.btn_Review03 = new System.Windows.Forms.Button();
            this.btn_Review02 = new System.Windows.Forms.Button();
            this.btn_Review01 = new System.Windows.Forms.Button();
            this.btn_Answer10 = new System.Windows.Forms.Button();
            this.btn_Answer09 = new System.Windows.Forms.Button();
            this.btn_Answer08 = new System.Windows.Forms.Button();
            this.btn_Answer07 = new System.Windows.Forms.Button();
            this.btn_Answer06 = new System.Windows.Forms.Button();
            this.btn_Answer05 = new System.Windows.Forms.Button();
            this.btn_Answer04 = new System.Windows.Forms.Button();
            this.btn_Answer03 = new System.Windows.Forms.Button();
            this.btn_Answer02 = new System.Windows.Forms.Button();
            this.btn_Answer01 = new System.Windows.Forms.Button();
            this.btn_LoadSpeaking10 = new System.Windows.Forms.Button();
            this.btn_LoadWriting10 = new System.Windows.Forms.Button();
            this.btn_LoadListening10 = new System.Windows.Forms.Button();
            this.btn_LoadReading10 = new System.Windows.Forms.Button();
            this.btn_LoadSpeaking09 = new System.Windows.Forms.Button();
            this.btn_LoadWriting09 = new System.Windows.Forms.Button();
            this.btn_LoadListening09 = new System.Windows.Forms.Button();
            this.btn_LoadReading09 = new System.Windows.Forms.Button();
            this.btn_LoadSpeaking08 = new System.Windows.Forms.Button();
            this.btn_LoadWriting08 = new System.Windows.Forms.Button();
            this.btn_LoadListening08 = new System.Windows.Forms.Button();
            this.btn_LoadReading08 = new System.Windows.Forms.Button();
            this.btn_LoadSpeaking07 = new System.Windows.Forms.Button();
            this.btn_LoadWriting07 = new System.Windows.Forms.Button();
            this.btn_LoadListening07 = new System.Windows.Forms.Button();
            this.btn_LoadReading07 = new System.Windows.Forms.Button();
            this.btn_LoadSpeaking06 = new System.Windows.Forms.Button();
            this.btn_LoadWriting06 = new System.Windows.Forms.Button();
            this.btn_LoadListening06 = new System.Windows.Forms.Button();
            this.btn_LoadReading06 = new System.Windows.Forms.Button();
            this.btn_LoadSpeaking05 = new System.Windows.Forms.Button();
            this.btn_LoadWriting05 = new System.Windows.Forms.Button();
            this.btn_LoadListening05 = new System.Windows.Forms.Button();
            this.btn_LoadReading05 = new System.Windows.Forms.Button();
            this.btn_LoadSpeaking04 = new System.Windows.Forms.Button();
            this.btn_LoadWriting04 = new System.Windows.Forms.Button();
            this.btn_LoadListening04 = new System.Windows.Forms.Button();
            this.btn_LoadReading04 = new System.Windows.Forms.Button();
            this.btn_LoadSpeaking03 = new System.Windows.Forms.Button();
            this.btn_LoadWriting03 = new System.Windows.Forms.Button();
            this.btn_LoadListening03 = new System.Windows.Forms.Button();
            this.btn_LoadReading03 = new System.Windows.Forms.Button();
            this.btn_LoadSpeaking02 = new System.Windows.Forms.Button();
            this.btn_LoadWriting02 = new System.Windows.Forms.Button();
            this.btn_LoadListening02 = new System.Windows.Forms.Button();
            this.btn_LoadReading02 = new System.Windows.Forms.Button();
            this.btn_LoadSpeaking01 = new System.Windows.Forms.Button();
            this.btn_LoadWriting01 = new System.Windows.Forms.Button();
            this.btn_LoadListening01 = new System.Windows.Forms.Button();
            this.btn_LoadReading01 = new System.Windows.Forms.Button();
            this.lbl_top5 = new System.Windows.Forms.Label();
            this.lbl_top8 = new System.Windows.Forms.Label();
            this.lbl_top10 = new System.Windows.Forms.Label();
            this.lbl_top9 = new System.Windows.Forms.Label();
            this.lbl_top7 = new System.Windows.Forms.Label();
            this.lbl_top6 = new System.Windows.Forms.Label();
            this.lbl_top4 = new System.Windows.Forms.Label();
            this.lbl_top3 = new System.Windows.Forms.Label();
            this.lbl_top2 = new System.Windows.Forms.Label();
            this.lbl_top1 = new System.Windows.Forms.Label();
            this.tab_Reading = new System.Windows.Forms.TabPage();
            this.tabf_Reading = new System.Windows.Forms.TabControl();
            this.rtab_Direction = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rtab_NormalQuestion = new System.Windows.Forms.TabPage();
            this.tb_reading = new System.Windows.Forms.TrackBar();
            this.rtb_Passage = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rtb_question = new System.Windows.Forms.RichTextBox();
            this.tlp_answers = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_answerE = new System.Windows.Forms.RichTextBox();
            this.rtb_answerD = new System.Windows.Forms.RichTextBox();
            this.rtb_answerC = new System.Windows.Forms.RichTextBox();
            this.rtb_answerB = new System.Windows.Forms.RichTextBox();
            this.ckb_A = new System.Windows.Forms.CheckBox();
            this.ckb_B = new System.Windows.Forms.CheckBox();
            this.ckb_C = new System.Windows.Forms.CheckBox();
            this.ckb_D = new System.Windows.Forms.CheckBox();
            this.ckb_E = new System.Windows.Forms.CheckBox();
            this.rtb_answerA = new System.Windows.Forms.RichTextBox();
            this.ckb_F = new System.Windows.Forms.CheckBox();
            this.ckb_G = new System.Windows.Forms.CheckBox();
            this.ckb_H = new System.Windows.Forms.CheckBox();
            this.rtb_answerF = new System.Windows.Forms.RichTextBox();
            this.rtb_answerG = new System.Windows.Forms.RichTextBox();
            this.rtb_answerH = new System.Windows.Forms.RichTextBox();
            this.btn_stopReading = new System.Windows.Forms.Button();
            this.bn_readText = new System.Windows.Forms.Button();
            this.lbl_readingIndication = new System.Windows.Forms.Label();
            this.rtab_SumQuestion = new System.Windows.Forms.TabPage();
            this.llbl_rightAnswer = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rtb_sumPassage = new System.Windows.Forms.RichTextBox();
            this.rtb_sumQuestion = new System.Windows.Forms.RichTextBox();
            this.tlp_sumAnswers = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_SumSelected5 = new System.Windows.Forms.RichTextBox();
            this.rtb_SumSelected1 = new System.Windows.Forms.RichTextBox();
            this.rtb_SumSelected2 = new System.Windows.Forms.RichTextBox();
            this.rtb_SumSelected3 = new System.Windows.Forms.RichTextBox();
            this.rtb_SumSelected4 = new System.Windows.Forms.RichTextBox();
            this.ckb_SumSelected1 = new System.Windows.Forms.CheckBox();
            this.ckb_SumSelected2 = new System.Windows.Forms.CheckBox();
            this.ckb_SumSelected3 = new System.Windows.Forms.CheckBox();
            this.ckb_SumSelected4 = new System.Windows.Forms.CheckBox();
            this.ckb_SumSelected5 = new System.Windows.Forms.CheckBox();
            this.tlp_Summary = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_sumAnswer5 = new System.Windows.Forms.RichTextBox();
            this.rtb_sumAnswer1 = new System.Windows.Forms.RichTextBox();
            this.rtb_sumAnswer2 = new System.Windows.Forms.RichTextBox();
            this.rtb_sumAnswer3 = new System.Windows.Forms.RichTextBox();
            this.rtb_sumAnswer4 = new System.Windows.Forms.RichTextBox();
            this.ckb_sumAnswer1 = new System.Windows.Forms.CheckBox();
            this.ckb_sumAnswer2 = new System.Windows.Forms.CheckBox();
            this.ckb_sumAnswer3 = new System.Windows.Forms.CheckBox();
            this.ckb_sumAnswer4 = new System.Windows.Forms.CheckBox();
            this.ckb_sumAnswer5 = new System.Windows.Forms.CheckBox();
            this.ckb_sumAnswer6 = new System.Windows.Forms.CheckBox();
            this.rtb_sumAnswer6 = new System.Windows.Forms.RichTextBox();
            this.ckb_sumAnswer7 = new System.Windows.Forms.CheckBox();
            this.ckb_sumAnswer8 = new System.Windows.Forms.CheckBox();
            this.rtb_sumAnswer7 = new System.Windows.Forms.RichTextBox();
            this.rtb_sumAnswer8 = new System.Windows.Forms.RichTextBox();
            this.ckb_sumAnswer9 = new System.Windows.Forms.CheckBox();
            this.ckb_sumAnswer10 = new System.Windows.Forms.CheckBox();
            this.rtb_sumAnswer9 = new System.Windows.Forms.RichTextBox();
            this.rtb_sumAnswer10 = new System.Windows.Forms.RichTextBox();
            this.rtab_Review = new System.Windows.Forms.TabPage();
            this.lbl_scoreReport = new System.Windows.Forms.Label();
            this.lbl_wrongAnswered = new System.Windows.Forms.Label();
            this.pb_wrongAnswered = new System.Windows.Forms.PictureBox();
            this.lbl_rightAnswered = new System.Windows.Forms.Label();
            this.pb_rightAnswered = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dgv_readingReview = new System.Windows.Forms.DataGridView();
            this.tab_Listening = new System.Windows.Forms.TabPage();
            this.tabf_Listening = new System.Windows.Forms.TabControl();
            this.ltab_Direction1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ltab_Direction2 = new System.Windows.Forms.TabPage();
            this.ltab_Materials = new System.Windows.Forms.TabPage();
            this.l_splitContainer = new System.Windows.Forms.SplitContainer();
            this.pb_currentpos = new System.Windows.Forms.ProgressBar();
            this.tb_currentpos = new System.Windows.Forms.TrackBar();
            this.PlayFileName = new System.Windows.Forms.Label();
            this.pb_ListenScene = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flp_passage = new System.Windows.Forms.FlowLayoutPanel();
            this.lnk_passage = new System.Windows.Forms.LinkLabel();
            this.lMaterials1 = new System.Windows.Forms.TabPage();
            this.tb_currentpos1 = new System.Windows.Forms.TrackBar();
            this.pb_currentpos1 = new System.Windows.Forms.ProgressBar();
            this.pb_ListenScene1 = new System.Windows.Forms.PictureBox();
            this.ltab_Question = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lrtb_question = new System.Windows.Forms.RichTextBox();
            this.lrtb_answerE = new System.Windows.Forms.RichTextBox();
            this.lrtb_answerD = new System.Windows.Forms.RichTextBox();
            this.lrtb_answerC = new System.Windows.Forms.RichTextBox();
            this.lrtb_answerB = new System.Windows.Forms.RichTextBox();
            this.lckb_A = new System.Windows.Forms.CheckBox();
            this.lckb_B = new System.Windows.Forms.CheckBox();
            this.lckb_C = new System.Windows.Forms.CheckBox();
            this.lckb_D = new System.Windows.Forms.CheckBox();
            this.lckb_E = new System.Windows.Forms.CheckBox();
            this.lckb_F = new System.Windows.Forms.CheckBox();
            this.lckb_G = new System.Windows.Forms.CheckBox();
            this.lckb_H = new System.Windows.Forms.CheckBox();
            this.lrtb_answerF = new System.Windows.Forms.RichTextBox();
            this.lrtb_answerG = new System.Windows.Forms.RichTextBox();
            this.lrtb_answerH = new System.Windows.Forms.RichTextBox();
            this.lrtb_answerA = new System.Windows.Forms.RichTextBox();
            this.lTableQuestion = new System.Windows.Forms.TabPage();
            this.lbl_tableAnswer = new System.Windows.Forms.Label();
            this.lrtbTableQuestion = new System.Windows.Forms.RichTextBox();
            this.ltlp_table = new System.Windows.Forms.TableLayoutPanel();
            this.lckbTable11 = new System.Windows.Forms.CheckBox();
            this.lckbTable12 = new System.Windows.Forms.CheckBox();
            this.lckbTable13 = new System.Windows.Forms.CheckBox();
            this.lckbTable14 = new System.Windows.Forms.CheckBox();
            this.lckbTable15 = new System.Windows.Forms.CheckBox();
            this.lckbTable25 = new System.Windows.Forms.CheckBox();
            this.lckbTable24 = new System.Windows.Forms.CheckBox();
            this.lckbTable23 = new System.Windows.Forms.CheckBox();
            this.lckbTable22 = new System.Windows.Forms.CheckBox();
            this.lckbTable21 = new System.Windows.Forms.CheckBox();
            this.lckbTable32 = new System.Windows.Forms.CheckBox();
            this.lckbTable33 = new System.Windows.Forms.CheckBox();
            this.lckbTable34 = new System.Windows.Forms.CheckBox();
            this.lckbTable35 = new System.Windows.Forms.CheckBox();
            this.lckbTable43 = new System.Windows.Forms.CheckBox();
            this.lckbTable41 = new System.Windows.Forms.CheckBox();
            this.lckbTable31 = new System.Windows.Forms.CheckBox();
            this.lckbTable42 = new System.Windows.Forms.CheckBox();
            this.lckbTable44 = new System.Windows.Forms.CheckBox();
            this.lckbTable45 = new System.Windows.Forms.CheckBox();
            this.lckbTable55 = new System.Windows.Forms.CheckBox();
            this.lckbTable54 = new System.Windows.Forms.CheckBox();
            this.lckbTable53 = new System.Windows.Forms.CheckBox();
            this.lckbTable52 = new System.Windows.Forms.CheckBox();
            this.lckbTable51 = new System.Windows.Forms.CheckBox();
            this.lckbTable61 = new System.Windows.Forms.CheckBox();
            this.lckbTable62 = new System.Windows.Forms.CheckBox();
            this.lckbTable63 = new System.Windows.Forms.CheckBox();
            this.lckbTable64 = new System.Windows.Forms.CheckBox();
            this.lckbTable65 = new System.Windows.Forms.CheckBox();
            this.lckbTable71 = new System.Windows.Forms.CheckBox();
            this.lckbTable72 = new System.Windows.Forms.CheckBox();
            this.lckbTable73 = new System.Windows.Forms.CheckBox();
            this.lckbTable74 = new System.Windows.Forms.CheckBox();
            this.lckbTable75 = new System.Windows.Forms.CheckBox();
            this.lckbTable85 = new System.Windows.Forms.CheckBox();
            this.lckbTable84 = new System.Windows.Forms.CheckBox();
            this.lckbTable83 = new System.Windows.Forms.CheckBox();
            this.lckbTable82 = new System.Windows.Forms.CheckBox();
            this.lckbTable81 = new System.Windows.Forms.CheckBox();
            this.lckbTable91 = new System.Windows.Forms.CheckBox();
            this.lckbTable92 = new System.Windows.Forms.CheckBox();
            this.lckbTable93 = new System.Windows.Forms.CheckBox();
            this.lckbTable94 = new System.Windows.Forms.CheckBox();
            this.lckbTable95 = new System.Windows.Forms.CheckBox();
            this.lrtbTableCol1 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableCol2 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableCol3 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableCol5 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableRow1 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableRow2 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableRow3 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableRow4 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableRow5 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableRow6 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableRow7 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableRow8 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableRow9 = new System.Windows.Forms.RichTextBox();
            this.lrtbTableCol4 = new System.Windows.Forms.RichTextBox();
            this.tab_Speaking = new System.Windows.Forms.TabPage();
            this.tabf_speaking = new System.Windows.Forms.TabControl();
            this.sDirection = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sNormalQuestions = new System.Windows.Forms.TabPage();
            this.spb = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.srtb_timer = new System.Windows.Forms.Label();
            this.srtb_timeindicator = new System.Windows.Forms.Label();
            this.srtb_introduction = new System.Windows.Forms.RichTextBox();
            this.pb_speakingScene = new System.Windows.Forms.PictureBox();
            this.tab_Writing = new System.Windows.Forms.TabPage();
            this.tabf_writing = new System.Windows.Forms.TabControl();
            this.wDirection = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.wReading = new System.Windows.Forms.TabPage();
            this.wrtb_writing1 = new System.Windows.Forms.RichTextBox();
            this.wrtb_reading = new System.Windows.Forms.RichTextBox();
            this.wSpeakingPassage = new System.Windows.Forms.TabPage();
            this.wpb_speak = new System.Windows.Forms.ProgressBar();
            this.wtb_speak = new System.Windows.Forms.TrackBar();
            this.pb_writingScene = new System.Windows.Forms.PictureBox();
            this.wWriting2 = new System.Windows.Forms.TabPage();
            this.lbl_writeDirection = new System.Windows.Forms.Label();
            this.wrtb_writing2 = new System.Windows.Forms.RichTextBox();
            this.wrtbQuestion2 = new System.Windows.Forms.RichTextBox();
            this.wpanel = new System.Windows.Forms.Panel();
            this.wlbl_wordcount = new System.Windows.Forms.Label();
            this.wbtn_wordcount = new System.Windows.Forms.Button();
            this.wbtn_redo = new System.Windows.Forms.Button();
            this.wbtn_undo = new System.Windows.Forms.Button();
            this.wbtn_paste = new System.Windows.Forms.Button();
            this.wbtn_cut = new System.Windows.Forms.Button();
            this.tab_Answers = new System.Windows.Forms.TabPage();
            this.tabf_answer = new System.Windows.Forms.TabControl();
            this.tab_readinganswer = new System.Windows.Forms.TabPage();
            this.dgv_readingSelect = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_readingscorereport = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.dgv_readinganswers = new System.Windows.Forms.DataGridView();
            this.tab_listeninganswers = new System.Windows.Forms.TabPage();
            this.dgv_listeningSelect = new System.Windows.Forms.DataGridView();
            this.bindingSource_Set = new System.Windows.Forms.BindingSource(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.dgv_listeninganswers = new System.Windows.Forms.DataGridView();
            this.bindingSource_Section = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_listeningScorereport = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.tab_speakinganswers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_speakinganswer1 = new System.Windows.Forms.Button();
            this.btn_speakinganswer2 = new System.Windows.Forms.Button();
            this.btn_speakinganswer3 = new System.Windows.Forms.Button();
            this.btn_speakinganswer4 = new System.Windows.Forms.Button();
            this.btn_speakinganswer5 = new System.Windows.Forms.Button();
            this.btn_speakinganswer6 = new System.Windows.Forms.Button();
            this.tab_writinganswers = new System.Windows.Forms.TabPage();
            this.rtb_writinganswers = new System.Windows.Forms.RichTextBox();
            this.rtb_writing2 = new System.Windows.Forms.RadioButton();
            this.rtb_writing1 = new System.Windows.Forms.RadioButton();
            this.btn_ShowText = new System.Windows.Forms.Button();
            this.flash_timer = new System.Windows.Forms.Timer(this.components);
            this.Timer_Speaking = new System.Windows.Forms.Timer(this.components);
            this.ckb_viewSpeakingText = new System.Windows.Forms.CheckBox();
            this.lbl_testingSection = new System.Windows.Forms.Label();
            this.btn_LastPage = new System.Windows.Forms.Button();
            this.btn_NexPage = new System.Windows.Forms.Button();
            this.rb_PracticeMode = new System.Windows.Forms.RadioButton();
            this.rb_TestMode = new System.Windows.Forms.RadioButton();
            this.ckb_ShowAnswer = new System.Windows.Forms.CheckBox();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_QUITapp = new System.Windows.Forms.Button();
            this.bgimagelist = new System.Windows.Forms.ImageList(this.components);
            this.btn_showexplanation = new System.Windows.Forms.Button();
            this.btn_showtranslation = new System.Windows.Forms.Button();
            this.Timer_reading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tb_sound)).BeginInit();
            this.tabf_test.SuspendLayout();
            this.tab_CoverForm.SuspendLayout();
            this.tabf_tposelection.SuspendLayout();
            this.TPO10.SuspendLayout();
            this.tab_Reading.SuspendLayout();
            this.tabf_Reading.SuspendLayout();
            this.rtab_Direction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rtab_NormalQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_reading)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tlp_answers.SuspendLayout();
            this.rtab_SumQuestion.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tlp_sumAnswers.SuspendLayout();
            this.tlp_Summary.SuspendLayout();
            this.rtab_Review.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wrongAnswered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightAnswered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readingReview)).BeginInit();
            this.tab_Listening.SuspendLayout();
            this.tabf_Listening.SuspendLayout();
            this.ltab_Direction1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ltab_Materials.SuspendLayout();
            this.l_splitContainer.Panel1.SuspendLayout();
            this.l_splitContainer.Panel2.SuspendLayout();
            this.l_splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_currentpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ListenScene)).BeginInit();
            this.panel1.SuspendLayout();
            this.flp_passage.SuspendLayout();
            this.lMaterials1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_currentpos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ListenScene1)).BeginInit();
            this.ltab_Question.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.lTableQuestion.SuspendLayout();
            this.ltlp_table.SuspendLayout();
            this.tab_Speaking.SuspendLayout();
            this.tabf_speaking.SuspendLayout();
            this.sDirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.sNormalQuestions.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_speakingScene)).BeginInit();
            this.tab_Writing.SuspendLayout();
            this.tabf_writing.SuspendLayout();
            this.wDirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.wReading.SuspendLayout();
            this.wSpeakingPassage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wtb_speak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_writingScene)).BeginInit();
            this.wWriting2.SuspendLayout();
            this.wpanel.SuspendLayout();
            this.tab_Answers.SuspendLayout();
            this.tabf_answer.SuspendLayout();
            this.tab_readinganswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readingSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readinganswers)).BeginInit();
            this.tab_listeninganswers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeningSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeninganswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Section)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.tab_speakinganswers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tab_writinganswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_continue
            // 
            this.btn_continue.BackgroundImage = global::Properties.Resources._continue;
            this.btn_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_continue.FlatAppearance.BorderSize = 0;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Location = new System.Drawing.Point(701, 1);
            this.btn_continue.Size = new System.Drawing.Size(86, 34);
            this.btn_continue.TabStop = false;
            this.btn_continue.Text = "";
            this.btn_continue.Visible = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.BackgroundImage = global::Properties.Resources.mainmenu;
            this.btn_mainmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mainmenu.FlatAppearance.BorderSize = 0;
            this.btn_mainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainmenu.Location = new System.Drawing.Point(3, 27);
            this.btn_mainmenu.TabStop = false;
            this.btn_mainmenu.Text = "";
            this.btn_mainmenu.Visible = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            // 
            // btn_nextQuestion
            // 
            this.btn_nextQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nextQuestion.BackColor = System.Drawing.Color.White;
            this.btn_nextQuestion.BackgroundImage = global::Properties.Resources.next;
            this.btn_nextQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nextQuestion.FlatAppearance.BorderSize = 0;
            this.btn_nextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nextQuestion.ForeColor = System.Drawing.Color.Black;
            this.btn_nextQuestion.Location = new System.Drawing.Point(707, 1);
            this.btn_nextQuestion.Size = new System.Drawing.Size(80, 44);
            this.btn_nextQuestion.TabStop = false;
            this.btn_nextQuestion.Text = "";
            this.btn_nextQuestion.UseVisualStyleBackColor = false;
            this.btn_nextQuestion.Visible = false;
            this.btn_nextQuestion.Click += new System.EventHandler(this.btn_nextQuestion_Click);
            // 
            // btn_preQuestion
            // 
            this.btn_preQuestion.BackgroundImage = global::Properties.Resources.back;
            this.btn_preQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_preQuestion.FlatAppearance.BorderSize = 0;
            this.btn_preQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preQuestion.Location = new System.Drawing.Point(649, 1);
            this.btn_preQuestion.Size = new System.Drawing.Size(80, 44);
            this.btn_preQuestion.TabStop = false;
            this.btn_preQuestion.Text = "";
            this.btn_preQuestion.Visible = false;
            this.btn_preQuestion.Click += new System.EventHandler(this.btn_preQuestion_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackgroundImage = global::Properties.Resources.exit;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Location = new System.Drawing.Point(52, 27);
            this.btn_quit.TabStop = false;
            this.btn_quit.Text = "";
            this.btn_quit.Visible = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_review
            // 
            this.btn_review.BackgroundImage = global::Properties.Resources.review;
            this.btn_review.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_review.FlatAppearance.BorderSize = 0;
            this.btn_review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_review.Location = new System.Drawing.Point(586, 1);
            this.btn_review.Size = new System.Drawing.Size(80, 44);
            this.btn_review.TabStop = false;
            this.btn_review.Text = "";
            this.btn_review.Visible = false;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Properties.Resources.hidetimer;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(652, 42);
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabStop = false;
            this.button1.Text = "";
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_mode
            // 
            this.lbl_mode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_mode.Location = new System.Drawing.Point(337, 40);
            this.lbl_mode.Size = new System.Drawing.Size(111, 17);
            this.lbl_mode.Visible = false;
            // 
            // lbl_questionNO
            // 
            this.lbl_questionNO.BackColor = System.Drawing.Color.Transparent;
            this.lbl_questionNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_questionNO.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_questionNO.Location = new System.Drawing.Point(341, 55);
            this.lbl_questionNO.Size = new System.Drawing.Size(115, 15);
            this.lbl_questionNO.Text = "";
            this.lbl_questionNO.Visible = false;
            // 
            // lbl_timeremain
            // 
            this.lbl_timeremain.BackColor = System.Drawing.Color.Transparent;
            this.lbl_timeremain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_timeremain.Location = new System.Drawing.Point(722, 50);
            this.lbl_timeremain.Size = new System.Drawing.Size(50, 16);
            this.lbl_timeremain.Visible = false;
            // 
            // Sound_icon
            // 
            this.Sound_icon.BackgroundImage = global::Properties.Resources.volumn;
            this.Sound_icon.Location = new System.Drawing.Point(597, 36);
            this.Sound_icon.Size = new System.Drawing.Size(74, 36);
            this.Sound_icon.Visible = false;
            this.Sound_icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Sound_icon_MouseClick);
            // 
            // tb_sound
            // 
            this.tb_sound.BackColor = System.Drawing.Color.Silver;
            this.tb_sound.Location = new System.Drawing.Point(490, 42);
            this.tb_sound.Maximum = 2000;
            this.tb_sound.SmallChange = 100;
            this.tb_sound.TickFrequency = 10;
            this.tb_sound.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_sound.Value = 1000;
            this.tb_sound.Visible = false;
            this.tb_sound.Scroll += new System.EventHandler(this.tb_sound_Scroll);
            // 
            // openMp3File
            // 
            this.openMp3File.FileName = "openMp3File";
            // 
            // Timer_Listening
            // 
            this.Timer_Listening.Interval = 1000;
            this.Timer_Listening.Tick += new System.EventHandler(this.Timer_Listening_Tick);
            // 
            // tabf_test
            // 
            this.tabf_test.Controls.Add(this.tab_CoverForm);
            this.tabf_test.Controls.Add(this.tab_Reading);
            this.tabf_test.Controls.Add(this.tab_Listening);
            this.tabf_test.Controls.Add(this.tab_Speaking);
            this.tabf_test.Controls.Add(this.tab_Writing);
            this.tabf_test.Controls.Add(this.tab_Answers);
            this.tabf_test.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabf_test.Location = new System.Drawing.Point(-1, 73);
            this.tabf_test.Multiline = true;
            this.tabf_test.Name = "tabf_test";
            this.tabf_test.SelectedIndex = 0;
            this.tabf_test.Size = new System.Drawing.Size(788, 510);
            this.tabf_test.TabIndex = 15;
            this.tabf_test.TabStop = false;
            // 
            // tab_CoverForm
            // 
            this.tab_CoverForm.Controls.Add(this.tabf_tposelection);
            this.tab_CoverForm.Location = new System.Drawing.Point(4, 22);
            this.tab_CoverForm.Name = "tab_CoverForm";
            this.tab_CoverForm.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CoverForm.Size = new System.Drawing.Size(780, 484);
            this.tab_CoverForm.TabIndex = 4;
            this.tab_CoverForm.Text = "CoverForm";
            // 
            // tabf_tposelection
            // 
            this.tabf_tposelection.Controls.Add(this.TPO10);
            this.tabf_tposelection.Location = new System.Drawing.Point(-4, -20);
            this.tabf_tposelection.Name = "tabf_tposelection";
            this.tabf_tposelection.SelectedIndex = 0;
            this.tabf_tposelection.Size = new System.Drawing.Size(790, 499);
            this.tabf_tposelection.TabIndex = 1;
            this.tabf_tposelection.TabStop = false;
            // 
            // TPO10
            // 
            this.TPO10.BackColor = System.Drawing.Color.White;
            this.TPO10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.TPO10.Location = new System.Drawing.Point(4, 22);
            this.TPO10.Name = "TPO10";
            this.TPO10.Padding = new System.Windows.Forms.Padding(3);
            this.TPO10.Size = new System.Drawing.Size(782, 473);
            this.TPO10.TabIndex = 0;
            this.TPO10.Text = "TPO1-10";
            // 
            // btn_Review10
            // 
            this.btn_Review10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Review10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Review10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Review10.Location = new System.Drawing.Point(533, 423);
            this.btn_Review10.Name = "btn_Review10";
            this.btn_Review10.Size = new System.Drawing.Size(100, 30);
            this.btn_Review10.TabIndex = 57;
            this.btn_Review10.TabStop = false;
            this.btn_Review10.Text = "START TEST";
            this.btn_Review10.UseVisualStyleBackColor = true;
            this.btn_Review10.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Review09
            // 
            this.btn_Review09.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Review09.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review09.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review09.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Review09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Review09.Location = new System.Drawing.Point(533, 384);
            this.btn_Review09.Name = "btn_Review09";
            this.btn_Review09.Size = new System.Drawing.Size(100, 30);
            this.btn_Review09.TabIndex = 56;
            this.btn_Review09.TabStop = false;
            this.btn_Review09.Text = "START TEST";
            this.btn_Review09.UseVisualStyleBackColor = true;
            this.btn_Review09.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Review08
            // 
            this.btn_Review08.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Review08.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review08.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Review08.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Review08.Location = new System.Drawing.Point(533, 340);
            this.btn_Review08.Name = "btn_Review08";
            this.btn_Review08.Size = new System.Drawing.Size(100, 30);
            this.btn_Review08.TabIndex = 55;
            this.btn_Review08.TabStop = false;
            this.btn_Review08.Text = "START TEST";
            this.btn_Review08.UseVisualStyleBackColor = true;
            this.btn_Review08.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Review07
            // 
            this.btn_Review07.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Review07.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review07.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Review07.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Review07.Location = new System.Drawing.Point(533, 294);
            this.btn_Review07.Name = "btn_Review07";
            this.btn_Review07.Size = new System.Drawing.Size(100, 30);
            this.btn_Review07.TabIndex = 54;
            this.btn_Review07.TabStop = false;
            this.btn_Review07.Text = "START TEST";
            this.btn_Review07.UseVisualStyleBackColor = true;
            this.btn_Review07.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Review06
            // 
            this.btn_Review06.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Review06.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review06.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Review06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Review06.Location = new System.Drawing.Point(533, 248);
            this.btn_Review06.Name = "btn_Review06";
            this.btn_Review06.Size = new System.Drawing.Size(100, 30);
            this.btn_Review06.TabIndex = 53;
            this.btn_Review06.TabStop = false;
            this.btn_Review06.Text = "START TEST";
            this.btn_Review06.UseVisualStyleBackColor = true;
            this.btn_Review06.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Review05
            // 
            this.btn_Review05.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Review05.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review05.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Review05.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Review05.Location = new System.Drawing.Point(533, 202);
            this.btn_Review05.Name = "btn_Review05";
            this.btn_Review05.Size = new System.Drawing.Size(100, 30);
            this.btn_Review05.TabIndex = 52;
            this.btn_Review05.TabStop = false;
            this.btn_Review05.Text = "START TEST";
            this.btn_Review05.UseVisualStyleBackColor = true;
            this.btn_Review05.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Review04
            // 
            this.btn_Review04.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Review04.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review04.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Review04.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Review04.Location = new System.Drawing.Point(533, 159);
            this.btn_Review04.Name = "btn_Review04";
            this.btn_Review04.Size = new System.Drawing.Size(100, 30);
            this.btn_Review04.TabIndex = 51;
            this.btn_Review04.TabStop = false;
            this.btn_Review04.Text = "START TEST";
            this.btn_Review04.UseVisualStyleBackColor = true;
            this.btn_Review04.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Review03
            // 
            this.btn_Review03.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Review03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Review03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Review03.Location = new System.Drawing.Point(533, 109);
            this.btn_Review03.Name = "btn_Review03";
            this.btn_Review03.Size = new System.Drawing.Size(100, 30);
            this.btn_Review03.TabIndex = 50;
            this.btn_Review03.TabStop = false;
            this.btn_Review03.Text = "START TEST";
            this.btn_Review03.UseVisualStyleBackColor = true;
            this.btn_Review03.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Review02
            // 
            this.btn_Review02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Review02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Review02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Review02.Location = new System.Drawing.Point(533, 58);
            this.btn_Review02.Name = "btn_Review02";
            this.btn_Review02.Size = new System.Drawing.Size(100, 30);
            this.btn_Review02.TabIndex = 49;
            this.btn_Review02.TabStop = false;
            this.btn_Review02.Text = "START TEST";
            this.btn_Review02.UseVisualStyleBackColor = true;
            this.btn_Review02.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Review01
            // 
            this.btn_Review01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Review01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Review01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Review01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Review01.Location = new System.Drawing.Point(533, 17);
            this.btn_Review01.Name = "btn_Review01";
            this.btn_Review01.Size = new System.Drawing.Size(100, 30);
            this.btn_Review01.TabIndex = 48;
            this.btn_Review01.TabStop = false;
            this.btn_Review01.Text = "START TEST";
            this.btn_Review01.UseVisualStyleBackColor = true;
            this.btn_Review01.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Answer10
            // 
            this.btn_Answer10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Answer10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Answer10.Location = new System.Drawing.Point(642, 423);
            this.btn_Answer10.Name = "btn_Answer10";
            this.btn_Answer10.Size = new System.Drawing.Size(80, 30);
            this.btn_Answer10.TabIndex = 47;
            this.btn_Answer10.TabStop = false;
            this.btn_Answer10.Text = "VIEW ANSWERS";
            this.btn_Answer10.UseVisualStyleBackColor = true;
            this.btn_Answer10.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Answer09
            // 
            this.btn_Answer09.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Answer09.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer09.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer09.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer09.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Answer09.Location = new System.Drawing.Point(642, 384);
            this.btn_Answer09.Name = "btn_Answer09";
            this.btn_Answer09.Size = new System.Drawing.Size(80, 30);
            this.btn_Answer09.TabIndex = 46;
            this.btn_Answer09.TabStop = false;
            this.btn_Answer09.Text = "VIEW ANSWERS";
            this.btn_Answer09.UseVisualStyleBackColor = true;
            this.btn_Answer09.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Answer08
            // 
            this.btn_Answer08.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Answer08.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer08.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer08.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Answer08.Location = new System.Drawing.Point(642, 340);
            this.btn_Answer08.Name = "btn_Answer08";
            this.btn_Answer08.Size = new System.Drawing.Size(80, 30);
            this.btn_Answer08.TabIndex = 45;
            this.btn_Answer08.TabStop = false;
            this.btn_Answer08.Text = "VIEW ANSWERS";
            this.btn_Answer08.UseVisualStyleBackColor = true;
            this.btn_Answer08.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Answer07
            // 
            this.btn_Answer07.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Answer07.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer07.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer07.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Answer07.Location = new System.Drawing.Point(642, 294);
            this.btn_Answer07.Name = "btn_Answer07";
            this.btn_Answer07.Size = new System.Drawing.Size(80, 30);
            this.btn_Answer07.TabIndex = 44;
            this.btn_Answer07.TabStop = false;
            this.btn_Answer07.Text = "VIEW ANSWERS";
            this.btn_Answer07.UseVisualStyleBackColor = true;
            this.btn_Answer07.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Answer06
            // 
            this.btn_Answer06.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Answer06.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer06.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer06.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Answer06.Location = new System.Drawing.Point(642, 248);
            this.btn_Answer06.Name = "btn_Answer06";
            this.btn_Answer06.Size = new System.Drawing.Size(80, 30);
            this.btn_Answer06.TabIndex = 43;
            this.btn_Answer06.TabStop = false;
            this.btn_Answer06.Text = "VIEW ANSWERS";
            this.btn_Answer06.UseVisualStyleBackColor = true;
            this.btn_Answer06.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Answer05
            // 
            this.btn_Answer05.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Answer05.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer05.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer05.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Answer05.Location = new System.Drawing.Point(642, 202);
            this.btn_Answer05.Name = "btn_Answer05";
            this.btn_Answer05.Size = new System.Drawing.Size(80, 30);
            this.btn_Answer05.TabIndex = 42;
            this.btn_Answer05.TabStop = false;
            this.btn_Answer05.Text = "VIEW ANSWERS";
            this.btn_Answer05.UseVisualStyleBackColor = true;
            this.btn_Answer05.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Answer04
            // 
            this.btn_Answer04.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Answer04.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer04.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer04.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Answer04.Location = new System.Drawing.Point(642, 159);
            this.btn_Answer04.Name = "btn_Answer04";
            this.btn_Answer04.Size = new System.Drawing.Size(80, 30);
            this.btn_Answer04.TabIndex = 41;
            this.btn_Answer04.TabStop = false;
            this.btn_Answer04.Text = "VIEW ANSWERS";
            this.btn_Answer04.UseVisualStyleBackColor = true;
            this.btn_Answer04.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Answer03
            // 
            this.btn_Answer03.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Answer03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer03.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Answer03.Location = new System.Drawing.Point(642, 109);
            this.btn_Answer03.Name = "btn_Answer03";
            this.btn_Answer03.Size = new System.Drawing.Size(80, 30);
            this.btn_Answer03.TabIndex = 40;
            this.btn_Answer03.TabStop = false;
            this.btn_Answer03.Text = "VIEW ANSWERS";
            this.btn_Answer03.UseVisualStyleBackColor = true;
            this.btn_Answer03.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Answer02
            // 
            this.btn_Answer02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Answer02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer02.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Answer02.Location = new System.Drawing.Point(642, 58);
            this.btn_Answer02.Name = "btn_Answer02";
            this.btn_Answer02.Size = new System.Drawing.Size(80, 30);
            this.btn_Answer02.TabIndex = 39;
            this.btn_Answer02.TabStop = false;
            this.btn_Answer02.Text = "VIEW ANSWERS";
            this.btn_Answer02.UseVisualStyleBackColor = true;
            this.btn_Answer02.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Answer01
            // 
            this.btn_Answer01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Answer01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Answer01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Answer01.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Answer01.Location = new System.Drawing.Point(642, 17);
            this.btn_Answer01.Name = "btn_Answer01";
            this.btn_Answer01.Size = new System.Drawing.Size(80, 30);
            this.btn_Answer01.TabIndex = 38;
            this.btn_Answer01.TabStop = false;
            this.btn_Answer01.Text = "VIEW ANSWERS";
            this.btn_Answer01.UseVisualStyleBackColor = true;
            this.btn_Answer01.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadSpeaking10
            // 
            this.btn_LoadSpeaking10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadSpeaking10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadSpeaking10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadSpeaking10.Location = new System.Drawing.Point(310, 423);
            this.btn_LoadSpeaking10.Name = "btn_LoadSpeaking10";
            this.btn_LoadSpeaking10.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadSpeaking10.TabIndex = 36;
            this.btn_LoadSpeaking10.TabStop = false;
            this.btn_LoadSpeaking10.Text = "SPEAKING";
            this.btn_LoadSpeaking10.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking10.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadWriting10
            // 
            this.btn_LoadWriting10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadWriting10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadWriting10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadWriting10.Location = new System.Drawing.Point(423, 423);
            this.btn_LoadWriting10.Name = "btn_LoadWriting10";
            this.btn_LoadWriting10.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadWriting10.TabIndex = 37;
            this.btn_LoadWriting10.TabStop = false;
            this.btn_LoadWriting10.Text = "WRITING";
            this.btn_LoadWriting10.UseVisualStyleBackColor = true;
            this.btn_LoadWriting10.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadListening10
            // 
            this.btn_LoadListening10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadListening10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadListening10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadListening10.Location = new System.Drawing.Point(197, 423);
            this.btn_LoadListening10.Name = "btn_LoadListening10";
            this.btn_LoadListening10.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadListening10.TabIndex = 34;
            this.btn_LoadListening10.TabStop = false;
            this.btn_LoadListening10.Text = "LISTENING";
            this.btn_LoadListening10.UseVisualStyleBackColor = true;
            this.btn_LoadListening10.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadReading10
            // 
            this.btn_LoadReading10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadReading10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadReading10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadReading10.Location = new System.Drawing.Point(80, 423);
            this.btn_LoadReading10.Name = "btn_LoadReading10";
            this.btn_LoadReading10.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadReading10.TabIndex = 35;
            this.btn_LoadReading10.TabStop = false;
            this.btn_LoadReading10.Text = "READING";
            this.btn_LoadReading10.UseVisualStyleBackColor = true;
            this.btn_LoadReading10.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadSpeaking09
            // 
            this.btn_LoadSpeaking09.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadSpeaking09.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking09.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking09.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadSpeaking09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadSpeaking09.Location = new System.Drawing.Point(310, 384);
            this.btn_LoadSpeaking09.Name = "btn_LoadSpeaking09";
            this.btn_LoadSpeaking09.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadSpeaking09.TabIndex = 32;
            this.btn_LoadSpeaking09.TabStop = false;
            this.btn_LoadSpeaking09.Text = "SPEAKING";
            this.btn_LoadSpeaking09.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking09.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadWriting09
            // 
            this.btn_LoadWriting09.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadWriting09.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting09.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting09.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadWriting09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadWriting09.Location = new System.Drawing.Point(423, 384);
            this.btn_LoadWriting09.Name = "btn_LoadWriting09";
            this.btn_LoadWriting09.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadWriting09.TabIndex = 33;
            this.btn_LoadWriting09.TabStop = false;
            this.btn_LoadWriting09.Text = "WRITING";
            this.btn_LoadWriting09.UseVisualStyleBackColor = true;
            this.btn_LoadWriting09.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadListening09
            // 
            this.btn_LoadListening09.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadListening09.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening09.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening09.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadListening09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadListening09.Location = new System.Drawing.Point(197, 384);
            this.btn_LoadListening09.Name = "btn_LoadListening09";
            this.btn_LoadListening09.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadListening09.TabIndex = 30;
            this.btn_LoadListening09.TabStop = false;
            this.btn_LoadListening09.Text = "LISTENING";
            this.btn_LoadListening09.UseVisualStyleBackColor = true;
            this.btn_LoadListening09.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadReading09
            // 
            this.btn_LoadReading09.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadReading09.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading09.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading09.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadReading09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadReading09.Location = new System.Drawing.Point(80, 384);
            this.btn_LoadReading09.Name = "btn_LoadReading09";
            this.btn_LoadReading09.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadReading09.TabIndex = 31;
            this.btn_LoadReading09.TabStop = false;
            this.btn_LoadReading09.Text = "READING";
            this.btn_LoadReading09.UseVisualStyleBackColor = true;
            this.btn_LoadReading09.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadSpeaking08
            // 
            this.btn_LoadSpeaking08.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadSpeaking08.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking08.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadSpeaking08.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadSpeaking08.Location = new System.Drawing.Point(310, 340);
            this.btn_LoadSpeaking08.Name = "btn_LoadSpeaking08";
            this.btn_LoadSpeaking08.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadSpeaking08.TabIndex = 28;
            this.btn_LoadSpeaking08.TabStop = false;
            this.btn_LoadSpeaking08.Text = "SPEAKING";
            this.btn_LoadSpeaking08.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking08.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadWriting08
            // 
            this.btn_LoadWriting08.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadWriting08.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting08.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadWriting08.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadWriting08.Location = new System.Drawing.Point(423, 340);
            this.btn_LoadWriting08.Name = "btn_LoadWriting08";
            this.btn_LoadWriting08.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadWriting08.TabIndex = 29;
            this.btn_LoadWriting08.TabStop = false;
            this.btn_LoadWriting08.Text = "WRITING";
            this.btn_LoadWriting08.UseVisualStyleBackColor = true;
            this.btn_LoadWriting08.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadListening08
            // 
            this.btn_LoadListening08.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadListening08.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening08.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadListening08.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadListening08.Location = new System.Drawing.Point(197, 340);
            this.btn_LoadListening08.Name = "btn_LoadListening08";
            this.btn_LoadListening08.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadListening08.TabIndex = 26;
            this.btn_LoadListening08.TabStop = false;
            this.btn_LoadListening08.Text = "LISTENING";
            this.btn_LoadListening08.UseVisualStyleBackColor = true;
            this.btn_LoadListening08.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadReading08
            // 
            this.btn_LoadReading08.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadReading08.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading08.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadReading08.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadReading08.Location = new System.Drawing.Point(80, 340);
            this.btn_LoadReading08.Name = "btn_LoadReading08";
            this.btn_LoadReading08.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadReading08.TabIndex = 27;
            this.btn_LoadReading08.TabStop = false;
            this.btn_LoadReading08.Text = "READING";
            this.btn_LoadReading08.UseVisualStyleBackColor = true;
            this.btn_LoadReading08.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadSpeaking07
            // 
            this.btn_LoadSpeaking07.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadSpeaking07.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking07.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadSpeaking07.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadSpeaking07.Location = new System.Drawing.Point(310, 294);
            this.btn_LoadSpeaking07.Name = "btn_LoadSpeaking07";
            this.btn_LoadSpeaking07.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadSpeaking07.TabIndex = 24;
            this.btn_LoadSpeaking07.TabStop = false;
            this.btn_LoadSpeaking07.Text = "SPEAKING";
            this.btn_LoadSpeaking07.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking07.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadWriting07
            // 
            this.btn_LoadWriting07.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadWriting07.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting07.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadWriting07.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadWriting07.Location = new System.Drawing.Point(423, 294);
            this.btn_LoadWriting07.Name = "btn_LoadWriting07";
            this.btn_LoadWriting07.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadWriting07.TabIndex = 25;
            this.btn_LoadWriting07.TabStop = false;
            this.btn_LoadWriting07.Text = "WRITING";
            this.btn_LoadWriting07.UseVisualStyleBackColor = true;
            this.btn_LoadWriting07.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadListening07
            // 
            this.btn_LoadListening07.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadListening07.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening07.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadListening07.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadListening07.Location = new System.Drawing.Point(197, 294);
            this.btn_LoadListening07.Name = "btn_LoadListening07";
            this.btn_LoadListening07.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadListening07.TabIndex = 22;
            this.btn_LoadListening07.TabStop = false;
            this.btn_LoadListening07.Text = "LISTENING";
            this.btn_LoadListening07.UseVisualStyleBackColor = true;
            this.btn_LoadListening07.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadReading07
            // 
            this.btn_LoadReading07.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadReading07.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading07.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadReading07.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadReading07.Location = new System.Drawing.Point(80, 294);
            this.btn_LoadReading07.Name = "btn_LoadReading07";
            this.btn_LoadReading07.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadReading07.TabIndex = 23;
            this.btn_LoadReading07.TabStop = false;
            this.btn_LoadReading07.Text = "READING";
            this.btn_LoadReading07.UseVisualStyleBackColor = true;
            this.btn_LoadReading07.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadSpeaking06
            // 
            this.btn_LoadSpeaking06.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadSpeaking06.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking06.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadSpeaking06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadSpeaking06.Location = new System.Drawing.Point(310, 248);
            this.btn_LoadSpeaking06.Name = "btn_LoadSpeaking06";
            this.btn_LoadSpeaking06.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadSpeaking06.TabIndex = 20;
            this.btn_LoadSpeaking06.TabStop = false;
            this.btn_LoadSpeaking06.Text = "SPEAKING";
            this.btn_LoadSpeaking06.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking06.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadWriting06
            // 
            this.btn_LoadWriting06.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadWriting06.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting06.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadWriting06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadWriting06.Location = new System.Drawing.Point(423, 248);
            this.btn_LoadWriting06.Name = "btn_LoadWriting06";
            this.btn_LoadWriting06.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadWriting06.TabIndex = 21;
            this.btn_LoadWriting06.TabStop = false;
            this.btn_LoadWriting06.Text = "WRITING";
            this.btn_LoadWriting06.UseVisualStyleBackColor = true;
            this.btn_LoadWriting06.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadListening06
            // 
            this.btn_LoadListening06.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadListening06.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening06.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadListening06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadListening06.Location = new System.Drawing.Point(197, 248);
            this.btn_LoadListening06.Name = "btn_LoadListening06";
            this.btn_LoadListening06.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadListening06.TabIndex = 18;
            this.btn_LoadListening06.TabStop = false;
            this.btn_LoadListening06.Text = "LISTENING";
            this.btn_LoadListening06.UseVisualStyleBackColor = true;
            this.btn_LoadListening06.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadReading06
            // 
            this.btn_LoadReading06.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadReading06.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading06.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadReading06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadReading06.Location = new System.Drawing.Point(80, 248);
            this.btn_LoadReading06.Name = "btn_LoadReading06";
            this.btn_LoadReading06.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadReading06.TabIndex = 19;
            this.btn_LoadReading06.TabStop = false;
            this.btn_LoadReading06.Text = "READING";
            this.btn_LoadReading06.UseVisualStyleBackColor = true;
            this.btn_LoadReading06.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadSpeaking05
            // 
            this.btn_LoadSpeaking05.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadSpeaking05.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking05.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadSpeaking05.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadSpeaking05.Location = new System.Drawing.Point(310, 202);
            this.btn_LoadSpeaking05.Name = "btn_LoadSpeaking05";
            this.btn_LoadSpeaking05.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadSpeaking05.TabIndex = 16;
            this.btn_LoadSpeaking05.TabStop = false;
            this.btn_LoadSpeaking05.Text = "SPEAKING";
            this.btn_LoadSpeaking05.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking05.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadWriting05
            // 
            this.btn_LoadWriting05.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadWriting05.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting05.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadWriting05.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadWriting05.Location = new System.Drawing.Point(423, 202);
            this.btn_LoadWriting05.Name = "btn_LoadWriting05";
            this.btn_LoadWriting05.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadWriting05.TabIndex = 17;
            this.btn_LoadWriting05.TabStop = false;
            this.btn_LoadWriting05.Text = "WRITING";
            this.btn_LoadWriting05.UseVisualStyleBackColor = true;
            this.btn_LoadWriting05.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadListening05
            // 
            this.btn_LoadListening05.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadListening05.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening05.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadListening05.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadListening05.Location = new System.Drawing.Point(197, 202);
            this.btn_LoadListening05.Name = "btn_LoadListening05";
            this.btn_LoadListening05.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadListening05.TabIndex = 14;
            this.btn_LoadListening05.TabStop = false;
            this.btn_LoadListening05.Text = "LISTENING";
            this.btn_LoadListening05.UseVisualStyleBackColor = true;
            this.btn_LoadListening05.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadReading05
            // 
            this.btn_LoadReading05.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadReading05.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading05.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadReading05.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadReading05.Location = new System.Drawing.Point(80, 202);
            this.btn_LoadReading05.Name = "btn_LoadReading05";
            this.btn_LoadReading05.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadReading05.TabIndex = 15;
            this.btn_LoadReading05.TabStop = false;
            this.btn_LoadReading05.Text = "READING";
            this.btn_LoadReading05.UseVisualStyleBackColor = true;
            this.btn_LoadReading05.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadSpeaking04
            // 
            this.btn_LoadSpeaking04.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadSpeaking04.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking04.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadSpeaking04.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadSpeaking04.Location = new System.Drawing.Point(310, 159);
            this.btn_LoadSpeaking04.Name = "btn_LoadSpeaking04";
            this.btn_LoadSpeaking04.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadSpeaking04.TabIndex = 12;
            this.btn_LoadSpeaking04.TabStop = false;
            this.btn_LoadSpeaking04.Text = "SPEAKING";
            this.btn_LoadSpeaking04.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking04.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadWriting04
            // 
            this.btn_LoadWriting04.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadWriting04.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting04.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadWriting04.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadWriting04.Location = new System.Drawing.Point(423, 159);
            this.btn_LoadWriting04.Name = "btn_LoadWriting04";
            this.btn_LoadWriting04.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadWriting04.TabIndex = 13;
            this.btn_LoadWriting04.TabStop = false;
            this.btn_LoadWriting04.Text = "WRITING";
            this.btn_LoadWriting04.UseVisualStyleBackColor = true;
            this.btn_LoadWriting04.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadListening04
            // 
            this.btn_LoadListening04.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadListening04.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening04.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadListening04.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadListening04.Location = new System.Drawing.Point(197, 159);
            this.btn_LoadListening04.Name = "btn_LoadListening04";
            this.btn_LoadListening04.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadListening04.TabIndex = 10;
            this.btn_LoadListening04.TabStop = false;
            this.btn_LoadListening04.Text = "LISTENING";
            this.btn_LoadListening04.UseVisualStyleBackColor = true;
            this.btn_LoadListening04.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadReading04
            // 
            this.btn_LoadReading04.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadReading04.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading04.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadReading04.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadReading04.Location = new System.Drawing.Point(80, 159);
            this.btn_LoadReading04.Name = "btn_LoadReading04";
            this.btn_LoadReading04.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadReading04.TabIndex = 11;
            this.btn_LoadReading04.TabStop = false;
            this.btn_LoadReading04.Text = "READING";
            this.btn_LoadReading04.UseVisualStyleBackColor = true;
            this.btn_LoadReading04.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadSpeaking03
            // 
            this.btn_LoadSpeaking03.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadSpeaking03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadSpeaking03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadSpeaking03.Location = new System.Drawing.Point(310, 109);
            this.btn_LoadSpeaking03.Name = "btn_LoadSpeaking03";
            this.btn_LoadSpeaking03.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadSpeaking03.TabIndex = 8;
            this.btn_LoadSpeaking03.TabStop = false;
            this.btn_LoadSpeaking03.Text = "SPEAKING";
            this.btn_LoadSpeaking03.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking03.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadWriting03
            // 
            this.btn_LoadWriting03.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadWriting03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadWriting03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadWriting03.Location = new System.Drawing.Point(423, 109);
            this.btn_LoadWriting03.Name = "btn_LoadWriting03";
            this.btn_LoadWriting03.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadWriting03.TabIndex = 9;
            this.btn_LoadWriting03.TabStop = false;
            this.btn_LoadWriting03.Text = "WRITING";
            this.btn_LoadWriting03.UseVisualStyleBackColor = true;
            this.btn_LoadWriting03.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadListening03
            // 
            this.btn_LoadListening03.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadListening03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadListening03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadListening03.Location = new System.Drawing.Point(197, 109);
            this.btn_LoadListening03.Name = "btn_LoadListening03";
            this.btn_LoadListening03.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadListening03.TabIndex = 6;
            this.btn_LoadListening03.TabStop = false;
            this.btn_LoadListening03.Text = "LISTENING";
            this.btn_LoadListening03.UseVisualStyleBackColor = true;
            this.btn_LoadListening03.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadReading03
            // 
            this.btn_LoadReading03.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadReading03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadReading03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadReading03.Location = new System.Drawing.Point(80, 109);
            this.btn_LoadReading03.Name = "btn_LoadReading03";
            this.btn_LoadReading03.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadReading03.TabIndex = 7;
            this.btn_LoadReading03.TabStop = false;
            this.btn_LoadReading03.Text = "READING";
            this.btn_LoadReading03.UseVisualStyleBackColor = true;
            this.btn_LoadReading03.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadSpeaking02
            // 
            this.btn_LoadSpeaking02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadSpeaking02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadSpeaking02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadSpeaking02.Location = new System.Drawing.Point(310, 58);
            this.btn_LoadSpeaking02.Name = "btn_LoadSpeaking02";
            this.btn_LoadSpeaking02.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadSpeaking02.TabIndex = 4;
            this.btn_LoadSpeaking02.TabStop = false;
            this.btn_LoadSpeaking02.Text = "SPEAKING";
            this.btn_LoadSpeaking02.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking02.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadWriting02
            // 
            this.btn_LoadWriting02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadWriting02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadWriting02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadWriting02.Location = new System.Drawing.Point(423, 58);
            this.btn_LoadWriting02.Name = "btn_LoadWriting02";
            this.btn_LoadWriting02.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadWriting02.TabIndex = 5;
            this.btn_LoadWriting02.TabStop = false;
            this.btn_LoadWriting02.Text = "WRITING";
            this.btn_LoadWriting02.UseVisualStyleBackColor = true;
            this.btn_LoadWriting02.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadListening02
            // 
            this.btn_LoadListening02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadListening02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadListening02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadListening02.Location = new System.Drawing.Point(197, 58);
            this.btn_LoadListening02.Name = "btn_LoadListening02";
            this.btn_LoadListening02.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadListening02.TabIndex = 2;
            this.btn_LoadListening02.TabStop = false;
            this.btn_LoadListening02.Text = "LISTENING";
            this.btn_LoadListening02.UseVisualStyleBackColor = true;
            this.btn_LoadListening02.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadReading02
            // 
            this.btn_LoadReading02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadReading02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadReading02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadReading02.Location = new System.Drawing.Point(80, 58);
            this.btn_LoadReading02.Name = "btn_LoadReading02";
            this.btn_LoadReading02.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadReading02.TabIndex = 3;
            this.btn_LoadReading02.TabStop = false;
            this.btn_LoadReading02.Text = "READING";
            this.btn_LoadReading02.UseVisualStyleBackColor = true;
            this.btn_LoadReading02.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadSpeaking01
            // 
            this.btn_LoadSpeaking01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadSpeaking01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadSpeaking01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadSpeaking01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadSpeaking01.Location = new System.Drawing.Point(310, 17);
            this.btn_LoadSpeaking01.Name = "btn_LoadSpeaking01";
            this.btn_LoadSpeaking01.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadSpeaking01.TabIndex = 1;
            this.btn_LoadSpeaking01.TabStop = false;
            this.btn_LoadSpeaking01.Text = "SPEAKING";
            this.btn_LoadSpeaking01.UseVisualStyleBackColor = true;
            this.btn_LoadSpeaking01.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadWriting01
            // 
            this.btn_LoadWriting01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadWriting01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadWriting01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadWriting01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadWriting01.Location = new System.Drawing.Point(423, 17);
            this.btn_LoadWriting01.Name = "btn_LoadWriting01";
            this.btn_LoadWriting01.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadWriting01.TabIndex = 1;
            this.btn_LoadWriting01.TabStop = false;
            this.btn_LoadWriting01.Text = "WRITING";
            this.btn_LoadWriting01.UseVisualStyleBackColor = true;
            this.btn_LoadWriting01.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadListening01
            // 
            this.btn_LoadListening01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadListening01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadListening01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadListening01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadListening01.Location = new System.Drawing.Point(197, 17);
            this.btn_LoadListening01.Name = "btn_LoadListening01";
            this.btn_LoadListening01.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadListening01.TabIndex = 1;
            this.btn_LoadListening01.TabStop = false;
            this.btn_LoadListening01.Text = "LISTENING";
            this.btn_LoadListening01.UseVisualStyleBackColor = true;
            this.btn_LoadListening01.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_LoadReading01
            // 
            this.btn_LoadReading01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadReading01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadReading01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadReading01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoadReading01.Location = new System.Drawing.Point(80, 17);
            this.btn_LoadReading01.Name = "btn_LoadReading01";
            this.btn_LoadReading01.Size = new System.Drawing.Size(80, 30);
            this.btn_LoadReading01.TabIndex = 0;
            this.btn_LoadReading01.TabStop = false;
            this.btn_LoadReading01.Text = "READING";
            this.btn_LoadReading01.UseVisualStyleBackColor = true;
            this.btn_LoadReading01.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // lbl_top5
            // 
            this.lbl_top5.AutoSize = true;
            this.lbl_top5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top5.Location = new System.Drawing.Point(17, 206);
            this.lbl_top5.Name = "lbl_top5";
            this.lbl_top5.Size = new System.Drawing.Size(64, 19);
            this.lbl_top5.TabIndex = 0;
            this.lbl_top5.Text = "TPO 05";
            // 
            // lbl_top8
            // 
            this.lbl_top8.AutoSize = true;
            this.lbl_top8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top8.Location = new System.Drawing.Point(17, 343);
            this.lbl_top8.Name = "lbl_top8";
            this.lbl_top8.Size = new System.Drawing.Size(64, 19);
            this.lbl_top8.TabIndex = 0;
            this.lbl_top8.Text = "TPO 08";
            // 
            // lbl_top10
            // 
            this.lbl_top10.AutoSize = true;
            this.lbl_top10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top10.Location = new System.Drawing.Point(17, 431);
            this.lbl_top10.Name = "lbl_top10";
            this.lbl_top10.Size = new System.Drawing.Size(64, 19);
            this.lbl_top10.TabIndex = 0;
            this.lbl_top10.Text = "TPO 10";
            // 
            // lbl_top9
            // 
            this.lbl_top9.AutoSize = true;
            this.lbl_top9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top9.Location = new System.Drawing.Point(17, 388);
            this.lbl_top9.Name = "lbl_top9";
            this.lbl_top9.Size = new System.Drawing.Size(64, 19);
            this.lbl_top9.TabIndex = 0;
            this.lbl_top9.Text = "TPO 09";
            // 
            // lbl_top7
            // 
            this.lbl_top7.AutoSize = true;
            this.lbl_top7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top7.Location = new System.Drawing.Point(17, 298);
            this.lbl_top7.Name = "lbl_top7";
            this.lbl_top7.Size = new System.Drawing.Size(64, 19);
            this.lbl_top7.TabIndex = 0;
            this.lbl_top7.Text = "TPO 07";
            // 
            // lbl_top6
            // 
            this.lbl_top6.AutoSize = true;
            this.lbl_top6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top6.Location = new System.Drawing.Point(17, 252);
            this.lbl_top6.Name = "lbl_top6";
            this.lbl_top6.Size = new System.Drawing.Size(64, 19);
            this.lbl_top6.TabIndex = 0;
            this.lbl_top6.Text = "TPO 06";
            // 
            // lbl_top4
            // 
            this.lbl_top4.AutoSize = true;
            this.lbl_top4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top4.Location = new System.Drawing.Point(17, 162);
            this.lbl_top4.Name = "lbl_top4";
            this.lbl_top4.Size = new System.Drawing.Size(64, 19);
            this.lbl_top4.TabIndex = 0;
            this.lbl_top4.Text = "TPO 04";
            // 
            // lbl_top3
            // 
            this.lbl_top3.AutoSize = true;
            this.lbl_top3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top3.Location = new System.Drawing.Point(17, 116);
            this.lbl_top3.Name = "lbl_top3";
            this.lbl_top3.Size = new System.Drawing.Size(64, 19);
            this.lbl_top3.TabIndex = 0;
            this.lbl_top3.Text = "TPO 03";
            // 
            // lbl_top2
            // 
            this.lbl_top2.AutoSize = true;
            this.lbl_top2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top2.Location = new System.Drawing.Point(17, 66);
            this.lbl_top2.Name = "lbl_top2";
            this.lbl_top2.Size = new System.Drawing.Size(64, 19);
            this.lbl_top2.TabIndex = 0;
            this.lbl_top2.Text = "TPO 02";
            // 
            // lbl_top1
            // 
            this.lbl_top1.AutoSize = true;
            this.lbl_top1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top1.Location = new System.Drawing.Point(17, 24);
            this.lbl_top1.Name = "lbl_top1";
            this.lbl_top1.Size = new System.Drawing.Size(64, 19);
            this.lbl_top1.TabIndex = 0;
            this.lbl_top1.Text = "TPO 01";
            // 
            // tab_Reading
            // 
            this.tab_Reading.Controls.Add(this.tabf_Reading);
            this.tab_Reading.Location = new System.Drawing.Point(4, 22);
            this.tab_Reading.Name = "tab_Reading";
            this.tab_Reading.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Reading.Size = new System.Drawing.Size(780, 484);
            this.tab_Reading.TabIndex = 0;
            this.tab_Reading.Text = "Reading";
            this.tab_Reading.UseVisualStyleBackColor = true;
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
            this.rtab_Direction.Controls.Add(this.pictureBox2);
            this.rtab_Direction.Location = new System.Drawing.Point(4, 25);
            this.rtab_Direction.Name = "rtab_Direction";
            this.rtab_Direction.Size = new System.Drawing.Size(763, 481);
            this.rtab_Direction.TabIndex = 3;
            this.rtab_Direction.Text = "rDirection";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Properties.Resources.ReadingDirection;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(30, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1093, 506);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // rtab_NormalQuestion
            // 
            this.rtab_NormalQuestion.Controls.Add(this.tb_reading);
            this.rtab_NormalQuestion.Controls.Add(this.rtb_Passage);
            this.rtab_NormalQuestion.Controls.Add(this.flowLayoutPanel1);
            this.rtab_NormalQuestion.Controls.Add(this.btn_stopReading);
            this.rtab_NormalQuestion.Controls.Add(this.bn_readText);
            this.rtab_NormalQuestion.Controls.Add(this.lbl_readingIndication);
            this.rtab_NormalQuestion.Location = new System.Drawing.Point(4, 25);
            this.rtab_NormalQuestion.Name = "rtab_NormalQuestion";
            this.rtab_NormalQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.rtab_NormalQuestion.Size = new System.Drawing.Size(763, 481);
            this.rtab_NormalQuestion.TabIndex = 0;
            this.rtab_NormalQuestion.Text = "rNormalQuestions";
            this.rtab_NormalQuestion.UseVisualStyleBackColor = true;
            // 
            // tb_reading
            // 
            this.tb_reading.AutoSize = false;
            this.tb_reading.Location = new System.Drawing.Point(426, 0);
            this.tb_reading.Name = "tb_reading";
            this.tb_reading.Size = new System.Drawing.Size(282, 19);
            this.tb_reading.TabIndex = 25;
            this.tb_reading.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_reading.Visible = false;
            this.tb_reading.Scroll += new System.EventHandler(this.tb_reading_Scroll);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.rtb_question);
            this.flowLayoutPanel1.Controls.Add(this.tlp_answers);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(346, 490);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // rtb_question
            // 
            this.rtb_question.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_question.Location = new System.Drawing.Point(3, 3);
            this.rtb_question.Name = "rtb_question";
            this.rtb_question.ReadOnly = true;
            this.rtb_question.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_question.Size = new System.Drawing.Size(331, 43);
            this.rtb_question.TabIndex = 0;
            this.rtb_question.TabStop = false;
            this.rtb_question.Text = "";
            // 
            // tlp_answers
            // 
            this.tlp_answers.AutoSize = true;
            this.tlp_answers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_answers.ColumnCount = 2;
            this.tlp_answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.tlp_answers.Location = new System.Drawing.Point(3, 52);
            this.tlp_answers.Name = "tlp_answers";
            this.tlp_answers.RowCount = 8;
            this.tlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_answers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_answers.Size = new System.Drawing.Size(336, 368);
            this.tlp_answers.TabIndex = 1;
            // 
            // rtb_answerE
            // 
            this.rtb_answerE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_answerE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_answerE.Location = new System.Drawing.Point(43, 187);
            this.rtb_answerE.Name = "rtb_answerE";
            this.rtb_answerE.ReadOnly = true;
            this.rtb_answerE.ShortcutsEnabled = false;
            this.rtb_answerE.Size = new System.Drawing.Size(290, 40);
            this.rtb_answerE.TabIndex = 9;
            this.rtb_answerE.TabStop = false;
            this.rtb_answerE.Text = "";
            this.rtb_answerE.Visible = false;
            // 
            // rtb_answerD
            // 
            this.rtb_answerD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_answerD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_answerD.Location = new System.Drawing.Point(43, 141);
            this.rtb_answerD.Name = "rtb_answerD";
            this.rtb_answerD.ReadOnly = true;
            this.rtb_answerD.ShortcutsEnabled = false;
            this.rtb_answerD.Size = new System.Drawing.Size(290, 40);
            this.rtb_answerD.TabIndex = 8;
            this.rtb_answerD.TabStop = false;
            this.rtb_answerD.Text = "";
            this.rtb_answerD.Visible = false;
            // 
            // rtb_answerC
            // 
            this.rtb_answerC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_answerC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_answerC.Location = new System.Drawing.Point(43, 95);
            this.rtb_answerC.Name = "rtb_answerC";
            this.rtb_answerC.ReadOnly = true;
            this.rtb_answerC.ShortcutsEnabled = false;
            this.rtb_answerC.Size = new System.Drawing.Size(290, 40);
            this.rtb_answerC.TabIndex = 7;
            this.rtb_answerC.TabStop = false;
            this.rtb_answerC.Text = "";
            this.rtb_answerC.Visible = false;
            // 
            // rtb_answerB
            // 
            this.rtb_answerB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_answerB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_answerB.Location = new System.Drawing.Point(43, 49);
            this.rtb_answerB.Name = "rtb_answerB";
            this.rtb_answerB.ReadOnly = true;
            this.rtb_answerB.ShortcutsEnabled = false;
            this.rtb_answerB.Size = new System.Drawing.Size(290, 40);
            this.rtb_answerB.TabIndex = 6;
            this.rtb_answerB.TabStop = false;
            this.rtb_answerB.Text = "";
            this.rtb_answerB.Visible = false;
            // 
            // ckb_A
            // 
            this.ckb_A.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_A.AutoSize = true;
            this.ckb_A.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.ckb_A.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ckb_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckb_A.Location = new System.Drawing.Point(3, 3);
            this.ckb_A.Name = "ckb_A";
            this.ckb_A.Size = new System.Drawing.Size(21, 22);
            this.ckb_A.TabIndex = 0;
            this.ckb_A.TabStop = false;
            this.ckb_A.Text = "A";
            this.ckb_A.UseVisualStyleBackColor = true;
            this.ckb_A.Visible = false;
            // 
            // ckb_B
            // 
            this.ckb_B.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_B.AutoSize = true;
            this.ckb_B.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.ckb_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ckb_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckb_B.Location = new System.Drawing.Point(3, 49);
            this.ckb_B.Name = "ckb_B";
            this.ckb_B.Size = new System.Drawing.Size(21, 22);
            this.ckb_B.TabIndex = 1;
            this.ckb_B.TabStop = false;
            this.ckb_B.Text = "B";
            this.ckb_B.UseVisualStyleBackColor = true;
            this.ckb_B.Visible = false;
            // 
            // ckb_C
            // 
            this.ckb_C.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_C.AutoSize = true;
            this.ckb_C.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.ckb_C.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ckb_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckb_C.Location = new System.Drawing.Point(3, 95);
            this.ckb_C.Name = "ckb_C";
            this.ckb_C.Size = new System.Drawing.Size(21, 22);
            this.ckb_C.TabIndex = 2;
            this.ckb_C.TabStop = false;
            this.ckb_C.Text = "C";
            this.ckb_C.UseVisualStyleBackColor = true;
            this.ckb_C.Visible = false;
            // 
            // ckb_D
            // 
            this.ckb_D.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_D.AutoSize = true;
            this.ckb_D.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.ckb_D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ckb_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckb_D.Location = new System.Drawing.Point(3, 141);
            this.ckb_D.Name = "ckb_D";
            this.ckb_D.Size = new System.Drawing.Size(21, 22);
            this.ckb_D.TabIndex = 3;
            this.ckb_D.TabStop = false;
            this.ckb_D.Text = "D";
            this.ckb_D.UseVisualStyleBackColor = true;
            this.ckb_D.Visible = false;
            // 
            // ckb_E
            // 
            this.ckb_E.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_E.AutoSize = true;
            this.ckb_E.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.ckb_E.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ckb_E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckb_E.Location = new System.Drawing.Point(3, 187);
            this.ckb_E.Name = "ckb_E";
            this.ckb_E.Size = new System.Drawing.Size(21, 22);
            this.ckb_E.TabIndex = 4;
            this.ckb_E.TabStop = false;
            this.ckb_E.Text = "E";
            this.ckb_E.UseVisualStyleBackColor = true;
            this.ckb_E.Visible = false;
            // 
            // rtb_answerA
            // 
            this.rtb_answerA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_answerA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_answerA.Location = new System.Drawing.Point(43, 3);
            this.rtb_answerA.Name = "rtb_answerA";
            this.rtb_answerA.ReadOnly = true;
            this.rtb_answerA.ShortcutsEnabled = false;
            this.rtb_answerA.Size = new System.Drawing.Size(290, 40);
            this.rtb_answerA.TabIndex = 5;
            this.rtb_answerA.TabStop = false;
            this.rtb_answerA.Text = "";
            this.rtb_answerA.Visible = false;
            // 
            // ckb_F
            // 
            this.ckb_F.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_F.AutoSize = true;
            this.ckb_F.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.ckb_F.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ckb_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckb_F.Location = new System.Drawing.Point(3, 233);
            this.ckb_F.Name = "ckb_F";
            this.ckb_F.Size = new System.Drawing.Size(21, 22);
            this.ckb_F.TabIndex = 4;
            this.ckb_F.TabStop = false;
            this.ckb_F.Text = "F";
            this.ckb_F.UseVisualStyleBackColor = true;
            this.ckb_F.Visible = false;
            // 
            // ckb_G
            // 
            this.ckb_G.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_G.AutoSize = true;
            this.ckb_G.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.ckb_G.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ckb_G.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckb_G.Location = new System.Drawing.Point(3, 279);
            this.ckb_G.Name = "ckb_G";
            this.ckb_G.Size = new System.Drawing.Size(21, 22);
            this.ckb_G.TabIndex = 4;
            this.ckb_G.TabStop = false;
            this.ckb_G.Text = "G";
            this.ckb_G.UseVisualStyleBackColor = true;
            this.ckb_G.Visible = false;
            // 
            // ckb_H
            // 
            this.ckb_H.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_H.AutoSize = true;
            this.ckb_H.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.ckb_H.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ckb_H.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckb_H.Location = new System.Drawing.Point(3, 325);
            this.ckb_H.Name = "ckb_H";
            this.ckb_H.Size = new System.Drawing.Size(21, 22);
            this.ckb_H.TabIndex = 4;
            this.ckb_H.TabStop = false;
            this.ckb_H.Text = "H";
            this.ckb_H.UseVisualStyleBackColor = true;
            this.ckb_H.Visible = false;
            // 
            // rtb_answerF
            // 
            this.rtb_answerF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_answerF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_answerF.Location = new System.Drawing.Point(43, 233);
            this.rtb_answerF.Name = "rtb_answerF";
            this.rtb_answerF.ReadOnly = true;
            this.rtb_answerF.ShortcutsEnabled = false;
            this.rtb_answerF.Size = new System.Drawing.Size(290, 40);
            this.rtb_answerF.TabIndex = 9;
            this.rtb_answerF.TabStop = false;
            this.rtb_answerF.Text = "";
            this.rtb_answerF.Visible = false;
            // 
            // rtb_answerG
            // 
            this.rtb_answerG.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_answerG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_answerG.Location = new System.Drawing.Point(43, 279);
            this.rtb_answerG.Name = "rtb_answerG";
            this.rtb_answerG.ReadOnly = true;
            this.rtb_answerG.ShortcutsEnabled = false;
            this.rtb_answerG.Size = new System.Drawing.Size(290, 40);
            this.rtb_answerG.TabIndex = 9;
            this.rtb_answerG.TabStop = false;
            this.rtb_answerG.Text = "";
            this.rtb_answerG.Visible = false;
            // 
            // rtb_answerH
            // 
            this.rtb_answerH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_answerH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_answerH.Location = new System.Drawing.Point(43, 325);
            this.rtb_answerH.Name = "rtb_answerH";
            this.rtb_answerH.ReadOnly = true;
            this.rtb_answerH.ShortcutsEnabled = false;
            this.rtb_answerH.Size = new System.Drawing.Size(290, 40);
            this.rtb_answerH.TabIndex = 9;
            this.rtb_answerH.TabStop = false;
            this.rtb_answerH.Text = "";
            this.rtb_answerH.Visible = false;
            // 
            // btn_stopReading
            // 
            this.btn_stopReading.BackColor = System.Drawing.Color.Transparent;
            this.btn_stopReading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stopReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_stopReading.Location = new System.Drawing.Point(711, 0);
            this.btn_stopReading.Name = "btn_stopReading";
            this.btn_stopReading.Size = new System.Drawing.Size(55, 19);
            this.btn_stopReading.TabIndex = 24;
            this.btn_stopReading.Text = "Stop";
            this.btn_stopReading.UseVisualStyleBackColor = false;
            this.btn_stopReading.Visible = false;
            this.btn_stopReading.Click += new System.EventHandler(this.btn_stopReading_Click);
            // 
            // bn_readText
            // 
            this.bn_readText.BackColor = System.Drawing.Color.Transparent;
            this.bn_readText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_readText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bn_readText.Location = new System.Drawing.Point(348, -1);
            this.bn_readText.Name = "bn_readText";
            this.bn_readText.Size = new System.Drawing.Size(75, 19);
            this.bn_readText.TabIndex = 24;
            this.bn_readText.Text = "ReadText";
            this.bn_readText.UseVisualStyleBackColor = false;
            this.bn_readText.Click += new System.EventHandler(this.bn_readText_Click);
            // 
            // lbl_readingIndication
            // 
            this.lbl_readingIndication.BackColor = System.Drawing.Color.Teal;
            this.lbl_readingIndication.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_readingIndication.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_readingIndication.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_readingIndication.Location = new System.Drawing.Point(348, -1);
            this.lbl_readingIndication.Name = "lbl_readingIndication";
            this.lbl_readingIndication.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_readingIndication.Size = new System.Drawing.Size(416, 20);
            this.lbl_readingIndication.TabIndex = 5;
            this.lbl_readingIndication.Text = "Beginning";
            // 
            // rtab_SumQuestion
            // 
            this.rtab_SumQuestion.Controls.Add(this.llbl_rightAnswer);
            this.rtab_SumQuestion.Controls.Add(this.flowLayoutPanel2);
            this.rtab_SumQuestion.Location = new System.Drawing.Point(4, 25);
            this.rtab_SumQuestion.Name = "rtab_SumQuestion";
            this.rtab_SumQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.rtab_SumQuestion.Size = new System.Drawing.Size(763, 481);
            this.rtab_SumQuestion.TabIndex = 1;
            this.rtab_SumQuestion.Text = "rSumQuestion";
            this.rtab_SumQuestion.UseVisualStyleBackColor = true;
            // 
            // llbl_rightAnswer
            // 
            this.llbl_rightAnswer.AutoSize = true;
            this.llbl_rightAnswer.Location = new System.Drawing.Point(7, 96);
            this.llbl_rightAnswer.Name = "llbl_rightAnswer";
            this.llbl_rightAnswer.Size = new System.Drawing.Size(71, 12);
            this.llbl_rightAnswer.TabIndex = 2;
            this.llbl_rightAnswer.Text = "rightAnswer";
            this.llbl_rightAnswer.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rtb_sumPassage);
            this.flowLayoutPanel2.Controls.Add(this.rtb_sumQuestion);
            this.flowLayoutPanel2.Controls.Add(this.tlp_sumAnswers);
            this.flowLayoutPanel2.Controls.Add(this.tlp_Summary);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(77, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(619, 474);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // rtb_sumPassage
            // 
            this.rtb_sumPassage.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_sumPassage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumPassage.Location = new System.Drawing.Point(3, 3);
            this.rtb_sumPassage.Name = "rtb_sumPassage";
            this.rtb_sumPassage.ReadOnly = true;
            this.rtb_sumPassage.ShortcutsEnabled = false;
            this.rtb_sumPassage.Size = new System.Drawing.Size(613, 20);
            this.rtb_sumPassage.TabIndex = 5;
            this.rtb_sumPassage.TabStop = false;
            this.rtb_sumPassage.Text = "";
            this.rtb_sumPassage.Visible = false;
            // 
            // rtb_sumQuestion
            // 
            this.rtb_sumQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_sumQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumQuestion.Location = new System.Drawing.Point(3, 29);
            this.rtb_sumQuestion.Name = "rtb_sumQuestion";
            this.rtb_sumQuestion.ReadOnly = true;
            this.rtb_sumQuestion.Size = new System.Drawing.Size(613, 17);
            this.rtb_sumQuestion.TabIndex = 2;
            this.rtb_sumQuestion.TabStop = false;
            this.rtb_sumQuestion.Text = "";
            this.rtb_sumQuestion.Visible = false;
            // 
            // tlp_sumAnswers
            // 
            this.tlp_sumAnswers.AutoSize = true;
            this.tlp_sumAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_sumAnswers.BackColor = System.Drawing.Color.Transparent;
            this.tlp_sumAnswers.ColumnCount = 2;
            this.tlp_sumAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_sumAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.tlp_sumAnswers.Location = new System.Drawing.Point(3, 52);
            this.tlp_sumAnswers.Name = "tlp_sumAnswers";
            this.tlp_sumAnswers.RowCount = 5;
            this.tlp_sumAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_sumAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_sumAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_sumAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_sumAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_sumAnswers.Size = new System.Drawing.Size(613, 130);
            this.tlp_sumAnswers.TabIndex = 3;
            // 
            // rtb_SumSelected5
            // 
            this.rtb_SumSelected5.BackColor = System.Drawing.Color.LightGray;
            this.rtb_SumSelected5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_SumSelected5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_SumSelected5.Location = new System.Drawing.Point(43, 107);
            this.rtb_SumSelected5.Name = "rtb_SumSelected5";
            this.rtb_SumSelected5.ReadOnly = true;
            this.rtb_SumSelected5.ShortcutsEnabled = false;
            this.rtb_SumSelected5.Size = new System.Drawing.Size(567, 20);
            this.rtb_SumSelected5.TabIndex = 1;
            this.rtb_SumSelected5.TabStop = false;
            this.rtb_SumSelected5.Text = "";
            this.rtb_SumSelected5.Visible = false;
            // 
            // rtb_SumSelected1
            // 
            this.rtb_SumSelected1.BackColor = System.Drawing.Color.LightGray;
            this.rtb_SumSelected1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_SumSelected1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_SumSelected1.Location = new System.Drawing.Point(43, 3);
            this.rtb_SumSelected1.Name = "rtb_SumSelected1";
            this.rtb_SumSelected1.ReadOnly = true;
            this.rtb_SumSelected1.ShortcutsEnabled = false;
            this.rtb_SumSelected1.Size = new System.Drawing.Size(567, 17);
            this.rtb_SumSelected1.TabIndex = 0;
            this.rtb_SumSelected1.TabStop = false;
            this.rtb_SumSelected1.Text = "";
            this.rtb_SumSelected1.Visible = false;
            // 
            // rtb_SumSelected2
            // 
            this.rtb_SumSelected2.BackColor = System.Drawing.Color.LightGray;
            this.rtb_SumSelected2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_SumSelected2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_SumSelected2.Location = new System.Drawing.Point(43, 29);
            this.rtb_SumSelected2.Name = "rtb_SumSelected2";
            this.rtb_SumSelected2.ReadOnly = true;
            this.rtb_SumSelected2.ShortcutsEnabled = false;
            this.rtb_SumSelected2.Size = new System.Drawing.Size(567, 17);
            this.rtb_SumSelected2.TabIndex = 0;
            this.rtb_SumSelected2.TabStop = false;
            this.rtb_SumSelected2.Text = "";
            this.rtb_SumSelected2.Visible = false;
            // 
            // rtb_SumSelected3
            // 
            this.rtb_SumSelected3.BackColor = System.Drawing.Color.LightGray;
            this.rtb_SumSelected3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_SumSelected3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_SumSelected3.Location = new System.Drawing.Point(43, 55);
            this.rtb_SumSelected3.Name = "rtb_SumSelected3";
            this.rtb_SumSelected3.ReadOnly = true;
            this.rtb_SumSelected3.ShortcutsEnabled = false;
            this.rtb_SumSelected3.Size = new System.Drawing.Size(567, 17);
            this.rtb_SumSelected3.TabIndex = 0;
            this.rtb_SumSelected3.TabStop = false;
            this.rtb_SumSelected3.Text = "";
            this.rtb_SumSelected3.Visible = false;
            // 
            // rtb_SumSelected4
            // 
            this.rtb_SumSelected4.BackColor = System.Drawing.Color.LightGray;
            this.rtb_SumSelected4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_SumSelected4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_SumSelected4.Location = new System.Drawing.Point(43, 81);
            this.rtb_SumSelected4.Name = "rtb_SumSelected4";
            this.rtb_SumSelected4.ReadOnly = true;
            this.rtb_SumSelected4.ShortcutsEnabled = false;
            this.rtb_SumSelected4.Size = new System.Drawing.Size(567, 17);
            this.rtb_SumSelected4.TabIndex = 0;
            this.rtb_SumSelected4.TabStop = false;
            this.rtb_SumSelected4.Text = "";
            this.rtb_SumSelected4.Visible = false;
            // 
            // ckb_SumSelected1
            // 
            this.ckb_SumSelected1.AutoSize = true;
            this.ckb_SumSelected1.BackColor = System.Drawing.Color.LightGray;
            this.ckb_SumSelected1.Checked = true;
            this.ckb_SumSelected1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_SumSelected1.Location = new System.Drawing.Point(3, 3);
            this.ckb_SumSelected1.Name = "ckb_SumSelected1";
            this.ckb_SumSelected1.Size = new System.Drawing.Size(15, 14);
            this.ckb_SumSelected1.TabIndex = 2;
            this.ckb_SumSelected1.TabStop = false;
            this.ckb_SumSelected1.UseVisualStyleBackColor = false;
            this.ckb_SumSelected1.Visible = false;
            // 
            // ckb_SumSelected2
            // 
            this.ckb_SumSelected2.AutoSize = true;
            this.ckb_SumSelected2.BackColor = System.Drawing.Color.LightGray;
            this.ckb_SumSelected2.Checked = true;
            this.ckb_SumSelected2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_SumSelected2.Location = new System.Drawing.Point(3, 29);
            this.ckb_SumSelected2.Name = "ckb_SumSelected2";
            this.ckb_SumSelected2.Size = new System.Drawing.Size(15, 14);
            this.ckb_SumSelected2.TabIndex = 2;
            this.ckb_SumSelected2.TabStop = false;
            this.ckb_SumSelected2.UseVisualStyleBackColor = false;
            this.ckb_SumSelected2.Visible = false;
            // 
            // ckb_SumSelected3
            // 
            this.ckb_SumSelected3.AutoSize = true;
            this.ckb_SumSelected3.BackColor = System.Drawing.Color.LightGray;
            this.ckb_SumSelected3.Checked = true;
            this.ckb_SumSelected3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_SumSelected3.Location = new System.Drawing.Point(3, 55);
            this.ckb_SumSelected3.Name = "ckb_SumSelected3";
            this.ckb_SumSelected3.Size = new System.Drawing.Size(15, 14);
            this.ckb_SumSelected3.TabIndex = 2;
            this.ckb_SumSelected3.TabStop = false;
            this.ckb_SumSelected3.UseVisualStyleBackColor = false;
            this.ckb_SumSelected3.Visible = false;
            // 
            // ckb_SumSelected4
            // 
            this.ckb_SumSelected4.AutoSize = true;
            this.ckb_SumSelected4.BackColor = System.Drawing.Color.LightGray;
            this.ckb_SumSelected4.Checked = true;
            this.ckb_SumSelected4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_SumSelected4.Location = new System.Drawing.Point(3, 81);
            this.ckb_SumSelected4.Name = "ckb_SumSelected4";
            this.ckb_SumSelected4.Size = new System.Drawing.Size(15, 14);
            this.ckb_SumSelected4.TabIndex = 2;
            this.ckb_SumSelected4.TabStop = false;
            this.ckb_SumSelected4.UseVisualStyleBackColor = false;
            this.ckb_SumSelected4.Visible = false;
            // 
            // ckb_SumSelected5
            // 
            this.ckb_SumSelected5.AutoSize = true;
            this.ckb_SumSelected5.BackColor = System.Drawing.Color.LightGray;
            this.ckb_SumSelected5.Checked = true;
            this.ckb_SumSelected5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_SumSelected5.Location = new System.Drawing.Point(3, 107);
            this.ckb_SumSelected5.Name = "ckb_SumSelected5";
            this.ckb_SumSelected5.Size = new System.Drawing.Size(15, 14);
            this.ckb_SumSelected5.TabIndex = 2;
            this.ckb_SumSelected5.TabStop = false;
            this.ckb_SumSelected5.UseVisualStyleBackColor = false;
            this.ckb_SumSelected5.Visible = false;
            // 
            // tlp_Summary
            // 
            this.tlp_Summary.AutoSize = true;
            this.tlp_Summary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Summary.ColumnCount = 2;
            this.tlp_Summary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Summary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.tlp_Summary.Location = new System.Drawing.Point(3, 188);
            this.tlp_Summary.Name = "tlp_Summary";
            this.tlp_Summary.RowCount = 10;
            this.tlp_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Summary.Size = new System.Drawing.Size(613, 260);
            this.tlp_Summary.TabIndex = 4;
            // 
            // rtb_sumAnswer5
            // 
            this.rtb_sumAnswer5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_sumAnswer5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumAnswer5.Location = new System.Drawing.Point(43, 107);
            this.rtb_sumAnswer5.Name = "rtb_sumAnswer5";
            this.rtb_sumAnswer5.ReadOnly = true;
            this.rtb_sumAnswer5.ShortcutsEnabled = false;
            this.rtb_sumAnswer5.Size = new System.Drawing.Size(567, 20);
            this.rtb_sumAnswer5.TabIndex = 1;
            this.rtb_sumAnswer5.TabStop = false;
            this.rtb_sumAnswer5.Text = "";
            this.rtb_sumAnswer5.Visible = false;
            // 
            // rtb_sumAnswer1
            // 
            this.rtb_sumAnswer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_sumAnswer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumAnswer1.Location = new System.Drawing.Point(43, 3);
            this.rtb_sumAnswer1.Name = "rtb_sumAnswer1";
            this.rtb_sumAnswer1.ReadOnly = true;
            this.rtb_sumAnswer1.ShortcutsEnabled = false;
            this.rtb_sumAnswer1.Size = new System.Drawing.Size(567, 20);
            this.rtb_sumAnswer1.TabIndex = 0;
            this.rtb_sumAnswer1.TabStop = false;
            this.rtb_sumAnswer1.Text = "";
            this.rtb_sumAnswer1.Visible = false;
            // 
            // rtb_sumAnswer2
            // 
            this.rtb_sumAnswer2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_sumAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumAnswer2.Location = new System.Drawing.Point(43, 29);
            this.rtb_sumAnswer2.Name = "rtb_sumAnswer2";
            this.rtb_sumAnswer2.ReadOnly = true;
            this.rtb_sumAnswer2.ShortcutsEnabled = false;
            this.rtb_sumAnswer2.Size = new System.Drawing.Size(567, 20);
            this.rtb_sumAnswer2.TabIndex = 0;
            this.rtb_sumAnswer2.TabStop = false;
            this.rtb_sumAnswer2.Text = "";
            this.rtb_sumAnswer2.Visible = false;
            // 
            // rtb_sumAnswer3
            // 
            this.rtb_sumAnswer3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_sumAnswer3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumAnswer3.Location = new System.Drawing.Point(43, 55);
            this.rtb_sumAnswer3.Name = "rtb_sumAnswer3";
            this.rtb_sumAnswer3.ReadOnly = true;
            this.rtb_sumAnswer3.ShortcutsEnabled = false;
            this.rtb_sumAnswer3.Size = new System.Drawing.Size(567, 20);
            this.rtb_sumAnswer3.TabIndex = 0;
            this.rtb_sumAnswer3.TabStop = false;
            this.rtb_sumAnswer3.Text = "";
            this.rtb_sumAnswer3.Visible = false;
            // 
            // rtb_sumAnswer4
            // 
            this.rtb_sumAnswer4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_sumAnswer4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumAnswer4.Location = new System.Drawing.Point(43, 81);
            this.rtb_sumAnswer4.Name = "rtb_sumAnswer4";
            this.rtb_sumAnswer4.ReadOnly = true;
            this.rtb_sumAnswer4.ShortcutsEnabled = false;
            this.rtb_sumAnswer4.Size = new System.Drawing.Size(567, 20);
            this.rtb_sumAnswer4.TabIndex = 0;
            this.rtb_sumAnswer4.TabStop = false;
            this.rtb_sumAnswer4.Text = "";
            this.rtb_sumAnswer4.Visible = false;
            // 
            // ckb_sumAnswer1
            // 
            this.ckb_sumAnswer1.AutoSize = true;
            this.ckb_sumAnswer1.Enabled = false;
            this.ckb_sumAnswer1.Location = new System.Drawing.Point(3, 3);
            this.ckb_sumAnswer1.Name = "ckb_sumAnswer1";
            this.ckb_sumAnswer1.Size = new System.Drawing.Size(30, 16);
            this.ckb_sumAnswer1.TabIndex = 2;
            this.ckb_sumAnswer1.TabStop = false;
            this.ckb_sumAnswer1.Text = "A";
            this.ckb_sumAnswer1.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer1.Visible = false;
            // 
            // ckb_sumAnswer2
            // 
            this.ckb_sumAnswer2.AutoSize = true;
            this.ckb_sumAnswer2.Enabled = false;
            this.ckb_sumAnswer2.Location = new System.Drawing.Point(3, 29);
            this.ckb_sumAnswer2.Name = "ckb_sumAnswer2";
            this.ckb_sumAnswer2.Size = new System.Drawing.Size(30, 16);
            this.ckb_sumAnswer2.TabIndex = 2;
            this.ckb_sumAnswer2.TabStop = false;
            this.ckb_sumAnswer2.Text = "B";
            this.ckb_sumAnswer2.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer2.Visible = false;
            // 
            // ckb_sumAnswer3
            // 
            this.ckb_sumAnswer3.AutoSize = true;
            this.ckb_sumAnswer3.Enabled = false;
            this.ckb_sumAnswer3.Location = new System.Drawing.Point(3, 55);
            this.ckb_sumAnswer3.Name = "ckb_sumAnswer3";
            this.ckb_sumAnswer3.Size = new System.Drawing.Size(30, 16);
            this.ckb_sumAnswer3.TabIndex = 2;
            this.ckb_sumAnswer3.TabStop = false;
            this.ckb_sumAnswer3.Text = "C";
            this.ckb_sumAnswer3.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer3.Visible = false;
            // 
            // ckb_sumAnswer4
            // 
            this.ckb_sumAnswer4.AutoSize = true;
            this.ckb_sumAnswer4.Enabled = false;
            this.ckb_sumAnswer4.Location = new System.Drawing.Point(3, 81);
            this.ckb_sumAnswer4.Name = "ckb_sumAnswer4";
            this.ckb_sumAnswer4.Size = new System.Drawing.Size(30, 16);
            this.ckb_sumAnswer4.TabIndex = 2;
            this.ckb_sumAnswer4.TabStop = false;
            this.ckb_sumAnswer4.Text = "D";
            this.ckb_sumAnswer4.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer4.Visible = false;
            // 
            // ckb_sumAnswer5
            // 
            this.ckb_sumAnswer5.AutoSize = true;
            this.ckb_sumAnswer5.Enabled = false;
            this.ckb_sumAnswer5.Location = new System.Drawing.Point(3, 107);
            this.ckb_sumAnswer5.Name = "ckb_sumAnswer5";
            this.ckb_sumAnswer5.Size = new System.Drawing.Size(30, 16);
            this.ckb_sumAnswer5.TabIndex = 2;
            this.ckb_sumAnswer5.TabStop = false;
            this.ckb_sumAnswer5.Text = "E";
            this.ckb_sumAnswer5.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer5.Visible = false;
            // 
            // ckb_sumAnswer6
            // 
            this.ckb_sumAnswer6.AutoSize = true;
            this.ckb_sumAnswer6.Enabled = false;
            this.ckb_sumAnswer6.Location = new System.Drawing.Point(3, 133);
            this.ckb_sumAnswer6.Name = "ckb_sumAnswer6";
            this.ckb_sumAnswer6.Size = new System.Drawing.Size(30, 16);
            this.ckb_sumAnswer6.TabIndex = 2;
            this.ckb_sumAnswer6.TabStop = false;
            this.ckb_sumAnswer6.Text = "F";
            this.ckb_sumAnswer6.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer6.Visible = false;
            // 
            // rtb_sumAnswer6
            // 
            this.rtb_sumAnswer6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_sumAnswer6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumAnswer6.Location = new System.Drawing.Point(43, 133);
            this.rtb_sumAnswer6.Name = "rtb_sumAnswer6";
            this.rtb_sumAnswer6.ReadOnly = true;
            this.rtb_sumAnswer6.ShortcutsEnabled = false;
            this.rtb_sumAnswer6.Size = new System.Drawing.Size(567, 20);
            this.rtb_sumAnswer6.TabIndex = 1;
            this.rtb_sumAnswer6.TabStop = false;
            this.rtb_sumAnswer6.Text = "";
            this.rtb_sumAnswer6.Visible = false;
            // 
            // ckb_sumAnswer7
            // 
            this.ckb_sumAnswer7.AutoSize = true;
            this.ckb_sumAnswer7.Enabled = false;
            this.ckb_sumAnswer7.Location = new System.Drawing.Point(3, 159);
            this.ckb_sumAnswer7.Name = "ckb_sumAnswer7";
            this.ckb_sumAnswer7.Size = new System.Drawing.Size(30, 16);
            this.ckb_sumAnswer7.TabIndex = 2;
            this.ckb_sumAnswer7.TabStop = false;
            this.ckb_sumAnswer7.Text = "G";
            this.ckb_sumAnswer7.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer7.Visible = false;
            // 
            // ckb_sumAnswer8
            // 
            this.ckb_sumAnswer8.AutoSize = true;
            this.ckb_sumAnswer8.Enabled = false;
            this.ckb_sumAnswer8.Location = new System.Drawing.Point(3, 185);
            this.ckb_sumAnswer8.Name = "ckb_sumAnswer8";
            this.ckb_sumAnswer8.Size = new System.Drawing.Size(30, 16);
            this.ckb_sumAnswer8.TabIndex = 2;
            this.ckb_sumAnswer8.TabStop = false;
            this.ckb_sumAnswer8.Text = "H";
            this.ckb_sumAnswer8.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer8.Visible = false;
            // 
            // rtb_sumAnswer7
            // 
            this.rtb_sumAnswer7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_sumAnswer7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumAnswer7.Location = new System.Drawing.Point(43, 159);
            this.rtb_sumAnswer7.Name = "rtb_sumAnswer7";
            this.rtb_sumAnswer7.ReadOnly = true;
            this.rtb_sumAnswer7.ShortcutsEnabled = false;
            this.rtb_sumAnswer7.Size = new System.Drawing.Size(567, 20);
            this.rtb_sumAnswer7.TabIndex = 1;
            this.rtb_sumAnswer7.TabStop = false;
            this.rtb_sumAnswer7.Text = "";
            this.rtb_sumAnswer7.Visible = false;
            // 
            // rtb_sumAnswer8
            // 
            this.rtb_sumAnswer8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_sumAnswer8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumAnswer8.Location = new System.Drawing.Point(43, 185);
            this.rtb_sumAnswer8.Name = "rtb_sumAnswer8";
            this.rtb_sumAnswer8.ReadOnly = true;
            this.rtb_sumAnswer8.ShortcutsEnabled = false;
            this.rtb_sumAnswer8.Size = new System.Drawing.Size(567, 20);
            this.rtb_sumAnswer8.TabIndex = 1;
            this.rtb_sumAnswer8.TabStop = false;
            this.rtb_sumAnswer8.Text = "";
            this.rtb_sumAnswer8.Visible = false;
            // 
            // ckb_sumAnswer9
            // 
            this.ckb_sumAnswer9.AutoSize = true;
            this.ckb_sumAnswer9.Enabled = false;
            this.ckb_sumAnswer9.Location = new System.Drawing.Point(3, 211);
            this.ckb_sumAnswer9.Name = "ckb_sumAnswer9";
            this.ckb_sumAnswer9.Size = new System.Drawing.Size(30, 16);
            this.ckb_sumAnswer9.TabIndex = 2;
            this.ckb_sumAnswer9.TabStop = false;
            this.ckb_sumAnswer9.Text = "I";
            this.ckb_sumAnswer9.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer9.Visible = false;
            // 
            // ckb_sumAnswer10
            // 
            this.ckb_sumAnswer10.AutoSize = true;
            this.ckb_sumAnswer10.Enabled = false;
            this.ckb_sumAnswer10.Location = new System.Drawing.Point(3, 237);
            this.ckb_sumAnswer10.Name = "ckb_sumAnswer10";
            this.ckb_sumAnswer10.Size = new System.Drawing.Size(30, 16);
            this.ckb_sumAnswer10.TabIndex = 2;
            this.ckb_sumAnswer10.Text = "J";
            this.ckb_sumAnswer10.UseVisualStyleBackColor = true;
            this.ckb_sumAnswer10.Visible = false;
            // 
            // rtb_sumAnswer9
            // 
            this.rtb_sumAnswer9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_sumAnswer9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumAnswer9.Location = new System.Drawing.Point(43, 211);
            this.rtb_sumAnswer9.Name = "rtb_sumAnswer9";
            this.rtb_sumAnswer9.ReadOnly = true;
            this.rtb_sumAnswer9.ShortcutsEnabled = false;
            this.rtb_sumAnswer9.Size = new System.Drawing.Size(567, 20);
            this.rtb_sumAnswer9.TabIndex = 1;
            this.rtb_sumAnswer9.TabStop = false;
            this.rtb_sumAnswer9.Text = "";
            this.rtb_sumAnswer9.Visible = false;
            // 
            // rtb_sumAnswer10
            // 
            this.rtb_sumAnswer10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_sumAnswer10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sumAnswer10.Location = new System.Drawing.Point(43, 237);
            this.rtb_sumAnswer10.Name = "rtb_sumAnswer10";
            this.rtb_sumAnswer10.ReadOnly = true;
            this.rtb_sumAnswer10.ShortcutsEnabled = false;
            this.rtb_sumAnswer10.Size = new System.Drawing.Size(567, 20);
            this.rtb_sumAnswer10.TabIndex = 1;
            this.rtb_sumAnswer10.Text = "";
            this.rtb_sumAnswer10.Visible = false;
            // 
            // rtab_Review
            // 
            this.rtab_Review.Controls.Add(this.lbl_scoreReport);
            this.rtab_Review.Controls.Add(this.lbl_wrongAnswered);
            this.rtab_Review.Controls.Add(this.pb_wrongAnswered);
            this.rtab_Review.Controls.Add(this.lbl_rightAnswered);
            this.rtab_Review.Controls.Add(this.pb_rightAnswered);
            this.rtab_Review.Controls.Add(this.label1);
            this.rtab_Review.Controls.Add(this.pictureBox5);
            this.rtab_Review.Controls.Add(this.dgv_readingReview);
            this.rtab_Review.Location = new System.Drawing.Point(4, 25);
            this.rtab_Review.Name = "rtab_Review";
            this.rtab_Review.Size = new System.Drawing.Size(763, 481);
            this.rtab_Review.TabIndex = 2;
            this.rtab_Review.Text = "rReview";
            this.rtab_Review.UseVisualStyleBackColor = true;
            // 
            // lbl_scoreReport
            // 
            this.lbl_scoreReport.AutoSize = true;
            this.lbl_scoreReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_scoreReport.Location = new System.Drawing.Point(68, 19);
            this.lbl_scoreReport.Name = "lbl_scoreReport";
            this.lbl_scoreReport.Size = new System.Drawing.Size(97, 17);
            this.lbl_scoreReport.TabIndex = 5;
            this.lbl_scoreReport.Text = "scoreReport";
            // 
            // lbl_wrongAnswered
            // 
            this.lbl_wrongAnswered.AutoSize = true;
            this.lbl_wrongAnswered.Location = new System.Drawing.Point(339, 53);
            this.lbl_wrongAnswered.Name = "lbl_wrongAnswered";
            this.lbl_wrongAnswered.Size = new System.Drawing.Size(89, 12);
            this.lbl_wrongAnswered.TabIndex = 4;
            this.lbl_wrongAnswered.Text = "Wrong Answered";
            // 
            // pb_wrongAnswered
            // 
            this.pb_wrongAnswered.BackColor = System.Drawing.Color.Yellow;
            this.pb_wrongAnswered.Location = new System.Drawing.Point(306, 44);
            this.pb_wrongAnswered.Name = "pb_wrongAnswered";
            this.pb_wrongAnswered.Size = new System.Drawing.Size(27, 20);
            this.pb_wrongAnswered.TabIndex = 3;
            this.pb_wrongAnswered.TabStop = false;
            // 
            // lbl_rightAnswered
            // 
            this.lbl_rightAnswered.AutoSize = true;
            this.lbl_rightAnswered.Location = new System.Drawing.Point(222, 53);
            this.lbl_rightAnswered.Name = "lbl_rightAnswered";
            this.lbl_rightAnswered.Size = new System.Drawing.Size(89, 12);
            this.lbl_rightAnswered.TabIndex = 4;
            this.lbl_rightAnswered.Text = "Right Answered";
            // 
            // pb_rightAnswered
            // 
            this.pb_rightAnswered.BackColor = System.Drawing.Color.Green;
            this.pb_rightAnswered.Location = new System.Drawing.Point(189, 44);
            this.pb_rightAnswered.Name = "pb_rightAnswered";
            this.pb_rightAnswered.Size = new System.Drawing.Size(27, 20);
            this.pb_rightAnswered.TabIndex = 3;
            this.pb_rightAnswered.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Not Answered";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Red;
            this.pictureBox5.Location = new System.Drawing.Point(71, 44);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 20);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // dgv_readingReview
            // 
            this.dgv_readingReview.AllowUserToAddRows = false;
            this.dgv_readingReview.AllowUserToDeleteRows = false;
            this.dgv_readingReview.AllowUserToResizeColumns = false;
            this.dgv_readingReview.AllowUserToResizeRows = false;
            this.dgv_readingReview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_readingReview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_readingReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_readingReview.Location = new System.Drawing.Point(71, 70);
            this.dgv_readingReview.MultiSelect = false;
            this.dgv_readingReview.Name = "dgv_readingReview";
            this.dgv_readingReview.ReadOnly = true;
            this.dgv_readingReview.RowHeadersVisible = false;
            this.dgv_readingReview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_readingReview.RowTemplate.Height = 23;
            this.dgv_readingReview.RowTemplate.ReadOnly = true;
            this.dgv_readingReview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_readingReview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_readingReview.Size = new System.Drawing.Size(644, 313);
            this.dgv_readingReview.TabIndex = 2;
            this.dgv_readingReview.TabStop = false;
            this.dgv_readingReview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_readingReview_CellContentClick);
            this.dgv_readingReview.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_readingReview_ColumnHeaderMouseClick);
            this.dgv_readingReview.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_readingReview_DataBindingComplete);
            // 
            // tab_Listening
            // 
            this.tab_Listening.Controls.Add(this.tabf_Listening);
            this.tab_Listening.Location = new System.Drawing.Point(4, 22);
            this.tab_Listening.Name = "tab_Listening";
            this.tab_Listening.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Listening.Size = new System.Drawing.Size(780, 484);
            this.tab_Listening.TabIndex = 1;
            this.tab_Listening.Text = "Listening";
            this.tab_Listening.UseVisualStyleBackColor = true;
            // 
            // tabf_Listening
            // 
            this.tabf_Listening.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabf_Listening.Controls.Add(this.ltab_Direction1);
            this.tabf_Listening.Controls.Add(this.ltab_Direction2);
            this.tabf_Listening.Controls.Add(this.ltab_Materials);
            this.tabf_Listening.Controls.Add(this.lMaterials1);
            this.tabf_Listening.Controls.Add(this.ltab_Question);
            this.tabf_Listening.Controls.Add(this.lTableQuestion);
            this.tabf_Listening.Location = new System.Drawing.Point(4, -24);
            this.tabf_Listening.Name = "tabf_Listening";
            this.tabf_Listening.SelectedIndex = 0;
            this.tabf_Listening.Size = new System.Drawing.Size(780, 514);
            this.tabf_Listening.TabIndex = 1;
            this.tabf_Listening.TabStop = false;
            // 
            // ltab_Direction1
            // 
            this.ltab_Direction1.Controls.Add(this.pictureBox1);
            this.ltab_Direction1.Location = new System.Drawing.Point(4, 25);
            this.ltab_Direction1.Name = "ltab_Direction1";
            this.ltab_Direction1.Padding = new System.Windows.Forms.Padding(3);
            this.ltab_Direction1.Size = new System.Drawing.Size(772, 485);
            this.ltab_Direction1.TabIndex = 0;
            this.ltab_Direction1.Text = "lDirection1";
            this.ltab_Direction1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Properties.Resources.ListeningDirection3;
            this.pictureBox1.Location = new System.Drawing.Point(28, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1126, 492);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ltab_Direction2
            // 
            this.ltab_Direction2.Location = new System.Drawing.Point(4, 25);
            this.ltab_Direction2.Name = "ltab_Direction2";
            this.ltab_Direction2.Size = new System.Drawing.Size(772, 485);
            this.ltab_Direction2.TabIndex = 3;
            this.ltab_Direction2.Text = "lDirection2";
            this.ltab_Direction2.UseVisualStyleBackColor = true;
            // 
            // ltab_Materials
            // 
            this.ltab_Materials.Controls.Add(this.l_splitContainer);
            this.ltab_Materials.Location = new System.Drawing.Point(4, 25);
            this.ltab_Materials.Name = "ltab_Materials";
            this.ltab_Materials.Padding = new System.Windows.Forms.Padding(3);
            this.ltab_Materials.Size = new System.Drawing.Size(772, 485);
            this.ltab_Materials.TabIndex = 1;
            this.ltab_Materials.Text = "lMaterials";
            this.ltab_Materials.UseVisualStyleBackColor = true;
            // 
            // l_splitContainer
            // 
            this.l_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_splitContainer.IsSplitterFixed = true;
            this.l_splitContainer.Location = new System.Drawing.Point(3, 3);
            this.l_splitContainer.Name = "l_splitContainer";
            // 
            // l_splitContainer.Panel1
            // 
            this.l_splitContainer.Panel1.Controls.Add(this.pb_currentpos);
            this.l_splitContainer.Panel1.Controls.Add(this.tb_currentpos);
            this.l_splitContainer.Panel1.Controls.Add(this.PlayFileName);
            this.l_splitContainer.Panel1.Controls.Add(this.pb_ListenScene);
            // 
            // l_splitContainer.Panel2
            // 
            this.l_splitContainer.Panel2.AutoScroll = true;
            this.l_splitContainer.Panel2.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.l_splitContainer.Panel2.Controls.Add(this.panel1);
            this.l_splitContainer.Size = new System.Drawing.Size(766, 482);
            this.l_splitContainer.SplitterDistance = 342;
            this.l_splitContainer.TabIndex = 1;
            // 
            // pb_currentpos
            // 
            this.pb_currentpos.Location = new System.Drawing.Point(18, 380);
            this.pb_currentpos.Name = "pb_currentpos";
            this.pb_currentpos.Size = new System.Drawing.Size(308, 21);
            this.pb_currentpos.TabIndex = 38;
            // 
            // tb_currentpos
            // 
            this.tb_currentpos.AutoSize = false;
            this.tb_currentpos.Location = new System.Drawing.Point(18, 7);
            this.tb_currentpos.Name = "tb_currentpos";
            this.tb_currentpos.Size = new System.Drawing.Size(308, 18);
            this.tb_currentpos.TabIndex = 36;
            this.tb_currentpos.TabStop = false;
            this.tb_currentpos.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_currentpos.Visible = false;
            this.tb_currentpos.Scroll += new System.EventHandler(this.tb_currentpos_Scroll);
            // 
            // PlayFileName
            // 
            this.PlayFileName.AutoSize = true;
            this.PlayFileName.Location = new System.Drawing.Point(-25, 443);
            this.PlayFileName.Name = "PlayFileName";
            this.PlayFileName.Size = new System.Drawing.Size(41, 12);
            this.PlayFileName.TabIndex = 35;
            this.PlayFileName.Text = "label1";
            // 
            // pb_ListenScene
            // 
            this.pb_ListenScene.Location = new System.Drawing.Point(18, 47);
            this.pb_ListenScene.Name = "pb_ListenScene";
            this.pb_ListenScene.Size = new System.Drawing.Size(308, 285);
            this.pb_ListenScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ListenScene.TabIndex = 37;
            this.pb_ListenScene.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flp_passage);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 421);
            this.panel1.TabIndex = 29;
            // 
            // flp_passage
            // 
            this.flp_passage.Controls.Add(this.lnk_passage);
            this.flp_passage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_passage.Location = new System.Drawing.Point(3, 11);
            this.flp_passage.Name = "flp_passage";
            this.flp_passage.Size = new System.Drawing.Size(374, 1108);
            this.flp_passage.TabIndex = 28;
            // 
            // lnk_passage
            // 
            this.lnk_passage.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnk_passage.AutoSize = true;
            this.lnk_passage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_passage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnk_passage.LinkColor = System.Drawing.Color.Black;
            this.lnk_passage.Location = new System.Drawing.Point(3, 0);
            this.lnk_passage.Name = "lnk_passage";
            this.lnk_passage.Size = new System.Drawing.Size(26, 17);
            this.lnk_passage.TabIndex = 0;
            this.lnk_passage.TabStop = true;
            this.lnk_passage.Text = "lnk\r\n";
            // 
            // lMaterials1
            // 
            this.lMaterials1.Controls.Add(this.tb_currentpos1);
            this.lMaterials1.Controls.Add(this.pb_currentpos1);
            this.lMaterials1.Controls.Add(this.pb_ListenScene1);
            this.lMaterials1.Location = new System.Drawing.Point(4, 25);
            this.lMaterials1.Name = "lMaterials1";
            this.lMaterials1.Size = new System.Drawing.Size(772, 485);
            this.lMaterials1.TabIndex = 5;
            this.lMaterials1.Text = "lMaterials1";
            this.lMaterials1.UseVisualStyleBackColor = true;
            // 
            // tb_currentpos1
            // 
            this.tb_currentpos1.AutoSize = false;
            this.tb_currentpos1.LargeChange = 1;
            this.tb_currentpos1.Location = new System.Drawing.Point(204, 11);
            this.tb_currentpos1.Name = "tb_currentpos1";
            this.tb_currentpos1.Size = new System.Drawing.Size(400, 18);
            this.tb_currentpos1.TabIndex = 38;
            this.tb_currentpos1.TabStop = false;
            this.tb_currentpos1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_currentpos1.Visible = false;
            this.tb_currentpos1.Scroll += new System.EventHandler(this.tb_currentpos1_Scroll);
            // 
            // pb_currentpos1
            // 
            this.pb_currentpos1.Location = new System.Drawing.Point(204, 405);
            this.pb_currentpos1.Name = "pb_currentpos1";
            this.pb_currentpos1.Size = new System.Drawing.Size(400, 21);
            this.pb_currentpos1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_currentpos1.TabIndex = 40;
            // 
            // pb_ListenScene1
            // 
            this.pb_ListenScene1.Location = new System.Drawing.Point(204, 30);
            this.pb_ListenScene1.Name = "pb_ListenScene1";
            this.pb_ListenScene1.Size = new System.Drawing.Size(400, 369);
            this.pb_ListenScene1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ListenScene1.TabIndex = 39;
            this.pb_ListenScene1.TabStop = false;
            // 
            // ltab_Question
            // 
            this.ltab_Question.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ltab_Question.Controls.Add(this.tableLayoutPanel1);
            this.ltab_Question.Location = new System.Drawing.Point(4, 25);
            this.ltab_Question.Name = "ltab_Question";
            this.ltab_Question.Size = new System.Drawing.Size(772, 485);
            this.ltab_Question.TabIndex = 2;
            this.ltab_Question.Text = "lQuestion";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(87, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 434);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lrtb_question
            // 
            this.lrtb_question.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtb_question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtb_question.Location = new System.Drawing.Point(43, 3);
            this.lrtb_question.Name = "lrtb_question";
            this.lrtb_question.ReadOnly = true;
            this.lrtb_question.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtb_question.ShortcutsEnabled = false;
            this.lrtb_question.Size = new System.Drawing.Size(574, 60);
            this.lrtb_question.TabIndex = 3;
            this.lrtb_question.TabStop = false;
            this.lrtb_question.Text = "";
            // 
            // lrtb_answerE
            // 
            this.lrtb_answerE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtb_answerE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtb_answerE.Location = new System.Drawing.Point(43, 253);
            this.lrtb_answerE.Name = "lrtb_answerE";
            this.lrtb_answerE.ReadOnly = true;
            this.lrtb_answerE.ShortcutsEnabled = false;
            this.lrtb_answerE.Size = new System.Drawing.Size(574, 40);
            this.lrtb_answerE.TabIndex = 9;
            this.lrtb_answerE.TabStop = false;
            this.lrtb_answerE.Text = "";
            this.lrtb_answerE.Visible = false;
            // 
            // lrtb_answerD
            // 
            this.lrtb_answerD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtb_answerD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtb_answerD.Location = new System.Drawing.Point(43, 207);
            this.lrtb_answerD.Name = "lrtb_answerD";
            this.lrtb_answerD.ReadOnly = true;
            this.lrtb_answerD.ShortcutsEnabled = false;
            this.lrtb_answerD.Size = new System.Drawing.Size(574, 40);
            this.lrtb_answerD.TabIndex = 8;
            this.lrtb_answerD.TabStop = false;
            this.lrtb_answerD.Text = "";
            this.lrtb_answerD.Visible = false;
            // 
            // lrtb_answerC
            // 
            this.lrtb_answerC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtb_answerC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtb_answerC.Location = new System.Drawing.Point(43, 161);
            this.lrtb_answerC.Name = "lrtb_answerC";
            this.lrtb_answerC.ReadOnly = true;
            this.lrtb_answerC.ShortcutsEnabled = false;
            this.lrtb_answerC.Size = new System.Drawing.Size(574, 40);
            this.lrtb_answerC.TabIndex = 7;
            this.lrtb_answerC.TabStop = false;
            this.lrtb_answerC.Text = "";
            this.lrtb_answerC.Visible = false;
            // 
            // lrtb_answerB
            // 
            this.lrtb_answerB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtb_answerB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtb_answerB.Location = new System.Drawing.Point(43, 115);
            this.lrtb_answerB.Name = "lrtb_answerB";
            this.lrtb_answerB.ReadOnly = true;
            this.lrtb_answerB.ShortcutsEnabled = false;
            this.lrtb_answerB.Size = new System.Drawing.Size(574, 40);
            this.lrtb_answerB.TabIndex = 6;
            this.lrtb_answerB.TabStop = false;
            this.lrtb_answerB.Text = "";
            this.lrtb_answerB.Visible = false;
            // 
            // lckb_A
            // 
            this.lckb_A.Appearance = System.Windows.Forms.Appearance.Button;
            this.lckb_A.AutoSize = true;
            this.lckb_A.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.lckb_A.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.lckb_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckb_A.Location = new System.Drawing.Point(3, 69);
            this.lckb_A.Name = "lckb_A";
            this.lckb_A.Size = new System.Drawing.Size(21, 22);
            this.lckb_A.TabIndex = 0;
            this.lckb_A.TabStop = false;
            this.lckb_A.Text = "A";
            this.lckb_A.UseVisualStyleBackColor = true;
            this.lckb_A.Visible = false;
            // 
            // lckb_B
            // 
            this.lckb_B.Appearance = System.Windows.Forms.Appearance.Button;
            this.lckb_B.AutoSize = true;
            this.lckb_B.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.lckb_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.lckb_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckb_B.Location = new System.Drawing.Point(3, 115);
            this.lckb_B.Name = "lckb_B";
            this.lckb_B.Size = new System.Drawing.Size(21, 22);
            this.lckb_B.TabIndex = 1;
            this.lckb_B.TabStop = false;
            this.lckb_B.Text = "B";
            this.lckb_B.UseVisualStyleBackColor = true;
            this.lckb_B.Visible = false;
            // 
            // lckb_C
            // 
            this.lckb_C.Appearance = System.Windows.Forms.Appearance.Button;
            this.lckb_C.AutoSize = true;
            this.lckb_C.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.lckb_C.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.lckb_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckb_C.Location = new System.Drawing.Point(3, 161);
            this.lckb_C.Name = "lckb_C";
            this.lckb_C.Size = new System.Drawing.Size(21, 22);
            this.lckb_C.TabIndex = 2;
            this.lckb_C.TabStop = false;
            this.lckb_C.Text = "C";
            this.lckb_C.UseVisualStyleBackColor = true;
            this.lckb_C.Visible = false;
            // 
            // lckb_D
            // 
            this.lckb_D.Appearance = System.Windows.Forms.Appearance.Button;
            this.lckb_D.AutoSize = true;
            this.lckb_D.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.lckb_D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.lckb_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckb_D.Location = new System.Drawing.Point(3, 207);
            this.lckb_D.Name = "lckb_D";
            this.lckb_D.Size = new System.Drawing.Size(21, 22);
            this.lckb_D.TabIndex = 3;
            this.lckb_D.TabStop = false;
            this.lckb_D.Text = "D";
            this.lckb_D.UseVisualStyleBackColor = true;
            this.lckb_D.Visible = false;
            // 
            // lckb_E
            // 
            this.lckb_E.Appearance = System.Windows.Forms.Appearance.Button;
            this.lckb_E.AutoSize = true;
            this.lckb_E.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.lckb_E.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.lckb_E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckb_E.Location = new System.Drawing.Point(3, 253);
            this.lckb_E.Name = "lckb_E";
            this.lckb_E.Size = new System.Drawing.Size(21, 22);
            this.lckb_E.TabIndex = 4;
            this.lckb_E.TabStop = false;
            this.lckb_E.Text = "E";
            this.lckb_E.UseVisualStyleBackColor = true;
            this.lckb_E.Visible = false;
            // 
            // lckb_F
            // 
            this.lckb_F.Appearance = System.Windows.Forms.Appearance.Button;
            this.lckb_F.AutoSize = true;
            this.lckb_F.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.lckb_F.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.lckb_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckb_F.Location = new System.Drawing.Point(3, 299);
            this.lckb_F.Name = "lckb_F";
            this.lckb_F.Size = new System.Drawing.Size(21, 22);
            this.lckb_F.TabIndex = 4;
            this.lckb_F.TabStop = false;
            this.lckb_F.Text = "F";
            this.lckb_F.UseVisualStyleBackColor = true;
            this.lckb_F.Visible = false;
            // 
            // lckb_G
            // 
            this.lckb_G.Appearance = System.Windows.Forms.Appearance.Button;
            this.lckb_G.AutoSize = true;
            this.lckb_G.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.lckb_G.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.lckb_G.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckb_G.Location = new System.Drawing.Point(3, 345);
            this.lckb_G.Name = "lckb_G";
            this.lckb_G.Size = new System.Drawing.Size(21, 22);
            this.lckb_G.TabIndex = 4;
            this.lckb_G.TabStop = false;
            this.lckb_G.Text = "G";
            this.lckb_G.UseVisualStyleBackColor = true;
            this.lckb_G.Visible = false;
            // 
            // lckb_H
            // 
            this.lckb_H.Appearance = System.Windows.Forms.Appearance.Button;
            this.lckb_H.AutoSize = true;
            this.lckb_H.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.lckb_H.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.lckb_H.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckb_H.Location = new System.Drawing.Point(3, 391);
            this.lckb_H.Name = "lckb_H";
            this.lckb_H.Size = new System.Drawing.Size(21, 22);
            this.lckb_H.TabIndex = 4;
            this.lckb_H.TabStop = false;
            this.lckb_H.Text = "H";
            this.lckb_H.UseVisualStyleBackColor = true;
            this.lckb_H.Visible = false;
            // 
            // lrtb_answerF
            // 
            this.lrtb_answerF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtb_answerF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtb_answerF.Location = new System.Drawing.Point(43, 299);
            this.lrtb_answerF.Name = "lrtb_answerF";
            this.lrtb_answerF.ReadOnly = true;
            this.lrtb_answerF.ShortcutsEnabled = false;
            this.lrtb_answerF.Size = new System.Drawing.Size(574, 40);
            this.lrtb_answerF.TabIndex = 9;
            this.lrtb_answerF.TabStop = false;
            this.lrtb_answerF.Text = "";
            this.lrtb_answerF.Visible = false;
            // 
            // lrtb_answerG
            // 
            this.lrtb_answerG.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtb_answerG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtb_answerG.Location = new System.Drawing.Point(43, 345);
            this.lrtb_answerG.Name = "lrtb_answerG";
            this.lrtb_answerG.ReadOnly = true;
            this.lrtb_answerG.ShortcutsEnabled = false;
            this.lrtb_answerG.Size = new System.Drawing.Size(574, 40);
            this.lrtb_answerG.TabIndex = 9;
            this.lrtb_answerG.TabStop = false;
            this.lrtb_answerG.Text = "";
            this.lrtb_answerG.Visible = false;
            // 
            // lrtb_answerH
            // 
            this.lrtb_answerH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtb_answerH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtb_answerH.Location = new System.Drawing.Point(43, 391);
            this.lrtb_answerH.Name = "lrtb_answerH";
            this.lrtb_answerH.ReadOnly = true;
            this.lrtb_answerH.ShortcutsEnabled = false;
            this.lrtb_answerH.Size = new System.Drawing.Size(574, 40);
            this.lrtb_answerH.TabIndex = 9;
            this.lrtb_answerH.TabStop = false;
            this.lrtb_answerH.Text = "";
            this.lrtb_answerH.Visible = false;
            // 
            // lrtb_answerA
            // 
            this.lrtb_answerA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtb_answerA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtb_answerA.Location = new System.Drawing.Point(43, 69);
            this.lrtb_answerA.Name = "lrtb_answerA";
            this.lrtb_answerA.ReadOnly = true;
            this.lrtb_answerA.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtb_answerA.ShortcutsEnabled = false;
            this.lrtb_answerA.Size = new System.Drawing.Size(574, 40);
            this.lrtb_answerA.TabIndex = 5;
            this.lrtb_answerA.TabStop = false;
            this.lrtb_answerA.Text = "";
            this.lrtb_answerA.Visible = false;
            // 
            // lTableQuestion
            // 
            this.lTableQuestion.Controls.Add(this.lbl_tableAnswer);
            this.lTableQuestion.Controls.Add(this.lrtbTableQuestion);
            this.lTableQuestion.Controls.Add(this.ltlp_table);
            this.lTableQuestion.Location = new System.Drawing.Point(4, 25);
            this.lTableQuestion.Name = "lTableQuestion";
            this.lTableQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.lTableQuestion.Size = new System.Drawing.Size(772, 485);
            this.lTableQuestion.TabIndex = 4;
            this.lTableQuestion.Text = "lTableQuestion";
            this.lTableQuestion.UseVisualStyleBackColor = true;
            // 
            // lbl_tableAnswer
            // 
            this.lbl_tableAnswer.AutoSize = true;
            this.lbl_tableAnswer.Location = new System.Drawing.Point(13, 6);
            this.lbl_tableAnswer.Name = "lbl_tableAnswer";
            this.lbl_tableAnswer.Size = new System.Drawing.Size(41, 12);
            this.lbl_tableAnswer.TabIndex = 5;
            this.lbl_tableAnswer.Text = "label6";
            // 
            // lrtbTableQuestion
            // 
            this.lrtbTableQuestion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableQuestion.Location = new System.Drawing.Point(13, 22);
            this.lrtbTableQuestion.Name = "lrtbTableQuestion";
            this.lrtbTableQuestion.ReadOnly = true;
            this.lrtbTableQuestion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableQuestion.ShortcutsEnabled = false;
            this.lrtbTableQuestion.Size = new System.Drawing.Size(753, 44);
            this.lrtbTableQuestion.TabIndex = 4;
            this.lrtbTableQuestion.TabStop = false;
            this.lrtbTableQuestion.Text = "";
            // 
            // ltlp_table
            // 
            this.ltlp_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ltlp_table.ColumnCount = 6;
            this.ltlp_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.ltlp_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.ltlp_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.ltlp_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.ltlp_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.ltlp_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
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
            this.ltlp_table.Location = new System.Drawing.Point(12, 70);
            this.ltlp_table.Name = "ltlp_table";
            this.ltlp_table.RowCount = 10;
            this.ltlp_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.ltlp_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.ltlp_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.ltlp_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.ltlp_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.ltlp_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.ltlp_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.ltlp_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.ltlp_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.ltlp_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.ltlp_table.Size = new System.Drawing.Size(754, 368);
            this.ltlp_table.TabIndex = 0;
            // 
            // lckbTable11
            // 
            this.lckbTable11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable11.Location = new System.Drawing.Point(160, 47);
            this.lckbTable11.Name = "lckbTable11";
            this.lckbTable11.Size = new System.Drawing.Size(94, 28);
            this.lckbTable11.TabIndex = 0;
            this.lckbTable11.TabStop = false;
            this.lckbTable11.UseVisualStyleBackColor = false;
            this.lckbTable11.Visible = false;
            this.lckbTable11.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable12
            // 
            this.lckbTable12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable12.Location = new System.Drawing.Point(316, 47);
            this.lckbTable12.Name = "lckbTable12";
            this.lckbTable12.Size = new System.Drawing.Size(94, 28);
            this.lckbTable12.TabIndex = 0;
            this.lckbTable12.TabStop = false;
            this.lckbTable12.UseVisualStyleBackColor = false;
            this.lckbTable12.Visible = false;
            this.lckbTable12.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable13
            // 
            this.lckbTable13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable13.Location = new System.Drawing.Point(472, 47);
            this.lckbTable13.Name = "lckbTable13";
            this.lckbTable13.Size = new System.Drawing.Size(62, 25);
            this.lckbTable13.TabIndex = 0;
            this.lckbTable13.TabStop = false;
            this.lckbTable13.UseVisualStyleBackColor = false;
            this.lckbTable13.Visible = false;
            this.lckbTable13.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable14
            // 
            this.lckbTable14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable14.Location = new System.Drawing.Point(628, 47);
            this.lckbTable14.Name = "lckbTable14";
            this.lckbTable14.Size = new System.Drawing.Size(56, 28);
            this.lckbTable14.TabIndex = 0;
            this.lckbTable14.TabStop = false;
            this.lckbTable14.UseVisualStyleBackColor = false;
            this.lckbTable14.Visible = false;
            this.lckbTable14.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable15
            // 
            this.lckbTable15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable15.Location = new System.Drawing.Point(691, 47);
            this.lckbTable15.Name = "lckbTable15";
            this.lckbTable15.Size = new System.Drawing.Size(59, 28);
            this.lckbTable15.TabIndex = 0;
            this.lckbTable15.TabStop = false;
            this.lckbTable15.UseVisualStyleBackColor = false;
            this.lckbTable15.Visible = false;
            this.lckbTable15.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable25
            // 
            this.lckbTable25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable25.Location = new System.Drawing.Point(691, 90);
            this.lckbTable25.Name = "lckbTable25";
            this.lckbTable25.Size = new System.Drawing.Size(59, 28);
            this.lckbTable25.TabIndex = 0;
            this.lckbTable25.TabStop = false;
            this.lckbTable25.UseVisualStyleBackColor = false;
            this.lckbTable25.Visible = false;
            this.lckbTable25.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable24
            // 
            this.lckbTable24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable24.Location = new System.Drawing.Point(628, 90);
            this.lckbTable24.Name = "lckbTable24";
            this.lckbTable24.Size = new System.Drawing.Size(56, 28);
            this.lckbTable24.TabIndex = 0;
            this.lckbTable24.TabStop = false;
            this.lckbTable24.UseVisualStyleBackColor = false;
            this.lckbTable24.Visible = false;
            this.lckbTable24.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable23
            // 
            this.lckbTable23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable23.Location = new System.Drawing.Point(472, 90);
            this.lckbTable23.Name = "lckbTable23";
            this.lckbTable23.Size = new System.Drawing.Size(94, 28);
            this.lckbTable23.TabIndex = 0;
            this.lckbTable23.TabStop = false;
            this.lckbTable23.UseVisualStyleBackColor = false;
            this.lckbTable23.Visible = false;
            this.lckbTable23.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable22
            // 
            this.lckbTable22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable22.Location = new System.Drawing.Point(316, 90);
            this.lckbTable22.Name = "lckbTable22";
            this.lckbTable22.Size = new System.Drawing.Size(94, 28);
            this.lckbTable22.TabIndex = 0;
            this.lckbTable22.TabStop = false;
            this.lckbTable22.UseVisualStyleBackColor = false;
            this.lckbTable22.Visible = false;
            this.lckbTable22.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable21
            // 
            this.lckbTable21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable21.Location = new System.Drawing.Point(160, 90);
            this.lckbTable21.Name = "lckbTable21";
            this.lckbTable21.Size = new System.Drawing.Size(94, 28);
            this.lckbTable21.TabIndex = 0;
            this.lckbTable21.TabStop = false;
            this.lckbTable21.UseVisualStyleBackColor = false;
            this.lckbTable21.Visible = false;
            this.lckbTable21.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable32
            // 
            this.lckbTable32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable32.Location = new System.Drawing.Point(316, 133);
            this.lckbTable32.Name = "lckbTable32";
            this.lckbTable32.Size = new System.Drawing.Size(94, 28);
            this.lckbTable32.TabIndex = 0;
            this.lckbTable32.TabStop = false;
            this.lckbTable32.UseVisualStyleBackColor = false;
            this.lckbTable32.Visible = false;
            this.lckbTable32.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable33
            // 
            this.lckbTable33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable33.Location = new System.Drawing.Point(472, 133);
            this.lckbTable33.Name = "lckbTable33";
            this.lckbTable33.Size = new System.Drawing.Size(94, 28);
            this.lckbTable33.TabIndex = 0;
            this.lckbTable33.TabStop = false;
            this.lckbTable33.UseVisualStyleBackColor = false;
            this.lckbTable33.Visible = false;
            this.lckbTable33.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable34
            // 
            this.lckbTable34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable34.Location = new System.Drawing.Point(628, 133);
            this.lckbTable34.Name = "lckbTable34";
            this.lckbTable34.Size = new System.Drawing.Size(56, 28);
            this.lckbTable34.TabIndex = 0;
            this.lckbTable34.TabStop = false;
            this.lckbTable34.UseVisualStyleBackColor = false;
            this.lckbTable34.Visible = false;
            this.lckbTable34.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable35
            // 
            this.lckbTable35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable35.Location = new System.Drawing.Point(691, 133);
            this.lckbTable35.Name = "lckbTable35";
            this.lckbTable35.Size = new System.Drawing.Size(59, 28);
            this.lckbTable35.TabIndex = 0;
            this.lckbTable35.TabStop = false;
            this.lckbTable35.UseVisualStyleBackColor = false;
            this.lckbTable35.Visible = false;
            this.lckbTable35.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable43
            // 
            this.lckbTable43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable43.Location = new System.Drawing.Point(472, 176);
            this.lckbTable43.Name = "lckbTable43";
            this.lckbTable43.Size = new System.Drawing.Size(94, 28);
            this.lckbTable43.TabIndex = 0;
            this.lckbTable43.TabStop = false;
            this.lckbTable43.UseVisualStyleBackColor = false;
            this.lckbTable43.Visible = false;
            this.lckbTable43.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable41
            // 
            this.lckbTable41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable41.Location = new System.Drawing.Point(160, 176);
            this.lckbTable41.Name = "lckbTable41";
            this.lckbTable41.Size = new System.Drawing.Size(94, 28);
            this.lckbTable41.TabIndex = 0;
            this.lckbTable41.TabStop = false;
            this.lckbTable41.UseVisualStyleBackColor = false;
            this.lckbTable41.Visible = false;
            this.lckbTable41.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable31
            // 
            this.lckbTable31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable31.Location = new System.Drawing.Point(160, 133);
            this.lckbTable31.Name = "lckbTable31";
            this.lckbTable31.Size = new System.Drawing.Size(94, 28);
            this.lckbTable31.TabIndex = 0;
            this.lckbTable31.TabStop = false;
            this.lckbTable31.UseVisualStyleBackColor = false;
            this.lckbTable31.Visible = false;
            this.lckbTable31.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable42
            // 
            this.lckbTable42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable42.Location = new System.Drawing.Point(316, 176);
            this.lckbTable42.Name = "lckbTable42";
            this.lckbTable42.Size = new System.Drawing.Size(94, 28);
            this.lckbTable42.TabIndex = 0;
            this.lckbTable42.TabStop = false;
            this.lckbTable42.UseVisualStyleBackColor = false;
            this.lckbTable42.Visible = false;
            this.lckbTable42.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable44
            // 
            this.lckbTable44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable44.Location = new System.Drawing.Point(628, 176);
            this.lckbTable44.Name = "lckbTable44";
            this.lckbTable44.Size = new System.Drawing.Size(56, 28);
            this.lckbTable44.TabIndex = 0;
            this.lckbTable44.TabStop = false;
            this.lckbTable44.UseVisualStyleBackColor = false;
            this.lckbTable44.Visible = false;
            this.lckbTable44.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable45
            // 
            this.lckbTable45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable45.Location = new System.Drawing.Point(691, 176);
            this.lckbTable45.Name = "lckbTable45";
            this.lckbTable45.Size = new System.Drawing.Size(59, 28);
            this.lckbTable45.TabIndex = 0;
            this.lckbTable45.TabStop = false;
            this.lckbTable45.UseVisualStyleBackColor = false;
            this.lckbTable45.Visible = false;
            this.lckbTable45.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable55
            // 
            this.lckbTable55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable55.Location = new System.Drawing.Point(691, 219);
            this.lckbTable55.Name = "lckbTable55";
            this.lckbTable55.Size = new System.Drawing.Size(59, 28);
            this.lckbTable55.TabIndex = 0;
            this.lckbTable55.TabStop = false;
            this.lckbTable55.UseVisualStyleBackColor = false;
            this.lckbTable55.Visible = false;
            this.lckbTable55.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable54
            // 
            this.lckbTable54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable54.Location = new System.Drawing.Point(628, 219);
            this.lckbTable54.Name = "lckbTable54";
            this.lckbTable54.Size = new System.Drawing.Size(56, 28);
            this.lckbTable54.TabIndex = 0;
            this.lckbTable54.TabStop = false;
            this.lckbTable54.UseVisualStyleBackColor = false;
            this.lckbTable54.Visible = false;
            this.lckbTable54.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable53
            // 
            this.lckbTable53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable53.Location = new System.Drawing.Point(472, 219);
            this.lckbTable53.Name = "lckbTable53";
            this.lckbTable53.Size = new System.Drawing.Size(94, 28);
            this.lckbTable53.TabIndex = 0;
            this.lckbTable53.TabStop = false;
            this.lckbTable53.UseVisualStyleBackColor = false;
            this.lckbTable53.Visible = false;
            this.lckbTable53.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable52
            // 
            this.lckbTable52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable52.Location = new System.Drawing.Point(316, 219);
            this.lckbTable52.Name = "lckbTable52";
            this.lckbTable52.Size = new System.Drawing.Size(94, 28);
            this.lckbTable52.TabIndex = 0;
            this.lckbTable52.TabStop = false;
            this.lckbTable52.UseVisualStyleBackColor = false;
            this.lckbTable52.Visible = false;
            this.lckbTable52.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable51
            // 
            this.lckbTable51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable51.Location = new System.Drawing.Point(160, 219);
            this.lckbTable51.Name = "lckbTable51";
            this.lckbTable51.Size = new System.Drawing.Size(94, 28);
            this.lckbTable51.TabIndex = 0;
            this.lckbTable51.TabStop = false;
            this.lckbTable51.UseVisualStyleBackColor = false;
            this.lckbTable51.Visible = false;
            this.lckbTable51.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable61
            // 
            this.lckbTable61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable61.Location = new System.Drawing.Point(160, 262);
            this.lckbTable61.Name = "lckbTable61";
            this.lckbTable61.Size = new System.Drawing.Size(94, 19);
            this.lckbTable61.TabIndex = 0;
            this.lckbTable61.TabStop = false;
            this.lckbTable61.UseVisualStyleBackColor = false;
            this.lckbTable61.Visible = false;
            this.lckbTable61.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable62
            // 
            this.lckbTable62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable62.Location = new System.Drawing.Point(316, 262);
            this.lckbTable62.Name = "lckbTable62";
            this.lckbTable62.Size = new System.Drawing.Size(94, 19);
            this.lckbTable62.TabIndex = 0;
            this.lckbTable62.TabStop = false;
            this.lckbTable62.UseVisualStyleBackColor = false;
            this.lckbTable62.Visible = false;
            this.lckbTable62.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable63
            // 
            this.lckbTable63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable63.Location = new System.Drawing.Point(472, 262);
            this.lckbTable63.Name = "lckbTable63";
            this.lckbTable63.Size = new System.Drawing.Size(94, 19);
            this.lckbTable63.TabIndex = 0;
            this.lckbTable63.TabStop = false;
            this.lckbTable63.UseVisualStyleBackColor = false;
            this.lckbTable63.Visible = false;
            this.lckbTable63.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable64
            // 
            this.lckbTable64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable64.Location = new System.Drawing.Point(628, 262);
            this.lckbTable64.Name = "lckbTable64";
            this.lckbTable64.Size = new System.Drawing.Size(56, 19);
            this.lckbTable64.TabIndex = 0;
            this.lckbTable64.TabStop = false;
            this.lckbTable64.UseVisualStyleBackColor = false;
            this.lckbTable64.Visible = false;
            this.lckbTable64.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable65
            // 
            this.lckbTable65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable65.Location = new System.Drawing.Point(691, 262);
            this.lckbTable65.Name = "lckbTable65";
            this.lckbTable65.Size = new System.Drawing.Size(59, 19);
            this.lckbTable65.TabIndex = 0;
            this.lckbTable65.TabStop = false;
            this.lckbTable65.UseVisualStyleBackColor = false;
            this.lckbTable65.Visible = false;
            this.lckbTable65.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable71
            // 
            this.lckbTable71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable71.Location = new System.Drawing.Point(160, 288);
            this.lckbTable71.Name = "lckbTable71";
            this.lckbTable71.Size = new System.Drawing.Size(62, 19);
            this.lckbTable71.TabIndex = 0;
            this.lckbTable71.TabStop = false;
            this.lckbTable71.UseVisualStyleBackColor = false;
            this.lckbTable71.Visible = false;
            this.lckbTable71.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable72
            // 
            this.lckbTable72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable72.Location = new System.Drawing.Point(316, 288);
            this.lckbTable72.Name = "lckbTable72";
            this.lckbTable72.Size = new System.Drawing.Size(62, 19);
            this.lckbTable72.TabIndex = 0;
            this.lckbTable72.TabStop = false;
            this.lckbTable72.UseVisualStyleBackColor = false;
            this.lckbTable72.Visible = false;
            this.lckbTable72.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable73
            // 
            this.lckbTable73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable73.Location = new System.Drawing.Point(472, 288);
            this.lckbTable73.Name = "lckbTable73";
            this.lckbTable73.Size = new System.Drawing.Size(62, 19);
            this.lckbTable73.TabIndex = 0;
            this.lckbTable73.TabStop = false;
            this.lckbTable73.UseVisualStyleBackColor = false;
            this.lckbTable73.Visible = false;
            this.lckbTable73.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable74
            // 
            this.lckbTable74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable74.Location = new System.Drawing.Point(628, 288);
            this.lckbTable74.Name = "lckbTable74";
            this.lckbTable74.Size = new System.Drawing.Size(56, 19);
            this.lckbTable74.TabIndex = 0;
            this.lckbTable74.TabStop = false;
            this.lckbTable74.UseVisualStyleBackColor = false;
            this.lckbTable74.Visible = false;
            this.lckbTable74.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable75
            // 
            this.lckbTable75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable75.Location = new System.Drawing.Point(691, 288);
            this.lckbTable75.Name = "lckbTable75";
            this.lckbTable75.Size = new System.Drawing.Size(59, 19);
            this.lckbTable75.TabIndex = 0;
            this.lckbTable75.TabStop = false;
            this.lckbTable75.UseVisualStyleBackColor = false;
            this.lckbTable75.Visible = false;
            this.lckbTable75.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable85
            // 
            this.lckbTable85.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable85.Location = new System.Drawing.Point(691, 314);
            this.lckbTable85.Name = "lckbTable85";
            this.lckbTable85.Size = new System.Drawing.Size(59, 19);
            this.lckbTable85.TabIndex = 0;
            this.lckbTable85.TabStop = false;
            this.lckbTable85.UseVisualStyleBackColor = false;
            this.lckbTable85.Visible = false;
            this.lckbTable85.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable84
            // 
            this.lckbTable84.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable84.Location = new System.Drawing.Point(628, 314);
            this.lckbTable84.Name = "lckbTable84";
            this.lckbTable84.Size = new System.Drawing.Size(56, 19);
            this.lckbTable84.TabIndex = 0;
            this.lckbTable84.TabStop = false;
            this.lckbTable84.UseVisualStyleBackColor = false;
            this.lckbTable84.Visible = false;
            this.lckbTable84.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable83
            // 
            this.lckbTable83.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable83.Location = new System.Drawing.Point(472, 314);
            this.lckbTable83.Name = "lckbTable83";
            this.lckbTable83.Size = new System.Drawing.Size(62, 19);
            this.lckbTable83.TabIndex = 0;
            this.lckbTable83.TabStop = false;
            this.lckbTable83.UseVisualStyleBackColor = false;
            this.lckbTable83.Visible = false;
            this.lckbTable83.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable82
            // 
            this.lckbTable82.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable82.Location = new System.Drawing.Point(316, 314);
            this.lckbTable82.Name = "lckbTable82";
            this.lckbTable82.Size = new System.Drawing.Size(62, 19);
            this.lckbTable82.TabIndex = 0;
            this.lckbTable82.TabStop = false;
            this.lckbTable82.UseVisualStyleBackColor = false;
            this.lckbTable82.Visible = false;
            this.lckbTable82.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable81
            // 
            this.lckbTable81.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable81.Location = new System.Drawing.Point(160, 314);
            this.lckbTable81.Name = "lckbTable81";
            this.lckbTable81.Size = new System.Drawing.Size(62, 19);
            this.lckbTable81.TabIndex = 0;
            this.lckbTable81.TabStop = false;
            this.lckbTable81.UseVisualStyleBackColor = false;
            this.lckbTable81.Visible = false;
            this.lckbTable81.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable91
            // 
            this.lckbTable91.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable91.Location = new System.Drawing.Point(160, 340);
            this.lckbTable91.Name = "lckbTable91";
            this.lckbTable91.Size = new System.Drawing.Size(62, 23);
            this.lckbTable91.TabIndex = 0;
            this.lckbTable91.TabStop = false;
            this.lckbTable91.UseVisualStyleBackColor = false;
            this.lckbTable91.Visible = false;
            this.lckbTable91.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable92
            // 
            this.lckbTable92.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable92.Location = new System.Drawing.Point(316, 340);
            this.lckbTable92.Name = "lckbTable92";
            this.lckbTable92.Size = new System.Drawing.Size(62, 23);
            this.lckbTable92.TabIndex = 0;
            this.lckbTable92.TabStop = false;
            this.lckbTable92.UseVisualStyleBackColor = false;
            this.lckbTable92.Visible = false;
            this.lckbTable92.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable93
            // 
            this.lckbTable93.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable93.Location = new System.Drawing.Point(472, 340);
            this.lckbTable93.Name = "lckbTable93";
            this.lckbTable93.Size = new System.Drawing.Size(62, 23);
            this.lckbTable93.TabIndex = 0;
            this.lckbTable93.TabStop = false;
            this.lckbTable93.UseVisualStyleBackColor = false;
            this.lckbTable93.Visible = false;
            this.lckbTable93.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable94
            // 
            this.lckbTable94.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable94.Location = new System.Drawing.Point(628, 340);
            this.lckbTable94.Name = "lckbTable94";
            this.lckbTable94.Size = new System.Drawing.Size(56, 23);
            this.lckbTable94.TabIndex = 0;
            this.lckbTable94.TabStop = false;
            this.lckbTable94.UseVisualStyleBackColor = false;
            this.lckbTable94.Visible = false;
            this.lckbTable94.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lckbTable95
            // 
            this.lckbTable95.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lckbTable95.Location = new System.Drawing.Point(691, 340);
            this.lckbTable95.Name = "lckbTable95";
            this.lckbTable95.Size = new System.Drawing.Size(59, 23);
            this.lckbTable95.TabIndex = 0;
            this.lckbTable95.TabStop = false;
            this.lckbTable95.UseVisualStyleBackColor = false;
            this.lckbTable95.Visible = false;
            this.lckbTable95.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // lrtbTableCol1
            // 
            this.lrtbTableCol1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableCol1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableCol1.Location = new System.Drawing.Point(160, 4);
            this.lrtbTableCol1.Name = "lrtbTableCol1";
            this.lrtbTableCol1.ReadOnly = true;
            this.lrtbTableCol1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableCol1.ShortcutsEnabled = false;
            this.lrtbTableCol1.Size = new System.Drawing.Size(149, 36);
            this.lrtbTableCol1.TabIndex = 1;
            this.lrtbTableCol1.TabStop = false;
            this.lrtbTableCol1.Text = "";
            this.lrtbTableCol1.Visible = false;
            // 
            // lrtbTableCol2
            // 
            this.lrtbTableCol2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableCol2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableCol2.Location = new System.Drawing.Point(316, 4);
            this.lrtbTableCol2.Name = "lrtbTableCol2";
            this.lrtbTableCol2.ReadOnly = true;
            this.lrtbTableCol2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableCol2.ShortcutsEnabled = false;
            this.lrtbTableCol2.Size = new System.Drawing.Size(149, 36);
            this.lrtbTableCol2.TabIndex = 1;
            this.lrtbTableCol2.TabStop = false;
            this.lrtbTableCol2.Text = "";
            this.lrtbTableCol2.Visible = false;
            // 
            // lrtbTableCol3
            // 
            this.lrtbTableCol3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableCol3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableCol3.Location = new System.Drawing.Point(472, 4);
            this.lrtbTableCol3.Name = "lrtbTableCol3";
            this.lrtbTableCol3.ReadOnly = true;
            this.lrtbTableCol3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableCol3.ShortcutsEnabled = false;
            this.lrtbTableCol3.Size = new System.Drawing.Size(149, 36);
            this.lrtbTableCol3.TabIndex = 1;
            this.lrtbTableCol3.TabStop = false;
            this.lrtbTableCol3.Text = "";
            this.lrtbTableCol3.Visible = false;
            // 
            // lrtbTableCol5
            // 
            this.lrtbTableCol5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableCol5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableCol5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrtbTableCol5.Location = new System.Drawing.Point(691, 4);
            this.lrtbTableCol5.Name = "lrtbTableCol5";
            this.lrtbTableCol5.ReadOnly = true;
            this.lrtbTableCol5.ShortcutsEnabled = false;
            this.lrtbTableCol5.Size = new System.Drawing.Size(36, 28);
            this.lrtbTableCol5.TabIndex = 1;
            this.lrtbTableCol5.TabStop = false;
            this.lrtbTableCol5.Text = "";
            this.lrtbTableCol5.Visible = false;
            // 
            // lrtbTableRow1
            // 
            this.lrtbTableRow1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableRow1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableRow1.Location = new System.Drawing.Point(4, 47);
            this.lrtbTableRow1.Name = "lrtbTableRow1";
            this.lrtbTableRow1.ReadOnly = true;
            this.lrtbTableRow1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableRow1.ShortcutsEnabled = false;
            this.lrtbTableRow1.Size = new System.Drawing.Size(149, 36);
            this.lrtbTableRow1.TabIndex = 1;
            this.lrtbTableRow1.TabStop = false;
            this.lrtbTableRow1.Text = "";
            this.lrtbTableRow1.Visible = false;
            // 
            // lrtbTableRow2
            // 
            this.lrtbTableRow2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableRow2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableRow2.Location = new System.Drawing.Point(4, 90);
            this.lrtbTableRow2.Name = "lrtbTableRow2";
            this.lrtbTableRow2.ReadOnly = true;
            this.lrtbTableRow2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableRow2.ShortcutsEnabled = false;
            this.lrtbTableRow2.Size = new System.Drawing.Size(149, 36);
            this.lrtbTableRow2.TabIndex = 1;
            this.lrtbTableRow2.TabStop = false;
            this.lrtbTableRow2.Text = "";
            this.lrtbTableRow2.Visible = false;
            // 
            // lrtbTableRow3
            // 
            this.lrtbTableRow3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableRow3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableRow3.Location = new System.Drawing.Point(4, 133);
            this.lrtbTableRow3.Name = "lrtbTableRow3";
            this.lrtbTableRow3.ReadOnly = true;
            this.lrtbTableRow3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableRow3.ShortcutsEnabled = false;
            this.lrtbTableRow3.Size = new System.Drawing.Size(149, 36);
            this.lrtbTableRow3.TabIndex = 1;
            this.lrtbTableRow3.TabStop = false;
            this.lrtbTableRow3.Text = "";
            this.lrtbTableRow3.Visible = false;
            // 
            // lrtbTableRow4
            // 
            this.lrtbTableRow4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableRow4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableRow4.Location = new System.Drawing.Point(4, 176);
            this.lrtbTableRow4.Name = "lrtbTableRow4";
            this.lrtbTableRow4.ReadOnly = true;
            this.lrtbTableRow4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableRow4.ShortcutsEnabled = false;
            this.lrtbTableRow4.Size = new System.Drawing.Size(149, 36);
            this.lrtbTableRow4.TabIndex = 1;
            this.lrtbTableRow4.TabStop = false;
            this.lrtbTableRow4.Text = "";
            this.lrtbTableRow4.Visible = false;
            // 
            // lrtbTableRow5
            // 
            this.lrtbTableRow5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableRow5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableRow5.Location = new System.Drawing.Point(4, 219);
            this.lrtbTableRow5.Name = "lrtbTableRow5";
            this.lrtbTableRow5.ReadOnly = true;
            this.lrtbTableRow5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableRow5.ShortcutsEnabled = false;
            this.lrtbTableRow5.Size = new System.Drawing.Size(149, 36);
            this.lrtbTableRow5.TabIndex = 1;
            this.lrtbTableRow5.TabStop = false;
            this.lrtbTableRow5.Text = "";
            this.lrtbTableRow5.Visible = false;
            // 
            // lrtbTableRow6
            // 
            this.lrtbTableRow6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableRow6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableRow6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrtbTableRow6.Location = new System.Drawing.Point(4, 262);
            this.lrtbTableRow6.Name = "lrtbTableRow6";
            this.lrtbTableRow6.ReadOnly = true;
            this.lrtbTableRow6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableRow6.ShortcutsEnabled = false;
            this.lrtbTableRow6.Size = new System.Drawing.Size(149, 19);
            this.lrtbTableRow6.TabIndex = 1;
            this.lrtbTableRow6.TabStop = false;
            this.lrtbTableRow6.Text = "";
            this.lrtbTableRow6.Visible = false;
            // 
            // lrtbTableRow7
            // 
            this.lrtbTableRow7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableRow7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableRow7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrtbTableRow7.Location = new System.Drawing.Point(4, 288);
            this.lrtbTableRow7.Name = "lrtbTableRow7";
            this.lrtbTableRow7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableRow7.ShortcutsEnabled = false;
            this.lrtbTableRow7.Size = new System.Drawing.Size(149, 19);
            this.lrtbTableRow7.TabIndex = 1;
            this.lrtbTableRow7.TabStop = false;
            this.lrtbTableRow7.Text = "";
            this.lrtbTableRow7.Visible = false;
            this.lrtbTableRow7.TextChanged += new System.EventHandler(this.RtbAnswers_TextChanged);
            // 
            // lrtbTableRow8
            // 
            this.lrtbTableRow8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableRow8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableRow8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrtbTableRow8.Location = new System.Drawing.Point(4, 314);
            this.lrtbTableRow8.Name = "lrtbTableRow8";
            this.lrtbTableRow8.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableRow8.ShortcutsEnabled = false;
            this.lrtbTableRow8.Size = new System.Drawing.Size(149, 19);
            this.lrtbTableRow8.TabIndex = 1;
            this.lrtbTableRow8.TabStop = false;
            this.lrtbTableRow8.Text = "";
            this.lrtbTableRow8.Visible = false;
            this.lrtbTableRow8.TextChanged += new System.EventHandler(this.RtbAnswers_TextChanged);
            // 
            // lrtbTableRow9
            // 
            this.lrtbTableRow9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableRow9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableRow9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrtbTableRow9.Location = new System.Drawing.Point(4, 340);
            this.lrtbTableRow9.Name = "lrtbTableRow9";
            this.lrtbTableRow9.ShortcutsEnabled = false;
            this.lrtbTableRow9.Size = new System.Drawing.Size(149, 23);
            this.lrtbTableRow9.TabIndex = 1;
            this.lrtbTableRow9.TabStop = false;
            this.lrtbTableRow9.Text = "";
            this.lrtbTableRow9.Visible = false;
            this.lrtbTableRow9.TextChanged += new System.EventHandler(this.RtbAnswers_TextChanged);
            // 
            // lrtbTableCol4
            // 
            this.lrtbTableCol4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lrtbTableCol4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrtbTableCol4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrtbTableCol4.Location = new System.Drawing.Point(628, 4);
            this.lrtbTableCol4.Name = "lrtbTableCol4";
            this.lrtbTableCol4.ReadOnly = true;
            this.lrtbTableCol4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lrtbTableCol4.ShortcutsEnabled = false;
            this.lrtbTableCol4.Size = new System.Drawing.Size(56, 36);
            this.lrtbTableCol4.TabIndex = 1;
            this.lrtbTableCol4.TabStop = false;
            this.lrtbTableCol4.Text = "";
            this.lrtbTableCol4.Visible = false;
            // 
            // tab_Speaking
            // 
            this.tab_Speaking.Controls.Add(this.tabf_speaking);
            this.tab_Speaking.Location = new System.Drawing.Point(4, 22);
            this.tab_Speaking.Name = "tab_Speaking";
            this.tab_Speaking.Size = new System.Drawing.Size(780, 484);
            this.tab_Speaking.TabIndex = 2;
            this.tab_Speaking.Text = "Speaking";
            this.tab_Speaking.UseVisualStyleBackColor = true;
            // 
            // tabf_speaking
            // 
            this.tabf_speaking.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabf_speaking.Controls.Add(this.sDirection);
            this.tabf_speaking.Controls.Add(this.sNormalQuestions);
            this.tabf_speaking.Location = new System.Drawing.Point(5, -23);
            this.tabf_speaking.Name = "tabf_speaking";
            this.tabf_speaking.SelectedIndex = 0;
            this.tabf_speaking.Size = new System.Drawing.Size(771, 477);
            this.tabf_speaking.TabIndex = 1;
            this.tabf_speaking.TabStop = false;
            // 
            // sDirection
            // 
            this.sDirection.Controls.Add(this.pictureBox3);
            this.sDirection.Location = new System.Drawing.Point(4, 25);
            this.sDirection.Name = "sDirection";
            this.sDirection.Size = new System.Drawing.Size(763, 448);
            this.sDirection.TabIndex = 3;
            this.sDirection.Text = "sDirection";
            this.sDirection.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Properties.Resources.SpeakingDirection4;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(3, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(904, 523);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // sNormalQuestions
            // 
            this.sNormalQuestions.Controls.Add(this.spb);
            this.sNormalQuestions.Controls.Add(this.tableLayoutPanel3);
            this.sNormalQuestions.Controls.Add(this.srtb_introduction);
            this.sNormalQuestions.Controls.Add(this.pb_speakingScene);
            this.sNormalQuestions.Location = new System.Drawing.Point(4, 25);
            this.sNormalQuestions.Name = "sNormalQuestions";
            this.sNormalQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.sNormalQuestions.Size = new System.Drawing.Size(763, 448);
            this.sNormalQuestions.TabIndex = 0;
            this.sNormalQuestions.Text = "sNormalQuestions";
            this.sNormalQuestions.UseVisualStyleBackColor = true;
            // 
            // spb
            // 
            this.spb.Location = new System.Drawing.Point(190, 371);
            this.spb.Name = "spb";
            this.spb.Size = new System.Drawing.Size(350, 21);
            this.spb.TabIndex = 41;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.srtb_timer, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.srtb_timeindicator, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(267, 228);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 72);
            this.tableLayoutPanel3.TabIndex = 4;
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
            // pb_speakingScene
            // 
            this.pb_speakingScene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_speakingScene.Image = ((System.Drawing.Image)(resources.GetObject("pb_speakingScene.Image")));
            this.pb_speakingScene.Location = new System.Drawing.Point(190, 18);
            this.pb_speakingScene.Name = "pb_speakingScene";
            this.pb_speakingScene.Size = new System.Drawing.Size(350, 323);
            this.pb_speakingScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_speakingScene.TabIndex = 0;
            this.pb_speakingScene.TabStop = false;
            // 
            // tab_Writing
            // 
            this.tab_Writing.Controls.Add(this.tabf_writing);
            this.tab_Writing.Location = new System.Drawing.Point(4, 22);
            this.tab_Writing.Name = "tab_Writing";
            this.tab_Writing.Size = new System.Drawing.Size(780, 484);
            this.tab_Writing.TabIndex = 3;
            this.tab_Writing.Text = "Writing";
            this.tab_Writing.UseVisualStyleBackColor = true;
            // 
            // tabf_writing
            // 
            this.tabf_writing.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabf_writing.Controls.Add(this.wDirection);
            this.tabf_writing.Controls.Add(this.wReading);
            this.tabf_writing.Controls.Add(this.wSpeakingPassage);
            this.tabf_writing.Controls.Add(this.wWriting2);
            this.tabf_writing.Location = new System.Drawing.Point(5, -25);
            this.tabf_writing.Name = "tabf_writing";
            this.tabf_writing.SelectedIndex = 0;
            this.tabf_writing.Size = new System.Drawing.Size(771, 477);
            this.tabf_writing.TabIndex = 2;
            this.tabf_writing.TabStop = false;
            this.tabf_writing.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            // 
            // wDirection
            // 
            this.wDirection.Controls.Add(this.pictureBox4);
            this.wDirection.Location = new System.Drawing.Point(4, 25);
            this.wDirection.Name = "wDirection";
            this.wDirection.Size = new System.Drawing.Size(763, 448);
            this.wDirection.TabIndex = 3;
            this.wDirection.Text = "wDirection";
            this.wDirection.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = global::Properties.Resources.WritingDirection1;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1081, 490);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // wReading
            // 
            this.wReading.Controls.Add(this.wrtb_writing1);
            this.wReading.Controls.Add(this.wrtb_reading);
            this.wReading.Location = new System.Drawing.Point(4, 25);
            this.wReading.Name = "wReading";
            this.wReading.Size = new System.Drawing.Size(763, 448);
            this.wReading.TabIndex = 5;
            this.wReading.Text = "wReading";
            this.wReading.UseVisualStyleBackColor = true;
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
            // wSpeakingPassage
            // 
            this.wSpeakingPassage.Controls.Add(this.wpb_speak);
            this.wSpeakingPassage.Controls.Add(this.wtb_speak);
            this.wSpeakingPassage.Controls.Add(this.pb_writingScene);
            this.wSpeakingPassage.Location = new System.Drawing.Point(4, 25);
            this.wSpeakingPassage.Name = "wSpeakingPassage";
            this.wSpeakingPassage.Padding = new System.Windows.Forms.Padding(3);
            this.wSpeakingPassage.Size = new System.Drawing.Size(763, 448);
            this.wSpeakingPassage.TabIndex = 0;
            this.wSpeakingPassage.Text = "wSpeakingPassage";
            this.wSpeakingPassage.UseVisualStyleBackColor = true;
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
            // pb_writingScene
            // 
            this.pb_writingScene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_writingScene.Image = ((System.Drawing.Image)(resources.GetObject("pb_writingScene.Image")));
            this.pb_writingScene.Location = new System.Drawing.Point(206, 46);
            this.pb_writingScene.Name = "pb_writingScene";
            this.pb_writingScene.Size = new System.Drawing.Size(350, 323);
            this.pb_writingScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_writingScene.TabIndex = 1;
            this.pb_writingScene.TabStop = false;
            // 
            // wWriting2
            // 
            this.wWriting2.Controls.Add(this.lbl_writeDirection);
            this.wWriting2.Controls.Add(this.wrtb_writing2);
            this.wWriting2.Controls.Add(this.wrtbQuestion2);
            this.wWriting2.Controls.Add(this.wpanel);
            this.wWriting2.Location = new System.Drawing.Point(4, 25);
            this.wWriting2.Name = "wWriting2";
            this.wWriting2.Size = new System.Drawing.Size(763, 448);
            this.wWriting2.TabIndex = 4;
            this.wWriting2.Text = "wWriting2";
            this.wWriting2.UseVisualStyleBackColor = true;
            // 
            // lbl_writeDirection
            // 
            this.lbl_writeDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_writeDirection.Location = new System.Drawing.Point(3, 21);
            this.lbl_writeDirection.Name = "lbl_writeDirection";
            this.lbl_writeDirection.Size = new System.Drawing.Size(760, 45);
            this.lbl_writeDirection.TabIndex = 8;
            this.lbl_writeDirection.Text = resources.GetString("lbl_writeDirection.Text");
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
            // wrtbQuestion2
            // 
            this.wrtbQuestion2.BackColor = System.Drawing.SystemColors.Control;
            this.wrtbQuestion2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrtbQuestion2.Location = new System.Drawing.Point(3, 69);
            this.wrtbQuestion2.Name = "wrtbQuestion2";
            this.wrtbQuestion2.ReadOnly = true;
            this.wrtbQuestion2.ShortcutsEnabled = false;
            this.wrtbQuestion2.Size = new System.Drawing.Size(347, 381);
            this.wrtbQuestion2.TabIndex = 5;
            this.wrtbQuestion2.TabStop = false;
            this.wrtbQuestion2.Text = "Introduction";
            // 
            // wpanel
            // 
            this.wpanel.BackColor = System.Drawing.Color.LightGray;
            this.wpanel.Controls.Add(this.wlbl_wordcount);
            this.wpanel.Controls.Add(this.wbtn_wordcount);
            this.wpanel.Controls.Add(this.wbtn_redo);
            this.wpanel.Controls.Add(this.wbtn_undo);
            this.wpanel.Controls.Add(this.wbtn_paste);
            this.wpanel.Controls.Add(this.wbtn_cut);
            this.wpanel.Location = new System.Drawing.Point(350, 69);
            this.wpanel.Name = "wpanel";
            this.wpanel.Size = new System.Drawing.Size(425, 38);
            this.wpanel.TabIndex = 7;
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
            // 
            // tab_Answers
            // 
            this.tab_Answers.Controls.Add(this.tabf_answer);
            this.tab_Answers.Location = new System.Drawing.Point(4, 22);
            this.tab_Answers.Name = "tab_Answers";
            this.tab_Answers.Size = new System.Drawing.Size(780, 484);
            this.tab_Answers.TabIndex = 5;
            this.tab_Answers.Text = "Answers";
            this.tab_Answers.UseVisualStyleBackColor = true;
            // 
            // tabf_answer
            // 
            this.tabf_answer.Controls.Add(this.tab_readinganswer);
            this.tabf_answer.Controls.Add(this.tab_listeninganswers);
            this.tabf_answer.Controls.Add(this.tab_speakinganswers);
            this.tabf_answer.Controls.Add(this.tab_writinganswers);
            this.tabf_answer.Location = new System.Drawing.Point(3, 3);
            this.tabf_answer.Name = "tabf_answer";
            this.tabf_answer.SelectedIndex = 0;
            this.tabf_answer.Size = new System.Drawing.Size(781, 510);
            this.tabf_answer.TabIndex = 0;
            this.tabf_answer.SelectedIndexChanged += new System.EventHandler(this.tabf_answer_SelectedIndexChanged);
            // 
            // tab_readinganswer
            // 
            this.tab_readinganswer.Controls.Add(this.dgv_readingSelect);
            this.tab_readinganswer.Controls.Add(this.label2);
            this.tab_readinganswer.Controls.Add(this.lbl_readingscorereport);
            this.tab_readinganswer.Controls.Add(this.label3);
            this.tab_readinganswer.Controls.Add(this.pictureBox6);
            this.tab_readinganswer.Controls.Add(this.label4);
            this.tab_readinganswer.Controls.Add(this.pictureBox7);
            this.tab_readinganswer.Controls.Add(this.label5);
            this.tab_readinganswer.Controls.Add(this.pictureBox8);
            this.tab_readinganswer.Controls.Add(this.dgv_readinganswers);
            this.tab_readinganswer.Location = new System.Drawing.Point(4, 22);
            this.tab_readinganswer.Name = "tab_readinganswer";
            this.tab_readinganswer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_readinganswer.Size = new System.Drawing.Size(773, 484);
            this.tab_readinganswer.TabIndex = 0;
            this.tab_readinganswer.Text = "Reading";
            this.tab_readinganswer.UseVisualStyleBackColor = true;
            // 
            // dgv_readingSelect
            // 
            this.dgv_readingSelect.AllowUserToAddRows = false;
            this.dgv_readingSelect.AllowUserToDeleteRows = false;
            this.dgv_readingSelect.AllowUserToResizeColumns = false;
            this.dgv_readingSelect.AllowUserToResizeRows = false;
            this.dgv_readingSelect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_readingSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_readingSelect.Location = new System.Drawing.Point(513, 64);
            this.dgv_readingSelect.MultiSelect = false;
            this.dgv_readingSelect.Name = "dgv_readingSelect";
            this.dgv_readingSelect.ReadOnly = true;
            this.dgv_readingSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_readingSelect.RowTemplate.Height = 23;
            this.dgv_readingSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_readingSelect.Size = new System.Drawing.Size(219, 341);
            this.dgv_readingSelect.TabIndex = 15;
            this.dgv_readingSelect.TabStop = false;
            this.dgv_readingSelect.SelectionChanged += new System.EventHandler(this.dgv_readingSelect_SelectionChanged);
            this.dgv_readingSelect.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_readingSelect_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(905, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Note: Because the real IBT scoring policy will take all the students\' performance" +
    " into account, the standard score gained here can\'t be very accurate!";
            // 
            // lbl_readingscorereport
            // 
            this.lbl_readingscorereport.AutoSize = true;
            this.lbl_readingscorereport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_readingscorereport.Location = new System.Drawing.Point(61, 13);
            this.lbl_readingscorereport.Name = "lbl_readingscorereport";
            this.lbl_readingscorereport.Size = new System.Drawing.Size(97, 17);
            this.lbl_readingscorereport.TabIndex = 13;
            this.lbl_readingscorereport.Text = "scoreReport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wrong Answered";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox6.Location = new System.Drawing.Point(299, 38);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 20);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Right Answered";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Green;
            this.pictureBox7.Location = new System.Drawing.Point(182, 38);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(27, 20);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Not Answered";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Red;
            this.pictureBox8.Location = new System.Drawing.Point(64, 38);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 20);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // dgv_readinganswers
            // 
            this.dgv_readinganswers.AllowUserToAddRows = false;
            this.dgv_readinganswers.AllowUserToDeleteRows = false;
            this.dgv_readinganswers.AllowUserToResizeColumns = false;
            this.dgv_readinganswers.AllowUserToResizeRows = false;
            this.dgv_readinganswers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_readinganswers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_readinganswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_readinganswers.Location = new System.Drawing.Point(64, 64);
            this.dgv_readinganswers.MultiSelect = false;
            this.dgv_readinganswers.Name = "dgv_readinganswers";
            this.dgv_readinganswers.ReadOnly = true;
            this.dgv_readinganswers.RowHeadersVisible = false;
            this.dgv_readinganswers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_readinganswers.RowTemplate.Height = 23;
            this.dgv_readinganswers.RowTemplate.ReadOnly = true;
            this.dgv_readinganswers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_readinganswers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_readinganswers.Size = new System.Drawing.Size(393, 341);
            this.dgv_readinganswers.TabIndex = 6;
            this.dgv_readinganswers.TabStop = false;
            this.dgv_readinganswers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_readinganswers_DataBindingComplete);
            this.dgv_readinganswers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_readinganswers_MouseDoubleClick);
            // 
            // tab_listeninganswers
            // 
            this.tab_listeninganswers.Controls.Add(this.dgv_listeningSelect);
            this.tab_listeninganswers.Controls.Add(this.label16);
            this.tab_listeninganswers.Controls.Add(this.dgv_listeninganswers);
            this.tab_listeninganswers.Controls.Add(this.lbl_listeningScorereport);
            this.tab_listeninganswers.Controls.Add(this.label7);
            this.tab_listeninganswers.Controls.Add(this.pictureBox9);
            this.tab_listeninganswers.Controls.Add(this.label8);
            this.tab_listeninganswers.Controls.Add(this.pictureBox10);
            this.tab_listeninganswers.Controls.Add(this.label9);
            this.tab_listeninganswers.Controls.Add(this.pictureBox11);
            this.tab_listeninganswers.Location = new System.Drawing.Point(4, 22);
            this.tab_listeninganswers.Name = "tab_listeninganswers";
            this.tab_listeninganswers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_listeninganswers.Size = new System.Drawing.Size(773, 484);
            this.tab_listeninganswers.TabIndex = 1;
            this.tab_listeninganswers.Text = "Listening";
            this.tab_listeninganswers.UseVisualStyleBackColor = true;
            // 
            // dgv_listeningSelect
            // 
            this.dgv_listeningSelect.AllowUserToAddRows = false;
            this.dgv_listeningSelect.AllowUserToDeleteRows = false;
            this.dgv_listeningSelect.AllowUserToResizeColumns = false;
            this.dgv_listeningSelect.AllowUserToResizeRows = false;
            this.dgv_listeningSelect.AutoGenerateColumns = false;
            this.dgv_listeningSelect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_listeningSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_listeningSelect.DataSource = this.bindingSource_Set;
            this.dgv_listeningSelect.Location = new System.Drawing.Point(513, 64);
            this.dgv_listeningSelect.MultiSelect = false;
            this.dgv_listeningSelect.Name = "dgv_listeningSelect";
            this.dgv_listeningSelect.ReadOnly = true;
            this.dgv_listeningSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_listeningSelect.RowTemplate.Height = 23;
            this.dgv_listeningSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listeningSelect.Size = new System.Drawing.Size(219, 341);
            this.dgv_listeningSelect.TabIndex = 24;
            this.dgv_listeningSelect.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 422);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(905, 12);
            this.label16.TabIndex = 23;
            this.label16.Text = "Note: Because the real IBT scoring policy will take all the students\' performance" +
    " into account, the standard score gained here can\'t be very accurate!";
            // 
            // dgv_listeninganswers
            // 
            this.dgv_listeninganswers.AllowUserToAddRows = false;
            this.dgv_listeninganswers.AllowUserToDeleteRows = false;
            this.dgv_listeninganswers.AllowUserToResizeColumns = false;
            this.dgv_listeninganswers.AllowUserToResizeRows = false;
            this.dgv_listeninganswers.AutoGenerateColumns = false;
            this.dgv_listeninganswers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_listeninganswers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_listeninganswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_listeninganswers.DataSource = this.bindingSource_Section;
            this.dgv_listeninganswers.Location = new System.Drawing.Point(64, 64);
            this.dgv_listeninganswers.MultiSelect = false;
            this.dgv_listeninganswers.Name = "dgv_listeninganswers";
            this.dgv_listeninganswers.ReadOnly = true;
            this.dgv_listeninganswers.RowHeadersVisible = false;
            this.dgv_listeninganswers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_listeninganswers.RowTemplate.Height = 23;
            this.dgv_listeninganswers.RowTemplate.ReadOnly = true;
            this.dgv_listeninganswers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listeninganswers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listeninganswers.Size = new System.Drawing.Size(393, 341);
            this.dgv_listeninganswers.TabIndex = 22;
            this.dgv_listeninganswers.TabStop = false;
            this.dgv_listeninganswers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_readinganswers_DataBindingComplete);
            // 
            // lbl_listeningScorereport
            // 
            this.lbl_listeningScorereport.AutoSize = true;
            this.lbl_listeningScorereport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_listeningScorereport.Location = new System.Drawing.Point(61, 13);
            this.lbl_listeningScorereport.Name = "lbl_listeningScorereport";
            this.lbl_listeningScorereport.Size = new System.Drawing.Size(97, 17);
            this.lbl_listeningScorereport.TabIndex = 21;
            this.lbl_listeningScorereport.Text = "scoreReport";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "Wrong Answered";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox9.Location = new System.Drawing.Point(299, 38);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(27, 20);
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "Right Answered";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Green;
            this.pictureBox10.Location = new System.Drawing.Point(182, 38);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(27, 20);
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "Not Answered";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Red;
            this.pictureBox11.Location = new System.Drawing.Point(64, 38);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(27, 20);
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            // 
            // tab_speakinganswers
            // 
            this.tab_speakinganswers.AutoScroll = true;
            this.tab_speakinganswers.Controls.Add(this.tableLayoutPanel2);
            this.tab_speakinganswers.Location = new System.Drawing.Point(4, 22);
            this.tab_speakinganswers.Name = "tab_speakinganswers";
            this.tab_speakinganswers.Size = new System.Drawing.Size(773, 484);
            this.tab_speakinganswers.TabIndex = 2;
            this.tab_speakinganswers.Text = "Speaking";
            this.tab_speakinganswers.UseVisualStyleBackColor = true;
            this.tab_speakinganswers.Click += new System.EventHandler(this.tab_speakinganswers_Click);
            this.tab_speakinganswers.Leave += new System.EventHandler(this.tab_speakinganswers_Leave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.2973F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.24324F));
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(84, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(373, 422);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 66);
            this.label10.TabIndex = 0;
            this.label10.Text = "SPEAKING 1";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(6, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 66);
            this.label11.TabIndex = 0;
            this.label11.Text = "SPEAKING 2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(6, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 66);
            this.label12.TabIndex = 0;
            this.label12.Text = "SPEAKING 3";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(6, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 66);
            this.label13.TabIndex = 0;
            this.label13.Text = "SPEAKING 4";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(6, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 66);
            this.label14.TabIndex = 0;
            this.label14.Text = "SPEAKING 5";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(6, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 70);
            this.label15.TabIndex = 0;
            this.label15.Text = "SPEAKING 6";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_speakinganswer1
            // 
            this.btn_speakinganswer1.BackgroundImage = global::Properties.Resources.horn;
            this.btn_speakinganswer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_speakinganswer1.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_speakinganswer1.Location = new System.Drawing.Point(142, 6);
            this.btn_speakinganswer1.Name = "btn_speakinganswer1";
            this.btn_speakinganswer1.Size = new System.Drawing.Size(65, 60);
            this.btn_speakinganswer1.TabIndex = 1;
            this.btn_speakinganswer1.UseVisualStyleBackColor = true;
            this.btn_speakinganswer1.Click += new System.EventHandler(this.btn_speakinganswer_Click);
            // 
            // btn_speakinganswer2
            // 
            this.btn_speakinganswer2.BackgroundImage = global::Properties.Resources.horn;
            this.btn_speakinganswer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_speakinganswer2.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_speakinganswer2.Location = new System.Drawing.Point(142, 75);
            this.btn_speakinganswer2.Name = "btn_speakinganswer2";
            this.btn_speakinganswer2.Size = new System.Drawing.Size(65, 60);
            this.btn_speakinganswer2.TabIndex = 1;
            this.btn_speakinganswer2.UseVisualStyleBackColor = true;
            this.btn_speakinganswer2.Click += new System.EventHandler(this.btn_speakinganswer_Click);
            // 
            // btn_speakinganswer3
            // 
            this.btn_speakinganswer3.BackgroundImage = global::Properties.Resources.horn;
            this.btn_speakinganswer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_speakinganswer3.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_speakinganswer3.Location = new System.Drawing.Point(142, 144);
            this.btn_speakinganswer3.Name = "btn_speakinganswer3";
            this.btn_speakinganswer3.Size = new System.Drawing.Size(65, 60);
            this.btn_speakinganswer3.TabIndex = 1;
            this.btn_speakinganswer3.UseVisualStyleBackColor = true;
            this.btn_speakinganswer3.Click += new System.EventHandler(this.btn_speakinganswer_Click);
            // 
            // btn_speakinganswer4
            // 
            this.btn_speakinganswer4.BackgroundImage = global::Properties.Resources.horn;
            this.btn_speakinganswer4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_speakinganswer4.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_speakinganswer4.Location = new System.Drawing.Point(142, 213);
            this.btn_speakinganswer4.Name = "btn_speakinganswer4";
            this.btn_speakinganswer4.Size = new System.Drawing.Size(65, 60);
            this.btn_speakinganswer4.TabIndex = 1;
            this.btn_speakinganswer4.UseVisualStyleBackColor = true;
            this.btn_speakinganswer4.Click += new System.EventHandler(this.btn_speakinganswer_Click);
            // 
            // btn_speakinganswer5
            // 
            this.btn_speakinganswer5.BackgroundImage = global::Properties.Resources.horn;
            this.btn_speakinganswer5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_speakinganswer5.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_speakinganswer5.Location = new System.Drawing.Point(142, 282);
            this.btn_speakinganswer5.Name = "btn_speakinganswer5";
            this.btn_speakinganswer5.Size = new System.Drawing.Size(65, 60);
            this.btn_speakinganswer5.TabIndex = 1;
            this.btn_speakinganswer5.UseVisualStyleBackColor = true;
            this.btn_speakinganswer5.Click += new System.EventHandler(this.btn_speakinganswer_Click);
            // 
            // btn_speakinganswer6
            // 
            this.btn_speakinganswer6.BackgroundImage = global::Properties.Resources.horn;
            this.btn_speakinganswer6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_speakinganswer6.FlatAppearance.BorderSize = 0;
            this.btn_speakinganswer6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_speakinganswer6.Location = new System.Drawing.Point(142, 351);
            this.btn_speakinganswer6.Name = "btn_speakinganswer6";
            this.btn_speakinganswer6.Size = new System.Drawing.Size(65, 61);
            this.btn_speakinganswer6.TabIndex = 1;
            this.btn_speakinganswer6.UseVisualStyleBackColor = true;
            this.btn_speakinganswer6.Click += new System.EventHandler(this.btn_speakinganswer_Click);
            // 
            // tab_writinganswers
            // 
            this.tab_writinganswers.Controls.Add(this.rtb_writinganswers);
            this.tab_writinganswers.Controls.Add(this.rtb_writing2);
            this.tab_writinganswers.Controls.Add(this.rtb_writing1);
            this.tab_writinganswers.Location = new System.Drawing.Point(4, 22);
            this.tab_writinganswers.Name = "tab_writinganswers";
            this.tab_writinganswers.Size = new System.Drawing.Size(773, 484);
            this.tab_writinganswers.TabIndex = 3;
            this.tab_writinganswers.Text = "Writing";
            this.tab_writinganswers.UseVisualStyleBackColor = true;
            // 
            // rtb_writinganswers
            // 
            this.rtb_writinganswers.Location = new System.Drawing.Point(55, 40);
            this.rtb_writinganswers.Name = "rtb_writinganswers";
            this.rtb_writinganswers.Size = new System.Drawing.Size(402, 394);
            this.rtb_writinganswers.TabIndex = 1;
            this.rtb_writinganswers.Text = "";
            // 
            // rtb_writing2
            // 
            this.rtb_writing2.AutoSize = true;
            this.rtb_writing2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_writing2.Location = new System.Drawing.Point(213, 15);
            this.rtb_writing2.Name = "rtb_writing2";
            this.rtb_writing2.Size = new System.Drawing.Size(172, 21);
            this.rtb_writing2.TabIndex = 0;
            this.rtb_writing2.Text = "Independent Writing";
            this.rtb_writing2.UseVisualStyleBackColor = true;
            this.rtb_writing2.CheckedChanged += new System.EventHandler(this.rtb_writing2_CheckedChanged);
            // 
            // rtb_writing1
            // 
            this.rtb_writing1.AutoSize = true;
            this.rtb_writing1.Checked = true;
            this.rtb_writing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_writing1.Location = new System.Drawing.Point(55, 15);
            this.rtb_writing1.Name = "rtb_writing1";
            this.rtb_writing1.Size = new System.Drawing.Size(152, 21);
            this.rtb_writing1.TabIndex = 0;
            this.rtb_writing1.TabStop = true;
            this.rtb_writing1.Text = "Integrated Wrting";
            this.rtb_writing1.UseVisualStyleBackColor = true;
            // 
            // btn_ShowText
            // 
            this.btn_ShowText.BackgroundImage = global::Properties.Resources.viewtext;
            this.btn_ShowText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShowText.FlatAppearance.BorderSize = 0;
            this.btn_ShowText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowText.Location = new System.Drawing.Point(523, 10);
            this.btn_ShowText.Name = "btn_ShowText";
            this.btn_ShowText.Size = new System.Drawing.Size(74, 31);
            this.btn_ShowText.TabIndex = 16;
            this.btn_ShowText.TabStop = false;
            this.btn_ShowText.UseVisualStyleBackColor = true;
            this.btn_ShowText.Visible = false;
            this.btn_ShowText.Click += new System.EventHandler(this.btn_ShowText_Click);
            // 
            // flash_timer
            // 
            this.flash_timer.Interval = 300;
            this.flash_timer.Tick += new System.EventHandler(this.flash_timer_Tick);
            // 
            // Timer_Speaking
            // 
            this.Timer_Speaking.Interval = 1000;
            this.Timer_Speaking.Tick += new System.EventHandler(this.Timer_Speaking_Tick);
            // 
            // ckb_viewSpeakingText
            // 
            this.ckb_viewSpeakingText.BackColor = System.Drawing.Color.Transparent;
            this.ckb_viewSpeakingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_viewSpeakingText.Location = new System.Drawing.Point(462, 51);
            this.ckb_viewSpeakingText.Name = "ckb_viewSpeakingText";
            this.ckb_viewSpeakingText.Size = new System.Drawing.Size(112, 21);
            this.ckb_viewSpeakingText.TabIndex = 17;
            this.ckb_viewSpeakingText.TabStop = false;
            this.ckb_viewSpeakingText.Text = "Show Scripts";
            this.ckb_viewSpeakingText.UseVisualStyleBackColor = false;
            this.ckb_viewSpeakingText.Visible = false;
            this.ckb_viewSpeakingText.CheckedChanged += new System.EventHandler(this.ckb_viewSpeakingText_CheckedChanged);
            // 
            // lbl_testingSection
            // 
            this.lbl_testingSection.AutoSize = true;
            this.lbl_testingSection.BackColor = System.Drawing.Color.Transparent;
            this.lbl_testingSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_testingSection.Location = new System.Drawing.Point(10, 2);
            this.lbl_testingSection.Name = "lbl_testingSection";
            this.lbl_testingSection.Size = new System.Drawing.Size(174, 24);
            this.lbl_testingSection.TabIndex = 18;
            this.lbl_testingSection.Text = "lbl_testingSection";
            this.lbl_testingSection.Visible = false;
            // 
            // btn_LastPage
            // 
            this.btn_LastPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LastPage.BackgroundImage")));
            this.btn_LastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LastPage.Enabled = false;
            this.btn_LastPage.FlatAppearance.BorderSize = 0;
            this.btn_LastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LastPage.Location = new System.Drawing.Point(7, 27);
            this.btn_LastPage.Name = "btn_LastPage";
            this.btn_LastPage.Size = new System.Drawing.Size(85, 30);
            this.btn_LastPage.TabIndex = 19;
            this.btn_LastPage.TabStop = false;
            this.btn_LastPage.UseVisualStyleBackColor = true;
            this.btn_LastPage.Click += new System.EventHandler(this.btn_LastPage_Click);
            // 
            // btn_NexPage
            // 
            this.btn_NexPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_NexPage.BackgroundImage")));
            this.btn_NexPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NexPage.FlatAppearance.BorderSize = 0;
            this.btn_NexPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NexPage.Location = new System.Drawing.Point(67, 27);
            this.btn_NexPage.Name = "btn_NexPage";
            this.btn_NexPage.Size = new System.Drawing.Size(85, 30);
            this.btn_NexPage.TabIndex = 19;
            this.btn_NexPage.TabStop = false;
            this.btn_NexPage.UseVisualStyleBackColor = true;
            this.btn_NexPage.Click += new System.EventHandler(this.btn_NexPage_Click);
            // 
            // rb_PracticeMode
            // 
            this.rb_PracticeMode.AutoSize = true;
            this.rb_PracticeMode.BackColor = System.Drawing.Color.Transparent;
            this.rb_PracticeMode.Checked = true;
            this.rb_PracticeMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_PracticeMode.Location = new System.Drawing.Point(265, 11);
            this.rb_PracticeMode.Name = "rb_PracticeMode";
            this.rb_PracticeMode.Size = new System.Drawing.Size(151, 21);
            this.rb_PracticeMode.TabIndex = 20;
            this.rb_PracticeMode.TabStop = true;
            this.rb_PracticeMode.Text = "PRACTICE MODE";
            this.rb_PracticeMode.UseVisualStyleBackColor = false;
            // 
            // rb_TestMode
            // 
            this.rb_TestMode.AutoSize = true;
            this.rb_TestMode.BackColor = System.Drawing.Color.Transparent;
            this.rb_TestMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_TestMode.Location = new System.Drawing.Point(265, 38);
            this.rb_TestMode.Name = "rb_TestMode";
            this.rb_TestMode.Size = new System.Drawing.Size(116, 21);
            this.rb_TestMode.TabIndex = 20;
            this.rb_TestMode.Text = "TEST MODE";
            this.rb_TestMode.UseVisualStyleBackColor = false;
            // 
            // ckb_ShowAnswer
            // 
            this.ckb_ShowAnswer.AutoSize = true;
            this.ckb_ShowAnswer.BackColor = System.Drawing.Color.Transparent;
            this.ckb_ShowAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckb_ShowAnswer.Location = new System.Drawing.Point(203, 54);
            this.ckb_ShowAnswer.Name = "ckb_ShowAnswer";
            this.ckb_ShowAnswer.Size = new System.Drawing.Size(111, 19);
            this.ckb_ShowAnswer.TabIndex = 22;
            this.ckb_ShowAnswer.TabStop = false;
            this.ckb_ShowAnswer.Text = "Show Answer";
            this.ckb_ShowAnswer.UseVisualStyleBackColor = false;
            this.ckb_ShowAnswer.Visible = false;
            this.ckb_ShowAnswer.CheckedChanged += new System.EventHandler(this.ckb_ShowAnswer_CheckedChanged);
            // 
            // btn_pause
            // 
            this.btn_pause.BackgroundImage = global::Properties.Resources.pause;
            this.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pause.FlatAppearance.BorderSize = 0;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Location = new System.Drawing.Point(110, 30);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(69, 24);
            this.btn_pause.TabIndex = 16;
            this.btn_pause.TabStop = false;
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Visible = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_QUITapp
            // 
            this.btn_QUITapp.BackgroundImage = global::Properties.Resources.exit1;
            this.btn_QUITapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_QUITapp.FlatAppearance.BorderSize = 0;
            this.btn_QUITapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QUITapp.Location = new System.Drawing.Point(707, 0);
            this.btn_QUITapp.Name = "btn_QUITapp";
            this.btn_QUITapp.Size = new System.Drawing.Size(80, 44);
            this.btn_QUITapp.TabIndex = 23;
            this.btn_QUITapp.UseVisualStyleBackColor = true;
            this.btn_QUITapp.Click += new System.EventHandler(this.btn_QUITapp_Click);
            // 
            // bgimagelist
            // 
            this.bgimagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bgimagelist.ImageStream")));
            this.bgimagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.bgimagelist.Images.SetKeyName(0, "back1");
            this.bgimagelist.Images.SetKeyName(1, "continue");
            this.bgimagelist.Images.SetKeyName(2, "exit1");
            this.bgimagelist.Images.SetKeyName(3, "exit2");
            this.bgimagelist.Images.SetKeyName(4, "help");
            this.bgimagelist.Images.SetKeyName(5, "hidetimer");
            this.bgimagelist.Images.SetKeyName(6, "next");
            this.bgimagelist.Images.SetKeyName(7, "ok");
            this.bgimagelist.Images.SetKeyName(8, "Review");
            this.bgimagelist.Images.SetKeyName(9, "volumn");
            // 
            // btn_showexplanation
            // 
            this.btn_showexplanation.BackColor = System.Drawing.Color.Transparent;
            this.btn_showexplanation.BackgroundImage = global::Properties.Resources.EXPLANATION;
            this.btn_showexplanation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_showexplanation.FlatAppearance.BorderSize = 0;
            this.btn_showexplanation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showexplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_showexplanation.Location = new System.Drawing.Point(318, 14);
            this.btn_showexplanation.Name = "btn_showexplanation";
            this.btn_showexplanation.Size = new System.Drawing.Size(68, 29);
            this.btn_showexplanation.TabIndex = 24;
            this.btn_showexplanation.UseVisualStyleBackColor = false;
            this.btn_showexplanation.Visible = false;
            this.btn_showexplanation.Click += new System.EventHandler(this.btn_showexplanation_Click);
            // 
            // btn_showtranslation
            // 
            this.btn_showtranslation.BackColor = System.Drawing.Color.Transparent;
            this.btn_showtranslation.BackgroundImage = global::Properties.Resources.TRANSLATION;
            this.btn_showtranslation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_showtranslation.FlatAppearance.BorderSize = 0;
            this.btn_showtranslation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showtranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_showtranslation.Location = new System.Drawing.Point(397, 14);
            this.btn_showtranslation.Name = "btn_showtranslation";
            this.btn_showtranslation.Size = new System.Drawing.Size(70, 28);
            this.btn_showtranslation.TabIndex = 24;
            this.btn_showtranslation.UseVisualStyleBackColor = false;
            this.btn_showtranslation.Visible = false;
            this.btn_showtranslation.Click += new System.EventHandler(this.btn_showtranslation_Click);
            // 
            // Timer_reading
            // 
            this.Timer_reading.Tick += new System.EventHandler(this.Timer_reading_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(788, 611);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_NexPage);
            this.Controls.Add(this.ckb_ShowAnswer);
            this.Controls.Add(this.btn_LastPage);
            this.Controls.Add(this.tabf_test);
            this.Controls.Add(this.lbl_testingSection);
            this.Controls.Add(this.ckb_viewSpeakingText);
            this.Controls.Add(this.rb_PracticeMode);
            this.Controls.Add(this.rb_TestMode);
            this.Controls.Add(this.btn_showtranslation);
            this.Controls.Add(this.btn_showexplanation);
            this.Controls.Add(this.btn_ShowText);
            this.Controls.Add(this.btn_QUITapp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPO";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Controls.SetChildIndex(this.btn_nextQuestion, 0);
            this.Controls.SetChildIndex(this.btn_continue, 0);
            this.Controls.SetChildIndex(this.btn_QUITapp, 0);
            this.Controls.SetChildIndex(this.btn_preQuestion, 0);
            this.Controls.SetChildIndex(this.btn_ShowText, 0);
            this.Controls.SetChildIndex(this.btn_review, 0);
            this.Controls.SetChildIndex(this.Sound_icon, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btn_showexplanation, 0);
            this.Controls.SetChildIndex(this.btn_showtranslation, 0);
            this.Controls.SetChildIndex(this.rb_TestMode, 0);
            this.Controls.SetChildIndex(this.rb_PracticeMode, 0);
            this.Controls.SetChildIndex(this.ckb_viewSpeakingText, 0);
            this.Controls.SetChildIndex(this.lbl_testingSection, 0);
            this.Controls.SetChildIndex(this.tabf_test, 0);
            this.Controls.SetChildIndex(this.btn_LastPage, 0);
            this.Controls.SetChildIndex(this.ckb_ShowAnswer, 0);
            this.Controls.SetChildIndex(this.btn_NexPage, 0);
            this.Controls.SetChildIndex(this.btn_pause, 0);
            this.Controls.SetChildIndex(this.btn_mainmenu, 0);
            this.Controls.SetChildIndex(this.btn_quit, 0);
            this.Controls.SetChildIndex(this.tb_sound, 0);
            this.Controls.SetChildIndex(this.lbl_timeremain, 0);
            this.Controls.SetChildIndex(this.lbl_questionNO, 0);
            this.Controls.SetChildIndex(this.lbl_mode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tb_sound)).EndInit();
            this.tabf_test.ResumeLayout(false);
            this.tab_CoverForm.ResumeLayout(false);
            this.tabf_tposelection.ResumeLayout(false);
            this.TPO10.ResumeLayout(false);
            this.TPO10.PerformLayout();
            this.tab_Reading.ResumeLayout(false);
            this.tabf_Reading.ResumeLayout(false);
            this.rtab_Direction.ResumeLayout(false);
            this.rtab_Direction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rtab_NormalQuestion.ResumeLayout(false);
            this.rtab_NormalQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_reading)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_wrongAnswered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightAnswered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readingReview)).EndInit();
            this.tab_Listening.ResumeLayout(false);
            this.tabf_Listening.ResumeLayout(false);
            this.ltab_Direction1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ltab_Materials.ResumeLayout(false);
            this.l_splitContainer.Panel1.ResumeLayout(false);
            this.l_splitContainer.Panel1.PerformLayout();
            this.l_splitContainer.Panel2.ResumeLayout(false);
            this.l_splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_currentpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ListenScene)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flp_passage.ResumeLayout(false);
            this.flp_passage.PerformLayout();
            this.lMaterials1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_currentpos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ListenScene1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.sNormalQuestions.ResumeLayout(false);
            this.sNormalQuestions.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_speakingScene)).EndInit();
            this.tab_Writing.ResumeLayout(false);
            this.tabf_writing.ResumeLayout(false);
            this.wDirection.ResumeLayout(false);
            this.wDirection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.wReading.ResumeLayout(false);
            this.wSpeakingPassage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wtb_speak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_writingScene)).EndInit();
            this.wWriting2.ResumeLayout(false);
            this.wpanel.ResumeLayout(false);
            this.wpanel.PerformLayout();
            this.tab_Answers.ResumeLayout(false);
            this.tabf_answer.ResumeLayout(false);
            this.tab_readinganswer.ResumeLayout(false);
            this.tab_readinganswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readingSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readinganswers)).EndInit();
            this.tab_listeninganswers.ResumeLayout(false);
            this.tab_listeninganswers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeningSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeninganswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Section)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.tab_speakinganswers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tab_writinganswers.ResumeLayout(false);
            this.tab_writinganswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
            this.btn_pause.BackgroundImage = (Image)this.resmgr.GetObject("pause");
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
            LinkLabel label = (LinkLabel)sender;
            label.Links[label.Links.IndexOf(e.Link)].Visited = true;
            string linkData = e.Link.LinkData as string;
            this.MP3Player.SetPlayTime((long)Convert.ToInt32(linkData));
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
                this.TestQuestions = new TPOPart(RtfReader.getRTF(@"Tests\" + this.TPONO + @"\Listening\questions.rtf"), @"Tests\" + this.TPONO + @"\Listening\questions.xml", "");
            }
            base.lbl_questionNO.Text = "Question " + this.QuestionNO.ToString() + " of 34";
            XMLReader reader = new XMLReader(@"Tests\" + this.TPONO + @"\Listening\questions.xml");
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
            Section question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
            base.lbl_questionNO.Text = "Question " + this.QuestionNO + " of 34";
            this.llbl_rightAnswer.Visible = this.ckb_ShowAnswer.Checked;
            this.IsPassageMP3 = false;
            switch (question.QuestionType)
            {
                case QuestionType.TABLE:
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
                            this.LRtbTableCol[length].Rtf = (string)question.ColStrs[length];
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
                            this.LRtbTableRow[num5].Rtf = (string)question.RowStrs[num5];
                            this.LRtbTableRow[num5].Visible = true;
                        }
                        if (this.ckb_ShowAnswer.Checked)
                        {
                            this.lbl_tableAnswer.Visible = true;
                            this.lbl_tableAnswer.Text = question.CorrectAnswersStr;
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
                        this.LCkbAnswers[((int)question.UserAnswers[length]) - 1].Checked = true;
                    }
                    for (int i = 0; i < question.CorrectAnswer.Length; i++)
                    {
                        if (this.ckb_ShowAnswer.Checked)
                        {
                            this.LRtbAnswers[question.CorrectAnswer[i] - 1].BackColor = Color.LightPink;
                        }
                        else
                        {
                            this.LRtbAnswers[question.CorrectAnswer[i] - 1].BackColor = SystemColors.ControlLight;
                        }
                    }
                    goto Label_0656;
            }
            this.llbl_rightAnswer.Text = question.CorrectAnswersStr;
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
                this.ButtonsStatus();
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
                    LyricsReader.Lrc lrc = (LyricsReader.Lrc)reader.LrcList[num3];
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
            this.ButtonsStatus();
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
                Section question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
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
                        for (num = 0; num < question.CorrectAnswer.Length; num++)
                        {
                            this.RtbSumAnswersToBeSelected[question.CorrectAnswer[num] - 1].BackColor = Color.LightPink;
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
                    for (num = 0; (num < question.MyAnswer.Length) && (num < this.CkbSummary.Length); num++)
                    {
                        this.RtbSumAnswersToBeSelected[num].Visible = true;
                        this.CkbSummary[num].Visible = true;
                        this.RtbSumAnswersToBeSelected[num].Rtf = question.MyAnswer[num].ToString();
                    }
                    for (num = 0; num < question.CorrectAnswer.Length; num++)
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
                else if (question.QuestionType == QuestionType.TABLE)
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
                        this.LRtbTableCol[num].Rtf = (string)question.ColStrs[num];
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
                        this.LRtbTableRow[num5].Rtf = (string)question.RowStrs[num5];
                        this.LRtbTableRow[num5].Visible = true;
                    }
                    if (this.ckb_ShowAnswer.Checked)
                    {
                        this.lbl_tableAnswer.Visible = true;
                        this.lbl_tableAnswer.Text = question.CorrectAnswersStr;
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
                    for (num = 0; (num < question.MyAnswer.Length) && (num < this.CkbReading.Length); num++)
                    {
                        this.RtbReadingAnswers[num].Visible = true;
                        if (question.QuestionType != QuestionType.INSERT)
                        {
                            this.CkbReading[num].Visible = true;
                        }
                        this.RtbReadingAnswers[num].Rtf = question.MyAnswer[num].ToString();
                        this.RtbReadingAnswers[num].BackColor = SystemColors.ControlLight;
                    }
                    if (this.ckb_ShowAnswer.Checked)
                    {
                        for (int i = 0; i < question.CorrectAnswer.Length; i++)
                        {
                            this.RtbReadingAnswers[question.CorrectAnswer[i] - 1].BackColor = Color.LightPink;
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
                        this.CkbReading[((int)question.UserAnswers[num]) - 1].Checked = true;
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
            XMLReader reader = new XMLReader();
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
                        Section question = (Section)this.TestQuestions.Questions[num - 2];
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
            this.tabf_test.Region = new Region(new RectangleF((float)this.tabf_test.TabPages[0].Left, (float)this.tabf_test.TabPages[0].Top, (float)this.tabf_test.TabPages[0].Width, (float)this.tabf_test.TabPages[0].Height));
            this.tabf_tposelection.Region = new Region(new RectangleF((float)this.tabf_test.TabPages[0].Left, (float)this.tabf_test.TabPages[0].Top, (float)this.tabf_tposelection.TabPages[0].Width, (float)this.tabf_tposelection.TabPages[0].Height));
            this.tabf_Reading.Region = new Region(new RectangleF((float)this.tabf_test.TabPages[0].Left, (float)this.tabf_test.TabPages[0].Top, (float)this.tabf_Reading.TabPages[0].Width, (float)this.tabf_Reading.TabPages[0].Height));
            this.tabf_Listening.Region = new Region(new RectangleF((float)this.tabf_test.TabPages[0].Left, (float)this.tabf_test.TabPages[0].Top, (float)this.tabf_Listening.TabPages[0].Width, (float)this.tabf_Listening.TabPages[0].Height));
            this.tabf_speaking.Region = new Region(new RectangleF((float)this.tabf_test.TabPages[0].Left, (float)this.tabf_test.TabPages[0].Top, (float)this.tabf_speaking.TabPages[0].Width, (float)this.tabf_speaking.TabPages[0].Height));
            this.tabf_writing.Region = new Region(new RectangleF((float)this.tabf_test.TabPages[0].Left, (float)this.tabf_test.TabPages[0].Top, (float)this.tabf_writing.TabPages[0].Width, (float)this.tabf_writing.TabPages[0].Height));
            this.Antuorization();
        }

        private void GetConnectAndCreateTable()
        {
            if (!Directory.Exists("history"))
            {
                Directory.CreateDirectory("history");
            }
            if (!File.Exists("history/history.db"))
            {
                SQLiteConnection.CreateFile("history/history.db");
            }

            /*using (DataTable tbl = DbProviderFactories.GetFactoryClasses())
            {
                foreach (DataRow row in tbl.Rows)
                {
                    string prov = row[2].ToString();
                    if ((prov.IndexOf("SQLite", 0, StringComparison.OrdinalIgnoreCase) != -1) || (prov.IndexOf("SqlClient", 0, StringComparison.OrdinalIgnoreCase) != -1))
                    {
                        MessageBox.Show("SQLite");
                    }
                    if (prov == "System.Data.SQLite")
                    {
                        MessageBox.Show("Has System.Data.SQLite");
                    }
                }
            }*/


            //this.dbConn = new System.Data.SQLite.SQLiteConnection("Data Source=history/history.s3db");
            SQLiteConnection dbConn = new SQLiteConnection("Data Source=history/history.db;Pooling=true;FailIfMissing=false");
            dbConn.Open();

            try
            {

                SQLiteCommand cmd = dbConn.CreateCommand();

                String temp = "select count(*) from sqlite_master where type='table' and name='%s'";
                cmd.CommandText = temp + "Reading";
                int ln = cmd.ExecuteNonQuery();
                if (ln < 1)
                {
                    cmd.CommandText = "CREATE TABLE Reading(QuestionNo TEXT(5) PRIMARY KEY AUTOINCREMENT, QuestionType TEXT(15), YourAnswers TEXT(5), StandardAnswers TEXT(5), Score TEXT(5))";
                    cmd.ExecuteNonQuery();
                }

                cmd.CommandText = temp + "Listening";
                string str = cmd.ExecuteScalar().ToString();
                if (str == null || Convert.ToInt32(str) < 0)
                {
                    cmd.CommandText = "CREATE TABLE Listening(QuestionNo TEXT(5) PRIMARY KEY AUTOINCREMENT, QuestionType TEXT(15), YourAnswers TEXT(5), StandardAnswers TEXT(5), Score TEXT(5))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.StackTrace);
                Debug.Print(ex.StackTrace);
            }

            String sql_create = @"CREATE TABLE test_tbl(id INTEGER PRIMARY KEY AUTOINCREMENT,
							byte0 TEXT(4), byte1 TEXT(4), byte2 TEXT(4), byte3 TEXT(4), byte4 TEXT(4),
							byte5 TEXT(4), byte6 TEXT(4), byte7 TEXT(4));";
            DbCommand com = dbConn.CreateCommand();
            String tableVerify = "select count(*) from sqlite_master where type='table' and name='%s' ";
            String[] sections = { "Reading", "Listening", "Speaking", "Writing" };
            foreach (String section in sections)
            {

            }


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

            #region temporarily disabled
            //this.SaveUserAnswers();
            #endregion temporarily disabled
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
                        XMLReader reader = new XMLReader(@"Tests\" + this.TPONO + @"\Reading\config.xml");
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
                        this.TestQuestions = new TPOPart(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\questions" + this.PassageNO.ToString() + ".txt").Substring(0xb5), "", RtfReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\Q" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
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
            XMLReader reader2 = new XMLReader(@"Tests\Direction\Scoring.xml");
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
                Section question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
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
                Section question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
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
            RichTextBox box = (RichTextBox)sender;
            int num = box.GetPositionFromCharIndex(box.TextLength - 1).Y - box.GetPositionFromCharIndex(0).Y;
            box.Height = num + 20;
        }

        private void RtbSumSelected_Click(object sender, EventArgs e)
        {
            int num2;
            RichTextBox box = (RichTextBox)sender;
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
            Section question;
            int num;
            int count;
            bool flag;
            int num3;
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    if (this.QuestionNO > 0)
                    {
                        question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
                        question.UserAnswers = new ArrayList();
                        if (question.QuestionType != QuestionType.SUMMARY)
                        {
                            if (question.QuestionType == QuestionType.TABLE)
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
                        while (num < question.CorrectAnswer.Length)
                        {
                            question.UserAnswers.Add(this.SummarySelectedAnswers[num]);
                            num++;
                        }
                    }
                    break;

                case TestingSection.LISTENING:
                    if (this.QuestionNO > 0)
                    {
                        question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
                        question.UserAnswers = new ArrayList();
                        if (question.QuestionType != QuestionType.SORT)
                        {
                            if (question.QuestionType == QuestionType.TABLE)
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
                            for (num = 0; num < question.CorrectAnswer.Length; num++)
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
            Section question = null;
            XMLReader reader = new XMLReader(@"Tests\Direction\Scoring.xml");
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            for (int i = 0; i < this.TestQuestions.Questions.Count; i++)
            {
                question = (Section)this.TestQuestions.Questions[i];
                if (question.MyAnswersStr.Equals(question.CorrectAnswersStr))
                {
                    num4 += question.Score;
                    num++;
                }
                else if (question.MyAnswersStr.Equals(""))
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
                this.btn_speakinganswer1.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.btn_speakinganswer1.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
            }
            if (File.Exists(str + @"\SpeakingAnswer2.wav"))
            {
                this.btn_speakinganswer2.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.btn_speakinganswer2.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
            }
            if (File.Exists(str + @"\SpeakingAnswer3.wav"))
            {
                this.btn_speakinganswer3.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.btn_speakinganswer3.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
            }
            if (File.Exists(str + @"\SpeakingAnswer4.wav"))
            {
                this.btn_speakinganswer4.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.btn_speakinganswer4.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
            }
            if (File.Exists(str + @"\SpeakingAnswer5.wav"))
            {
                this.btn_speakinganswer5.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.btn_speakinganswer5.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
            }
            if (File.Exists(str + @"\SpeakingAnswer6.wav"))
            {
                this.btn_speakinganswer6.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.btn_speakinganswer6.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
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
            TabControl control = (TabControl)sender;
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
            this.MP3Player.SetPlayTime((long)(this.tb_currentpos.Value * 0x3e8));
        }

        private void tb_currentpos1_Scroll(object sender, EventArgs e)
        {
            this.MP3Player.SetPlayTime((long)(this.tb_currentpos1.Value * 0x3e8));
        }

        private void tb_reading_Scroll(object sender, EventArgs e)
        {
            this.MP3Player.SetPlayTime((long)(this.tb_reading.Value * 0x3e8));
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
                        XMLReader reader = new XMLReader(@"Tests\" + this.TPONO + @"\Reading\config.xml");
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
                        this.TestQuestions = new TPOPart(RtfReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\questions" + this.PassageNO.ToString() + ".txt").Substring(0xb5), "", RtfReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\Q" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
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
                    base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("ok");
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
                        base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
                    }
                    if (this.rb_PracticeMode.Checked)
                    {
                        this.ckb_ShowAnswer.Visible = true;
                    }
                    if (this.QuestionNO > 0)
                    {
                        time6 = DateTime.ParseExact("00:01", "mm:ss", null);
                        span = (TimeSpan)(DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time6);
                        base.lbl_timeremain.Text = span.Minutes.ToString().PadLeft(2, '0') + ":" + span.Seconds.ToString().PadLeft(2, '0');
                    }
                    if (this.QuestionNO >= 1)
                    {
                        Section question = (Section)this.TestQuestions.Questions[this.QuestionNO - 1];
                        switch (question.QuestionType)
                        {
                            case QuestionType.TABLE:
                                if (!this.ckb_ShowAnswer.Checked)
                                {
                                    this.lbl_tableAnswer.Visible = false;
                                    break;
                                }
                                this.lbl_tableAnswer.Visible = true;
                                this.lbl_tableAnswer.Text = question.CorrectAnswersStr;
                                break;

                            case QuestionType.SORT:
                                if (question.QuestionType == QuestionType.SORT)
                                {
                                    this.rtb_sumQuestion.Rtf = question.QuestionTitle;
                                    this.rtb_sumQuestion.Visible = true;
                                    num4 = 0;
                                    while ((num4 < question.MyAnswer.Length) && (num4 < this.CkbSummary.Length))
                                    {
                                        this.RtbSumAnswersToBeSelected[num4].Visible = true;
                                        this.CkbSummary[num4].Visible = true;
                                        this.RtbSumAnswersToBeSelected[num4].Rtf = (question.MyAnswer[num4]).ToString();
                                        num4++;
                                    }
                                    for (num4 = 0; num4 < question.CorrectAnswer.Length; num4++)
                                    {
                                        this.RtbSumSelected[num4].Visible = true;
                                    }
                                    this.Timer_Listening.Stop();
                                }
                                break;

                            default:
                                for (num4 = 0; (num4 < question.MyAnswer.Length) && (num4 < this.CkbReading.Length); num4++)
                                {
                                    this.LRtbAnswers[num4].Visible = true;
                                    this.LCkbAnswers[num4].Visible = true;
                                    this.LRtbAnswers[num4].Rtf = (question.MyAnswer[num4]).ToString();
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
                span = (TimeSpan)(DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time6);
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
                                    base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
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
                                base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
                                base.btn_preQuestion.Enabled = false;
                                base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back");
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
                            span = (TimeSpan)(DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
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
                                        base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back1");
                                    }
                                    base.btn_nextQuestion.Enabled = true;
                                    base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
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
                                        base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back1");
                                    }
                                    base.btn_nextQuestion.Enabled = true;
                                    base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
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
                                    base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back1");
                                }
                                base.btn_nextQuestion.Enabled = true;
                                base.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
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
                            span = (TimeSpan)(DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
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
                                    base.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("back1");
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
                            span = (TimeSpan)(DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
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
                XMLReader reader = new XMLReader(@"Tests\" + this.TPONO + @"\Speaking\questions.xml");
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
                        span = (TimeSpan)(DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
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
                        span = (TimeSpan)(DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
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
                        span = (TimeSpan)(DateTime.ParseExact(base.lbl_timeremain.Text.ToString(), "mm:ss", null) - time);
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

        private void WriteAnswersToDB(DbConnection conn)
        {

            try
            {
                for (int i = 0; i < this.TestQuestions.QuestionCount; i++)
                {
                    Section question = (Section)this.TestQuestions.Questions[i];

                    DbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert　into　Answers　values(@QuestionNo,@QuestionType,@YourAnswers,@StandardAnswers,@Score);";

                    cmd.Parameters.Add(new SQLiteParameter("QuestionNo", question.AnswerID.ToString()));
                    cmd.Parameters.Add(new SQLiteParameter("QuestionType", question.QuestionType.ToString()));
                    cmd.Parameters.Add(new SQLiteParameter("YourAnswers", question.MyAnswersStr.ToString()));
                    cmd.Parameters.Add(new SQLiteParameter("StandardAnswers", question.CorrectAnswersStr.ToString()));
                    cmd.Parameters.Add(new SQLiteParameter("Score", question.Score.ToString()));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException e)
            {
                //MessageBox.Show(e);   
                MessageBox.Show(e.StackTrace);
            }
        }

        private void WriteAnswersToFile(string fileName)
        {
            //WriteAnswersToDB(this.dbConn);

            FileStream stream = null;
            StreamWriter writer = null;
            try
            {
                stream = new FileStream(string.Concat(new object[] { Application.StartupPath, @"\users\", USERNAME, @"\", this.TPONO, @"\", fileName }), FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(stream);
                writer.Write(string.Format("{0}{1}{2}{3}{4}\r\n", new object[] { "QuestionNo".PadRight(15), "QuestionType".PadRight(15), "YourAnswers".PadRight(15), "StandardAnswers".PadRight(15), "Score".PadRight(15) }));
                for (int i = 0; i < this.TestQuestions.QuestionCount; i++)
                {
                    Section question = (Section)this.TestQuestions.Questions[i];
                    writer.Write(string.Format("{0}{1}{2}{3}{4}\r\n", new object[] { question.AnswerID.ToString().PadRight(15), question.QuestionType.ToString().PadRight(15), question.MyAnswersStr.ToString().PadRight(15), question.CorrectAnswersStr.ToString().PadRight(15), question.Score.ToString().PadRight(15) }));
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
            this.MP3Player.SetPlayTime((long)(this.wtb_speak.Value * 0x3e8));
        }

        private void dgv_readingSelect_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgv_readinganswers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewSelectedRowCollection select = view.SelectedRows;
            int No = select[0].Index + 1;
            //MessageBox.Show("It's " + No);
        }

        private void dgv_readingSelect_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewSelectedRowCollection select = view.SelectedRows;
            if (select.Count == 0)
                return;
            int No = select[0].Index + 1;
            String ID = (String)select[0].Cells[0].Value;
            MessageBox.Show("It's " + No);
        }

        private void tabf_answer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.tabf_answer.SelectedIndex;

        }

        private void notify_prev_Listening_Practical(object sender, EventArgs e)
        {
            this.btn_preQuestion.Enabled = true;
            this.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("ok1");
        }

        #region 模拟在所有情况下点击按钮的行为
        private void btn_Next_Reading_Practical_Click(object sender, EventArgs e)
        {
            this.btn_Next_Reading_Test_Click(sender, e);
        }

        private void btn_Next_Reading_Test_Click(object sender, EventArgs e)
        {
            this.RBtn_nextQuestion(e);
        }

        private void btn_Prev_Reading_Practical_Click(object sender, EventArgs e)
        {
            this.btn_Prev_Reading_Test_Click(sender, e);
        }

        private void btn_Prev_Reading_Test_Click(object sender, EventArgs e)
        {
            if (this.QuestionNO == (this.RSpiltQuestionNO + 1))
            {
                this.PreInsertPosition = -1;
            }
            //this.SaveUserAnswers();
            this.QuestionNO--;
            this.LoadReadingMaterialAndQA();
        }

        private void btn_Next_Listening_Practical_Click(object sender, EventArgs e)
        {
            this.btn_Prev_Listening_Test_Click(sender, e);
        }

        private void btn_Next_Listening_Test_Click(object sender, EventArgs e)
        {
            this.btn_nextQuestion.Enabled = false;  //next disable
            this.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next");
            this.btn_preQuestion.Enabled = true;  //ok enable
            this.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("ok1");
        }

        private void btn_Prev_Listening_Practical_Click(object sender, EventArgs e)
        {
            this.btn_nextQuestion.Enabled = true;  // next enable
            this.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
            this.btn_preQuestion.Enabled = true;  //ok enable
            this.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("ok1");
        }

        private void btn_Prev_Listening_Test_Click(object sender, EventArgs e)
        {
            this.btn_nextQuestion.Enabled = true;  // next enable
            this.btn_nextQuestion.BackgroundImage = (Image)this.resmgr.GetObject("next1");
            this.btn_preQuestion.Enabled = false;  //ok disable
            this.btn_preQuestion.BackgroundImage = (Image)this.resmgr.GetObject("ok");
        }

        private void btn_Next_Speaking_Practical_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Speaking_Test_Click(object sender, EventArgs e)
        {

        }

        private void btn_Prev_Speaking_Practical_Click(object sender, EventArgs e)
        {

        }

        private void btn_Prev_Speaking_Test_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Writing_Practical_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Writing_Test_Click(object sender, EventArgs e)
        {

        }

        private void btn_Prev_Writing_Practical_Click(object sender, EventArgs e)
        {

        }

        private void btn_Prev_Writing_Test_Click(object sender, EventArgs e)
        {

        }
        #endregion 模拟在所有情况下点击按钮的行为
    }
}

