using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace BusinessApplication
{
    partial class Form_InventoryController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InventoryController));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
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
            this.btn_addProduct = new MaterialSkin.Controls.MaterialButton();
            this.gv_inventory = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.crd_implemented = new MaterialSkin.Controls.MaterialCard();
            this.lbl_implemented = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_changePassword = new MaterialSkin.Controls.MaterialButton();
            this.txt_newPassword2 = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_newPassword2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_newPassword1 = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_newPassword1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_oldPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_password = new MaterialSkin.Controls.MaterialLabel();
            this.gv_shelf = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.crd_cnic.SuspendLayout();
            this.crd_date.SuspendLayout();
            this.crd_address.SuspendLayout();
            this.crd_phone.SuspendLayout();
            this.crd_email.SuspendLayout();
            this.crd_name.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_inventory)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.crd_implemented.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_shelf)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-male-user-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-access-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-shelf-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-in-inventory-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-mail-32.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(852, 503);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialLabel12);
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
            this.tabPage1.Size = new System.Drawing.Size(844, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel12
            // 
            this.materialLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(533, 220);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(69, 19);
            this.materialLabel12.TabIndex = 23;
            this.materialLabel12.Text = "Join Date";
            // 
            // lbl_forAddress
            // 
            this.lbl_forAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forAddress.AutoSize = true;
            this.lbl_forAddress.Depth = 0;
            this.lbl_forAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forAddress.Location = new System.Drawing.Point(305, 220);
            this.lbl_forAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forAddress.Name = "lbl_forAddress";
            this.lbl_forAddress.Size = new System.Drawing.Size(58, 19);
            this.lbl_forAddress.TabIndex = 22;
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
            this.crd_cnic.Location = new System.Drawing.Point(74, 253);
            this.crd_cnic.Margin = new System.Windows.Forms.Padding(14);
            this.crd_cnic.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_cnic.Name = "crd_cnic";
            this.crd_cnic.Padding = new System.Windows.Forms.Padding(14);
            this.crd_cnic.Size = new System.Drawing.Size(188, 51);
            this.crd_cnic.TabIndex = 17;
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
            this.lbl_forCnic.Depth = 0;
            this.lbl_forCnic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forCnic.Location = new System.Drawing.Point(71, 220);
            this.lbl_forCnic.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forCnic.Name = "lbl_forCnic";
            this.lbl_forCnic.Size = new System.Drawing.Size(36, 19);
            this.lbl_forCnic.TabIndex = 21;
            this.lbl_forCnic.Text = "CNIC";
            // 
            // lbl_forPhone
            // 
            this.lbl_forPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forPhone.AutoSize = true;
            this.lbl_forPhone.Depth = 0;
            this.lbl_forPhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forPhone.Location = new System.Drawing.Point(533, 86);
            this.lbl_forPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forPhone.Name = "lbl_forPhone";
            this.lbl_forPhone.Size = new System.Drawing.Size(46, 19);
            this.lbl_forPhone.TabIndex = 20;
            this.lbl_forPhone.Text = "Phone";
            // 
            // lbl_forEmail
            // 
            this.lbl_forEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forEmail.AutoSize = true;
            this.lbl_forEmail.Depth = 0;
            this.lbl_forEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forEmail.Location = new System.Drawing.Point(305, 86);
            this.lbl_forEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forEmail.Name = "lbl_forEmail";
            this.lbl_forEmail.Size = new System.Drawing.Size(41, 19);
            this.lbl_forEmail.TabIndex = 19;
            this.lbl_forEmail.Text = "Email";
            // 
            // lbl_forName
            // 
            this.lbl_forName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forName.AutoSize = true;
            this.lbl_forName.Depth = 0;
            this.lbl_forName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forName.Location = new System.Drawing.Point(71, 86);
            this.lbl_forName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forName.Name = "lbl_forName";
            this.lbl_forName.Size = new System.Drawing.Size(43, 19);
            this.lbl_forName.TabIndex = 18;
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
            this.crd_date.Location = new System.Drawing.Point(536, 253);
            this.crd_date.Margin = new System.Windows.Forms.Padding(14);
            this.crd_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_date.Name = "crd_date";
            this.crd_date.Padding = new System.Windows.Forms.Padding(14);
            this.crd_date.Size = new System.Drawing.Size(188, 51);
            this.crd_date.TabIndex = 13;
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
            this.lbl_date.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.crd_address.Location = new System.Drawing.Point(308, 253);
            this.crd_address.Margin = new System.Windows.Forms.Padding(14);
            this.crd_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_address.Name = "crd_address";
            this.crd_address.Padding = new System.Windows.Forms.Padding(14);
            this.crd_address.Size = new System.Drawing.Size(188, 103);
            this.crd_address.TabIndex = 14;
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
            this.crd_phone.Location = new System.Drawing.Point(536, 119);
            this.crd_phone.Margin = new System.Windows.Forms.Padding(14);
            this.crd_phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_phone.Name = "crd_phone";
            this.crd_phone.Padding = new System.Windows.Forms.Padding(14);
            this.crd_phone.Size = new System.Drawing.Size(188, 51);
            this.crd_phone.TabIndex = 15;
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
            this.crd_email.Location = new System.Drawing.Point(308, 119);
            this.crd_email.Margin = new System.Windows.Forms.Padding(14);
            this.crd_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_email.Name = "crd_email";
            this.crd_email.Padding = new System.Windows.Forms.Padding(14);
            this.crd_email.Size = new System.Drawing.Size(188, 51);
            this.crd_email.TabIndex = 16;
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
            this.crd_name.Location = new System.Drawing.Point(74, 119);
            this.crd_name.Margin = new System.Windows.Forms.Padding(14);
            this.crd_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_name.Name = "crd_name";
            this.crd_name.Padding = new System.Windows.Forms.Padding(14);
            this.crd_name.Size = new System.Drawing.Size(188, 51);
            this.crd_name.TabIndex = 12;
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
            this.btn_logout.Location = new System.Drawing.Point(724, 354);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(52, 57);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_addProduct);
            this.tabPage2.Controls.Add(this.gv_inventory);
            this.tabPage2.ImageKey = "icons8-in-inventory-32.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_addProduct.Depth = 0;
            this.btn_addProduct.DrawShadows = true;
            this.btn_addProduct.HighEmphasis = true;
            this.btn_addProduct.Icon = null;
            this.btn_addProduct.Location = new System.Drawing.Point(644, 41);
            this.btn_addProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_addProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(121, 36);
            this.btn_addProduct.TabIndex = 1;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_addProduct.UseAccentColor = false;
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // gv_inventory
            // 
            this.gv_inventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gv_inventory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.gv_inventory.Location = new System.Drawing.Point(69, 86);
            this.gv_inventory.Name = "gv_inventory";
            this.gv_inventory.ReadOnly = true;
            this.gv_inventory.Size = new System.Drawing.Size(704, 316);
            this.gv_inventory.TabIndex = 0;
            this.gv_inventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "View";
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gv_shelf);
            this.tabPage3.ImageKey = "icons8-shelf-32.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(844, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Shelf";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.crd_implemented);
            this.tabPage4.ImageKey = "icons8-mail-32.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(844, 460);
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
            this.crd_implemented.Location = new System.Drawing.Point(281, 147);
            this.crd_implemented.Margin = new System.Windows.Forms.Padding(14);
            this.crd_implemented.MouseState = MaterialSkin.MouseState.HOVER;
            this.crd_implemented.Name = "crd_implemented";
            this.crd_implemented.Padding = new System.Windows.Forms.Padding(14);
            this.crd_implemented.Size = new System.Drawing.Size(200, 100);
            this.crd_implemented.TabIndex = 1;
            // 
            // lbl_implemented
            // 
            this.lbl_implemented.AutoSize = true;
            this.lbl_implemented.Depth = 0;
            this.lbl_implemented.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_implemented.Location = new System.Drawing.Point(26, 40);
            this.lbl_implemented.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_implemented.Name = "lbl_implemented";
            this.lbl_implemented.Size = new System.Drawing.Size(149, 19);
            this.lbl_implemented.TabIndex = 0;
            this.lbl_implemented.Text = "To be Implemented...";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Controls.Add(this.btn_changePassword);
            this.tabPage5.Controls.Add(this.txt_newPassword2);
            this.tabPage5.Controls.Add(this.lbl_newPassword2);
            this.tabPage5.Controls.Add(this.txt_newPassword1);
            this.tabPage5.Controls.Add(this.lbl_newPassword1);
            this.tabPage5.Controls.Add(this.txt_oldPassword);
            this.tabPage5.Controls.Add(this.lbl_password);
            this.tabPage5.ImageKey = "icons8-access-32.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(844, 460);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Credentials";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::BusinessApplication.Properties.Resources.pngwing_com__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_changePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_changePassword.Depth = 0;
            this.btn_changePassword.DrawShadows = true;
            this.btn_changePassword.HighEmphasis = true;
            this.btn_changePassword.Icon = null;
            this.btn_changePassword.Location = new System.Drawing.Point(484, 342);
            this.btn_changePassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_changePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(163, 36);
            this.btn_changePassword.TabIndex = 14;
            this.btn_changePassword.Text = "Change Password";
            this.btn_changePassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_changePassword.UseAccentColor = false;
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // txt_newPassword2
            // 
            this.txt_newPassword2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_newPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_newPassword2.Depth = 0;
            this.txt_newPassword2.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_newPassword2.Location = new System.Drawing.Point(186, 328);
            this.txt_newPassword2.MaxLength = 50;
            this.txt_newPassword2.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_newPassword2.Multiline = false;
            this.txt_newPassword2.Name = "txt_newPassword2";
            this.txt_newPassword2.Size = new System.Drawing.Size(201, 50);
            this.txt_newPassword2.TabIndex = 13;
            this.txt_newPassword2.Text = "";
            // 
            // lbl_newPassword2
            // 
            this.lbl_newPassword2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_newPassword2.AutoSize = true;
            this.lbl_newPassword2.Depth = 0;
            this.lbl_newPassword2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_newPassword2.Location = new System.Drawing.Point(183, 306);
            this.lbl_newPassword2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_newPassword2.Name = "lbl_newPassword2";
            this.lbl_newPassword2.Size = new System.Drawing.Size(132, 19);
            this.lbl_newPassword2.TabIndex = 12;
            this.lbl_newPassword2.Text = "Confirm Password";
            // 
            // txt_newPassword1
            // 
            this.txt_newPassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_newPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_newPassword1.Depth = 0;
            this.txt_newPassword1.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_newPassword1.Location = new System.Drawing.Point(186, 238);
            this.txt_newPassword1.MaxLength = 50;
            this.txt_newPassword1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_newPassword1.Multiline = false;
            this.txt_newPassword1.Name = "txt_newPassword1";
            this.txt_newPassword1.Size = new System.Drawing.Size(201, 50);
            this.txt_newPassword1.TabIndex = 11;
            this.txt_newPassword1.Text = "";
            // 
            // lbl_newPassword1
            // 
            this.lbl_newPassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_newPassword1.AutoSize = true;
            this.lbl_newPassword1.Depth = 0;
            this.lbl_newPassword1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_newPassword1.Location = new System.Drawing.Point(183, 216);
            this.lbl_newPassword1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_newPassword1.Name = "lbl_newPassword1";
            this.lbl_newPassword1.Size = new System.Drawing.Size(106, 19);
            this.lbl_newPassword1.TabIndex = 10;
            this.lbl_newPassword1.Text = "New Password";
            // 
            // txt_oldPassword
            // 
            this.txt_oldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_oldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_oldPassword.Depth = 0;
            this.txt_oldPassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_oldPassword.Location = new System.Drawing.Point(186, 104);
            this.txt_oldPassword.MaxLength = 50;
            this.txt_oldPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_oldPassword.Multiline = false;
            this.txt_oldPassword.Name = "txt_oldPassword";
            this.txt_oldPassword.Size = new System.Drawing.Size(201, 50);
            this.txt_oldPassword.TabIndex = 9;
            this.txt_oldPassword.Text = "";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_password.AutoSize = true;
            this.lbl_password.Depth = 0;
            this.lbl_password.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_password.Location = new System.Drawing.Point(183, 82);
            this.lbl_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(99, 19);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Old Password";
            // 
            // gv_shelf
            // 
            this.gv_shelf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gv_shelf.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv_shelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_shelf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn2});
            this.gv_shelf.Location = new System.Drawing.Point(70, 72);
            this.gv_shelf.Name = "gv_shelf";
            this.gv_shelf.ReadOnly = true;
            this.gv_shelf.Size = new System.Drawing.Size(704, 316);
            this.gv_shelf.TabIndex = 1;
            this.gv_shelf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_shelf_CellContentClick);
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "Transfer";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // Form_InventoryController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 503);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form_InventoryController";
            this.Text = "Inventory Controller";
            this.Load += new System.EventHandler(this.Form_InventoryController_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.gv_inventory)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.crd_implemented.ResumeLayout(false);
            this.crd_implemented.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_shelf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_logout;
        private MaterialLabel materialLabel12;
        private MaterialLabel lbl_forAddress;
        private MaterialCard crd_cnic;
        private MaterialProgressBar materialProgressBar4;
        private MaterialLabel lbl_cnic;
        private MaterialLabel lbl_forCnic;
        private MaterialLabel lbl_forPhone;
        private MaterialLabel lbl_forEmail;
        private MaterialLabel lbl_forName;
        private MaterialCard crd_date;
        private MaterialProgressBar materialProgressBar5;
        private MaterialLabel lbl_date;
        private MaterialCard crd_address;
        private MaterialProgressBar materialProgressBar6;
        private MaterialMultiLineTextBox lbl_address;
        private MaterialCard crd_phone;
        private MaterialProgressBar materialProgressBar3;
        private MaterialLabel lbl_phone;
        private MaterialCard crd_email;
        private MaterialProgressBar materialProgressBar2;
        private MaterialLabel lbl_email;
        private MaterialCard crd_name;
        private MaterialProgressBar materialProgressBar1;
        private MaterialLabel lbl_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialButton btn_changePassword;
        private MaterialTextBox txt_newPassword2;
        private MaterialLabel lbl_newPassword2;
        private MaterialTextBox txt_newPassword1;
        private MaterialLabel lbl_newPassword1;
        private MaterialTextBox txt_oldPassword;
        private MaterialLabel lbl_password;
        private MaterialButton btn_addProduct;
        private System.Windows.Forms.DataGridView gv_inventory;
        private MaterialLabel lbl_implemented;
        private MaterialCard crd_implemented;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridView gv_shelf;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}