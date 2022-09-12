using System;
using System.Windows.Forms;

namespace SCUMControlPanel
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        string message = "《SCUM单机服务器设置面板》\r\n\r\n有些翻译可能不准确,可修改目录下Chinese.txt文件自定义\r\n\r\n基于0.7版本测试\r\n\r\n作者:S0cke3t\r\n"
            + "\r\n获取源代码请点击下方\"源代码\"链接\r\n";
        private void About_Load(object sender, EventArgs e)
        {
            Msg_textBox.Text = message;
            Msg_textBox.ReadOnly = true;
            Ok_button.Focus();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Source_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DeEpinGh0st/ScumControlPanel");
        }
    }
}
