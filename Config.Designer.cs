namespace InMyMonitor
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.btnSetImage = new System.Windows.Forms.Button();
            this.lbIsSuccess = new System.Windows.Forms.Label();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.lbScale = new System.Windows.Forms.Label();
            this.btn_changeSize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.gbControl.SuspendLayout();
            this.gbImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetImage
            // 
            this.btnSetImage.Location = new System.Drawing.Point(160, 18);
            this.btnSetImage.Name = "btnSetImage";
            this.btnSetImage.Size = new System.Drawing.Size(91, 23);
            this.btnSetImage.TabIndex = 0;
            this.btnSetImage.Text = "이미지 등록..";
            this.btnSetImage.UseVisualStyleBackColor = true;
            this.btnSetImage.Click += new System.EventHandler(this.btnSetImage_Click);
            // 
            // lbIsSuccess
            // 
            this.lbIsSuccess.AutoSize = true;
            this.lbIsSuccess.Location = new System.Drawing.Point(22, 23);
            this.lbIsSuccess.Name = "lbIsSuccess";
            this.lbIsSuccess.Size = new System.Drawing.Size(97, 12);
            this.lbIsSuccess.TabIndex = 1;
            this.lbIsSuccess.Text = "새 이미지 만들기";
            this.lbIsSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxWidth
            // 
            this.tbxWidth.AcceptsReturn = true;
            this.tbxWidth.Location = new System.Drawing.Point(49, 18);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(133, 21);
            this.tbxWidth.TabIndex = 2;
            this.tbxWidth.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "가로 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.lbScale);
            this.gbControl.Controls.Add(this.btn_changeSize);
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Controls.Add(this.label1);
            this.gbControl.Controls.Add(this.tbxHeight);
            this.gbControl.Controls.Add(this.tbxWidth);
            this.gbControl.Location = new System.Drawing.Point(12, 145);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(251, 152);
            this.gbControl.TabIndex = 3;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "조절";
            // 
            // lbScale
            // 
            this.lbScale.AutoSize = true;
            this.lbScale.Location = new System.Drawing.Point(6, 126);
            this.lbScale.Name = "lbScale";
            this.lbScale.Size = new System.Drawing.Size(75, 12);
            this.lbScale.TabIndex = 4;
            this.lbScale.Text = "크기 비율 : 1";
            // 
            // btn_changeSize
            // 
            this.btn_changeSize.Location = new System.Drawing.Point(188, 16);
            this.btn_changeSize.Name = "btn_changeSize";
            this.btn_changeSize.Size = new System.Drawing.Size(57, 51);
            this.btn_changeSize.TabIndex = 3;
            this.btn_changeSize.Text = "변경";
            this.btn_changeSize.UseVisualStyleBackColor = true;
            this.btn_changeSize.Click += new System.EventHandler(this.btn_changeSize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "세로 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxHeight
            // 
            this.tbxHeight.Location = new System.Drawing.Point(49, 46);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(133, 21);
            this.tbxHeight.TabIndex = 2;
            this.tbxHeight.Text = "0";
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.btnSetImage);
            this.gbImage.Controls.Add(this.lbIsSuccess);
            this.gbImage.Location = new System.Drawing.Point(12, 12);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(257, 127);
            this.gbImage.TabIndex = 3;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "이미지";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(12, 330);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(149, 24);
            this.lbDescription.TabIndex = 4;
            this.lbDescription.Text = "투명도가 적용된 이미지는 \r\n깨져 나올수도 있습니다.";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 363);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.gbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.Text = "Config";
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbImage.ResumeLayout(false);
            this.gbImage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetImage;
        private System.Windows.Forms.Label lbIsSuccess;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btn_changeSize;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbScale;
    }
}