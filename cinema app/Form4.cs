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

namespace cinema_app
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            try
            {
                List<string> filmed = new List<string>();

                using (OleDbConnection connection = new OleDbConnection(db.Class1.ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT [NameOfFilm] FROM Film;";

                    OleDbCommand oleDbCommand = new OleDbCommand(sql, connection);

                    using (OleDbDataReader reader = oleDbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            filmed.Add(reader["NameOfFilm"].ToString());
                        }
                    }
                }

                Films.DataSource = filmed;
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
    }
}
