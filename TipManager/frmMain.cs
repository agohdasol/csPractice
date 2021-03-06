﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TipManager
{
    public partial class frmMain : Form
    {
        public OleDbConnection m_oleConn;

        //트리 이미지
        public enum TREE_IMAGE
        {
            TI_PARENT = 0,
            TI_ITEM
        }

        //frmAdd의 사용 용도
        public enum FORM_MODE
        {
            FM_INSERT = 0,       //추가 모드
            FM_UPDATE           //수정 모드
        }

        bool m_bResultShow;    //검색 결과 Show/Hide
                               // TreeView 초기화
        private void InitTree()
        {
            treeContents.Nodes.Clear();
            treeContents.ShowRootLines = true;
            treeContents.HideSelection = false;

            //루트노드 생성
            treeContents.Nodes.Add(new TreeNode("나만의 팁", (int)TREE_IMAGE.TI_PARENT, (int)TREE_IMAGE.TI_PARENT));

            //상태바에 루트노드 텍스트 설정
            wndStatusBar.Text = treeContents.Nodes[0].Text;
        }

        // 리스트뷰 초기화
        private void InitList()
        {
            //리스트뷰 속성설정
            lvResult.View = View.Details;
            lvResult.MultiSelect = false;
            lvResult.FullRowSelect = true;
            lvResult.Activation = ItemActivation.TwoClick;

            lvResult.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            //컬럼 추가
            lvResult.Columns.Add("그룹", 80, HorizontalAlignment.Left);
            lvResult.Columns.Add("제목", lvResult.Width - 90, HorizontalAlignment.Left);

        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowResultList(false);
            InitTree();
            InitList();
            InitRichText();
            if (InitDatabase() == false)
            {
                MessageBox.Show("데이터베이스에 연결 실패하여 프로그램을 종료합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
        }
        private void InitRichText()
        {
            //MultiLine 속성을 갖고 있는 RichTextBox 컨트롤에서 Tab 키를 누를 때
            //AcceptsTab 속성이 설정되지 않으면 사용자가 Tab 키를 눌렀을 때, 
            //RichTextBox 내에서 탭 키로 작용하는것이 아니라 폼 내의 컨트롤의 
            //탭 순서에 따라 다음 컨트롤로 포커스를 이동하게 된다.
            //그러므로 해당 컨트롤에 탭 문자를 입력할지 여부를 나타내는 값을 
            //가져오거나 설정하는 AcceptsTab 속성을 설정해주어야 한다.
            rtxNote.AcceptsTab = true;
            rtxNote.Multiline = true;
            rtxNote.ForeColor = Color.Black;

            rtxNote.Text = "";
        }
        private bool InitDatabase()
        {
            try
            {
                m_oleConn = new OleDbConnection(GetConnectionStr());

                OleDbDataReader oleDR;
                OleDbCommand oleCmd = new OleDbCommand("SELECT * FROM TIP", m_oleConn);

                m_oleConn.Open();
                oleDR = oleCmd.ExecuteReader();

                SetTreeNode(oleDR);

                oleDR.Close();
            }
            catch(OleDbException e)
            {
                MessageBox.Show(e.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void ShowResultList(bool bShow)
        {
            if (bShow)
            {
                sp2.Visible = bShow;
                rtxNote.Parent = sp2.Panel1;
            }
            else
            {
                sp2.Visible = bShow;
                rtxNote.Parent = sp1.Panel2;
            }
            mnuResult.Checked = bShow;
        }
        private void SetTreeNode(OleDbDataReader oleDR)
        {
            string strSeq, strTitle, strGroup;
            TreeNode tnGroup;

            while (oleDR.Read())
            {
                strSeq = oleDR["TF_SEQ"].ToString();
                strTitle = oleDR["TF_TITLE"].ToString();
                strGroup = oleDR["TF_GROUP"].ToString();

                tnGroup = GetGroupNodePos(strGroup);

                if (tnGroup == null)
                {
                    TreeNode tnParent, tnItem;

                    tnParent = new TreeNode(strGroup, (int)TREE_IMAGE.TI_PARENT, (int)TREE_IMAGE.TI_PARENT);

                    treeContents.Nodes[0].Nodes.Add(tnParent);

                    tnItem = new TreeNode(strTitle, (int)TREE_IMAGE.TI_ITEM, (int)TREE_IMAGE.TI_ITEM);

                    tnParent.Nodes.Add(tnItem);
                    tnItem.Tag = strSeq;
                }
                else
                {
                    TreeNode tnItem;
                    tnItem = new TreeNode(strTitle, (int)TREE_IMAGE.TI_ITEM, (int)TREE_IMAGE.TI_ITEM);

                    tnItem.Tag = strSeq;
                    tnGroup.Nodes.Add(tnItem);
                }
            }
        }
        private TreeNode GetGroupNodePos(string strGroup)
        {
            TreeNode tnItem = treeContents.Nodes[0];
            TreeNode tnTemp = null;
            string strNode;

            tnTemp = tnItem.FirstNode;

            while (tnTemp != null)
            {
                strNode = tnTemp.Text;
                if (strNode.Equals(strGroup))
                    break;

                tnTemp = tnTemp.NextNode;
            }
            return tnTemp;
        }
        public string GetConnectionStr()
        {
            string strConn;
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\Tip.mdb";
            return strConn;
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            TreeNode tnItem;

            tnItem = treeContents.SelectedNode;

            if (tnItem.ImageIndex == (int)TREE_IMAGE.TI_ITEM)
            {
                DialogResult nYesNo;
                nYesNo = MessageBox.Show("선택한 아이템을 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (nYesNo == DialogResult.Yes)
                {
                    DeleteItem(tnItem.Tag.ToString());

                    TreeNode tnGroup;
                    tnGroup = tnItem.Parent;
                    treeContents.Nodes.Remove(tnItem);

                    if (tnGroup.LastNode == null)
                        treeContents.Nodes.Remove(tnGroup);
                    else
                    {
                        TreeNode tnTemp;
                        tnTemp = tnGroup.FirstNode;
                        treeContents.SelectedNode = tnTemp;
                        rtxNote.Text = GetTipNote(tnTemp.Tag.ToString());
                    }
                }
                else
                    MessageBox.Show("삭제할 아이템(팁 제목)을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void treeContents_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != treeContents.Nodes[0])
            {
                int nSelImage = e.Node.ImageIndex;

                if (nSelImage == (int)TREE_IMAGE.TI_ITEM)
                {
                    TreeNode tnItem;
                    string strSeq;

                    tnItem = treeContents.SelectedNode;
                    wndStatusBar.Text = GetStatusText(tnItem);

                    strSeq = tnItem.Tag.ToString();

                    rtxNote.Text = GetTipNote(strSeq);
                }
                else
                    wndStatusBar.Text = e.Node.Text;
            }
        }
        private String GetStatusText(TreeNode tnItem)
        {
            TreeNode tnParent;
            String strStatus;

            //선택한 아이템의 부모(=그룹이름)를 얻는다.
            tnParent = tnItem.Parent;

            //부모모드와 인자로 넘어온 tnItem의 텍스트를 더해 경로를 설정한다.
            strStatus = tnParent.Text;
            strStatus += "/";
            strStatus += tnItem.Text;

            return strStatus;

        }
        private int GetSelectedItem()
        {
            return lvResult.SelectedItems[0].Index;
        }
        public string GetTipNote(string strSeq)
        {
            string strRet = "";

            try
            {
                string strSQL;
                OleDbDataReader oleDR;

                strSQL = "SELECT TF_NOTE FROM TIP WHERE TF_SEQ = " + strSeq;

                OleDbCommand oleCmd = new OleDbCommand(strSQL, m_oleConn);

                oleDR = oleCmd.ExecuteReader();

                if (oleDR.Read())
                    strRet = oleDR["TF_NOTE"].ToString();

                oleDR.Close();
            }
            catch(OleDbException e)
            {
                MessageBox.Show(e.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            return strRet;
        }
        public void GetSearchResult(string strSQL)
        {
            try
            {
                string strSeq, strTitle, strGroup;

                OleDbDataReader oleDR;
                OleDbCommand oleCmd = new OleDbCommand(strSQL, m_oleConn);

                lvResult.Items.Clear();

                oleDR = oleCmd.ExecuteReader();

                while (oleDR.Read())
                {
                    strSeq = oleDR["TF_SEQ"].ToString();
                    strTitle = oleDR["TF_TITLE"].ToString();
                    strGroup = oleDR["TF_GROUP"].ToString();

                    AddListItem(strSeq, strTitle, strGroup);
                }

                oleDR.Close();
            }
            catch(OleDbException e)
            {
                MessageBox.Show(e.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddListItem(string strSeq, string strTitle, string strGroup)
        {
            ListViewItem lvItem = new ListViewItem();
            ListViewItem.ListViewSubItem lvTitle = new ListViewItem.ListViewSubItem();

            lvItem.Text = strGroup;
            lvItem.Tag = strSeq;

            lvTitle.Text = strTitle;
            lvItem.SubItems.Add(lvTitle);

            lvResult.Items.Add(lvItem);
        }

        private void lvResult_ItemActivate(object sender, EventArgs e)
        {
            TreeNode tnNode;
            int nIndex;

            nIndex = GetSelectedItem();

            if (nIndex >= 0)
            {
                string strSeq, strTitle;

                strSeq = lvResult.Items[nIndex].Tag.ToString();
                strTitle = lvResult.Items[nIndex].SubItems[1].ToString();

                tnNode = FindItem(strSeq);

                if (tnNode != null)
                    treeContents.SelectedNode = tnNode;

                rtxNote.Text = GetTipNote(strSeq);
            }
        }
        private TreeNode FindItem(string strSeq)
        {
            TreeNode tnItem = treeContents.Nodes[0];
            string strFind;

            while (tnItem != null)
            {
                strFind = tnItem.Tag.ToString();

                if (strFind != null)
                {
                    if (strFind.Equals(strSeq))
                        return tnItem;
                }
                tnItem = GetNextNode(tnItem);
            }
            return null;
        }
        private TreeNode GetNextNode(TreeNode tnItem)
        {
            TreeNode tnChild, tnNode, tnParent;

            tnChild = tnItem.FirstNode;
            if (tnChild != null)
                return tnChild;

            tnNode = tnItem.NextNode;

            if (tnNode != null)
                return tnNode;

            tnParent = tnItem.Parent;
            while (tnParent != null)
            {
                tnNode = tnParent.NextNode;
                if (tnNode != null)
                    return tnNode;

                tnParent = tnParent.Parent;
            }
            return null;
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            frmAdd frmUpdate = new frmAdd();
            TreeNode tnItem;

            tnItem = treeContents.SelectedNode;

            if (!tnItem.Tag.ToString().Equals(""))
            {
                TreeNode tnGroup;

                tnGroup = tnItem.Parent;

                frmUpdate.SetParent(this);
                frmUpdate.SetMode((int)FORM_MODE.FM_UPDATE);
                frmUpdate.SetUpdateInfo(tnGroup.Text, tnItem.Text, tnItem.Tag.ToString());
                frmUpdate.ShowDialog(this);
            }
            else
                MessageBox.Show("수정할 팁 제목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool DeleteItem(string strSeq)
        {
            string strSQL;
            OleDbCommand oleCmd;
            OleDbTransaction oleTran;

            strSQL = "DELETE FROM TIP WHERE TF_SEQ = " + strSeq;

            try
            {
                oleCmd = new OleDbCommand(strSQL, m_oleConn);

                oleTran = m_oleConn.BeginTransaction();
                oleCmd.Transaction = oleTran;

                oleCmd.ExecuteNonQuery();

                oleTran.Commit();
                return true;
            }
            catch(OleDbException err)
            {
                MessageBox.Show(err.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            TreeNode tnItem;

            tnItem = treeContents.SelectedNode;

            if (tnItem.SelectedImageIndex == (int)TREE_IMAGE.TI_ITEM)
            {
                string strSQL;
                string strNote;
                OleDbCommand oleCmd;
                OleDbTransaction oleTran;

                strNote = rtxNote.Text;
                strNote = strNote.Replace("'", "''");

                strSQL = "UPDATE TIP SET TF_NOTE = '" + strNote + "' WHERE TF_SEQ = " + tnItem.Tag;

                try
                {
                    oleCmd = new OleDbCommand(strSQL, m_oleConn);

                    oleTran = m_oleConn.BeginTransaction();
                    oleCmd.Transaction = oleTran;

                    oleCmd.ExecuteNonQuery();

                    oleTran.Commit();
                }
                catch (OleDbException err)
                {
                    MessageBox.Show(err.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("트리 아이템에서 팁 제목을 선택하신 후, 변경된 팁 내용을 저장하셔야 합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

            rtxNote.SelectAll();
            rtxNote.SelectionColor = Color.Black;
            rtxNote.Select(0, 0);
        }

        private void mnuSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmFind = new frmSearch();

            frmFind.SetParent(this);
            frmFind.ShowDialog(this);
        }

        private void mnuResult_Click(object sender, EventArgs e)
        {
            if (m_bResultShow == true)
            {
                ShowResultList(false);
                m_bResultShow = false;
                ((ToolStripButton)toolStrip1.Items[4]).Checked = false;
            }
            else
            {
                ShowResultList(true);
                m_bResultShow = true;
                ((ToolStripButton)toolStrip1.Items[4]).Checked = true;
            }
        }

        public void GetGroupNameList(ref String strGroup)
        {
            TreeNode tnItem = treeContents.Nodes[0];
            TreeNode tnTemp = null;
            String strNode;

            //첫번째 자식 노드(=그룹) 얻기
            tnTemp = tnItem.FirstNode;

            while (tnTemp != null)
            {
                System.Windows.Forms.Application.DoEvents();

                //트리 아이템 텍스트를 얻는다.
                strNode = tnTemp.Text;

                strGroup += strNode;
                strGroup += ";";

                //다음 형제 노드로 이동
                tnTemp = tnTemp.NextNode;
            }


            if (!strGroup.Equals("")) //마지막의 ;을 뺀다.
                strGroup = strGroup.Substring(0, strGroup.Length - 1);
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "tlbAdd")
                mnuAdd_Click(sender, e);
            else if (e.ClickedItem.Name == "tlbUpdate")
                mnuUpdate_Click(sender, e);
            else if (e.ClickedItem.Name == "tlbDelete")
                mnuDelete_Click(sender, e);
            else if (e.ClickedItem.Name == "tlbSearch")
                mnuSearch_Click(sender, e);
            else if (e.ClickedItem.Name == "tlbResult")
                mnuResult_Click(sender, e);
            else if (e.ClickedItem.Name == "tlbSave")
                mnuSave_Click(sender, e);
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            frmAdd frmTipAdd = new frmAdd();

            frmTipAdd.SetParent(this);

            frmTipAdd.SetMode((int)FORM_MODE.FM_INSERT);
            frmTipAdd.ShowDialog(this);
        }

        public void UpdateTreeItem(String strGroup, String strTitle)
        {

            TreeNode tnItem, tnGroup;

            //선택된 노드를 얻는다.
            tnItem = treeContents.SelectedNode;
            tnGroup = tnItem.Parent;

            tnItem.Text = strTitle;
            tnGroup.Text = strGroup;

            treeContents.Refresh();

        }
        public String GetNextSeqNum()
        {
            String strSeq = "";

            try
            {
                String strSQL;
                OleDbDataReader oleDR;

                //현재 TIP 테이블에서 TF_SEQ 필드 중 최대 값을 얻는다.
                strSQL = "SELECT MAX(TF_SEQ) AS MAX_SEQ FROM TIP";
                OleDbCommand oleCmd = new OleDbCommand(strSQL, m_oleConn);

                oleDR = oleCmd.ExecuteReader();

                if (oleDR.Read())
                    //TF_SEQ 필드는 자동증가 이므로 다음 SEQ 값은 필드에서 최고 큰 값 +1 이된다.
                    strSeq = (Convert.ToInt32(oleDR["MAX_SEQ"].ToString()) + 1).ToString();

                oleDR.Close();
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            return strSeq;

        }

        public void AddTreeItem(String strSeq, String strGroup, String strTitle, String strNote)
        {
            TreeNode tnGroup, tnParent, tnItem;

            //해당 그룹이름이 현재 TreeView에 존재하는지 검사한다.
            tnGroup = GetGroupNodePos(strGroup);

            //만약 현재 존재하지 않는 그룹노드라면 생성한다.
            if (tnGroup == null)
            {
                //그룹 노드 생성
                tnParent = new TreeNode(strGroup, (int)TREE_IMAGE.TI_PARENT, (int)TREE_IMAGE.TI_PARENT);

                //그룹 추가
                treeContents.Nodes[0].Nodes.Add(tnParent);

                //생성된 그룹에 팁 타이틀 추가
                tnItem = new TreeNode(strTitle, (int)TREE_IMAGE.TI_ITEM, (int)TREE_IMAGE.TI_ITEM);
                tnParent.Nodes.Add(tnItem);
                tnItem.Tag = strSeq;
            }
            else
            {
                //존재하는 그룹 노드이므로 해당 그룹 밑에 팁 제목을 추가한다.
                tnItem = new TreeNode(strTitle, (int)TREE_IMAGE.TI_ITEM, (int)TREE_IMAGE.TI_ITEM);
                tnItem.Tag = strSeq;

                //이미 존재하는 그룹이므로 및에 팁 타이틀 추가
                tnGroup.Nodes.Add(tnItem);
            }

            //사용자의 팁 내용을 받을 준비를 한다.
            rtxNote.Text = "";

            //추가된 노드 선택
            treeContents.SelectedNode = tnItem;

        }
    }
}
