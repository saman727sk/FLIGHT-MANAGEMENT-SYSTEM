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

namespace AIRLINE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void REGISTERED_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();


            SqlCommand cmd = new SqlCommand("insert into Passenger values(@PASSENGER_ID,@PASSPORT_NO,@FIRST_NAME,@LAST_NAME,@USER_ID,@PASSWORD)", con);

            cmd.Parameters.AddWithValue("@PASSENGER_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@PASSPORT_NO", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@FIRST_NAME", FIRSTNAME.Text);
            cmd.Parameters.AddWithValue("@LAST_NAME", LASTNAME.Text);
            cmd.Parameters.AddWithValue("@USER_ID", USERID.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", PASS.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull inserterd");
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }
    }
}
