using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanoi
{
    public partial class frmMain : Form
    {
        // 블럭 위치/크기 설정
        const int BLOCK_START_X = 10;
        const int BLOCK_START_Y = 200;
        const int BLOCK_WIDTH = 160;
        const int BLOCK_HEIGHT = 30;

        string m_strDragTag;
        int m_nMoveCnt;

        //PictureBox 생성
        //pan 컨트롤에 추가
        private void MakeBlock(Panel pan, int nIndex, int nImage, bool bMoving)
        {
            PictureBox pic;
            int i;
            
            pic = new PictureBox();
            pan.Controls.Add(pic);

            pic.Size = new Size(BLOCK_WIDTH, BLOCK_HEIGHT);
            pic.Location = new Point(BLOCK_START_X, 0); //우선 최상단에 위치시킴
            pic.SizeMode = PictureBoxSizeMode.CenterImage;
            pic.BackColor = Color.FromArgb(213, 236, 253);

            //조건에 맞는 이미지 저장
            pic.Image = new Bitmap(GetType(), "h" + nImage.ToString() + ".bmp");

            //tag 값은 가장 아래 있는 컨트롤이 0이 됨
            //앞자리는 panLeft : 0 panCenter : 1 panRight : 2
            if (pan == panLeft)
                pic.Tag = "0" + nImage.ToString();
            else if (pan == panCenter)
                pic.Tag = "1" + nImage.ToString();
            else
                pic.Tag = "2" + nImage.ToString();

            //pic를 제 위치로 이동
            //위에서 아래로 떨어지는 효과
            if (bMoving)
            {
                for (i = 0; i < BLOCK_START_Y - (nIndex * BLOCK_HEIGHT); i += 2)
                {
                    pic.Location = new Point(BLOCK_START_X, i);
                    Application.DoEvents();
                }
            }
            else
                pic.Location = new Point(BLOCK_START_X, BLOCK_START_Y - (nIndex * BLOCK_HEIGHT));

            pic.MouseDown += new MouseEventHandler(pic_MouseDown);
        }

        private void RemoveBlock(string strTag)
        {
            Panel pan;
            int i;

            pan = GetPanCtrl(strTag);

            //Tag 값을 비교해 삭제
            for(i=0; i < pan.Controls.Count; i++)
            {
                if (pan.Controls[i].Tag.ToString().Equals(strTag))
                    pan.Controls.RemoveAt(i);
            }
        }

        private Panel GetPanCtrl(string strTag)
        {
            if (strTag.ToString().Substring(0, 1) == "0")
                return panLeft;
            else if (strTag.ToString().Substring(0, 1) == "1")
                return panCenter;
            else
                return panRight;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsGameEnd(Convert.ToInt32(nudCnt.Value))) return;

            if(e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;

                if (IsDragPic(pic))
                {
                    m_strDragTag = pic.Tag.ToString();

                    //모든 Panel 의 AllowDrop을 true로
                    panLeft.AllowDrop = true;
                    panCenter.AllowDrop = true;
                    panRight.AllowDrop = true;

                    //현재 클릭한 pic의 부모 패널은 false
                    GetPanCtrl(pic.Tag.ToString()).AllowDrop = false;

                    pic.DoDragDrop(pic.Image, DragDropEffects.Move);
                }
                else
                    m_strDragTag = "";
            }
        }

        private bool IsDragPic(PictureBox pic)
        {
            int i, nMax;
            Panel pan;

            pan = GetPanCtrl(pic.Tag.ToString());
            nMax = 1;

            //패널에 있는 pic 컨트롤의 최대 수를 구함
            for (i = 0; i < pan.Controls.Count; i++)
            {
                if (Convert.ToInt32(pan.Controls[i].Tag.ToString().Substring(1, 1)) > nMax)
                    nMax = Convert.ToInt32(pan.Controls[i].Tag.ToString().Substring(1, 1));
            }

            //비교값이 컨트롤의 tag과 같으면 true
            if (nMax == Convert.ToInt32(pic.Tag.ToString().Substring(1, 1)))
                return true;
            else
                return false;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pan_DragEnter(object sender, DragEventArgs e)
        {
            //데이터를 검사
            if(e.Data.GetDataPresent(DataFormats.Bitmap) && m_strDragTag != "")
            {
                Panel pan;
                pan = (Panel)sender;

                if (IsDragEnter(pan, m_strDragTag))
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private bool IsDragEnter(Panel pan, string strTag)
        {
            int i, nMax;
            nMax = 1;

            //패널에 있는 pic 컨트롤의 최대 수를 구함
            for (i = 0; i < pan.Controls.Count; i++)
            {
                if (Convert.ToInt32(pan.Controls[i].Tag.ToString().Substring(1, 1)) > nMax)
                    nMax = Convert.ToInt32(pan.Controls[i].Tag.ToString().Substring(1, 1));
            }

            //비어있는 panel이면 true
            if (nMax == 1) return true;

            //비교값이 컨트롤의 tag값보다 더 작을때
            //드래그한 블럭이 더 좁은 블록이면
            if (nMax < Convert.ToInt32(strTag.ToString().Substring(1, 1)))
                return true;
            else
                return false;
        }

        private void pan_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && m_strDragTag != "")
            {
                int nCnt;
                Panel pan;

                pan = (Panel)sender;

                //Drop할 Panel에 PictureBox개수를 저장
                nCnt = pan.Controls.Count;

                //이동한 블럭 삭제
                RemoveBlock(m_strDragTag);

                //pic 생성
                MakeBlock(pan, nCnt, Convert.ToInt32(m_strDragTag.ToString().Substring(1, 1)), true);

                m_nMoveCnt += 1;
                lblCnt.Text = m_nMoveCnt.ToString();


                //게임종료검사
                if (IsGameEnd(Convert.ToInt32(nudCnt.Value)))
                    MessageBox.Show("게임종료");
            }
        }

        private bool IsGameEnd(int nCnt)
        {
            //오른쪽 패널 블럭재수가 전체 블럭개수와 같으면 종료
            if (panRight.Controls.Count == nCnt)
                return true;
            else
                return false;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            InitHanoi(Convert.ToInt32(nudCnt.Value));

            AutoHanoi(Convert.ToInt32(nudCnt.Value), panLeft, panCenter, panRight);
        }

        //자동으로 블럭 이동
        //재귀호출 이용
        private void AutoHanoi(int nCnt, Panel panFrom, Panel panBy, Panel panTo)
        {
            if (nCnt == 1)
                MoveBlock(panFrom, panTo);
            else
            {
                AutoHanoi(nCnt - 1, panFrom, panTo, panBy);
                MoveBlock(panFrom, panTo);
                AutoHanoi(nCnt - 1, panBy, panFrom, panTo);
            }
        }

        private void MoveBlock(Panel panFrom, Panel panTo)
        {
            //panFrom의 최상위 pic을 찾음
            //최상위 pic은 tag의 두번째자리가 가장 큰 경우
            int i, nMax;
            PictureBox picMax = new PictureBox();

            nMax = 1;

            //패널에 있는 pic 컨트롤의 최대수를 구함
            for (i = 0; i < panFrom.Controls.Count; i++)
            {
                if (Convert.ToInt32(panFrom.Controls[i].Tag.ToString().Substring(1, 1)) > nMax)
                    nMax = Convert.ToInt32(panFrom.Controls[i].Tag.ToString().Substring(1, 1));
                picMax = (PictureBox)panFrom.Controls[i];
            }

            //찾은 pic을 옮김
            int nCnt;
            //Drop할 Panel에 PictureBox 개수 저장
            nCnt = panTo.Controls.Count;

            //이동한 블럭 삭제
            RemoveBlock(picMax.Tag.ToString());

            //pic을 만든다
            MakeBlock(panTo, nCnt, Convert.ToInt32(picMax.Tag.ToString().Substring(1, 1)), true);

            m_nMoveCnt += 1;
            lblCnt.Text = m_nMoveCnt.ToString() + " 번";

            //게임종료검사
            if (IsGameEnd(Convert.ToInt32(nudCnt.Value)))
                MessageBox.Show("게임종료");
        }

        // 블럭 갯수에 맞게 하노이탑을 초기화 한다.
        private void InitHanoi(int nCnt)
        {
            int i;

            // 우선 Panel에 있는 컨트롤을을 삭제한다.
            panLeft.Controls.Clear();
            panCenter.Controls.Clear();
            panRight.Controls.Clear();

            // panLeft에 PictureBox 컨트롤을 생성 한다.
            for (i = 0; i < nCnt; i++)
                MakeBlock(panLeft, i, i, false);

            m_nMoveCnt = 0;
            lblCnt.Text = m_nMoveCnt.ToString() + " 번";
        }
    }
}
