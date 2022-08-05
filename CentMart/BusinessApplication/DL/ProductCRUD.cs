using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BusinessApplication;
using BusinessApplication.BL;

namespace BusinessApplication.DL
{
    internal class ProductCRUD
    {
        public static List<Product> productList = new List<Product>();
        public static int getQuantity(Int64 id)
        {
            foreach(Product p in productList)
            {
                if(p.Barcode == id)
                {
                    return p.ShelfQuantity;
                }
            }
            return -1;
        }
        public static bool ifBarcodeExist(Int64 id)
        {
            foreach(Product p in productList)
            {
                if(p.Barcode == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static Product getProduct(Int64 id)
        {
            foreach(Product p in productList)
            {
                if(p.Barcode == id )
                {
                    return p;
                }
            }
            return null;
        }
        public static Product getProductByIndex(int idx)
        {
            return productList[idx];
        }
        public static void addProduct(Product product)
        {
            productList.Add(product);
        }
        public static void removeProduct(Product product)
        {
            productList.Remove(product);
        }
        public static void save()
        {
            StreamWriter sw = new StreamWriter("products.txt");
            foreach (Product product in productList)
            {
                sw.WriteLine(product._ToString());
            }
            sw.Flush();
            sw.Close();
        }
        public static void load()
        {
            StreamReader sr = new StreamReader("products.txt");
            string s = sr.ReadLine();
            while(s!=null)
            {
                string[] arr = s.Split(',');
                Product p = new Product(arr[0], int.Parse(arr[1]), int.Parse(arr[2]), int.Parse(arr[3]), int.Parse(arr[4]), Int64.Parse(arr[5]), arr[6], arr[7]);
                DL.ProductCRUD.addProduct(p);
                s = sr.ReadLine();
            }
            sr.Close();
        }
        public static void removeAt(int idx)
        {
            productList.RemoveAt(idx);
        }
    }
}
