using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class CashClass : PaymentProperties
    {
        private double total;

        public double Total { get => total; set => total = value; }
    }
}
