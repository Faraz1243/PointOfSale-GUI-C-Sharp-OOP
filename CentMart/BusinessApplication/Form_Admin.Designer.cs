namespace BusinessApplication
{
    partial class Form_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pic_graph = new System.Windows.Forms.PictureBox();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.crd_gst = new MaterialSkin.Controls.MaterialCard();
            this.lbl_gst = new System.Windows.Forms.Label();
            this.lbl_forGst = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.crd_tax = new MaterialSkin.Controls.MaterialCard();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.lbl_forTax = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.button1 = new System.Windows.Forms.Button();
            this.crd_balance = new MaterialSkin.Controls.MaterialCard();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lblforBalance = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gv_users = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_addUser = new MaterialSkin.Controls.MaterialButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.crd_implemented = new MaterialSkin.Controls.MaterialCard();
            this.lbl_implemented = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbl_inventory = new MaterialSkin.Controls.MaterialLabel();
            this.gv_inventory = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tab_tax = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.tab_mischalleneous = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.tab_rent = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.tab_net = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.tab_water = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.tab_electricity = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_graph)).BeginInit();
            this.crd_gst.SuspendLayout();
            this.crd_tax.SuspendLayout();
            this.crd_balance.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_users)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.crd_implemented.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_inventory)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tab_tax.SuspendLayout();
            this.tab_mischalleneous.SuspendLayout();
            this.tab_rent.SuspendLayout();
            this.tab_net.SuspendLayout();
            this.tab_water.SuspendLayout();
            this.tab_electricity.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(989, 531);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pic_graph);
            this.tabPage1.Controls.Add(this.materialFloatingActionButton2);
            this.tabPage1.Controls.Add(this.crd_gst);
            this.tabPage1.Controls.Add(this.materialFloatingActionButton1);
            this.tabPage1.Controls.Add(this.crd_tax);
            this.tabPage1.Controls.Add(this.materialFloatingActionButton3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.crd_balance);
            this.tabPage1.ImageKey = "icons8-home-32.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pic_graph
            // 
            this.pic_graph.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_graph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_graph.Image = global::BusinessApplication.Properties.Resources.pngwing_com;
            this.pic_graph.Location = new System.Drawing.Point(-38, 183);
            this.pic_graph.Margin = new System.Windows.Forms.Padding(0);
            this.pic_graph.Name = "pic_graph";
            this.pic_graph.Size = new System.Drawing.Size(647, 338);
            this.pic_graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_graph.TabIndex = 5;
            this.pic_graph.TabStop = false;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFloatingActionButton2.AnimateShowHideButton = false;
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.DrawShadows = true;
            this.materialFloatingActionButton2.Icon = global::BusinessApplication.Properties.Resources.icons8_refresh_32;
            this.materialFloatingActionButton2.ImageKey = "icons8-refresh-32.png";
            this.materialFloatingActionButton2.ImageList = this.imageList1;
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(778, 328);
            this.materialFloatingActionButton2.Mini = false;
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(57, 56);
            this.materialFloatingActionButton2.TabIndex = 17;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = false;
            this.materialFloatingActionButton2.Click += new System.EventHandler(this.materialFloatingActionButton2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-pay-64.png");
            this.imageList1.Images.SetKeyName(1, "icons8-bill-64.png");
            this.imageList1.Images.SetKeyName(2, "icons8-in-inventory-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-users-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-home-32.png");
            this.imageList1.Images.SetKeyName(5, "pngwing.com (2).png");
            this.imageList1.Images.SetKeyName(6, "icons8-mail-32.png");
            this.imageList1.Images.SetKeyName(7, "icons8-logout-32.png");
            // 
            // crd_gst
            // 
            this.crd_gst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crd_gst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crd_gst.Controls.Add(this.lbl_gst);
            this.crd_gst.Controls.Add(this.lbl_forGst);
            this.crd_gst.Depth = 0;
            this.crd_gst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crd_gst.Location = new System.Drawing.Point(623, 303);
            this.crd_gst.Margin = new System.Windows.Forms.Padding(14);
            this.crd_gst.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_gst.Name = "crd_gst";
            this.crd_gst.Padding = new System.Windows.Forms.Padding(14);
            this.crd_gst.Size = new System.Drawing.Size(186, 108);
            this.crd_gst.TabIndex = 16;
            // 
            // lbl_gst
            // 
            this.lbl_gst.AutoSize = true;
            this.lbl_gst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gst.Location = new System.Drawing.Point(16, 52);
            this.lbl_gst.Name = "lbl_gst";
            this.lbl_gst.Size = new System.Drawing.Size(66, 29);
            this.lbl_gst.TabIndex = 4;
            this.lbl_gst.Text = "17%";
            // 
            // lbl_forGst
            // 
            this.lbl_forGst.AutoSize = true;
            this.lbl_forGst.Depth = 0;
            this.lbl_forGst.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forGst.Location = new System.Drawing.Point(26, 18);
            this.lbl_forGst.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forGst.Name = "lbl_forGst";
            this.lbl_forGst.Size = new System.Drawing.Size(32, 19);
            this.lbl_forGst.TabIndex = 0;
            this.lbl_forGst.Text = "GST";
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFloatingActionButton1.AnimateShowHideButton = false;
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.DrawShadows = true;
            this.materialFloatingActionButton1.Icon = global::BusinessApplication.Properties.Resources.icons8_refresh_32;
            this.materialFloatingActionButton1.ImageKey = "icons8-refresh-32.png";
            this.materialFloatingActionButton1.ImageList = this.imageList1;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(778, 98);
            this.materialFloatingActionButton1.Mini = false;
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(57, 56);
            this.materialFloatingActionButton1.TabIndex = 15;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = false;
            this.materialFloatingActionButton1.Click += new System.EventHandler(this.materialFloatingActionButton1_Click);
            // 
            // crd_tax
            // 
            this.crd_tax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crd_tax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crd_tax.Controls.Add(this.lbl_tax);
            this.crd_tax.Controls.Add(this.lbl_forTax);
            this.crd_tax.Depth = 0;
            this.crd_tax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crd_tax.Location = new System.Drawing.Point(556, 73);
            this.crd_tax.Margin = new System.Windows.Forms.Padding(14);
            this.crd_tax.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_tax.Name = "crd_tax";
            this.crd_tax.Padding = new System.Windows.Forms.Padding(14);
            this.crd_tax.Size = new System.Drawing.Size(253, 108);
            this.crd_tax.TabIndex = 14;
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tax.Location = new System.Drawing.Point(30, 56);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(133, 29);
            this.lbl_tax.TabIndex = 4;
            this.lbl_tax.Text = "$6231734";
            // 
            // lbl_forTax
            // 
            this.lbl_forTax.AutoSize = true;
            this.lbl_forTax.Depth = 0;
            this.lbl_forTax.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forTax.Location = new System.Drawing.Point(32, 18);
            this.lbl_forTax.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forTax.Name = "lbl_forTax";
            this.lbl_forTax.Size = new System.Drawing.Size(71, 19);
            this.lbl_forTax.TabIndex = 0;
            this.lbl_forTax.Text = "Sales Tax";
            // 
            // materialFloatingActionButton3
            // 
            this.materialFloatingActionButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFloatingActionButton3.AnimateShowHideButton = false;
            this.materialFloatingActionButton3.Depth = 0;
            this.materialFloatingActionButton3.DrawShadows = true;
            this.materialFloatingActionButton3.Icon = global::BusinessApplication.Properties.Resources.icons8_refresh_32;
            this.materialFloatingActionButton3.ImageKey = "icons8-refresh-32.png";
            this.materialFloatingActionButton3.ImageList = this.imageList1;
            this.materialFloatingActionButton3.Location = new System.Drawing.Point(367, 98);
            this.materialFloatingActionButton3.Mini = false;
            this.materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.Size = new System.Drawing.Size(57, 56);
            this.materialFloatingActionButton3.TabIndex = 13;
            this.materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.UseVisualStyleBackColor = false;
            this.materialFloatingActionButton3.Click += new System.EventHandler(this.materialFloatingActionButton3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(868, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 57);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crd_balance
            // 
            this.crd_balance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crd_balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crd_balance.Controls.Add(this.lbl_balance);
            this.crd_balance.Controls.Add(this.lblforBalance);
            this.crd_balance.Depth = 0;
            this.crd_balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crd_balance.Location = new System.Drawing.Point(141, 73);
            this.crd_balance.Margin = new System.Windows.Forms.Padding(14);
            this.crd_balance.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_balance.Name = "crd_balance";
            this.crd_balance.Padding = new System.Windows.Forms.Padding(14);
            this.crd_balance.Size = new System.Drawing.Size(253, 108);
            this.crd_balance.TabIndex = 11;
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(30, 56);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(133, 29);
            this.lbl_balance.TabIndex = 4;
            this.lbl_balance.Text = "$6231734";
            // 
            // lblforBalance
            // 
            this.lblforBalance.AutoSize = true;
            this.lblforBalance.Depth = 0;
            this.lblforBalance.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblforBalance.Location = new System.Drawing.Point(32, 18);
            this.lblforBalance.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblforBalance.Name = "lblforBalance";
            this.lblforBalance.Size = new System.Drawing.Size(58, 19);
            this.lblforBalance.TabIndex = 0;
            this.lblforBalance.Text = "Balance";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gv_users);
            this.tabPage2.Controls.Add(this.btn_addUser);
            this.tabPage2.ImageKey = "icons8-users-32.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gv_users
            // 
            this.gv_users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gv_users.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.gv_users.Location = new System.Drawing.Point(68, 70);
            this.gv_users.Name = "gv_users";
            this.gv_users.ReadOnly = true;
            this.gv_users.Size = new System.Drawing.Size(816, 340);
            this.gv_users.TabIndex = 2;
            this.gv_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btn_addUser
            // 
            this.btn_addUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addUser.AutoSize = false;
            this.btn_addUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_addUser.Depth = 0;
            this.btn_addUser.DrawShadows = true;
            this.btn_addUser.HighEmphasis = true;
            this.btn_addUser.Icon = null;
            this.btn_addUser.Location = new System.Drawing.Point(757, 28);
            this.btn_addUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_addUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(112, 33);
            this.btn_addUser.TabIndex = 1;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_addUser.UseAccentColor = false;
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.crd_implemented);
            this.tabPage4.ImageKey = "icons8-mail-32.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(981, 488);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mail";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // crd_implemented
            // 
            this.crd_implemented.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crd_implemented.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crd_implemented.Controls.Add(this.lbl_implemented);
            this.crd_implemented.Depth = 0;
            this.crd_implemented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crd_implemented.Location = new System.Drawing.Point(341, 137);
            this.crd_implemented.Margin = new System.Windows.Forms.Padding(14);
            this.crd_implemented.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_implemented.Name = "crd_implemented";
            this.crd_implemented.Padding = new System.Windows.Forms.Padding(14);
            this.crd_implemented.Size = new System.Drawing.Size(200, 100);
            this.crd_implemented.TabIndex = 2;
            // 
            // lbl_implemented
            // 
            this.lbl_implemented.AutoSize = true;
            this.lbl_implemented.Depth = 0;
            this.lbl_implemented.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_implemented.Location = new System.Drawing.Point(28, 37);
            this.lbl_implemented.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_implemented.Name = "lbl_implemented";
            this.lbl_implemented.Size = new System.Drawing.Size(149, 19);
            this.lbl_implemented.TabIndex = 1;
            this.lbl_implemented.Text = "To be Implemented...";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialCard1);
            this.tabPage5.Controls.Add(this.gv_inventory);
            this.tabPage5.ImageKey = "icons8-in-inventory-32.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(981, 488);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Inventory";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbl_inventory);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(400, 8);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(117, 43);
            this.materialCard1.TabIndex = 3;
            // 
            // lbl_inventory
            // 
            this.lbl_inventory.AutoSize = true;
            this.lbl_inventory.Depth = 0;
            this.lbl_inventory.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_inventory.Location = new System.Drawing.Point(25, 12);
            this.lbl_inventory.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_inventory.Name = "lbl_inventory";
            this.lbl_inventory.Size = new System.Drawing.Size(66, 19);
            this.lbl_inventory.TabIndex = 2;
            this.lbl_inventory.Text = "Inventory";
            // 
            // gv_inventory
            // 
            this.gv_inventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gv_inventory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_inventory.Location = new System.Drawing.Point(31, 60);
            this.gv_inventory.Name = "gv_inventory";
            this.gv_inventory.ReadOnly = true;
            this.gv_inventory.Size = new System.Drawing.Size(865, 352);
            this.gv_inventory.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tab_tax);
            this.tabPage6.Controls.Add(this.tab_mischalleneous);
            this.tabPage6.Controls.Add(this.tab_rent);
            this.tabPage6.Controls.Add(this.tab_net);
            this.tabPage6.Controls.Add(this.tab_water);
            this.tabPage6.Controls.Add(this.tab_electricity);
            this.tabPage6.Controls.Add(this.materialButton2);
            this.tabPage6.ImageKey = "icons8-bill-64.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(981, 488);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Pay Bills";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tab_tax
            // 
            this.tab_tax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab_tax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab_tax.Controls.Add(this.materialLabel7);
            this.tab_tax.Controls.Add(this.materialTextBox4);
            this.tab_tax.Depth = 0;
            this.tab_tax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tab_tax.Location = new System.Drawing.Point(631, 215);
            this.tab_tax.Margin = new System.Windows.Forms.Padding(14);
            this.tab_tax.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_tax.Name = "tab_tax";
            this.tab_tax.Padding = new System.Windows.Forms.Padding(14);
            this.tab_tax.Size = new System.Drawing.Size(224, 133);
            this.tab_tax.TabIndex = 10;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.White;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabel7.Location = new System.Drawing.Point(30, 18);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(84, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Income Tax";
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox4.Location = new System.Drawing.Point(23, 69);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(177, 50);
            this.materialTextBox4.TabIndex = 11;
            this.materialTextBox4.Text = "";
            // 
            // tab_mischalleneous
            // 
            this.tab_mischalleneous.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab_mischalleneous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab_mischalleneous.Controls.Add(this.materialLabel8);
            this.tab_mischalleneous.Controls.Add(this.materialTextBox5);
            this.tab_mischalleneous.Depth = 0;
            this.tab_mischalleneous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tab_mischalleneous.Location = new System.Drawing.Point(359, 215);
            this.tab_mischalleneous.Margin = new System.Windows.Forms.Padding(14);
            this.tab_mischalleneous.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_mischalleneous.Name = "tab_mischalleneous";
            this.tab_mischalleneous.Padding = new System.Windows.Forms.Padding(14);
            this.tab_mischalleneous.Size = new System.Drawing.Size(224, 133);
            this.tab_mischalleneous.TabIndex = 8;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.White;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabel8.Location = new System.Drawing.Point(30, 18);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(112, 19);
            this.materialLabel8.TabIndex = 8;
            this.materialLabel8.Text = "Mischalleneous";
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox5.Location = new System.Drawing.Point(23, 69);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.Size = new System.Drawing.Size(177, 50);
            this.materialTextBox5.TabIndex = 9;
            this.materialTextBox5.Text = "";
            // 
            // tab_rent
            // 
            this.tab_rent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab_rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab_rent.Controls.Add(this.materialLabel9);
            this.tab_rent.Controls.Add(this.materialTextBox6);
            this.tab_rent.Depth = 0;
            this.tab_rent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tab_rent.Location = new System.Drawing.Point(89, 215);
            this.tab_rent.Margin = new System.Windows.Forms.Padding(14);
            this.tab_rent.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_rent.Name = "tab_rent";
            this.tab_rent.Padding = new System.Windows.Forms.Padding(14);
            this.tab_rent.Size = new System.Drawing.Size(224, 133);
            this.tab_rent.TabIndex = 2;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.White;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabel9.Location = new System.Drawing.Point(30, 14);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(33, 19);
            this.materialLabel9.TabIndex = 6;
            this.materialLabel9.Text = "Rent";
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox6.Location = new System.Drawing.Point(23, 65);
            this.materialTextBox6.MaxLength = 50;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.Size = new System.Drawing.Size(177, 50);
            this.materialTextBox6.TabIndex = 7;
            this.materialTextBox6.Text = "";
            // 
            // tab_net
            // 
            this.tab_net.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab_net.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab_net.Controls.Add(this.materialLabel6);
            this.tab_net.Controls.Add(this.materialTextBox3);
            this.tab_net.Depth = 0;
            this.tab_net.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tab_net.Location = new System.Drawing.Point(631, 37);
            this.tab_net.Margin = new System.Windows.Forms.Padding(14);
            this.tab_net.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_net.Name = "tab_net";
            this.tab_net.Padding = new System.Windows.Forms.Padding(14);
            this.tab_net.Size = new System.Drawing.Size(224, 133);
            this.tab_net.TabIndex = 15;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.White;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel6.Location = new System.Drawing.Point(30, 14);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(54, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Internet";
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox3.Location = new System.Drawing.Point(23, 65);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(177, 50);
            this.materialTextBox3.TabIndex = 5;
            this.materialTextBox3.Text = "";
            // 
            // tab_water
            // 
            this.tab_water.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab_water.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab_water.Controls.Add(this.materialLabel4);
            this.tab_water.Controls.Add(this.materialTextBox2);
            this.tab_water.Depth = 0;
            this.tab_water.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tab_water.Location = new System.Drawing.Point(359, 37);
            this.tab_water.Margin = new System.Windows.Forms.Padding(14);
            this.tab_water.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_water.Name = "tab_water";
            this.tab_water.Padding = new System.Windows.Forms.Padding(14);
            this.tab_water.Size = new System.Drawing.Size(224, 133);
            this.tab_water.TabIndex = 14;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.White;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabel4.Location = new System.Drawing.Point(30, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Water";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox2.Location = new System.Drawing.Point(23, 65);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(177, 50);
            this.materialTextBox2.TabIndex = 3;
            this.materialTextBox2.Text = "";
            // 
            // tab_electricity
            // 
            this.tab_electricity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab_electricity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab_electricity.Controls.Add(this.materialLabel3);
            this.tab_electricity.Controls.Add(this.materialTextBox1);
            this.tab_electricity.Depth = 0;
            this.tab_electricity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tab_electricity.Location = new System.Drawing.Point(89, 37);
            this.tab_electricity.Margin = new System.Windows.Forms.Padding(14);
            this.tab_electricity.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_electricity.Name = "tab_electricity";
            this.tab_electricity.Padding = new System.Windows.Forms.Padding(14);
            this.tab_electricity.Size = new System.Drawing.Size(224, 133);
            this.tab_electricity.TabIndex = 13;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabel3.Location = new System.Drawing.Point(30, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Electricity";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.Location = new System.Drawing.Point(23, 65);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(177, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(411, 388);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(125, 38);
            this.materialButton2.TabIndex = 12;
            this.materialButton2.Text = "Pay Now";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 531);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form_Admin";
            this.Text = "Admin Portal";
            this.Load += new System.EventHandler(this.Form_Admin_Load_1);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_graph)).EndInit();
            this.crd_gst.ResumeLayout(false);
            this.crd_gst.PerformLayout();
            this.crd_tax.ResumeLayout(false);
            this.crd_tax.PerformLayout();
            this.crd_balance.ResumeLayout(false);
            this.crd_balance.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_users)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.crd_implemented.ResumeLayout(false);
            this.crd_implemented.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_inventory)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tab_tax.ResumeLayout(false);
            this.tab_tax.PerformLayout();
            this.tab_mischalleneous.ResumeLayout(false);
            this.tab_mischalleneous.PerformLayout();
            this.tab_rent.ResumeLayout(false);
            this.tab_rent.PerformLayout();
            this.tab_net.ResumeLayout(false);
            this.tab_net.PerformLayout();
            this.tab_water.ResumeLayout(false);
            this.tab_water.PerformLayout();
            this.tab_electricity.ResumeLayout(false);
            this.tab_electricity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialButton btn_addUser;
        private System.Windows.Forms.DataGridView gv_users;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private MaterialSkin.Controls.MaterialCard crd_balance;
        private System.Windows.Forms.Label lbl_balance;
        private MaterialSkin.Controls.MaterialLabel lblforBalance;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialCard crd_tax;
        private System.Windows.Forms.Label lbl_tax;
        private MaterialSkin.Controls.MaterialLabel lbl_forTax;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard crd_gst;
        private System.Windows.Forms.Label lbl_gst;
        private MaterialSkin.Controls.MaterialLabel lbl_forGst;
        private System.Windows.Forms.PictureBox pic_graph;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel lbl_implemented;
        private MaterialSkin.Controls.MaterialCard crd_implemented;
        private MaterialSkin.Controls.MaterialCard tab_tax;
        private MaterialSkin.Controls.MaterialCard tab_mischalleneous;
        private MaterialSkin.Controls.MaterialCard tab_rent;
        private MaterialSkin.Controls.MaterialCard tab_net;
        private MaterialSkin.Controls.MaterialCard tab_water;
        private MaterialSkin.Controls.MaterialCard tab_electricity;
        private System.Windows.Forms.DataGridView gv_inventory;
        private MaterialSkin.Controls.MaterialLabel lbl_inventory;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}