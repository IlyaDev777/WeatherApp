using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using System.IO;
using System.Threading;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        string[][] stateID = new string[9][];
        TimerCallback tm;
        System.Threading.Timer timerThread;
        public string[] data;
        public string temp;
        public string feels;
        public string state;
        public Point lastPoint;
        string[] states;
        PictureBox[] statePictures;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public void timer_tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle screenSize = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            this.Location = new Point(screenSize.Width - this.Width - 10, 10);

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = 1000;
            timer.Start();


           

            statePictures = new PictureBox[]
            {
                pbClearSky,
                pbFewClouds,
                pbScatteredClouds,
                pbBrokenClouds,
                pbShowerRain,
                pbRain,
                pbThunderstorm,
                pbSnow,
                pbMist
            };

            pbClearSky.Visible = false;
            pbFewClouds.Visible = false;
            pbScatteredClouds.Visible = false;
            pbBrokenClouds.Visible = false;
            pbShowerRain.Visible = false;
            pbRain.Visible = false;
            pbThunderstorm.Visible = false;
            pbSnow.Visible = false;
            pbMist.Visible = false;
            
            stateID[0] = new string[] { "800" };
            stateID[1] = new string[] { "801" };
            stateID[2] = new string[] { "802" };
            stateID[3] = new string[] { "803", "804" };
            stateID[4] = new string[] { "300", "301", "302", "310", "311", "312",
                "313", "314", "321", "520", "521", "522", "531"};
            stateID[5] = new string[] { "500", "501", "502", "503", "504" };
            stateID[6] = new string[] { "200", "201", "202", "210", "211", "212", "221",
                "230", "231", "232" };
            stateID[7] = new string[] { "511", "600", "601", "602", "611", "612", "613",
                "615", "616", "620", "621", "622" };
            stateID[8] = new string[] { "701", "711", "721", "731", "741", "751", "761",
                "762", "771", "781" };

            tm = new TimerCallback(GetData);
            timerThread = new System.Threading.Timer(tm, null, 0, 600000);
            
            
        }

        private void GetData(object obj)
        {
            data = File.ReadAllText(@"E:\CurrentWeather.txt").Split(';');
            temp = Math.Round(double.Parse(data[0])).ToString();
            feels = Math.Round(double.Parse(data[1])).ToString();
            state = data[2];

            if (temp.Length == 1)
            {
                this.Invoke((MethodInvoker)(() => lblTemp.Location = new Point(78, 186)));
                this.Invoke((MethodInvoker)(() => lblO.Location = new Point(111, 188)));
            }

            if (temp.Length == 3)
            {
                this.Invoke((MethodInvoker)(() => lblTemp.Location = new Point(53, 186)));
                this.Invoke((MethodInvoker)(() => lblO.Location = new Point(126, 188)));
            }

            if (temp.Length == 2 && !temp.Contains("-"))
            {
                this.Invoke((MethodInvoker)(() => lblTemp.Location = new Point(66, 186)));
                this.Invoke((MethodInvoker)(() => lblO.Location = new Point(123, 188)));
                
            }

            if (temp.Length == 2 && temp.Contains("-"))
            {
                this.Invoke((MethodInvoker)(() => lblTemp.Location = new Point(63, 186)));
                this.Invoke((MethodInvoker)(() => lblO.Location = new Point(112, 188)));
            }

            this.Invoke((MethodInvoker)(() => lblTemp.Text = temp));
            this.Invoke((MethodInvoker)(() => lblFeels.Text = feels));
           
            
            for (int i = 0; i < stateID.Length; i++)
            {
                this.Invoke((MethodInvoker)(() => statePictures[i].Visible = false));

                for (int j = 0; j < stateID[i].Length; j++)
                {
                    if (state.Equals(stateID[i][j]))
                    {
                        this.Invoke((MethodInvoker)(() => statePictures[i].Visible = true));
                        break;
                    }
                }
            }
        }
    }
}
