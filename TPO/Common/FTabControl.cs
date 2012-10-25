namespace TPO.Common
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class FTabControl : TabControl
    {
        private static Color BackColor = Color.FromArgb(0xe3, 0xed, 0xfb);
        private static Color BorderColor = Color.Black;
        private static Color ButtonColor;
        private static Color ButtonHighlightColor;
        private Container components = null;
        public bool UserChangeTab = true;

        public FTabControl()
        {
            this.InitializeComponent();
            this.SetDafaultStyle();
            base.SetStyle(ControlStyles.UserPaint, true);
        }

        protected void DrawItem(Graphics g, int index)
        {
            Rectangle tabRect = base.GetTabRect(index);
            tabRect.Inflate(-2, -2);
            if (base.SelectedIndex == index)
            {
                g.FillRectangle(new SolidBrush(ButtonHighlightColor), tabRect);
            }
            else
            {
                g.FillRectangle(new SolidBrush(ButtonColor), tabRect);
            }
            g.DrawRectangle(new Pen(new SolidBrush(BorderColor)), tabRect);
            tabRect.Inflate(-3, -3);
            g.DrawString(base.TabPages[index].Text, this.Font, new SolidBrush(BorderColor), tabRect);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if ((!e.Control || (e.KeyCode != Keys.Tab)) || this.UserChangeTab)
            {
                base.OnKeyDown(e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(BackColor), e.ClipRectangle);
            for (int i = 0; i < base.TabCount; i++)
            {
                this.DrawItem(e.Graphics, i);
            }
        }

        public void SetDafaultStyle()
        {
            base.Appearance = TabAppearance.FlatButtons;
            ButtonColor = Color.FromArgb(0xb8, 210, 250);
            ButtonHighlightColor = Color.FromArgb(0x90, 0xbb, 0xfc);
        }

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg != 0x201) || this.UserChangeTab)
            {
                base.WndProc(ref m);
            }
        }
    }
}

