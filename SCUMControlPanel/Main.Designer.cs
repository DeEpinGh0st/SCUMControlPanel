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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Setting_groupBox = new System.Windows.Forms.GroupBox();
            this.Setting_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Reload_btn = new System.Windows.Forms.Button();
            this.Export_btn = new System.Windows.Forms.Button();
            this.Import_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Save_FileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Open_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.NameCols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChineseCols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.Setting_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Setting_dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_ToolStripMenuItem,
            this.About_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 25);
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
            this.Setting_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Setting_groupBox.Controls.Add(this.Setting_dataGridView);
            this.Setting_groupBox.Location = new System.Drawing.Point(13, 29);
            this.Setting_groupBox.Name = "Setting_groupBox";
            this.Setting_groupBox.Size = new System.Drawing.Size(642, 583);
            this.Setting_groupBox.TabIndex = 1;
            this.Setting_groupBox.TabStop = false;
            this.Setting_groupBox.Text = "服务器设置";
            // 
            // Setting_dataGridView
            // 
            this.Setting_dataGridView.AllowUserToAddRows = false;
            this.Setting_dataGridView.AllowUserToDeleteRows = false;
            this.Setting_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Setting_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Setting_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCols,
            this.ChineseCols,
            this.ValueCols});
            this.Setting_dataGridView.Location = new System.Drawing.Point(7, 20);
            this.Setting_dataGridView.Name = "Setting_dataGridView";
            this.Setting_dataGridView.RowTemplate.Height = 23;
            this.Setting_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Setting_dataGridView.Size = new System.Drawing.Size(629, 557);
            this.Setting_dataGridView.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Reload_btn);
            this.groupBox2.Controls.Add(this.Export_btn);
            this.groupBox2.Controls.Add(this.Import_btn);
            this.groupBox2.Controls.Add(this.Save_btn);
            this.groupBox2.Location = new System.Drawing.Point(661, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // Reload_btn
            // 
            this.Reload_btn.Location = new System.Drawing.Point(25, 140);
            this.Reload_btn.Name = "Reload_btn";
            this.Reload_btn.Size = new System.Drawing.Size(75, 23);
            this.Reload_btn.TabIndex = 3;
            this.Reload_btn.Text = "重载";
            this.Reload_btn.UseVisualStyleBackColor = true;
            this.Reload_btn.Click += new System.EventHandler(this.Reload_btn_Click);
            // 
            // Export_btn
            // 
            this.Export_btn.Location = new System.Drawing.Point(25, 102);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(75, 23);
            this.Export_btn.TabIndex = 2;
            this.Export_btn.Text = "导出";
            this.Export_btn.UseVisualStyleBackColor = true;
            this.Export_btn.Click += new System.EventHandler(this.Export_btn_Click);
            // 
            // Import_btn
            // 
            this.Import_btn.Location = new System.Drawing.Point(25, 64);
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
            // Save_FileDialog
            // 
            this.Save_FileDialog.Filter = "配置文件|*.ini";
            // 
            // Open_FileDialog
            // 
            this.Open_FileDialog.Filter = "配置文件|*.ini";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 624);
            this.Controls.Add(this.groupBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.Setting_dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
    }
}

