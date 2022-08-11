using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace CsharpHotelDatabase
{

    //room class 
    internal class Room
    {
        CONNECT connection = new CONNECT();
        //get list of rooms

        public DataTable getRoomTypes()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM room_category", connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);


            return table;
        }
        public DataTable getRoomsByType(int type)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM room WHERE type =@tpe and free='yes'", connection.getConnection());

            command.Parameters.Add("@tpe", MySqlDbType.Int32).Value = type;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);


            return table;
        }

        //get room type
        public int getRoomType(int number)
        {
            MySqlCommand command = new MySqlCommand("SELECT type FROM room WHERE number =@num ", connection.getConnection());

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);


            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        public bool roomTo(int number, String yesNo)
        {
            MySqlCommand command = new MySqlCommand("UPDATE room SET free=@yon WHERE number=@num", connection.getConnection());

            command.Parameters.Add("@yon", MySqlDbType.VarChar).Value = yesNo;
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            connection.openConnection();
            if(command.ExecuteNonQuery() == 1)
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



        //insert new room
        public bool addRoom(int number, int type, String phone, String free)
        {
            String insertQuery = "INSERT INTO room (number, type, phone, free) VALUES (@num,@tp,@phn,@fr)";
            MySqlCommand command = new MySqlCommand(insertQuery, connection.getConnection());

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;
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

        //edit rooms

        public bool editRoom(int number, int type, String phone, String free)
        {
            String editQuery = "UPDATE room SET type=@tp,phone=@phn,free=@fr WHERE number =@num";
            MySqlCommand command = new MySqlCommand(editQuery, connection.getConnection());

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;
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

        //delete room
        public bool deleteRoom(int number)
        {
            String deleteQuery = "DELETE FROM room WHERE number=@num";
            MySqlCommand command = new MySqlCommand(deleteQuery, connection.getConnection());
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
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
