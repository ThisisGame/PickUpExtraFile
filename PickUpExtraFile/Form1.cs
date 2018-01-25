using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickUpExtraFile
{
    public partial class Form1 : Form
    {
        private string mStandradDirectory = string.Empty;
        private string mCurrentDirectory = string.Empty;


        public Form1()
        {
            InitializeComponent();
        }

        private void mButtonStandard_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "选择作为标准的文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }

                mStandradDirectory = dialog.SelectedPath;
                mLabelStandard.Text = mStandradDirectory;
            }
        }

        private void mButtonCurrent_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "选择作为当前使用的文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }

                mCurrentDirectory = dialog.SelectedPath;
                mLabelCurrent.Text = mCurrentDirectory;
            }
        }

        private void mButtonCompare_Click(object sender, EventArgs e)
        {
            string[] tmpStandardDirectoryFilePathArray = System.IO.Directory.GetFiles(mStandradDirectory, "*.*",System.IO.SearchOption.AllDirectories);
            string[] tmpCurrentDirectoryFilePathArray = System.IO.Directory.GetFiles(mCurrentDirectory, "*.*", System.IO.SearchOption.AllDirectories);

            using (System.IO.StreamWriter tmpStreamWrite = new System.IO.StreamWriter(Application.StartupPath+"/Extra.txt",false))
            {
                //对当前文件夹进行遍历，在标准文件夹进行寻找同名文件，如果找不到就提取出来
                for (int tmpCurrentFilePathIndex = 0; tmpCurrentFilePathIndex < tmpCurrentDirectoryFilePathArray.Length; tmpCurrentFilePathIndex++)
                {
                    string tmpCurrentFilePath = tmpCurrentDirectoryFilePathArray[tmpCurrentFilePathIndex];

                    int tmpLastPatternIndex = tmpCurrentFilePath.LastIndexOf('\\');
                    string tmpCurrentFileName = tmpCurrentFilePath.Substring(tmpLastPatternIndex+1, tmpCurrentFilePath.Length - tmpLastPatternIndex-1);

                    bool tmpFind = false;
                    for (int tmpStandardFilePathIndex = 0; tmpStandardFilePathIndex < tmpStandardDirectoryFilePathArray.Length; tmpStandardFilePathIndex++)
                    {
                        string tmpStandradFilePath = tmpStandardDirectoryFilePathArray[tmpStandardFilePathIndex];
                        if (tmpStandradFilePath.EndsWith(tmpCurrentFileName))
                        {
                            tmpFind = true;
                            break;
                        }
                    }

                    if(tmpFind==false)
                    {
                        tmpStreamWrite.WriteLine(tmpCurrentFilePath);
                        tmpStreamWrite.Flush();
                    }
                }
            }

            MessageBox.Show("对比完毕，查看Extra.txt");
        }
    }
}
