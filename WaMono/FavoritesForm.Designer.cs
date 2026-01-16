namespace WaMono
{
    partial class FavoritesForm
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
            this.mainTitle = new System.Windows.Forms.Label();
            this.flowFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.flowFavorites.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Inter Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.mainTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mainTitle.Location = new System.Drawing.Point(3, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(134, 33);
            this.mainTitle.TabIndex = 1;
            this.mainTitle.Text = "WaMono";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowFavorites
            // 
            this.flowFavorites.Controls.Add(this.mainTitle);
            this.flowFavorites.Controls.Add(this.btnBack);
            this.flowFavorites.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowFavorites.Location = new System.Drawing.Point(0, 0);
            this.flowFavorites.Name = "flowFavorites";
            this.flowFavorites.Size = new System.Drawing.Size(1132, 80);
            this.flowFavorites.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(143, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "На главную";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FavoritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1132, 595);
            this.Controls.Add(this.flowFavorites);
            this.Name = "FavoritesForm";
            this.Text = "FavoritesForm";
            this.Load += new System.EventHandler(this.FavoritesForm_Load);
            this.flowFavorites.ResumeLayout(false);
            this.flowFavorites.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.FlowLayoutPanel flowFavorites;
        private System.Windows.Forms.Button btnBack;
    }
}