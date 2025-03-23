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
    public partial class Registration : Form
    {
        private byte[] profilePicture;
        public Registration()
        {
            InitializeComponent();
        }

        private void EnterNewLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void DownloadPhoto_Click(object sender, EventArgs e)
        {
            // Открытие окна для загрузки фото
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Сохраняем выбранное фото в формате байтов
                    profilePicture = File.ReadAllBytes(openFileDialog.FileName);
                    // Отображаем фото в pictureBox (если он есть на форме)
                    ShowPhoto.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void FinishRegistration_Click(object sender, EventArgs e)
        {
            // Получаем логин и пароль из текстовых полей
            string newUsername = EnterNewLogin.Text;
            string newPassword = EnterNewPassword.Text;

            // Проверка, заполнены ли все поля
            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword) || profilePicture == null)
            {
                MessageBox.Show("Заполните все поля и загрузите фото!");
                return;
            }

            // Добавляем нового пользователя в базу данных
            RegisterUser(newUsername, newPassword, profilePicture);
        }

        private void RegisterUser(string username, string password, byte[] profilePicture)
        {
            try
            {
                using (var connection = new SqlConnection(CreateTable.connectionString))
                {
                    connection.Open();

                    // Проверяем, существует ли пользователь с таким логином
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (var checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", username);
                        int userCount = (int)checkCommand.ExecuteScalar();

                        if (userCount > 0)
                        {
                            // Если пользователь существует, показываем сообщение
                            MessageBox.Show("Такой пользователь уже существует. Введите другой логин.");
                            return;
                        }
                    }

                    // Если пользователь не найден, добавляем его
                    string insertQuery = "INSERT INTO Users (Username, Password, ProfilePicture) VALUES (@Username, @Password, @ProfilePicture)";
                    using (var insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Username", username);
                        insertCommand.Parameters.AddWithValue("@Password", password);
                        insertCommand.Parameters.AddWithValue("@ProfilePicture", profilePicture);

                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Регистрация успешно завершена!");
                        this.Close(); // Закрываем форму после успешной регистрации
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации: " + ex.Message);
            }
        }

        private void ShowPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
