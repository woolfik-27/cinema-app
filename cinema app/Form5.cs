using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_app
{
    
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void LoadMovies()
        {
            using (OleDbConnection connection = new OleDbConnection(db.Class1.ConnectionString))
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Film", connection);
                DataTable filmsTable = new DataTable();
                adapter.Fill(filmsTable);
                dataGridViewFilms.DataSource = filmsTable;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            

                
                using (OleDbConnection connection = new OleDbConnection(db.Class1.ConnectionString))
                {
                    connection.Open();
                    string searchQuery = textBoxSearch.Text;
                OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM [Film] WHERE [NameOfFilm] LIKE '%{searchQuery}%'", connection);
                DataSet filmsTable = new DataSet();
                adapter.Fill(filmsTable);
                dataGridViewFilms.DataSource = filmsTable.Tables[0];
            }
        }
    }
}
