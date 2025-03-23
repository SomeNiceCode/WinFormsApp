
using Microsoft.Data.SqlClient;

namespace WinFormsApp
{
    class CreateTable
    {
        public static string connectionString = "Server=localhost; Database=Store; Integrated Security=True; TrustServerCertificate=True; MultipleActiveResultSets=True;";
        public void CreateUsersTableIfNotExists()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Создаём таблицу Users, если её нет
                    string query = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Users' AND xtype = 'U')
                CREATE TABLE Users (
                    Id INT IDENTITY(1,1) PRIMARY KEY,
                    Username NVARCHAR(50) NOT NULL,
                    Password NVARCHAR(255) NOT NULL,
                    ProfilePicture VARBINARY(MAX)
                )";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Таблица 'Users' успешно создана, либо уже существует.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при создании таблицы: " + ex.Message);
            }
        }

    }
}
