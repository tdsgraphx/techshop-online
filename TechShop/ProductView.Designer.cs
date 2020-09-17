namespace TechShop
{
    partial class ProductView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            this.BuyNowBtn = new System.Windows.Forms.Button();
            this.AddToMyCartBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductDescriptionLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProductFeaturesLabel = new System.Windows.Forms.Label();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuyNowBtn
            // 
            this.BuyNowBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BuyNowBtn.FlatAppearance.BorderSize = 0;
            this.BuyNowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyNowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyNowBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuyNowBtn.Location = new System.Drawing.Point(154, 210);
            this.BuyNowBtn.Name = "BuyNowBtn";
            this.BuyNowBtn.Size = new System.Drawing.Size(82, 34);
            this.BuyNowBtn.TabIndex = 1;
            this.BuyNowBtn.Text = "Buy Now";
            this.BuyNowBtn.UseVisualStyleBackColor = false;
            // 
            // AddToMyCartBtn
            // 
            this.AddToMyCartBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddToMyCartBtn.FlatAppearance.BorderSize = 0;
            this.AddToMyCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToMyCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToMyCartBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddToMyCartBtn.Location = new System.Drawing.Point(54, 209);
            this.AddToMyCartBtn.Name = "AddToMyCartBtn";
            this.AddToMyCartBtn.Size = new System.Drawing.Size(82, 34);
            this.AddToMyCartBtn.TabIndex = 2;
            this.AddToMyCartBtn.Text = "Add ";
            this.AddToMyCartBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.ProductImage);
            this.panel1.Location = new System.Drawing.Point(276, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 215);
            this.panel1.TabIndex = 3;
            // 
            // ProductImage
            // 
            this.ProductImage.Image = ((System.Drawing.Image)(resources.GetObject("ProductImage.Image")));
            this.ProductImage.Location = new System.Drawing.Point(0, 0);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(200, 178);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 0;
            this.ProductImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProductDescriptionLabel);
            this.panel2.Location = new System.Drawing.Point(43, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 100);
            this.panel2.TabIndex = 4;
            // 
            // ProductDescriptionLabel
            // 
            this.ProductDescriptionLabel.AutoSize = true;
            this.ProductDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDescriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductDescriptionLabel.Location = new System.Drawing.Point(26, 4);
            this.ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            this.ProductDescriptionLabel.Size = new System.Drawing.Size(373, 85);
            this.ProductDescriptionLabel.TabIndex = 0;
            this.ProductDescriptionLabel.Text = resources.GetString("ProductDescriptionLabel.Text");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProductFeaturesLabel);
            this.panel3.Controls.Add(this.ProductPriceLabel);
            this.panel3.Location = new System.Drawing.Point(81, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 151);
            this.panel3.TabIndex = 5;
            // 
            // ProductFeaturesLabel
            // 
            this.ProductFeaturesLabel.AutoSize = true;
            this.ProductFeaturesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductFeaturesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductFeaturesLabel.Location = new System.Drawing.Point(27, 67);
            this.ProductFeaturesLabel.Name = "ProductFeaturesLabel";
            this.ProductFeaturesLabel.Size = new System.Drawing.Size(72, 65);
            this.ProductFeaturesLabel.TabIndex = 6;
            this.ProductFeaturesLabel.Text = "sed diam \r\nnonummy \r\nnibh euismod \r\ntincidunt \r\nut laoreet ";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductPriceLabel.Font = new System.Drawing.Font("Minion Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ProductPriceLabel.Location = new System.Drawing.Point(25, 16);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(71, 30);
            this.ProductPriceLabel.TabIndex = 5;
            this.ProductPriceLabel.Text = "R3000";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddToMyCartBtn);
            this.Controls.Add(this.BuyNowBtn);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(521, 398);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BuyNowBtn;
        private System.Windows.Forms.Button AddToMyCartBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ProductDescriptionLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ProductFeaturesLabel;
        private System.Windows.Forms.Label ProductPriceLabel;
    }
}
