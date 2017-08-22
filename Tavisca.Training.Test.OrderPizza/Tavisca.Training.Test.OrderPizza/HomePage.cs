using System;

namespace Tavisca.Training.Test.OrderPizza
{
    public class HomePage
    {
        int choice { get; set; }

        public void Options()
        { 
            switch (choice)
            {
                case 1:
                    Menu menu = new Menu();
                    break;
                case 2:
                    break;
                case 3:
                    break;

                default:
                    break;
            }
        }
    }
}