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
    using TPO.UI;
    using System.Data.Common;
    using System.Data.SQLite;
    using System.Resources;
    using System.Reflection;

    public class MainForm : TestBaseForm
    {
        #region default UI interface
        private ImageList bgimagelist;
        
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
       
        
        private Button[] BtnLoadTest;
        
        private CheckBox ckb_ShowAnswer;
        
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
        
        
        private ExplanationUI EXP;
        public static string EXPLANATION = "";
        private Timer flash_timer;
        
        
        public bool HasClickedNext;
        private bool HasLoadMP3;
        private int IBTScore;
        private string InsertSetenceRtf;
        public static bool ISACTIVED = false;
        private bool IsPassageMP3;
        public bool IsPause;
        private bool IsQuestionAfter;
        private bool IsRepeated;
        
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
                    
        private static int LDIRECTION1 = 0;
        private static int LDIRECTION2 = 1;
        private static int LISTENING = 2;     
        private static int LMATERIALS = 2;     
        private static int LMATERIALS1 = 3;     
        public bool LOADLASTQUESTION;
        private static int LQUESTIONS = 4; 
        private static int LTABLEQUESTION = 5;
        
        private MP3MCI MP3Player;
        private MP3Record MP3Recorder;
        private int NotAnsweredQuestions;
        private OpenFileDialog openMp3File;
        
        private int PartCount;
        private int PartLastPassageIndex;
        private int PartNO;
        private int PassageCount;
        private int PassageLastQuestionIndex;
        private int PassageNO;
               
        
        
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
        
        
        private RichTextBox rtb_Passage;
        
        
        private RichTextBox RtbPreviousSelected;
        private RichTextBox[] RtbReadingAnswers;
        private RichTextBox[] RtbSumAnswersToBeSelected;
        private RichTextBox[] RtbSumSelected;
        
        private static int SDIRECTION = 0;
        private bool ShowPassage;
        
        private static int SPEAKING = 3;
        private string[] SpeakingQuestions;
        private string[] SPicturePaths;
        private string[] SPictureTimeLines;
        private static int SQUESTION = 1;
        private string[] SReadingMaterials;
        
        private int SummarySelectedAnswerIndex;
        private int[] SummarySelectedAnswers;
        private TabPage tab_CoverForm;
        private TabPage tab_Listening;     
        private TabPage tab_Reading;       
        private TabPage tab_Speaking;       
        private TabPage tab_Writing;
        private TabPage tab_Answers;
        private TabControl tabf_answer;
        private TabControl tabf_Listening;     
        private TabControl tabf_speaking;
        private TabControl tabf_test;
        private TabControl tabf_tposelection;
        private TabControl tabf_writing;
        
        
        
        
        
        
        private int TestMode;
        private TPOTest TestQuestions;
        private TestingSection TestSection;
        private DateTime TimeLimitation;
        private Timer Timer_Listening;
        private Timer Timer_reading;
        private Timer Timer_Speaking;
        private int TotalQuestions;
        private int TotalScore;
        private TabPage TPO10;
        private int TPONO;
        public static string TRANSLATION = "";
        private TranslationUI TRANSUI;
        private static int USERANSWERS = 5;
        public static string USERNAME = "";
       
        private static int WDIRECTION = 0;
        private static int WINDEPENDENT = 3;
        private static int WINTERGRATED = 1;
        
        private static int WRITING = 4;
        private string[] WritingQuestions;
        private int WrongAnsweredQuestions;
       
        private static int WSPEECH = 2;
        
        
        
        #endregion
        

        private DbConnection dbConn;
        
        private DataGridViewCheckBoxColumn isAnsweredDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn rightAnswersStrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userAnswersStrDataGridViewTextBoxColumn;
        private TPO.SQLite.SQLiteDB sqlite = new SQLite.SQLiteDB();
        private ResourceManager resmgr = new ResourceManager("Properties.Resources", Assembly.GetExecutingAssembly());

        #region event
        private event EventHandler OnClickNextButton;
        private event EventHandler OnClickPrevButton;
        #endregion event

        #region my module
        //private TabControlReading tabf_Reading;
        #endregion my module

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

            /// 主窗体控件初始化
            InitializeComponent();

            this.PreFormHeight = base.Height;
            this.PreFormWidth = base.Width;
            base.WindowState = FormWindowState.Maximized;
            
            

            for (num = 0; num < 8; num++)
            {
                this.RtbReadingAnswers[num].TextChanged += new EventHandler(this.RtbAnswers_TextChanged);
                this.CkbReading[num].CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
                this.LCkbAnswers[num].CheckedChanged += new EventHandler(this.Ckb_CheckedChanged);
            }

            

            for (num = 0; num < 9; num++)
            {
                this.LCkbTable[num] = new CheckBox[5];
                for (int i = 0; i < 5; i++)
                {
                    this.LCkbTable[num][i] = new CheckBox();
                }
            }
            
            
            
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
                    //this.rbtn_readText.Enabled = false;
                    //this.rbtn_stopReading.Visible = true;
                    this.rtb_reading.Visible = true;
                    this.rtb_reading.Maximum = this.MP3Player.Duration;
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
                        //this.rlbl_scoreReport.Visible = false;
                        break;
                    }
                    //this.rlbl_scoreReport.Visible = true;
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
                TPOSection question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
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
                this.ltb_currentpos1.Visible = false;
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

        private void LoadTest_DataGrid_Click(object sender, EventArgs e)
        {
            DataGridViewCellEventArgs datagrid_e;
            
            try
            {
                datagrid_e = (DataGridViewCellEventArgs)e;
            }
            catch(InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            int TPO_NO = datagrid_e.RowIndex;
            int TPO_Part = datagrid_e.ColumnIndex;
            
        }

        private void btn_LoadTest_Click(object sender, EventArgs e)
        {
            
            
            //this.artb_writinganswers.Text = "";
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
                        this.RMaterial = new TPOPassage(RTFReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\" + this.PassageNO.ToString() + ".txt").Substring(0xb5), RTFReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\P" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
                        if (!File.Exists(@"Explanations\" + this.TPONO.ToString() + @"\Reading\" + this.ReadingPassageNo.ToString() + ".mp3") || !ConstantValues.TPOEXPLANATION[this.TPONO])
                        {
                            //this.rbtn_readText.Visible = false;
                        }
                        //this.rbtn_readText.Visible = true;
                        //this.rbtn_readText.Enabled = true;
                        this.TestQuestions.AddPart(new TPOPart(RTFReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\questions" + this.PassageNO.ToString() + ".txt").Substring(0xb5), "", RTFReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\Q" + this.PassageNO.ToString() + ".txt").Substring(0xb5)));
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
                            this.TestQuestions.AddPart(new TPOPart(RTFReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Listening\questions.rtf"), @"Tests\" + this.TPONO.ToString() + @"\Listening\questions.xml", ""));
                        }
                        string str4 = reader.GetAttr("//part[@NO=" + this.PartNO + "]/@partDirection");
                        try
                        {
                            this.MP3Player = new MP3MCI();
                            string str5 = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Listening\", str4 });
                            this.MP3Player.FileName = str5;
                            this.l_PlayFileName.Text = str5;
                            this.lpb_currentpos.Maximum = this.MP3Player.Duration;
                            this.lpb_currentpos1.Maximum = this.MP3Player.Duration;
                            this.ltb_currentpos.Maximum = this.MP3Player.Duration;
                            this.ltb_currentpos1.Maximum = this.MP3Player.Duration;
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
                //this.rrtb_question.Text = "";
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
                //this.rlbl_scoreReport.Text = this.scoreReport(1);
            }
            else
            {
                //this.rlbl_scoreReport.Text = this.scoreReport(3);
            }
            this.tabf_test.SelectedIndex = READING;
            this.tabf_Reading.SelectedIndex = RREVIEW;
            if (this.rb_PracticeMode.Checked)
            {
                //this.rlbl_wrongAnswered.Visible = true;
                //this.rpb_wrongAnswered.Visible = true;
                //this.rlbl_rightAnswered.Visible = true;
                //this.rpb_rightAnswered.Visible = true;
            }
            else
            {
                //this.rlbl_wrongAnswered.Visible = false;
                //this.rpb_wrongAnswered.Visible = false;
                //this.rlbl_rightAnswered.Visible = false;
                //this.rpb_rightAnswered.Visible = false;
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
                    TPOSection question = (TPOSection)this.TestQuestions.Questions[i];
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
                //this.rdgv_readingReview.DataSource = table;
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
            //this.rrtb_sumQuestion.Visible = !this.ShowPassage;
            //this.rrtb_sumPassage.Visible = this.ShowPassage;
            this.rtlp_sumAnswers.Visible = !this.ShowPassage;
            this.rtlp_Summary.Visible = !this.ShowPassage;
            if (this.ShowPassage)
            {
                this.tabf_test.SelectedIndex = READING;
                this.tabf_Reading.SelectedIndex = RSUMMARYQUESTION;
                this.btn_ShowText.BackgroundImage = (Image)this.resmgr.GetObject("viewquestion");
            }
            else
            {
                this.btn_ShowText.BackgroundImage = (Image)this.resmgr.GetObject("viewtext");
                TPOSection question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
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
            //this.rbtn_readText.Enabled = true;
            //this.rbtn_stopReading.Visible = false;
            this.rtb_reading.Visible = false;
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
            TPOSection question;
            int num;
            CheckBox ckb = (CheckBox)sender;
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    if (!ckb.Checked)
                    {
                        return;
                    }
                    question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
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
                        question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
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
                TPOSection question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
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
                        this.llbl_tableAnswer.Visible = true;
                        this.llbl_tableAnswer.Text = question.CorrectAnswersStr;
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
                this.llbl_tableAnswer.Visible = false;
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
                            this.llbl_tableAnswer.Visible = true;
                            this.llbl_tableAnswer.Text = question.CorrectAnswersStr;
                            return;

                        case QuestionType.SORT:
                            if (!this.ckb_ShowAnswer.Checked)
                            {
                                break;
                            }
                            this.rlbl_rightAnswer.Text = question.CorrectAnswersStr;
                            this.rlbl_rightAnswer.Visible = true;
                            return;

                        default:
                            goto Label_0242;
                    }
                    this.rlbl_rightAnswer.Visible = false;
                }
                return;
            Label_0233:
                this.llbl_tableAnswer.Visible = false;
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
            if ((this.rdgv_readingReview.SelectedRows != null) && (this.rdgv_readingReview.SelectedRows.Count > 0))
            {
                this.ReviewSelectedQuestionNO = Convert.ToInt16(this.rdgv_readingReview.SelectedRows[0].Cells["QuestionID"].Value);
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
            this.rdgv_readingReview.ClearSelection();
            this.ReviewSelectedQuestionNO = -1;
        }

        private void dgv_readingReview_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.rdgv_readingReview.Rows.Count; i++)
            {
                DataGridViewRow row = this.rdgv_readingReview.Rows[i];
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
            TPOSection question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
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
            
            this.tabf_Reading = new TPO.UI.TabControlReading();
          
            this.tab_Listening = new System.Windows.Forms.TabPage();
            
            this.tab_Speaking = new System.Windows.Forms.TabPage();           
            this.tab_Writing = new System.Windows.Forms.TabPage();
            this.tabf_writing = new System.Windows.Forms.TabControl();         
            this.tab_Answers = new System.Windows.Forms.TabPage();
            this.tabf_answer = new System.Windows.Forms.TabControl();
            

            //this.bindingSource_Set = new System.Windows.Forms.BindingSource(this.components);
            //this.bindingSource_Section = new System.Windows.Forms.BindingSource(this.components);

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
            //this.tabf_Reading.SuspendLayout();
            
            
            
            
            //this.rtlp_answers.SuspendLayout();
           
            
            
            this.tab_Speaking.SuspendLayout();
            //this.tabf_speaking.SuspendLayout();
           
            this.tab_Writing.SuspendLayout();
            this.tabf_writing.SuspendLayout();
            
            this.tab_Answers.SuspendLayout();
            this.tabf_answer.SuspendLayout();
            
            
            
            this.SuspendLayout();
            // 
            // btn_continue
            // 
            this.btn_continue.BackgroundImage = TPO.Properties.Resources._continue;
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
            this.btn_mainmenu.BackgroundImage = global::TPO.Properties.Resources.mainmenu;
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
            this.btn_nextQuestion.BackgroundImage = global::TPO.Properties.Resources.next;
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
            this.btn_preQuestion.BackgroundImage = global::TPO.Properties.Resources.back;
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
            this.btn_quit.BackgroundImage = global::TPO.Properties.Resources.exit;
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
            this.btn_review.BackgroundImage = global::TPO.Properties.Resources.review;
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
            this.button1.BackgroundImage = global::TPO.Properties.Resources.hidetimer;
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
            this.Sound_icon.BackgroundImage = global::TPO.Properties.Resources.volumn;
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
            
            //Too dirty
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
            //this.tab_Reading.Controls.Add(this.tabf_Reading);
            this.tab_Reading.Location = new System.Drawing.Point(4, 22);
            this.tab_Reading.Name = "tab_Reading";
            this.tab_Reading.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Reading.Size = new System.Drawing.Size(780, 484);
            this.tab_Reading.TabIndex = 0;
            this.tab_Reading.Text = "Reading";
            this.tab_Reading.UseVisualStyleBackColor = true;
            
            
            // 
            // tab_Listening
            // 
            //this.tab_Listening.Controls.Add(this.tabf_Listening);
            this.tab_Listening.Location = new System.Drawing.Point(4, 22);
            this.tab_Listening.Name = "tab_Listening";
            this.tab_Listening.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Listening.Size = new System.Drawing.Size(780, 484);
            this.tab_Listening.TabIndex = 1;
            this.tab_Listening.Text = "Listening";
            this.tab_Listening.UseVisualStyleBackColor = true;
            
            
            // 
            // tab_Speaking
            // 
            //this.tab_Speaking.Controls.Add(this.tabf_speaking);
            this.tab_Speaking.Location = new System.Drawing.Point(4, 22);
            this.tab_Speaking.Name = "tab_Speaking";
            this.tab_Speaking.Size = new System.Drawing.Size(780, 484);
            this.tab_Speaking.TabIndex = 2;
            this.tab_Speaking.Text = "Speaking";
            this.tab_Speaking.UseVisualStyleBackColor = true;
            
            // 
            // tab_Writing
            // 
            //this.tab_Writing.Controls.Add(this.tabf_writing);
            this.tab_Writing.Location = new System.Drawing.Point(4, 22);
            this.tab_Writing.Name = "tab_Writing";
            this.tab_Writing.Size = new System.Drawing.Size(780, 484);
            this.tab_Writing.TabIndex = 3;
            this.tab_Writing.Text = "Writing";
            this.tab_Writing.UseVisualStyleBackColor = true;
            
            // 
            // tab_Answers
            // 
            //this.tab_Answers.Controls.Add(this.tabf_answer);
            this.tab_Answers.Location = new System.Drawing.Point(4, 22);
            this.tab_Answers.Name = "tab_Answers";
            this.tab_Answers.Size = new System.Drawing.Size(780, 484);
            this.tab_Answers.TabIndex = 5;
            this.tab_Answers.Text = "Answers";
            this.tab_Answers.UseVisualStyleBackColor = true;
            
            
            
            // 
            // btn_ShowText
            // 
            this.btn_ShowText.BackgroundImage = global::TPO.Properties.Resources.viewtext;
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
            this.btn_pause.BackgroundImage = global::TPO.Properties.Resources.pause;
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
            this.btn_QUITapp.BackgroundImage = global::TPO.Properties.Resources.exit1;
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
            this.btn_showexplanation.BackgroundImage = global::TPO.Properties.Resources.EXPLANATION;
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
            this.btn_showtranslation.BackgroundImage = global::TPO.Properties.Resources.TRANSLATION;
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
            this.BackgroundImage = global::TPO.Properties.Resources.bg1;
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
            //this.tabf_Reading.ResumeLayout(false);
                   
            this.tab_Listening.ResumeLayout(false);
            //this.tabf_Listening.ResumeLayout(false);
            
            this.tab_Speaking.ResumeLayout(false);
            //this.tabf_speaking.ResumeLayout(false);
            
            
            this.tab_Writing.ResumeLayout(false);
            this.tabf_writing.ResumeLayout(false);
            
            this.tab_Answers.ResumeLayout(false);
            
     
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
            this.rtb_reading.Visible = false;
            this.rbtn_readText.Visible = false;
            this.rbtn_stopReading.Visible = false;
            this.Timer_Listening.Stop();
            this.flash_timer.Stop();
            this.Timer_Speaking.Stop();
            this.btn_pause.BackgroundImage = (Image)this.resmgr.GetObject("pause");
            this.btn_pause.Visible = false;
            this.rlbl_rightAnswer.Visible = false;
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
            this.lpb_ListenScene.Image = null;
            this.lpb_ListenScene1.Image = null;
            if (this.PassageNO <= 1)
            {
                this.TestQuestions = new TPOPart(RTFReader.getRTF(@"Tests\" + this.TPONO + @"\Listening\questions.rtf"), @"Tests\" + this.TPONO + @"\Listening\questions.xml", "");
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
                this.l_PlayFileName.Text = str2;
                this.lpb_currentpos.Maximum = this.MP3Player.Duration;
                this.lpb_currentpos1.Maximum = this.MP3Player.Duration;
                this.ltb_currentpos.Maximum = this.MP3Player.Duration;
                this.ltb_currentpos1.Maximum = this.MP3Player.Duration;
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
            TPOSection question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
            base.lbl_questionNO.Text = "Question " + this.QuestionNO + " of 34";
            this.rlbl_rightAnswer.Visible = this.ckb_ShowAnswer.Checked;
            this.IsPassageMP3 = false;
            switch (question.QuestionType)
            {
                case QuestionType.TABLE:
                    {
                        int num5;
                        this.tabf_test.SelectedIndex = LISTENING;
                        this.tabf_Listening.SelectedIndex = LTABLEQUESTION;
                        this.lrtb_TableQuestion.Rtf = question.QuestionTitle;
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
                            this.llbl_tableAnswer.Visible = true;
                            this.llbl_tableAnswer.Text = question.CorrectAnswersStr;
                        }
                        else
                        {
                            this.llbl_tableAnswer.Visible = false;
                        }
                        goto Label_0656;
                    }
                case QuestionType.SORT:
                    if (question.QuestionType == QuestionType.SORT)
                    {
                        this.tabf_test.SelectedIndex = READING;
                        this.tabf_Reading.SelectedIndex = RSUMMARYQUESTION;
                        this.rrtb_sumQuestion.Rtf = question.QuestionTitle;
                        this.rrtb_sumQuestion.Visible = true;
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
            this.rlbl_rightAnswer.Text = question.CorrectAnswersStr;
        Label_0656:
            try
            {
                this.MP3Player = new MP3MCI();
                string str = "";
                str = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Listening\", question.MP3Path });
                this.MP3Player.FileName = str;
                this.l_PlayFileName.Text = str;
                this.lpb_currentpos.Maximum = this.MP3Player.Duration;
                this.lpb_currentpos1.Maximum = this.MP3Player.Duration;
                this.ltb_currentpos.Maximum = this.MP3Player.Duration;
                this.ltb_currentpos1.Maximum = this.MP3Player.Duration;
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
            this.lflp_passage.Controls.Clear();
            while (index < 0x20)
            {
                labelArray[index] = new LinkLabel();
                labelArray[index].AutoSize = true;
                labelArray[index].Font = this.llnk_passage.Font;
                labelArray[index].LinkBehavior = this.llnk_passage.LinkBehavior;
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
                        this.lflp_passage.Controls.Add(labelArray[index]);
                        break;
                    }
                    if ((num4 == 0x1f) || lrc.sText.Trim().Equals(""))
                    {
                        this.lflp_passage.Controls.Add(labelArray[index]);
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
                TPOSection question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
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
                    this.rrtb_sumPassage.Height = 500;
                    this.rrtb_sumQuestion.Visible = !this.ShowPassage;
                    this.rrtb_sumPassage.Visible = this.ShowPassage;
                    this.rtlp_answers.Visible = !this.ShowPassage;
                    this.rtlp_Summary.Visible = !this.ShowPassage;
                    this.rrtb_sumQuestion.Rtf = question.QuestionTitle;
                    this.rrtb_sumPassage.Rtf = this.RMaterial.ReadingPassageONQuestion(this.QuestionNO, this.RSpiltQuestionNO);
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
                    this.rrtb_sumPassage.Height = 500;
                    this.rrtb_sumQuestion.Visible = !this.ShowPassage;
                    this.rrtb_sumPassage.Visible = this.ShowPassage;
                    this.rtlp_answers.Visible = !this.ShowPassage;
                    this.rtlp_Summary.Visible = !this.ShowPassage;
                    this.rrtb_sumPassage.Rtf = this.RMaterial.ReadingPassageONQuestion(this.QuestionNO, this.RSpiltQuestionNO);
                    TRANSLATION = this.RMaterial.Translation;
                    this.lrtb_TableQuestion.Rtf = question.QuestionTitle;
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
                        this.llbl_tableAnswer.Visible = true;
                        this.llbl_tableAnswer.Text = question.CorrectAnswersStr;
                    }
                    else
                    {
                        this.llbl_tableAnswer.Visible = false;
                    }
                }
                else
                {
                    this.rrtb_question.Rtf = question.QuestionTitle;
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
                        int index = this.rrtb_question.Text.IndexOf(str);
                        int num8 = this.rrtb_question.Text.IndexOf(str2);
                        if (index >= 0)
                        {
                            this.rrtb_question.SelectionStart = index;
                            this.rrtb_question.SelectionLength = str.Length;
                            this.rrtb_question.SelectedText = "\n";
                        }
                        if (num8 >= 0)
                        {
                            this.rrtb_question.SelectionStart = (num8 - str.Length) + 1;
                            this.rrtb_question.SelectionLength = str2.Length;
                            this.rrtb_question.SelectedText = "\n";
                        }
                        this.rrtb_question.SelectionStart = index + 1;
                        this.rrtb_question.SelectionLength = ((num8 - index) - str.Length) - 1;
                        this.InsertSetenceRtf = this.rrtb_question.SelectedRtf;
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
            string str = RTFReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Speaking\questions.rtf");
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
            str = RTFReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Speaking\reading.rtf");
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
                        TPOSection question = (TPOSection)this.TestQuestions.Questions[num - 2];
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
            string str = RTFReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Writing\questions.rtf");
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
                        this.RMaterial = new TPOPassage(RTFReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\" + this.PassageNO.ToString() + ".txt").Substring(0xb5), RTFReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\P" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
                        if (File.Exists(@"Explanations\" + this.TPONO.ToString() + @"\Reading\" + this.ReadingPassageNo.ToString() + ".mp3") && ConstantValues.TPOEXPLANATION[this.TPONO])
                        {
                            this.rbtn_readText.Visible = true;
                            this.rbtn_readText.Enabled = true;
                        }
                        else
                        {
                            this.rbtn_readText.Visible = false;
                        }
                        this.TestQuestions = new TPOPart(RTFReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\questions" + this.PassageNO.ToString() + ".txt").Substring(0xb5), "", RTFReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\Q" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
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
            this.adgv_readinganswers.DataSource = table;
            XMLReader reader2 = new XMLReader(@"Tests\Direction\Scoring.xml");
            num7 = int.Parse(reader2.GetAttr("//ScoreSections//Section[@NO=1]//Score[@TestScore='" + num4 + "']//@IBTScore"));
            string str9 = string.Concat(new object[] { "Your score is (total score): ", num4, "         Your standard score is (in 30 scores): ", num7, "\nRight answered: ", num2, "      Wrong answered: ", num3, "      Not answered: ", num6 });
            this.albl_readingscorereport.Text = str9;
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
            this.albl_listeningScorereport.Text = str9;
            this.adgv_listeninganswers.DataSource = table2;
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
                        this.artb_writinganswers.Text = str2;
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
                TPOSection question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
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
                TPOSection question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
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
                if (this.artb_writing1.Checked)
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
                    this.artb_writinganswers.Text = reader.ReadToEnd();
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
            TPOSection question;
            int num;
            int count;
            bool flag;
            int num3;
            switch (this.TestSection)
            {
                case TestingSection.READING:
                    if (this.QuestionNO > 0)
                    {
                        question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
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
                        question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
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
            TPOSection question = null;
            XMLReader reader = new XMLReader(@"Tests\Direction\Scoring.xml");
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            for (int i = 0; i < this.TestQuestions.Questions.Count; i++)
            {
                question = (TPOSection)this.TestQuestions.Questions[i];
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
                this.abtn_speakinganswer1.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.abtn_speakinganswer1.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
            }
            if (File.Exists(str + @"\SpeakingAnswer2.wav"))
            {
                this.abtn_speakinganswer2.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.abtn_speakinganswer2.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
            }
            if (File.Exists(str + @"\SpeakingAnswer3.wav"))
            {
                this.abtn_speakinganswer3.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.abtn_speakinganswer3.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
            }
            if (File.Exists(str + @"\SpeakingAnswer4.wav"))
            {
                this.abtn_speakinganswer4.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.abtn_speakinganswer4.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
            }
            if (File.Exists(str + @"\SpeakingAnswer5.wav"))
            {
                this.abtn_speakinganswer5.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.abtn_speakinganswer5.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
            }
            if (File.Exists(str + @"\SpeakingAnswer6.wav"))
            {
                this.abtn_speakinganswer6.BackgroundImage = (Image)this.resmgr.GetObject("horn");
            }
            else
            {
                this.abtn_speakinganswer6.BackgroundImage = (Image)this.resmgr.GetObject("horn1");
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
            this.MP3Player.SetPlayTime((long)(this.ltb_currentpos.Value * 0x3e8));
        }

        private void tb_currentpos1_Scroll(object sender, EventArgs e)
        {
            this.MP3Player.SetPlayTime((long)(this.ltb_currentpos1.Value * 0x3e8));
        }

        private void tb_reading_Scroll(object sender, EventArgs e)
        {
            this.MP3Player.SetPlayTime((long)(this.rtb_reading.Value * 0x3e8));
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
            this.ltb_currentpos.Value = currentPosition;
            this.lpb_currentpos.Value = currentPosition;
            this.ltb_currentpos1.Value = currentPosition;
            this.lpb_currentpos1.Value = currentPosition;
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
                        this.RMaterial = new TPOPassage(RTFReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\" + this.PassageNO.ToString() + ".txt").Substring(0xb5), RTFReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\P" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
                        if (File.Exists(@"Explanations\" + this.TPONO.ToString() + @"\Reading\" + this.ReadingPassageNo.ToString() + ".mp3") && ConstantValues.TPOEXPLANATION[this.TPONO])
                        {
                            this.rbtn_readText.Visible = true;
                            this.rbtn_readText.Enabled = true;
                        }
                        else
                        {
                            this.rbtn_readText.Visible = false;
                        }
                        this.TestQuestions = new TPOPart(RTFReader.getRTF(@"Tests\" + this.TPONO.ToString() + @"\Reading\questions" + this.PassageNO.ToString() + ".txt").Substring(0xb5), "", RTFReader.getRTF(@"Explanations\" + this.TPONO.ToString() + @"\Reading\Q" + this.PassageNO.ToString() + ".txt").Substring(0xb5));
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
                        this.lpb_ListenScene.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[0]);
                        this.lpb_ListenScene1.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[0]);
                    }
                    else
                    {
                        for (num4 = 1; num4 < length; num4++)
                        {
                            DateTime time3 = DateTime.ParseExact(this.SPictureTimeLines[num4 - 1], "mm:ss", null);
                            DateTime time4 = DateTime.ParseExact(this.SPictureTimeLines[num4], "mm:ss", null);
                            if ((time3 <= time2) && (time2 <= time4))
                            {
                                this.lpb_ListenScene.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[num4 - 1]);
                                this.lpb_ListenScene1.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[num4 - 1]);
                            }
                        }
                        DateTime time5 = DateTime.ParseExact(this.SPictureTimeLines[length - 1], "mm:ss", null);
                        if (time2 > time5)
                        {
                            this.lpb_ListenScene.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[length - 1]);
                            this.lpb_ListenScene1.Load(Application.StartupPath + @"\Tests\images\" + this.SPicturePaths[length - 1]);
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
                        TPOSection question = (TPOSection)this.TestQuestions.Questions[this.QuestionNO - 1];
                        switch (question.QuestionType)
                        {
                            case QuestionType.TABLE:
                                if (!this.ckb_ShowAnswer.Checked)
                                {
                                    this.llbl_tableAnswer.Visible = false;
                                    break;
                                }
                                this.llbl_tableAnswer.Visible = true;
                                this.llbl_tableAnswer.Text = question.CorrectAnswersStr;
                                break;

                            case QuestionType.SORT:
                                if (question.QuestionType == QuestionType.SORT)
                                {
                                    this.rrtb_sumQuestion.Rtf = question.QuestionTitle;
                                    this.rrtb_sumQuestion.Visible = true;
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
            this.rtb_reading.Value = this.MP3Player.CurrentPosition;
            if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
            {
                this.rbtn_readText.Enabled = true;
                this.rbtn_readText.Enabled = true;
                this.rbtn_stopReading.Visible = false;
                this.rtb_reading.Visible = false;
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
                                    this.wpb_writingScene.Load(Application.StartupPath + @"\Tests\images\WaitPerson.jpg");
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
                                this.wrtb_Question2.Rtf = this.WritingQuestions[0];
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
                                    this.wpb_writingScene.Load(Application.StartupPath + @"\Tests\images\write" + this.TPONO.ToString() + ".jpg");
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
                                this.wrtb_Question2.Rtf = this.WritingQuestions[0];
                                this.wrtb_writing2.ReadOnly = false;
                                this.wlbl_writeDirection.Text = "Directions: You have 20 minutes to plan and write your response. Your response will be judged on the basis of the quality of your writing and on how well your response presents in the lecture and their relationship to the reading passage. Typically, an effective response will be 150 to 225 words.\n Question: Summarize the points made in the lecture, being sure to explain how they cast doubt on specific points made in the reading passage.";
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
                                this.wlbl_writeDirection.Text = "Directions: Read the question below. You have 30 minutes to plan, write, and revise your essay. Typically, an effective response will contain a minimum of 300 words.";
                                this.wrtb_writing2.Text = "";
                                this.wrtb_writing2.ReadOnly = false;
                                this.wrtb_Question2.Rtf = this.WritingQuestions[1];
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
                                this.spb_progress.Visible = false;
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
                                    this.spb_speakingScene.Load(Application.StartupPath + @"\Tests\images\WaitPerson.jpg");
                                    base.lbl_questionNO.Text = "Question " + this.QuestionNO + " of 6";
                                    this.tabf_test.SelectedIndex = SPEAKING;
                                    this.tabf_speaking.SelectedIndex = SQUESTION;
                                    this.spb_speakingScene.Visible = true;
                                    this.srtb_introduction.Visible = false;
                                    this.MP3Player = new MP3MCI();
                                    str = string.Concat(new object[] { @"Tests\", this.TPONO, @"\Speaking\", attr });
                                    this.MP3Player.FileName = str;
                                    this.MP3Player.play();
                                    this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                    this.srtb_timeindicator.Visible = false;
                                    this.srtb_timer.Visible = false;
                                    this.spb_progress.Visible = false;
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
                                this.spb_speakingScene.Visible = false;
                                base.lbl_timeremain.Text = "00:45";
                                this.srtb_timeindicator.Text = "READING TIME";
                                this.srtb_introduction.Rtf = this.SReadingMaterials[this.QuestionNO - 3];
                                this.srtb_timer.Text = "00:" + base.lbl_timeremain.Text;
                                this.srtb_introduction.Visible = true;
                                this.srtb_timeindicator.Visible = true;
                                this.srtb_timer.Visible = true;
                                this.spb_progress.Visible = false;
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
                            this.spb_speakingScene.Visible = false;
                            base.lbl_timeremain.Text = "00:45";
                            this.srtb_timeindicator.Text = "READING TIME";
                            this.srtb_timer.Text = "00:" + base.lbl_timeremain.Text;
                            this.srtb_timeindicator.Visible = true;
                            this.srtb_timer.Visible = true;
                            this.spb_progress.Visible = false;
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
                                this.spb_progress.Maximum = this.MP3Player.Duration;
                                if (this.QuestionNO > 2)
                                {
                                    this.spb_progress.Visible = true;
                                }
                                else
                                {
                                    this.spb_progress.Visible = false;
                                }
                                this.srtb_introduction.Rtf = this.SpeakingQuestions[this.QuestionNO - 1];
                                if ((this.QuestionNO == 1) || (this.QuestionNO == 2))
                                {
                                    this.srtb_introduction.Visible = true;
                                    this.spb_speakingScene.Visible = false;
                                }
                                else
                                {
                                    this.srtb_introduction.Visible = false;
                                    this.spb_speakingScene.Load(string.Concat(new object[] { Application.StartupPath, @"\Tests\images\speak", this.QuestionNO, ".jpg" }));
                                    this.srtb_timeindicator.Visible = false;
                                    this.srtb_timer.Visible = false;
                                    this.spb_speakingScene.Visible = true;
                                }
                                this.HasLoadMP3 = true;
                            }
                            catch
                            {
                                MessageBox.Show("open" + str + "出错!");
                            }
                        }
                        this.spb_progress.Value = this.MP3Player.CurrentPosition;
                        if (this.MP3Player.CurrentPosition >= this.MP3Player.Duration)
                        {
                            if ((this.QuestionNO == 1) || (this.QuestionNO == 2))
                            {
                                this.CurrentSpeakingStep = 6;
                                this.spb_progress.Visible = false;
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
                                this.spb_progress.Visible = false;
                                this.MP3Player.FileName = str;
                                this.MP3Player.play();
                                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                this.srtb_introduction.Rtf = this.SpeakingQuestions[this.QuestionNO - 1];
                                this.srtb_introduction.Visible = true;
                                this.spb_speakingScene.Visible = false;
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
                                this.spb_progress.Visible = false;
                                this.MP3Player.FileName = str;
                                this.MP3Player.play();
                                this.MP3Player.SetVolume(base.tb_sound.Value.ToString());
                                this.srtb_introduction.Visible = true;
                                this.spb_speakingScene.Visible = false;
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
                            this.spb_speakingScene.Visible = false;
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
                                this.spb_speakingScene.Visible = false;
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
                            this.spb_speakingScene.Visible = false;
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
                            this.spb_speakingScene.Visible = true;
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
                    TPOSection question = (TPOSection)this.TestQuestions.Questions[i];

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
                    TPOSection question = (TPOSection)this.TestQuestions.Questions[i];
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

