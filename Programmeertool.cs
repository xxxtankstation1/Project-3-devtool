using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_programmeertool
{
    public partial class frmLoopgenerator : Form
    {
        public frmLoopgenerator()
        {
            InitializeComponent();
        }

        private void btnAdvies_Click(object sender, EventArgs e)
        {
            try
            {
               // Reset textbox
                txtOutput.Text = "";
                // Modifiers 
                String compare = "";
                String incrementOperator = "";
                // Error indicator variable
                bool error = false;

                // error message if there is no input
                if (String.IsNullOrEmpty(txtStart.Text) || String.IsNullOrEmpty(txtEnd.Text))
                {
                    MessageBox.Show("Enter a starting and end value.");
                    error = true;
                }

                // Sets variable compare to the right value based on input from the radiobuttons
                if (rdbGreater.Checked)
                {
                    compare = ">";
                }

                if (rdbGreaterEqual.Checked)
                {
                    compare = ">=";
                }

                if (rdbSmaller.Checked)
                {
                    compare = "<";
                }

                if (rdbSmallerEqual.Checked)
                {
                    compare = "<=";
                }
                // Error message if none of the radiobuttons for comparison are checked
                if (String.IsNullOrEmpty(compare))
                {
                    MessageBox.Show("Choose one of the options within 3.");
                    error = true;
                }
                
                // Sets incrementOperator to the right value according to the input from 4
                if (rdbPlus.Checked && txtIncrement.Text == "1")
                {
                    incrementOperator = "++";
                }

                if (rdbPlus.Checked && txtIncrement.Text != "1")
                {
                    incrementOperator = $"+={txtIncrement.Text}";
                }

                if (rdbMin.Checked && txtIncrement.Text == "1")
                {
                    incrementOperator = "--";
                }

                if (rdbMin.Checked && txtIncrement.Text != "1")
                {
                    incrementOperator = $"-={txtIncrement.Text}";
                }

                // Error message if none of the radiobuttons in 4 are checked
                if (!rdbMin.Checked && !rdbPlus.Checked)
                {
                    MessageBox.Show("Choose one of the options within 4.");
                }

                // Error message if the starting value is larger then or equal to the end value with the plus operator selected
                if ((double.Parse(txtStart.Text) > double.Parse(txtEnd.Text) || double.Parse(txtStart.Text) == double.Parse(txtEnd.Text)) && rdbPlus.Checked)
                {
                    MessageBox.Show("The starting value cannot be larger then or equal to the end value when using the plus operator.");
                    error = true;
                }

                // Error message if the starting value is larger then or equal to the end value with the plus operator selected
                if ((double.Parse(txtEnd.Text) > double.Parse(txtStart.Text) || double.Parse(txtStart.Text) == double.Parse(txtEnd.Text)) && rdbMin.Checked)
                {
                    MessageBox.Show("The end value cannot be smaller then or equal to the starting value when using the minus operator.");
                    error = true;
                }

                // Creates a for loop using the user input and sets the txtOutput equal to that value
                if (rdbFor.Checked && error == false)
                {
                    txtOutput.Text = ($"for (int i = {txtStart.Text}; i {compare} {txtEnd.Text}; i{incrementOperator})\r\n{{\r\n}}");
                }

                // Creates a while loop using the user input and sets the txtOutput equal to that value
                if (rdbWhile.Checked && error == false)
                {
                    txtOutput.Text = ($"int i = {txtStart.Text};\r\nwhile (i {compare} {txtEnd.Text})\r\n{{\r\ni{incrementOperator};\r\n}}");
                }
            }
            catch // Failsafe error if none of the code above worked
            {
                MessageBox.Show("Er is een fout opgetreden.");
            }
        }

        private void txtIncrement_TextChanged(object sender, EventArgs e)
        {

        }
    }
}