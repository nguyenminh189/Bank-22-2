using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Foreigner : Customer
    {
        public string Nationality { get; set; }
        public int Quantity { get; set; }

        public double Price {get; set; }

        public double Calculate()
        {
            return Quantity * Price;
        }
    }
}
