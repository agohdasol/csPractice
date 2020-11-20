
namespace Hanoi
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panLeft = new System.Windows.Forms.Panel();
            this.panCenter = new System.Windows.Forms.Panel();
            this.panRight = new System.Windows.Forms.Panel();
            this.nudCnt = new System.Windows.Forms.NumericUpDown();
            this.lblCnt = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCnt)).BeginInit();
            this.SuspendLayout();
            // 
            // panLeft
            // 
            this.panLeft.AllowDrop = true;
            this.panLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panLeft.BackgroundImage")));
            this.panLeft.Location = new System.Drawing.Point(12, 12);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(180, 250);
            this.panLeft.TabIndex = 0;
            // 
            // panCenter
            // 
            this.panCenter.AllowDrop = true;
            this.panCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panCenter.BackgroundImage")));
            this.panCenter.Location = new System.Drawing.Point(198, 12);
            this.panCenter.Name = "panCenter";
            this.panCenter.Size = new System.Drawing.Size(180, 250);
            this.panCenter.TabIndex = 1;
            // 
            // panRight
            // 
            this.panRight.AllowDrop = true;
            this.panRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panRight.BackgroundImage")));
            this.panRight.Location = new System.Drawing.Point(384, 12);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(180, 250);
            this.panRight.TabIndex = 2;
            // 
            // nudCnt
            // 
            this.nudCnt.Location = new System.Drawing.Point(643, 146);
            this.nudCnt.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudCnt.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCnt.Name = "nudCnt";
            this.nudCnt.Size = new System.Drawing.Size(47, 25);
            this.nudCnt.TabIndex = 3;
            this.nudCnt.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(645, 183);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(45, 15);
            this.lblCnt.TabIndex = 4;
            this.lblCnt.Text = "label1";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(570, 210);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(120, 23);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "다시 시작하기";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(570, 239);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(120, 23);
            this.btnAuto.TabIndex = 6;
            this.btnAuto.Text = "자동 맞추기";
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblCnt);
            this.Controls.Add(this.nudCnt);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.panCenter);
            this.Controls.Add(this.panLeft);
            this.Name = "frmMain";
            this.Text = "하노이탑";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panLeft;
        private System.Windows.Forms.Panel panCenter;
        private System.Windows.Forms.Panel panRight;
        private System.Windows.Forms.NumericUpDown nudCnt;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnAuto;
    }
}

