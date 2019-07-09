namespace InMyMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsImageMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DuplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTrayMenu.SuspendLayout();
            this.cmsImageMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "WA!";
            this.notifyIcon.BalloonTipTitle = "Sans!";
            this.notifyIcon.ContextMenuStrip = this.cmsTrayMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "In My Monitor";
            this.notifyIcon.Visible = true;
            // 
            // cmsTrayMenu
            // 
            this.cmsTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.cmsTrayMenu.Name = "cmsTrayMenu";
            this.cmsTrayMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.설정ToolStripMenuItem.Text = "Settings";
            this.설정ToolStripMenuItem.Click += new System.EventHandler(this.설정ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.종료ToolStripMenuItem.Text = "Exit";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // cmsImageMenu
            // 
            this.cmsImageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DuplicateToolStripMenuItem,
            this.DeleteToolStripMenuItem1});
            this.cmsImageMenu.Name = "cmsImageMenu";
            this.cmsImageMenu.Size = new System.Drawing.Size(126, 48);
            // 
            // DuplicateToolStripMenuItem
            // 
            this.DuplicateToolStripMenuItem.Name = "DuplicateToolStripMenuItem";
            this.DuplicateToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.DuplicateToolStripMenuItem.Text = "Duplicate";
            this.DuplicateToolStripMenuItem.Click += new System.EventHandler(this.DuplicateToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem1
            // 
            this.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1";
            this.DeleteToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.DeleteToolStripMenuItem1.Text = "Delete";
            this.DeleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "InMyMonitor";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.cmsTrayMenu.ResumeLayout(false);
            this.cmsImageMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmsTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsImageMenu;
        private System.Windows.Forms.ToolStripMenuItem DuplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem1;
    }
}

