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
    public partial class TabControlWriting : UserControl
    {
        TabControl tabf_writing;

        private PictureBox w_pictureBox1;
        private Button wbtn_cut;
        private Button wbtn_paste;
        private Button wbtn_redo;
        private Button wbtn_undo;
        private Button wbtn_wordcount;
        private TabPage wtab_Direction;
        private Label wlbl_wordcount;
        private Panel w_panel;
        private ProgressBar wpb_speak;
        private TabPage wtab_Reading;
        private RichTextBox wrtb_reading;
        private RichTextBox wrtb_writing1;
        private RichTextBox wrtb_writing2;
        private RichTextBox wrtb_Question2;
        private TabPage wtab_SpeakingPassage;
        private TrackBar wtb_speak;
        private TabPage wtab_Writing2;
        private PictureBox wpb_writingScene;
        private Label wlbl_writeDirection;
        
        public TabControlWriting()
        {
            InitializeComponent();
        }
    }
}
