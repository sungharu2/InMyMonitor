﻿using System;
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
        private Point startPoint = Point.Empty;
        private Point movePoint = Point.Empty;
        bool isClick = false;

        public PictureBox pbPNG;

        Size imageSize;

        public Form1()
        {
            InitializeComponent();
            InitPicture();
            this.FormBorderStyle = FormBorderStyle.None;
            // 기본 Form을 투명하게 하기 위해 배경색 조정
            this.BackColor = Color.Green;
            this.TransparencyKey = Color.Green;
            // 기본 이미지 설정
            SetPicture(@"..\..\Image.png");
        }

        private void InitPicture()
        {
            pbPNG = new PictureBox();
            pbPNG.BackColor = Color.Transparent;
            pbPNG.Size = new Size(System.Windows.Forms.SystemInformation.VirtualScreen.Width,
                            System.Windows.Forms.SystemInformation.VirtualScreen.Height);
            pbPNG.Location = new Point(0, 0);
            pbPNG.Image = Image.FromFile(@"..\..\Image.png");

            pbPNG.MouseDown += new MouseEventHandler(this.pbPNG_MouseDown);
            pbPNG.MouseMove += new MouseEventHandler(this.pbPNG_MouseMove);
            pbPNG.MouseUp += new MouseEventHandler(this.pbPNG_MouseUp);
            pbPNG.Paint += new PaintEventHandler(this.pbPNG_Paint);

            pbPNG.Show();
        }

        public int SetPicture(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                this.pbPNG.Image = Image.FromFile(imagePath);
                return 0;
            }
            else
            {
                MessageBox.Show(imagePath + "\n이미지 파일이 존재하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // 이미지 드래그 시 이동 시킬 함수
        private void pbPNG_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isClick = true;
                this.startPoint = new Point(e.Location.X - movePoint.X, e.Location.Y - movePoint.Y);
            }
        }

        private void pbPNG_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClick)
            {
                this.movePoint = new Point(e.Location.X - startPoint.X, e.Location.Y - startPoint.Y);
                this.pbPNG.Invalidate();
            }
        }

        private void pbPNG_MouseUp(object sender, MouseEventArgs e)
        {
            if (isClick) isClick = false;
        }

        // 이미지가 이동하여 Invalidate 메시지를 받을 때마다 새로 이미지를 그려는 함수
        private void pbPNG_Paint(object sender, PaintEventArgs e)
        {
            //이전 이미지 clear
            e.Graphics.Clear(Color.Green);
            if (this.pbPNG.Image != null)
            {
                e.Graphics.DrawImage(this.pbPNG.Image, movePoint);
            }
        }

        // 트레이 아이콘 클릭 시 실행
        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 설정 창 On
            ConfigForm configForm = new ConfigForm(this);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 프로그램 종료 시 트레이 아이콘이 남는 것을 방지 메모리 완벽 제거
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyIcon.Dispose();
        }
    }
}
