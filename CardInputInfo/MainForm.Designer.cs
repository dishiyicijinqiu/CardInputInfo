namespace CardInputInfo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPicPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExportPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExportPath = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbExportPath = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPicPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCheckQty = new System.Windows.Forms.TextBox();
            this.tbTestTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.tbBatchNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSetCardNo = new System.Windows.Forms.ToolStripButton();
            this.btnClearCopy = new System.Windows.Forms.ToolStripButton();
            this.btnClearAll = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView_ShowLine1 = new CardInputInfo.DataGridView_ShowLine(this.components);
            this.btnSetPicSize = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colSpec,
            this.colBatchNo,
            this.colQty,
            this.colTestTime,
            this.colCheckQty,
            this.colTestResult,
            this.colUserName,
            this.colPicPath,
            this.colExportPath,
            this.colWidth,
            this.colHeight});
            this.dgv.Location = new System.Drawing.Point(0, 188);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ShowLine1.SetShowLineNo(this.dgv, true);
            this.dgv.Size = new System.Drawing.Size(1075, 360);
            this.dgv.TabIndex = 16;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "产品名称";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colSpec
            // 
            this.colSpec.HeaderText = "规格型号";
            this.colSpec.Name = "colSpec";
            this.colSpec.ReadOnly = true;
            // 
            // colBatchNo
            // 
            this.colBatchNo.HeaderText = "产品批号";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "生产数量";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colTestTime
            // 
            this.colTestTime.HeaderText = "测量时间";
            this.colTestTime.Name = "colTestTime";
            this.colTestTime.ReadOnly = true;
            // 
            // colCheckQty
            // 
            this.colCheckQty.HeaderText = "抽检数量";
            this.colCheckQty.Name = "colCheckQty";
            this.colCheckQty.ReadOnly = true;
            // 
            // colTestResult
            // 
            this.colTestResult.HeaderText = "测量结果";
            this.colTestResult.Name = "colTestResult";
            this.colTestResult.ReadOnly = true;
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "测量员";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colPicPath
            // 
            this.colPicPath.HeaderText = "图片路径";
            this.colPicPath.Name = "colPicPath";
            this.colPicPath.ReadOnly = true;
            // 
            // colExportPath
            // 
            this.colExportPath.HeaderText = "保存路径";
            this.colExportPath.Name = "colExportPath";
            this.colExportPath.ReadOnly = true;
            // 
            // colWidth
            // 
            this.colWidth.HeaderText = "图片宽度";
            this.colWidth.Name = "colWidth";
            this.colWidth.ReadOnly = true;
            // 
            // colHeight
            // 
            this.colHeight.HeaderText = "图片高度";
            this.colHeight.Name = "colHeight";
            this.colHeight.ReadOnly = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnExportPath);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label10);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbExportPath);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.radioButton2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.radioButton1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnOpen);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label9);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbPicPath);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label5);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label6);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbCardNo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label7);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label8);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbCheckQty);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbTestTime);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbQty);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbBatchNo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbSpec);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbProductName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgv);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1075, 548);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1075, 595);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1075, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnExportPath
            // 
            this.btnExportPath.Location = new System.Drawing.Point(872, 132);
            this.btnExportPath.Name = "btnExportPath";
            this.btnExportPath.Size = new System.Drawing.Size(38, 23);
            this.btnExportPath.TabIndex = 24;
            this.btnExportPath.Text = "..";
            this.btnExportPath.UseVisualStyleBackColor = true;
            this.btnExportPath.Click += new System.EventHandler(this.btnExportPath_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "导出路径";
            // 
            // tbExportPath
            // 
            this.tbExportPath.Location = new System.Drawing.Point(73, 134);
            this.tbExportPath.Name = "tbExportPath";
            this.tbExportPath.Size = new System.Drawing.Size(837, 21);
            this.tbExportPath.TabIndex = 22;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(208, 163);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.Text = "不合格";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(88, 163);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "合格";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(872, 101);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(38, 23);
            this.btnOpen.TabIndex = 19;
            this.btnOpen.Text = "..";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "图片路径";
            // 
            // tbPicPath
            // 
            this.tbPicPath.Location = new System.Drawing.Point(73, 103);
            this.tbPicPath.Name = "tbPicPath";
            this.tbPicPath.Size = new System.Drawing.Size(837, 21);
            this.tbPicPath.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "请在此刷卡";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "测量结果";
            // 
            // tbCardNo
            // 
            this.tbCardNo.Location = new System.Drawing.Point(553, 161);
            this.tbCardNo.Name = "tbCardNo";
            this.tbCardNo.Size = new System.Drawing.Size(357, 21);
            this.tbCardNo.TabIndex = 4;
            this.tbCardNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCardNo_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "抽检数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "测量时间";
            // 
            // tbCheckQty
            // 
            this.tbCheckQty.Location = new System.Drawing.Point(553, 69);
            this.tbCheckQty.Name = "tbCheckQty";
            this.tbCheckQty.ReadOnly = true;
            this.tbCheckQty.Size = new System.Drawing.Size(357, 21);
            this.tbCheckQty.TabIndex = 6;
            // 
            // tbTestTime
            // 
            this.tbTestTime.Location = new System.Drawing.Point(75, 69);
            this.tbTestTime.Name = "tbTestTime";
            this.tbTestTime.ReadOnly = true;
            this.tbTestTime.Size = new System.Drawing.Size(399, 21);
            this.tbTestTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "生产数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "产品批号";
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(553, 42);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(357, 21);
            this.tbQty.TabIndex = 3;
            // 
            // tbBatchNo
            // 
            this.tbBatchNo.Location = new System.Drawing.Point(75, 42);
            this.tbBatchNo.Name = "tbBatchNo";
            this.tbBatchNo.Size = new System.Drawing.Size(399, 21);
            this.tbBatchNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "规格型号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "产品名称";
            // 
            // tbSpec
            // 
            this.tbSpec.Location = new System.Drawing.Point(553, 15);
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.Size = new System.Drawing.Size(357, 21);
            this.tbSpec.TabIndex = 1;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(75, 15);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(399, 21);
            this.tbProductName.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetCardNo,
            this.btnClearCopy,
            this.btnClearAll,
            this.btnExport,
            this.btnDel,
            this.btnSetPicSize});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(472, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnSetCardNo
            // 
            this.btnSetCardNo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSetCardNo.Image = ((System.Drawing.Image)(resources.GetObject("btnSetCardNo.Image")));
            this.btnSetCardNo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetCardNo.Name = "btnSetCardNo";
            this.btnSetCardNo.Size = new System.Drawing.Size(60, 22);
            this.btnSetCardNo.Text = "设置卡号";
            this.btnSetCardNo.Click += new System.EventHandler(this.btnSetCardNo_Click);
            // 
            // btnClearCopy
            // 
            this.btnClearCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClearCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCopy.Image")));
            this.btnClearCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearCopy.Name = "btnClearCopy";
            this.btnClearCopy.Size = new System.Drawing.Size(96, 22);
            this.btnClearCopy.Text = "清空前三个数据";
            this.btnClearCopy.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAll.Image")));
            this.btnClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(84, 22);
            this.btnClearAll.Text = "清空所有数据";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(69, 22);
            this.btnExport.Text = "导出Word";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(36, 22);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSetPicSize
            // 
            this.btnSetPicSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSetPicSize.Image = ((System.Drawing.Image)(resources.GetObject("btnSetPicSize.Image")));
            this.btnSetPicSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetPicSize.Name = "btnSetPicSize";
            this.btnSetPicSize.Size = new System.Drawing.Size(84, 22);
            this.btnSetPicSize.Text = "设置图片大小";
            this.btnSetPicSize.Click += new System.EventHandler(this.btnSetPicSize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 595);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private DataGridView_ShowLine dataGridView_ShowLine1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSetCardNo;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCardNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCheckQty;
        private System.Windows.Forms.TextBox tbTestTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.TextBox tbBatchNo;
        private System.Windows.Forms.ToolStripButton btnClearCopy;
        private System.Windows.Forms.ToolStripButton btnClearAll;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPicPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnExportPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbExportPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPicPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExportPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeight;
        private System.Windows.Forms.ToolStripButton btnSetPicSize;
    }
}

