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
    public partial class REGISTER : Form
    {
        public REGISTER()
        {
            InitializeComponent();
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();


            SqlCommand cmd = new SqlCommand("insert into MANAGER values(@MANAGER_ID,@FULL_NAME,@USER_ID,@PASSWORD)", con);

            cmd.Parameters.AddWithValue("@MANAGER_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@FULL_NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@USER_ID", textBox3.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", textBox4.Text);
    
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfull inserterd");
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }
    }
}
