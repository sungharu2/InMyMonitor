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
        Form1 imageForm;
        int imageX;
        int imageY;


        public ConfigForm(Form1 _Form1)
        {
            InitializeComponent();
            //imageX = Form1.pbPNG.
            //imageY =
            imageForm = _Form1;
            this.Show();
        }

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
                    this.lbIsSuccess.Text = "이미지 등록 성공";
                }
            }
        }

        private void btn_Image_X_Click(object sender, EventArgs e)
        {

        }

        private void btn_Image_Y_Click(object sender, EventArgs e)
        {

        }
    }
}
