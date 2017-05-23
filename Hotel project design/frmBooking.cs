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

namespace Hotel_project_design
{
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu frm = new frmMenu();
            frm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection connection;
            string server = "localhost";
            string database = "wellington_hotel";
            string uid = "root";
            string password = "usbw";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            
            connection = new MySqlConnection(connectionString);
            
            try
            {
                connection.Open();
                MessageBox.Show("Your booking was created successfully");
                //connection.ConnectionString = connectionString;
                MySqlCommand cmd = new MySqlCommand("insert into  customer_details (Title,Forename,Surname,Address,County,Postcode,City,Email,ContactNo) values(@Title,@Forename,@Surname,@Address,@County,@Postcode,@City,@Email,@ContactNo)", connection);
                cmd.Parameters.AddWithValue("@Title", cmbTitle.Text);
                cmd.Parameters.AddWithValue("@Forename", txtForename.Text);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@County", txtCounty.Text);
                cmd.Parameters.AddWithValue("@PostCode", txtPostcode.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmailAddress.Text);
                cmd.Parameters.AddWithValue("@ContactNo", txtContactNumber.Text);
                cmd.ExecuteNonQuery();


                MySqlCommand cmd_2 = new MySqlCommand("insert into booking_details (RoomType,CheckIn,CheckOut,GuestsNo,CarPark,FoodOptions,DietaryRequirements,AdditionalInfo) values(@RoomType,@CheckIn,@CheckOut,@GuestsNo,@CarPark,@FoodOptions,@DietaryRequirements,@AdditionalInfo)", connection);
                cmd_2.Parameters.AddWithValue("@RoomType", cmbRoomType.Text);
                cmd_2.Parameters.AddWithValue("@CheckIn", cmbCheckIn.Value.Date.ToString("yyyy-MM-dd"));
                cmd_2.Parameters.AddWithValue("@CheckOut", cmbCheckOut.Value.Date.ToString("yyyy-MM-dd"));
                cmd_2.Parameters.AddWithValue("@GuestsNo", cmbGuests.Text);
                cmd_2.Parameters.AddWithValue("@CarPark", cmbCarPark.Text);
                cmd_2.Parameters.AddWithValue("@FoodOptions", cmbFood.Text);
                cmd_2.Parameters.AddWithValue("@DietaryRequirements", cmbDiet.Text);
                cmd_2.Parameters.AddWithValue("@AdditionalInfo", txtAdditionalInfo.Text);



                cmd_2.ExecuteNonQuery();


            }

    catch (Exception ex)
    {
        MessageBox.Show("Connection has failed" + ex);
    }
    connection.Close();
    }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        }
    

