namespace WaMono
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.lblFavoritesCount = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.titleH2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Inter Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.mainTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mainTitle.Location = new System.Drawing.Point(12, 25);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(134, 33);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "WaMono";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.lblCartCount);
            this.pnlHeader.Controls.Add(this.lblFavoritesCount);
            this.pnlHeader.Controls.Add(this.btnCart);
            this.pnlHeader.Controls.Add(this.btnFavorites);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.mainTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlHeader.Size = new System.Drawing.Size(1132, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(518, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.Location = new System.Drawing.Point(1114, 35);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(13, 13);
            this.lblCartCount.TabIndex = 6;
            this.lblCartCount.Text = "0";
            // 
            // lblFavoritesCount
            // 
            this.lblFavoritesCount.AutoSize = true;
            this.lblFavoritesCount.Location = new System.Drawing.Point(1012, 35);
            this.lblFavoritesCount.Name = "lblFavoritesCount";
            this.lblFavoritesCount.Size = new System.Drawing.Size(13, 13);
            this.lblFavoritesCount.TabIndex = 5;
            this.lblFavoritesCount.Text = "0";
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(1045, 30);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(75, 23);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "Корзина";
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // btnFavorites
            // 
            this.btnFavorites.Location = new System.Drawing.Point(944, 30);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(75, 23);
            this.btnFavorites.TabIndex = 3;
            this.btnFavorites.Text = "Избранное";
            this.btnFavorites.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(384, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSort
            // 
            this.cmbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(944, 86);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(176, 21);
            this.cmbSort.TabIndex = 2;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // titleH2
            // 
            this.titleH2.AutoSize = true;
            this.titleH2.Font = new System.Drawing.Font("Inter Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleH2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.titleH2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.titleH2.Location = new System.Drawing.Point(12, 85);
            this.titleH2.Name = "titleH2";
            this.titleH2.Size = new System.Drawing.Size(90, 23);
            this.titleH2.TabIndex = 3;
            this.titleH2.Text = "Каталог";
            this.titleH2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1132, 595);
            this.Controls.Add(this.titleH2);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label titleH2;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.Label lblFavoritesCount;
        private System.Windows.Forms.Label label1;
    }
}

