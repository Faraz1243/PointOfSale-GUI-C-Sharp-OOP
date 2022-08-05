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
    public partial class SF_ForProduct : MaterialSkin.Controls.MaterialForm
    {
        public SF_ForProduct()
        {
            InitializeComponent(); ;

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void SF_ForProduct_Load(object sender, EventArgs e)
        {
            txt_name.Text = DL.GlobalVariables.tempProduct.Name;
            txt_cost.Text = DL.GlobalVariables.tempProduct.Cost.ToString();
            txt_price.Text = DL.GlobalVariables.tempProduct.Price.ToString();
            txt_shelf.Text = DL.GlobalVariables.tempProduct.ShelfQuantity.ToString();
            txt_stock.Text = DL.GlobalVariables.tempProduct.Quantity.ToString();
            txt_barcode.Text = DL.GlobalVariables.tempProduct.Barcode.ToString();
            txt_category.Text = DL.GlobalVariables.tempProduct.Category;
            txt_supplier.Text = DL.GlobalVariables.tempProduct.Supplier;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
