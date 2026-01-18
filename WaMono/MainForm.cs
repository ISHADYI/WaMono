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
using System.IO;

namespace WaMono
{
    public partial class MainForm : Form
    {
        private List<Product> products = new List<Product>();
        private List<Product> favorites = new List<Product>();
        private List<CartItem> cart = new List<CartItem>();

        public MainForm()
        {
            InitializeComponent();

            cmbSort.SelectedIndex = 0;

            //LoadTestData();
            LoadProductsFromFile();
            RefreshProductCards();
            UpdateFavoritesBadge();
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
            flowPanel.Controls.Clear();

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

            var result = filteredProducts.ToList();
            // Если ничего не найдено И был реальный поисковый запрос
            if (result.Count == 0 && !string.IsNullOrEmpty(searchText))
            {
                var lblNotFound = new Label
                {
                    Text = "Такого товара не существует.\nПопробуйте изменить запрос или посмотреть другие товары",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 20, FontStyle.Bold),
                    ForeColor = Color.FromArgb(85, 18, 27)
                };
                flowPanel.Controls.Add(lblNotFound);

                return;
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
                Margin = new Padding(4),
                Cursor = Cursors.Hand
            };

            PictureBox pb = new PictureBox
            {
                Size = new Size(260, 220),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                ImageLocation = p.ImagePath,
                BorderStyle = BorderStyle.None,
                Cursor = Cursors.Hand
            };
            pb.Click += (s, e) => OpenProductDetails(p);
            card.Controls.Add(pb);

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

            return card;
        }
        private void LoadProductsFromFile()
        {
            products.Clear();

            string filePath = "products.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл products.txt не найден!", "Ошибка");
                return;
            }

            try
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding(1251)))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line) || line.StartsWith("//")) continue;

                        string[] parts = line.Split(';');

                        if (parts.Length >= 5)
                        {
                            if (int.TryParse(parts[0].Trim(), out int id) &&
                                decimal.TryParse(parts[2].Trim(), out decimal price))
                            {
                                Product prod = new Product
                                {
                                    Id = id,
                                    Name = parts[1].Trim(),
                                    Price = price,
                                    ImagePath = parts[3].Trim(),
                                    Description = parts[4].Trim()
                                };
                                products.Add(prod);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения файла: {ex.Message}", "Ошибка");
            }
        }

        private void UpdateCartBadge()
        {
            int totalItems = cart.Sum(item => item.Quantity);
            //int count = cart.Count;
            lblCartCount.Text = totalItems > 99 ? "99+" : totalItems.ToString();
            lblCartCount.Visible = totalItems > 0;
        }
        // логика добавления в корзину
        private void AddToCart(Product product)
        {
            var existing = cart.FirstOrDefault(ci => ci.Product.Id == product.Id);
            if (existing != null)
            {
                existing.Quantity++;
                MessageBox.Show($"Количество увеличено: {product.Name} ({existing.Quantity} шт.)");
            }
            else
            {
                cart.Add(new CartItem { Product = product, Quantity = 1 });
                MessageBox.Show($"Добавлено в корзину: {product.Name}");
            }

            UpdateCartBadge();
        }
        // логика добавления в избранное
        private void AddToFavorites(Product product)
        {
            if (favorites.Contains(product))
            {
                favorites.Remove(product);
                MessageBox.Show($"Удалено из избранного:\n{product.Name}", "Избранное");
            }
            else
            {
                favorites.Add(product);
                MessageBox.Show($"Добавлено в избранное:\n{product.Name}", "Избранное");
            }

            UpdateFavoritesBadge();
            //RefreshProductCards();
        }


        private void OpenProductDetails(Product product)
        {
            var detailForm = new ProductDetailForm(
                product,
                AddToCart,
                AddToFavorites
            );

            this.Hide();
            detailForm.ShowDialog();
            this.Show();
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

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            this.Hide();
            var favoritesForm = new FavoritesForm(favorites, cart);
            favoritesForm.ShowDialog();
            UpdateFavoritesBadge();
            UpdateCartBadge();
            RefreshProductCards();
            this.Show();
        }

        private void UpdateFavoritesBadge()
        {
            int count = favorites.Count;
            lblFavoritesCount.Text = count > 99 ? "99+" : count.ToString();
            lblFavoritesCount.Visible = count > 0;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cartForm = new CartForm(cart);
            cartForm.ShowDialog();
            UpdateCartBadge();
            RefreshProductCards();
            this.Show();
        }
    }
}
