using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace CsharpHotelDatabase
{
    internal class Reservation
    {
        CONNECT connection = new CONNECT();
        //get all reservations
        public DataTable getAllReservations()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM reservation", connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);


            return table;
        }

        //add new reservation
        public bool addReservation(int roomNumber, int clientId,DateTime dateIn, DateTime dateOut)
        {
            String insertQuery = "INSERT INTO reservation (roomNumber, clientId, dateIn, dateOut) VALUES (@rnm,@cid,@din,@dout)";
            MySqlCommand command = new MySqlCommand(insertQuery, connection.getConnection());

            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;
            connection.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }

        }

        //get list of all rooms
        public DataTable getRooms()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM room", connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);


            return table;
        }

        public bool editReservation(int reservId, int roomNumber,int clientId, DateTime dateIn, DateTime dateOut)
        {
            String editQuery = "UPDATE reservation SET roomNumber=@rnm,clientId=@cid,dateIn=@din,dateOut=@dout WHERE reservId =@rid";
            MySqlCommand command = new MySqlCommand(editQuery, connection.getConnection());

            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = reservId;
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;
            connection.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }

        public bool deleteReservation(int rsvId)
        {
            String deleteQuery = "DELETE FROM reservation WHERE reservId=@rid";
            MySqlCommand command = new MySqlCommand(deleteQuery, connection.getConnection());
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = rsvId;
            connection.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }

        }


    }
}
