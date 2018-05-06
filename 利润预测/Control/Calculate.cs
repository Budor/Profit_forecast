using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Configuration;
using Common;

namespace Control
{
    //计算
    public class Calculate
    {
        //public static Dictionary<string, double> configList = new Dictionary<string, double>();

        public Profit profit = null;
       
        public Calculate()
        {
            
        }
        public Calculate(double dou,Data data)
        {
            this.profit = this.InitializationProfit(dou, data);         
        }


        private Profit InitializationProfit(double weight, Data data)
        {
            //精品煤对象
            Coal CleanCoal = this.InitializationCoal("精品煤", weight, this.getvalue("FineCoalPrice"), this.getvalue("FineCoalRecoveryCoefficient"));
            //块煤对象
            Coal LumpCoal = this.InitializationCoal("块儿煤", weight, this.getvalue("LumpCoalPrice"), this.getvalue("LumpCoalRecoveryCoefficient"));
            //原煤对象
            Coal coal = this.InitializationCoal("原煤", weight, this.getvalue("RawCoalPrice"), this.getvalue("RawCoalRecoveryCoefficient"));
            //煤泥对象
            Coal Slime = this.InitializationCoal("煤泥", weight, this.getvalue("SlimePrice"), this.getvalue("SlimeRecoveryCoefficient"));
            //末矸对象
            Coal Mogan = this.InitializationCoal("末矸", weight, this.getvalue("MoGanPrice"), this.getvalue("MoGanRecoveryCoefficient"));

            Profit profit = new Profit();
            //重量
            profit.Wight = weight;
            //成本基数
            profit.CostBasis = this.getvalue("CostBasis");
            //税金系数
            profit.Tax = this.getvalue("TaxCoefficient");
            //月成本系数
            switch (data)
            {
                case Data.Year:
                    profit.CostCoefficient = this.getvalue("YearCostCoefficient");
                    break;
                case Data.Month:
                    profit.CostCoefficient = this.getvalue("MonthCostCoefficient");
                    break;
                
            }
            //总商品煤产量
            profit.Yield = CleanCoal.Yield + LumpCoal.Yield + coal.Yield + Slime.Yield + Mogan.Yield;


            //总营业收入
            profit.Income = CleanCoal.Income + LumpCoal.Income + coal.Income + Slime.Income + Mogan.Income;
            //预计单位成本
            profit.Cost = profit.CostBasis * profit.CostCoefficient / profit.Wight;
            //综合售价
            profit.CSPrice = profit.Income / profit.Yield * 1.17;
            //预测利润
            profit.Profit1 = profit.Income - profit.CostBasis * profit.CostCoefficient - profit.Tax * profit.Income;

            return profit;
        }

        /// <summary>
        /// 初始化煤的种类
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="wight">重量</param>
        /// <param name="price">售价</param>
        /// <param name="recoveryCoefficient">回收系数</param>
        /// <returns>煤的对象</returns>
        private Coal InitializationCoal( string name, double wight, double price, double recoveryCoefficient)
        {
            Coal Coal = new Model.Coal();
            Coal.Name = name;
            Coal.Wight = wight;
            Coal.Price = price;
            Coal.RecoveryCoefficient = recoveryCoefficient;
            Coal.Yield = Coal.Wight * Coal.RecoveryCoefficient;
            Coal.Income = Coal.Price / 1.17 * Coal.Yield;
            return Coal;
        }
       



        public double getvalue(string str)
        {
            return ConfigDictionary.getValue(str);
        }
    }
}
