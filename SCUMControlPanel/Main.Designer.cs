namespace SCUMControlPanel
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Setting_groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Reload_btn = new System.Windows.Forms.Button();
            this.Export_btn = new System.Windows.Forms.Button();
            this.Import_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Setting_dataGridView = new System.Windows.Forms.DataGridView();
            this.NameCols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChineseCols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save_FileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Open_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyPropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCHS_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeepLlinkLabel = new System.Windows.Forms.LinkLabel();
            this.BaidulinkLabel = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.Setting_groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Setting_dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_ToolStripMenuItem,
            this.About_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Open_ToolStripMenuItem
            // 
            this.Open_ToolStripMenuItem.Name = "Open_ToolStripMenuItem";
            this.Open_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.Open_ToolStripMenuItem.Text = "打开";
            this.Open_ToolStripMenuItem.Click += new System.EventHandler(this.Open_ToolStripMenuItem_Click);
            // 
            // About_ToolStripMenuItem
            // 
            this.About_ToolStripMenuItem.Name = "About_ToolStripMenuItem";
            this.About_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.About_ToolStripMenuItem.Text = "关于";
            this.About_ToolStripMenuItem.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // Setting_groupBox
            // 
            this.Setting_groupBox.Controls.Add(this.groupBox1);
            this.Setting_groupBox.Controls.Add(this.groupBox2);
            this.Setting_groupBox.Controls.Add(this.Setting_dataGridView);
            this.Setting_groupBox.Location = new System.Drawing.Point(13, 29);
            this.Setting_groupBox.Name = "Setting_groupBox";
            this.Setting_groupBox.Size = new System.Drawing.Size(850, 678);
            this.Setting_groupBox.TabIndex = 1;
            this.Setting_groupBox.TabStop = false;
            this.Setting_groupBox.Text = "服务器设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OpenCHS_Btn);
            this.groupBox2.Controls.Add(this.Reload_btn);
            this.groupBox2.Controls.Add(this.Export_btn);
            this.groupBox2.Controls.Add(this.Import_btn);
            this.groupBox2.Controls.Add(this.Save_btn);
            this.groupBox2.Location = new System.Drawing.Point(724, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // Reload_btn
            // 
            this.Reload_btn.Location = new System.Drawing.Point(25, 143);
            this.Reload_btn.Name = "Reload_btn";
            this.Reload_btn.Size = new System.Drawing.Size(75, 23);
            this.Reload_btn.TabIndex = 3;
            this.Reload_btn.Text = "重载";
            this.Reload_btn.UseVisualStyleBackColor = true;
            this.Reload_btn.Click += new System.EventHandler(this.Reload_btn_Click);
            // 
            // Export_btn
            // 
            this.Export_btn.Location = new System.Drawing.Point(25, 104);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(75, 23);
            this.Export_btn.TabIndex = 2;
            this.Export_btn.Text = "导出";
            this.Export_btn.UseVisualStyleBackColor = true;
            this.Export_btn.Click += new System.EventHandler(this.Export_btn_Click);
            // 
            // Import_btn
            // 
            this.Import_btn.Location = new System.Drawing.Point(25, 65);
            this.Import_btn.Name = "Import_btn";
            this.Import_btn.Size = new System.Drawing.Size(75, 23);
            this.Import_btn.TabIndex = 1;
            this.Import_btn.Text = "导入";
            this.Import_btn.UseVisualStyleBackColor = true;
            this.Import_btn.Click += new System.EventHandler(this.Import_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(25, 26);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 0;
            this.Save_btn.Text = "保存";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Setting_dataGridView
            // 
            this.Setting_dataGridView.AllowUserToAddRows = false;
            this.Setting_dataGridView.AllowUserToDeleteRows = false;
            this.Setting_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Setting_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCols,
            this.ChineseCols,
            this.ValueCols});
            this.Setting_dataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.Setting_dataGridView.Location = new System.Drawing.Point(7, 20);
            this.Setting_dataGridView.Name = "Setting_dataGridView";
            this.Setting_dataGridView.RowTemplate.Height = 23;
            this.Setting_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Setting_dataGridView.Size = new System.Drawing.Size(711, 652);
            this.Setting_dataGridView.TabIndex = 4;
            // 
            // NameCols
            // 
            this.NameCols.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCols.HeaderText = "配置项";
            this.NameCols.Name = "NameCols";
            this.NameCols.ReadOnly = true;
            this.NameCols.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ChineseCols
            // 
            this.ChineseCols.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChineseCols.HeaderText = "注释";
            this.ChineseCols.Name = "ChineseCols";
            this.ChineseCols.ReadOnly = true;
            this.ChineseCols.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ValueCols
            // 
            this.ValueCols.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ValueCols.HeaderText = "值";
            this.ValueCols.Name = "ValueCols";
            this.ValueCols.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ValueCols.Width = 23;
            // 
            // Save_FileDialog
            // 
            this.Save_FileDialog.Filter = "配置文件|*.ini";
            // 
            // Open_FileDialog
            // 
            this.Open_FileDialog.Filter = "配置文件|*.ini";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyPropToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(161, 26);
            // 
            // CopyPropToolStripMenuItem
            // 
            this.CopyPropToolStripMenuItem.Name = "CopyPropToolStripMenuItem";
            this.CopyPropToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.CopyPropToolStripMenuItem.Text = "复制配置项名称";
            this.CopyPropToolStripMenuItem.Click += new System.EventHandler(this.CopyPropToolStripMenuItem_Click);
            // 
            // OpenCHS_Btn
            // 
            this.OpenCHS_Btn.Location = new System.Drawing.Point(25, 182);
            this.OpenCHS_Btn.Name = "OpenCHS_Btn";
            this.OpenCHS_Btn.Size = new System.Drawing.Size(75, 23);
            this.OpenCHS_Btn.TabIndex = 4;
            this.OpenCHS_Btn.Text = "查看注释";
            this.OpenCHS_Btn.UseVisualStyleBackColor = true;
            this.OpenCHS_Btn.Click += new System.EventHandler(this.OpenCHS_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BaidulinkLabel);
            this.groupBox1.Controls.Add(this.DeepLlinkLabel);
            this.groupBox1.Location = new System.Drawing.Point(725, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "翻译站点";
            // 
            // DeepLlinkLabel
            // 
            this.DeepLlinkLabel.AutoSize = true;
            this.DeepLlinkLabel.Location = new System.Drawing.Point(27, 41);
            this.DeepLlinkLabel.Name = "DeepLlinkLabel";
            this.DeepLlinkLabel.Size = new System.Drawing.Size(71, 12);
            this.DeepLlinkLabel.TabIndex = 0;
            this.DeepLlinkLabel.TabStop = true;
            this.DeepLlinkLabel.Text = "DeepL(推荐)";
            this.DeepLlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeepLlinkLabel_LinkClicked);
            // 
            // BaidulinkLabel
            // 
            this.BaidulinkLabel.AutoSize = true;
            this.BaidulinkLabel.Location = new System.Drawing.Point(27, 77);
            this.BaidulinkLabel.Name = "BaidulinkLabel";
            this.BaidulinkLabel.Size = new System.Drawing.Size(53, 12);
            this.BaidulinkLabel.TabIndex = 0;
            this.BaidulinkLabel.TabStop = true;
            this.BaidulinkLabel.Text = "百度翻译";
            this.BaidulinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BaidulinkLabel_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 735);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Setting_groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCUM Control Panel";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Setting_groupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Setting_dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Open_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_ToolStripMenuItem;
        private System.Windows.Forms.GroupBox Setting_groupBox;
        private System.Windows.Forms.DataGridView Setting_dataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Reload_btn;
        private System.Windows.Forms.Button Export_btn;
        private System.Windows.Forms.Button Import_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.SaveFileDialog Save_FileDialog;
        private System.Windows.Forms.OpenFileDialog Open_FileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCols;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChineseCols;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueCols;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyPropToolStripMenuItem;
        private System.Windows.Forms.Button OpenCHS_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel BaidulinkLabel;
        private System.Windows.Forms.LinkLabel DeepLlinkLabel;
    }
}

