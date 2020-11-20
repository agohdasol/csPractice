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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
