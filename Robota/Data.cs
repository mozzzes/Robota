using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Robota
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void download_Click(object sender, EventArgs e)
        {
            //Створюється з'єднання
            string connection = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaData.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connection);

            //звернення до бази
            dbConnection.Open();//відкривається з'єднання 
            string query = "SELECT * FROM tovar";//рядок запиту
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            //перевірка даних
            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Дані не знайдені!", "ERROR");
            }
            else
            {

                while (dbReader.Read())
                {
                    //Выводим данные
                    dataGridView1.Rows.Add(dbReader["id"], dbReader["partTovar"], dbReader["forMagazin"], dbReader["dataVugotov"]);
                }
            }

            //Закрываем соеденение с БД
            dbReader.Close();
            dbConnection.Close();
        }

        private void obnova_Click(object sender, EventArgs e)
        {
            //Створюється з'єднання
            string connection = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaData.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connection);

            //звернення до бази
            dbConnection.Open();//відкривається з'єднання 
            string query = "SELECT * FROM tovar";//рядок запиту
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            //перевірка даних
            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Дані не знайдені!", "ERROR");
            }
            else
            {

                while (dbReader.Read())
                {
                    //Выводим данные
                    dataGridView1.Rows.Add(dbReader["id"], dbReader["partTovar"], dbReader["forMagazin"], dbReader["dataVugotov"]);
                }
            }

            //Закрываем соеденение с БД
            dbReader.Close();
            dbConnection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Redactor_Click(object sender, EventArgs e)
        {
            Adminka admaika = new Adminka();
            this.Hide();
            admaika.Show();
        }
    }
}
