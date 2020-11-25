
namespace TextEditer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditDown = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditUp = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeText = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imglstTree = new System.Windows.Forms.ImageList(this.components);
            this.fileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.SearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileNew,
            this.MenuFileOpen,
            this.MenuFileSave,
            this.MenuFileSaveAs,
            this.종료ToolStripMenuItem,
            this.MenuFileEnd});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.FileToolStripMenuItem.Text = "파일";
            // 
            // MenuFileNew
            // 
            this.MenuFileNew.Name = "MenuFileNew";
            this.MenuFileNew.Size = new System.Drawing.Size(224, 26);
            this.MenuFileNew.Text = "새로만들기";
            this.MenuFileNew.Click += new System.EventHandler(this.MenuFileNew_Click);
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.Size = new System.Drawing.Size(224, 26);
            this.MenuFileOpen.Text = "열기";
            this.MenuFileOpen.Click += new System.EventHandler(this.MenuFileOpen_Click);
            // 
            // MenuFileSave
            // 
            this.MenuFileSave.Name = "MenuFileSave";
            this.MenuFileSave.Size = new System.Drawing.Size(224, 26);
            this.MenuFileSave.Text = "저장";
            // 
            // MenuFileSaveAs
            // 
            this.MenuFileSaveAs.Name = "MenuFileSaveAs";
            this.MenuFileSaveAs.Size = new System.Drawing.Size(224, 26);
            this.MenuFileSaveAs.Text = "다른이름으로 저장";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(221, 6);
            // 
            // MenuFileEnd
            // 
            this.MenuFileEnd.Name = "MenuFileEnd";
            this.MenuFileEnd.Size = new System.Drawing.Size(224, 26);
            this.MenuFileEnd.Text = "종료";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEditCut,
            this.MenuEditCopy,
            this.MenuEditPaste,
            this.MenuEditDelete,
            this.toolStripMenuItem1,
            this.MenuEditAll,
            this.MenuEditTime,
            this.toolStripMenuItem2,
            this.MenuEditDown,
            this.MenuEditUp});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.EditToolStripMenuItem.Text = "편집";
            // 
            // MenuEditCut
            // 
            this.MenuEditCut.Name = "MenuEditCut";
            this.MenuEditCut.Size = new System.Drawing.Size(224, 26);
            this.MenuEditCut.Text = "잘라내기";
            // 
            // MenuEditCopy
            // 
            this.MenuEditCopy.Name = "MenuEditCopy";
            this.MenuEditCopy.Size = new System.Drawing.Size(224, 26);
            this.MenuEditCopy.Text = "복사";
            // 
            // MenuEditPaste
            // 
            this.MenuEditPaste.Name = "MenuEditPaste";
            this.MenuEditPaste.Size = new System.Drawing.Size(224, 26);
            this.MenuEditPaste.Text = "붙여넣기";
            // 
            // MenuEditDelete
            // 
            this.MenuEditDelete.Name = "MenuEditDelete";
            this.MenuEditDelete.Size = new System.Drawing.Size(224, 26);
            this.MenuEditDelete.Text = "삭제";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // MenuEditAll
            // 
            this.MenuEditAll.Name = "MenuEditAll";
            this.MenuEditAll.Size = new System.Drawing.Size(224, 26);
            this.MenuEditAll.Text = "전체선택";
            // 
            // MenuEditTime
            // 
            this.MenuEditTime.Name = "MenuEditTime";
            this.MenuEditTime.Size = new System.Drawing.Size(224, 26);
            this.MenuEditTime.Text = "시간/날짜";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // MenuEditDown
            // 
            this.MenuEditDown.Name = "MenuEditDown";
            this.MenuEditDown.Size = new System.Drawing.Size(224, 26);
            this.MenuEditDown.Text = "소문자로";
            // 
            // MenuEditUp
            // 
            this.MenuEditUp.Name = "MenuEditUp";
            this.MenuEditUp.Size = new System.Drawing.Size(224, 26);
            this.MenuEditUp.Text = "대문자로";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSearchFind,
            this.MenuSearchReplace});
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.SearchToolStripMenuItem.Text = "찾기";
            // 
            // MenuSearchFind
            // 
            this.MenuSearchFind.Name = "MenuSearchFind";
            this.MenuSearchFind.Size = new System.Drawing.Size(224, 26);
            this.MenuSearchFind.Text = "찾기";
            // 
            // MenuSearchReplace
            // 
            this.MenuSearchReplace.Name = "MenuSearchReplace";
            this.MenuSearchReplace.Size = new System.Drawing.Size(224, 26);
            this.MenuSearchReplace.Text = "바꾸기";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeText);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtMain);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 422);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeText
            // 
            this.treeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeText.HideSelection = false;
            this.treeText.Location = new System.Drawing.Point(0, 15);
            this.treeText.Name = "treeText";
            this.treeText.Size = new System.Drawing.Size(264, 405);
            this.treeText.TabIndex = 1;
            this.treeText.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeText_BeforeSelect);
            this.treeText.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeText_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "문서목록";
            // 
            // txtMain
            // 
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.Location = new System.Drawing.Point(0, 15);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMain.Size = new System.Drawing.Size(528, 405);
            this.txtMain.TabIndex = 1;
            this.txtMain.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "내용";
            // 
            // imglstTree
            // 
            this.imglstTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTree.ImageStream")));
            this.imglstTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTree.Images.SetKeyName(0, "root.bmp");
            this.imglstTree.Images.SetKeyName(1, "seltext.bmp");
            this.imglstTree.Images.SetKeyName(2, "text.bmp");
            // 
            // fileDlg
            // 
            this.fileDlg.FileName = "openFileDialog1";
            this.fileDlg.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            // 
            // saveDlg
            // 
            this.saveDlg.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "문서 편집기";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imglstTree;
        private System.Windows.Forms.OpenFileDialog fileDlg;
        private System.Windows.Forms.SaveFileDialog saveDlg;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFileNew;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFileEnd;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuEditCut;
        private System.Windows.Forms.ToolStripMenuItem MenuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem MenuEditDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuEditAll;
        private System.Windows.Forms.ToolStripMenuItem MenuEditTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuEditDown;
        private System.Windows.Forms.ToolStripMenuItem MenuEditUp;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchFind;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchReplace;
    }
}

