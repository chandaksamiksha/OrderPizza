using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training.Test.OrderPizza
{
    public class Cart
    {
        List<string> Order { get; set; }

        public void DispalyOrder()
        {
        }
        public void ModifyOrder()
        {
        }
        public void PlaceOrder()
        {
            //check list lenght >=2
            Checkout checkout = new Checkout();
            checkout.CalculateAmount(Order);
        }
    }
}
