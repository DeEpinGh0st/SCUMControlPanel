namespace SCUMControlPanel
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Msg_textBox = new System.Windows.Forms.TextBox();
            this.Source_linkLabel = new System.Windows.Forms.LinkLabel();
            this.Ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msg_textBox
            // 
            this.Msg_textBox.Location = new System.Drawing.Point(12, 12);
            this.Msg_textBox.Multiline = true;
            this.Msg_textBox.Name = "Msg_textBox";
            this.Msg_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Msg_textBox.Size = new System.Drawing.Size(289, 150);
            this.Msg_textBox.TabIndex = 2;
            // 
            // Source_linkLabel
            // 
            this.Source_linkLabel.AutoSize = true;
            this.Source_linkLabel.Location = new System.Drawing.Point(127, 174);
            this.Source_linkLabel.Name = "Source_linkLabel";
            this.Source_linkLabel.Size = new System.Drawing.Size(41, 12);
            this.Source_linkLabel.TabIndex = 1;
            this.Source_linkLabel.TabStop = true;
            this.Source_linkLabel.Text = "源代码";
            this.Source_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Source_linkLabel_LinkClicked);
            // 
            // Ok_button
            // 
            this.Ok_button.Location = new System.Drawing.Point(110, 198);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(75, 23);
            this.Ok_button.TabIndex = 0;
            this.Ok_button.Text = "确定";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 247);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.Source_linkLabel);
            this.Controls.Add(this.Msg_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(330, 286);
            this.MinimumSize = new System.Drawing.Size(330, 286);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Msg_textBox;
        private System.Windows.Forms.LinkLabel Source_linkLabel;
        private System.Windows.Forms.Button Ok_button;
    }
}