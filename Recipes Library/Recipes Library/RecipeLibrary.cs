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
    public partial class RecipeLibraryForm : Form
    {
        public RecipeLibraryForm()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CreationForm creationForm = new CreationForm();
            creationForm.ShowDialog();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            ModifyForm modifyForm = new ModifyForm();
            modifyForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    changeLanguage.UpdateConfig("language", "en-CA");
                    Application.Restart();
                    break;
                    case 1:

                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;

                    case 2:
                    changeLanguage.UpdateConfig("language", "es-US");
                    Application.Restart();
                    break;
            }
        }

        private void RecipeLibraryForm_Load(object sender, EventArgs e)
        {
        }
    }
}
