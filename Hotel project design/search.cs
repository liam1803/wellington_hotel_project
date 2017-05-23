using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotel_project_design
{
    class search
    {
        //datagrid search
        public DataTable searchdatagrid()
        {
            string connect = "server=localhost;database=wellington_hotel;port=3306;username=root;password=usbw;";
            string search = "SELECT * FROM customer_details";

            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(search, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    connection.Close();
                    return dt;

                }

            }


        }
    }
}
