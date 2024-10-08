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
    public partial class MAN_AIRPORT : Form
    {
        public MAN_AIRPORT()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void INSERT_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into AIRPORT values(@AIRPORT_CODE,@AIRPORT_NAME,@AIRPORT_COUNTRY,@AIRPORT_CITY,@FLIGHT_NO)", con);
            cmd.Parameters.AddWithValue("@AIRPORT_CODE", textBox1.Text);
            cmd.Parameters.AddWithValue("@AIRPORT_NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@AIRPORT_COUNTRY", textBox3.Text);
            cmd.Parameters.AddWithValue("@AIRPORT_CITY", textBox4.Text);
            cmd.Parameters.AddWithValue("@FLIGHT_NO", int.Parse(textBox5.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull inserterd");

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update AIRPORT set AIRPORT_CODE=@AIRPORT_CODE, AIRPORT_NAME=@AIRPORT_NAME,AIRPORT_COUNTRY=@AIRPORT_COUNTRY,AIRPORT_CITY=@AIRPORT_CITY,FLIGHT_NO=@FLIGHT_NO ", con);
            cmd.Parameters.AddWithValue("@AIRPORT_CODE", textBox1.Text);
            cmd.Parameters.AddWithValue("@AIRPORT_NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@AIRPORT_COUNTRY", textBox3.Text);
            cmd.Parameters.AddWithValue("@AIRPORT_CITY", textBox4.Text);
            cmd.Parameters.AddWithValue("@FLIGHT_NO", int.Parse(textBox5.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull updated");
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete AIRPORT where AIRPORT_CODE=@AIRPORT_CODE ", con);
            cmd.Parameters.AddWithValue("@AIRPORT_CODE", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull Deleted");
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AIRPORT ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AIRPORT where AIRPORT_CODE = '" + textBox1.Text + "'", con);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
