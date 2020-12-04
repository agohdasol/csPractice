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
    }
}
