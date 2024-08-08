namespace AIRLINE
{
    partial class MANAGER_MENU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MAN_FLIGHT = new System.Windows.Forms.Button();
            this.MAN_AIRPLANE = new System.Windows.Forms.Button();
            this.MAN_AIRPORTS = new System.Windows.Forms.Button();
            this.MAN_PASSENGER = new System.Windows.Forms.Button();
            this.MAN_RESERVATION = new System.Windows.Forms.Button();
            this.MAN_FLIGHT_LEG = new System.Windows.Forms.Button();
            this.MAN_SCHEDULE = new System.Windows.Forms.Button();
            this.MAN_PAYMENT = new System.Windows.Forms.Button();
            this.MAN_REFUND = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BACK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-95, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1561, 136);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(679, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fly High With Your Dreams";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(636, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "FLY HIGH AIRLINE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AIRLINE.Properties.Resources.fly;
            this.pictureBox1.Location = new System.Drawing.Point(131, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(-39, 641);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1448, 186);
            this.panel2.TabIndex = 2;
            // 
            // MAN_FLIGHT
            // 
            this.MAN_FLIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MAN_FLIGHT.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAN_FLIGHT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MAN_FLIGHT.Location = new System.Drawing.Point(336, 214);
            this.MAN_FLIGHT.Name = "MAN_FLIGHT";
            this.MAN_FLIGHT.Size = new System.Drawing.Size(183, 85);
            this.MAN_FLIGHT.TabIndex = 3;
            this.MAN_FLIGHT.Text = "MANAGE_FLIGHT";
            this.MAN_FLIGHT.UseVisualStyleBackColor = false;
            this.MAN_FLIGHT.Click += new System.EventHandler(this.MAN_FLIGHT_Click);
            // 
            // MAN_AIRPLANE
            // 
            this.MAN_AIRPLANE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MAN_AIRPLANE.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAN_AIRPLANE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MAN_AIRPLANE.Location = new System.Drawing.Point(588, 214);
            this.MAN_AIRPLANE.Name = "MAN_AIRPLANE";
            this.MAN_AIRPLANE.Size = new System.Drawing.Size(201, 84);
            this.MAN_AIRPLANE.TabIndex = 4;
            this.MAN_AIRPLANE.Text = "MANAGE_AIRPLANE";
            this.MAN_AIRPLANE.UseVisualStyleBackColor = false;
            this.MAN_AIRPLANE.Click += new System.EventHandler(this.MAN_AIRPLANE_Click);
            // 
            // MAN_AIRPORTS
            // 
            this.MAN_AIRPORTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MAN_AIRPORTS.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAN_AIRPORTS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MAN_AIRPORTS.Location = new System.Drawing.Point(849, 214);
            this.MAN_AIRPORTS.Name = "MAN_AIRPORTS";
            this.MAN_AIRPORTS.Size = new System.Drawing.Size(180, 85);
            this.MAN_AIRPORTS.TabIndex = 5;
            this.MAN_AIRPORTS.Text = "MANAGE_AIRPORTS";
            this.MAN_AIRPORTS.UseVisualStyleBackColor = false;
            this.MAN_AIRPORTS.Click += new System.EventHandler(this.MAN_AIRPORTS_Click);
            // 
            // MAN_PASSENGER
            // 
            this.MAN_PASSENGER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MAN_PASSENGER.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAN_PASSENGER.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MAN_PASSENGER.Location = new System.Drawing.Point(336, 340);
            this.MAN_PASSENGER.Name = "MAN_PASSENGER";
            this.MAN_PASSENGER.Size = new System.Drawing.Size(183, 83);
            this.MAN_PASSENGER.TabIndex = 6;
            this.MAN_PASSENGER.Text = "MANAGE_PASSENGER";
            this.MAN_PASSENGER.UseVisualStyleBackColor = false;
            this.MAN_PASSENGER.Click += new System.EventHandler(this.MAN_PASSENGER_Click);
            // 
            // MAN_RESERVATION
            // 
            this.MAN_RESERVATION.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MAN_RESERVATION.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAN_RESERVATION.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MAN_RESERVATION.Location = new System.Drawing.Point(588, 344);
            this.MAN_RESERVATION.Name = "MAN_RESERVATION";
            this.MAN_RESERVATION.Size = new System.Drawing.Size(201, 79);
            this.MAN_RESERVATION.TabIndex = 7;
            this.MAN_RESERVATION.Text = "MANAGE_RESERVATIONS";
            this.MAN_RESERVATION.UseVisualStyleBackColor = false;
            this.MAN_RESERVATION.Click += new System.EventHandler(this.MAN_RESERVATION_Click);
            // 
            // MAN_FLIGHT_LEG
            // 
            this.MAN_FLIGHT_LEG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MAN_FLIGHT_LEG.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAN_FLIGHT_LEG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MAN_FLIGHT_LEG.Location = new System.Drawing.Point(849, 344);
            this.MAN_FLIGHT_LEG.Name = "MAN_FLIGHT_LEG";
            this.MAN_FLIGHT_LEG.Size = new System.Drawing.Size(180, 79);
            this.MAN_FLIGHT_LEG.TabIndex = 8;
            this.MAN_FLIGHT_LEG.Text = "MANAGE_FLIGHT_LEG";
            this.MAN_FLIGHT_LEG.UseVisualStyleBackColor = false;
            this.MAN_FLIGHT_LEG.Click += new System.EventHandler(this.MAN_FLIGHT_LEG_Click);
            // 
            // MAN_SCHEDULE
            // 
            this.MAN_SCHEDULE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MAN_SCHEDULE.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAN_SCHEDULE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MAN_SCHEDULE.Location = new System.Drawing.Point(336, 462);
            this.MAN_SCHEDULE.Name = "MAN_SCHEDULE";
            this.MAN_SCHEDULE.Size = new System.Drawing.Size(183, 87);
            this.MAN_SCHEDULE.TabIndex = 9;
            this.MAN_SCHEDULE.Text = "MANAGE_SCHEDULE";
            this.MAN_SCHEDULE.UseVisualStyleBackColor = false;
            this.MAN_SCHEDULE.Click += new System.EventHandler(this.MAN_SCHEDULE_Click);
            // 
            // MAN_PAYMENT
            // 
            this.MAN_PAYMENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MAN_PAYMENT.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAN_PAYMENT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MAN_PAYMENT.Location = new System.Drawing.Point(588, 462);
            this.MAN_PAYMENT.Name = "MAN_PAYMENT";
            this.MAN_PAYMENT.Size = new System.Drawing.Size(201, 87);
            this.MAN_PAYMENT.TabIndex = 10;
            this.MAN_PAYMENT.Text = "MANAGE_PAYMENT";
            this.MAN_PAYMENT.UseVisualStyleBackColor = false;
            this.MAN_PAYMENT.Click += new System.EventHandler(this.MAN_PAYMENT_Click);
            // 
            // MAN_REFUND
            // 
            this.MAN_REFUND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MAN_REFUND.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAN_REFUND.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MAN_REFUND.Location = new System.Drawing.Point(849, 462);
            this.MAN_REFUND.Name = "MAN_REFUND";
            this.MAN_REFUND.Size = new System.Drawing.Size(178, 87);
            this.MAN_REFUND.TabIndex = 11;
            this.MAN_REFUND.Text = "MANAGE_REFUND";
            this.MAN_REFUND.UseVisualStyleBackColor = false;
            this.MAN_REFUND.Click += new System.EventHandler(this.MAN_REFUND_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1403, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(630, 587);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(75, 23);
            this.BACK.TabIndex = 13;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // MANAGER_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.MAN_REFUND);
            this.Controls.Add(this.MAN_PAYMENT);
            this.Controls.Add(this.MAN_SCHEDULE);
            this.Controls.Add(this.MAN_FLIGHT_LEG);
            this.Controls.Add(this.MAN_RESERVATION);
            this.Controls.Add(this.MAN_PASSENGER);
            this.Controls.Add(this.MAN_AIRPORTS);
            this.Controls.Add(this.MAN_AIRPLANE);
            this.Controls.Add(this.MAN_FLIGHT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MANAGER_MENU";
            this.Text = "MANAGER_MENU";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MAN_FLIGHT;
        private System.Windows.Forms.Button MAN_AIRPLANE;
        private System.Windows.Forms.Button MAN_AIRPORTS;
        private System.Windows.Forms.Button MAN_PASSENGER;
        private System.Windows.Forms.Button MAN_RESERVATION;
        private System.Windows.Forms.Button MAN_FLIGHT_LEG;
        private System.Windows.Forms.Button MAN_SCHEDULE;
        private System.Windows.Forms.Button MAN_PAYMENT;
        private System.Windows.Forms.Button MAN_REFUND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BACK;
    }
}