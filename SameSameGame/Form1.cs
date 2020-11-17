using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SameSameGame
{
    public partial class Form1 : Form
    {
        int[,] m_nBlock = new int[20, 10];
        int[] m_nSel = new int[200]; //선택된 블럭(인접한 같은모양의 블럭) 저장
        bool[,] m_bVisit = new bool[20, 10];  // 방문했는지 표시
        int m_nSameCnt; //인접한 같은 모양의 갯수
        int m_nPointBlock; //현재 마우스 포인터가 위치한 블럭의 그림
        int m_nPointIndex; //현재 마우스 포인터가 위치한 블럭의 인덱스

        int m_nBlockCnt; // 남은 블럭 갯수
        int m_nScore; // 점수

        Random m_rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void FindSameBlock(int nX, int nY)
        {
            //위로 찾기
            if(nY > 0)
            {
                if ((m_nBlock[nX, nY - 1 ] == m_nPointBlock) && m_bVisit[nX, nY - 1] == false)
                {
                    m_nSel[m_nSameCnt] = (nY - 1) * 20 + nX;    //2차원 배열 좌표를 index로 변환
                    m_nSameCnt += 1;
                    m_bVisit[nX, nY - 1] = true;
                    FindSameBlock(nX, nY - 1);
                }
            }

            //아래로 찾기
            if (nY < 9)
            {
                if ((m_nBlock[nX, nY + 1] == m_nPointBlock) && m_bVisit[nX, nY + 1] == false)
                {
                    m_nSel[m_nSameCnt] = (nY + 1) * 20 + nX;    //2차원 배열 좌표를 index로 변환
                    m_nSameCnt += 1;
                    m_bVisit[nX, nY + 1] = true;
                    FindSameBlock(nX, nY + 1);
                }
            }

            //왼쪽으로 찾기
            if (nX > 0)
            {
                if ((m_nBlock[nX - 1, nY] == m_nPointBlock) && m_bVisit[nX - 1, nY] == false)
                {
                    m_nSel[m_nSameCnt] = nY * 20 + (nX - 1);    //2차원 배열 좌표를 index로 변환
                    m_nSameCnt += 1;
                    m_bVisit[nX - 1, nY] = true;
                    FindSameBlock(nX - 1, nY);
                }
            }

            //오른쪽으로 찾기
            if (nX < 19)
            {
                if ((m_nBlock[nX + 1, nY] == m_nPointBlock) && m_bVisit[nX + 1, nY] == false)
                {
                    m_nSel[m_nSameCnt] = nY * 20 + (nX + 1);    //2차원 배열 좌표를 index로 변환
                    m_nSameCnt += 1;
                    m_bVisit[nX + 1, nY] = true;
                    FindSameBlock(nX + 1, nY);
                }
            }
        }

        private void MoveY()
        {
            int i, j;
            int nIndex;
            int nX, nY;
            bool[] bX = new bool[20];

            for(i=0; i<20; i++)
            {
                nIndex = m_nSel[i];

                nX = nIndex % 20;
                nY = (int)(nIndex / 20);

                int nEmptyY;
                nEmptyY = -1;

                //아래에서 위쪽으로 빈칸을 찾는다
                //찾은 빈칸의 위에도 계속 빈칸이면 무시한다
                for(j=9; j>0; j--)
                {
                    if (m_nBlock[nX, j] == -1 && m_nBlock[nX, j-1] != -1)
                    {
                        nEmptyY = j;
                        break;
                    }
                }

                //빈칸을 찾은경우
                if (nEmptyY != -1)
                {
                    //그림을 한칸씩 아래로 내려준다
                    for (j = nEmptyY; j > 0; j--)
                        m_nBlock[nX, j] = m_nBlock[nX, j - 1];
                    m_nBlock[nX, 0] = -1;
                }
            }

            PictureBox pic;

            //정리된 결과를 화면에 출력
            for(i=0; i<m_nSameCnt; i++)
            {
                nIndex = m_nSel[i] % 20;
                nX = nIndex % 20;
                nY = (int)(nIndex / 20);

                if (bX[nX] == false) //정리한 곳인지 검사
                {
                    bX[nX] = true;

                    // -1이 저장된 컨트롤의 Visible을 false, 아닌것을 true
                    for(j=9; j>=0; j--)
                    {
                        if(m_nBlock[nX, j] == -1)
                            //그림을 지우고
                            panMain.Controls[j * 20 - +nX].Visible = false;
                        else //그림을 다시 채운다
                        {
                            if (panMain.Controls[j * 20 + nX].Visible == false)
                                panMain.Controls[j * 20 + nX].Visible = true;
                            pic = (PictureBox)panMain.Controls[j * 20 + nX];
                            pic.Image = imglstBlock.Images[m_nBlock[nX, j]];
                        }

                    }
                }
            }
        }

        private void MoveX()
        {
            int i, j;
            int nIndex;
            int nX, nY;
            bool bY;
            int nMinX;
            nMinX = 19;
            bY = false;

            //맨아래(nY=9)가 비어있으면 한 줄이 비어있음
            for (i = 0; i < m_nSameCnt; i++)
            {
                nIndex = m_nSel[i];

                nX = nIndex % 20;
                nY = (int)(nIndex / 20);

                //맨아래칸이 삭제된경우
                if(nY == 9)
                {
                    int nEmptyX;
                    nEmptyX = -1;
                    for(j=0; j<19; j++)
                    {
                        if(m_nBlock[j, 9] == -1 && m_nBlock[j + 1, 9] != -1)
                        {
                            nEmptyX = j;
                            if(nMinX > nEmptyX)
                            {
                                nMinX = nEmptyX;
                                break;
                            }
                        }
                    }
                    //오른쪽의 블럭을 옮긴다
                    if (nEmptyX != -1)
                    {
                        bY = true;
                        int k;
                        for(j=nEmptyX; j<20; j++)
                        {
                            for(k=0; k<10; k++)
                            {
                                if (j == 19)
                                    m_nBlock[j, k] = -1;
                                else
                                    m_nBlock[j, k] = m_nBlock[j + 1, k];
                            }
                        }
                    }
                }
                
            }

            //빈칸이 없음 블럭 옮길 필요 없음
            if (bY == false) return;

            PictureBox pic;
            for(i=nMinX; i<20; i++)
            {
                for(j=0; j<10; j++)
                {
                    nIndex = i + j * 20;
                    pic = (PictureBox)panMain.Controls[nIndex];

                    if (m_nBlock[i, j] == -1)
                    {
                        if (pic.Visible)
                            pic.Visible = false;
                    }
                    else
                    {
                        if (pic.Visible == false)
                            pic.Visible = true;
                        pic.Image = imglstBlock.Images[m_nBlock[i, j]];
                    }
                }
            }
        }

        private bool IsGameEnd()
        {
            int i = 0, j = 0;

            for(i=1; i < 19; i++)
            {
                for (j = 1; j < 9; j++)
                {
                    //왼쪽, 오른쪽, 위, 아래 순 검사
                    if(m_nBlock[i,j] != -1)
                    {
                        if (m_nBlock[i, j] == m_nBlock[i - 1, j]) return false;
                        if (m_nBlock[i, j] == m_nBlock[i + 1, j]) return false;
                        if (m_nBlock[i, j] == m_nBlock[i, j - 1]) return false;
                        if (m_nBlock[i, j] == m_nBlock[i, j + 1]) return false;
                    }
                }
            }
            return true;
        }

        private void SetScore()
        {
            string strScore;
            int i, nCnt;

            strScore = m_nScore.ToString();
            nCnt = strScore.Length;
            //자리수 맞추기
            for (i = 0; i < 5 - nCnt; i++)
                strScore = "0" + strScore;

            picScore1.Image = imglstNum.Images[Convert.ToInt32(strScore.Substring(4, 1))];
            picScore2.Image = imglstNum.Images[Convert.ToInt32(strScore.Substring(3, 1))];
            picScore3.Image = imglstNum.Images[Convert.ToInt32(strScore.Substring(2, 1))];
            picScore4.Image = imglstNum.Images[Convert.ToInt32(strScore.Substring(1, 1))];
            picScore5.Image = imglstNum.Images[Convert.ToInt32(strScore.Substring(0, 1))];
        }

        private void SetBlock()
        {
            string strBlock;
            int i, nCnt;

            strBlock = m_nBlockCnt.ToString();
            nCnt = strBlock.Length;
            for (i = 0; i < 3 - nCnt; i++)
                strBlock = "0" + strBlock;

            picBlock1.Image = imglstNum.Images[Convert.ToInt32(strBlock.Substring(2, 1))];
            picBlock2.Image = imglstNum.Images[Convert.ToInt32(strBlock.Substring(1, 1))];
            picBlock3.Image = imglstNum.Images[Convert.ToInt32(strBlock.Substring(0, 1))];
        }

        private void MakePicCtrl(int nIndex)
        {
            PictureBox pic = new PictureBox();
            Point pos = new Point();
            int nX, nY;

            //인덱스를 배열의 x, y 위치로 변환
            nX = nIndex % 20;
            nY = (int)(nIndex / 20);

            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //tag에 컨트롤의 인덱스를 저장
            pic.Tag = nIndex.ToString();
            pic.Size = new Size(30, 30);
            //위치 저장
            pic.Location = new Point((nX * 30), (nY * 30));
            panMain.Controls.Add(pic);  //패널에 추가

            //클릭/더블클릭 이벤트와 연결
            pic.Click += new System.EventHandler(Ctrl_Click);
            //마우스 무브 이벤트와 연결
            pic.MouseMove += new System.Windows.Forms.MouseEventHandler(Ctrl_MouseMove);
        }

        private void initGame()
        {
            int i = 0;
            int nRndNum;
            PictureBox pic;

            //픽쳐박스 설정
            Control.ControlCollection myCtrl = panMain.Controls;

            foreach(Control ctl in myCtrl)
            {
                pic = (System.Windows.Forms.PictureBox)ctl;
                pic.Visible = true;
                //블럭 종류 얻기(랜덤)
                nRndNum = GetRndBlock();
                //실제 이미지 설정

                pic.Image = imglstBlock.Images[nRndNum];
                //이미지에 맞는 숫자를 배열에 설정
                m_nBlock[i % 20, (int)(i / 20)] = nRndNum;
                m_nSel[i] = -1;
                i++;
            }

            m_nPointBlock = -1;
            m_nPointIndex = -1;

            m_nBlockCnt = 200;
            m_nScore = 0;

            SetScore();
            SetBlock();
        }

        //랜덤함수를 이용해 블럭모양 얻기
        private int GetRndBlock()
        {
            return m_rnd.Next(0, 4);
        }

        //동적 생성 picturebox의 mousemove 이벤트
        private void Ctrl_MouseMove(object sender, MouseEventArgs e)
        {
            int nX, nY;
            int i, j;
            PictureBox pic;

            //원본 그림 표시
            if(m_nSameCnt > 1 && m_nPointBlock >= 0)
            {
                for (i = 0; i < m_nSameCnt; i++)
                {
                    pic = (PictureBox)panMain.Controls[m_nSel[i]];
                    pic.Image = imglstBlock.Images[m_nPointBlock];
                }
            }

            //방문자는 false로 세팅
            for (i = 0; i < 20; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    m_bVisit[i, j] = false;
                }
            }
            pic = (PictureBox)sender;
            //블럭의 인덱스를 얻는다
            m_nPointIndex = Convert.ToInt32(pic.Tag.ToString());

            //인덱스를 배열의 x,y위치로 변환
            nX = m_nPointIndex % 20;
            nY = (int)(m_nPointIndex / 20);

            //블럭 종류 저장
            m_nPointBlock = m_nBlock[nX, nY];

            if (m_nPointBlock == -1) return;

            //방문 표시
            m_bVisit[nX, nY] = true;
            m_nSameCnt = 0;
            m_nSel[m_nSameCnt] = m_nPointIndex;
            m_nSameCnt += 1;
            //인접한 같은 블럭들을 찾는다
            FindSameBlock(nX, nY);

            //같은 그림들을 선택한 그림으로 표시
            if (m_nSameCnt > 1 && m_nPointBlock >= 0)
            {
                for (i = 0; i < m_nSameCnt; i++)
                {
                    pic = (PictureBox)panMain.Controls[m_nSel[i]];
                    pic.Image = imglstSel.Images[m_nPointBlock];
                }
            }
        }

        private void Ctrl_Click(object sender, EventArgs e)
        {
            int i;
            int nX, nY;
            int nIndex;

            //블럭을 삭제(-1 저장)
            if (m_nSameCnt > 1 && m_nPointBlock >= 0)
            {
                for (i = 0; i < m_nSameCnt; i++)
                {
                    nIndex = m_nSel[i];
                    //지워진 블럭에 -1 저장
                    nX = nIndex % 20;
                    nY = (int)(nIndex / 20);
                    m_nBlock[nX, nY] = -1;
                }

                //블럭 위치 재설정
                MoveY();
                MoveX();

                //점수 및 남은블럭 계산
                m_nBlockCnt -= m_nSameCnt;
                SetBlock();
                m_nScore += (m_nSameCnt - 2) * (m_nSameCnt - 2);
                SetScore();

                if (IsGameEnd())
                {
                    if(MessageBox.Show("게임이 끝났습니다. 다시하시겠습니까?", "셈셈 게임", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        initGame();
                    }
                }
            }

            m_nSameCnt = -1;
            m_nPointIndex = -1;
        }
    }
}
