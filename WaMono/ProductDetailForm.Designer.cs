namespace WaMono
{
    partial class ProductDetailForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.mainTitle = new System.Windows.Forms.Label();
            this.btnToFavorites = new System.Windows.Forms.Button();
            this.btnToCart = new System.Windows.Forms.Button();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGray;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnBack.Location = new System.Drawing.Point(0, 716);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(1204, 45);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Inter Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.mainTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mainTitle.Location = new System.Drawing.Point(536, 9);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(134, 33);
            this.mainTitle.TabIndex = 12;
            this.mainTitle.Text = "WaMono";
            // 
            // btnToFavorites
            // 
            this.btnToFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnToFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToFavorites.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToFavorites.ForeColor = System.Drawing.Color.White;
            this.btnToFavorites.Location = new System.Drawing.Point(848, 207);
            this.btnToFavorites.Name = "btnToFavorites";
            this.btnToFavorites.Size = new System.Drawing.Size(169, 45);
            this.btnToFavorites.TabIndex = 13;
            this.btnToFavorites.Text = "В избранное";
            this.btnToFavorites.UseVisualStyleBackColor = false;
            this.btnToFavorites.Click += new System.EventHandler(this.btnToFavorites_Click);
            // 
            // btnToCart
            // 
            this.btnToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToCart.ForeColor = System.Drawing.Color.White;
            this.btnToCart.Location = new System.Drawing.Point(1023, 207);
            this.btnToCart.Name = "btnToCart";
            this.btnToCart.Size = new System.Drawing.Size(169, 45);
            this.btnToCart.TabIndex = 14;
            this.btnToCart.Text = "В корзину";
            this.btnToCart.UseVisualStyleBackColor = false;
            this.btnToCart.Click += new System.EventHandler(this.button2_Click);
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(12, 116);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(354, 441);
            this.picProduct.TabIndex = 15;
            this.picProduct.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(372, 138);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "название";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(845, 138);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "цена";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Location = new System.Drawing.Point(372, 207);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(55, 13);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.Text = "описание";
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1204, 761);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.btnToCart);
            this.Controls.Add(this.btnToFavorites);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.btnBack);
            this.MaximizeBox = false;
            this.Name = "ProductDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О товаре";
            this.Load += new System.EventHandler(this.ProductDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button btnToFavorites;
        private System.Windows.Forms.Button btnToCart;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label txtDescription;
    }
}