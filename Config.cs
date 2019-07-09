/*

이미지를 제어하는 설정 폼
 
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

namespace InMyMonitor
{
    public partial class ConfigForm : Form
    {
        // 이미지 폼
        Form1 imageForm;
        // 트랙바
        TrackBar track;
        // 이미지 정보
        string imagePath;
        int imageX;
        int imageY;


        public ConfigForm(Form1 _Form1)
        {
            InitializeComponent();
            // 크기 비율 조절 트랙바 생성
            track = new TrackBar();
            track.Parent = this.gbControl;
            // 눈금자 표시 OFF
            track.TickStyle = TickStyle.None;
            // 스크롤 값 설정
            track.Maximum = 100;
            track.Value = 50;
            track.Size = new Size(230, 100);
            track.Location = new Point(6, 80);
            track.Scroll += new EventHandler(trackBar_Scroll);
            track.Show();

            // 이미지 정보 초기화
            initImageInfo(_Form1);
            _Form1.configForm = this;
            this.Show();
        }

        // 트랙바 값이 스크롤 될 때마다 실행
        void trackBar_Scroll(object sender, EventArgs e)
        {
            // 스크롤 값에 따른 스케일 비율 값 설정
            double scale = (double)(track.Value / 50.0);
            // 값 반영
            this.lbScale.Text = "크기 비율 : " + scale.ToString();
            this.tbxWidth.Text = ((int)(imageX * scale)).ToString();
            this.tbxHeight.Text = ((int)(imageY * scale)).ToString();
        }

        // 이미지 폼에 이 설정 폼 전달... 무언가 방법이 잘못댐
        public ConfigForm dontMindMe()
        {
            return this;
        }

        // 이미지가 바뀔 때 정보 초기화
        public void initImageInfo(Form1 _Form1)
        {
            // Image Form 로드
            imageForm = _Form1;
            // 이미지 경로 받아와 이미지 크기 저장
            imagePath = Form1.imagePath;
            imageX = Form1.imageSize.Width;
            imageY = Form1.imageSize.Height;

            // 사이즈 텍스트로 출력
            this.tbxWidth.Text = imageX.ToString();
            this.tbxHeight.Text = imageY.ToString();
        }

        
        int ResizeImage()
        {
            // 현재 이미지 불러오고
            Image origin = Image.FromFile(imagePath);
            // 이미지 크기 조절 후 반환
            Image dest = new Bitmap(origin, imageX, imageY);

            return imageForm.SetPicture(dest);
        }

        // 새 이미지 등록
        private void btnSetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImage = new OpenFileDialog();
            ofdImage.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            ofdImage.Title = "이미지 파일 열기";
            ofdImage.FileName = "Some Image";
            ofdImage.Filter = "Image File|*.PNG";
            
            DialogResult dr = ofdImage.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (imageForm.SetPicture(ofdImage.FileName) == -1)
                {
                    this.lbIsSuccess.Text = "이미지 등록 오류";
                }
                else
                {
                    // 새 이미지 등록에 성공하면 이미지 정보 갱신
                    initImageInfo(imageForm);
                    this.lbIsSuccess.Text = "이미지 등록 성공";
                }
            }
        }

        // 입력된 사이즈로 이미지 사이즈 변경
        private void btn_changeSize_Click(object sender, EventArgs e)
        {
            track.Value = 50;
            this.lbScale.Text = "크기 비율 : 1";
            // 사이즈가 0일 경우
            if (imageX <= 0 || imageY <= 0)
            {
                // 이미지 숨김
                imageForm.imageEnable(false);
            }
            else
            {
                // 이미지 보이기
                imageForm.imageEnable(true);
                imageX = Convert.ToInt32(this.tbxWidth.Text);
                imageY = Convert.ToInt32(this.tbxHeight.Text);
                // 리사이즈한 이미지로 교체
                ResizeImage();
                // 이미지 정보 갱신
                initImageInfo(imageForm);
            }
        }
    }
}
