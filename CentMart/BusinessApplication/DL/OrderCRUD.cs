using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication.BL;

namespace BusinessApplication.DL
{
    internal class OrderCRUD
    {
        public static List<Order> cart = new List<Order>();
        public static int getBill()
        {
            int bill = 0;
            foreach(Order o in cart)
            {
                bill += o.Total;
            }
            return bill;
        }
        public static void clear()
        {
            cart = null;
        }
    }
}
