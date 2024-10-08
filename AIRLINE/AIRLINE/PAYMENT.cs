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
    public partial class PAYMENT : Form
    {
        public PAYMENT()
        {
            InitializeComponent();
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into PAYMENT values(@PAYMENT_ID,@RESERVATION_ID,@PAYMENT_DATE,@PAYMENT_AMOUNT,@PAYMENT_METHOD,@STATUS)", con);
            cmd.Parameters.AddWithValue("@PAYMENT_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@RESERVATION_ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@PAYMENT_DATE", textBox3.Text);
            cmd.Parameters.AddWithValue("@PAYMENT_AMOUNT", textBox4.Text);
            cmd.Parameters.AddWithValue("@PAYMENT_METHOD", textBox5.Text);
            cmd.Parameters.AddWithValue("@STATUS", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull inserterd");
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update PAYMENT set PAYMENT_ID=@PAYMENT_ID, RESERVATION_ID=@RESERVATION_ID,PAYMENT_DATE=@PAYMENT_DATE,PAYMENT_AMOUNT=@PAYMENT_AMOUNT,PAYMENT_METHOD=@PAYMENT_METHOD,STATUS=@STATUS ", con);
            cmd.Parameters.AddWithValue("@PAYMENT_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@RESERVATION_ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@PAYMENT_DATE", textBox3.Text);
            cmd.Parameters.AddWithValue("@PAYMENT_AMOUNT", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@PAYMENT_METHOD", textBox5.Text);
            cmd.Parameters.AddWithValue("@STATUS", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull updated");
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete PAYMENT where PAYMENT_ID=@PAYMENT_ID ", con);
            cmd.Parameters.AddWithValue("@PAYMENT_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull Deleted");
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from PAYMENT ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from PAYMENT where PAYMENT_ID = '" + textBox1.Text + "'", con);
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

        private void PAYMENT_Load(object sender, EventArgs e)
        {

        }
    }
}
