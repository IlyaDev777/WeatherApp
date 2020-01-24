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
namespace WeatherApp
{
    public partial class Form1 : Form
    {
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

            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = 1000;
            timer.Start();

            states = new string[]
            {
                "Clear sky",
                "Few clouds",
                "Scattered clouds",
                "Broken clouds",
                "Shower rain",
                "Rain",
                "Thunderstorm",
                "Snow",
                "Mist"
            };

            statePictures = new PictureBox[]
            {
                pbSun,
                pbSunny,
                pbCloudy,
                pbOvercast,
                pbLightRain,
                pbRain,
                pbThander,
                pbSnow,
                pbFog
            };

            pbCloudy.Visible = false;
            pbFog.Visible = false;
            pbOvercast.Visible = false;
            pbRain.Visible = false;
            pbSnow.Visible = false;
            pbSun.Visible = false;
            pbSunny.Visible = false;
            pbThander.Visible = false;
            pbLightRain.Visible = false;
            pbDefault.Visible = false;

            GetData();
            //switch (state)
            //{
            //    case "Clear sky":
            //        pbSun.Visible = true;
            //        pbSunny.Visible = false;

            //        break;

            //    case "Few clouds":
            //        pbSunny.Visible = true;
            //        break;

            //    case "Scattered clouds":
            //        pbCloudy.Visible = true;
            //        break;

            //    case "Broken clouds":
            //        pbOvercast.Visible = true;
            //        break;

            //    case "Shower rain":
            //        pbLightRain.Visible = true;
            //        break;

            //    case "Rain":
            //        pbRain.Visible = true;
            //        break;

            //    case "Thanderstorm":
            //        pbThander.Visible = true;
            //        break;

            //    case "Snow":
            //        pbSnow.Visible = true;
            //        break;

            //    case "Mist":
            //        pbFog.Visible = true;
            //        break;

            //    default:
            //        pbDefault.Visible = true;
            //        break;

            //}


        }

        private void GetData()
        {
            data = File.ReadAllText(@"E:\CurrentWeather.txt").Split(';');
            temp = Math.Round(double.Parse(data[0])).ToString();
            feels = Math.Round(double.Parse(data[1])).ToString();
            state = data[2];

            if (temp.Length == 1)
            {
                lblTemp.Location = new Point(78, 186);
                lblO.Location = new Point(111, 188);
            }

            if (temp.Length == 3)
            {
                lblTemp.Location = new Point(53, 186);
                lblO.Location = new Point(126, 188);
            }

            if (temp.Length == 2 && !temp.Contains("-"))
            {
                lblTemp.Location = new Point(66, 186);
                lblO.Location = new Point(123, 188);
            }

            if (temp.Length == 2 && temp.Contains("-"))
            {
                lblTemp.Location = new Point(63, 186);
                lblO.Location = new Point(112, 188);
            }


            lblTemp.Text = temp;
            lblFeels.Text = feels;

            for (int i = 0; i < states.Length; i++)
            {
                if (state == states[i])
                {
                    statePictures[i].Visible = true;
                    continue;
                }
                statePictures[i].Visible = false;
            }
        }
    }
}
