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
            this.btnSetImage = new System.Windows.Forms.Button();
            this.lbIsSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetImage
            // 
            this.btnSetImage.Location = new System.Drawing.Point(41, 72);
            this.btnSetImage.Name = "btnSetImage";
            this.btnSetImage.Size = new System.Drawing.Size(159, 23);
            this.btnSetImage.TabIndex = 0;
            this.btnSetImage.Text = "이미지 등록";
            this.btnSetImage.UseVisualStyleBackColor = true;
            this.btnSetImage.Click += new System.EventHandler(this.btnSetImage_Click);
            // 
            // lbIsSuccess
            // 
            this.lbIsSuccess.AutoSize = true;
            this.lbIsSuccess.Location = new System.Drawing.Point(57, 118);
            this.lbIsSuccess.Name = "lbIsSuccess";
            this.lbIsSuccess.Size = new System.Drawing.Size(133, 12);
            this.lbIsSuccess.TabIndex = 1;
            this.lbIsSuccess.Text = "이미지 등록을 해주세요";
            this.lbIsSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 165);
            this.Controls.Add(this.lbIsSuccess);
            this.Controls.Add(this.btnSetImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfigForm";
            this.Text = "Config";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetImage;
        private System.Windows.Forms.Label lbIsSuccess;
    }
}