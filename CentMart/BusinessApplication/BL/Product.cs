using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    internal class Product
    {
        private string name;
        private int cost;
        private int price;
        private int shelfQuantity;
        private int quantity;
        private Int64 barcode;
        private string category;
        private string supplier;
        //parametrized constructor
        public Product(string name, int cost, int price, int shelfQuantity, int quantity, Int64 barcode, string category, string supplier)
        {
            this.name = name;
            this.cost = cost;
            this.price = price;
            this.shelfQuantity = shelfQuantity;
            this.quantity = quantity;
            this.barcode = barcode;
            this.category = category;
            this.supplier = supplier;
        }

        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value; }
        public int Price { get => price; set => price = value; }
        public int ShelfQuantity { get => shelfQuantity; set => shelfQuantity = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Int64 Barcode { get => barcode; set => barcode = value; }
        public string Category { get => category; set => category = value; }
        public string Supplier { get => supplier; set => supplier = value; }
        
        public string _ToString()
        {
            return name + ',' + cost + ',' + price + ',' + shelfQuantity + ',' + quantity + ',' + barcode + ',' + category + ',' + supplier;
        }
    }
}
