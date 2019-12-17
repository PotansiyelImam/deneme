using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class CheckClass : PaymentProperties
    {
        private string name;
        private int bankid;

        public int Bankid { get => bankid; set => bankid = value; }
        public string Name { get => name; set => name = value; }
    }
}
