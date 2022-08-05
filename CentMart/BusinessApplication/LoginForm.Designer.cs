using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace BusinessApplication
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbl_email = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_pass = new MaterialSkin.Controls.MaterialLabel();
            this.txt_email = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_pass = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_login = new MaterialSkin.Controls.MaterialButton();
            this.pic_cart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Depth = 0;
            this.lbl_email.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_email.Location = new System.Drawing.Point(153, 135);
            this.lbl_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 19);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email";
            // 
            // lbl_pass
            // 
            this.lbl_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Depth = 0;
            this.lbl_pass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_pass.Location = new System.Drawing.Point(153, 228);
            this.lbl_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(82, 19);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Password\r\n";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Depth = 0;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_email.Location = new System.Drawing.Point(147, 157);
            this.txt_email.MaxLength = 50;
            this.txt_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(294, 50);
            this.txt_email.TabIndex = 3;
            this.txt_email.Text = "";
            // 
            // txt_pass
            // 
            this.txt_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Depth = 0;
            this.txt_pass.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_pass.Location = new System.Drawing.Point(147, 250);
            this.txt_pass.MaxLength = 50;
            this.txt_pass.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_pass.Multiline = false;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(294, 50);
            this.txt_pass.TabIndex = 4;
            this.txt_pass.Text = "";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.AutoSize = false;
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Depth = 0;
            this.btn_login.DrawShadows = true;
            this.btn_login.HighEmphasis = true;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(208, 342);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(151, 36);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_login.UseAccentColor = false;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // pic_cart
            // 
            this.pic_cart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_cart.Image = ((System.Drawing.Image)(resources.GetObject("pic_cart.Image")));
            this.pic_cart.Location = new System.Drawing.Point(510, 157);
            this.pic_cart.Name = "pic_cart";
            this.pic_cart.Size = new System.Drawing.Size(188, 143);
            this.pic_cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cart.TabIndex = 6;
            this.pic_cart.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic_cart);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "CentMart";
            ((System.ComponentModel.ISupportInitialize)(this.pic_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialLabel lbl_email;
        private MaterialLabel lbl_pass;
        private MaterialTextBox txt_email;
        private MaterialTextBox txt_pass;
        private MaterialButton btn_login;
        private System.Windows.Forms.PictureBox pic_cart;
    }
}

