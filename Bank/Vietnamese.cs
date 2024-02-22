using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Vietnamese : Customer
    {
        public string CustomerType { get; set; }
        public int Quantity { get; set; }
        public double Price {get; set; }
    

    public double Calculate()
    {
        int Limit = GetLimit();
        float Total;

        if (Quantity <= Limit)
        {
                Total = Quantity * Price;
        }
            else
            {
                Total = Limit * Price + (Quantity - Limit) * GetNewPrice();
            }
        }

        private int GetLimit()
        {
            switch (CustomerType)
            {
                case "sinh hoạt":
                    return 50;
                case "kinh doanh":
                    return 100;
                case "sản xuất":
                    return 200;
                default:
                    return 0;
            }
            }

        private double GetNewPrice()
        {
            switch (CustomerType)
            {
                case "sinh hoạt":
                    return 1000;
                case "kinh doanh":
                    return 1200;
                case "sản xuất":
                    return 1500;
                default:
                    return 0;
            }
        }

      

    }
}
