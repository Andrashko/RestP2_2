using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public partial class Sale
    {
        public void SaleGoods()
        {
            this.Goods.decStock(this.Number);
        }

        public float Amount()
        {
            return this.Number * this.Goods.Price;
        }

        public Sale( Goods goods, float number)
        {
            this.Goods = goods;
            this.Number = number;        
        }
    }
}