using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TrafficLights
{
    public partial class TrafficLightsGUI : Form
    {
        public TrafficLightsGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            serialPort1.PortName = "COM4";
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;

            textBox1.Text = "No Data";

            serialPort1.Open();
        }

        readonly int[,] led7code = { {1,1,1,1,1,1,0},{0,1,1,0,0,0,0},{1,1,0,1,1,0,1 },{1,1,1,1,0,0,1},{0,1,1,0,0,1,1},{1,0,1,1,0,1,1},{1,0,1,1,1,1,1},{1,1,1,0,0,0,0},{1,1,1,1,1,1,1},{1,1,1,1,0,1,1} };

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string rcv_data = serialPort1.ReadLine();
            textBox1.Text = rcv_data;
            string[] sub_data = rcv_data.Split(';');
            lblLamp_info.Text = sub_data[1];
            lblTime_Remaining.Text = sub_data[2];

            if (sub_data[1] == "1")
            {
                DXA.FillColor = Color.Green;
                DDA.FillColor = Color.White;
            }
            if (sub_data[1] == "2")
            {
                DXA.FillColor = Color.White;
                DVA.FillColor = Color.Yellow;
            }
            if (sub_data[1] == "4")
            {
                DVA.FillColor = Color.White;
                DDA.FillColor = Color.Red;
            }
            string ctime = sub_data[2].TrimEnd('\r', ' ');
            if (ctime.Length < 2) ctime = "0" + ctime;
            int chucA = ctime[0] - 0x30;
            int donviA = ctime[1]- 0x30;
            Ada.FillColor = (led7code[donviA, 0] != 0) ? Color.OrangeRed : Color.White;
            Adb.FillColor = (led7code[donviA, 1] != 0) ? Color.OrangeRed : Color.White;
            Adc.FillColor = (led7code[donviA, 2] != 0) ? Color.OrangeRed : Color.White;
            Add.FillColor = (led7code[donviA, 3] != 0) ? Color.OrangeRed : Color.White;
            Ade.FillColor = (led7code[donviA, 4] != 0) ? Color.OrangeRed : Color.White;
            Adf.FillColor = (led7code[donviA, 5] != 0) ? Color.OrangeRed : Color.White;
            Adg.FillColor = (led7code[donviA, 6] != 0) ? Color.OrangeRed : Color.White;
            Aca.FillColor = (led7code[chucA, 0] != 0) ? Color.OrangeRed : Color.White;
            Acb.FillColor = (led7code[chucA, 1] != 0) ? Color.OrangeRed : Color.White;
            Acc.FillColor = (led7code[chucA, 2] != 0) ? Color.OrangeRed : Color.White;
            Acd.FillColor = (led7code[chucA, 3] != 0) ? Color.OrangeRed : Color.White;
            Ace.FillColor = (led7code[chucA, 4] != 0) ? Color.OrangeRed : Color.White;
            Acf.FillColor = (led7code[chucA, 5] != 0) ? Color.OrangeRed : Color.White;
            Acg.FillColor = (led7code[chucA, 6] != 0) ? Color.OrangeRed : Color.White;

        }

        private void DXA_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
