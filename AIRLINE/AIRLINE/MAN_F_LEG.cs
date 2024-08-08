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
    public partial class MAN_F_LEG : Form
    {
        public MAN_F_LEG()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into FLIGHT_LEG values(@LEG_ID,@LEG_DURATION,@DEPARTURE_AIRPORT,@ARRIVAL_AIRPORT,@FLIGHT_NO)", con);
            cmd.Parameters.AddWithValue("@LEG_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@LEG_DURATION", textBox2.Text);
            cmd.Parameters.AddWithValue("@DEPARTURE_AIRPORT", textBox3.Text);
            cmd.Parameters.AddWithValue("@ARRIVAL_AIRPORT", textBox4.Text);
            cmd.Parameters.AddWithValue("@FLIGHT_NO", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull inserterd");
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update FLIGHT_LEG set LEG_ID=@LEG_ID, LEG_DURATION=@LEG_DURATION,DEPARTURE_AIRPORT=@DEPARTURE_AIRPORT,ARRIVAL_AIRPORT=@ARRIVAL_AIRPORT,FLIGHT_NO=@FLIGHT_NO ", con);
            cmd.Parameters.AddWithValue("@LEG_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@LEG_DURATION", textBox2.Text);
            cmd.Parameters.AddWithValue("@DEPARTURE_AIRPORT", textBox3.Text);
            cmd.Parameters.AddWithValue("@ARRIVAL_AIRPORT", textBox4.Text);
            cmd.Parameters.AddWithValue("@FLIGHT_NO", int.Parse(textBox5.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull updated");
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete FLIGHT_LEG where LEG_ID=@LEG_ID ", con);
            cmd.Parameters.AddWithValue("@LEG_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull Deleted");
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from FLIGHT_LEG ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from FLIGHT_LEG where LEG_ID = '" + textBox1.Text + "'", con);
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
