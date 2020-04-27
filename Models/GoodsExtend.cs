using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public partial class Goods
    {
        public void incStock(float Count)
        {
            this.Stock += Count;
        }

        public void decStock(float Count)
        {
            if (Count>=this.Stock)
                this.Stock -= Count;
        }
    }
}