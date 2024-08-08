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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("MANAGER");
            comboBox1.Items.Add("PASSENGER");
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "PASSENGER")
            {
                SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
                string USER_ID = textBox1.Text;
                string PASSWORD = textBox2.Text;
                String query = "SELECT count(*) FROM Passenger where USER_ID= @USER_ID and PASSWORD= @PASSWORD";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@USER_ID", USER_ID);
                cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD);

                con.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    MessageBox.Show("YOU ARE SUCCESSFULLY LOGIN", "Login", MessageBoxButtons.OK);
                    Form3 f3 = new Form3();
                    f3.Show();
                    Visible = false;
                }

                else
                {
                    MessageBox.Show("Invalid user id or password", "Login", MessageBoxButtons.OK);
                }
            }
            else if (comboBox1.Text == "MANAGER")
            {
                SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
                string USER_ID = textBox1.Text;
                string PASSWORD = textBox2.Text;
                String query = "SELECT count(*) FROM MANAGER where USER_ID= @USER_ID and PASSWORD= @PASSWORD";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@USER_ID", USER_ID);
                cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD);

                con.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    MessageBox.Show("YOU ARE SUCCESSFULLY LOGIN", "Login", MessageBoxButtons.OK);
                    MANAGER_MENU MN = new MANAGER_MENU();
                    MN.Show();
                    Visible = false;
                }
                else
                {

                }
            }
        }

                private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
                {

                }

        private void MANAGER_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REGISTER R1 = new REGISTER();
            R1.Show();
            Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


           
        }
    }
        } 
