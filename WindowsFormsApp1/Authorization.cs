using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        public static bool IsAdminAuthorized = false; //Переменная определяющая являетесь ли вы администратором
        private void loginbox_KeyDown(object sender, KeyEventArgs e)//Активация кнопки авторизации при нажатии Enter
        {
            if (e.KeyData == Keys.Enter)
            {
                login_Click(new object(), new EventArgs());
            }
        }

        private void passwordbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                login_Click(new object(), new EventArgs());
            }
        }
        private void login_Click(object sender, EventArgs e)
        {
            unhide.Focus();
            string login = loginbox.Text;
            string password = passwordbox.Text;
            string validUsername = "admin";
            string validPassword = "121244";;
            if (login.Equals(validUsername, StringComparison.OrdinalIgnoreCase) && password.Equals(validPassword))
            {
                Authorization.IsAdminAuthorized = true;
                AdminСhoice plantListForm = new AdminСhoice();
                plantListForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введён неверный логин или пароль.");
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            passwordbox.UseSystemPasswordChar = true;
        }

        private void unhide_Click(object sender, EventArgs e)
        {
            passwordbox.UseSystemPasswordChar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage plantListForm = new MainPage();
            plantListForm.Show();
            this.Hide();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
