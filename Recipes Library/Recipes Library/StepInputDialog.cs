using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes_Library
{
    public partial class StepInputDialog : Form
    {
        public string StepDescription { get; private set; }

        public StepInputDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Trim any whitespace from the text entered in the step description text box
            StepDescription = stepDescriptionTextBox.Text.Trim();
            // Check if the step description is not empty
            if (!string.IsNullOrEmpty(StepDescription))
            {
                // Set the dialog result to OK to indicate success
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {        // Show an error message if the step description is empty

                MessageBox.Show("Please enter a step description.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {    
            // Set the dialog result to Cancel to indicate cancellation

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
