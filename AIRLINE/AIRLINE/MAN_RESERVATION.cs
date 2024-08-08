using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AIRLINE
{
    public partial class MAN_RESERVATION : Form
    {
        public MAN_RESERVATION()
        {
            InitializeComponent();
        }

        private void INSERT_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RESERVATION  values(@RESERVATION_ID,@PASSENGER_ID,@FLIGHT_NO,@SEAT_NO,@RESERVATION_DATE)", con);
            cmd.Parameters.AddWithValue("@RESERVATION_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@PASSENGER_ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@FLIGHT_NO",int.Parse( textBox3.Text));
            cmd.Parameters.AddWithValue("@SEAT_NO", textBox4.Text);
            cmd.Parameters.AddWithValue("@RESERVATION_DATE", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull inserterd");
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update RESERVATION set RESERVATION_ID=@RESERVATION_ID, PASSENGER_ID=@PASSENGER_ID,FLIGHT_NO=@FLIGHT_NO,SEAT_NO=@SEAT_NO,RESERVATION_DATE=@RESERVATION_DATE ", con);
            cmd.Parameters.AddWithValue("@RESERVATION_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@PASSENGER_ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@FLIGHT_NO", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@SEAT_NO", textBox4.Text);
            cmd.Parameters.AddWithValue("@RESERVATION_DATE", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull updated");
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete RESERVATION where RESERVATION_ID=@RESERVATION_ID ", con);
            cmd.Parameters.AddWithValue("@RESERVATION_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull Deleted");
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from RESERVATION ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from RESERVATION where RESERVATION_ID = '" + textBox1.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BACK_Click(object sender, EventArgs e)
        {
            MANAGER_MENU M1 = new MANAGER_MENU();
            M1.Show();
            Visible = false;
        }
    }
}
