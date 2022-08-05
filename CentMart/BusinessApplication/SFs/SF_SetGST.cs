using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MaterialSkin;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplication.SFs
{
    public partial class SF_SetGST : MaterialSkin.Controls.MaterialForm
    {
        public SF_SetGST()
        {
            InitializeComponent(); 

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void SF_setGST_Load(object sender, EventArgs e)
        {
            txt_gst.Text = $"{DL.GlobalVariables.GST}";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (Vs.Validations.isConvertableToFloat(txt_gst.Text))
            {
                DL.GlobalVariables.GST = float.Parse(txt_gst.Text);
                DL.GlobalVariables.save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid GST value");
            }
        }
    }
}
