using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpHotelDatabase
{
    public partial class ManageClientsForm : Form
    {
        Client client = new Client();
        public ManageClientsForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxCountry.Text = "";
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            String firstName = textBoxFirstName.Text;
            String lastName = textBoxLastName.Text;
            String phone = textBoxPhone.Text;
            String country = textBoxCountry.Text;

            if (firstName.Trim().Equals("") || lastName.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
            {
                MessageBox.Show("Must insert into fields", "Client Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Boolean insertClient = client.insertClient(firstName, lastName, phone, country);
                if (insertClient)
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("Inserted new client successfully", "Client Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("unsuccessful insertion of client", "Client Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getClients();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int id;
            String firstName = textBoxFirstName.Text;
            String lastName = textBoxLastName.Text;
            String phone = textBoxPhone.Text;
            String country = textBoxCountry.Text;

            try
            {
                
                id = Convert.ToInt32(textBoxID.Text);
                if (firstName.Trim().Equals("") || lastName.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
                {
                    MessageBox.Show("Must insert into fields", "Client Not edited", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    Boolean editClient = client.editClient(id, firstName, lastName, phone, country);

                    if (editClient)
                    {
                        dataGridView1.DataSource = client.getClients();
                        MessageBox.Show("Edited client successfully", "Client edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("unsuccessful edit of client", "Client Not edited", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }


        //display selected client
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxCountry.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if (client.deleteClient(id))
                {

                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("Deleted client successfully", "Client deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFieldsButton.PerformClick();

                }
                else
                {
                    MessageBox.Show("Did not delete client successfully", "Client not deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
