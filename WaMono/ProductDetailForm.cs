using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaMono
{
    public partial class ProductDetailForm : Form
    {
        private Product product;
        private Action<Product> addToCartAction;
        private Action<Product> addToFavoritesAction;
        public ProductDetailForm(Product product, Action<Product> onAddToCart, Action<Product> onAddToFavorites)
        {
            InitializeComponent();

            this.product = product;
            this.addToCartAction = onAddToCart;
            this.addToFavoritesAction = onAddToFavorites;

            LoadProductDetails();
        }
        private void LoadProductDetails()
        {
            picProduct.ImageLocation = product.ImagePath;
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;

            lblName.Text = product.Name;
            lblName.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(40, 44, 52);

            lblPrice.Text = $"{product.Price:N0} ₽";
            lblPrice.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(220, 53, 69);

            txtDescription.Text = product.Description ?? "Подробное описание отсутствует.";
            //txtDescription.ReadOnly = true;
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 11);
            txtDescription.ForeColor = Color.FromArgb(70, 70, 70);
        }


        private void ProductDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // btnToCart
        private void button2_Click(object sender, EventArgs e)
        {
            addToCartAction?.Invoke(product);
        }

        private void btnToFavorites_Click(object sender, EventArgs e)
        {
            addToFavoritesAction?.Invoke(product);
        }
    }
}
