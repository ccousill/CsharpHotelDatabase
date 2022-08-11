using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace CsharpHotelDatabase
{
    internal class Client
    {

        CONNECT connection = new CONNECT();
        public bool insertClient(String firstName, String lastName, String phone, String country)
        {
            String insertQuery = "INSERT INTO client (first_name, last_name, phone, country) VALUES (@fnm,@lnm,@phn,@cnt)";
            MySqlCommand command = new MySqlCommand(insertQuery,connection.getConnection());

            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;
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
        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM client", connection.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);


            return table;
        }

        //edit client
        public bool editClient(int id, String firstName, String lastName, String phone, String country) 
        {
            String editQuery = "UPDATE client SET first_name=@fnm,last_name=@lnm,phone=@phn,country=@cnt WHERE id =@cid";
            MySqlCommand command = new MySqlCommand(editQuery, connection.getConnection());
            
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;
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

        //delete client
        public bool deleteClient(int id)
        {
            String deleteQuery = "DELETE FROM client WHERE id=@cid";
            MySqlCommand command = new MySqlCommand(deleteQuery, connection.getConnection());
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
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
