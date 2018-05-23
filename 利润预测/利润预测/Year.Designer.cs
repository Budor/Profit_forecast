namespace 利润预测
{
    partial class Year
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Year));
            this.btnMonth = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtPorfit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetUp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCoal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCompany = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnYear = new System.Windows.Forms.Button();
            this.configDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configDictionaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnMonth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMonth.FlatAppearance.BorderSize = 0;
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.Location = new System.Drawing.Point(30, 126);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(120, 40);
            this.btnMonth.TabIndex = 2;
            this.btnMonth.Text = "月度利润预测";
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(10, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "预测利润(万元)：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(10, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "营业收入(万元)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "原煤(万吨)：";
            // 
            // txtIncome
            // 
            this.txtIncome.BackColor = System.Drawing.Color.White;
            this.txtIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIncome.Font = new System.Drawing.Font("宋体", 18F);
            this.txtIncome.ForeColor = System.Drawing.Color.Black;
            this.txtIncome.Location = new System.Drawing.Point(182, 200);
            this.txtIncome.MaxLength = 8;
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(167, 28);
            this.txtIncome.TabIndex = 105;
            // 
            // txtPorfit
            // 
            this.txtPorfit.BackColor = System.Drawing.Color.White;
            this.txtPorfit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPorfit.Font = new System.Drawing.Font("宋体", 18F);
            this.txtPorfit.ForeColor = System.Drawing.Color.Black;
            this.txtPorfit.Location = new System.Drawing.Point(182, 250);
            this.txtPorfit.MaxLength = 8;
            this.txtPorfit.Name = "txtPorfit";
            this.txtPorfit.Size = new System.Drawing.Size(167, 28);
            this.txtPorfit.TabIndex = 106;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(334, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 108;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnSetUp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 33);
            this.panel1.TabIndex = 110;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnSetUp
            // 
            this.btnSetUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.btnSetUp.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSetUp.FlatAppearance.BorderSize = 0;
            this.btnSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUp.Image = ((System.Drawing.Image)(resources.GetObject("btnSetUp.Image")));
            this.btnSetUp.Location = new System.Drawing.Point(268, 0);
            this.btnSetUp.Name = "btnSetUp";
            this.btnSetUp.Size = new System.Drawing.Size(36, 33);
            this.btnSetUp.TabIndex = 138;
            this.btnSetUp.UseVisualStyleBackColor = false;
            this.btnSetUp.Click += new System.EventHandler(this.btnSetUp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 28);
            this.label9.TabIndex = 137;
            this.label9.Text = "龙   山   煤   矿";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(299, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 33);
            this.button2.TabIndex = 111;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCoal
            // 
            this.txtCoal.BackColor = System.Drawing.Color.White;
            this.txtCoal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoal.Font = new System.Drawing.Font("宋体", 20F);
            this.txtCoal.Location = new System.Drawing.Point(166, 67);
            this.txtCoal.MaxLength = 8;
            this.txtCoal.Name = "txtCoal";
            this.txtCoal.Size = new System.Drawing.Size(183, 31);
            this.txtCoal.TabIndex = 104;
            this.txtCoal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCoal_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCompany);
            this.panel2.Location = new System.Drawing.Point(-15, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 119);
            this.panel2.TabIndex = 111;
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbCompany.Location = new System.Drawing.Point(145, 9);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(113, 12);
            this.lbCompany.TabIndex = 115;
            this.lbCompany.Text = "安阳龙鑫煤业规划部";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(355, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 288);
            this.panel3.TabIndex = 112;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(-34, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 322);
            this.panel4.TabIndex = 113;
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnYear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnYear.FlatAppearance.BorderSize = 0;
            this.btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.Location = new System.Drawing.Point(209, 126);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(120, 40);
            this.btnYear.TabIndex = 114;
            this.btnYear.Text = "年度利润预测";
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click_1);
            // 
            // configDictionaryBindingSource
            // 
            this.configDictionaryBindingSource.DataSource = typeof(Common.ConfigDictionary);
            // 
            // Year
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 313);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCoal);
            this.Controls.Add(this.txtPorfit);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Year";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "利润预测";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Year_FormClosing);
            this.Load += new System.EventHandler(this.Year_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Year_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configDictionaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource configDictionaryBindingSource;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox txtPorfit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCoal;
        private System.Windows.Forms.Button btnSetUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Label lbCompany;
    }
}