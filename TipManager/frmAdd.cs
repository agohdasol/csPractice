using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipManager
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            Init();

            string strGroup = "";
            string[] strArrItem;
            int nIndex;

            m_frmParent.GetGroupNameList(ref strGroup);

            if (!strGroup.Equals(""))
            {
                strArrItem = strGroup.Split(";");

                for (nIndex = 0; nIndex < strArrItem.Length; nIndex++)
                    cbGroup.Items.Add(strArrItem[nIndex]);
            }

            if (m_nMode == UPGRADE_MODE)
            {
                cbGroup.SelectedText = m_uiInfo.m_strGroup;
                txtTitle.Text = m_uiInfo.m_strTitle;
            }
            else
                cbGroup.SelectedIndex = 0;
        }
        public void GetGroupNameList(ref string strGroup)
        {
            TreeNode tnItem = treeContents.Nodes[0];
            TreeNode tnTemp = null;
            string strNode;

            tnTemp = tnItem.FirstNode;

            while (tnTemp != null)
            {
                System.Windows.Forms.Application.DoEvents();

                strNode = tnTemp.Text;

                strGroup += strNode;
                strGroup += ";";

                tnTemp = tnTemp.NextNode;
            }

            if (!strGroup.Equals(""))
                strGroup = strGroup.Substring(0, strGroup.Length - 1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strSQL, strGroup, strTitle;
            OleDbCommand oleCmd;
            OleDbTransaction oleTran;

            strGroup = cbGroup.Text;
            if(strGroup.Equals(""))
            {
                MessageBox.Show("그룹 이름을 입력하셔야 합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            strTitle = txtTitle.Text;
            if (strTitle.Equals(""))
            {
                MessageBox.Show("팁 제목을 입력하셔야 합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (m_nMode == ADD_MODE)
            {
                strTitle strSeq;
                strSeq = m_frmParent.GetNextSeqNum();

                strSQL = "INSERT INTO TIP VALUES(" + strSeq + ",'" + strTitle + ",'" + strGroup + ",'" + "')";

                try
                {
                    oleCmd = new OleDbCommand(strSQL, m_frmParent.m_oleConn);

                    oleTran = m_frmParent.m_oleConn.BeginTransaction();
                    oleCmd.Transaction = oleTran;

                    oleCmd.ExecuteNonQuery();

                    oleTran.Commit();

                    m_frmParent.AddTreeItem(strSeq, strGroup, strTitle, "");
                }
                catch(OleDbException err)
                {
                    MessageBox.Show(err.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                strSQL = "UPDATE TIP SET TF_GROUP = '" + strGroup + "', TF_TITLE = '" + strTitle + "' WHERE TF_SEQ = " + m_uiInfo.m_strKey;

                try
                {
                    oleCmd = new OleDbCommand(strSQL, m_frmParent.m_oleConn);
                    oleTran = m_frmParent.m_oleConn.BeginTransaction();
                    oleCmd.Transaction = oleTran;

                    oleCmd.ExecuteNonQuery();

                    oleTran.Commit();

                    m_frmParent.UpdateTreeItem(strGroup, strTitle);
                }
                catch(OleDbException err)
                {
                    MessageBox.Show(err.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }
        public string GetNextSeqNum()
        {
            string strSeq = "";

            try
            {
                string strSQL;
                OleDbDataReader oleDR;

                strSQL = "SELECT MAX(TF_SEQ) AS MAX_SEQ FROM TIP";
                OleDbCommand oleCmd = new OleDbCommand(strSQL, m_oleConn);

                oleDR = oleCmd.ExecuteReader();

                if (oleDR.Read())
                    strSeq = (Convert.ToInt32(oleDR["MAX_SEQ"].ToString()) + 1).ToString();

                oleDR.Close();
            }
            catch(OleDbException err)
            {
                MessageBox.Show(err.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            return strSeq;
        }
    }
}
