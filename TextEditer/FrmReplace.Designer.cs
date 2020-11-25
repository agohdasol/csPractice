
namespace TextEditer
{
    partial class FrmReplace
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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReText = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.lblContentsToFind = new System.Windows.Forms.Label();
            this.lblContentsToChange = new System.Windows.Forms.Label();
            this.groupBoxDirection = new System.Windows.Forms.GroupBox();
            this.rdoDown = new System.Windows.Forms.RadioButton();
            this.rdoUp = new System.Windows.Forms.RadioButton();
            this.groupBoxDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(92, 39);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(317, 25);
            this.txtFind.TabIndex = 0;
            // 
            // txtReText
            // 
            this.txtReText.Location = new System.Drawing.Point(92, 70);
            this.txtReText.Name = "txtReText";
            this.txtReText.Size = new System.Drawing.Size(317, 25);
            this.txtReText.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(479, 43);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(105, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "다음찾기";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(479, 72);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(105, 23);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "바꾸기";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(479, 101);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(105, 23);
            this.btnReplaceAll.TabIndex = 4;
            this.btnReplaceAll.Text = "모두바꾸기";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(479, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(12, 116);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(130, 19);
            this.chkCase.TabIndex = 6;
            this.chkCase.Text = "대/소문자 구분";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // lblContentsToFind
            // 
            this.lblContentsToFind.AutoSize = true;
            this.lblContentsToFind.Location = new System.Drawing.Point(22, 39);
            this.lblContentsToFind.Name = "lblContentsToFind";
            this.lblContentsToFind.Size = new System.Drawing.Size(77, 15);
            this.lblContentsToFind.TabIndex = 9;
            this.lblContentsToFind.Text = "찾을내용 :";
            // 
            // lblContentsToChange
            // 
            this.lblContentsToChange.AutoSize = true;
            this.lblContentsToChange.Location = new System.Drawing.Point(22, 73);
            this.lblContentsToChange.Name = "lblContentsToChange";
            this.lblContentsToChange.Size = new System.Drawing.Size(77, 15);
            this.lblContentsToChange.TabIndex = 10;
            this.lblContentsToChange.Text = "바꿀내용 :";
            // 
            // groupBoxDirection
            // 
            this.groupBoxDirection.Controls.Add(this.rdoDown);
            this.groupBoxDirection.Controls.Add(this.rdoUp);
            this.groupBoxDirection.Location = new System.Drawing.Point(148, 101);
            this.groupBoxDirection.Name = "groupBoxDirection";
            this.groupBoxDirection.Size = new System.Drawing.Size(222, 52);
            this.groupBoxDirection.TabIndex = 11;
            this.groupBoxDirection.TabStop = false;
            this.groupBoxDirection.Text = "방향";
            // 
            // rdoDown
            // 
            this.rdoDown.AutoSize = true;
            this.rdoDown.Location = new System.Drawing.Point(85, 20);
            this.rdoDown.Name = "rdoDown";
            this.rdoDown.Size = new System.Drawing.Size(73, 19);
            this.rdoDown.TabIndex = 1;
            this.rdoDown.TabStop = true;
            this.rdoDown.Text = "아래쪽";
            this.rdoDown.UseVisualStyleBackColor = true;
            // 
            // rdoUp
            // 
            this.rdoUp.AutoSize = true;
            this.rdoUp.Location = new System.Drawing.Point(21, 20);
            this.rdoUp.Name = "rdoUp";
            this.rdoUp.Size = new System.Drawing.Size(58, 19);
            this.rdoUp.TabIndex = 0;
            this.rdoUp.TabStop = true;
            this.rdoUp.Text = "위쪽";
            this.rdoUp.UseVisualStyleBackColor = true;
            // 
            // FrmReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 165);
            this.Controls.Add(this.groupBoxDirection);
            this.Controls.Add(this.lblContentsToChange);
            this.Controls.Add(this.lblContentsToFind);
            this.Controls.Add(this.chkCase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtReText);
            this.Controls.Add(this.txtFind);
            this.Name = "FrmReplace";
            this.Text = "찾기 / 바꾸기";
            this.groupBoxDirection.ResumeLayout(false);
            this.groupBoxDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReText;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.Label lblContentsToFind;
        private System.Windows.Forms.Label lblContentsToChange;
        private System.Windows.Forms.GroupBox groupBoxDirection;
        private System.Windows.Forms.RadioButton rdoDown;
        private System.Windows.Forms.RadioButton rdoUp;
    }
}