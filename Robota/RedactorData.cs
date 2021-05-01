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
    public partial class RedactorData : Form
    {
        public RedactorData()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Enter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_Leave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
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

        private void dobav_Click(object sender, EventArgs e)
        {
            //провірка кількості рядків
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 рядок!", "ERROR");
                return;
            }

            //вибираєм рядок
            int index = dataGridView1.SelectedRows[0].Index;

            //Перевірка даних
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null)
            {
                MessageBox.Show("Не всі дані введені", "ERROR");
                return;
            }

            //зчитування даних
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string partTovar = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string forMagazin = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string dataVugotov = dataGridView1.Rows[index].Cells[3].Value.ToString();

            //з'єднання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaData.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            //Выполянем запрос к БД
            dbConnection.Open();//открываем соеденение
            string query = "INSERT INTO tovar VALUES (" + id + ", '" + partTovar + "', " + forMagazin + ", " + dataVugotov + ")";//рядок запиту

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);


            if (dbCommand.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Помилка", "ERROR");
            }
            else
            {
                MessageBox.Show("Dані додані", "УВАГА");
            }
            
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

        private void dell_Click(object sender, EventArgs e)
        {
            //перевірка вибраних рядків
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть один рядок", "УВАГА");
                return;
            }

            
            int index = dataGridView1.SelectedRows[0].Index;

            //перевірка даних в базі
            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все введене", "АХТУНГ");
                return;
            }

            
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=BazaData.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            
            dbConnection.Open();
            string query = "DELETE FROM tovar WHERE id = " + id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("ERROR");
            else
            {
                MessageBox.Show("Dані видалені", "УВАГА");
                //видалення даних
                dataGridView1.Rows.RemoveAt(index);
            }

            
            dbConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
