
namespace SameSameGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panMain = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblBlock = new System.Windows.Forms.Label();
            this.picScore1 = new System.Windows.Forms.PictureBox();
            this.picScore2 = new System.Windows.Forms.PictureBox();
            this.picScore3 = new System.Windows.Forms.PictureBox();
            this.picScore4 = new System.Windows.Forms.PictureBox();
            this.picScore5 = new System.Windows.Forms.PictureBox();
            this.picBlock1 = new System.Windows.Forms.PictureBox();
            this.picBlock2 = new System.Windows.Forms.PictureBox();
            this.picBlock3 = new System.Windows.Forms.PictureBox();
            this.imglstBlock = new System.Windows.Forms.ImageList(this.components);
            this.imglstSel = new System.Windows.Forms.ImageList(this.components);
            this.imglstNum = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock3)).BeginInit();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panMain.BackgroundImage")));
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panMain.Location = new System.Drawing.Point(112, 75);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(604, 304);
            this.panMain.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 415);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(104, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(122, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(29, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(61, 15);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score : ";
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Location = new System.Drawing.Point(247, 9);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(59, 15);
            this.lblBlock.TabIndex = 4;
            this.lblBlock.Text = "Block : ";
            // 
            // picScore1
            // 
            this.picScore1.Location = new System.Drawing.Point(180, 9);
            this.picScore1.Name = "picScore1";
            this.picScore1.Size = new System.Drawing.Size(15, 20);
            this.picScore1.TabIndex = 5;
            this.picScore1.TabStop = false;
            // 
            // picScore2
            // 
            this.picScore2.Location = new System.Drawing.Point(159, 9);
            this.picScore2.Name = "picScore2";
            this.picScore2.Size = new System.Drawing.Size(15, 20);
            this.picScore2.TabIndex = 6;
            this.picScore2.TabStop = false;
            // 
            // picScore3
            // 
            this.picScore3.Location = new System.Drawing.Point(138, 9);
            this.picScore3.Name = "picScore3";
            this.picScore3.Size = new System.Drawing.Size(15, 20);
            this.picScore3.TabIndex = 7;
            this.picScore3.TabStop = false;
            // 
            // picScore4
            // 
            this.picScore4.Location = new System.Drawing.Point(117, 9);
            this.picScore4.Name = "picScore4";
            this.picScore4.Size = new System.Drawing.Size(15, 20);
            this.picScore4.TabIndex = 8;
            this.picScore4.TabStop = false;
            // 
            // picScore5
            // 
            this.picScore5.Location = new System.Drawing.Point(96, 9);
            this.picScore5.Name = "picScore5";
            this.picScore5.Size = new System.Drawing.Size(15, 20);
            this.picScore5.TabIndex = 9;
            this.picScore5.TabStop = false;
            // 
            // picBlock1
            // 
            this.picBlock1.Location = new System.Drawing.Point(348, 9);
            this.picBlock1.Name = "picBlock1";
            this.picBlock1.Size = new System.Drawing.Size(15, 20);
            this.picBlock1.TabIndex = 10;
            this.picBlock1.TabStop = false;
            // 
            // picBlock2
            // 
            this.picBlock2.Location = new System.Drawing.Point(327, 9);
            this.picBlock2.Name = "picBlock2";
            this.picBlock2.Size = new System.Drawing.Size(15, 20);
            this.picBlock2.TabIndex = 11;
            this.picBlock2.TabStop = false;
            // 
            // picBlock3
            // 
            this.picBlock3.Location = new System.Drawing.Point(306, 9);
            this.picBlock3.Name = "picBlock3";
            this.picBlock3.Size = new System.Drawing.Size(15, 20);
            this.picBlock3.TabIndex = 12;
            this.picBlock3.TabStop = false;
            // 
            // imglstBlock
            // 
            this.imglstBlock.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstBlock.ImageStream")));
            this.imglstBlock.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstBlock.Images.SetKeyName(0, "b1.bmp");
            this.imglstBlock.Images.SetKeyName(1, "b2.bmp");
            this.imglstBlock.Images.SetKeyName(2, "b3.bmp");
            this.imglstBlock.Images.SetKeyName(3, "b4.bmp");
            this.imglstBlock.Images.SetKeyName(4, "b5.bmp");
            // 
            // imglstSel
            // 
            this.imglstSel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstSel.ImageStream")));
            this.imglstSel.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstSel.Images.SetKeyName(0, "s1.bmp");
            this.imglstSel.Images.SetKeyName(1, "s2.bmp");
            this.imglstSel.Images.SetKeyName(2, "s3.bmp");
            this.imglstSel.Images.SetKeyName(3, "s4.bmp");
            this.imglstSel.Images.SetKeyName(4, "s5.bmp");
            // 
            // imglstNum
            // 
            this.imglstNum.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstNum.ImageStream")));
            this.imglstNum.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstNum.Images.SetKeyName(0, "0.bmp");
            this.imglstNum.Images.SetKeyName(1, "1.bmp");
            this.imglstNum.Images.SetKeyName(2, "2.bmp");
            this.imglstNum.Images.SetKeyName(3, "3.bmp");
            this.imglstNum.Images.SetKeyName(4, "4.bmp");
            this.imglstNum.Images.SetKeyName(5, "5.bmp");
            this.imglstNum.Images.SetKeyName(6, "6.bmp");
            this.imglstNum.Images.SetKeyName(7, "7.bmp");
            this.imglstNum.Images.SetKeyName(8, "8.bmp");
            this.imglstNum.Images.SetKeyName(9, "9.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBlock3);
            this.Controls.Add(this.picBlock2);
            this.Controls.Add(this.picBlock1);
            this.Controls.Add(this.picScore5);
            this.Controls.Add(this.picScore4);
            this.Controls.Add(this.picScore3);
            this.Controls.Add(this.picScore2);
            this.Controls.Add(this.picScore1);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.PictureBox picScore1;
        private System.Windows.Forms.PictureBox picScore2;
        private System.Windows.Forms.PictureBox picScore3;
        private System.Windows.Forms.PictureBox picScore4;
        private System.Windows.Forms.PictureBox picScore5;
        private System.Windows.Forms.PictureBox picBlock1;
        private System.Windows.Forms.PictureBox picBlock2;
        private System.Windows.Forms.PictureBox picBlock3;
        private System.Windows.Forms.ImageList imglstBlock;
        private System.Windows.Forms.ImageList imglstSel;
        private System.Windows.Forms.ImageList imglstNum;
    }
}

