using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_learnin
{
    public partial class Form1 : Form
    {
        int CountNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CountNumber = 3;

            double CountTotal = 100;

            CountTotal = CountTotal - CountNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myValue = 1000;
            int myNewValue = 100000;

            for(int i = 0; i<10; i++) { 
                bool validation = myValue < myNewValue;
                if (validation)
                {
                    myValue += myValue * myNewValue;
                }
            }
     
            MessageBox.Show("Suceess: " + myValue);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi! Are you ok? " + Math.Sqrt(4));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int AgeErick = 27;
            int AgeRay = 23;
            int AgeEmanuel = 12;

            // Sum age values
            int AgeTotal = AgeErick + AgeRay + AgeEmanuel;

            /* 
             Show the result count value
             */
            MessageBox.Show("The value is: " + (double)AgeTotal / (double)CountNumber);
        }
    }
}
