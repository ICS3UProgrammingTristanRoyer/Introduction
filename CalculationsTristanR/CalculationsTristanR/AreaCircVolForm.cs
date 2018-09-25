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
            lblArea.Text = Convert.ToString(Math.PI * Math.Pow(10, 2));
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            lblVolume.Text = Convert.ToString((double)4 / (double)3 * Math.PI * Math.Pow(10, 3));

        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            lblPer.Text = Convert.ToString(2 * (10 * 9));

        }
    }
}
