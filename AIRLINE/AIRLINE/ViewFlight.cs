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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AIRLINE
{
    public partial class ViewFlight : Form
    {
        public ViewFlight()
        {
            InitializeComponent();
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT FLIGHT_NO,ORIGIN,DESTINATION,DEPARTURE_TIME,ARRIVAL_TIME,AIRPLANE_ID,FLIGHT_DURATION FROM FLIGHT;\r\n", con);
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
            try
            {
                string connectionString = "Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM FLIGHT WHERE ORIGIN = @origin AND DESTINATION = @destination";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@origin", textBox1.Text);
                        cmd.Parameters.AddWithValue("@destination", textBox2.Text);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SEAT_RESERVED_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                SELECT p.PASSENGER_ID, p.PASSPORT_NO, p.FIRST_NAME, p.LAST_NAME,
                       r.RESERVATION_ID, r.FLIGHT_NO, r.RESERVATION_DATE, r.SEAT_NO,F.ORIGIN,F.DESTINATION,py.PAYMENT_ID, py.PAYMENT_AMOUNT,py.STATUS
                FROM Passenger p
                JOIN RESERVATION r  ON p.PASSENGER_ID = r.PASSENGER_ID 
                JOIN FLIGHT f ON r.FLIGHT_NO = f.FLIGHT_NO
                JOIN PAYMENT py ON py.RESERVATION_ID=r.RESERVATION_ID
                WHERE p.PASSENGER_ID =@PASSENGER_ID AND f.FLIGHT_NO  = @FLIGHT_NO";
                   

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Passenger_Id", textBox7.Text);
                        cmd.Parameters.AddWithValue("@FLIGHT_NO", textBox3.Text);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No data found for the given Passenger ID.");
                        }
                        else
                        {
                            dataGridView1.DataSource = dt;
                            MessageBox.Show("seat reserved");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            
               
            }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=SAMAN\\SQLEXPRESS;Initial Catalog=Passenger;Integrated Security=True;Encrypt=False";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
            SELECT p.PASSENGER_ID, p.PASSPORT_NO, p.FIRST_NAME, p.LAST_NAME,
                   r.RESERVATION_ID, r.FLIGHT_NO, r.RESERVATION_DATE, r.SEAT_NO,
                   f.ORIGIN, f.DESTINATION
            FROM Passenger p
            JOIN RESERVATION r ON p.PASSENGER_ID = r.PASSENGER_ID
            JOIN FLIGHT f ON r.FLIGHT_NO = f.FLIGHT_NO
            WHERE p.PASSENGER_ID = @Passenger_Id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Passenger_Id", textBox7.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No data found for the given Passenger ID.");
                        }
                        else
                        {
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
    }


