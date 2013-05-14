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
    public partial class TabControlSpeaking : UserControl
    {
        TabControl tabf_speaking;

        private TabPage stab_Direction;

        private TabPage stab_NormalQuestions;
        private ProgressBar spb_progress;

        private RichTextBox srtb_introduction;
        private Label srtb_timeindicator;
        private Label srtb_timer;
        private PictureBox spb_speakingScene;
        private PictureBox s_pictureBox1;

        private TableLayoutPanel s_tableLayoutPanel1;

        private EventHandler RtbAnswers_TextChanged;

        public TabControlSpeaking()
        {
            InitializeComponent();
        }
    }
}