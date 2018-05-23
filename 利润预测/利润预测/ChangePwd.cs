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
using Control;
using Common;
namespace 利润预测
{
    public partial class ChangePwd : SkinMain
    {
        Calculate cal = new Calculate();
        public ChangePwd()
        {
            InitializeComponent();
        }

        private void ChangePwd_Load(object sender, EventArgs e)
        {

        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            string old = this.txtOld.Text;
            string news=this.txtNew.Text;
            if (old==cal.getPraviteValue("pwd"))
            {
                ConfigDictionary.privateList["pwd"] = news;
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误！");
                this.txtOld.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
