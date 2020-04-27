using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public partial class Bill
    {
        public float TotalAmount() {
            float Summ = 0;
            foreach (Sale sale in this.Sale)
                Summ += sale.Amount();
            return Summ;
        }
    }
}