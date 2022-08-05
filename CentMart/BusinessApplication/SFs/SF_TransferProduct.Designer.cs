namespace BusinessApplication.SFs
{
    partial class SF_TransferProduct
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
            this.txt_quantity = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_transfer = new MaterialSkin.Controls.MaterialButton();
            this.lbl_forQuantity = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txt_quantity
            // 
            this.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_quantity.Depth = 0;
            this.txt_quantity.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_quantity.Location = new System.Drawing.Point(102, 157);
            this.txt_quantity.MaxLength = 50;
            this.txt_quantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_quantity.Multiline = false;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(202, 50);
            this.txt_quantity.TabIndex = 0;
            this.txt_quantity.Text = "";
            // 
            // btn_transfer
            // 
            this.btn_transfer.AutoSize = false;
            this.btn_transfer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_transfer.Depth = 0;
            this.btn_transfer.DrawShadows = true;
            this.btn_transfer.HighEmphasis = true;
            this.btn_transfer.Icon = null;
            this.btn_transfer.Location = new System.Drawing.Point(149, 241);
            this.btn_transfer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_transfer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(106, 36);
            this.btn_transfer.TabIndex = 1;
            this.btn_transfer.Text = "Transfer";
            this.btn_transfer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_transfer.UseAccentColor = false;
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // lbl_forQuantity
            // 
            this.lbl_forQuantity.AutoSize = true;
            this.lbl_forQuantity.Depth = 0;
            this.lbl_forQuantity.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_forQuantity.Location = new System.Drawing.Point(102, 120);
            this.lbl_forQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_forQuantity.Name = "lbl_forQuantity";
            this.lbl_forQuantity.Size = new System.Drawing.Size(101, 19);
            this.lbl_forQuantity.TabIndex = 2;
            this.lbl_forQuantity.Text = "Enter Quantity";
            // 
            // SF_TransferProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 329);
            this.Controls.Add(this.lbl_forQuantity);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.txt_quantity);
            this.Name = "SF_TransferProduct";
            this.Text = "Transfer Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_quantity;
        private MaterialSkin.Controls.MaterialButton btn_transfer;
        private MaterialSkin.Controls.MaterialLabel lbl_forQuantity;
    }
}