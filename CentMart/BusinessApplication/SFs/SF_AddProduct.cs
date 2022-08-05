using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessApplication.Vs.Validations;
using System.Windows.Forms;
using MaterialSkin;

namespace BusinessApplication.SFs
{
    public partial class SF_AddProduct : MaterialSkin.Controls.MaterialForm
    {
        public SF_AddProduct()
        {
            InitializeComponent(); ;

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (txt_name == null || txt_barcode == null || txt_cost == null || txt_price == null || txt_stock == null || txt_shelf == null || txt_supplier == null || txt_category == null)
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                if (txt_barcode.Text.Length != 13)
                {
                    MessageBox.Show("Barcode must be 13 digits");
                }
                else
                {
                    if (txt_cost.Text.Length > 8 || txt_price.Text.Length > 8 || txt_stock.Text.Length > 8 || txt_shelf.Text.Length > 8)
                    {
                        MessageBox.Show("Cost, Price and Stock must be less than 8 digits");
                    }
                    else if(DL.ProductCRUD.ifBarcodeExist(Int64.Parse(txt_barcode.Text)))
                    {
                        MessageBox.Show("Barcode already exist");
                    }
                    else
                    {
                        if(isConvertableToInt(txt_cost.Text)&& isConvertableToInt(txt_price.Text) && isConvertableToInt(txt_shelf.Text) && isConvertableToInt(txt_stock.Text) && isConvertableToInt(txt_barcode.Text))
                        {
                            BL.Product p = new BL.Product(txt_name.Text, int.Parse(txt_cost.Text), int.Parse(txt_price.Text), int.Parse(txt_shelf.Text), int.Parse(txt_stock.Text), Int64.Parse(txt_barcode.Text), txt_supplier.Text, txt_category.Text);
                            DL.ProductCRUD.addProduct(p);
                            DL.ProductCRUD.save();
                            MessageBox.Show("Product added successfully");
                            this.Close();               
                        }
                    }
                }
            }
        }
    }
}
