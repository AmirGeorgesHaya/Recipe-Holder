using Recipes_Library.RecipeDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Recipes_Library
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();

        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipeDataSet.RecipeSteps' table. You can move, or remove it, as needed.
            this.recipeStepsTableAdapter.Fill(this.recipeDataSet.RecipeSteps);
            // TODO: This line of code loads data into the 'recipeDataSet.Ingredient' table. You can move, or remove it, as needed.
            this.ingredientTableAdapter.Fill(this.recipeDataSet.Ingredient);
            // TODO: This line of code loads data into the 'recipeDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.recipeDataSet.Recipes);
            

        }

        private void optionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if a recipe is selected

            if (optionsListBox.SelectedValue != null)
            {
                // Get the selected recipe ID from the ListBox

                int selectedRecipeId = (int)optionsListBox.SelectedValue;

                // Clear previous ingredients and steps from the TextBoxes
                ingredientTextBox.Clear(); // Clear previous ingredients
                stepsTextBox.Clear();

                // Fetch and display ingredients for the selected recipe
                using (var adapter = new RecipeDataSetTableAdapters.RecipeIngredientsTableAdapter())
                {
                    // Create an instance of RecipeIngredientsDataTable
                    var riDataTable = new RecipeDataSet.RecipeIngredientsDataTable();

                    // Pass both the DataTable and RecipeID to the GetIngredients method
                    adapter.GetIngredients(riDataTable, selectedRecipeId);

                    // Iterate through the rows in the resulting DataTable
                    foreach (var row in riDataTable)
                    {
                        // Build the ingredient details string

                        string ingredientDetails = $"{row["IngredientName"]} - {row["Quantity"]} {row["Unit"]}{Environment.NewLine}";
                        ingredientTextBox.AppendText(ingredientDetails);
                    }
                }
                // Fetch and display steps for the selected recipe
                using (var stepAdapter = new RecipeDataSetTableAdapters.RecipeStepsTableAdapter())
                {

                    // Create an instance of RecipeStepsDataTable
                    var rsDataTable = new RecipeDataSet.RecipeStepsDataTable();
                    stepAdapter.GetStepsByRecipeID(rsDataTable, selectedRecipeId);

                    // Iterate through the rows in the resulting DataTable

                    foreach (var row in rsDataTable)
                    {
                        string stepDetails = $"Step {row.StepNumber}: {row.StepInfo}{Environment.NewLine}";
                        // Append the step details to the TextBox

                        stepsTextBox.AppendText(stepDetails);
                    }
                }

            }
        }

       

       
    }
    
}









