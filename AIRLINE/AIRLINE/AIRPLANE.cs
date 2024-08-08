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
    public partial class AIRPLANE : Form
    {
        public AIRPLANE()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into AIRPLANE values(@AIRPLANE_ID,@CAPACITY,@FLIGHT_NO)", con);
            cmd.Parameters.AddWithValue("@AIRPLANE_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@CAPACITY", textBox2.Text);
            cmd.Parameters.AddWithValue("@FLIGHT_NO", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull inserterd");

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update AIRPLANE set AIRPLANE_ID=@AIRPLANE_ID, CAPACITY=@CAPACITY ,FLIGHT_NO=@FLIGHT_NO where  AIRPLANE_ID=@AIRPLANE_ID", con);
            cmd.Parameters.AddWithValue("@AIRPLANE_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@CAPACITY", textBox2.Text);
            cmd.Parameters.AddWithValue("@FLIGHT_NO", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull updated");

        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete AIRPLANE where AIRPLANE_ID=@AIRPLANE_ID ", con);
            cmd.Parameters.AddWithValue("@AIRPLANE_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull Deleted");


        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AIRPLANE ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AIRPLANE where AIRPLANE_ID = '" + textBox1.Text + "'", con);
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
            MANAGER_MENU MN = new MANAGER_MENU();
            MN.Show();
            Visible = false;
        }
    }
}
