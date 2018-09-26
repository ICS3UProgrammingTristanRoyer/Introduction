/*
 * Created by: Tristan Royer
 * Created on: 26-09-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #5 - Hello International
 * This program displays  hello "my name" in different languages.
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

namespace HelloInternationalTristanR
{
    public partial class HelloInternationalForm : Form
    {
        public HelloInternationalForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            // Changes Language
            this.lblHelloWorld.Text = "Ciao , Tristan Royer";

            this.radEnglish.Text = "Inglese";
            this.radSpanish.Text = "spagnolo";
            this.radItalian.Text = "italiano";
            this.radFrench.Text = "francese";


        }

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            
            // Changes the language
            this.lblHelloWorld.Text = "Hello , Tristan Royer";

            this.radEnglish.Text = "English";
            this.radSpanish.Text = "Spanish";
            this.radItalian.Text = "Italian";
            this.radFrench.Text = "French";

        }

        private void radFrench_CheckedChanged(object sender, EventArgs e)
        {
            // Changes Language
            this.lblHelloWorld.Text = "Bonjour , Tristan Royer";
            this.radEnglish.Text = "Inglés";
            this.radSpanish.Text = "Espanol";
            this.radItalian.Text = "Inglese";
            this.radFrench.Text = "Français";



        }

        private void radSpanish_CheckedChanged(object sender, EventArgs e)
        {
            // Changes Language
            this.lblHelloWorld.Text = "Hola , Tristan Royer";
            this.radEnglish.Text = "Anglais";
            this.radSpanish.Text = "Español";
            this.radItalian.Text = "italiano";
            this.radFrench.Text = " francés";


        }
        // Changes Language
        private void grbLanguages_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Closes program
            this.Close();
        }
    }
}
