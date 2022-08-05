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
using BusinessApplication;
using MaterialSkin.Controls;

namespace BusinessApplication
{
    public partial class Form_InventoryController : MaterialSkin.Controls.MaterialForm
    {
        public Form_InventoryController()
        {
            InitializeComponent(); 

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void Form_InventoryController_Load(object sender, EventArgs e)
        {
            //home tab
            lbl_name.Text = DL.GlobalVariables.CurrentUser.Name;
            lbl_email.Text = DL.GlobalVariables.CurrentUser.Email;
            lbl_phone.Text = DL.GlobalVariables.CurrentUser.Phone.ToString();
            lbl_cnic.Text = DL.GlobalVariables.CurrentUser.Cnic.ToString();
            lbl_address.Text = DL.GlobalVariables.CurrentUser.Address;
            lbl_date.Text = DL.GlobalVariables.CurrentUser.JoinDate.Day.ToString();

            //inventory tab
            gv_inventory.DataSource = DL.ProductCRUD.productList;
            gv_inventory.ForeColor = Color.Black;
            gv_inventory.Columns[0].Width = 50;
            gv_inventory.Columns[1].Width = 50;
            gv_inventory.Columns[3].Width = 80;
            gv_inventory.Columns[4].Width = 80;
            gv_inventory.Columns[5].Visible = false;
            gv_inventory.Columns[6].Visible = false;
            this.gv_inventory.Columns["Barcode"].Width = 120;
            this.gv_inventory.Columns["Supplier"].Width = 80;

            //shelf tab
            gv_shelf.DataSource = DL.ProductCRUD.productList;
            gv_shelf.ForeColor = Color.Black;
            gv_shelf.Columns["Cost"].Visible = false;
            gv_shelf.Columns["Price"].Visible = false;
            gv_shelf.Columns["Category"].Width = 80;
            gv_shelf.Columns["Supplier"].Width = 90;
            gv_shelf.Columns["Barcode"].Width = 120;
            gv_shelf.Columns[0].Width = 70;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
            f.Closed += (s, args) => this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (column == 0)
            {
                DL.GlobalVariables.tempProduct = DL.ProductCRUD.getProductByIndex(row);
                SFs.SF_ForProduct form = new SFs.SF_ForProduct();
                form.ShowDialog();

            }
            if (column == 1)
            {
                DL.ProductCRUD.removeAt(row);
                DL.ProductCRUD.save();
                gv_inventory.DataSource = null;
                gv_inventory.DataSource = DL.ProductCRUD.productList;
                gv_inventory.ForeColor = Color.Black;
                gv_inventory.Columns[0].Width = 50;
                gv_inventory.Columns[1].Width = 50;
                gv_inventory.Columns[3].Width = 80;
                gv_inventory.Columns[4].Width = 80;
                gv_inventory.Columns[5].Visible = false;
                gv_inventory.Columns[6].Visible = false;
                MessageBox.Show("Product Deleted!");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            SFs.SF_AddProduct form = new SFs.SF_AddProduct();
            form.ShowDialog();
            this.gv_inventory.DataSource = null;
            BindingSource s = new BindingSource();
            s.DataSource = DL.ProductCRUD.productList;
            this.gv_inventory.DataSource = s;
            gv_inventory.ForeColor = Color.Black;
            gv_inventory.Columns[0].Width = 50;
            gv_inventory.Columns[1].Width = 50;
            gv_inventory.Columns[3].Width = 80;
            gv_inventory.Columns[4].Width = 80;
            gv_inventory.Columns[5].Visible = false;
            gv_inventory.Columns[6].Visible = false;
            this.gv_inventory.Columns["Barcode"].Width = 120;
            this.gv_inventory.Columns["Supplier"].Width = 80;
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            string pass = txt_oldPassword.Text;
            string cpass1 = txt_newPassword1.Text;
            string cpass2 = txt_newPassword2.Text;
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

        private void gv_shelf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (column == 0)
            {
                DL.GlobalVariables.tempProduct = DL.ProductCRUD.getProductByIndex(row);
                SFs.SF_TransferProduct form = new SFs.SF_TransferProduct();
                form.ShowDialog();
                gv_shelf.DataSource = null;
                gv_shelf.DataSource = DL.ProductCRUD.productList;
                gv_shelf.ForeColor = Color.Black;
                gv_shelf.Columns["Cost"].Visible = false;
                gv_shelf.Columns["Price"].Visible = false;
                gv_shelf.Columns["Category"].Width = 80;
                gv_shelf.Columns["Supplier"].Width = 90;
                gv_shelf.Columns["Barcode"].Width = 120;
                gv_shelf.Columns[0].Width = 70;
            }
        }
    }
}
