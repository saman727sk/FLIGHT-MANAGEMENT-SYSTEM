﻿using System;
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
    public partial class REFUND : Form
    {
        public REFUND()
        {
            InitializeComponent();
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into REFUND values(@REFUND_ID,@RESERVATION_ID,@REFUND_AMOUNT,@REFUND_DATE)", con);
            cmd.Parameters.AddWithValue("@REFUND_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@RESERVATION_ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@REFUND_AMOUNT",int.Parse( textBox3.Text));
            cmd.Parameters.AddWithValue("@REFUND_DATE", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull inserterd");
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update REFUND set REFUND_ID=@REFUND_ID, RESERVATION_ID=@RESERVATION_ID,REFUND_AMOUNT=@REFUND_AMOUNT,REFUND_DATE=@REFUND_DATE", con);
            cmd.Parameters.AddWithValue("@REFUND_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@RESERVATION_ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@REFUND_AMOUNT",int.Parse( textBox3.Text));
            cmd.Parameters.AddWithValue("@REFUND_DATE", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull updated");
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete REFUND where REFUND_ID=@REFUND_ID ", con);
            cmd.Parameters.AddWithValue("@REFUND_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull Deleted");
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from REFUND ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from REFUND where REFUND_ID = '" + textBox1.Text + "'", con);
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

        }
    }
}
