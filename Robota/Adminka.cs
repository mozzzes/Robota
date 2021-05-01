using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robota
{
    public partial class Adminka : Form
    {
        public Adminka()
        {
            InitializeComponent();
        }

        private void download_Click(object sender, EventArgs e)
        {
            string loginUser = login.Text;
            string passwordUser = password.Text;

            if (loginUser == "" || passwordUser == "")
            {
                MessageBox.Show("Не всі поля заповнені");
            }

            if (loginUser != "admin" || passwordUser != "123")
            {
                MessageBox.Show("Невірні дані");

            }
            else
            {
                RedactorData redactDT = new RedactorData();
                this.Hide();
                redactDT.Show();
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Data adat = new Data();
            this.Hide();
            adat.Show();

        }
    }
}
