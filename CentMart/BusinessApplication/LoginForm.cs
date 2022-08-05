using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace BusinessApplication
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_pass.Text;

            if (DL.UserCRUD.userRole(email, password) == "Admin")
            {
                this.Hide();
                Form_Admin admin = new Form_Admin();
                admin.Closed += (s, args) => this.Close();
                admin.Show();
            }
            else if (DL.UserCRUD.userRole(email, password) == "Inventory Controller")
            {
                this.Hide();
                Form_InventoryController iv = new Form_InventoryController();
                iv.Closed += (s, args) => this.Close();
                iv.Show();
            }
            else if (DL.UserCRUD.userRole(email, password) == "Cashier")
            {
                this.Hide();
                Form_Cashier cashier = new Form_Cashier();
                cashier.Closed += (s, args) => this.Close();
                cashier.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials");
            }
        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_Admin admin = new Form_Admin();
            DL.GlobalVariables.CurrentUser = DL.UserCRUD.userList[0];
            admin.Closed += (s, args) => this.Close();
            admin.Show();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DL.GlobalVariables.CurrentUser = DL.UserCRUD.userList[1];
            Form_InventoryController iv = new Form_InventoryController();
            iv.Closed += (s, args) => this.Close();
            iv.Show();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DL.GlobalVariables.CurrentUser = DL.UserCRUD.userList[2];
            Form_Cashier cashier = new Form_Cashier();
            cashier.Closed += (s, args) => this.Close();
            cashier.Show();
        }
    }
}
