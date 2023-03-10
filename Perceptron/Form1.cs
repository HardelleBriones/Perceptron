using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class PerceptronForm : Form
    {
        Perceptron p = new Perceptron(2);
        double epoch = 0.00;
        Boolean x1 = true;
        Boolean x2 = true;
        public PerceptronForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            int input1;
            int input2;
            if (button2.BackColor == Color.White)
            {
                input1 = 1;
            }
            else
            {
                input1 = -1;
            }

            if (button3.BackColor == Color.White)
            {
                input2 = 1;
            }
            else
            {
                input2 = -1;
            }


            label2.Text = p.Activate(new double[] { input1,input2 })+"";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEpoch_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (x1 == true)
            {
                button2.BackColor = Color.Black;
                x1 = false;
            }
            else 
            {
                button2.BackColor = Color.White;
                x1 = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (x2 == true)
            {
                button3.BackColor = Color.Black;
                x2 = false;
            }
            else
            {
                button3.BackColor = Color.White;
                x2= true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double[][] inputs = { new double[] { -1, -1 }, new double[] { -1, 1 }, new double[] { 1, -1 }, new double[] { 1, 1 } };
            int[] targets = { -1, 1, 1, 1 };
            double totalEpoch = Convert.ToDouble(textBoxEpoch.Text) + epoch;
            label4.Text = totalEpoch+"";
             epoch += Convert.ToDouble(textBoxEpoch.Text);
            p.Train(inputs, targets, epoch);
           
        }
    }
}
