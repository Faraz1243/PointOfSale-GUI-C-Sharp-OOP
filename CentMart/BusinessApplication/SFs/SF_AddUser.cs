using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using System.Windows.Forms;

namespace BusinessApplication.SFs
{
    public partial class SF_AddUser : MaterialSkin.Controls.MaterialForm
    {
        private string _name;
        private string _password;
        private string _email;
        private Int64 _phone;
        private int _salary;
        private string _address;
        private string _role;
        private string _createdBy;
        private Int64 _cnic;

        public SF_AddUser()
        {
            InitializeComponent(); ;

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if(materialTextBox1.Text!=""&& materialTextBox2.Text != "" && materialTextBox3.Text != "" )
            {
                this._name = materialTextBox1.Text;
                this._address = materialTextBox2.Text;
                if(materialTextBox3.Text.Length==13)
                {
                    if (Vs.Validations.isConvertableToInt(materialTextBox3.Text))
                    {
                        this._cnic = Int64.Parse(materialTextBox3.Text);
                        if (DL.UserCRUD.ifCnicExist(this._cnic))
                        {
                            MessageBox.Show("Cnic already exist");
                        }
                        else
                        {
                            this.panel1.Visible = false;
                            this.panel2.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid CNIC number");
                    }
                }
                else
                {
                    MessageBox.Show("CNIC must be 13 digits");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if(materialTextBox4.Text!="")
            { 
                if (Vs.Validations.isConvertableToInt(materialTextBox4.Text))
                {
                    if (materialTextBox4.Text.Length == DL.GlobalVariables.PHONE_NO_LENGTH)
                    {
                        this._phone = Int64.Parse(materialTextBox4.Text);
                        this.panel2.Visible = false;
                        this.panel3.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid phone number!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid phone number");
                }
            }
            else
            {
                MessageBox.Show("Please enter a phone number");
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            if(materialTextBox5.Text==""||materialComboBox1.Text=="")
            {
                MessageBox.Show("Kindly fulfill all requirements!");
            }
            else
            {
                if (materialComboBox1.Text == "Admin")
                {
                    this.materialLabel9.Text = ("@admin." + Vs.Validations.toLowerCase(DL.GlobalVariables.COMPANY_NAME) +".com");
                }
                else if (materialComboBox1.Text == "Inventory Controller")
                {
                    this.materialLabel9.Text = "@controller." + Vs.Validations.toLowerCase(DL.GlobalVariables.COMPANY_NAME) + ".com";
                }
                else if (materialComboBox1.Text == "Cashier")
                {
                    this.materialLabel9.Text = "@cashier." + Vs.Validations.toLowerCase(DL.GlobalVariables.COMPANY_NAME) + ".com";
                }
                if (Vs.Validations.isConvertableToInt(materialTextBox5.Text))
                {
                    if(int.Parse(materialTextBox5.Text)>0)
                    {
                        this._salary = int.Parse(materialTextBox5.Text);
                        this._role = materialComboBox1.Text;
                        this.panel3.Visible = false;
                        this.panel4.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Salary must be greater than 0");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid salary");
                }
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            if(materialTextBox6.Text==""||materialTextBox7.Text=="")
            {
                MessageBox.Show("Please fill the required fields!");
            }
            else
            {
                if(!Vs.Validations.isValidPassword(materialTextBox7.Text))
                {
                    MessageBox.Show("Password must be at least 8 characters long and contain at least one number and one uppercase letter");
                }
                else if (DL.UserCRUD.ifEmailExist(materialTextBox6.Text+ materialLabel9.Text))
                {
                    MessageBox.Show("Email already exist");
                }
                else
                {
                    this._email = materialTextBox6.Text + materialLabel9.Text;
                    this._password = materialTextBox7.Text;
                    this._createdBy = DL.GlobalVariables.CurrentUser.Name;
                    BL.User user = new BL.User(this._name, _password, _email, _phone, _salary, _address, _role, _createdBy, _cnic, DateTime.Now);
                    DL.UserCRUD.addUser(user);
                    DL.UserCRUD.save();
                    MessageBox.Show("User added successfully!");
                  
                    //
                        this.Close();
                }
            }
        }
    }
}
