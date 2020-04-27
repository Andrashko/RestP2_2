using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class CashPayment : IPayment
    {
        public bool Pay(float Sum)
        {
            return true;
        }
        public string Name()
        {
            return "Cash";
        }
    }
}