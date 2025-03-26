using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{

    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void EnterLogin_TextChanged(object sender, EventArgs e)
        {
            // Проверка допустимых символов или длины логина
        }

        private void EnterPassword_TextChanged(object sender, EventArgs e)
        {
            // Можно добавить проверку сложности пароля
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string username = EnterLogin.Text;
            string password = EnterPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните логин и пароль.");
                return;
            }

            using (var context = new ApplicationContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Name == username);

                if (user == null)
                {
                    MessageBox.Show("Логин не найден. Хотите зарегистрироваться?");
                    return;
                }

                if (user.PasswordHash == password) // Сравнение пароля (можно добавить проверку хэша)
                {
                    MessageBox.Show("Успешный вход! Добро пожаловать.");
                    // Логика после успешного входа, например, переход в главное окно программы
                }
                else
                {
                    MessageBox.Show("Неверный пароль. Попробуйте ещё раз.");
                }
            }
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            var registrationForm = new Registration();
            registrationForm.ShowDialog();
        }
    }


}
