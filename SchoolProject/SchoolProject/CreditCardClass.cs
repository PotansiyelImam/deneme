using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public  enum Cards
    {
        Visa,
        MasterCard,
        PayPal,
        PaPara,
        ToslaApp

    }
    
    class CreditCardClass : PaymentProperties
    {
        private string CardNumber;
        public Cards Cards { get; set; }
        private string SKT;
        public string SKT1 { get => SKT; set => SKT = value; }
        public string CardNumber1 { get => CardNumber; set => CardNumber = value; }
    }
}
