using System;
using System.Windows.Forms;
using BMICalculatorLib;
using BMIUtilityLib;

namespace BMICalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtWeight_Enter(object sender, EventArgs e)
        {
            lblWeightPlaceholder.Visible = false;
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            lblWeightPlaceholder.Visible = string.IsNullOrEmpty(txtWeight.Text);
        }

        private void txtHeight_Enter(object sender, EventArgs e)
        {
            lblHeightPlaceholder.Visible = false;
        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            lblHeightPlaceholder.Visible = string.IsNullOrEmpty(txtHeight.Text);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtWeight.Text, out double weight) &&
                double.TryParse(txtHeight.Text, out double height))
            {
                var calculator = new BMICalculator();
                try
                {
                    double bmi = calculator.CalculateBMI(weight, height);
                    var utility = new UtilityFunctions();
                    string formattedResult = utility.FormatBMIResult(bmi);
                    string healthTip = utility.GetHealthTip(bmi);
                    lblResult.Text = $"{formattedResult}\n{healthTip}";
                }
                catch (ArgumentException ex)
                {
                    lblResult.Text = ex.Message;
                }
            }
            else
            {
                lblResult.Text = "Invalid input!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWeightPlaceholder.Visible = string.IsNullOrEmpty(txtWeight.Text);
            lblHeightPlaceholder.Visible = string.IsNullOrEmpty(txtHeight.Text);
        }
    }
}