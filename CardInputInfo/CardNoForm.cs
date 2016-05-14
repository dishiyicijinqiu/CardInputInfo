using CardInputInfo.Entitys;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;
using CardInputInfo.Core;
using System.Data;

namespace CardInputInfo
{
    public partial class CardNoForm : Form
    {
        public CardNoForm()
        {
            InitializeComponent();
        }

        private void CardNoForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgv.AutoGenerateColumns = false;
                var database = DatabaseFactory.CreateDatabase();
                DbCommand dbCommand = database.GetSqlStringCommand("select * from [T_UserInfo]");
                var list = database.GetEntitys<UserInfo>(dbCommand);
                foreach (var item in list)
                {
                    int index = this.dgv.Rows.Add();
                    this.dgv.Rows[index].Cells["colCardNo"].Value = item.CardNo;
                    this.dgv.Rows[index].Cells["colUserName"].Value = item.UserName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<UserInfo> results = new List<UserInfo>();
                for (int i = 0; i < this.dgv.Rows.Count; i++)
                {
                    var row = this.dgv.Rows[i];
                    if (row.IsNewRow) continue;
                    string cardno = (string)row.Cells["colCardNo"].Value;
                    string username = (string)row.Cells["colUserName"].Value;
                    var user = new UserInfo();
                    user.CardNo = cardno ?? string.Empty;
                    user.UserName = username ?? string.Empty;
                    results.Add(user);
                }

                var database = DatabaseFactory.CreateDatabase();
                using (DbConnection connection = database.CreateConnection())
                {
                    connection.Open();
                    DbTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        DbCommand dbCommand = database.GetSqlStringCommand("DELETE FROM T_UserInfo WHERE 1 = 1");
                        database.ExecuteNonQuery(dbCommand, transaction);
                        foreach (var item in results)
                        {
                            dbCommand = database.GetSqlStringCommand("insert into [T_UserInfo] (CardNo,UserName) values ($CardNo,$UserName)");
                            database.AddInParameter(dbCommand, "$CardNo", DbType.String, item.CardNo);
                            database.AddInParameter(dbCommand, "$UserName", DbType.String, item.UserName);
                            database.ExecuteNonQuery(dbCommand, transaction);
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
