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
    public partial class TabControlCoverForm : UserControl
    {
        private EventHandler tpo_and_part_selected;
        
        public TabControlCoverForm()
        {
            InitializeComponent();
        }

        private void tpo_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Part_NO = e.ColumnIndex;
            int TPO_NO = e.RowIndex;
            tpo_and_part_selected(sender, e);
        }

        /// <summary>
        /// 设置点击网格的消息钩子
        /// </summary>
        /// <param name="e">调用一个外部消息响应函数</param>
        public void SetSelectedEvent(EventHandler e)
        {
            this.tpo_and_part_selected = e;
        }
    }
}
