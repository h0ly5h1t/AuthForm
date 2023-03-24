using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthForm
{
    public partial class FormWindowRegistration : Form
    {
        private string _login;
        private string _enteredPassword;
        private string _hashPassword;
        private string _email;

        public FormWindowRegistration()
        {
            InitializeComponent();
            loginField.MaxLength = 16;
            passwordField.MaxLength = 32;
            emailField.MaxLength = 40;
            pictureBox6.Visible = false;
        }

        public string Login { get => _login; set => _login = value; }
        public string EnteredPassword { get => _enteredPassword; set => _enteredPassword = value; }
        public string HashPassword { get => _hashPassword; set => _hashPassword = value; }
        public string Email { get => _email; set => _email = value; }

        private async void UserRegistrationbButton_Click(object sender, EventArgs e)
        {
            Login = loginField.Text;
            EnteredPassword = passwordField.Text;
            Email = emailField.Text;

            if (IsNotEmptyString(Login) && IsNotEmptyString(EnteredPassword) && IsNotEmptyString(Email))
            {
                Task<string> hashTask = HashingPasswordAsync(EnteredPassword);

                if (IsUserExists())
                    return;

                DataBase dataBase = new DataBase();

                HashPassword = await hashTask;


                MySqlCommand cmd = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `mail`) VALUES (@login, @pass, @mail)", dataBase.GetСonnectionStatus());
                cmd.Parameters.AddWithValue("@login", Login);
                cmd.Parameters.AddWithValue("@pass", HashPassword);
                cmd.Parameters.AddWithValue("@mail", Email);

                dataBase.OpeningConnection(); // Открываем подклчюение к бд

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Регистрация успешна!");
                    this.Hide();
                    FormWindowAuthorization formWindowAuthorization = new FormWindowAuthorization();
                    formWindowAuthorization.Show();
                    // Открытие приложения
                }
                else
                {
                    MessageBox.Show("Аккаунт не создан!\nПовторите ввод данных");
                }

                dataBase.ClosingConnection(); // Закрываем, хуле
            }

            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private static async Task<string> HashingPasswordAsync(string input)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = await Task.Run(() => sha512.ComputeHash(bytes));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }

        } // Хеширование пароля, чтобы в бд передавался и хранился, сравнивался только хеш

        private void AuthorizationButton_Click(object sender, EventArgs e) // Кнопка, если ты авторизован
        {
            this.Hide();
            FormWindowAuthorization form2 = new FormWindowAuthorization();
            form2.Show();
        }
        private bool IsNotEmptyString(string stringToCheck) // Проверка на пустые строки
        {
            return !string.IsNullOrEmpty(stringToCheck);
        }
        private bool IsUserExists() // Проверка уже созданных пользователей
        {
            DataBase dataBase = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE login = @login", dataBase.GetСonnectionStatus());
            cmd.Parameters.AddWithValue("@login", Login);

            mySqlDataAdapter.SelectCommand = cmd;
            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Этот логин уже используется!");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void RegistrationButton_TextChanged(object sender, EventArgs e) // Делаем кнопку активной только по достижению целей
        {
            if (loginField.Text.Length >= 4 && passwordField.Text.Length >= 6 && emailField.Text.Length >= 6)
                registrationButton.Enabled = true;
            else
                registrationButton.Enabled = false;
        }

        private void ConclusionHints_MouseHover(object sender, EventArgs e) // Подсказска при регистрации
        {
            ToolTip hints = new ToolTip();
            hints.SetToolTip(pictureBox4, "Минимальная длина пароля - 6 символов!\nМинимальная длина ника - 4 символа!\nВвод букв только на английской раскладке!!!");
        }

        private void HiddenPassword_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

            passwordField.UseSystemPasswordChar = false;
            passwordField.Multiline = true;

            passwordField.Width = 258;
            passwordField.Height = 73;

            passwordField.PasswordChar = '\0';
        }

        private void VisiblePassoword_MouseUp(object sender, MouseEventArgs e)
        {
            passwordField.Multiline = false;

            pictureBox5.Visible = true;
            pictureBox6.Visible = false;

            passwordField.UseSystemPasswordChar = true;
        }

        private void LoginFieldFormatting(object sender, KeyPressEventArgs e)
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

        private void PasswordFieldFormatting_KeyPress(object sender, KeyPressEventArgs e)
        {
            char passwordChar = (char)e.KeyChar;
            int asciNum = (int)passwordChar;
            if (!(asciNum == 8 || asciNum >= 33 && asciNum <= 126))
                e.Handled = true;
        }

        private void EmailFieldFormatting_KeyPress(object sender, KeyPressEventArgs e)
        {
            char passwordChar = (char)e.KeyChar;
            int asciNum = (int)passwordChar;
            if (!(asciNum == 8 || asciNum == 46 || asciNum >= 48 && asciNum <= 57 || (asciNum >= 64 && asciNum <= 90) || (asciNum >= 97 && asciNum <= 122)))
            {
                // запрет ввода любых символов, кроме
                // цифр 0 - 9 и прописных букв и заглавных, символа @
                e.Handled = true;
            }
        }
    }
}
