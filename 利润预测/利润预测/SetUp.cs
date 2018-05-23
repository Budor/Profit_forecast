using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using Common;
using Control;

namespace 利润预测
{
    public partial class SetUp : SkinMain
    {
        public static bool flag = false;
        public SetUp()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txt1_1.ReadOnly == true)
            {
                ConfigDictionary.InitializationConfig();
                this.Close();

            }
            else
            {
                MessageBox.Show("请保存参数！");
            }
        }

        #region 移动窗体
        private Point mPoint = new Point();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            }
        }
        #endregion

        private void SetUp_Load(object sender, EventArgs e)
        {
            InitializationTxtBox();//重绘文本框边框
        }

        #region 初始化控件的值
        /// <summary>
        /// 初始化参数控件的值
        /// </summary>
        private void InitializationTxtBox()
        {
            Calculate cal = new Calculate();
            this.txt1_1.Text = cal.getvalue("FineCoalPrice").ToString();
            this.txt1_2.Text = cal.getvalue("FineCoalRecoveryCoefficient").ToString();
            this.txt2_1.Text = cal.getvalue("LumpCoalPrice").ToString();
            this.txt2_2.Text = cal.getvalue("LumpCoalRecoveryCoefficient").ToString();
            this.txt3_1.Text = cal.getvalue("RawCoalPrice").ToString();
            this.txt3_2.Text = cal.getvalue("RawCoalRecoveryCoefficient").ToString();
            this.txt4_1.Text = cal.getvalue("SlimePrice").ToString();
            this.txt4_2.Text = cal.getvalue("SlimeRecoveryCoefficient").ToString();
            this.txt5_1.Text = cal.getvalue("MoGanPrice").ToString();
            this.txt5_2.Text = cal.getvalue("MoGanRecoveryCoefficient").ToString();

            this.txt6.Text = cal.getvalue("CostBasis").ToString();
            this.txt7.Text = cal.getvalue("TaxCoefficient").ToString();
            this.txt8.Text = cal.getvalue("MonthCostCoefficient").ToString();
            this.txt9.Text = cal.getvalue("YearCostCoefficient").ToString();
            this.txtCompany.Text = cal.getPraviteValue("company").ToString();
        }
        #endregion

        #region 重绘文本框边框


        private void SetUp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 155, 0), 2.0f);
            foreach (System.Windows.Forms.Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    g.DrawRectangle(pen, new Rectangle(ctr.Location, ctr.Size));
                }
            }
            pen.Dispose();
        }
        #endregion

        #region 限制文本框输入内容

        private void txt1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt1_1, e);

        }

        private void txt1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt1_2, e);

        }

        private void txt2_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt2_1, e);

        }

        private void txt2_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt2_2, e);

        }

        private void txt3_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt3_1, e);

        }

        private void txt3_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt3_2, e);

        }

        private void txt4_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt4_1, e);

        }

        private void txt4_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt4_2, e);

        }

        private void txt5_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt5_1, e);

        }

        private void txt5_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt5_2, e);

        }

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt6, e);

        }

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt7, e);

        }

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt8, e);

        }

        private void txt9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txt9, e);

        }


        #endregion


        #region 修改字典的值
        /// <summary>
        /// 修改字典的值
        /// </summary>
        private bool ChangeDictionaries()
        {
            bool flag = true;
            try
            {

                if (Convert.ToDouble(this.txt1_1.Text) > 0 && flag == true)
                {
                    ConfigDictionary.configList["FineCoalPrice"] = Convert.ToDouble(this.txt1_1.Text);
                    if (Convert.ToDouble(this.txt1_2.Text) > 0 && flag == true)
                    {
                        ConfigDictionary.configList["FineCoalRecoveryCoefficient"] = Convert.ToDouble(this.txt1_2.Text);
                        if (Convert.ToDouble(this.txt2_1.Text) > 0 && flag == true)
                        {
                            ConfigDictionary.configList["LumpCoalPrice"] = Convert.ToDouble(this.txt2_1.Text);
                            if (Convert.ToDouble(this.txt2_2.Text) > 0 && flag == true)
                            {
                                ConfigDictionary.configList["LumpCoalRecoveryCoefficient"] = Convert.ToDouble(this.txt2_2.Text);
                                if (Convert.ToDouble(this.txt3_1.Text) > 0 && flag == true)
                                {
                                    ConfigDictionary.configList["RawCoalPrice"] = Convert.ToDouble(this.txt3_1.Text);
                                    if (Convert.ToDouble(this.txt3_2.Text) > 0 && flag == true)
                                    {
                                        ConfigDictionary.configList["RawCoalRecoveryCoefficient"] = Convert.ToDouble(this.txt3_2.Text);
                                        if (Convert.ToDouble(this.txt4_1.Text) > 0 && flag == true)
                                        {
                                            ConfigDictionary.configList["SlimePrice"] = Convert.ToDouble(this.txt4_1.Text);
                                            if (Convert.ToDouble(this.txt4_2.Text) > 0 && flag == true)
                                            {
                                                ConfigDictionary.configList["SlimeRecoveryCoefficient"] = Convert.ToDouble(this.txt4_2.Text);
                                                if (Convert.ToDouble(this.txt5_1.Text) > 0 && flag == true)
                                                {
                                                    ConfigDictionary.configList["MoGanPrice"] = Convert.ToDouble(this.txt5_1.Text);
                                                    if (Convert.ToDouble(this.txt5_2.Text) > 0 && flag == true)
                                                    {
                                                        ConfigDictionary.configList["MoGanRecoveryCoefficient"] = Convert.ToDouble(this.txt5_2.Text);
                                                        if (Convert.ToDouble(this.txt6.Text) > 0 && flag == true)
                                                        {
                                                            ConfigDictionary.configList["CostBasis"] = Convert.ToDouble(this.txt6.Text);
                                                            if (Convert.ToDouble(this.txt7.Text) > 0 && flag == true)
                                                            {
                                                                ConfigDictionary.configList["TaxCoefficient"] = Convert.ToDouble(this.txt7.Text);
                                                                if (Convert.ToDouble(this.txt8.Text) > 0 && flag == true)
                                                                {
                                                                    ConfigDictionary.configList["MonthCostCoefficient"] = Convert.ToDouble(this.txt8.Text);
                                                                    if (Convert.ToDouble(this.txt9.Text) > 0 && flag == true)
                                                                    {
                                                                        ConfigDictionary.configList["YearCostCoefficient"] = Convert.ToDouble(this.txt9.Text);
                                                                        if (this.txtCompany.Text != null && flag == true)
                                                                        {
                                                                            ConfigDictionary.privateList["company"] = this.txtCompany.Text;
                                                                        }
                                                                        else
                                                                        {
                                                                            flag = false;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        flag = false;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    flag = false;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                flag = false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            flag = false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        flag = false;
                                                    }
                                                }
                                                else
                                                {
                                                    flag = false;
                                                }
                                            }
                                            else
                                            {
                                                flag = false;
                                            }
                                        }
                                        else
                                        {
                                            flag = false;
                                        }
                                    }
                                    else
                                    {
                                        flag = false;
                                    }
                                }
                                else
                                {
                                    flag = false;
                                }
                            }
                            else
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;








        }

        #endregion

        #region 解除/固定 控件修改状态
        /// <summary>
        /// 解除/固定 控件修改状态
        /// </summary>
        /// <param name="b">为真则解除，否则固定</param>
        private void TxtBoxState(bool b)
        {
            if (b)
            {
                this.txt1_1.ReadOnly = false;
                this.txt1_2.ReadOnly = false;
                this.txt2_1.ReadOnly = false;
                this.txt2_2.ReadOnly = false;
                this.txt3_1.ReadOnly = false;
                this.txt3_2.ReadOnly = false;
                this.txt4_1.ReadOnly = false;
                this.txt4_2.ReadOnly = false;
                this.txt5_1.ReadOnly = false;
                this.txt5_2.ReadOnly = false;
                this.txt6.ReadOnly = false;
                this.txt7.ReadOnly = false;
                this.txt8.ReadOnly = false;
                this.txt9.ReadOnly = false;
                this.txtCompany.ReadOnly = false;
            }
            else
            {
                this.txt1_1.ReadOnly = true;
                this.txt1_2.ReadOnly = true;
                this.txt2_1.ReadOnly = true;
                this.txt2_2.ReadOnly = true;
                this.txt3_1.ReadOnly = true;
                this.txt3_2.ReadOnly = true;
                this.txt4_1.ReadOnly = true;
                this.txt4_2.ReadOnly = true;
                this.txt5_1.ReadOnly = true;
                this.txt5_2.ReadOnly = true;
                this.txt6.ReadOnly = true;
                this.txt7.ReadOnly = true;
                this.txt8.ReadOnly = true;
                this.txt9.ReadOnly = true;
                this.txtCompany.ReadOnly = true;
            }
        }

        #endregion

        private void btnChange_Click(object sender, EventArgs e)
        {


            if (this.btnChange.Text == "修改参数")
            {
                Pwd pwd = new Pwd();
                pwd.ShowDialog();
                if (flag)
                {
                    this.TxtBoxState(true);
                    this.btnChange.Text = "保存参数";
                }
                else
                {
                    this.btnChange.Text = "修改参数";

                }

            }
            else
            {
                flag = false;
                if (this.ChangeDictionaries())
                {
                    this.TxtBoxState(false);
                    this.btnChange.Text = "修改参数";
                }
                else
                {
                    MessageBox.Show("参数必须大于零！");

                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.btnChange.Text == "保存参数")
            {
                MessageBox.Show("请先保存参数！");
            }
            else
            {
                ChangePwd cha = new ChangePwd();
                cha.ShowDialog();
            }
            
        }
    }
}
