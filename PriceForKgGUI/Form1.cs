using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceForKgGUI
{
    public partial class Form1 : Form
    {
        double price, amount,result,amountMultiplyer;
        double price2, amount2, result2, amountMultiplyer2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            price2 = Convert.ToDouble(TxtPrice2.Text);
            amount2 = Convert.ToDouble(TxtAmount2.Text);
            if (price2 > 0 && amount2 > 0)
            {
                if (BtnGram2.Checked)
                {
                    amountMultiplyer2 = 1000 / amount2;
                    result2 = amountMultiplyer2 * price2;
                }
                else if (BtnKilo2.Checked)
                {
                    amountMultiplyer2 = amount2;
                    result2 = amountMultiplyer2 * price2;
                }
                else
                {
                    MessageBox.Show("Please select measurment unit", "Error", MessageBoxButtons.OK);
                }
                LblResult2.Text = result2.ToString("0.00 lv");
            }
            else
            {
                MessageBox.Show("Enter valid numbers", "Error", MessageBoxButtons.OK);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblResult_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            price = Convert.ToDouble(TxtPrice.Text);
            amount = Convert.ToDouble(TxtAmount.Text);
            if (price > 0 && amount > 0)
            {
                if (BtnGram.Checked)
                {
                    amountMultiplyer = 1000 / amount;
                    result = amountMultiplyer * price;
                }
                else if (BtnKilo.Checked)
                {
                    amountMultiplyer = amount;
                    result = amountMultiplyer * price;
                }
                else
                {
                    MessageBox.Show("Please select measurment unit","Error",MessageBoxButtons.OK);
                }
                LblResult.Text = result.ToString("0.00 lv");
            }
            else
            {
                MessageBox.Show("Enter valid numbers", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
