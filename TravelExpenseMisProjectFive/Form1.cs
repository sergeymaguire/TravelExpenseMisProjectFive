using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpenseMisProjectFive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioBtnCity_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtnBuick.Checked)
            {
                lblMpg.Text = "15.5";
            }
        }
    }
}


//1. The Buick gets 23.7 miles per gallon on the freeway and 15.5 miles per gallon in the city.
//2. The Chevy gets 29.3 miles per gallon on the freeway and 19.8 miles per gallon in the city.
//3. Freeway distance is 33 miles.
//4. City driving distance is 21 miles.