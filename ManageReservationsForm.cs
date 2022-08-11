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
    public partial class ManageReservationsForm : Form
    {
        public ManageReservationsForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        Reservation reservation = new Reservation();

        private void ManageReservationsForm_Load(object sender, EventArgs e)
        {
           

         
            //display room types
            comboBoxRoomType.DataSource = room.getRoomTypes();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            //display room numbers
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            comboBoxRoomNumber.DataSource = room.getRoomsByType(type);
            comboBoxRoomNumber.DisplayMember = "number";
            comboBoxRoomNumber.ValueMember = "number";

            dataGridView1.DataSource = reservation.getAllReservations();
        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            textBoxReservId.Text = "";
            textBoxClientId.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            dateInBox.Value = DateTime.Now;
            dateOutBox.Value = DateTime.Now;

        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                //display room numbers
                int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
                comboBoxRoomNumber.DataSource = room.getRoomsByType(type);
                comboBoxRoomNumber.DisplayMember = "number";
                comboBoxRoomNumber.ValueMember = "number";
            }
            catch(Exception ex)
            {

            }
            
        }

        private void addReservationButton_Click(object sender, EventArgs e)
        {

            try {
                int clientId = Convert.ToInt32(textBoxClientId.Text);
                int roomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue.ToString());
                DateTime dateIn = dateInBox.Value;
                DateTime dateOut = dateOutBox.Value;

                //date in must be >= todays date
                //date out must also be >= todays date

                if(DateTime.Compare(dateIn.Date,DateTime.Now.Date) < 0)
                {
                    MessageBox.Show("The Date In must be great than today's date", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(DateTime.Compare(dateOut.Date, dateIn.Date) < 0)
                {
                    MessageBox.Show("The Date Out must be great than today's date", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.addReservation(roomNumber, clientId, dateIn, dateOut))
                    {

                        room.roomTo(roomNumber,"No");
                        MessageBox.Show("Reservation Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = reservation.getAllReservations();
                    }
                    else
                    {
                        MessageBox.Show("Reservation Not Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Add Reservation Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void editReservationButton_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(textBoxReservId.Text);
                int clientId = Convert.ToInt32(textBoxClientId.Text);
                int roomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue.ToString());
                DateTime dateIn = dateInBox.Value;
                DateTime dateOut = dateOutBox.Value;

                //date in must be >= todays date
                //date out must also be >= todays date

                if (dateIn < DateTime.Now)
                {
                    MessageBox.Show("The Date In must be great than today's date", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateOut < DateTime.Now)
                {
                    MessageBox.Show("The Date Out must be great than today's date", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.editReservation(reservId,roomNumber, clientId, dateIn, dateOut))
                    {

                        room.roomTo(roomNumber, "No");
                        MessageBox.Show("Reservation Updated", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = reservation.getAllReservations();
                    }
                    else
                    {
                        MessageBox.Show("Reservation Not Updated", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxReservId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int roomId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            comboBoxRoomType.SelectedValue = room.getRoomType(roomId);
            comboBoxRoomNumber.SelectedValue = roomId;
            textBoxClientId.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            dateInBox.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            dateOutBox.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);

        }

        private void removeReservationButton_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(textBoxReservId.Text);
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                if (reservation.deleteReservation(reservId))
                {
                    room.roomTo(roomNumber, "Yes");
                    MessageBox.Show("Reservation Deleted", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = reservation.getAllReservations();

                }
                else
                {
                    MessageBox.Show("Did not delete Reservation", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //ALTER TABLE room add CONSTRAINT fk_type_id FOREIGN KEY (type) REFERENCES room_category(category_id) on UPDATE CASCADE on DELETE CASCADE;
        //ALTER TABLE reservation add CONSTRAINT fk_room_number FOREIGN KEY(roomNumber) REFERENCES room(number) on UPDATE CASCADE on DELETE CASCADE;
        //ALTER TABLE reservation add CONSTRAINT fk_client_id FOREIGN KEY (clientId) REFERENCES client(id) on UPDATE CASCADE on DELETE CASCADE;

    }
}
