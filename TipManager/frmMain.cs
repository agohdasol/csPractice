using System;
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
        public frmMain()
        {
            InitializeComponent();
        }

        private void 구분선ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\Tip.accdb";
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
    }
}
