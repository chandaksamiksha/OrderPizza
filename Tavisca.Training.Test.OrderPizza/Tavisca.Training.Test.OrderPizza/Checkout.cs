using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training.Test.OrderPizza
{
    public class Checkout
    {
        public void CalculateAmount(List<string> order)
        {
            //Calculte Price 
            BookingEngine bookingEngine = new BookingEngine();
            bookingEngine.PaymentOptions();
        }
    }
}
