using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    internal class Order
    {
        private Product product;
        private string name;
        private int price;
        private int quantity;
        private int total;

        internal Product Product { get => product; set => product = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public int Total { get => total; set => total = value; }

        public Order(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
            this.Price = product.Price;
            this.Name = product.Name;
            this.total = Price * Quantity;
        }
    }
}
