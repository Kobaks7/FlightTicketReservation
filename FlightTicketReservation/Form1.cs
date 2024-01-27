using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (startingPoint.Text!=endPoint.Text)
            {
                informationDisplay.Items.Add("Rota: "+startingPoint.Text+" - "+endPoint.Text+" Tarih: "+date.Text
                        +" Saat: "+time.Text+" Yolcu Ad Soyad: "+passengerName.Text+" TC Kimlik No: "+passengerTCNo.Text
                        +" Telefon No: "+passengerNumber.Text);

                MessageBox.Show("Yolcu kaydı yapıldı");
            }
            else
            {
                MessageBox.Show("Kalkış noktası ve varış noktası aynı olamaz!");
            }
            
        }

        private void changeLocationBtn_Click(object sender, EventArgs e)
        {
            string startPos = startingPoint.Text;
            string endPos = endPoint.Text;

            startingPoint.Text = endPos;
            endPoint.Text = startPos;
        }
    }
}
