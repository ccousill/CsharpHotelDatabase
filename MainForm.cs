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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClientsForm manageForm = new ManageClientsForm();
            manageForm.ShowDialog();
        }

        private void manageReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReservationsForm reservationsForm = new ManageReservationsForm();
            reservationsForm.ShowDialog();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomsForm manageRoomsForm = new ManageRoomsForm();
            manageRoomsForm.ShowDialog();
        }
    }
}
