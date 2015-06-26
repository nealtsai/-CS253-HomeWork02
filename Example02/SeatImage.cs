using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class SeatImage
    {
        public string imagePath;

        public void SetImage(int status)
        {
            string seatUnavail = System.IO.Directory.GetCurrentDirectory() + "\\SeatImage\\seat_unavail.png";
            string seatAvail = System.IO.Directory.GetCurrentDirectory() + "\\SeatImage\\seat_avail.png";
            string seatSelect = System.IO.Directory.GetCurrentDirectory() + "\\SeatImage\\seat_select.png;";

            if (status == 0)
            {
                imagePath = seatUnavail;
            }
            else if (status == 1)
            {
                imagePath = seatAvail;
            }
            else imagePath = seatSelect;
        }

        public void GetImage(int status, Form1 mform)
        {
        }
    }
}