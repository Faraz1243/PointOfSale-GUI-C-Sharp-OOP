using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using BusinessApplication.BL;

namespace BusinessApplication.DL
{
    internal class UserCRUD
    {
        public static List<User> userList = new List<User>();
        public static User getUser(int idx)
        {
            return userList[idx];
        }
        public static void addUser(User user)
        {
            userList.Add(user);
        }
        
        public static void deleteUser(int idx)
        {
            userList.RemoveAt(idx);
        }
        
        public static bool ifCnicExist(Int64 cnic)
        {
            foreach (User user in userList)
            {
                if (user.Cnic == cnic)
                {
                    return true;
                }
            }
            return false;
        }
        
        public static bool ifEmailExist(string email)
        {
            foreach (User user in userList)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
        
        //save to file
        public static void save()
        {
            StreamWriter sw = new StreamWriter("users.txt");
            foreach (User u in userList)
            {
                sw.WriteLine($"{u.Name},{u.Password},{u.Email},{u.Phone},{u.Salary},{u.Address},{u.Role},{u.CreatedBy},{u.Cnic},{u.JoinDate.Date.Day},{u.JoinDate.Month},{u.JoinDate.Year}");
            }
            sw.Flush();
            sw.Close();
            
        }
        public static void load()
        {
            StreamReader sr = new StreamReader("users.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] data = line.Split(',');
                User user = new User(data[0], data[1], data[2], Int64.Parse(data[3]), int.Parse(data[4]), data[5], data[6], data[7], Int64.Parse(data[8]), int.Parse(data[9]), int.Parse(data[10]), int.Parse(data[11]));
                userList.Add(user);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        public static string userRole(string email, string pass)
        {
            foreach(User u in userList)
            {
                if (u.Email == email && u.Password == pass)
                {
                    GlobalVariables.CurrentUser = u;
                    return u.Role;
                }
            }
            return "";
        }
    }
}
