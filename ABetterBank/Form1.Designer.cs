namespace ABetterBank
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.ComboBox();
            this.action = new System.Windows.Forms.ComboBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.addInterest = new System.Windows.Forms.Button();
            this.printStatement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(14, 120);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // account
            // 
            this.account.FormattingEnabled = true;
            this.account.Location = new System.Drawing.Point(110, 18);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(187, 20);
            this.account.TabIndex = 4;
            this.account.SelectedIndexChanged += new System.EventHandler(this.account_SelectedIndexChanged);
            // 
            // action
            // 
            this.action.FormattingEnabled = true;
            this.action.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.action.Location = new System.Drawing.Point(110, 49);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(187, 20);
            this.action.TabIndex = 5;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(110, 82);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(187, 21);
            this.amount.TabIndex = 6;
            // 
            // addInterest
            // 
            this.addInterest.Location = new System.Drawing.Point(121, 120);
            this.addInterest.Name = "addInterest";
            this.addInterest.Size = new System.Drawing.Size(85, 23);
            this.addInterest.TabIndex = 7;
            this.addInterest.Text = "Add interest";
            this.addInterest.UseVisualStyleBackColor = true;
            this.addInterest.Click += new System.EventHandler(this.addInterest_Click);
            // 
            // printStatement
            // 
            this.printStatement.Location = new System.Drawing.Point(222, 120);
            this.printStatement.Name = "printStatement";
            this.printStatement.Size = new System.Drawing.Size(75, 23);
            this.printStatement.TabIndex = 8;
            this.printStatement.Text = "Print";
            this.printStatement.UseVisualStyleBackColor = true;
            this.printStatement.Click += new System.EventHandler(this.printStatement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 168);
            this.Controls.Add(this.printStatement);
            this.Controls.Add(this.addInterest);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.action);
            this.Controls.Add(this.account);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox account;
        private System.Windows.Forms.ComboBox action;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button addInterest;
        private System.Windows.Forms.Button printStatement;
    }
}

