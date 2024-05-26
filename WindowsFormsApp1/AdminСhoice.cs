using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminСhoice : Form
    {
        public AdminСhoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablesEdit plantListForm = new TablesEdit();
            plantListForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TablesSee plantListForm = new TablesSee();
            plantListForm.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Authorization plantListForm = new Authorization();
            plantListForm.Show();
            this.Hide();
        }

        private void AdminСhoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
