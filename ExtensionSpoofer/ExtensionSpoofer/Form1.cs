using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExtensionSpoofer
{
    public partial class Form1 : Form
    {
        string itemSelected = "";
        string[] spoofExtensionList = { "png", "mp3", "mp4","pdf", "word", "txt", "xls" };
        string reverseChar = "\u202e";
        char dot = '.';

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbb_SpoofExtension.Items.AddRange(spoofExtensionList);
            cbb_SpoofExtension.SelectedIndex = 0;
        }

        private void OpenTargetFile_Click(object sender, EventArgs e)
        {
            string fileFullPath = "";
            string fileName = "";
            string filePath = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.AutoUpgradeEnabled = false;
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileFullPath = openFileDialog.FileName; //경로와 파일명
                    fileName = openFileDialog.SafeFileName; //파일명
                    filePath = fileFullPath.Replace(fileName, ""); //경로
                    txtBox_TargetPath.Text = filePath;
                    txtBox_TargetName.Text = fileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbb_SpoofExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_SpoofExtension.SelectedIndex >= 0)
            {
                this.itemSelected = cbb_SpoofExtension.SelectedItem as string;
            }
        }

        private void RunSpoofExtension_Click(object sender, EventArgs e)
        {
            string originalFile;
            string spoofFile;
            FileStream readStream;
            FileStream writeStream;

            char dot = '.';
            string filePath = txtBox_TargetPath.Text;
            string fileExtension = Path.GetExtension(txtBox_TargetName.Text);
            string fileName = txtBox_TargetName.Text.Replace(fileExtension, "");

            string reverseFileExtension = "";
            string reverseSpoofFileExtension = "";

            fileExtension = fileExtension.Replace(".", "");

            //reverseFileExtension = new String(fileExtension.ToCharArray().Reverse().ToArray());
            reverseSpoofFileExtension = new String(itemSelected.ToCharArray().Reverse().ToArray());

            originalFile = txtBox_TargetPath.Text + txtBox_TargetName.Text;
            //spoofFile = filePath + fileName + reverseChar + reverseSpoofFileExtension + dot + fileExtension;

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "CMD.exe";
            startInfo.WorkingDirectory = @"C:\";

            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            process.EnableRaisingEvents = false;
            process.StartInfo = startInfo;
            process.Start();    //프로세스 시작
            
            process.StandardInput.Write("copy "+originalFile+" "+ filePath + fileName + "\u202e" + reverseSpoofFileExtension + dot + fileExtension + Environment.NewLine);     //예를 들어 dir명령어를 입력
            process.StandardInput.Close();

            string result = process.StandardOutput.ReadToEnd();                     //실행결과를 standard output으로 받아와 string값에 저장
            string error = process.StandardError.ReadToEnd();                        //오류유무를 standard output으로 받아와 string값에 저장
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("[ Result Info ]\r\n");                                                  //출력
            sb.Append(result);
            sb.Append("\r\n");
            sb.Append("[ Error Info ]\r\n");
            sb.Append(error);

            MessageBox.Show(sb.ToString());

            process.WaitForExit();
            process.Close();

        }
    }
}