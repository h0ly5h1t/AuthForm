using MySql.Data.MySqlClient;

namespace AuthForm
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=loginvolodya");

        public void OpeningConnection() // Открытие соеденения
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void ClosingConnection() // Закрытие соеденения
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetСonnectionStatus()
        {
            return connection;
        }
    }
}
