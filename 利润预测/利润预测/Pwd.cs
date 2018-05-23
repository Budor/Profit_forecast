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
    public partial class Pwd : SkinMain
    {
        public  bool flag = false;

        Calculate cal = new Calculate();
        public Pwd()
        {
            InitializeComponent();
        }
        

        private void Pwd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            string password = this.textBox1.Text;
            string pwd = cal.getPraviteValue("pwd");
            if (password==pwd)
            {
                SetUp.flag = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误");
            }
        }
    }
}
