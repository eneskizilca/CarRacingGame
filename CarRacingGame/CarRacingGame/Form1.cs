using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int carSpeed1;
        int carSpeed2;
        int carSpeed3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            car1.Left = 45;
            car2.Left = 45;
            car3.Left = 45;
            timer.Start();
        }

        private void Timer(object sender, EventArgs e)
        {
            carSpeed1 = random.Next(5, 20);
            carSpeed2 = random.Next(5, 20);
            carSpeed3 = random.Next(5, 20);

            car1.Left += carSpeed1;
            car2.Left += carSpeed2;
            car3.Left += carSpeed3;

            if(car1.Right >= finish.Left || car2.Right >= finish.Left || car3.Right >= finish.Left)
            {
                timer.Stop();
            }

            if (car1.Right >= finish.Left)
            {
                MessageBox.Show("Car 1 Win!");
            }
            if (car2.Right >= finish.Left)
            {
                MessageBox.Show("Car 2 Win!");
            }
            if (car3.Right >= finish.Left)
            {
                MessageBox.Show("Car 3 Win!");
            }
        }
    }
}
