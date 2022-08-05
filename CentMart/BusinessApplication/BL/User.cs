using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    internal class User
    {
        private string name;
        private string password;
        private string email;
        private Int64 phone;
        private int salary;
        private string address;
        private string role;
        private string createdBy;
        private Int64 cnic;
        private DateTime joinDate;
        
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public Int64 Phone { get => phone; set => phone = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Address { get => address; set => address = value; }
        public string Role { get => role; set => role = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public Int64 Cnic { get => cnic; set => cnic = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }

        public User(string name, string password, string email, Int64 phone, int salary, string address, string role, string createdBy, Int64 cnic, DateTime joinDate)
        {
            this.Name = name;
            this.Password = password;
            this.Email = email;
            this.Phone = phone;
            this.Salary = salary;
            this.Address = address;
            this.Role = role;
            this.CreatedBy = createdBy;
            this.Cnic = cnic;
            this.JoinDate = joinDate;
        }
        //for file handlind
        public User(string name, string password, string email, Int64 phone, int salary, string address, string role, string createdBy, Int64 cnic, int date, int month, int year)
        {
            this.Name = name;
            this.Password = password;
            this.Email = email;
            this.Phone = phone;
            this.Salary = salary;
            this.Address = address;
            this.Role = role;
            this.CreatedBy = createdBy;
            this.Cnic = cnic;
            this.JoinDate = new DateTime(year, month, date);
        }
    }
}
