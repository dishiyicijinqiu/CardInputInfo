using CardInputInfo.Entitys;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardInputInfo.Core;

namespace CardInputInfo
{
    public partial class PicSizeForm : Form
    {
        public PicSizeForm()
        {
            InitializeComponent();
            this.dgv.AutoGenerateColumns = false;
            var database = DatabaseFactory.CreateDatabase();
            DbCommand dbCommand = database.GetSqlStringCommand("select * from [T_PicSize]");
            this.dgv.DataSource = database.GetEntitys<PicSizeEntity>(dbCommand);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<PicSizeEntity> results = this.dgv.DataSource as List<PicSizeEntity>;
                var database = DatabaseFactory.CreateDatabase();
                using (DbConnection connection = database.CreateConnection())
                {
                    connection.Open();
                    DbTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        DbCommand dbCommand = database.GetSqlStringCommand("DELETE FROM T_PicSize WHERE 1 = 1");
                        database.ExecuteNonQuery(dbCommand, transaction);
                        foreach (var item in results)
                        {
                            dbCommand = database.GetSqlStringCommand("insert into [T_PicSize] (FileCount,Width,Height) values ($FileCount,$Width,$Height)");
                            database.AddInParameter(dbCommand, "$FileCount", DbType.Int32, item.FileCount);
                            database.AddInParameter(dbCommand, "$Width", DbType.Decimal, item.Width);
                            database.AddInParameter(dbCommand, "$Height", DbType.Decimal, item.Height);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
