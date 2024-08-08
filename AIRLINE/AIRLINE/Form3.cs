using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void SERVICES_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
            Visible = false;
        }

        private void CONTACT_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            Visible = false;
        }

        private void BOOK_Click(object sender, EventArgs e)
        {
             ViewFlight VF = new ViewFlight();
             VF.Show();
           // Form6 f6 = new Form6();
           // f6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
