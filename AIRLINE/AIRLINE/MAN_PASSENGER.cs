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
    public partial class MAN_PASSENGER : Form
    {
        public MAN_PASSENGER()
        {
            InitializeComponent();
        }

        private void MAN_PASSENGER_Load(object sender, EventArgs e)
        {

        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Passenger values(@PASSENGER_ID,@PASSPORT_NO,@FIRST_NAME,@LAST_NAME,@USER_ID,@PASSWORD)", con);
            cmd.Parameters.AddWithValue("@PASSENGER_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@PASSPORT_NO",int.Parse( textBox2.Text));
            cmd.Parameters.AddWithValue("@FIRST_NAME", textBox3.Text);
            cmd.Parameters.AddWithValue("@LAST_NAME", textBox4.Text);
            cmd.Parameters.AddWithValue("@USER_ID", textBox5.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull inserterd");
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Passenger set PASSENGER_ID=@PASSENGER_ID, PASSPORT_NO=@PASSPORT_NO,FIRST_NAME=@FIRST_NAME,LAST_NAME=@LAST_NAME,USER_ID=@USER_ID,PASSWORD=@PASSWORD ", con);
            cmd.Parameters.AddWithValue("@PASSENGER_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@PASSPORT_NO", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@FIRST_NAME", textBox3.Text);
            cmd.Parameters.AddWithValue("@LAST_NAME", textBox4.Text);
            cmd.Parameters.AddWithValue("@USER_ID", textBox5.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull updated");
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Passenger where PASSENGER_ID=@PASSENGER_ID ", con);
            cmd.Parameters.AddWithValue("@PASSENGER_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull Deleted");
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Passenger ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Passenger where PASSENGER_ID = '" + textBox1.Text + "'", con);
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
