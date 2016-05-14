using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CardInputInfo
{
    [ToolboxItem(true)]
    [Description("是否应用时间样式。")]
    [ProvideProperty("ShowLineNo", typeof(DataGridView))]
    public class DataGridView_ShowLine : Component, IExtenderProvider
    {
        private Dictionary<DataGridView, bool> StyleList = null;
        public DataGridView_ShowLine()
        {
            StyleList = new Dictionary<DataGridView, bool>();
        }

        public DataGridView_ShowLine(IContainer container)
        {
            container.Add(this);
            StyleList = new Dictionary<DataGridView, bool>();
        }


        [Category("扩展")]
        [Description("是否显示行号")]
        public bool GetShowLineNo(DataGridView dgv)
        {
            if (StyleList.ContainsKey(dgv))
            {
                return (bool)StyleList[dgv];
            }
            return false;
        }
        public void SetShowLineNo(DataGridView dgv, bool isApply)
        {
            if (!StyleList.ContainsKey(dgv))
            {
                StyleList.Add(dgv, isApply);
            }
            else
            {
                StyleList[dgv] = isApply;
            }
            dgv.RowPostPaint -= dataGridView1_RowPostPaint;
            if (isApply)
            {
                dgv.RowPostPaint += dataGridView1_RowPostPaint;
            }
        }

        public bool CanExtend(object extendee)
        {
            return (extendee is DataGridView);
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv.RowHeadersDefaultCellStyle.Font, rectangle,
                dgv.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
    }
}
