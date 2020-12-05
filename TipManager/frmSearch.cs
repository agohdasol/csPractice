using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipManager
{
    public partial class frmSearch : Form
    {
        //부모(frmMain)를 가리킬 객체
        frmMain m_frmParent;
        public frmSearch()
        {
            InitializeComponent();
        }
        // 부모 설정
        public void SetParent(frmMain frmParent)
        {
            m_frmParent = frmParent;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("검색어를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string strSQL = "";

            if (rbtnTitle.Checked)
            {
                strSQL = "SELECT TF_SEQ, TF_TITLE, TF_GROUP FROM TIP WHERE TF_TITLE LIKE '%";
                strSQL += txtSearch.Text;
                strSQL += "%' ORDER BY TF_TITLE ASC";
            }
            else if (rbtnGroup.Checked)
            {
                strSQL = "SELECT TF_SEQ, TF_TITLE, TF_GROUP FROM TIP WHERE TF_TITLE LIKE '%";
                strSQL += txtSearch.Text;
                strSQL += "%' ORDER BY TF_GROUP ASC";
            }
            else if (rbtnNote.Checked)
            {
                strSQL = "SELECT TF_SEQ, TF_TITLE, TF_GROUP FROM TIP WHERE TF_TITLE LIKE '%";
                strSQL += txtSearch.Text;
                strSQL += "%' ORDER BY TF_SEQ ASC";
            }
            m_frmParent.ShowResultList(true);

            m_frmParent.lblResult.Text = txtSearch.Text;
            m_frmParent.GetSearchResult(strSQL);

            this.Close();
        }
    }
}
