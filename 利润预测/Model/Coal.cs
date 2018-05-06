using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Model
{
    /// <summary>
    /// 煤 父类
    /// </summary>
   public class Coal
    {
        private string name;                     //品种               可读写
        private double wight;                    //重量               可读写
        private double price;                    //售价               可读写
        private double recoveryCoefficient;      //回收系数           可读写
        private double yield;                    //商品煤产量         可读，不可写
        private double income;                   //营业收入           可读，不可写

       /// <summary>
       /// 品种
       /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
           
        }
       /// <summary>
       /// 重量
       /// </summary>
        public double Wight
        {
            get { return wight; }
            set { wight = value; }
        }
       /// <summary>
       /// 售价
       /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
       /// <summary>
       /// 回收系数
       /// </summary>
        public double RecoveryCoefficient
        {
            get { return recoveryCoefficient; }
            set { recoveryCoefficient = value; }
        }
       /// <summary>
       /// 商品煤产量
       /// </summary>
        public double Yield
        {
            get { return yield; }
            set { yield = value; }
        }
       /// <summary>
       /// 营业收入
       /// </summary>
        public double Income
        {
            get { return income; }
            set { income = value; }
        }

    }
}
