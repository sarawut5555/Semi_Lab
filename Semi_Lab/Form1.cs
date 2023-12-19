using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Semi_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ohter_TextChanged(object sender, EventArgs e)
        {
            total.Text = (Convert.ToDouble(salary.Text) * 12 + Convert.ToDouble(bonus.Text) + Convert.ToDouble(ohtersalary.Text)).ToString();
            textBox16.Text = total.Text;
            textBox17.Text = 100000.ToString();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            double total = 0;

            System.Windows.Forms.TextBox[] textBoxes = { textBox3, textBox4, textBox15, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14  };

            foreach (System.Windows.Forms.TextBox textBox in textBoxes)
            {
                if (double.TryParse(textBox.Text, out double value))
                {
                    total += value;
                }
            }

            total2.Text = total.ToString();
            textBox18.Text = total2.Text;
            textBox19.Text = (Convert.ToDouble(textBox16.Text) - Convert.ToDouble(textBox17.Text) - Convert.ToDouble(textBox18.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double netIncome = 0;
            double tax = 0;

            if (double.TryParse(textBox19.Text, out netIncome))
            {
                if (netIncome <= 150000)
                {
                    tax = 0;
                }
                else if (netIncome <= 300000)
                {
                    tax = (netIncome * 5) / 100;
                }
                else if (netIncome <= 500000)
                {
                    tax = (netIncome * 10) / 100;
                }
                else if (netIncome <= 750000)
                {
                    tax = (netIncome * 15) / 100;
                }
                else if (netIncome <= 1000000)
                {
                    tax = (netIncome * 20) / 100;
                }
                else if (netIncome <= 2000000)
                {
                    tax = (netIncome * 25) / 100;
                }
                else if (netIncome <= 5000000)
                {
                    tax = (netIncome * 30) / 100;
                }
                else
                {
                    tax = (netIncome * 35) / 100;
                }

                Tax.Text = tax.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox5.Text, out int children))
            {
                int calculatedValue = children * 30000;
                textBox15.Text= calculatedValue.ToString(); 
            }
            else
            {
                textBox15.Text = string.Empty;
            }
        }
    }
}
