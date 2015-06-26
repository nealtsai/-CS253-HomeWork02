using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public partial class Form1 : Form
    {
        //private int[] status;
        private Seat seat;

        private int number = 24;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seat = new Seat();
            //InitializeSeats();
            seat.InitializeSeats(number, this);
        }

        //private void InitializeSeats()
        //{
        //    Random random = new Random();
        //    int number = 24;
        //    status = new int[number];
        //    for (int i = 0; i < number; i++)
        //    {
        //        status[i] = random.Next(0, 2);
        //    }

        //    for (int j = 0; j < number; j++)
        //    {
        //        PictureBox imagePictureBox = new PictureBox();
        //        if (j < 12)
        //        {
        //            imagePictureBox.Location = new System.Drawing.Point(10 + 87 * j, 10);
        //        }
        //        else imagePictureBox.Location = new System.Drawing.Point(10 + 87 * (j - 12), 135);

        //        imagePictureBox.Name = "imageBox" + j;

        //        if (status[j] == 0)
        //        {
        //            imagePictureBox.Load("C:\\Users\\tgi0464\\Documents\\Visual Studio 2013\\Projects\\In Study\\[In Study] 2015-06-23\\SeatImage\\seat_unavail.png");
        //        }
        //        else if (status[j] == 1)
        //        {
        //            imagePictureBox.Load("C:\\Users\\tgi0464\\Documents\\Visual Studio 2013\\Projects\\In Study\\[In Study] 2015-06-23\\SeatImage\\seat_avail.png");
        //        }
        //        else imagePictureBox.Load("C:\\Users\\tgi0464\\Documents\\Visual Studio 2013\\Projects\\In Study\\[In Study] 2015-06-23\\SeatImage\\seat_select.png");

        //        imagePictureBox.Size = new System.Drawing.Size(87, 125);
        //        this.Controls.Add(imagePictureBox);
        //        string ab = imagePictureBox.Name;
        //    }
        //}

        private void ResetSeatsButton_Click(object sender, EventArgs e)
        {
            seat.ResetSeatsStatus(24, this);
        }

        private void ChooseSeatsButton_Click(object sender, EventArgs e)
        {
            seat.ChooseSeats(this);
        }
    }
}