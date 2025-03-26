using Microsoft.Data.SqlClient;


namespace WinFormsApp
{
    public partial class Registration : Form
    {
        private byte[] profilePicture; // Поле для хранения фото

        public Registration()
        {
            InitializeComponent();
        }

        private void EnterNewLogin_TextChanged(object sender, EventArgs e)
        {
            // Можно добавить ограничение длины логина или проверку на недопустимые символы
        }

        private void EnterNewPassword_TextChanged(object sender, EventArgs e)
        {
            // Аналогично, можно добавить проверку сложности пароля
        }

        private void DownloadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    profilePicture = File.ReadAllBytes(openFileDialog.FileName); // Сохраняем фото как массив байтов
                    ShowPhoto.Image = Image.FromFile(openFileDialog.FileName);  // Отображаем фото в PictureBox
                }
            }
        }

        private void FinishRegistration_Click(object sender, EventArgs e)
        {
            string newUsername = EnterNewLogin.Text;
            string newPassword = EnterNewPassword.Text;

            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword) || profilePicture == null)
            {
                MessageBox.Show("Заполните все поля и загрузите фото!");
                return;
            }

            using (var context = new ApplicationContext())
            {
                // Проверяем, существует ли пользователь с таким логином
                if (context.Users.Any(u => u.Name == newUsername))
                {
                    MessageBox.Show("Такой пользователь уже существует. Введите другой логин.");
                    return;
                }

                // Добавляем нового пользователя
                var newUser = new User
                {
                    Name = newUsername,
                    PasswordHash = newPassword, // Здесь можно добавить хэширование пароля
                    ProfilePicture = profilePicture
                };

                context.Users.Add(newUser);
                context.SaveChanges();

                MessageBox.Show("Регистрация успешно завершена!");
                this.Close(); // Закрываем форму после успешной регистрации
            }
        }


        private void ShowPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
