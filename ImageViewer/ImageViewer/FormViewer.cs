﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class FormViewer : Form
    {
        // 전역변수 선언
        int m_nCnt;
        int m_nSelLabel;
        public FormViewer()
        {
            InitializeComponent();
        }

        private int SetDrive()
        {
            String[] strDrives;
            String strTmp;

            // 위로 항목 추가
            lstDir.Items.Add("..", 0);

            // 드라이브 목록 얻기
            strDrives = System.IO.Directory.GetLogicalDrives();

            // 얻어진 드라이브 목록을 리스트뷰에 입력
            foreach (string str in strDrives)
            {
                strTmp = str.Remove(2, 1);
                lstDir.Items.Add(strTmp, 1);
            }

            return lstDir.Items.Count;
        }

        private bool SetFolder(string strParentPath)
        {
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(strParentPath);

            // 리스트뷰의 아이템을 모두 삭제한 후
            lstDir.Items.Clear();

            // 드라이브의 정보를 보여준다
            m_nCnt = SetDrive();
            lblPath.Text = "";

            try
            {
                foreach (System.IO.DirectoryInfo dirInfoCurDir in dirInfo.GetDirectories("*"))
                {
                    lstDir.Items.Add(dirInfoCurDir.Name.ToString(), 2);
                }
                lblPath.Text = strParentPath.Remove(strParentPath.Length - 1, 1);
            }
            catch
            {
                MessageBox.Show("접근에 실패했습니다.");
                return false;
            }

            return true;
        }

        private void SetImgFile(String strParentPath)
        {
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(strParentPath);
            int nCnt;

            splitContainer1.Panel2.Controls.Clear();
            nCnt = 0;

            try
            {
                foreach (System.IO.FileInfo fileInfo in dirInfo.GetFiles("*.*"))
                {
                    if (IsImgFile(fileInfo.Extension))
                    {
                        MakePicCtrl(nCnt, fileInfo.FullName);
                        nCnt += 1;
                        MakeLblCtrl(nCnt, fileInfo.Name);
                        nCnt += 1;
                        Application.DoEvents();
                    }
                }
                lblPath.Text = strParentPath.Remove(strParentPath.Length - 1, 1);
            }
            catch
            {

            }
        }

        private void MakePicCtrl(int nIndex, String strFilePath)
        {
            PictureBox pic = new PictureBox();
            Point pos;

            pic.Name = "pic" + nIndex.ToString();   //이름
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Tag = nIndex.ToString();    //tag 에 컨트롤의 인덱스를 저장
            pic.Size = new Size(80, 80);    //크기

            GetPos(nIndex, out pos);

            pic.Location = pos;
            pic.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Panel2.Controls.Add(pic);   //패널에 추가

            try
            {
                pic.Image = System.Drawing.Bitmap.FromFile(strFilePath);    //그림 보여주기
            }
            catch
            {
                pic.Image = null;
            }

            //클릭/더블클릭 이벤트와 연결
            pic.Click += new System.EventHandler(Ctrl_Click);
            pic.DoubleClick += new System.EventHandler(Ctrl_DoubleClick);
        }

        // 라벨 컨트롤을 생성한다.
        private void MakeLblCtrl(int nIndex, String strFileName)
        {
            Label lbl = new Label();
            Point pos;

            lbl.Name = "lbl" + nIndex.ToString(); // 이름
            lbl.Tag = nIndex.ToString();
            lbl.Size = new Size(80, 20); //크기
            lbl.TextAlign = ContentAlignment.MiddleLeft;

            GetPos(nIndex, out pos);

            lbl.Location = pos;
            lbl.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Panel2.Controls.Add(lbl); // 패널에 추가
            lbl.Text = strFileName; // 그림 이름 보여주기
            lbl.BackColor = Color.GreenYellow;

            // 클릭/더블클릭 이벤트와 연결한다.
            lbl.Click += new System.EventHandler(Ctrl_Click);
            lbl.DoubleClick += new System.EventHandler(Ctrl_DoubleClick);
        }

        private void Ctrl_Click(object sender, EventArgs e)
        {
            PictureBox pic;
            Label lbl;

            if (sender.GetType().Name.IndexOf("PictureBox") != -1) //클릭한 컨트롤이 픽처박스일경우
            {
                pic = (System.Windows.Forms.PictureBox)sender;

                //라벨 컨트롤을 얻는다
                lbl = (System.Windows.Forms.Label)GetCtrl("Label", Convert.ToInt32(pic.Tag) + 1);
            }
            else
            {
                lbl = (System.Windows.Forms.Label)sender;

                //픽쳐박스 컨트롤을 얻는다
                pic = (System.Windows.Forms.PictureBox)GetCtrl("PictureBox", Convert.ToInt32(lbl.Tag) - 1);
            }
            //클릭한 픽쳐박스의 내용을 picSelect에 보여준다
            picSelect.Image = pic.Image;

            //선택한 라벨 컨트롤의 색을 노란색으로 한다
            lbl.BackColor = Color.Yellow;

            //이전에 선택한 라벨 컨트롤의 색을 GreenYellow로 한다.
            if (m_nSelLabel != -1 && m_nSelLabel != Convert.ToInt32(lbl.Tag))
                GetCtrl("Label", m_nSelLabel).BackColor = Color.GreenYellow;

            m_nSelLabel = Convert.ToInt32(lbl.Tag);
        }

        private void Ctrl_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pic;
            Label lbl;

            if(sender.GetType().Name.IndexOf("PictureBox") != -1)   //클릭한 컨트롤이 픽처박스일 경우
            {
                pic = (System.Windows.Forms.PictureBox)sender;

                //라벨 컨트롤을 얻는다
                lbl = (System.Windows.Forms.Label)GetCtrl("Label", Convert.ToInt32(pic.Tag) + 1);
            }
            else //클릭한 컨트롤이 라벨일 경우
            {
                lbl = (System.Windows.Forms.Label)sender;
            }

            //폼을 생성한다.
            ImageViewer.FrmSelect dlg = new ImageViewer.FrmSelect();
            Size sizePic = new Size();

            //폼의 캡션을 그림의 전체 경로로 한다.
            dlg.Text = "그림 선택 - " + lblPath.Text + "\\" + lbl.Text;
            //선택한 그림을 picSel에 보여준다
            dlg.picSel.Image = System.Drawing.Bitmap.FromFile(lblPath.Text + "\\" + lbl.Text);

            //폼의 크기를 적당히 조절한다.
            sizePic = dlg.picSel.Size;
            sizePic.Height += 30;
            sizePic.Width += 15;

            dlg.Size = sizePic;
            dlg.picSel.Location = new Point(5, 5);

            //폼을 모달 형태로 보여준다
            dlg.ShowDialog();
        }

        private void MovePicCtrl()
        {
            int i = 0;
            Point pos;

            Control.ControlCollection myCtrl = splitContainer1.Panel2.Controls;

            foreach(Control ctl in myCtrl)
            {
                GetPos(i, out pos);
                ctl.Location = pos;
                i++;
            }
        }
        private Control GetCtrl(string strCtrlName, int nTag)
        {
            Control.ControlCollection myCtrl = splitContainer1.Panel2.Controls;

            foreach(Control ctl in myCtrl)
            {
                //컨트롤 종류가 일치하고
                if (ctl.GetType().Name.IndexOf(strCtrlName) != -1)
                {
                    //태그가 일치하면
                    if (Convert.ToInt32(ctl.Tag.ToString()) == nTag)
                        return ctl;
                }
            }

            return null;
        }
        private void GetPos(int nIndex, out Point pos)
        {
            pos = new Point();
            Size sizePan = new Size(splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
            int nXCnt;
            int i;

            if ((nIndex % 2) == 0)  //픽쳐박스 컨트롤일 경우
            {
                nXCnt = (int)(sizePan.Width / 85);
                if (nXCnt <= 0)
                    return;

                i = (int)(nIndex / 2) % nXCnt;
                pos.X = (i * 80) + (5 * i) + 5;

                i = (int)(nIndex / 2) / nXCnt;
                pos.Y = (i * 80) + (35 * i) + 5;
            } else
            {
                nXCnt = (int)(sizePan.Width / 85);
                if (nXCnt <= 0)
                    return;

                i = (int)(nIndex / 2) % nXCnt;
                pos.X = (i * 80) + (5 * i) + 5;

                i = (int)(nIndex / 2) / nXCnt;
                pos.Y = (i * 80) + (35 * i) + 5 + 82;
            }
        }

        private bool IsImgFile(String strExi)
        {
            String strTmp;
            strTmp = strExi.ToUpper();
            if (strTmp.IndexOf(".BMP") != -1)
                return true;
            else if (strTmp.IndexOf(".WMF") != -1)
                return true;
            else if (strTmp.IndexOf(".EMF") != -1)
                return true;
            else if (strTmp.IndexOf(".ICO") != -1)
                return true;
            else if (strTmp.IndexOf(".JPG") != -1)
                return true;
            else if (strTmp.IndexOf(".GIF") != -1)
                return true;
            else if (strTmp.IndexOf(".PNG") != -1)
                return true;
            else if (strTmp.IndexOf(".TIF") != -1)
                return true;
            else
                return false;
        }
        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstDir_DoubleClick(object sender, EventArgs e)
        {
            int nSel;
            string strSelText;
            string strTmp;

            // 선택된 항목의 텍스트와 인덱스를 얻는다
            nSel = lstDir.SelectedItems[0].Index;
            strSelText = lstDir.SelectedItems[0].SubItems[0].Text;

            m_nSelLabel = -1;
            picSelect.Image = null;

            if (nSel == 0) //위로
            {
                int nStart;

                nStart = lblPath.Text.LastIndexOf("\\");
                if (nStart == -1)
                    return;

                strTmp = lblPath.Text.Remove(nStart, lblPath.Text.Length - nStart) + "\\";
            }
            else if (m_nCnt > nSel) //드라이브
                strTmp = strSelText = "\\";
            else
                strTmp = lblPath.Text + "\\" + strSelText + "\\";
            
            // 하위 폴더들을 보여준다.
            if (SetFolder(strTmp))
                SetImgFile(strTmp);

            // 툴팁 연결
            tipPath.SetToolTip(lblPath, lblPath.Text);
        }

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            MovePicCtrl();
        }

        private void FormViewer_Load(object sender, EventArgs e)
        {
            SetFolder("C:\\");
            lblPath.Text = "C:";
            SetImgFile("C:\\");
            m_nSelLabel = -1;

            // 툴팁 연결
            tipPath.SetToolTip(lblPath, lblPath.Text);
        }
    }
}
