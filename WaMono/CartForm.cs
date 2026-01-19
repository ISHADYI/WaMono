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
    public partial class CartForm : Form
    {
        private List<CartItem> cart;
        public CartForm(List<CartItem> cartItems)
        {
            InitializeComponent();
            this.cart = cartItems ?? new List<CartItem>();

            LoadCartItems();
        }

        private void LoadCartItems()
        {
            flowCart.Controls.Clear();

            if (cart.Count == 0)
            {
                Label lblEmpty = new Label
                {
                    Text = "Ваша корзина пуста",
                    Font = new Font("Segoe UI", 18, FontStyle.Bold),
                    AutoSize = true,
                    ForeColor = Color.FromArgb(254, 250, 239)
                };
                flowCart.Controls.Add(lblEmpty);
                //return;
            }
            else
            {
                foreach (var item in cart)
                {
                    flowCart.Controls.Add(CreateCartItemControl(item));
                }
            }

            UpdateTotal();
        }

        private Control CreateCartItemControl(CartItem item)
        {
            Panel panel = new Panel
            { 
                Height = 140,
                Margin = new Padding(0, 0, 0, 15),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(211, 211, 211),
                Width = 1160,
            };
            // img
            PictureBox pb = new PictureBox
            {
                Size = new Size(120, 120),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                ImageLocation = item.Product.ImagePath
            };
            panel.Controls.Add(pb);

            // Название
            Label lblName = new Label
            {
                Text = item.Product.Name,
                Location = new Point(140, 10),
                Size = new Size(400, 40),
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            panel.Controls.Add(lblName);

            // Цена за ед
            Label lblPrice = new Label
            {
                Text = $"{item.Product.Price:N0} ₽ / шт.",
                Location = new Point(140, 50),
                Size = new Size(200, 30),
                Font = new Font("Segoe UI", 11)
            };
            panel.Controls.Add(lblPrice);

            // +/-
            NumericUpDown nudQuantity = new NumericUpDown
            {
                Location = new Point(140, 85),
                Width = 100,
                Minimum = 1,
                Maximum = 99,
                Value = item.Quantity,
                Increment = 1
            };

            // удаление
            Button btnRemove = new Button
            {
                Text = "Удалить",
                Size = new Size(100, 35),
                Location = new Point(1050, 50),
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnRemove.Click += (s, e) =>
            {
                cart.Remove(item);
                LoadCartItems();
                //MessageBox.Show($"Товар удалён: {item.Product.Name}");
            };
            panel.Controls.Add(btnRemove);

            // Тотал прайс
            Label lblItemTotal = new Label
            {
                Text = $"{item.TotalPrice:N0} ₽",
                Location = new Point(1000, 10),
                Size = new Size(150, 30),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 167, 69),
                TextAlign = ContentAlignment.MiddleRight
            };
            panel.Controls.Add(lblItemTotal);

            nudQuantity.ValueChanged += (s, e) =>
            {
                item.Quantity = (int)nudQuantity.Value;
                lblItemTotal.Text = $"{item.TotalPrice:N0} ₽";
                UpdateTotal();
            };
            panel.Controls.Add(nudQuantity);

            return panel;
        }
        private void UpdateTotal()
        {
            decimal total = cart.Sum(item => item.TotalPrice);
            lblItemTotal.Text = $"Итого: {total:N0} ₽";
        }
        private void CartForm_Load(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Ваша корзина пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var checkout = new CheckoutForm())
            {
                if (checkout.ShowDialog() == DialogResult.OK)
                {
                    // если заказ оформлен очищаем корзину
                    cart.Clear();
                    LoadCartItems();
                    UpdateTotal();        
                }
            }
        }
    }
}
