/*

이미지 플로팅 프로그램 - 최태현

모니터 전체를 폼으로 하여 PictureBox 안에서 이미지를 드래그할 수 있도록 하는 프로그램

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace InMyMonitor
{
    public partial class Form1 : Form
    {
        // 설정 폼과 정보 공유하기 위해 저장
        public ConfigForm configForm;

        // 이미지 드래그시 이용할 두 좌표
        private Point startPoint = Point.Empty;
        private Point movePoint = Point.Empty;
        bool isClick = false;

        // 이미지를 띄울 PictureBox
        public static PictureBox pbImage;  

        // 이미지 정보 저장
        public static string imagePath;
        public static Size imageSize;

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(SystemInformation.VirtualScreen.Width,
                            SystemInformation.VirtualScreen.Height);
            // PicutureBox 생성
            InitPicture(@"..\..\Image.png");
        }

        // PictureBox 생성 및 초기화
        private int InitPicture(string path)
        {
            try
            {
                pbImage = new PictureBox
                {
                    // 필수!! 부모로 폼을 등록해야 이미지가 보임
                    Parent = this,
                    // PictureBox의 배경을 투명하게 하면 PNG 파일 출력 가능, 
                    // 하지만 투명도가 1 ~ 99%면 배경색과 섞여 나오므로 완전히 투명하진 않음
                    BackColor = Color.Transparent,
                    // 이미지가 화면 전체를 드나들도록 모니터 크기만큼 사이즈 설정
                    Size = new Size(SystemInformation.VirtualScreen.Width,
                                SystemInformation.VirtualScreen.Height),
                    Location = new Point(0, 0)
                };
                // 기본 이미지 설정
                SetPicture(path);

                // 이벤트 핸들러 추가
                pbImage.MouseDown += new MouseEventHandler(this.pbImage_MouseDown);
                pbImage.MouseMove += new MouseEventHandler(this.pbImage_MouseMove);
                pbImage.MouseUp += new MouseEventHandler(this.pbImage_MouseUp);
                pbImage.MouseClick += new MouseEventHandler(this.pbImage_MouseClick);
                pbImage.Paint += new PaintEventHandler(this.pbImage_Paint);

                // 로딩 완료 후 보이기
                pbImage.Show();
                return 0;
            }
            catch 
            {
                return -1;
            }
        }

        // 이미지 경로를 통한 이미지 교체
        public int SetPicture(string path)
        {
            if (File.Exists(path))
            {
                // PictureBox가 없다면 재생성
                if (pbImage.IsDisposed == true)
                {
                    return InitPicture(path);
                }
                pbImage.Image = Image.FromFile(path);
                // 이미지 정보 저장
                imagePath = path;
                imageSize = getImageSize(path);
                return 0;
            }
            else
            {
                MessageBox.Show(imagePath + "\n이미지 파일이 존재하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // 이미지 변수를 통한 이미지 교체
        public int SetPicture(Image image)
        {
            try
            {
                pbImage.Image = image;
                // 이미지 사이즈 저장
                imageSize = image.Size;
                configForm.initImageInfo(this);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        // 이미지 경로를 통해 사이즈 알아내기
        public Size getImageSize(string imagePath)
        {
            Image image = Image.FromFile(imagePath);
            return new Size(image.Width, image.Height);
        }


        // 이미지 드래그 시 이동
        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isClick = true;
                // 이동한 거리 계산용 좌표
                this.startPoint = new Point(e.Location.X - movePoint.X, e.Location.Y - movePoint.Y);
            }
        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClick)
            {
                // 이동될 거리 계산 후 Invalidate 함수 호출
                this.movePoint = new Point(e.Location.X - startPoint.X, e.Location.Y - startPoint.Y);
                pbImage.Invalidate();
            }
        }

        private void pbImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (isClick) isClick = false;
        }

        // 이미지가 이동하여 Invalidate 메시지를 받을 때마다 새로 이미지를 그려는 함수
        private void pbImage_Paint(object sender, PaintEventArgs e)
        {
            // 이전 이미지 clear
            e.Graphics.Clear(Color.Green);
            if (pbImage.Image != null)
            {
                // 계산된 좌표로 새로 이미지 그리기
                e.Graphics.DrawImage(pbImage.Image, movePoint);
            }
            else
            {
                DialogResult r = MessageBox.Show("이미지 오류가 발생했습니다.", "오류",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                // 무시
                if (r == DialogResult.Retry)
                {
                    return;
                }
                // 중단
                else if (r == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }

        // 이미지 활성화/비활성화
        public void imageEnable(bool flag)
        {
            if (flag == true)
            {
                pbImage.Show();
            }
            else
            {
                pbImage.Hide();
            }
        }


        // 이미지 마우스 우클릭시 메뉴 생성
        private void pbImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // 트레이 메뉴 보이기
                this.cmsImageMenu.Show(new Point(e.X, e.Y));
            }
        }

        // 트레이 메뉴, 클릭 시 실행
        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 설정 창 ON과 함께 불러온 설정 폼 저장
            configForm = new ConfigForm(this);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 프로그램 종료 시 트레이 아이콘이 남는 것을 방지
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyIcon.Dispose();
        }
        
        // 여러 이미지 복제 기능 추가 예정
        private void DuplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 이미지 리소스 제거
            pbImage.Dispose();
        }
    }
}
