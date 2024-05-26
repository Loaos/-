using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TablesSee : Form
    {
        DB database = new DB();

        private SqlDataAdapter adapter = null;

        private SqlDataAdapter adapter1 = null;

        private DataTable table = null;

        private SqlDataAdapter adapter2 = null;

        private DataTable table2 = null;

        private SqlDataAdapter adapter3 = null;

        private DataTable table3 = null;
        public TablesSee()
        {
            InitializeComponent();
        }

        private void Tables_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void TablesSee_Load(object sender, EventArgs e)
        {
            adapter1 = new SqlDataAdapter("Select * from Бронирование", database.getSqlConnection());

            adapter = new SqlDataAdapter("execute Sort1", database.getSqlConnection());

            table = new DataTable();

            adapter1.Fill(table);
            dataGridView1.DataSource = table;

            adapter2 = new SqlDataAdapter("Select * from Гиды", database.getSqlConnection());

            table2 = new DataTable();

            adapter2.Fill(table2);
            dataGridView2.DataSource = table2;

            adapter3 = new SqlDataAdapter("Select * from Экскурсии", database.getSqlConnection());

            table3 = new DataTable();

            adapter3.Fill(table3);
            dataGridView3.DataSource = table3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table.Clear();
            adapter1.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            table2.Clear();
            adapter2.Fill(table2);
            dataGridView2.DataSource = table2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            table3.Clear();
            adapter3.Fill(table3);
            dataGridView3.DataSource = table3;
        }
    }
}
