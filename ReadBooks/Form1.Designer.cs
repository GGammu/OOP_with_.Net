namespace ReadMoreBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.listOfBooks = new System.Windows.Forms.ListBox();
            this.page = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pageLength = new System.Windows.Forms.NumericUpDown();
            this.pageToDisplay = new System.Windows.Forms.NumericUpDown();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageToDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of books";
            // 
            // listOfBooks
            // 
            this.listOfBooks.FormattingEnabled = true;
            this.listOfBooks.ItemHeight = 12;
            this.listOfBooks.Location = new System.Drawing.Point(12, 24);
            this.listOfBooks.Name = "listOfBooks";
            this.listOfBooks.Size = new System.Drawing.Size(161, 124);
            this.listOfBooks.TabIndex = 1;
            this.listOfBooks.SelectedIndexChanged += new System.EventHandler(this.listOfBooks_SelectedIndexChanged);
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(201, 24);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(151, 124);
            this.page.TabIndex = 2;
            this.page.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Page length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Page to display";
            // 
            // pageLength
            // 
            this.pageLength.Location = new System.Drawing.Point(12, 201);
            this.pageLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageLength.Name = "pageLength";
            this.pageLength.Size = new System.Drawing.Size(120, 21);
            this.pageLength.TabIndex = 6;
            this.pageLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pageToDisplay
            // 
            this.pageToDisplay.Location = new System.Drawing.Point(201, 201);
            this.pageToDisplay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageToDisplay.Name = "pageToDisplay";
            this.pageToDisplay.Size = new System.Drawing.Size(120, 21);
            this.pageToDisplay.TabIndex = 7;
            this.pageToDisplay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(199, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 12);
            this.titleLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pageToDisplay);
            this.Controls.Add(this.pageLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.page);
            this.Controls.Add(this.listOfBooks);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Read Books";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageToDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listOfBooks;
        private System.Windows.Forms.RichTextBox page;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown pageLength;
        private System.Windows.Forms.NumericUpDown pageToDisplay;
        private System.Windows.Forms.Label titleLabel;

    }
}

