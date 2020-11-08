namespace xingapi_bridge
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
            this.test_btn = new System.Windows.Forms.Button();
            this.consoleview = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(24, 93);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(115, 34);
            this.test_btn.TabIndex = 3;
            this.test_btn.Text = "test";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // consoleview
            // 
            this.consoleview.Location = new System.Drawing.Point(12, 267);
            this.consoleview.Name = "consoleview";
            this.consoleview.ReadOnly = true;
            this.consoleview.Size = new System.Drawing.Size(776, 171);
            this.consoleview.TabIndex = 4;
            this.consoleview.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.consoleview);
            this.Controls.Add(this.test_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.RichTextBox consoleview;
        private System.Windows.Forms.Button button1;
    }
}

