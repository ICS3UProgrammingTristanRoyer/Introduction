/*
 * Created by: Tristan Royer
 * Created on: 17-09-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - AreaCircVol
 * This program calculates the area , circumference and volume of different shapes
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationsTristanR
{
    public partial class AreaCircVolForm : Form
    {
        public AreaCircVolForm()
        {
            InitializeComponent();
        }

     

        private void btnArea_Click(object sender, EventArgs e)
        {
			double area;
			// Converts the area into a string so it can be displayed
			area = (Math.PI * Math.Pow(10, 2)) ;
			area = Math.Round(area , 2, MidpointRounding.AwayFromZero);
			lblArea.Text = Convert.ToString(area) + " cm^2";

        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
			double volume;
			// Converts the Volume into a string so it can be displayed
			volume = ((double)4 / (double)3 * Math.PI * Math.Pow(10, 3));
			volume = Math.Round(volume , 2, MidpointRounding.AwayFromZero);
			lblVolume.Text = Convert.ToString(volume) + " cm^3" ;
			

		}

		private void btnPer_Click(object sender, EventArgs e)
        {
			double perimeter;
			// Converts the Perimeter into a string so it can be displayed
			perimeter = (2 * (10 * 9));
			perimeter = Math.Round(perimeter, 2, MidpointRounding.AwayFromZero);
			lblPer.Text = Convert.ToString(perimeter) + " cm";

        }
    }
}
