using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class CardPayment:IPayment
    {
        
        public bool Pay(float Sum)
        {
            return false;
        }

        public string Name()
        {
            return "Card";
        }
    }
}