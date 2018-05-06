using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    /// <summary>
    /// 检测，判断输入时候合法
    /// </summary>
    public static class Detection
    {
        #region 限制文本框输入数字 + public static bool OnlyNum(TextBox convent, KeyPressEventArgs e)
        /// <summary>
        /// 限制文本框只能输入数字、小数点、退格
        /// </summary>
        /// <param name="convent">需要限制的文本框</param>
        /// <param name="e">按键</param>
        /// <returns></returns>
        public static bool OnlyNum(TextBox convent, KeyPressEventArgs e)
        {
            e.Handled = true;
            //输入0-9和Backspace del 有效  
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 46)                       //小数点        
            {
                if (convent.Text.Length <= 0)
                    e.Handled = true;           //小数点不能在第一位        
                else
                {
                    float f;
                    if (float.TryParse(convent.Text + e.KeyChar.ToString(), out f))
                    {
                        e.Handled = false;
                    }
                }
            }
            return e.Handled;
        } 
    #endregion
    }
}
