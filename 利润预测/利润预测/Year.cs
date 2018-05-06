using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Common;
using Model;

using System.Configuration;
using CCWin;
namespace 利润预测
{
    public partial class Year : SkinMain
    {
        
        public Year()
        {
            InitializeComponent();
        }

       

        

       

        private void btnMonth_Click(object sender, EventArgs e)
        {

            //double income;
            //double porfit;

            if (this.txtCoal.Text.Length>0)
            {
                Calculate calculate = new Calculate(Convert.ToDouble(this.txtCoal.Text),Data.Month);
                this.txtIncome.Text = Math.Round(calculate.profit.Income, 2).ToString();
                this.txtPorfit.Text = Math.Round(calculate.profit.Profit1).ToString();
            }
            else
            {
                MessageBox.Show("请输入原煤！");
            }
            //this.txtIncome.Text=calculate.
        }




       

        private void Year_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("???");
           
            //进度条页面
            Begin begion = new Begin();
            begion.ShowDialog();
            //重绘TextBox边框
            this.Paint+=Year_Paint;

           
        }

       

              
        private void txtCoal_Enter(object sender, EventArgs e)
        {
            this.txtCoal.Clear();
        }


       

        
        

        #region 关闭窗口时事件： 更改配置文件的值
        /// <summary>
        /// 关闭窗口时事件： 更改配置文件的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Year_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigDictionary.InitializationConfig();

        } 
        #endregion


        #region txtCoal_KeyPress事件： 只输入数字
        /// <summary>
        /// 限制文本框只输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCoal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Detection.OnlyNum(this.txtCoal, e);

        } 
        #endregion

        #region 移动窗体
        private Point mPoint = new Point();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        #region 最小化窗体

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        #endregion

        #region 重新绘制TextBox边框
        private void Year_Paint(object sender, PaintEventArgs e)
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

        private void btnSetUp_Click(object sender, EventArgs e)
        {
            SetUp setup = new SetUp();
            setup.ShowDialog();

            this.txtCoal.Clear();
            this.txtIncome.Clear();
            this.txtPorfit.Clear();
        }

        private void btnYear_Click_1(object sender, EventArgs e)
        {
            if (this.txtCoal.Text.Length > 0)
            {
                Calculate calculate = new Calculate(Convert.ToDouble(this.txtCoal.Text), Data.Year);
                this.txtIncome.Text = Math.Round(calculate.profit.Income, 2).ToString();
                this.txtPorfit.Text = Math.Round(calculate.profit.Profit1).ToString();
            }
            else
            {
                MessageBox.Show("请输入原煤！");
            }
        }

        

      
       
       
        

      

        

    }


}
