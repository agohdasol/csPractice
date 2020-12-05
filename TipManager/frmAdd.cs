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
        frmMain m_frmParent;

        private const int ADD_MODE = 0;
        private const int UPDATE_MODE = 1;

        public int m_nMode;       //0 : ADD, 1 : UPDATE

        UPDATE_INFO m_uiInfo;

        //데이터 수정을 위해 정보를 저장할 구조체
        public struct UPDATE_INFO
        {
            public String m_strGroup;
            public String m_strTitle;
            public String m_strKey;
        }
        public frmAdd()
        {
            InitializeComponent();
        }

        private void Init()
        {
            txtTitle.Clear();

            cbGroup.Text = "";
            cbGroup.Items.Clear();

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
                strArrItem = strGroup.Split(';');

                for (nIndex = 0; nIndex < strArrItem.Length; nIndex++)
                    cbGroup.Items.Add(strArrItem[nIndex]);
            }

            if (m_nMode == UPDATE_MODE)
            {
                cbGroup.SelectedText = m_uiInfo.m_strGroup;
                txtTitle.Text = m_uiInfo.m_strTitle;
            }
            else
                cbGroup.SelectedIndex = 0;
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
                string strSeq;
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
        // 부모 설정
        public void SetParent(frmMain frmParent)
        {
            m_frmParent = frmParent;
        }

        public void SetUpdateInfo(String strGroup, String strItem, String strKey)
        {
            m_uiInfo.m_strGroup = strGroup;
            m_uiInfo.m_strTitle = strItem;
            m_uiInfo.m_strKey = strKey;
        }
        // 폼의 사용 용도를 설정한다.(nMode - 0 : Add, 1 : Update)
        public void SetMode(int nMode)
        {

            if (nMode == ADD_MODE)
            {
                this.Text = "팁 추가";
                m_nMode = nMode;
            }
            else
            {
                this.Text = "팁 수정";
                m_nMode = nMode;
            }

        }
    }
}
