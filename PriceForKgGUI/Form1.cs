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
        public Form1()
        {
            InitializeComponent();
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
                LblResult.Text =Convert.ToString(Math.Round(result,2));
            }
            else
            {
                MessageBox.Show("Enter valid numbers", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
