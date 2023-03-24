using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AuthForm
{
    public partial class FormWindowAuthorization : Form
    {
        private string _login;
        private string _enteredPassword;
        private string _hashPassword;

        public FormWindowAuthorization()
        {
            InitializeComponent();
            loginField.MaxLength = 16;
            passwordField.MaxLength = 16;
        }

        public string Login { get => _login; set => _login = value; }
        public string EnteredPassword { get => _enteredPassword; set => _enteredPassword = value; }
        public string HashPassword { get => _hashPassword; set => _hashPassword = value; }

        private void UserAuthorizationbButton_Click(object sender, EventArgs e)
        {
            Login = loginField.Text.Trim().Replace(" ", "");
            EnteredPassword = passwordField.Text.Trim().Replace(" ", "");
            HashPassword = HashingPassword(EnteredPassword);

            DataBase dataBase = new DataBase();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE login = @login AND pass = @pass", dataBase.GetСonnectionStatus());
            cmd.Parameters.AddWithValue("@login", Login);
            cmd.Parameters.AddWithValue("@pass", HashPassword);

            mySqlDataAdapter.SelectCommand = cmd;
            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0) // Если была найдена 1 запись, то мы проходим авторизацию!
            {
                MessageBox.Show("Вы Авторизованы");
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }

            else
                MessageBox.Show("Авторизация не удалась :(");
        }

        private static string HashingPassword(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            SHA512Managed sha512 = new SHA512Managed();
            byte[] hash = sha512.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWindowRegistration form2 = new FormWindowRegistration();
            form2.Show();
        }

        private void LoginFormatting_KeyPress(object sender, KeyPressEventArgs e)
        {
            char passwordChar = (char)e.KeyChar;
            int asciNum = (int)passwordChar;
            if (!(asciNum == 8 || (asciNum >= 48 && asciNum <= 57) || (asciNum >= 97 && asciNum <= 122)))
            {
                // запрет ввода любых символов, кроме
                // цифр 0 - 9 и прописных букв
                e.Handled = true;
            }
        }

        private void ЗasswordаFormatting_KeyPress(object sender, KeyPressEventArgs e)
        {
            char passwordChar = (char)e.KeyChar;
            int asciNum = (int)passwordChar;
            if (!(asciNum == 8 || asciNum >= 33 && asciNum <= 126))
                e.Handled = true;
        }

    }
}

