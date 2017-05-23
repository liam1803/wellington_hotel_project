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
    public partial class frmSearch : Form
    {

        MySqlConnection mcon = new MySqlConnection("datasource=localhost;database=wellington_hotel;port=3306;username=root;password=usbw");
        MySqlCommand mcd;
        MySqlDataReader mdr;
        string s;

       public frmSearch()
       {
           InitializeComponent();
       }

   


                // public void updateBookingGrid()
                //   {
                //  DataSet ds = new DataSet();
                //  DataTable dt = new DataTable();
                // ds.Tables.Add(dt);
                ///  search booking = new search();
                //  dt = booking.searchdatagrid();
                // dgvSearch.DataSource = dt.DefaultView;

                // }

                //   private void frmSearch_Load(object sender, EventArgs e)
                //   {
                //      updateBookingGrid();
                //   }

                //   private void txtSearch_TextChanged(object sender, EventArgs e)
                //  {

                //  }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                mcon.Open();
                s = "select * from customer_details where Booking_ID=" + int.Parse(txtBookingID.Text);
                mcd = new MySqlCommand(s, mcon);
                mdr = mcd.ExecuteReader();
                if (mdr.Read())
                {
                    txtSurname.Text = mdr.GetString("Surname");
                    txtForename.Text = mdr.GetString("Forename");
                }

                else
                {
                    MessageBox.Show("No Data Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                mdr.Dispose();
                mcon.Close();
            }

        }
 



            }


        }
    

