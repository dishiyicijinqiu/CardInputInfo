using CardInputInfo.Core;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CardInputInfo
{
    public partial class MainForm : Form
    {
        int[] piclens = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 18, 20, 32 };
        string piclenstring = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 18, 20, 32";
        public MainForm()
        {
            InitializeComponent();
            mNextClipBoardViewerHWnd = SetClipboardViewer(this.Handle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DelDoCopy = OnCopyText;
        }

        private void btnSetCardNo_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new CardNoForm();
                form.Owner = this;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(this, "确实要退出吗？", "提示", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                e.Cancel = true;
            else
            {
                var ps = System.Diagnostics.Process.GetProcessesByName("winword");
                foreach (var item in ps)
                {
                    item.Kill();
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.tbBatchNo.Text = this.tbSpec.Text = this.tbProductName.Text = string.Empty;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.tbProductName.Text = this.tbSpec.Text = this.tbBatchNo.Text = this.tbQty.Text =
            this.tbTestTime.Text = this.tbCheckQty.Text = this.tbCardNo.Text = this.tbPicPath.Text =
            this.tbExportPath.Text =
                string.Empty;
            this.radioButton1.Checked = true;
        }

        private void OnCopyText(string text)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.tbProductName.Text))
                {
                    this.tbProductName.Text = text;
                }
                else if (string.IsNullOrWhiteSpace(this.tbSpec.Text))
                {
                    this.tbSpec.Text = text;
                }
                else if (string.IsNullOrWhiteSpace(this.tbBatchNo.Text))
                {
                    this.tbBatchNo.Text = text;
                }
            }
            catch (Exception)
            {

            }
        }

        private void tbCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.tbTestTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    #region 验证空
                    if (string.IsNullOrWhiteSpace(this.tbProductName.Text))
                    {
                        MessageBox.Show("产品名称为空");
                        this.tbProductName.Focus();
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.tbSpec.Text))
                    {
                        MessageBox.Show("规格型号为空");
                        this.tbSpec.Focus();
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.tbBatchNo.Text))
                    {
                        MessageBox.Show("生产批号为空");
                        this.tbBatchNo.Focus();
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.tbTestTime.Text))
                    {
                        MessageBox.Show("测量时间为空");
                        this.tbTestTime.Focus();
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.tbPicPath.Text))
                    {
                        MessageBox.Show("图片路径为空");
                        this.tbPicPath.Focus();
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(this.tbCardNo.Text))
                    {
                        MessageBox.Show("卡号为空");
                        this.tbCardNo.Focus();
                        return;
                    }
                    int qty = 0;
                    if (!int.TryParse(this.tbQty.Text, out qty))
                    {
                        MessageBox.Show("生产数量不是有效的数字");
                        this.tbQty.Focus();
                        return;
                    }
                    int checkqty = 0;
                    if (!GetCheckQtyByQty(qty, out checkqty))
                    {
                        MessageBox.Show("抽检数量不是有效的数字");
                        this.tbCheckQty.Focus();
                        return;
                    }
                    #endregion
                    #region 检查图片路径是否存在是否合法
                    if (!Directory.Exists(this.tbPicPath.Text))
                    {
                        MessageBox.Show("图片路径不存在");
                        this.tbPicPath.Focus();
                        return;
                    }
                    var files = Directory.GetFiles(this.tbPicPath.Text, "*.jpg");
                    if (!piclens.Contains(files.Length))
                    {
                        MessageBox.Show(string.Format("图片路径下jpg文件数必须为：{0}", piclenstring));
                        this.tbPicPath.Focus();
                        return;
                    }
                    #endregion
                    #region 检查保存路径是否合法
                    if (!Directory.Exists(this.tbExportPath.Text))
                    {
                        MessageBox.Show("保存路径不存在");
                        this.tbExportPath.Focus();
                    }
                    #endregion
                    #region 检查卡号是否存在
                    var database = DatabaseFactory.CreateDatabase();
                    DbCommand dbCommand = database.GetSqlStringCommand("select * FROM T_UserInfo WHERE CardNo = $CardNo");
                    database.AddInParameter(dbCommand, "$CardNo", DbType.String, this.tbCardNo.Text);
                    var ds = database.ExecuteDataSet(dbCommand);
                    if (ds == null || ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
                    {
                        MessageBox.Show(string.Format("卡号{0}不存在", this.tbCardNo.Text));
                        this.tbCardNo.Text = string.Empty;
                        this.tbCardNo.Focus();
                    }
                    string strUserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                    #endregion
                    int index = this.dgv.Rows.Add();
                    this.dgv.Rows[index].Cells["colProductName"].Value = this.tbProductName.Text;
                    this.dgv.Rows[index].Cells["colSpec"].Value = this.tbSpec.Text;
                    this.dgv.Rows[index].Cells["colBatchNo"].Value = this.tbBatchNo.Text;
                    this.dgv.Rows[index].Cells["colQty"].Value = qty;
                    this.dgv.Rows[index].Cells["colTestTime"].Value = this.tbTestTime.Text;
                    this.dgv.Rows[index].Cells["colCheckQty"].Value = checkqty;
                    this.dgv.Rows[index].Cells["colPicPath"].Value = this.tbPicPath.Text;
                    this.dgv.Rows[index].Cells["colTestResult"].Value = this.radioButton1.Checked ? "合格" : "不合格";
                    this.dgv.Rows[index].Cells["colUserName"].Value = strUserName;
                    this.dgv.Rows[index].Cells["colExportPath"].Value = this.tbExportPath.Text;
                    btnClearAll_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool GetCheckQtyByQty(int qty, out int checkqty)
        {
            checkqty = 0;
            if (qty >= 1 && qty <= 15)
            {
                checkqty = qty;
                return true;
            }
            else if (qty >= 16 && qty <= 25)
            {
                checkqty = 13;
                return true;
            }
            else if (qty >= 26 && qty <= 50)
            {
                checkqty = 15;
                return true;
            }
            else if (qty >= 51 && qty <= 90)
            {
                checkqty = 16;
                return true;
            }
            else if (qty >= 91 && qty <= 150)
            {
                checkqty = 18;
                return true;
            }
            else if (qty >= 151 && qty <= 280)
            {
                checkqty = 20;
                return true;
            }
            else if (qty >= 281 && qty <= 1200)
            {
                checkqty = 32;
                return true;
            }
            else if (qty >= 1201 && qty <= 3200)
            {
                checkqty = 50;
                return true;
            }
            else if (qty >= 3201 && qty <= 10000)
            {
                checkqty = 80;
                return true;
            }
            else if (qty >= 10001 && qty <= 35000)
            {
                checkqty = 125;
                return true;
            }
            else if (qty > 35000)
            {
                checkqty = 200;
                return true;
            }
            return false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                List<Entitys.CheckEntity> list = new List<Entitys.CheckEntity>();
                for (int i = 0; i < this.dgv.Rows.Count; i++)
                {
                    var row = this.dgv.Rows[i];
                    var entity = new Entitys.CheckEntity();
                    entity.BatchNo = (string)row.Cells["colBatchNo"].Value;
                    entity.CheckQty = (int)row.Cells["colCheckQty"].Value;
                    entity.ProductName = (string)row.Cells["colProductName"].Value;
                    entity.Qty = (int)row.Cells["colQty"].Value;
                    entity.Spec = (string)row.Cells["colSpec"].Value;
                    entity.TestResult = (string)row.Cells["colTestResult"].Value;
                    entity.TestTime = (string)row.Cells["colTestTime"].Value;
                    entity.UserName = (string)row.Cells["colUserName"].Value;
                    entity.PicPath = (string)row.Cells["colPicPath"].Value;
                    entity.ExportPath = (string)row.Cells["colExportPath"].Value;
                    list.Add(entity);
                }

                var database = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = database.GetSqlStringCommand("select * from [T_PicSize]");
                var picsizes = database.GetEntitys<Entitys.PicSizeEntity>(dbCommand);
                foreach (var item in list)
                {
                    WordHelper helper = new WordHelper();
                    try
                    {
                        var files = Directory.GetFiles(item.PicPath, "*.jpg");
                        if (!piclens.Contains(files.Length))
                            throw new Exception(string.Format("图片路径下jpg文件数必须为：{0}", piclenstring));
                        var picsize = picsizes.First(t => t.FileCount == files.Length);
                        helper.OpenAndActive(Path.GetFullPath(string.Format("WordTemplates\\{0}张.doc", files.Length)), false, false);
                        helper.ReplaceBookMark("产品名称", item.ProductName);
                        helper.ReplaceBookMark("规格型号", item.Spec);
                        helper.ReplaceBookMark("产品批号", item.BatchNo);
                        helper.ReplaceBookMark("生产数量", item.Qty.ToString());
                        helper.ReplaceBookMark("测量时间", item.TestTime);
                        helper.ReplaceBookMark("抽检数量", item.CheckQty.ToString());
                        helper.ReplaceBookMark("测量结果", item.TestResult);
                        helper.ReplaceBookMark("测量员", item.UserName);
                        foreach (var file in files)
                        {
                            string filename = Path.GetFileNameWithoutExtension(file);
                            var results = filename.Split(new char[] { '-' });
                            string bookmarkname = string.Format("图{0}", results[results.Length - 1]);
                            bool isExist = helper.GoToBookMark(bookmarkname);
                            if (isExist)
                            {
                                helper.InsertPic(file, picsize.Width, picsize.Height);
                                //helper.InsertPic(file);
                                //throw new Exception(string.Format("标签{0}不存在", bookmarkname));
                            }
                        }
                        helper.SaveAs(string.Format("{0}\\{1}", item.ExportPath, item.BatchNo + ".doc"));
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        helper.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DoCopy DelDoCopy;
        #region Definitions
        //Constants for API Calls...
        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x30D;
        //Handle for next clipboard viewer...
        private IntPtr mNextClipBoardViewerHWnd;
        //API declarations...
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern bool ChangeClipboardChain(IntPtr HWnd, IntPtr HWndNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        #endregion
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    {
                        SendMessage(mNextClipBoardViewerHWnd, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());
                        //显示剪贴板中的文本信息
                        if (Clipboard.ContainsText())
                        {
                            string text = Clipboard.GetText();
                            if (DelDoCopy != null)
                            {
                                DelDoCopy(text);
                            }
                        }
                        break;
                    }
                case WM_CHANGECBCHAIN:
                    {
                        //Another clipboard viewer has removed itself...
                        if (m.WParam == (IntPtr)mNextClipBoardViewerHWnd)
                        {
                            mNextClipBoardViewerHWnd = m.LParam;
                        }
                        else
                        {
                            SendMessage(mNextClipBoardViewerHWnd, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());
                        }
                        break;
                    }
            }
            base.WndProc(ref m);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbPicPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private string GetWidthByFileCount(int filelen)
        {
            throw new NotImplementedException();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var rows = this.dgv.SelectedRows;
            int rowcount = rows.Count;
            for (int i = rowcount - 1; i >= 0; i--)
            {
                this.dgv.Rows.Remove(rows[i]);
            }
        }

        private void btnExportPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbExportPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                string filepath = string.Format("{0}\\{1}.doc",
                    this.dgv.Rows[e.RowIndex].Cells["colExportPath"].Value,
                    this.dgv.Rows[e.RowIndex].Cells["colBatchNo"].Value);
                System.Diagnostics.Process.Start(filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSetPicSize_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new PicSizeForm();
                form.Owner = this;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public delegate void DoCopy(string text);
}
