using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    interface IPayment
    {        
        bool Pay(float Sum);
        string Name();
    }
}
