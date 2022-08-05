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
using BusinessApplication.BL;
using static BusinessApplication.Vs.Validations;

namespace BusinessApplication
{
    public partial class Form_Cashier : MaterialSkin.Controls.MaterialForm
    {
        public Form_Cashier()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void Form_Cashier_Load(object sender, EventArgs e)
        {
            lbl_name.Text = DL.GlobalVariables.CurrentUser.Name;
            lbl_email.Text = DL.GlobalVariables.CurrentUser.Email;
            lbl_phone.Text = DL.GlobalVariables.CurrentUser.Phone.ToString();
            lbl_cnic.Text = DL.GlobalVariables.CurrentUser.Cnic.ToString();
            lbl_address.Text = DL.GlobalVariables.CurrentUser.Address;
            lbl_date.Text = DL.GlobalVariables.CurrentUser.JoinDate.Day.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
            f.Closed += (s, args) => this.Close();
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            string barcode = txt_barcode.Text;
            string quantity = txt_quantity.Text;
            if (barcode == null || quantity == null)
            {
                MessageBox.Show("Please enter all the fields");
            }
            else if(!(isConvertableToInt(barcode)&&isConvertableToInt(quantity)))
            {
                MessageBox.Show("Please enter valid values");
            }
            else if (!DL.ProductCRUD.ifBarcodeExist(Int64.Parse(barcode)))
            {
                MessageBox.Show("Barcode don't Exist!");
            }
            else if(DL.ProductCRUD.getQuantity(Int64.Parse(barcode))<int.Parse(quantity))
            {
                MessageBox.Show("Not Available on Shelf!");
            }
            else
            {
                Int64 barcode_int = Convert.ToInt64(barcode);
                int quantity_int = Convert.ToInt32(quantity);

                Order o = new Order(DL.ProductCRUD.getProduct(barcode_int), quantity_int);
                DL.OrderCRUD.cart.Add(o);
                this.gv_cart.DataSource = null;
                
                this.gv_cart.DataSource = DL.OrderCRUD.cart;
                txt_finalBill.Text = DL.OrderCRUD.getBill().ToString();
                /*
                if (DL.GlobalVariables.CurrentUser.Cart.ContainsKey(barcode_int))
                {
                    MessageBox.Show("Item already in cart");
                }
                else
                {
                    DL.GlobalVariables.CurrentUser.Cart.Add(barcode_int, quantity_int);
                    MessageBox.Show("Item added to cart");
                }
                */
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            DL.GlobalVariables.credit(DL.OrderCRUD.getBill());
            foreach(Order o in DL.OrderCRUD.cart)
            {
                o.Product.ShelfQuantity -= o.Quantity;
            }
            MessageBox.Show("Success!");
            DL.OrderCRUD.clear();
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            string pass = txt_password.Text;
            string cpass1 = txt_newPass1.Text;
            string cpass2 = txt_newPass2.Text;
            if (pass == DL.GlobalVariables.CurrentUser.Password)
            {
                if (cpass1 == cpass2)
                {
                    if (Vs.Validations.isValidPassword(cpass1))
                    {
                        DL.GlobalVariables.CurrentUser.Password = cpass1;
                        MessageBox.Show("Password Changed!");
                    }
                    else
                    {
                        MessageBox.Show("Enter Strong Password!");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match!");
                }
            }
            else
            {
                MessageBox.Show("Wrong Password!");
            }
        }
    }
}
