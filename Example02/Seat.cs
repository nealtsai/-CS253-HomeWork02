using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    internal class Seat
    {
        private SeatImage seatImage;
        private Random random = new Random();
        private int[] status;

        public void InitializeSeats(int number, Form1 mform)
        {
            status = new int[number];
            for (int i = 0; i < number; i++)
            {
                status[i] = random.Next(0, 2);
            }

            for (int i = 0; i < number; i++)
            {
                PictureBox imagePictureBox = new PictureBox();
                if (i < 12)
                {
                    imagePictureBox.Location = new System.Drawing.Point(10 + 87 * i, 10);
                }
                else imagePictureBox.Location = new System.Drawing.Point(10 + 87 * (i - 12), 135);

                imagePictureBox.Name = "imageBox" + i;
                seatImage = new SeatImage();
                seatImage.SetImage(status[i]);
                imagePictureBox.Load(seatImage.imagePath);
                imagePictureBox.Size = new System.Drawing.Size(87, 125);
                mform.Controls.Add(imagePictureBox);
            }
            //PictureBox imagePictureBox = new PictureBox();
            //imagePictureBox.Location = new System.Drawing.Point(10, 10);
            //imagePictureBox.Load("C:\\Users\\tgi0464\\Documents\\Visual Studio 2013\\Projects\\In Study\\[In Study] 2015-06-23\\SeatImage\\seat_select.png");
            //imagePictureBox.Size = new System.Drawing.Size(87, 125);
            //Form1 ff7 = new Form1();
            //mform.Controls.Add(imagePictureBox);
        }

        public void ResetSeatsStatus(int number, Form1 mform)
        {
            status = new int[number];
            for (int i = 0; i < number; i++)
            {
                status[i] = random.Next(0, 2);
            }

            int a = -1;
            for (int i = 0; i < mform.Controls.Count; i++)
            {
                if (mform.Controls[i].GetType().Name == "PictureBox")
                {
                    a++;
                    PictureBox imagePictureBox = new PictureBox();
                    imagePictureBox = (PictureBox)mform.Controls[i];
                    seatImage = new SeatImage();
                    seatImage.SetImage(status[a]);
                    imagePictureBox.Load(seatImage.imagePath);
                }
            }
        }

        public void ChooseSeats(Form1 mform)
        {
            for (int i = 0; i < status.Length; i++)
            {
                if (status[i] == 1 && status[i + 1] == 1 && status[i + 2] == 1)
                {
                    PictureBox imagePictureBox = new PictureBox();
                    imagePictureBox = (PictureBox)mform.Controls[2];
                }
            }
        }
    }
}