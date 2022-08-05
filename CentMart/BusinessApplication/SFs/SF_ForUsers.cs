using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace BusinessApplication.SFs
{
    public partial class SF_ForUsers : MaterialSkin.Controls.MaterialForm
    {
        public SF_ForUsers()
        {
            InitializeComponent(); ;

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void SF_ForUsers_Load(object sender, EventArgs e)
        {
            txt_name.Text = DL.GlobalVariables.TempUser.Name;
            txt_password.Text = DL.GlobalVariables.TempUser.Password;
            txt_email.Text = DL.GlobalVariables.TempUser.Email;
            txt_phone.Text = DL.GlobalVariables.TempUser.Phone.ToString();
            txt_salary.Text = DL.GlobalVariables.TempUser.Salary.ToString();
            txt_role.Text = DL.GlobalVariables.TempUser.Role;
            txt_cnic.Text = DL.GlobalVariables.TempUser.Cnic.ToString();
            txt_createdBy.Text = DL.GlobalVariables.TempUser.CreatedBy;
            txt_address.Text = DL.GlobalVariables.TempUser.Address;
            txt_date.Text = DL.GlobalVariables.TempUser.JoinDate.Date.ToString();
        }



        private void materialButton1_Click(object sender, EventArgs e)
        {
            if(txt_name.Text=="" || txt_password.Text == "" || txt_phone.Text == "" || txt_salary.Text == "" || txt_cnic.Text == "" || txt_address.Text == "" || txt_role.Text == "")
            {
                MessageBox.Show("Enter all the Fields!");
            }
            else if(!(Vs.Validations.isConvertableToInt(txt_phone.Text)&& Vs.Validations.isConvertableToInt(txt_salary.Text)&& Vs.Validations.isConvertableToInt(txt_cnic.Text)))
            {
                MessageBox.Show("Enter Valid Inputs!");
            }
            else if(!Vs.Validations.isValidPassword(txt_password.Text))
            {
                MessageBox.Show("Enter Strong Password!");
            }
            else if(txt_phone.Text.Length!=11)
            {
                MessageBox.Show("Enter Valid Password! ");
            }
            else if(txt_cnic.Text.Length != 13)
            {
                MessageBox.Show("Enter Valid CNIC!");
            }
            else if(!(txt_role.Text == "Admin"||txt_role.Text == "Inventory Controller"||txt_role.Text == "Cashier"))
            {
                MessageBox.Show("Enter Valid Role!");
            }
            else
            {
                DL.GlobalVariables.TempUser.Name = txt_name.Text;
                DL.GlobalVariables.TempUser.Password = txt_password.Text;
                DL.GlobalVariables.TempUser.Phone = Int64.Parse(txt_phone.Text);
                DL.GlobalVariables.TempUser.Salary = int.Parse(txt_salary.Text);
                DL.GlobalVariables.TempUser.Role = txt_role.Text;
                DL.GlobalVariables.TempUser.Cnic = Int64.Parse(txt_cnic.Text);
                DL.GlobalVariables.TempUser.Address = txt_address.Text;
                MessageBox.Show("Success!");
                DL.UserCRUD.save();
                this.Close();
            }
        }
    }
}
