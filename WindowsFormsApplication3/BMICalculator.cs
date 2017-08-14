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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(HeightTextBox.Text)) || (string.IsNullOrEmpty(WeightTextBox.Text)) || (ImperialRadioButton.Checked == false && MetricRadioButton.Checked == false))
                {
                    throw new Exception("Please enter the values!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            Height = double.Parse(HeightTextBox.Text);
            Weight = double.Parse(WeightTextBox.Text);
            if (ImperialRadioButton.Checked)
            {
                BMIValue = (Weight * 703) / (Height * Height);
                BMIResultTextBox.Text = string.Format("{0:f2}", BMIValue);
                SetBMIScale(BMIValue);
            }
            else if (MetricRadioButton.Checked)
            {
                BMIValue = Weight / (Height * Height);
                BMIResultTextBox.Text = string.Format("{0:f2}", BMIValue);
                SetBMIScale(BMIValue);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(HeightTextBox.Text)) || (string.IsNullOrEmpty(WeightTextBox.Text)) || (ImperialRadioButton.Checked == false && MetricRadioButton.Checked == false))
                {
                    throw new Exception("Please enter the values!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            Height = double.Parse(HeightTextBox.Text);
            Weight = double.Parse(WeightTextBox.Text);
            if (ImperialRadioButton.Checked)
            {
                BMIValue = (Weight * 703) / (Height * Height);
                BMIResultTextBox.Text = string.Format("{0:f2}", BMIValue);
                SetBMIScale(BMIValue);
            }
            else if (MetricRadioButton.Checked)
            {
                BMIValue = Weight / (Height * Height);
                BMIResultTextBox.Text = string.Format("{0:f2}", BMIValue);
                SetBMIScale(BMIValue);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightLabel.Text = "My Height(Inches) :";
            WeightLabel.Text = "My Weight(Pounds) :";
        }

        private void MyWeightLabel_Click(object sender, EventArgs e)
        {
            
            }

        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightLabel.Text = "My Height(Meters) :";
            WeightLabel.Text = "My Weight(Kg) :";
        }

        private void MyHeight_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp = 0.0f;
            try
            {
                if ("".Equals(MyHeight_TextBox_TextChanged))
                {
                    temp = 99.0f;
                }
                else
                {
                    temp = double.Parse(MyHeight_TextBox_TextChanged);
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
                    throw new Exception("Input string was not in correct format!");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(MessageBox.Show(exception.Message));
                MyHeight_TextBox_TextChanged.Clear();
            }
        }

        private void MyWeight_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp = 0.0f;
            try
            {
                if ("".Equals(WeightTextBox.Text))
                {
                    temp = 99.0f;
                }
                else
                {
                    temp = double.Parse(WeightTextBox.Text);
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
                    throw new Exception("Input string was not in correct format!");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(MessageBox.Show(exception.Message));
                WeightTextBox.Clear();
            }
        }
    }
}
