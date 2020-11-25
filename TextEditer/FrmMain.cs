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
    public partial class FrmMain : Form
    {
        // 텍스트 문서를 저장할 컬랙션
        System.Collections.Specialized.StringDictionary m_colText = new System.Collections.Specialized.StringDictionary();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            treeText.Nodes.Add(new TreeNode("문서목록", 0, 0));
        }

        //새로만들기
        private void MenuFileNew_Click(object sender, EventArgs e)
        {
            string str;
            int nIndex;

            //New Text 삽입
            str = "New Text" + m_colText.Count.ToString();

            //컬렉션 항목에도 삽입
            m_colText.Add(str, "");
            nIndex = treeText.Nodes[0].Nodes.Add(new TreeNode(str, 1, 2));
            //삽입한 항목 선택
            treeText.SelectedNode = treeText.Nodes[0].Nodes[nIndex];
        }

        //열기
        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            string strTxtPath;
            string strText;
            int nIndex;

            //파일 오픈 다이얼로그를 연다
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                strTxtPath = fileDlg.FileName;

                if (GetFileText(strTxtPath, out strText))
                {
                    m_colText.Add(strTxtPath, strText);

                    //트리 추가
                    nIndex = treeText.Nodes[0].Nodes.Add(new TreeNode(strTxtPath, 1, 2));
                    //추가항목 선택
                    treeText.SelectedNode = treeText.Nodes[0].Nodes[nIndex];
                }
                else
                    MessageBox.Show(strTxtPath + " 파일 오픈에 실패했습니다.");
            }
        }
        //파일을 열어서 내용을 얻는다.
        //반환:성공/실패

        private bool GetFileText(string strPath, out string strText)
        {
            System.IO.FileStream fileTxt;
            //기본 인코딩 타입 얻기
            System.Text.Encoding enc = System.Text.Encoding.Default;

            //파일 오픈
            fileTxt = System.IO.File.Open(strPath, System.IO.FileMode.Open);

            bool b;
            //파일 오픈 실패
            if (fileTxt == null)
            {
                strText = "";
                b = false;
            }
            else
            {
                //파일 내용을 String으로 변경
                Byte[] bytes = new Byte[fileTxt.Length + 1];
                fileTxt.Read(bytes, 0, (int)fileTxt.Length);
                strText = enc.GetString(bytes);
                fileTxt.Close();
                b = true;
            }
            return b;
        }

        private void treeText_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == treeText.Nodes[0])
            {
                txtMain.Text = "";
                txtMain.Enabled = false;
            }
            else
            {
                txtMain.Text = m_colText[e.Node.Text];
                txtMain.Enabled = true;
            }
        }

        private void treeText_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (treeText.SelectedNode == null)
                return;

            if (treeText.SelectedNode != treeText.Nodes[0])
            {
                //원래있던 아이템 삭제
                m_colText.Remove(treeText.SelectedNode.Text);
                //새 값을 다시 Add
                m_colText.Add(treeText.SelectedNode.Text, txtMain.Text);
                txtMain.Enabled = true;
            }
        }

        private void MenuFileSave_Click(object sender, EventArgs e)
        {
            if (treeText.SelectedNode == treeText.Nodes[0])
                return;

            string strPath;

            strPath = treeText.SelectedNode.Text;
            if (strPath.IndexOf("\\") == -1)
                SaveAsFile();
            else
                SaveFile(strPath);

        }
        private void SaveFile(string strPath)
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(strPath);
            System.IO.FileStream fileTxt;

            //기본 인코딩 타입 얻기
            System.Text.Encoding enc = System.Text.Encoding.Default;

            //기존파일삭제
            if (fileInfo != null)
                fileInfo.Delete();

            //파일 저장
            fileTxt = System.IO.File.Open(strPath, System.IO.FileMode.OpenOrCreate);
            fileTxt.Write(enc.GetBytes(txtMain.Text), 0, enc.GetByteCount(txtMain.Text));

            fileTxt.Close();
        }

        private void SaveAsFile()
        {
            if (treeText.SelectedNode == treeText.Nodes[0])
                return;
            string strPath;
            string strDir, strFile;
            string strTxtPath;

            strPath = treeText.SelectedNode.Text;

            if (strPath.IndexOf("\\") == -1)
                saveDlg.FileName = strPath + ".txt";
            else
            {
                //폴더와 파일명 분리
                strDir = strPath.Substring(0, strPath.LastIndexOf("\\"));
                strFile = strPath.Substring(strPath.LastIndexOf("\\"), strPath.Length - strPath.LastIndexOf("\\"));
                strFile = strFile.Remove(0, 1);
                saveDlg.InitialDirectory = strDir;
                saveDlg.FileName = strFile;
            }

            //파일패스를 얻는다
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                strTxtPath = saveDlg.FileName;
                SaveFile(strTxtPath);
            }
        }

        private void MenuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            int nCnt;
            int i;
            string strPath;
            nCnt = treeText.Nodes[0].GetNodeCount(true);

            //노드의 갯수만큼 루프를 돌린다
            for (i = 0; i < nCnt; i++)
            {
                strPath = treeText.Nodes[0].Nodes[i].Text;
                treeText.SelectedNode = treeText.Nodes[0].Nodes[i];
                if(MessageBox.Show(strPath+" 파일을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (strPath.IndexOf("\\") == -1)
                        SaveAsFile();
                    else
                        SaveFile(strPath);
                }
            }
        }

        private void MenuEditCut_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtMain.SelectedText);
            txtMain.SelectedText = "";
        }

        private void MenuEditCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtMain.SelectedText);
        }

        private void MenuEditDelete_Click(object sender, EventArgs e)
        {
            txtMain.SelectedText = "";
        }

        private void MenuEditPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                txtMain.SelectedText = Clipboard.GetDataObject().GetData(DataFormats.Text, true).ToString();

        }

        private void MenuEditAll_Click(object sender, EventArgs e)
        {
            txtMain.SelectAll();
        }

        private void MenuEditTime_Click(object sender, EventArgs e)
        {
            txtMain.SelectedText = DateTime.Now.ToLongTimeString();
        }

        private void MenuEditDown_Click(object sender, EventArgs e)
        {
            txtMain.SelectedText = txtMain.SelectedText.ToLower();
        }

        private void MenuEditUp_Click(object sender, EventArgs e)
        {
            txtMain.SelectedText = txtMain.SelectedText.ToUpper();
        }
    }
}
