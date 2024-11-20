using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace cinema_app
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            try
            {
                string tabl = "SELECT * FROM [Film]";

                using (OleDbConnection connection = new OleDbConnection(db.Class1.ConnectionString))
                {
                    connection.Open();

                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(tabl, db.Class1.ConnectionString);
                    DataSet ds = new DataSet();
                    oleDbDataAdapter.Fill(ds);
                    FilmdataGridView.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SeatNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(db.Class1.ConnectionString))
                {
                    connection.Open();

                    string cmd = "INSERT INTO Bookings (UserID, FilmID, BookingDate, Seats) VALUES (@userID, @FilmID, @bookingDate, @seats)";
                    OleDbCommand sqlCommand = new OleDbCommand(cmd, connection);
                    sqlCommand.Parameters.AddWithValue("@userID", 1); // Пример, ID текущего пользователя
                    sqlCommand.Parameters.AddWithValue("@FilmID", FilmID);
                    sqlCommand.Parameters.AddWithValue("@bookingDate", DateTime.Now);
                    sqlCommand.Parameters.AddWithValue("@seats", TextBoxSeats.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                if (true)
                {
                    MessageBox.Show("Бронирование выполнено успешно!");
                }
                else
                {
                    MessageBox.Show("Недостаточно свободных мест.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}