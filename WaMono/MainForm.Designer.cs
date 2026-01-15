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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.titleH2 = new System.Windows.Forms.Label();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.lblFavoritesCount = new System.Windows.Forms.Label();
            this.lblCartCount = new System.Windows.Forms.Label();
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
            this.pnlHeader.Controls.Add(this.lblCartCount);
            this.pnlHeader.Controls.Add(this.lblFavoritesCount);
            this.pnlHeader.Controls.Add(this.btnCart);
            this.pnlHeader.Controls.Add(this.btnFavorites);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.mainTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlHeader.Size = new System.Drawing.Size(1132, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(401, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Поиск...";
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(944, 86);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(176, 21);
            this.cmbSort.TabIndex = 2;
            // 
            // titleH2
            // 
            this.titleH2.AutoSize = true;
            this.titleH2.Font = new System.Drawing.Font("Inter Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleH2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.titleH2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.titleH2.Location = new System.Drawing.Point(12, 83);
            this.titleH2.Name = "titleH2";
            this.titleH2.Size = new System.Drawing.Size(103, 27);
            this.titleH2.TabIndex = 3;
            this.titleH2.Text = "Каталог";
            this.titleH2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(1045, 30);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(75, 23);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "Корзина";
            this.btnCart.UseVisualStyleBackColor = true;
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
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.Location = new System.Drawing.Point(1114, 35);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(13, 13);
            this.lblCartCount.TabIndex = 6;
            this.lblCartCount.Text = "0";
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
    }
}

