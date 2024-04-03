using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public abstract class Account
    {
        public double Balance;
       
        public double AccountNumber;
        public abstract double ShowAccountDetails();
    }
}
