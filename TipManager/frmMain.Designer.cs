
namespace TipManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResult = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tibAdd = new System.Windows.Forms.ToolStripButton();
            this.tipUpdate = new System.Windows.Forms.ToolStripButton();
            this.tipDelete = new System.Windows.Forms.ToolStripButton();
            this.tipSearch = new System.Windows.Forms.ToolStripButton();
            this.tipResult = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tipSave = new System.Windows.Forms.ToolStripButton();
            this.wndStatusBar = new System.Windows.Forms.StatusStrip();
            this.sp1 = new System.Windows.Forms.SplitContainer();
            this.treeContents = new System.Windows.Forms.TreeView();
            this.imglstTree = new System.Windows.Forms.ImageList(this.components);
            this.sp2 = new System.Windows.Forms.SplitContainer();
            this.rtxNote = new System.Windows.Forms.RichTextBox();
            this.lvResult = new System.Windows.Forms.ListView();
            this.panBottom = new System.Windows.Forms.Panel();
            this.panTop = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.picResultClose = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp1)).BeginInit();
            this.sp1.Panel1.SuspendLayout();
            this.sp1.Panel2.SuspendLayout();
            this.sp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).BeginInit();
            this.sp2.Panel1.SuspendLayout();
            this.sp2.Panel2.SuspendLayout();
            this.sp2.SuspendLayout();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResultClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1555, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuUpdate,
            this.mnuDelete,
            this.mnuSep,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(53, 24);
            this.mnuFile.Text = "파일";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(142, 26);
            this.mnuAdd.Text = "팁 추가";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(142, 26);
            this.mnuUpdate.Text = "팁 수정";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(142, 26);
            this.mnuDelete.Text = "팁 삭제";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuSep
            // 
            this.mnuSep.Name = "mnuSep";
            this.mnuSep.Size = new System.Drawing.Size(139, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(142, 26);
            this.mnuExit.Text = "종료";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(53, 24);
            this.mnuEdit.Text = "편집";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(177, 26);
            this.mnuSave.Text = "팁 내용 저장";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearch,
            this.mnuResult});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(53, 24);
            this.mnuView.Text = "보기";
            // 
            // mnuSearch
            // 
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.Size = new System.Drawing.Size(142, 26);
            this.mnuSearch.Text = "검색";
            this.mnuSearch.Click += new System.EventHandler(this.mnuSearch_Click);
            // 
            // mnuResult
            // 
            this.mnuResult.Name = "mnuResult";
            this.mnuResult.Size = new System.Drawing.Size(142, 26);
            this.mnuResult.Text = "결과 창";
            this.mnuResult.Click += new System.EventHandler(this.mnuResult_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tibAdd,
            this.tipUpdate,
            this.tipDelete,
            this.tipSearch,
            this.tipResult,
            this.toolStripSeparator1,
            this.tipSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1555, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tibAdd
            // 
            this.tibAdd.AutoSize = false;
            this.tibAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tibAdd.Image = ((System.Drawing.Image)(resources.GetObject("tibAdd.Image")));
            this.tibAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tibAdd.Name = "tibAdd";
            this.tibAdd.Size = new System.Drawing.Size(24, 24);
            this.tibAdd.Text = "팁 추가";
            // 
            // tipUpdate
            // 
            this.tipUpdate.AutoSize = false;
            this.tipUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tipUpdate.Image")));
            this.tipUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipUpdate.Name = "tipUpdate";
            this.tipUpdate.Size = new System.Drawing.Size(24, 24);
            this.tipUpdate.Text = "팁 수정";
            this.tipUpdate.ToolTipText = "팁 수정";
            // 
            // tipDelete
            // 
            this.tipDelete.AutoSize = false;
            this.tipDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipDelete.Image = ((System.Drawing.Image)(resources.GetObject("tipDelete.Image")));
            this.tipDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipDelete.Name = "tipDelete";
            this.tipDelete.Size = new System.Drawing.Size(24, 24);
            this.tipDelete.Text = "팁 삭제";
            this.tipDelete.ToolTipText = "팁 삭제";
            // 
            // tipSearch
            // 
            this.tipSearch.AutoSize = false;
            this.tipSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipSearch.Image = ((System.Drawing.Image)(resources.GetObject("tipSearch.Image")));
            this.tipSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipSearch.Name = "tipSearch";
            this.tipSearch.Size = new System.Drawing.Size(24, 24);
            this.tipSearch.Text = "검색";
            // 
            // tipResult
            // 
            this.tipResult.AutoSize = false;
            this.tipResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipResult.Image = ((System.Drawing.Image)(resources.GetObject("tipResult.Image")));
            this.tipResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipResult.Name = "tipResult";
            this.tipResult.Size = new System.Drawing.Size(24, 24);
            this.tipResult.Text = "결과창";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tipSave
            // 
            this.tipSave.AutoSize = false;
            this.tipSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipSave.Image = ((System.Drawing.Image)(resources.GetObject("tipSave.Image")));
            this.tipSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipSave.Name = "tipSave";
            this.tipSave.Size = new System.Drawing.Size(24, 24);
            this.tipSave.Text = "저장";
            // 
            // wndStatusBar
            // 
            this.wndStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.wndStatusBar.Location = new System.Drawing.Point(0, 583);
            this.wndStatusBar.Name = "wndStatusBar";
            this.wndStatusBar.Size = new System.Drawing.Size(1555, 22);
            this.wndStatusBar.TabIndex = 2;
            this.wndStatusBar.Text = "statusStrip1";
            // 
            // sp1
            // 
            this.sp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp1.Location = new System.Drawing.Point(0, 55);
            this.sp1.Name = "sp1";
            // 
            // sp1.Panel1
            // 
            this.sp1.Panel1.Controls.Add(this.treeContents);
            // 
            // sp1.Panel2
            // 
            this.sp1.Panel2.Controls.Add(this.sp2);
            this.sp1.Size = new System.Drawing.Size(1555, 528);
            this.sp1.SplitterDistance = 517;
            this.sp1.TabIndex = 3;
            // 
            // treeContents
            // 
            this.treeContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeContents.HideSelection = false;
            this.treeContents.ImageIndex = 0;
            this.treeContents.ImageList = this.imglstTree;
            this.treeContents.Location = new System.Drawing.Point(0, 0);
            this.treeContents.Name = "treeContents";
            this.treeContents.SelectedImageIndex = 0;
            this.treeContents.Size = new System.Drawing.Size(515, 526);
            this.treeContents.TabIndex = 0;
            this.treeContents.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeContents_AfterSelect);
            // 
            // imglstTree
            // 
            this.imglstTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTree.ImageStream")));
            this.imglstTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTree.Images.SetKeyName(0, "book1.bmp");
            this.imglstTree.Images.SetKeyName(1, "item.bmp");
            // 
            // sp2
            // 
            this.sp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp2.Location = new System.Drawing.Point(0, 0);
            this.sp2.Name = "sp2";
            this.sp2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sp2.Panel1
            // 
            this.sp2.Panel1.Controls.Add(this.rtxNote);
            // 
            // sp2.Panel2
            // 
            this.sp2.Panel2.Controls.Add(this.lvResult);
            this.sp2.Panel2.Controls.Add(this.panBottom);
            this.sp2.Panel2.Controls.Add(this.panTop);
            this.sp2.Size = new System.Drawing.Size(1034, 528);
            this.sp2.SplitterDistance = 183;
            this.sp2.TabIndex = 0;
            // 
            // rtxNote
            // 
            this.rtxNote.AcceptsTab = true;
            this.rtxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxNote.Location = new System.Drawing.Point(0, 0);
            this.rtxNote.Name = "rtxNote";
            this.rtxNote.Size = new System.Drawing.Size(1032, 181);
            this.rtxNote.TabIndex = 0;
            this.rtxNote.Text = "";
            // 
            // lvResult
            // 
            this.lvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(0, 125);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(1032, 214);
            this.lvResult.TabIndex = 2;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.ItemActivate += new System.EventHandler(this.lvResult_ItemActivate);
            // 
            // panBottom
            // 
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBottom.Location = new System.Drawing.Point(0, 125);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(1032, 214);
            this.panBottom.TabIndex = 1;
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.lblResult);
            this.panTop.Controls.Add(this.picResultClose);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1032, 125);
            this.panTop.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Location = new System.Drawing.Point(0, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 15);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "label1";
            // 
            // picResultClose
            // 
            this.picResultClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picResultClose.Location = new System.Drawing.Point(907, 0);
            this.picResultClose.Name = "picResultClose";
            this.picResultClose.Size = new System.Drawing.Size(125, 125);
            this.picResultClose.TabIndex = 0;
            this.picResultClose.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 605);
            this.Controls.Add(this.sp1);
            this.Controls.Add(this.wndStatusBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.sp1.Panel1.ResumeLayout(false);
            this.sp1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp1)).EndInit();
            this.sp1.ResumeLayout(false);
            this.sp2.Panel1.ResumeLayout(false);
            this.sp2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).EndInit();
            this.sp2.ResumeLayout(false);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResultClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip wndStatusBar;
        private System.Windows.Forms.SplitContainer sp1;
        private System.Windows.Forms.TreeView treeContents;
        private System.Windows.Forms.SplitContainer sp2;
        private System.Windows.Forms.RichTextBox rtxNote;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox picResultClose;
        private System.Windows.Forms.ImageList imglstTree;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripSeparator mnuSep;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuResult;
        private System.Windows.Forms.ToolStripButton tibAdd;
        private System.Windows.Forms.ToolStripButton tipUpdate;
        private System.Windows.Forms.ToolStripButton tipDelete;
        private System.Windows.Forms.ToolStripButton tipSearch;
        private System.Windows.Forms.ToolStripButton tipResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tipSave;
    }
}

