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
        public FavoritesForm(List<Product> favoritesList)
        {
            InitializeComponent();
            this.favorites = favoritesList;
            this.Text = "Избранное";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterParent;

            // Создаём FlowLayoutPanel, если не сделали в дизайнере
            flowFavorites = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(0, 100, 0, 20)
            };
            this.Controls.Add(flowFavorites);

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
                    Font = new Font("Segoe UI", 30, FontStyle.Bold),
                    AutoSize = true,
                    ForeColor = Color.FromArgb(85, 18, 27)
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
                Size = new Size(280, 380),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(15)
            };

            // Картинка, название, цена — почти как на главной
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

            // Кнопка удаления
            Button btnRemove = new Button
            {
                Text = "Удалить",
                Size = new Size(120, 35),
                Location = new Point(80, 320),
                BackColor = Color.FromArgb(220, 50, 70),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnRemove.Click += (s, e) =>
            {
                favorites.Remove(p);
                LoadFavoritesCards();
                MessageBox.Show($"Удалено из избранного:\n{p.Name}");
            };
            card.Controls.Add(btnRemove);

            return card;
        }

        private void FavoritesForm_Load(object sender, EventArgs e)
        {

        }

        private void titleH2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
