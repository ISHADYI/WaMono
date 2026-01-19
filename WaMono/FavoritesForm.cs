using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaMono;

namespace WaMono
{
    public partial class FavoritesForm : Form
    {
        private List<Product> favorites;
        private List<CartItem> cart;
        public FavoritesForm(List<Product> favoritesList, List<CartItem> cartItems)
        {
            InitializeComponent();
            this.favorites = favoritesList ?? new List<Product>();
            this.cart = cartItems ?? new List<CartItem>();

            LoadFavoritesCards();
        }
        private void LoadFavoritesCards()
        {
            flowFavorites.Controls.Clear();

            if (favorites == null || favorites.Count == 0)
            {
                Label lblEmpty = new Label
                {
                    Text = "Вы не добавили ничего в избранное",
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    AutoSize = true,
                    ForeColor = Color.FromArgb(254, 250, 239)
                };
                flowFavorites.Controls.Add(lblEmpty);
                return;
            }

            foreach (var product in favorites)
            {
                Panel card = CreateFavoriteCard(product);
                flowFavorites.Controls.Add(card);
            }
        }
        private Panel CreateFavoriteCard(Product p)
        {
            Panel card = new Panel
            {
                Size = new Size(280, 406),
                BackColor = Color.FromArgb(211, 211, 211),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(4)
            };

            PictureBox pb = new PictureBox
            {
                Size = new Size(260, 220),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                ImageLocation = p.ImagePath
            };
            card.Controls.Add(pb);

            Label lblName = new Label
            {
                Text = p.Name,
                Location = new Point(10, 235),
                Size = new Size(260, 40),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(lblName);

            Label lblPrice = new Label
            {
                Text = $"{p.Price:N0} ₽",
                Location = new Point(10, 280),
                Size = new Size(260, 30),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(200, 60, 60),
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(lblPrice);

            Button btnToCart = new Button
            {
                Text = "В корзину",
                Size = new Size(120, 35),
                Location = new Point(80, 320),
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnToCart.Click += (s, e) =>
            {
                var existing = this.cart.FirstOrDefault(ci => ci.Product.Id == p.Id);

                if (existing != null)
                {
                    existing.Quantity++;
                    MessageBox.Show($"Количество увеличено: {p.Name} ({existing.Quantity} шт.)", "Корзина");
                }
                else
                {
                    this.cart.Add(new CartItem { Product = p, Quantity = 1 });
                    MessageBox.Show($"Добавлен в корзину: {p.Name}", "Корзина");
                }
            };
            card.Controls.Add(btnToCart);

            Button btnRemove = new Button
            {
                Text = "Удалить",
                Size = new Size(120, 35),
                Location = new Point(80, 360),
                BackColor = Color.FromArgb(220, 50, 70),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnRemove.Click += (s, e) =>
            {
                favorites.Remove(p);
                LoadFavoritesCards();
                //MessageBox.Show($"Удалено из избранного:\n{p.Name}");
            };
            card.Controls.Add(btnRemove);
            return card;
        }

        private void FavoritesForm_Load(object sender, EventArgs e)
        {

        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
