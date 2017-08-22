using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training.Test.OrderPizza
{
    public class Menu
    {
        VegMenu vegMenu = new VegMenu();
        NonVegMenu nonvegMenu = new NonVegMenu();

        public void DisplayMenu(int choice)
        {
            if (choice == 1)
            {
                vegMenu.TakeOrder();
            }
            if (choice == 2)
            {
                nonvegMenu.TakeOrder();
            }
        }
       
    }
}
