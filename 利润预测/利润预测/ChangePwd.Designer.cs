namespace 利润预测
{
    partial class ChangePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePwd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnYear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 33);
            this.panel1.TabIndex = 112;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 149);
            this.panel2.TabIndex = 112;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(271, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 149);
            this.panel3.TabIndex = 113;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 137;
            this.label9.Text = "修改密码";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(261, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 108;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 113;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label2.Location = new System.Drawing.Point(27, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 114;
            this.label2.Text = "新密码：";
            // 
            // txtOld
            // 
            this.txtOld.Font = new System.Drawing.Font("宋体", 14F);
            this.txtOld.Location = new System.Drawing.Point(117, 65);
            this.txtOld.Name = "txtOld";
            this.txtOld.PasswordChar = '*';
            this.txtOld.Size = new System.Drawing.Size(137, 29);
            this.txtOld.TabIndex = 115;
            // 
            // txtNew
            // 
            this.txtNew.Font = new System.Drawing.Font("宋体", 14F);
            this.txtNew.Location = new System.Drawing.Point(117, 105);
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '*';
            this.txtNew.Size = new System.Drawing.Size(137, 29);
            this.txtNew.TabIndex = 116;
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnYear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnYear.FlatAppearance.BorderSize = 0;
            this.btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.Location = new System.Drawing.Point(96, 154);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(97, 28);
            this.btnYear.TabIndex = 118;
            this.btnYear.Text = "确定";
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(263, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 180);
            this.panel4.TabIndex = 119;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(-12, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(326, 180);
            this.panel5.TabIndex = 120;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(-15, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(45, 180);
            this.panel6.TabIndex = 121;
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePwd";
            this.Load += new System.EventHandler(this.ChangePwd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}