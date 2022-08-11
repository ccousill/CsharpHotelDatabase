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
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }
        Room room = new Room();
        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.getRoomTypes();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            dataGridView1.DataSource = room.getRooms();
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            
                int number = Convert.ToInt32(textBoxNumber.Text);
                int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
                string phone = textBoxPhone.Text;
                string free = "";



            try
            {
                if (yesButton.Checked)
                {
                    free = "Yes";
                }
                else if (noButton.Checked)
                {
                    free = "No";
                }

                if (room.addRoom(number, type, phone, free))
                {
                    MessageBox.Show("Room Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = room.getRooms();
                    clearFieldsButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            textBoxPhone.Text = "";
            yesButton.Checked = true;

        }

        //add to fields when clicked
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoomType.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String free = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (free.Equals("Yes"))
            {
                yesButton.Checked = true;
            }else if (free.Equals("No")){
                noButton.Checked = true;
            }

        }

        private void editRoomButton_Click(object sender, EventArgs e)
        {
            
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            String phone = textBoxPhone.Text;
            String free = "";

            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);
                if (yesButton.Checked)
                { 
                    free = "Yes";
                }
                else if (noButton.Checked)
                {
                    free = "No";
                }

                if (room.editRoom(number, type, phone, free))
                {
                    MessageBox.Show("Room Edited", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = room.getRooms();
                    clearFieldsButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Edited", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }

        private void removeRoomButton_Click(object sender, EventArgs e)
        {

            try
            {
                int roomNumber = Convert.ToInt32(textBoxNumber.Text);

                if (room.deleteRoom(roomNumber))
                {
                    MessageBox.Show("Room Deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = room.getRooms();
                    clearFieldsButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            
        }
    }
}
 