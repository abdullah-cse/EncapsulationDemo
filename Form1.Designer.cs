namespace EncapsulationDemo
{
    partial class FormHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWithdraw = new System.Windows.Forms.TextBox();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdrow = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encapsulation Example";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pubali Bank Ltd";
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeposit.Location = new System.Drawing.Point(17, 34);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxDeposit.Size = new System.Drawing.Size(198, 32);
            this.textBoxDeposit.TabIndex = 2;
            this.textBoxDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "TK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 40);
            this.label5.TabIndex = 7;
            this.label5.Text = "TK";
            // 
            // textBoxWithdraw
            // 
            this.textBoxWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWithdraw.Location = new System.Drawing.Point(20, 40);
            this.textBoxWithdraw.Name = "textBoxWithdraw";
            this.textBoxWithdraw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxWithdraw.Size = new System.Drawing.Size(198, 32);
            this.textBoxWithdraw.TabIndex = 5;
            this.textBoxWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(17, 72);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(198, 43);
            this.buttonDeposit.TabIndex = 11;
            this.buttonDeposit.Text = "Confirm";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithdrow
            // 
            this.buttonWithdrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrow.Location = new System.Drawing.Point(20, 78);
            this.buttonWithdrow.Name = "buttonWithdrow";
            this.buttonWithdrow.Size = new System.Drawing.Size(198, 43);
            this.buttonWithdrow.TabIndex = 12;
            this.buttonWithdrow.Text = "Confirm";
            this.buttonWithdrow.UseVisualStyleBackColor = true;
            this.buttonWithdrow.Click += new System.EventHandler(this.buttonWithdrow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeposit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDeposit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 138);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxWithdraw);
            this.groupBox2.Controls.Add(this.buttonWithdrow);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(444, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 138);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Withdraw";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonQuery);
            this.groupBox3.Controls.Add(this.textBoxBalance);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(283, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 152);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Balance Query";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuery.Location = new System.Drawing.Point(15, 81);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(262, 43);
            this.buttonQuery.TabIndex = 13;
            this.buttonQuery.Text = "Show Balance";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBalance.Location = new System.Drawing.Point(14, 35);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxBalance.Size = new System.Drawing.Size(263, 32);
            this.textBoxBalance.TabIndex = 12;
            this.textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "TK";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 534);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encapsulation Example";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWithdraw;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdrow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textBoxBalance;
    }
}

