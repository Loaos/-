using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ExcursionForClients : Form
    {
        public ExcursionForClients()
        {
            InitializeComponent();
            database.openConnection();
        }

        DB database = new DB();

        private SqlDataAdapter adapter1 = new SqlDataAdapter();
        private DataTable table1 = new DataTable();

        private void ExcursionForClients_Load(object sender, EventArgs e)
        {
        }

        private void ExcursionForClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage plantListForm = new MainPage();
            plantListForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand(@"INSERT INTO [Бронирование] (Клиент, Номер_телефона, Экскурсия, Гид, Дата, Время) VALUES (@Клиент, @Номер_телефона, @Экскурсия, @Гид, @Дата, @Время)", database.getSqlConnection());

            // Устанавливаем текст команды INSERT
            

            // Добавляем параметры в команду
            command1.Parameters.AddWithValue("@Клиент", textBox1.Text);
            command1.Parameters.AddWithValue("@Номер_телефона", textBox3.Text);
            command1.Parameters.AddWithValue("@Экскурсия", comboBox1.Text);
            command1.Parameters.AddWithValue("@Гид", comboBox4.Text);
            command1.Parameters.AddWithValue("@Дата", comboBox2.Text);
            command1.Parameters.AddWithValue("@Время", comboBox3.Text);

            MessageBox.Show(command1.ExecuteNonQuery().ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Анастасия");
                comboBox4.Items.Add("Сергей");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Сергей");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Ольга");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Алексей");
            }
            if (comboBox1.SelectedIndex == 4)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Светлана");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPage plantListForm = new MainPage();
            plantListForm.Show();
            this.Hide();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
                string selectedName = comboBox5.SelectedItem.ToString(); // Получаем выбранное название
                
                // Используем параметризованный запрос для защиты от SQL-инъекций
                SqlCommand command = new SqlCommand("SELECT Описание FROM Экскурсии WHERE Название = @Name", database.getSqlConnection());
                command.Parameters.AddWithValue("@Name", selectedName);

                table1.Clear(); // Очищаем таблицу перед заполнением новыми данными

                adapter1.SelectCommand = command;
                adapter1.Fill(table1);

                if (table1.Rows.Count > 0)
                {
                    richTextBox1.Text = table1.Rows[0]["Описание"].ToString();
                }
                else
                {
                    richTextBox1.Text = "Нет данных для выбранной экскурсии";
                }
            


            if (comboBox5.SelectedIndex == 0)
            {
                pictureBox1.Image = Properties.Resources.УП1;
                pictureBox2.Image = Properties.Resources.УП2;
                pictureBox3.Image = Properties.Resources.УП3;
                pictureBox4.Image = Properties.Resources.УП4;
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.УП5;
                pictureBox2.Image = Properties.Resources.УП6;
                pictureBox3.Image = Properties.Resources.УП7;
                pictureBox4.Image = Properties.Resources.УП8;
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                pictureBox1.Image = Properties.Resources.УП9;
                pictureBox2.Image = Properties.Resources.УП10;
                pictureBox3.Image = Properties.Resources.УП11;
                pictureBox4.Image = Properties.Resources.УП12;
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                pictureBox1.Image = Properties.Resources.УП13;
                pictureBox2.Image = Properties.Resources.УП14;
                pictureBox3.Image = Properties.Resources.УП15;
                pictureBox4.Image = Properties.Resources.УП16;
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                pictureBox1.Image = Properties.Resources.УП17;
                pictureBox2.Image = Properties.Resources.УП18;
                pictureBox3.Image = Properties.Resources.УП19;
                pictureBox4.Image = Properties.Resources.УП20;
            }
        }
    }
}