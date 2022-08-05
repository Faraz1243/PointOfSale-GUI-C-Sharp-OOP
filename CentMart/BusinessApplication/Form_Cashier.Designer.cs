using System.Collections.Generic;

namespace BusinessApplication
{
    partial class Form_Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cashier));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_forDate = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_forAddress = new MaterialSkin.Controls.MaterialLabel();
            this.crd_cnic = new MaterialSkin.Controls.MaterialCard();
            this.materialProgressBar4 = new MaterialSkin.Controls.MaterialProgressBar();
            this.lbl_cnic = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_forCnic = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_forPhone = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_forEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_forName = new MaterialSkin.Controls.MaterialLabel();
            this.crd_date = new MaterialSkin.Controls.MaterialCard();
            this.materialProgressBar5 = new MaterialSkin.Controls.MaterialProgressBar();
            this.lbl_date = new MaterialSkin.Controls.MaterialLabel();
            this.crd_address = new MaterialSkin.Controls.MaterialCard();
            this.materialProgressBar6 = new MaterialSkin.Controls.MaterialProgressBar();
            this.lbl_address = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.crd_phone = new MaterialSkin.Controls.MaterialCard();
            this.materialProgressBar3 = new MaterialSkin.Controls.MaterialProgressBar();
            this.lbl_phone = new MaterialSkin.Controls.MaterialLabel();
            this.crd_email = new MaterialSkin.Controls.MaterialCard();
            this.materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.lbl_email = new MaterialSkin.Controls.MaterialLabel();
            this.crd_name = new MaterialSkin.Controls.MaterialCard();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.lbl_name = new MaterialSkin.Controls.MaterialLabel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.txt_finalBill = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_total = new MaterialSkin.Controls.MaterialLabel();
            this.btn_checkout = new MaterialSkin.Controls.MaterialButton();
            this.card_input = new MaterialSkin.Controls.MaterialCard();
            this.lbl_quantity = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_barcode = new MaterialSkin.Controls.MaterialLabel();
            this.txt_barcode = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.txt_quantity = new MaterialSkin.Controls.MaterialTextBox();
            this.gv_cart = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.crd_implemented = new MaterialSkin.Controls.MaterialCard();
            this.txt_implemented = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pic_lock = new System.Windows.Forms.PictureBox();
            this.btn_changePass = new MaterialSkin.Controls.MaterialButton();
            this.txt_newPass2 = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_newPass2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_newPass1 = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_newPass1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_pass = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.crd_cnic.SuspendLayout();
            this.crd_date.SuspendLayout();
            this.crd_address.SuspendLayout();
            this.crd_phone.SuspendLayout();
            this.crd_email.SuspendLayout();
            this.crd_name.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard9.SuspendLayout();
            this.card_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cart)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.crd_implemented.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lock)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(800, 473);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_forDate);
            this.tabPage1.Controls.Add(this.lbl_forAddress);
            this.tabPage1.Controls.Add(this.crd_cnic);
            this.tabPage1.Controls.Add(this.lbl_forCnic);
            this.tabPage1.Controls.Add(this.lbl_forPhone);
            this.tabPage1.Controls.Add(this.lbl_forEmail);
            this.tabPage1.Controls.Add(this.lbl_forName);
            this.tabPage1.Controls.Add(this.crd_date);
            this.tabPage1.Controls.Add(this.crd_address);
            this.tabPage1.Controls.Add(this.crd_phone);
            this.tabPage1.Controls.Add(this.crd_email);
            this.tabPage1.Controls.Add(this.crd_name);
            this.tabPage1.Controls.Add(this.btn_logout);
            this.tabPage1.ImageKey = "icons8-male-user-32.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_forDate
            // 
            this.lbl_forDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forDate.AutoSize = true;
            this.lbl_forDate.BackColor = System.Drawing.Color.IndianRed;
            this.lbl_forDate.Depth = 0;
            this.lbl_forDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_forDate.Location = new System.Drawing.Point(515, 182);
            this.lbl_forDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forDate.Name = "lbl_forDate";
            this.lbl_forDate.Size = new System.Drawing.Size(69, 19);
            this.lbl_forDate.TabIndex = 11;
            this.lbl_forDate.Text = "Join Date";
            // 
            // lbl_forAddress
            // 
            this.lbl_forAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forAddress.AutoSize = true;
            this.lbl_forAddress.BackColor = System.Drawing.Color.IndianRed;
            this.lbl_forAddress.Depth = 0;
            this.lbl_forAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forAddress.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_forAddress.Location = new System.Drawing.Point(287, 182);
            this.lbl_forAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forAddress.Name = "lbl_forAddress";
            this.lbl_forAddress.Size = new System.Drawing.Size(58, 19);
            this.lbl_forAddress.TabIndex = 10;
            this.lbl_forAddress.Text = "Address";
            // 
            // crd_cnic
            // 
            this.crd_cnic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crd_cnic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crd_cnic.Controls.Add(this.materialProgressBar4);
            this.crd_cnic.Controls.Add(this.lbl_cnic);
            this.crd_cnic.Depth = 0;
            this.crd_cnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crd_cnic.Location = new System.Drawing.Point(56, 215);
            this.crd_cnic.Margin = new System.Windows.Forms.Padding(14);
            this.crd_cnic.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_cnic.Name = "crd_cnic";
            this.crd_cnic.Padding = new System.Windows.Forms.Padding(14);
            this.crd_cnic.Size = new System.Drawing.Size(188, 51);
            this.crd_cnic.TabIndex = 5;
            // 
            // materialProgressBar4
            // 
            this.materialProgressBar4.Depth = 0;
            this.materialProgressBar4.Location = new System.Drawing.Point(0, 43);
            this.materialProgressBar4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar4.Name = "materialProgressBar4";
            this.materialProgressBar4.Size = new System.Drawing.Size(188, 5);
            this.materialProgressBar4.TabIndex = 2;
            this.materialProgressBar4.Value = 99;
            // 
            // lbl_cnic
            // 
            this.lbl_cnic.AutoSize = true;
            this.lbl_cnic.Depth = 0;
            this.lbl_cnic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_cnic.Location = new System.Drawing.Point(17, 17);
            this.lbl_cnic.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_cnic.Name = "lbl_cnic";
            this.lbl_cnic.Size = new System.Drawing.Size(54, 19);
            this.lbl_cnic.TabIndex = 0;
            this.lbl_cnic.Text = "lbl_cnic";
            // 
            // lbl_forCnic
            // 
            this.lbl_forCnic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forCnic.AutoSize = true;
            this.lbl_forCnic.BackColor = System.Drawing.Color.IndianRed;
            this.lbl_forCnic.Depth = 0;
            this.lbl_forCnic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forCnic.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_forCnic.Location = new System.Drawing.Point(53, 182);
            this.lbl_forCnic.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forCnic.Name = "lbl_forCnic";
            this.lbl_forCnic.Size = new System.Drawing.Size(36, 19);
            this.lbl_forCnic.TabIndex = 9;
            this.lbl_forCnic.Text = "CNIC";
            // 
            // lbl_forPhone
            // 
            this.lbl_forPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forPhone.AutoSize = true;
            this.lbl_forPhone.BackColor = System.Drawing.Color.IndianRed;
            this.lbl_forPhone.Depth = 0;
            this.lbl_forPhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forPhone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_forPhone.Location = new System.Drawing.Point(515, 48);
            this.lbl_forPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forPhone.Name = "lbl_forPhone";
            this.lbl_forPhone.Size = new System.Drawing.Size(46, 19);
            this.lbl_forPhone.TabIndex = 8;
            this.lbl_forPhone.Text = "Phone";
            // 
            // lbl_forEmail
            // 
            this.lbl_forEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forEmail.AutoSize = true;
            this.lbl_forEmail.BackColor = System.Drawing.Color.IndianRed;
            this.lbl_forEmail.Depth = 0;
            this.lbl_forEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forEmail.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_forEmail.Location = new System.Drawing.Point(287, 48);
            this.lbl_forEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forEmail.Name = "lbl_forEmail";
            this.lbl_forEmail.Size = new System.Drawing.Size(41, 19);
            this.lbl_forEmail.TabIndex = 7;
            this.lbl_forEmail.Text = "Email";
            // 
            // lbl_forName
            // 
            this.lbl_forName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forName.AutoSize = true;
            this.lbl_forName.BackColor = System.Drawing.Color.IndianRed;
            this.lbl_forName.Depth = 0;
            this.lbl_forName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_forName.Location = new System.Drawing.Point(53, 48);
            this.lbl_forName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forName.Name = "lbl_forName";
            this.lbl_forName.Size = new System.Drawing.Size(43, 19);
            this.lbl_forName.TabIndex = 6;
            this.lbl_forName.Text = "Name";
            // 
            // crd_date
            // 
            this.crd_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crd_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crd_date.Controls.Add(this.materialProgressBar5);
            this.crd_date.Controls.Add(this.lbl_date);
            this.crd_date.Depth = 0;
            this.crd_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crd_date.Location = new System.Drawing.Point(518, 215);
            this.crd_date.Margin = new System.Windows.Forms.Padding(14);
            this.crd_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_date.Name = "crd_date";
            this.crd_date.Padding = new System.Windows.Forms.Padding(14);
            this.crd_date.Size = new System.Drawing.Size(188, 51);
            this.crd_date.TabIndex = 4;
            // 
            // materialProgressBar5
            // 
            this.materialProgressBar5.Depth = 0;
            this.materialProgressBar5.Location = new System.Drawing.Point(0, 43);
            this.materialProgressBar5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar5.Name = "materialProgressBar5";
            this.materialProgressBar5.Size = new System.Drawing.Size(188, 5);
            this.materialProgressBar5.TabIndex = 3;
            this.materialProgressBar5.Value = 99;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Depth = 0;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_date.Location = new System.Drawing.Point(17, 17);
            this.lbl_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(56, 19);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "lbl_date";
            // 
            // crd_address
            // 
            this.crd_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crd_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crd_address.Controls.Add(this.materialProgressBar6);
            this.crd_address.Controls.Add(this.lbl_address);
            this.crd_address.Depth = 0;
            this.crd_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crd_address.Location = new System.Drawing.Point(290, 215);
            this.crd_address.Margin = new System.Windows.Forms.Padding(14);
            this.crd_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_address.Name = "crd_address";
            this.crd_address.Padding = new System.Windows.Forms.Padding(14);
            this.crd_address.Size = new System.Drawing.Size(188, 103);
            this.crd_address.TabIndex = 4;
            // 
            // materialProgressBar6
            // 
            this.materialProgressBar6.Depth = 0;
            this.materialProgressBar6.Location = new System.Drawing.Point(0, 95);
            this.materialProgressBar6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar6.Name = "materialProgressBar6";
            this.materialProgressBar6.Size = new System.Drawing.Size(188, 5);
            this.materialProgressBar6.TabIndex = 4;
            this.materialProgressBar6.Value = 99;
            // 
            // lbl_address
            // 
            this.lbl_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_address.Depth = 0;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_address.Hint = "";
            this.lbl_address.Location = new System.Drawing.Point(12, 7);
            this.lbl_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(164, 82);
            this.lbl_address.TabIndex = 0;
            this.lbl_address.Text = "lbl_address";
            // 
            // crd_phone
            // 
            this.crd_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crd_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crd_phone.Controls.Add(this.materialProgressBar3);
            this.crd_phone.Controls.Add(this.lbl_phone);
            this.crd_phone.Depth = 0;
            this.crd_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crd_phone.Location = new System.Drawing.Point(518, 81);
            this.crd_phone.Margin = new System.Windows.Forms.Padding(14);
            this.crd_phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_phone.Name = "crd_phone";
            this.crd_phone.Padding = new System.Windows.Forms.Padding(14);
            this.crd_phone.Size = new System.Drawing.Size(188, 51);
            this.crd_phone.TabIndex = 4;
            // 
            // materialProgressBar3
            // 
            this.materialProgressBar3.Depth = 0;
            this.materialProgressBar3.Location = new System.Drawing.Point(0, 43);
            this.materialProgressBar3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar3.Name = "materialProgressBar3";
            this.materialProgressBar3.Size = new System.Drawing.Size(188, 5);
            this.materialProgressBar3.TabIndex = 13;
            this.materialProgressBar3.Value = 99;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Depth = 0;
            this.lbl_phone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_phone.Location = new System.Drawing.Point(17, 17);
            this.lbl_phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(69, 19);
            this.lbl_phone.TabIndex = 0;
            this.lbl_phone.Text = "lbl_phone";
            // 
            // crd_email
            // 
            this.crd_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crd_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crd_email.Controls.Add(this.materialProgressBar2);
            this.crd_email.Controls.Add(this.lbl_email);
            this.crd_email.Depth = 0;
            this.crd_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crd_email.Location = new System.Drawing.Point(290, 81);
            this.crd_email.Margin = new System.Windows.Forms.Padding(14);
            this.crd_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_email.Name = "crd_email";
            this.crd_email.Padding = new System.Windows.Forms.Padding(14);
            this.crd_email.Size = new System.Drawing.Size(188, 51);
            this.crd_email.TabIndex = 4;
            // 
            // materialProgressBar2
            // 
            this.materialProgressBar2.Depth = 0;
            this.materialProgressBar2.Location = new System.Drawing.Point(0, 43);
            this.materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar2.Name = "materialProgressBar2";
            this.materialProgressBar2.Size = new System.Drawing.Size(188, 5);
            this.materialProgressBar2.TabIndex = 12;
            this.materialProgressBar2.Value = 99;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Depth = 0;
            this.lbl_email.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_email.Location = new System.Drawing.Point(17, 17);
            this.lbl_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(64, 19);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "lbl_email";
            // 
            // crd_name
            // 
            this.crd_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crd_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crd_name.Controls.Add(this.materialProgressBar1);
            this.crd_name.Controls.Add(this.lbl_name);
            this.crd_name.Depth = 0;
            this.crd_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crd_name.Location = new System.Drawing.Point(56, 81);
            this.crd_name.Margin = new System.Windows.Forms.Padding(14);
            this.crd_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_name.Name = "crd_name";
            this.crd_name.Padding = new System.Windows.Forms.Padding(14);
            this.crd_name.Size = new System.Drawing.Size(188, 51);
            this.crd_name.TabIndex = 3;
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(0, 43);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(188, 5);
            this.materialProgressBar1.TabIndex = 1;
            this.materialProgressBar1.Value = 99;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Depth = 0;
            this.lbl_name.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_name.Location = new System.Drawing.Point(17, 17);
            this.lbl_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 19);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "lbl_name";
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Location = new System.Drawing.Point(704, 332);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(52, 57);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialCard9);
            this.tabPage2.Controls.Add(this.btn_checkout);
            this.tabPage2.Controls.Add(this.card_input);
            this.tabPage2.Controls.Add(this.gv_cart);
            this.tabPage2.ImageKey = "icons8-receipt-32.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Invoice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialCard9
            // 
            this.materialCard9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Controls.Add(this.txt_finalBill);
            this.materialCard9.Controls.Add(this.lbl_total);
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(44, 350);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(166, 47);
            this.materialCard9.TabIndex = 7;
            // 
            // txt_finalBill
            // 
            this.txt_finalBill.AutoSize = true;
            this.txt_finalBill.Depth = 0;
            this.txt_finalBill.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_finalBill.Location = new System.Drawing.Point(80, 14);
            this.txt_finalBill.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_finalBill.Name = "txt_finalBill";
            this.txt_finalBill.Size = new System.Drawing.Size(37, 19);
            this.txt_finalBill.TabIndex = 1;
            this.txt_finalBill.Text = "1221";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Depth = 0;
            this.lbl_total.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_total.Location = new System.Drawing.Point(12, 14);
            this.lbl_total.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(46, 19);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "Total :";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_checkout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_checkout.Depth = 0;
            this.btn_checkout.DrawShadows = true;
            this.btn_checkout.HighEmphasis = true;
            this.btn_checkout.Icon = null;
            this.btn_checkout.Location = new System.Drawing.Point(610, 354);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_checkout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(98, 36);
            this.btn_checkout.TabIndex = 6;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_checkout.UseAccentColor = false;
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // card_input
            // 
            this.card_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.card_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card_input.Controls.Add(this.lbl_quantity);
            this.card_input.Controls.Add(this.lbl_barcode);
            this.card_input.Controls.Add(this.txt_barcode);
            this.card_input.Controls.Add(this.materialButton2);
            this.card_input.Controls.Add(this.txt_quantity);
            this.card_input.Depth = 0;
            this.card_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.card_input.Location = new System.Drawing.Point(44, 14);
            this.card_input.Margin = new System.Windows.Forms.Padding(14);
            this.card_input.MouseState = MaterialSkin.MouseState.HOVER;
            this.card_input.Name = "card_input";
            this.card_input.Padding = new System.Windows.Forms.Padding(14);
            this.card_input.Size = new System.Drawing.Size(664, 84);
            this.card_input.TabIndex = 5;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Depth = 0;
            this.lbl_quantity.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_quantity.Location = new System.Drawing.Point(270, 5);
            this.lbl_quantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(61, 19);
            this.lbl_quantity.TabIndex = 6;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.AutoSize = true;
            this.lbl_barcode.Depth = 0;
            this.lbl_barcode.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_barcode.Location = new System.Drawing.Point(18, 5);
            this.lbl_barcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(59, 19);
            this.lbl_barcode.TabIndex = 5;
            this.lbl_barcode.Text = "Barcode";
            // 
            // txt_barcode
            // 
            this.txt_barcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_barcode.Depth = 0;
            this.txt_barcode.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_barcode.Location = new System.Drawing.Point(15, 26);
            this.txt_barcode.MaxLength = 50;
            this.txt_barcode.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_barcode.Multiline = false;
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(161, 50);
            this.txt_barcode.TabIndex = 0;
            this.txt_barcode.Text = "";
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
            this.materialButton2.Location = new System.Drawing.Point(526, 32);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(99, 32);
            this.materialButton2.TabIndex = 4;
            this.materialButton2.Text = "Add";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_quantity.Depth = 0;
            this.txt_quantity.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_quantity.Location = new System.Drawing.Point(271, 25);
            this.txt_quantity.MaxLength = 50;
            this.txt_quantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_quantity.Multiline = false;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(149, 50);
            this.txt_quantity.TabIndex = 2;
            this.txt_quantity.Text = "";
            // 
            // gv_cart
            // 
            this.gv_cart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gv_cart.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.gv_cart.Location = new System.Drawing.Point(44, 115);
            this.gv_cart.Name = "gv_cart";
            this.gv_cart.ReadOnly = true;
            this.gv_cart.Size = new System.Drawing.Size(664, 216);
            this.gv_cart.TabIndex = 3;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.crd_implemented);
            this.tabPage3.ImageKey = "icons8-mail-32.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mail";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // crd_implemented
            // 
            this.crd_implemented.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crd_implemented.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crd_implemented.Controls.Add(this.txt_implemented);
            this.crd_implemented.Depth = 0;
            this.crd_implemented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crd_implemented.Location = new System.Drawing.Point(282, 139);
            this.crd_implemented.Margin = new System.Windows.Forms.Padding(14);
            this.crd_implemented.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_implemented.Name = "crd_implemented";
            this.crd_implemented.Padding = new System.Windows.Forms.Padding(14);
            this.crd_implemented.Size = new System.Drawing.Size(200, 100);
            this.crd_implemented.TabIndex = 2;
            // 
            // txt_implemented
            // 
            this.txt_implemented.AutoSize = true;
            this.txt_implemented.Depth = 0;
            this.txt_implemented.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_implemented.Location = new System.Drawing.Point(27, 39);
            this.txt_implemented.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_implemented.Name = "txt_implemented";
            this.txt_implemented.Size = new System.Drawing.Size(149, 19);
            this.txt_implemented.TabIndex = 1;
            this.txt_implemented.Text = "To be Implemented...";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pic_lock);
            this.tabPage4.Controls.Add(this.btn_changePass);
            this.tabPage4.Controls.Add(this.txt_newPass2);
            this.tabPage4.Controls.Add(this.lbl_newPass2);
            this.tabPage4.Controls.Add(this.txt_newPass1);
            this.tabPage4.Controls.Add(this.lbl_newPass1);
            this.tabPage4.Controls.Add(this.txt_password);
            this.tabPage4.Controls.Add(this.lbl_pass);
            this.tabPage4.ImageKey = "icons8-access-32.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 430);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Credential";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pic_lock
            // 
            this.pic_lock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_lock.BackgroundImage = global::BusinessApplication.Properties.Resources.pngwing_com__1_;
            this.pic_lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_lock.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_lock.InitialImage")));
            this.pic_lock.Location = new System.Drawing.Point(456, 54);
            this.pic_lock.Name = "pic_lock";
            this.pic_lock.Size = new System.Drawing.Size(199, 200);
            this.pic_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_lock.TabIndex = 7;
            this.pic_lock.TabStop = false;
            // 
            // btn_changePass
            // 
            this.btn_changePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_changePass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_changePass.Depth = 0;
            this.btn_changePass.DrawShadows = true;
            this.btn_changePass.HighEmphasis = true;
            this.btn_changePass.Icon = null;
            this.btn_changePass.Location = new System.Drawing.Point(477, 308);
            this.btn_changePass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_changePass.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_changePass.Name = "btn_changePass";
            this.btn_changePass.Size = new System.Drawing.Size(163, 36);
            this.btn_changePass.TabIndex = 6;
            this.btn_changePass.Text = "Change Password";
            this.btn_changePass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_changePass.UseAccentColor = false;
            this.btn_changePass.UseVisualStyleBackColor = true;
            this.btn_changePass.Click += new System.EventHandler(this.btn_changePass_Click);
            // 
            // txt_newPass2
            // 
            this.txt_newPass2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_newPass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_newPass2.Depth = 0;
            this.txt_newPass2.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_newPass2.Location = new System.Drawing.Point(179, 294);
            this.txt_newPass2.MaxLength = 50;
            this.txt_newPass2.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_newPass2.Multiline = false;
            this.txt_newPass2.Name = "txt_newPass2";
            this.txt_newPass2.Size = new System.Drawing.Size(201, 50);
            this.txt_newPass2.TabIndex = 5;
            this.txt_newPass2.Text = "";
            // 
            // lbl_newPass2
            // 
            this.lbl_newPass2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_newPass2.AutoSize = true;
            this.lbl_newPass2.Depth = 0;
            this.lbl_newPass2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_newPass2.Location = new System.Drawing.Point(176, 272);
            this.lbl_newPass2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_newPass2.Name = "lbl_newPass2";
            this.lbl_newPass2.Size = new System.Drawing.Size(132, 19);
            this.lbl_newPass2.TabIndex = 4;
            this.lbl_newPass2.Text = "Confirm Password";
            // 
            // txt_newPass1
            // 
            this.txt_newPass1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_newPass1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_newPass1.Depth = 0;
            this.txt_newPass1.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_newPass1.Location = new System.Drawing.Point(179, 204);
            this.txt_newPass1.MaxLength = 50;
            this.txt_newPass1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_newPass1.Multiline = false;
            this.txt_newPass1.Name = "txt_newPass1";
            this.txt_newPass1.Size = new System.Drawing.Size(201, 50);
            this.txt_newPass1.TabIndex = 3;
            this.txt_newPass1.Text = "";
            // 
            // lbl_newPass1
            // 
            this.lbl_newPass1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_newPass1.AutoSize = true;
            this.lbl_newPass1.Depth = 0;
            this.lbl_newPass1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_newPass1.Location = new System.Drawing.Point(176, 182);
            this.lbl_newPass1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_newPass1.Name = "lbl_newPass1";
            this.lbl_newPass1.Size = new System.Drawing.Size(106, 19);
            this.lbl_newPass1.TabIndex = 2;
            this.lbl_newPass1.Text = "New Password";
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_password.Location = new System.Drawing.Point(179, 70);
            this.txt_password.MaxLength = 50;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(201, 50);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "";
            // 
            // lbl_pass
            // 
            this.lbl_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Depth = 0;
            this.lbl_pass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_pass.Location = new System.Drawing.Point(176, 48);
            this.lbl_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(99, 19);
            this.lbl_pass.TabIndex = 0;
            this.lbl_pass.Text = "Old Password";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-male-user-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-access-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-mail-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-receipt-32.png");
            // 
            // Form_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form_Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Form_Cashier_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.crd_cnic.ResumeLayout(false);
            this.crd_cnic.PerformLayout();
            this.crd_date.ResumeLayout(false);
            this.crd_date.PerformLayout();
            this.crd_address.ResumeLayout(false);
            this.crd_phone.ResumeLayout(false);
            this.crd_phone.PerformLayout();
            this.crd_email.ResumeLayout(false);
            this.crd_email.PerformLayout();
            this.crd_name.ResumeLayout(false);
            this.crd_name.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialCard9.ResumeLayout(false);
            this.materialCard9.PerformLayout();
            this.card_input.ResumeLayout(false);
            this.card_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.crd_implemented.ResumeLayout(false);
            this.crd_implemented.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_logout;
        private MaterialSkin.Controls.MaterialLabel lbl_forDate;
        private MaterialSkin.Controls.MaterialLabel lbl_forAddress;
        private MaterialSkin.Controls.MaterialLabel lbl_forCnic;
        private MaterialSkin.Controls.MaterialLabel lbl_forPhone;
        private MaterialSkin.Controls.MaterialLabel lbl_forEmail;
        private MaterialSkin.Controls.MaterialLabel lbl_forName;
        private MaterialSkin.Controls.MaterialCard crd_date;
        private MaterialSkin.Controls.MaterialLabel lbl_date;
        private MaterialSkin.Controls.MaterialCard crd_address;
        private MaterialSkin.Controls.MaterialCard crd_cnic;
        private MaterialSkin.Controls.MaterialLabel lbl_cnic;
        private MaterialSkin.Controls.MaterialCard crd_phone;
        private MaterialSkin.Controls.MaterialLabel lbl_phone;
        private MaterialSkin.Controls.MaterialCard crd_email;
        private MaterialSkin.Controls.MaterialLabel lbl_email;
        private MaterialSkin.Controls.MaterialCard crd_name;
        private MaterialSkin.Controls.MaterialLabel lbl_name;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox lbl_address;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar4;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar5;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar6;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar3;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
        private System.Windows.Forms.PictureBox pic_lock;
        private MaterialSkin.Controls.MaterialButton btn_changePass;
        private MaterialSkin.Controls.MaterialTextBox txt_newPass2;
        private MaterialSkin.Controls.MaterialLabel lbl_newPass2;
        private MaterialSkin.Controls.MaterialTextBox txt_newPass1;
        private MaterialSkin.Controls.MaterialLabel lbl_newPass1;
        private MaterialSkin.Controls.MaterialTextBox txt_password;
        private MaterialSkin.Controls.MaterialLabel lbl_pass;
        private MaterialSkin.Controls.MaterialLabel txt_implemented;
        private MaterialSkin.Controls.MaterialCard crd_implemented;
        private MaterialSkin.Controls.MaterialTextBox txt_quantity;
        private MaterialSkin.Controls.MaterialTextBox txt_barcode;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialLabel txt_finalBill;
        private MaterialSkin.Controls.MaterialLabel lbl_total;
        private MaterialSkin.Controls.MaterialButton btn_checkout;
        private MaterialSkin.Controls.MaterialCard card_input;
        private MaterialSkin.Controls.MaterialLabel lbl_quantity;
        private MaterialSkin.Controls.MaterialLabel lbl_barcode;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.DataGridView gv_cart;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}