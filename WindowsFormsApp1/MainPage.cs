using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class MainPage : Form
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization plantListForm = new Authorization();
            plantListForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcursionForClients plantListForm = new ExcursionForClients();
            plantListForm.Show();
            this.Hide();
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
