using BusinessApplication.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.DL
{
    internal class GlobalVariables
    {
        private static Int64 balance = 134000;
        private static Int64 accumulatedTax = 1200;
        private static float gst = 17;
        private static string company_name = "CentMart";

        private static int phone_no_length = 11;
        private static BL.User currentUser;
        private static User tempUser;
        public static Product tempProduct;

        public static double getBalance()
        {
            return balance;
        }
        public static void credit(int amount)
        {
            balance += amount;
        }
        public static void debit(int amount)
        {
            balance -= amount;
        }
        public static double getTax()
        {
            return accumulatedTax;
        }
        public static void addTax(int amount)
        {
            accumulatedTax += amount;
        }
        public static void payTax()
        {
            balance -= accumulatedTax;
            accumulatedTax = 0;
        }
        public static float GST { get => gst; set => gst = value; }
        public static int PHONE_NO_LENGTH { get => phone_no_length;}
        public static string COMPANY_NAME { get => company_name; set => company_name = value; }
        internal static User CurrentUser { get => currentUser; set => currentUser = value; }
        internal static User TempUser { get => tempUser; set => tempUser = value; }

        public static void save()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("balance.txt");
            file.WriteLine($"{balance},{accumulatedTax},{gst},{company_name}");
            file.Flush();
            file.Close();
        }
        public static void load()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("balance.txt");
            string[] data = file.ReadLine().Split(',');
            balance = Int64.Parse(data[0]);
            accumulatedTax = Int64.Parse(data[1]);
            gst = float.Parse(data[2]);
            company_name = data[3];
            file.Close();
        }
    }
}
