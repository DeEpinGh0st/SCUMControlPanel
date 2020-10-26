using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SCUMControlPanel
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private static string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private static readonly string ServerSettingPath = string.Format("{0}{1}", ApplicationData, @"\SCUM\Saved\Config\WindowsNoEditor\ServerSettings.ini");
        private static string TranslateFilePath = string.Format("{0}{1}", Application.StartupPath, @"\Chinese.txt");
        private static string DisplayPrefix;
        List<string> Sections;
        Dictionary<string, string> TranslateKeys = new Dictionary<string, string>();

        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ServerSettingPath))
            {
                MessageBox.Show("配置文件不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(TranslateFilePath))
            {
                MessageBox.Show("注释文件不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DisplayPrefix = Setting_groupBox.Text;
            OperateIniFile.SetFilePath(ServerSettingPath);
            ParameterizedThreadStart readsetting_child = new ParameterizedThreadStart(ReadSetting);
            Thread readsetting_thread = new Thread(readsetting_child);
            readsetting_thread.Start(OperateIniFile.GetFilePath());
            ThreadStart loadtranslate_child = new ThreadStart(LoadTranslateFile);
            Thread loadtranslate_thread = new Thread(loadtranslate_child);
            loadtranslate_thread.Start();
        }

        delegate void ReadSettingCallBack(object f_path);
        private void ReadSetting(object f_path)
        {
            if (Setting_dataGridView.InvokeRequired)
            {
                ReadSettingCallBack rscb = new ReadSettingCallBack(ReadSetting);
                Invoke(rscb, new object[] { f_path });
            }
            else
            {
                try
                {
                    int index;
                    Setting_groupBox.Text = String.Format("{0} - {1}", DisplayPrefix, f_path);
                    Sections = OperateIniFile.ReadSections();
                    foreach (var section in Sections)
                    {
                        index = Setting_dataGridView.Rows.Add();
                        Setting_dataGridView.Rows[index].Cells[0].Value = section;
                        Setting_dataGridView.Rows[index].ReadOnly = true;
                        Setting_dataGridView.Rows[index].DefaultCellStyle.BackColor = Color.BurlyWood;
                        Setting_dataGridView.Rows[index].Cells[1].Value = TranslateKeys[section];
                        List<string> Keys = OperateIniFile.ReadKeys(section);
                        foreach (var key in Keys)
                        {
                            index = Setting_dataGridView.Rows.Add();
                            Setting_dataGridView.Rows[index].Cells[0].Value = key;
                            string Value = Convert.ToString(OperateIniFile.ReadIniData(section, key, ""));
                            Setting_dataGridView.Rows[index].Cells[1].Value = TranslateKeys[key];
                            Setting_dataGridView.Rows[index].Cells[2].Value = Value;
                        }

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        delegate void LoadTranslateFileCallBack();

        private void LoadTranslateFile()
        {
            try
            {
                StreamReader sR = new StreamReader(TranslateFilePath, Encoding.UTF8);
                string nextLine;
                while ((nextLine = sR.ReadLine()) != null)
                {
                    string C_key = nextLine.Split('=')[0];
                    string C_Value = nextLine.Split('=')[1];
                    TranslateKeys.Add(C_key, C_Value);
                }
                sR.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Reload_btn_Click(object sender, EventArgs e)
        {
            TranslateKeys.Clear();
            Setting_dataGridView.Rows.Clear();
            ParameterizedThreadStart readsetting_child = new ParameterizedThreadStart(ReadSetting);
            Thread readsetting_thread = new Thread(readsetting_child);
            readsetting_thread.Start(OperateIniFile.GetFilePath());
            ThreadStart loadtranslate_child = new ThreadStart(LoadTranslateFile);
            Thread loadtranslate_thread = new Thread(loadtranslate_child);
            loadtranslate_thread.Start();
        }

        delegate void SaveFileCallBack();
        private void SaveFile()
        {
            if (Setting_dataGridView.InvokeRequired)
            {
                SaveFileCallBack rscb = new SaveFileCallBack(SaveFile);
                Invoke(rscb, new object[] { });
            }
            else
            {
                try
                {
                    string section, key, value;
                    section = Setting_dataGridView.Rows[0].Cells[0].Value.ToString();
                    for (int i = 0; i < Setting_dataGridView.Rows.Count - Sections.Count; i++)
                    {
                        if (Sections.Contains(Setting_dataGridView.Rows[i].Cells[0].Value.ToString()))
                        {
                            section = Setting_dataGridView.Rows[i].Cells[0].Value.ToString();
                        }
                        if (Sections.Contains(Setting_dataGridView.Rows[i + 1].Cells[0].Value.ToString()))
                        {
                            key = Setting_dataGridView.Rows[i].Cells[0].Value.ToString();
                            value = Setting_dataGridView.Rows[i].Cells[2].Value.ToString();
                        }
                        else
                        {
                            key = Setting_dataGridView.Rows[i + 1].Cells[0].Value.ToString();
                            value = Setting_dataGridView.Rows[i + 1].Cells[2].Value.ToString();
                        }
                        if (OperateIniFile.WriteIniData(section, key, value)) { }
                    }
                    MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            ThreadStart savefile_child = new ThreadStart(SaveFile);
            Thread savefile_thread = new Thread(savefile_child);
            savefile_thread.Start();
        }

        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = Save_FileDialog.ShowDialog();
            string filename = Save_FileDialog.FileName;
            OperateIniFile.SetFilePath(filename);
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                SaveFile();
                Setting_groupBox.Text = string.Format("{0} - {1}", DisplayPrefix, filename);
            }
            return;
        }

        private void Import_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = Open_FileDialog.ShowDialog();
            string filename = Open_FileDialog.FileName;
            if (dr == DialogResult.OK && File.Exists(filename))
            {
                OperateIniFile.SetFilePath(filename);
                Setting_dataGridView.Rows.Clear();
                ReadSetting(filename);
                Setting_groupBox.Text = string.Format("{0} - {1}", DisplayPrefix, filename);
            }
            return;
        }

        private void Open_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = Open_FileDialog.ShowDialog();
            string filename = Open_FileDialog.FileName;
            if (dr == DialogResult.OK && File.Exists(filename))
            {
                OperateIniFile.SetFilePath(filename);
                Setting_dataGridView.Rows.Clear();
                ReadSetting(filename);
                Setting_groupBox.Text = string.Format("{0} - {1}", DisplayPrefix, filename);
            }
            return;
        }
    }
}
