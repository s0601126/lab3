using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double balance = Convert.ToInt32 (txtAmount.Text);
            double millionBalance = 1000000;
            double rate100 =Convert.ToInt32 (txtRate.Text);
            double rate = rate100 / 100;

            // Calculate the value after 10 years
            double valueAfter10Years = balance * Math.Pow((1+rate), 10);

            // Calculate the number of years to reach $1,000,000
            int yearsToReachMillion = 0;
            while (balance < millionBalance)
            {
                balance *= (1 + rate);
                yearsToReachMillion++;
            }

            // Display the results
            lblValue2.Text = valueAfter10Years.ToString();
            lblMillion2.Text = yearsToReachMillion.ToString();
        }
    }
}
