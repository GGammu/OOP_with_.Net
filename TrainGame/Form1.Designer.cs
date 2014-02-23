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
            this.fire = new System.Windows.Forms.PictureBox();
            this.throttle = new System.Windows.Forms.TrackBar();
            this.train1 = new TrainGame.Train();
            this.track1 = new TrainGame.Track();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttle)).BeginInit();
            this.SuspendLayout();
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
            // throttle
            // 
            this.throttle.LargeChange = 10;
            this.throttle.Location = new System.Drawing.Point(343, 12);
            this.throttle.Maximum = 50;
            this.throttle.Name = "throttle";
            this.throttle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.throttle.Size = new System.Drawing.Size(45, 150);
            this.throttle.SmallChange = 5;
            this.throttle.TabIndex = 3;
            this.throttle.TickFrequency = 10;
            this.throttle.ValueChanged += new System.EventHandler(this.throttle_ValueChanged);
            // 
            // train1
            // 
            this.train1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("train1.BackgroundImage")));
            this.train1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.train1.Location = new System.Drawing.Point(37, 96);
            this.train1.Name = "train1";
            this.train1.Size = new System.Drawing.Size(55, 49);
            this.train1.Speed = 0;
            this.train1.TabIndex = 2;
            this.train1.DistanceChanged += new TrainGame.Train.DistanceChangedEventHandler(this.train1_DistanceChanged);
            // 
            // track1
            // 
            this.track1.FireFrequency = 3;
            this.track1.Location = new System.Drawing.Point(37, 147);
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(216, 15);
            this.track1.TabIndex = 0;
            this.track1.CaughtOnFire += new TrainGame.Track.CaughtOnFireEventHandler(this.track1_CaughtOnFire);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(327, 168);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "New game";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 196);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.throttle);
            this.Controls.Add(this.train1);
            this.Controls.Add(this.track1);
            this.Name = "Form1";
            this.Text = "Train Game";
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Track track1;
        private System.Windows.Forms.PictureBox fire;
        private Train train1;
        private System.Windows.Forms.TrackBar throttle;
        private System.Windows.Forms.Button reset;

    }
}

