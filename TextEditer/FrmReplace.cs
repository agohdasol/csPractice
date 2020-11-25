using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditer
{
    public partial class FrmReplace : Form
    {
        FrmMain m_parentDlg;

        public void Init(TextEditer.FrmMain parentDlg)
        {
            m_parentDlg = parentDlg;
            rdoDown.Checked = true;
        }
        public FrmReplace()
        {
            InitializeComponent();
        }

        private bool FindText()
        {
            int nFind;
            int nLen;
            string strTmpTxt, strTmpFind;

            if (chkCase.Checked)
            {
                strTmpTxt = m_parentDlg.txtMain.Text;
                strTmpFind = txtFind.Text;
            }
            else
            {
                strTmpTxt = m_parentDlg.txtMain.Text.ToLower();
                strTmpFind = txtFind.Text.ToLower();
            }

            nLen = txtFind.Text.Length;

            if (rdoUp.Checked)
            {
                if (m_parentDlg.txtMain.SelectionStart - m_parentDlg.txtMain.SelectionLength < 0)
                    nFind = -1;
                else
                    nFind = strTmpTxt.LastIndexOf(strTmpFind, m_parentDlg.txtMain.SelectionStart - m_parentDlg.txtMain.SelectionLength);
            }
            else
                nFind = strTmpTxt.IndexOf(strTmpFind, m_parentDlg.txtMain.SelectionStart + m_parentDlg.txtMain.SelectionLength);

            if (nFind == -1)
                return false;
            else
            {
                m_parentDlg.txtMain.SelectionStart = nFind;
                m_parentDlg.txtMain.SelectionLength = nLen;
                m_parentDlg.txtMain.Focus();
                return true;
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (!FindText())
                MessageBox.Show("더이상 찾지 못했습니다.");
            else
            {
                m_parentDlg.txtMain.SelectedText = txtReText.Text;
                m_parentDlg.txtMain.SelectionStart = m_parentDlg.txtMain.SelectionStart - txtReText.Text.Length;
                m_parentDlg.txtMain.SelectionLength = txtReText.Text.Length;
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            while (FindText())
                m_parentDlg.txtMain.SelectedText = txtReText.Text;

            MessageBox.Show("모두 바꿨습니다.");
        }
    }
}
