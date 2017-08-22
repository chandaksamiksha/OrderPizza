using System;
using System.Collections.Generic;

namespace Tavisca.Training.Test.OrderPizza
{
    public class NonVegMenu
    {
        List<string> nonVegPizza;
        public NonVegMenu()
        {
            nonVegPizza = new List<string>();
            nonVegPizza.Add("Chicken Pizza");
            nonVegPizza.Add("Mutton Pizza");
        }
        public void TakeOrder()
        {
           //display list
        }
    }
}