using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Priscylla Flisch 
 * 300931589
 * Aug 8th, 2017
 * Interface for BMI Calculator
 * Github link: https://github.com/pflisch/COMP123---BMI-Calculator
 */

namespace Assignment5
{
    public partial class BMICalculator : Form
    {
        //PRIVATE INSTANCE VARIABLES
        private double _weight;
        private double _height;
        private double _bmiValue;

        //PUBLIC PROPERTIES
        public double Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }

        public double Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        public double BMIValue
        {
            get
            {
                return this._bmiValue;
            }
            set
            {
                this._bmiValue = value;
            }
        }


        public BMICalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

            private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnImperial_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight.Text = "My Height(Inches): ";
            lblWeight.Text = "My Weight(Pounds): ";
        }

        private void btnMetric_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight.Text = "My Height(Meters): ";
            lblWeight.Text = "My Weight(Kg): ";
        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void txtHeigh_TextChanged(object sender, EventArgs e)
        {
            double temp = 0.0f;
            try
            {
                if ("".Equals(txtHeigh.Text))
                {
                    temp = 99.0f;
                }
                else
                {
                    temp = double.Parse(txtHeigh.Text);
                }
            }
            catch (Exception exception)
            {
                temp = -1.0f;
            }

            try
            {
                if (temp < 0)
                {
                    throw new Exception("Information wasn't inserted in the right format");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(MessageBox.Show(exception.Message));
                txtHeigh.Clear();
            }
        }

        private void lblWeight_Click(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            double temp = 0.0f;
            try
            {
                if ("".Equals(txtWeight.Text))
                {
                    temp = 99.0f;
                }
                else
                {
                    temp = double.Parse(txtWeight.Text);
                }
            }
            catch (Exception exception)
            {
                temp = -1.0f;
            }

            try
            {
                if (temp < 0)
                {
                    throw new Exception("Information wasn't inserted in the right format");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(MessageBox.Show(exception.Message));
                txtWeight.Clear();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtHeigh.Text)) || (string.IsNullOrEmpty(txtWeight.Text)) || (ImperialRadioButton.Checked == false && MetricRadioButton.Checked == false))
                {
                    throw new Exception("Enter the correct values, please.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            Height = double.Parse(txtHeigh.Text);
            Weight = double.Parse(txtWeight.Text);
            if (btnImperial.Checked)
            {
                BMIValue = (Weight * 703) / (Height * Height);
                txtCalculate.Text = string.Format("{0:f2}", BMIValue);
                SetBMIScale(BMIValue);
            }
            else if (btnMetric.Checked)
            {
                BMIValue = Weight / (Height * Height);
                txtCalculate.Text = string.Format("{0:f2}", BMIValue);
                SetBMIScale(BMIValue);
            }
        }

        private void txtCalculate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
