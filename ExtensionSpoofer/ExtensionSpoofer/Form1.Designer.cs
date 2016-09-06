namespace ExtensionSpoofer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenTargetFile = new System.Windows.Forms.Button();
            this.txtBox_TargetPath = new System.Windows.Forms.TextBox();
            this.cbb_SpoofExtension = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RunSpoofExtension = new System.Windows.Forms.Button();
            this.txtBox_TargetName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpenTargetFile
            // 
            this.OpenTargetFile.Location = new System.Drawing.Point(308, 12);
            this.OpenTargetFile.Name = "OpenTargetFile";
            this.OpenTargetFile.Size = new System.Drawing.Size(75, 23);
            this.OpenTargetFile.TabIndex = 0;
            this.OpenTargetFile.Text = "파일열기";
            this.OpenTargetFile.UseVisualStyleBackColor = true;
            this.OpenTargetFile.Click += new System.EventHandler(this.OpenTargetFile_Click);
            // 
            // txtBox_TargetPath
            // 
            this.txtBox_TargetPath.Location = new System.Drawing.Point(12, 14);
            this.txtBox_TargetPath.Name = "txtBox_TargetPath";
            this.txtBox_TargetPath.Size = new System.Drawing.Size(290, 21);
            this.txtBox_TargetPath.TabIndex = 1;
            this.txtBox_TargetPath.Text = " 대상 파일을 열어주세요";
            // 
            // cbb_SpoofExtension
            // 
            this.cbb_SpoofExtension.FormattingEnabled = true;
            this.cbb_SpoofExtension.Location = new System.Drawing.Point(237, 57);
            this.cbb_SpoofExtension.Name = "cbb_SpoofExtension";
            this.cbb_SpoofExtension.Size = new System.Drawing.Size(65, 20);
            this.cbb_SpoofExtension.TabIndex = 2;
            this.cbb_SpoofExtension.SelectedIndexChanged += new System.EventHandler(this.cbb_SpoofExtension_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spoof 할 확장자";
            // 
            // RunSpoofExtension
            // 
            this.RunSpoofExtension.Location = new System.Drawing.Point(308, 54);
            this.RunSpoofExtension.Name = "RunSpoofExtension";
            this.RunSpoofExtension.Size = new System.Drawing.Size(75, 23);
            this.RunSpoofExtension.TabIndex = 4;
            this.RunSpoofExtension.Text = "실행";
            this.RunSpoofExtension.UseVisualStyleBackColor = true;
            this.RunSpoofExtension.Click += new System.EventHandler(this.RunSpoofExtension_Click);
            // 
            // txtBox_TargetName
            // 
            this.txtBox_TargetName.Location = new System.Drawing.Point(15, 56);
            this.txtBox_TargetName.Name = "txtBox_TargetName";
            this.txtBox_TargetName.Size = new System.Drawing.Size(216, 21);
            this.txtBox_TargetName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 92);
            this.Controls.Add(this.txtBox_TargetName);
            this.Controls.Add(this.RunSpoofExtension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_SpoofExtension);
            this.Controls.Add(this.txtBox_TargetPath);
            this.Controls.Add(this.OpenTargetFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenTargetFile;
        private System.Windows.Forms.TextBox txtBox_TargetPath;
        private System.Windows.Forms.ComboBox cbb_SpoofExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RunSpoofExtension;
        private System.Windows.Forms.TextBox txtBox_TargetName;
    }
}

