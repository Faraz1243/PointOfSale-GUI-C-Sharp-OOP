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
using BusinessApplication;
using MaterialSkin;

namespace BusinessApplication
{
    public partial class Form_Admin : MaterialSkin.Controls.MaterialForm
    {
        //      2021-CS-122
        public Form_Admin()
        {
            InitializeComponent(); 

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
            f.Closed += (s, args) => this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            //override new form
            SFs.SF_AddUser f = new SFs.SF_AddUser();
            f.ShowDialog();
            gv_users.DataSource = null;
            this.gv_users.DataSource = DL.UserCRUD.userList;
            this.gv_users.Columns["Password"].Visible = false;
            this.gv_users.Columns["Salary"].Visible = false;
            this.gv_users.Columns["Address"].Visible = false;
            this.gv_users.Columns["CreatedBy"].Visible = false;
            this.gv_users.Columns["Cnic"].Visible = false;
            this.gv_users.Columns["JoinDate"].Visible = false;
            //
            this.gv_users.Columns[0].Width = 60;
            this.gv_users.Columns[1].Width = 60;
            this.gv_users.Columns["Name"].Width = 150;
            this.gv_users.Columns["Email"].Width = 220;
            this.gv_users.Columns["Phone"].Width = 130;
            this.gv_users.Columns["ROle"].Width = 150;
            this.gv_users.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (column == 0)
            {
                DL.GlobalVariables.TempUser = DL.UserCRUD.getUser(row);
                SFs.SF_ForUsers form = new SFs.SF_ForUsers();
                form.ShowDialog();
                gv_users.DataSource = null;
                this.gv_users.DataSource = DL.UserCRUD.userList;
                this.gv_users.Columns["Password"].Visible = false;
                this.gv_users.Columns["Salary"].Visible = false;
                this.gv_users.Columns["Address"].Visible = false;
                this.gv_users.Columns["CreatedBy"].Visible = false;
                this.gv_users.Columns["Cnic"].Visible = false;
                this.gv_users.Columns["JoinDate"].Visible = false;
                //
                this.gv_users.Columns[0].Width = 60;
                this.gv_users.Columns[1].Width = 60;
                this.gv_users.Columns["Name"].Width = 150;
                this.gv_users.Columns["Email"].Width = 220;
                this.gv_users.Columns["Phone"].Width = 130;
                this.gv_users.Columns["ROle"].Width = 150;
                this.gv_users.ForeColor = Color.Black;
                //
            }
            if (column == 1)
            {
                MessageBox.Show("leftest+1");
                DL.UserCRUD.deleteUser(row);
                DL.UserCRUD.save();
                gv_users.DataSource = null;
                this.gv_users.DataSource = DL.UserCRUD.userList;
                this.gv_users.Columns["Password"].Visible = false;
                this.gv_users.Columns["Salary"].Visible = false;
                this.gv_users.Columns["Address"].Visible = false;
                this.gv_users.Columns["CreatedBy"].Visible = false;
                this.gv_users.Columns["Cnic"].Visible = false;
                this.gv_users.Columns["JoinDate"].Visible = false;
                //
                this.gv_users.Columns[0].Width = 60;
                this.gv_users.Columns[1].Width = 60;
                this.gv_users.Columns["Name"].Width = 150;
                this.gv_users.Columns["Email"].Width = 220;
                this.gv_users.Columns["Phone"].Width = 130;
                this.gv_users.Columns["ROle"].Width = 150;
                this.gv_users.ForeColor = Color.Black;
            }
        }
        private void materialFloatingActionButton3_Click(object sender, EventArgs e)
        {
            lbl_balance.Text = null;
            lbl_balance.Text = $"${DL.GlobalVariables.getBalance()}";
            DL.GlobalVariables.save();
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            lbl_tax.Text = null;
            lbl_tax.Text = $"${DL.GlobalVariables.getTax()}";
            DL.GlobalVariables.save();
        }
        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            SFs.SF_SetGST form = new SFs.SF_SetGST();
            form.ShowDialog();
            lbl_gst.Text = null;
            lbl_gst.Text = $"{DL.GlobalVariables.GST} %";
            DL.GlobalVariables.save();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string x1 = materialTextBox1.Text;
            string x2 = materialTextBox2.Text;
            string x3 = materialTextBox3.Text;
            string x4 = materialTextBox4.Text;
            string x5 = materialTextBox5.Text;
            string x6 = materialTextBox6.Text;
            if (x1==""|| x2 == "" || x3 == "" || x4 == "" || x5 == "" ||x6 == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else if(Vs.Validations.isConvertableToFloat(x1)&& Vs.Validations.isConvertableToFloat(x2) && Vs.Validations.isConvertableToFloat(x3) && Vs.Validations.isConvertableToFloat(x4) && Vs.Validations.isConvertableToFloat(x5) && Vs.Validations.isConvertableToFloat(x6))
            {
                DL.GlobalVariables.debit(int.Parse(x1));
                DL.GlobalVariables.debit(int.Parse(x2));
                DL.GlobalVariables.debit(int.Parse(x3));
                DL.GlobalVariables.debit(int.Parse(x4));
                DL.GlobalVariables.debit(int.Parse(x5));
                DL.GlobalVariables.debit(int.Parse(x6));
                DL.GlobalVariables.save();
                MessageBox.Show("Debit Successful");
            }
            else
            {
                MessageBox.Show("Please enter valid numbers");
            }
        }

        private void Form_Admin_Load_1(object sender, EventArgs e)
        {
            //home tab
            this.lbl_balance.Text = $"${DL.GlobalVariables.getBalance()}";
            this.lbl_tax.Text = $"${DL.GlobalVariables.getTax()}";
            this.lbl_gst.Text = $"{DL.GlobalVariables.GST} %";

            //users tab
            this.gv_users.DataSource = null;
            this.gv_users.DataSource = DL.UserCRUD.userList;
            this.gv_users.Columns["Password"].Visible = false;
            this.gv_users.Columns["Salary"].Visible = false;
            this.gv_users.Columns["Address"].Visible = false;
            this.gv_users.Columns["CreatedBy"].Visible = false;
            this.gv_users.Columns["Cnic"].Visible = false;
            this.gv_users.Columns["JoinDate"].Visible = false;
            //
            this.gv_users.Columns[0].Width = 60;
            this.gv_users.Columns[1].Width = 60;
            this.gv_users.Columns["Name"].Width = 150;
            this.gv_users.Columns["Email"].Width = 220;
            this.gv_users.Columns["Phone"].Width = 130;
            this.gv_users.Columns["ROle"].Width = 150;
            this.gv_users.ForeColor = Color.Black;

            //invenntory tab
            this.gv_inventory.DataSource = null;
            this.gv_inventory.DataSource = DL.ProductCRUD.productList;
            this.gv_inventory.Columns["Barcode"].Width = 120;

        }
    }
}
