using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 利润类
    /// </summary>
    public class Profit
    {
        private double wight;                    //重量               可读写

        private double yield;                    //总商品煤产量         可读，不可写

       
        private double income;                   //总营业收入           可读，不可写


        private double cSPrice;                  //综合售价


        private double profit;                   //预计利润


        private double cost;                     //预计单位成本


        private double costBasis;                //成本基数


        private double costCoefficient;          //成本系数


        private double tax;                      //税金系数
        /// <summary>
        /// 重量
        /// </summary>
        public double Wight
        {
            get { return wight; }
            set { wight = value; }
        }
        /// <summary>
        /// 总商品煤产量
        /// </summary>
        public double Yield
        {
            get { return yield; }
            set { yield = value; }
        }
        /// <summary>
        /// 总营业收入
        /// </summary>
        public double Income
        {
            get { return income; }
            set { income = value; }
        }
        /// <summary>
        /// 综合售价
        /// </summary>
        public double CSPrice
        {
            get { return cSPrice; }
            set { cSPrice = value; }
        }
        /// <summary>
        /// 预计利润
        /// </summary>
        public double Profit1
        {
            get { return profit; }
            set { profit = value; }
        }
        /// <summary>
        /// 预计单位成本
        /// </summary>
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        /// <summary>
        /// 成本基数
        /// </summary>
        public double CostBasis
        {
            get { return costBasis; }
            set { costBasis = value; }
        }
        /// <summary>
        /// 成本系数
        /// </summary>
        public double CostCoefficient
        {
            get { return costCoefficient; }
            set { costCoefficient = value; }
        }
        /// <summary>
        /// 税金系数
        /// </summary>
        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }
    }
}
