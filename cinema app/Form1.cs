using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_app
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 newForm1 = new Form3();
            newForm1.Show();
            try
            {
                using (OleDbConnection connection = new OleDbConnection(db.Class1.ConnectionString))
                {
                    connection.Open();

                    string sqlExpression = "SELECT * FROM [User] WHERE [Login] = @Login AND [Password] = @Password;";
                    OleDbCommand sqlCommand = new OleDbCommand(sqlExpression, connection);
                    sqlCommand.Parameters.AddWithValue("@Login", LoginTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                    using (OleDbDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            MessageBox.Show($"Здравствуйте, {dataReader["FirstName"]}");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный Логин/Пароль!");
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
