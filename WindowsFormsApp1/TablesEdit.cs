using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class TablesEdit : Form
    {
        public TablesEdit()
        {
            InitializeComponent();
            database.openConnection();
        }
        DB database = new DB();


        private void button5_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand($"INSERT INTO [Экскурсии] (Название, Описание, Длительность, Стоимость) values (@Название, @Описание, @Длительность, @Стоимость)", database.getSqlConnection());
            command.Parameters.AddWithValue("@Название", textBox1.Text);
            command.Parameters.AddWithValue("@Описание", richTextBox1.Text);
            command.Parameters.AddWithValue("@Длительность", textBox2.Text);
            command.Parameters.AddWithValue("@Стоимость", textBox3.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Гиды] (Имя, Фамилия, Возраст, Опыт_работы, Номер_телефона) values (@Имя, @Фамилия, @Возраст, @Опыт_работы, @Номер_телефона)", database.getSqlConnection());
            command.Parameters.AddWithValue("@Имя", textBox10.Text);
            command.Parameters.AddWithValue("@Фамилия", textBox7.Text);
            command.Parameters.AddWithValue("@Возраст", textBox9.Text);
            command.Parameters.AddWithValue("@Опыт_работы", textBox8.Text);
            command.Parameters.AddWithValue("@Номер_телефона", textBox6.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void TablesEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Бронирование WHERE id = @id", database.getSqlConnection());
            command.Parameters.AddWithValue("@id", textBox4.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Экскурсии WHERE id = @id", database.getSqlConnection());
            command.Parameters.AddWithValue("@id", textBox5.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Гиды WHERE id = @id", database.getSqlConnection());
            command.Parameters.AddWithValue("@id", textBox11.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
