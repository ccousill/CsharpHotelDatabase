using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CsharpHotelDatabase
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            CONNECT connection = new CONNECT();
            DataTable table = new DataTable();

            String query = "SELECT * FROM user WHERE username = @usn AND password = @pass ";
            MySqlCommand command = new MySqlCommand(query,connection.getConnection());
            
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUser.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPass.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                //main form login
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
              

            }
            else
            {
                if (textBoxUser.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter a username", "Empty Box",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxPass.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter a password", "Empty Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect", "Enter again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

 
    }
}
