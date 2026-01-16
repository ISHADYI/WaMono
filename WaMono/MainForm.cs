using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace WaMono
{
    public partial class MainForm : Form
    {
        private List<Product> products = new List<Product>();
        private List<Product> favorites = new List<Product>();
        //private List<CartItem> cart = new List<CartItem>();
        private FlowLayoutPanel flowPanel;
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // окно во весь экран
            this.Text = "WaMono — Главная";

            //this.Size = new Size(1250, 700);
            //AutoScaleMode = AutoScaleMode.Dpi;
            //AutoSize = true;

            // Сортировка
            cmbSort.Items.AddRange(new[]
            {
                "Без сортировки",
                "Цена: по возрастанию",
                "Цена: по убыванию",
                "Название А→Я",
                "Название Я→А"
            });
            cmbSort.SelectedIndex = 0;

            flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(0, 100, 0, 20),
                //BackColor = Color.FromArgb(245, 245, 240)
            };
            this.Controls.Add(flowPanel);

            LoadTestData();
            RefreshProductCards();
        }

        private void LoadTestData()
        {
            products.Add(new Product
            {
                Id = 1,
                Name = "Низкий столик котацу",
                Price = 28900m,
                ImagePath = "images/product1.png",
                Description = "Традиционный японский стол с подогревом"
            });
            products.Add(new Product
            {
                Id = 2,
                Name = "Тумбочка Takatsy",
                Price = 15800m,
                ImagePath = "images/product2.jpg",
                Description = "Натуральный хлопок + латекс"
            });
            products.Add(new Product
            {
                Id = 3,
                Name = "Светильник Witadori",
                Price = 7900m,
                ImagePath = "images/product3.jpg",
                Description = "Тёплый рассеянный свет"
            });
            products.Add(new Product
            {
                Id = 4,
                Name = "Светильник Witadori",
                Price = 7900m,
                ImagePath = "images/product3.jpg",
                Description = "Тёплый рассеянный свет"
            });
            products.Add(new Product
            {
                Id = 5,
                Name = "Светильник Witadori",
                Price = 7900m,
                ImagePath = "images/product3.jpg",
                Description = "Тёплый рассеянный свет"
            });
            products.Add(new Product
            {
                Id = 6,
                Name = "Светильник Witadori",
                Price = 7900m,
                ImagePath = "images/product3.jpg",
                Description = "Тёплый рассеянный свет"
            });
            products.Add(new Product
            {
                Id = 7,
                Name = "Светильник Witadori",
                Price = 7900m,
                ImagePath = "images/product3.jpg",
                Description = "Тёплый рассеянный свет"
            });
            products.Add(new Product
            {
                Id = 8,
                Name = "Светильник Witadori",
                Price = 7900m,
                ImagePath = "images/product3.jpg",
                Description = "Тёплый рассеянный свет"
            });
            products.Add(new Product
            {
                Id = 6,
                Name = "Светильник Witadori",
                Price = 7900m,
                ImagePath = "images/product3.jpg",
                Description = "Тёплый рассеянный свет"
            });
            products.Add(new Product
            {
                Id = 6,
                Name = "Светильник Witadori",
                Price = 7900m,
                ImagePath = "images/product3.jpg",
                Description = "Тёплый рассеянный свет"
            });
            products.Add(new Product
            {
                Id = 6,
                Name = "Светильник Witadori",
                Price = 7900m,
                ImagePath = "images/product3.jpg",
                Description = "Тёплый рассеянный свет"
            });
            products.Add(new Product
            {
                Id = 6,
                Name = "Светильник Witadori",
                Price = 7900m,
                ImagePath = "images/product3.jpg",
                Description = "Тёплый рассеянный свет"
            });
        }

        // обновления карточек
        private void RefreshProductCards()
        {
            flowPanel?.Controls.Clear();

            string searchText = txtSearch.Text?.Trim() ?? "";

            // Фильтрация 
            var filteredProducts = products.AsEnumerable();
            if (!string.IsNullOrEmpty(searchText))
            {
                filteredProducts = filteredProducts.Where(p =>
                    p.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            switch (cmbSort.SelectedIndex)
            {
                case 1: // Цена по возрастанию
                    filteredProducts = filteredProducts.OrderBy(p => p.Price);
                    break;

                case 2: // Цена по убыванию
                    filteredProducts = filteredProducts.OrderByDescending(p => p.Price);
                    break;

                case 3: // Название А-Я
                    filteredProducts = filteredProducts.OrderBy(p => p.Name);
                    break;

                case 4: // Название Я-А
                    filteredProducts = filteredProducts.OrderByDescending(p => p.Name);
                    break;

                default:
                    break;
            }
            // Создаём карточки
            foreach (var product in filteredProducts)
            {
                Panel card = CreateProductCard(product);
                flowPanel.Controls.Add(card);
            }
        }

        private Panel CreateProductCard(Product p)
        {
            Panel card = new Panel
            {
                Size = new Size(280, 380),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(20),
                Cursor = Cursors.Hand
            };

            // Картинка
            PictureBox pb = new PictureBox
            {
                Size = new Size(260, 220),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                ImageLocation = p.ImagePath,
                BorderStyle = BorderStyle.None
            };
            card.Controls.Add(pb);

            // Название
            Label lblName = new Label
            {
                Text = p.Name,
                Location = new Point(10, 240),
                Size = new Size(260, 40),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false
            };
            card.Controls.Add(lblName);

            // Цена
            Label lblPrice = new Label
            {
                Text = $"{p.Price:N0} ₽",
                Location = new Point(10, 285),
                Size = new Size(260, 30),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(200, 60, 60),
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(lblPrice);

            // Кнопки внизу
            Button btnCart = new Button
            {
                Text = "В корзину",
                Size = new Size(120, 35),
                Location = new Point(10, 325),
                BackColor = Color.FromArgb(60, 140, 80),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10)
            };
            btnCart.Click += (s, e) => AddToCart(p);
            card.Controls.Add(btnCart);

            Button btnFav = new Button
            {
                Text = "♥",
                Size = new Size(35, 35),
                Location = new Point(235, 325),
                BackColor = Color.FromArgb(220, 50, 70),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };
            btnFav.Click += (s, e) => AddToFavorites(p);
            card.Controls.Add(btnFav);

            // Клик по всей карточке - открыть детали
            card.Click += (s, e) => OpenProductDetails(p);
            // кликабельныме все дочерние контролы:
            //foreach (Control c in card.Controls) c.Click += (s, e) => OpenProductDetails(p);

            return card;
        }
        private void AddToCart(Product product)
        {
            // Здесь будет логика добавления в корзину
            MessageBox.Show($"Добавлен в корзину:\n{product.Name}", "Корзина");
        }

        private void AddToFavorites(Product product)
        {
            // Логика избранного
            MessageBox.Show($"Добавлено в избранное:\n{product.Name}", "Избранное");
        }

        private void OpenProductDetails(Product product)
        {
            // Откроем форму с деталями (позже реализуем)
            MessageBox.Show($"Открыть детали:\n{product.Name}\n{product.Description}", "Детали товара");
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Поиск
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshProductCards();
        }
        // Фильтры
        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshProductCards();
        }
    }
}
