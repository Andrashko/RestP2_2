using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CheckoutController : ApiController
    {
        private Database1Entities db = new Database1Entities();
        private List<Bill> currentBills;
        private int CheckountCount = 3;

        public CheckoutController()
        {
            currentBills = new List<Bill>(this.CheckountCount);
            for (int i = 1; i < this.CheckountCount; i++)
            {
                Bill bill = new Bill();
                bill.CheckoutId = i;
                currentBills.Add(bill);
            }
        }
                  
        public IHttpActionResult Get(int Id)
        {
            var res = db.Сheckout.Find(Id);
            if (res== null)
                return NotFound();
            else
                return Ok(res);
        }

        public IHttpActionResult Patch(int Id, [FromUri] int GoodsId, [FromUri] float Count = 1 )
        {
            var goods = db.Goods.Find(GoodsId);
            if (goods == null)
                return BadRequest("Такого товару не існує");
            Sale sale = new Sale( goods, Count);
            sale.BillId = currentBills[Id].Id;
            sale.SaleGoods();           
            db.SaveChanges();
            return Ok(sale);
        }

        public IHttpActionResult Post(int Id)
        {           
            currentBills[Id].SaleTime = DateTime.Now;
            db.Bill.Add(currentBills[Id]);
            db.SaveChanges();
            return Ok("Чек збережено");
        }

        public IHttpActionResult Put(int Id)
        {
            Bill bill = new Bill();
            bill.CheckoutId = Id;
            currentBills[Id] = bill;
            return Ok("Відкрито новий чек");
        }
    }
}
