using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WaMono
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
            cbTime.SelectedIndex = 0;

        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {

        }
        //btnOrder_Click
        private void button2_Click(object sender, EventArgs e)
        {
            // Здесь можно добавить простую валидацию (опционально)
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "Спасибо за заказ!\n\nС вами свяжутся в ближайшее время для подтверждения покупки.\n\nХорошего дня!",
                "Заказ принят",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // window close
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
