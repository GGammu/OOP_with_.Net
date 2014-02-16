namespace TrainGame
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Track1 = new TrainGame.Track();
            this.fire = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            this.SuspendLayout();
            // 
            // Track1
            // 
            this.Track1.FireFrequency = 3;
            this.Track1.Location = new System.Drawing.Point(37, 147);
            this.Track1.Name = "Track1";
            this.Track1.Size = new System.Drawing.Size(216, 15);
            this.Track1.TabIndex = 0;
            this.Track1.CaughtOnFire += new TrainGame.Track.CaughtOnFireEventHandler(this.Track1_CaughtOnFire);
            // 
            // fire
            // 
            this.fire.Image = ((System.Drawing.Image)(resources.GetObject("fire.Image")));
            this.fire.InitialImage = null;
            this.fire.Location = new System.Drawing.Point(221, 113);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(32, 32);
            this.fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fire.TabIndex = 1;
            this.fire.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.Track1);
            this.Name = "Form1";
            this.Text = "Train Game";
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Track Track1;
        private System.Windows.Forms.PictureBox fire;

    }
}

