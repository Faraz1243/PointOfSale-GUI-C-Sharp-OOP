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
    public partial class SF_TransferProduct : MaterialSkin.Controls.MaterialForm
    {
        public SF_TransferProduct()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }


        private void btn_transfer_Click(object sender, EventArgs e)
        {
            string qty = txt_quantity.Text;
            if (!Vs.Validations.isConvertableToInt(qty))
            {
                MessageBox.Show("Quantity must be a number");
            }
            else
            {
                int qtyInt = Convert.ToInt32(qty);
                if (qtyInt <= 0)
                {
                    MessageBox.Show("Quantity must be greater than 0");
                }
                else
                {
                    if (qtyInt > DL.GlobalVariables.tempProduct.Quantity)
                    {
                        MessageBox.Show("Stock not Available!");
                    }
                    else
                    {
                        DL.GlobalVariables.tempProduct.Quantity -= qtyInt;
                        DL.GlobalVariables.tempProduct.ShelfQuantity += qtyInt;
                        DL.ProductCRUD.save();
                        MessageBox.Show("Transfer Successful!");
                        this.Close();
                    }
                }

            }
        }
    }
}
