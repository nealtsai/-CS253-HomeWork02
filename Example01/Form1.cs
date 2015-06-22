using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        private int[] status;

        public Form1()
        {
            InitializeComponent();
            InitializeSeats();
        }

        private void InitializeSeats()
        {
            Random random = new Random();
            status = new int[9];
            for (int index = 0; index < 9; index++)
            {
                status[index] = random.Next(0, 2);
            }
            SetSeatImage(status);
        }

        private void SetSeatImage(int[] status)
        {
            this.pictureBox1.Image = GetSeatImage(status[0]);
            this.pictureBox2.Image = GetSeatImage(status[1]);
            this.pictureBox3.Image = GetSeatImage(status[2]);
            this.pictureBox4.Image = GetSeatImage(status[3]);
            this.pictureBox5.Image = GetSeatImage(status[4]);
            this.pictureBox6.Image = GetSeatImage(status[5]);
            this.pictureBox7.Image = GetSeatImage(status[6]);
            this.pictureBox8.Image = GetSeatImage(status[7]);
            this.pictureBox9.Image = GetSeatImage(status[8]);
        }

        private Image GetSeatImage(int status)
        {
            if (status == 0)
            {
                return global::Example01.Properties.Resources.seat_unavail;
            }
            else if (status == 1)
            {
                return global::Example01.Properties.Resources.seat_avail;
            }
            else
            {
                return global::Example01.Properties.Resources.seat_select;
            }
        }

        public void chooseSeat()
        {
            for (int seatNumber = 0; seatNumber <= status.Length - 3; seatNumber++)
            {
                if (status[seatNumber] == 1 && status[seatNumber + 1] == 1 && status[seatNumber + 2] == 1)
                {
                    status[seatNumber] = 2;
                    status[seatNumber + 1] = 2;
                    status[seatNumber + 2] = 2;
                    SetSeatImage(status);
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chooseSeat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeSeats();
        }
    }
}