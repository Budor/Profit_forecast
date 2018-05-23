using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
namespace 利润预测
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //初始化字典
            Common.ConfigDictionary.InitializationConfigList();
            Common.ConfigDictionary.InitializationPrivateList();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Year());
        }
    }
}
