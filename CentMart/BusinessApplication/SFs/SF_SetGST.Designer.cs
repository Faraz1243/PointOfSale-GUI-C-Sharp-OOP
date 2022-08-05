namespace BusinessApplication.SFs
{
    partial class SF_SetGST
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
            this.lbl_gst = new MaterialSkin.Controls.MaterialLabel();
            this.txt_gst = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_submit = new MaterialSkin.Controls.MaterialButton();
            this.lbl_sign = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbl_gst
            // 
            this.lbl_gst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_gst.AutoSize = true;
            this.lbl_gst.Depth = 0;
            this.lbl_gst.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_gst.Location = new System.Drawing.Point(138, 109);
            this.lbl_gst.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_gst.Name = "lbl_gst";
            this.lbl_gst.Size = new System.Drawing.Size(129, 19);
            this.lbl_gst.TabIndex = 0;
            this.lbl_gst.Text = "General Sales Tax";
            // 
            // txt_gst
            // 
            this.txt_gst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_gst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gst.Depth = 0;
            this.txt_gst.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_gst.Location = new System.Drawing.Point(100, 152);
            this.txt_gst.MaxLength = 50;
            this.txt_gst.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_gst.Multiline = false;
            this.txt_gst.Name = "txt_gst";
            this.txt_gst.Size = new System.Drawing.Size(197, 50);
            this.txt_gst.TabIndex = 1;
            this.txt_gst.Text = "";
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_submit.AutoSize = false;
            this.btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_submit.Depth = 0;
            this.btn_submit.DrawShadows = true;
            this.btn_submit.HighEmphasis = true;
            this.btn_submit.Icon = null;
            this.btn_submit.Location = new System.Drawing.Point(152, 233);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(99, 37);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_submit.UseAccentColor = false;
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // lbl_sign
            // 
            this.lbl_sign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sign.AutoSize = true;
            this.lbl_sign.Depth = 0;
            this.lbl_sign.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_sign.Location = new System.Drawing.Point(268, 170);
            this.lbl_sign.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_sign.Name = "lbl_sign";
            this.lbl_sign.Size = new System.Drawing.Size(13, 19);
            this.lbl_sign.TabIndex = 3;
            this.lbl_sign.Text = "%";
            // 
            // SF_SetGST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 310);
            this.Controls.Add(this.lbl_sign);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_gst);
            this.Controls.Add(this.lbl_gst);
            this.Name = "SF_SetGST";
            this.Text = "Update GST";
            this.Load += new System.EventHandler(this.SF_setGST_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_gst;
        private MaterialSkin.Controls.MaterialTextBox txt_gst;
        private MaterialSkin.Controls.MaterialButton btn_submit;
        private MaterialSkin.Controls.MaterialLabel lbl_sign;
    }
}