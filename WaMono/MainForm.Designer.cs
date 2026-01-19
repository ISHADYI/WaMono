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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.lblFavoritesCount = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.titleH2 = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Inter Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.mainTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mainTitle.Location = new System.Drawing.Point(12, 33);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(134, 33);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "WaMono";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(568, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.lblCartCount.Location = new System.Drawing.Point(1179, 43);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(13, 13);
            this.lblCartCount.TabIndex = 6;
            this.lblCartCount.Text = "0";
            this.lblCartCount.Visible = false;
            // 
            // lblFavoritesCount
            // 
            this.lblFavoritesCount.AutoSize = true;
            this.lblFavoritesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.lblFavoritesCount.Location = new System.Drawing.Point(1024, 42);
            this.lblFavoritesCount.Name = "lblFavoritesCount";
            this.lblFavoritesCount.Size = new System.Drawing.Size(13, 13);
            this.lblFavoritesCount.TabIndex = 5;
            this.lblFavoritesCount.Text = "0";
            this.lblFavoritesCount.Visible = false;
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(1053, 29);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(120, 40);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "Корзина";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnFavorites
            // 
            this.btnFavorites.Location = new System.Drawing.Point(898, 29);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(120, 40);
            this.btnFavorites.TabIndex = 3;
            this.btnFavorites.Text = "Избранное";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(434, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSort
            // 
            this.cmbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Без сортировки",
            "Цена: по возрастанию",
            "Цена: по убыванию",
            "Название А-Я",
            "Название Я-А"});
            this.cmbSort.Location = new System.Drawing.Point(1016, 95);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(176, 21);
            this.cmbSort.TabIndex = 2;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // titleH2
            // 
            this.titleH2.AutoSize = true;
            this.titleH2.Font = new System.Drawing.Font("Inter Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleH2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.titleH2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.titleH2.Location = new System.Drawing.Point(569, 94);
            this.titleH2.Name = "titleH2";
            this.titleH2.Size = new System.Drawing.Size(90, 23);
            this.titleH2.TabIndex = 3;
            this.titleH2.Text = "Каталог";
            this.titleH2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Location = new System.Drawing.Point(12, 133);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1180, 599);
            this.flowPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1204, 761);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleH2);
            this.Controls.Add(this.lblCartCount);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.lblFavoritesCount);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label titleH2;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.Label lblFavoritesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}

