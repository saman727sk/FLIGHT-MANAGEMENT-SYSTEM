﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIRLINE
{
    public partial class MANAGER_MENU : Form
    {
        public MANAGER_MENU()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MAN_FLIGHT_Click(object sender, EventArgs e)
        {
            MAN_FLIGHT MF = new MAN_FLIGHT();
            MF.Show();
            Visible = false;
        }

        private void MAN_AIRPLANE_Click(object sender, EventArgs e)
        {
            AIRPLANE A = new AIRPLANE();
            A.Show();
            Visible = false;
        }

        private void MAN_AIRPORTS_Click(object sender, EventArgs e)
        {
            MAN_AIRPORT AR = new MAN_AIRPORT();
            AR.Show();
            Visible = false;
        }

        private void MAN_PASSENGER_Click(object sender, EventArgs e)
        {
            MAN_PASSENGER MP = new MAN_PASSENGER();
            MP.Show();
            Visible = false;
        }

        private void MAN_RESERVATION_Click(object sender, EventArgs e)
        {
            MAN_RESERVATION MR = new MAN_RESERVATION();
            MR.Show();
            Visible = false;
        }

        private void MAN_FLIGHT_LEG_Click(object sender, EventArgs e)
        {
            MAN_F_LEG FL=new MAN_F_LEG();
            FL.Show();
            Visible = false;

        }

        private void MAN_SCHEDULE_Click(object sender, EventArgs e)
        {
            SCHEDULE S = new SCHEDULE();
            S.Show();
            Visible = false;
        }

        private void MAN_PAYMENT_Click(object sender, EventArgs e)
        {
            PAYMENT P = new PAYMENT();
            P.Show();
            Visible = false;
        }

        private void MAN_REFUND_Click(object sender, EventArgs e)
        {
            REFUND R = new REFUND();
            R.Show();
            Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }
    }
}
