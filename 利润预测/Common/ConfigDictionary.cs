using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Common
{
   public static class ConfigDictionary
    {
       /// <summary>
       /// 配置文件字典 静态
       /// </summary>
       public static Dictionary<string, double> configList = new Dictionary<string, double>();

       #region 初始化字典
       /// <summary>
       /// 初始化字典
       /// </summary>
       public static void InitializationConfigList()
       {
           //回收系数
           double FineCoalRecoveryCoefficient = Convert.ToDouble(ConfigurationManager.AppSettings["FineCoalRecoveryCoefficient"]);
           double LumpCoalRecoveryCoefficient = Convert.ToDouble(ConfigurationManager.AppSettings["LumpCoalRecoveryCoefficient"]);
           double RawCoalRecoveryCoefficient = Convert.ToDouble(ConfigurationManager.AppSettings["RawCoalRecoveryCoefficient"]);
           double SlimeRecoveryCoefficient = Convert.ToDouble(ConfigurationManager.AppSettings["SlimeRecoveryCoefficient"]);
           double MoGanRecoveryCoefficient = Convert.ToDouble(ConfigurationManager.AppSettings["MoGanRecoveryCoefficient"]);

           configList.Add("FineCoalRecoveryCoefficient", FineCoalRecoveryCoefficient);
           configList.Add("LumpCoalRecoveryCoefficient", LumpCoalRecoveryCoefficient);
           configList.Add("RawCoalRecoveryCoefficient", RawCoalRecoveryCoefficient);
           configList.Add("SlimeRecoveryCoefficient", SlimeRecoveryCoefficient);
           configList.Add("MoGanRecoveryCoefficient", MoGanRecoveryCoefficient);

           //售价
           double FineCoalPrice = Convert.ToDouble(ConfigurationManager.AppSettings["FineCoalPrice"]);
           double LumpCoalPrice = Convert.ToDouble(ConfigurationManager.AppSettings["LumpCoalPrice"]);
           double RawCoalPrice = Convert.ToDouble(ConfigurationManager.AppSettings["RawCoalPrice"]);
           double SlimePrice = Convert.ToDouble(ConfigurationManager.AppSettings["SlimePrice"]);
           double MoGanPrice = Convert.ToDouble(ConfigurationManager.AppSettings["MoGanPrice"]);

           configList.Add("FineCoalPrice", FineCoalPrice);
           configList.Add("LumpCoalPrice", LumpCoalPrice);
           configList.Add("RawCoalPrice", RawCoalPrice);
           configList.Add("SlimePrice", SlimePrice);
           configList.Add("MoGanPrice", MoGanPrice);

           //成本基数
           double CostBasis = Convert.ToDouble(ConfigurationManager.AppSettings["CostBasis"]);
           configList.Add("CostBasis", CostBasis);

           //年成本系数
           double YearCostCoefficient = Convert.ToDouble(ConfigurationManager.AppSettings["YearCostCoefficient"]);
           configList.Add("YearCostCoefficient", YearCostCoefficient);
           //月成本基数
           double MonthCostCoefficient = Convert.ToDouble(ConfigurationManager.AppSettings["MonthCostCoefficient"]);
           configList.Add("MonthCostCoefficient", MonthCostCoefficient);

           //税金系数
           double TaxCoefficient = Convert.ToDouble(ConfigurationManager.AppSettings["TaxCoefficient"]);
           configList.Add("TaxCoefficient", TaxCoefficient);

       }
       #endregion


       #region 从字典里面取值
       /// <summary>
       /// 根据Key从字典里取出Value
       /// </summary>
       /// <param name="str">Key</param>
       /// <returns></returns>
       public static double getValue(string str)
       {
           double dou;
           configList.TryGetValue(str, out dou);
           return dou;
       } 
       #endregion

       /// <summary>
       /// 通过字典，修改配置文件的值
       /// </summary>
       public static void InitializationConfig()
       {
           string str = System.Windows.Forms.Application.ExecutablePath;
           Configuration config = ConfigurationManager.OpenExeConfiguration(str);
           config.AppSettings.Settings["FineCoalRecoveryCoefficient"].Value = getValue("FineCoalRecoveryCoefficient").ToString();
           config.AppSettings.Settings["LumpCoalRecoveryCoefficient"].Value = getValue("LumpCoalRecoveryCoefficient").ToString();
           config.AppSettings.Settings["RawCoalRecoveryCoefficient"].Value = getValue("RawCoalRecoveryCoefficient").ToString();
           config.AppSettings.Settings["SlimeRecoveryCoefficient"].Value = getValue("SlimeRecoveryCoefficient").ToString();
           config.AppSettings.Settings["MoGanRecoveryCoefficient"].Value = getValue("MoGanRecoveryCoefficient").ToString();
           config.AppSettings.Settings["FineCoalPrice"].Value = getValue("FineCoalPrice").ToString();
           config.AppSettings.Settings["LumpCoalPrice"].Value = getValue("LumpCoalPrice").ToString();
           config.AppSettings.Settings["RawCoalPrice"].Value = getValue("RawCoalPrice").ToString();
           config.AppSettings.Settings["SlimePrice"].Value = getValue("SlimePrice").ToString();
           config.AppSettings.Settings["MoGanPrice"].Value = getValue("MoGanPrice").ToString();
           config.AppSettings.Settings["CostBasis"].Value = getValue("CostBasis").ToString();
           config.AppSettings.Settings["YearCostCoefficient"].Value = getValue("YearCostCoefficient").ToString();
           config.AppSettings.Settings["MonthCostCoefficient"].Value = getValue("MonthCostCoefficient").ToString();
           config.AppSettings.Settings["TaxCoefficient"].Value = getValue("TaxCoefficient").ToString();
           config.Save(ConfigurationSaveMode.Modified);
           ConfigurationManager.RefreshSection("appSettings");
            //System.Windows.Forms.Application.ExecutablePath
           //ConfigurationSaveMode.Modified;
       }
    }
}
