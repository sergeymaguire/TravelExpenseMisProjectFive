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
    public partial class mainMISform : Form
    {
        public mainMISform()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioBtnCity_CheckedChanged(object sender, EventArgs e)
        {
            setTotalMiles(radioBtnBuick.Checked, true);
        }

        private void setTotalMiles(Boolean isBuick, Boolean isCity)
        {
            if (isCity)
            {
                if (isBuick)
                {
                    lblMpg.Text = "15.5";
                    lblTotalMiles.Text = "21";
                }
                else
                {
                    lblMpg.Text = "19.8";
                    lblTotalMiles.Text = "21";
                }

            }
            else
            {
                if (isBuick)
                {
                    lblMpg.Text = "23.7";
                    lblTotalMiles.Text = "33";
                }
                else
                {
                    lblMpg.Text = "29.3";
                    lblTotalMiles.Text = "33";
                }
            }
        }

        private void radioBtnFreeway_CheckedChanged(object sender, EventArgs e)
        {
            setTotalMiles(radioBtnBuick.Checked, false);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (textBoxGasPrice.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Please enter gas price");
            }
            else
                lblTotalCost.Text = calcTotalCost(lblMpg.Text, lblTotalMiles.Text, textBoxGasPrice.Text);

        }

        private string calcTotalCost(string mpg, string totalMiles, string gasPrice)
        {
             decimal totalMilesDriven = Decimal.Parse(totalMiles.ToString());
             decimal totalMpg = Decimal.Parse(mpg.ToString());
             decimal gasPrices = Decimal.Parse(gasPrice.ToString());
             var totalCost = totalMilesDriven / totalMpg * gasPrices;

             return totalCost.ToString("C2");
        }
        private void radioBtnBuick_CheckedChanged(object sender, EventArgs e)
        {
            setTotalMiles(true, radioBtnCity.Checked);
        }

        private void radioBtnChevy_CheckedChanged(object sender, EventArgs e)
        {
            setTotalMiles(false, radioBtnFreeway.Checked);
        }
    }
}


//1. The Buick gets 23.7 miles per gallon on the freeway and 15.5 miles per gallon in the city.
//2. The Chevy gets 29.3 miles per gallon on the freeway and 19.8 miles per gallon in the city.
//3. Freeway distance is 33 miles.
//4. City driving distance is 21 miles.