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

        }

        private void EnterPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string username = EnterLogin.Text; // Логин пользователя
            string password = EnterPassword.Text; // Пароль пользователя

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните логин и пароль.");
                return;
            }

            // Проверяем логин и пароль
            CheckCredentials(username, password);
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.ShowDialog();
        }

        private void CheckCredentials(string username, string password)
        {
            try
            {
                using (var connection = new SqlConnection(CreateTable.connectionString))
                {
                    connection.Open();

                    // Проверяем, существует ли пользователь с таким логином
                    string queryCheckUser = "SELECT Password FROM Users WHERE Username = @Username";
                    using (var command = new SqlCommand(queryCheckUser, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        var result = command.ExecuteScalar();

                        if (result == null)
                        {
                            // Пользователь не найден
                            var registerOption = MessageBox.Show("Логин не найден. Хотите зарегистрироваться?", "Регистрация", MessageBoxButtons.YesNo);
                            if (registerOption == DialogResult.Yes)
                            {
                                Registration registrationForm = new Registration();
                                registrationForm.ShowDialog();
                            }
                            return;
                        }

                        // Сравниваем введённый пароль с тем, что в базе
                        string storedPassword = result.ToString();
                        if (storedPassword == password)
                        {
                            MessageBox.Show("Успешный вход! Добро пожаловать.");
                            // Здесь можно открыть основное окно программы
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль. Попробуйте ещё раз.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при проверке данных: " + ex.Message);
            }
        }
    }
}
