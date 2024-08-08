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

namespace AIRLINE
{
    public partial class MAN_FLIGHT : Form
    {
        public MAN_FLIGHT()
        {
            InitializeComponent();
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into FLIGHT values(@FLIGHT_NO,@ORIGIN,@DESTINATION,@DEPARTURE_TIME,@ARRIVAL_TIME,@AIRPLANE_ID,@FLIGHT_DURATION)", con);
            cmd.Parameters.AddWithValue("@FLIGHT_NO", int.Parse(textBox1.Text)); 
            cmd.Parameters.AddWithValue("@ORIGIN", textBox2.Text);
            cmd.Parameters.AddWithValue("@DESTINATION", textBox3.Text);
            cmd.Parameters.AddWithValue("@DEPARTURE_TIME", textBox4.Text);
            cmd.Parameters.AddWithValue("@ARRIVAL_TIME", textBox5.Text);
            cmd.Parameters.AddWithValue("@AIRPLANE_ID", textBox6.Text);
            cmd.Parameters.AddWithValue("@FLIGHT_DURATION", int.Parse(textBox7.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull inserterd");

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update FLIGHT set FLIGHT_NO=@FLIGHT_NO, ORIGIN=@ORIGIN,DESTINATION=@DESTINATION,DEPARTURE_TIME=@DEPARTURE_TIME,ARRIVAL_TIME=@ARRIVAL_TIME,AIRPLANE_ID=@AIRPLANE_ID,FLIGHT_DURATION=@FLIGHT_DURATION WHERE FLIGHT_NO=@FLIGHT_NO ", con);
            cmd.Parameters.AddWithValue("@FLIGHT_NO", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@ORIGIN", textBox2.Text);
            cmd.Parameters.AddWithValue("@DESTINATION", textBox3.Text);
            cmd.Parameters.AddWithValue("@DEPARTURE_TIME", textBox4.Text);
            cmd.Parameters.AddWithValue("@ARRIVAL_TIME", textBox5.Text);
            cmd.Parameters.AddWithValue("@AIRPLANE_ID", textBox6.Text);
            cmd.Parameters.AddWithValue("@FLIGHT_DURATION", int.Parse(textBox7.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull updated");

        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete FLIGHT where FLIGHT_NO=@FLIGHT_NO ", con);
            cmd.Parameters.AddWithValue("@FLIGHT_NO", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull Deleted");

        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from FLIGHT ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from FLIGHT where FLIGHT_NO = '" + textBox1.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void BACK_Click(object sender, EventArgs e)
        {
            MANAGER_MENU M1 = new MANAGER_MENU();
            M1.Show();
            Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
