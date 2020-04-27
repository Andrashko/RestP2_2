using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using WebApplication2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


  

    namespace WebApplication2.Controllers
{
    [Authorize]
    public class PaymentController : ApiController
    {
        
        // GET: Sale
        private List<IPayment> PaymentMethods = new List<IPayment>() { new CashPayment(), new CardPayment() };
   
        public IHttpActionResult Get([FromUri] string PaymentMethod, [FromUri] float Sum)
        {
            IPayment method = this.PaymentMethods.First(m => m.Name() == PaymentMethod);
            if (method == null)
                return BadRequest("Невідомий метод оплати");
            if (method.Pay(Sum))
                return Ok("Оплачено");
            else
                return Ok("Неоплачено");
        }
    }
}