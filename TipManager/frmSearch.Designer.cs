
namespace TipManager
{
    partial class frmSearch
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.rbtnTitle = new System.Windows.Forms.RadioButton();
            this.rbtnGroup = new System.Windows.Forms.RadioButton();
            this.rbtnNote = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Controls.Add(this.rbtnNote);
            this.groupBoxSearch.Controls.Add(this.rbtnGroup);
            this.groupBoxSearch.Controls.Add(this.rbtnTitle);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(308, 83);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "검색 정보를 선택하세요.";
            // 
            // rbtnTitle
            // 
            this.rbtnTitle.AutoSize = true;
            this.rbtnTitle.Location = new System.Drawing.Point(20, 21);
            this.rbtnTitle.Name = "rbtnTitle";
            this.rbtnTitle.Size = new System.Drawing.Size(58, 19);
            this.rbtnTitle.TabIndex = 0;
            this.rbtnTitle.TabStop = true;
            this.rbtnTitle.Text = "제목";
            this.rbtnTitle.UseVisualStyleBackColor = true;
            // 
            // rbtnGroup
            // 
            this.rbtnGroup.AutoSize = true;
            this.rbtnGroup.Location = new System.Drawing.Point(131, 21);
            this.rbtnGroup.Name = "rbtnGroup";
            this.rbtnGroup.Size = new System.Drawing.Size(58, 19);
            this.rbtnGroup.TabIndex = 1;
            this.rbtnGroup.TabStop = true;
            this.rbtnGroup.Text = "그룹";
            this.rbtnGroup.UseVisualStyleBackColor = true;
            // 
            // rbtnNote
            // 
            this.rbtnNote.AutoSize = true;
            this.rbtnNote.Location = new System.Drawing.Point(244, 21);
            this.rbtnNote.Name = "rbtnNote";
            this.rbtnNote.Size = new System.Drawing.Size(58, 19);
            this.rbtnNote.TabIndex = 2;
            this.rbtnNote.TabStop = true;
            this.rbtnNote.Text = "내용";
            this.rbtnNote.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(296, 25);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(143, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 140);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBoxSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSearch";
            this.ShowInTaskbar = false;
            this.Text = "찾기";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbtnNote;
        private System.Windows.Forms.RadioButton rbtnGroup;
        private System.Windows.Forms.RadioButton rbtnTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
    }
}