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
            HeightLabel.Text = "My Height(Inches) :";
            WeightLabel.Text = "My Weight(Pounds) :";
        }

        private void btnMetric_CheckedChanged(object sender, EventArgs e)
        {
            HeightLabel.Text = "My Height(Meters) :";
            WeightLabel.Text = "My Weight(Kg) :";
        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void txtHeigh_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWeight_Click(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void txtCalculate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
