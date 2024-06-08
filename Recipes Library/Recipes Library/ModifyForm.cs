using Recipes_Library.RecipeDataSetTableAdapters;
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
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipeDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.recipeDataSet.Recipes);
            dataGridViewSteps.CellValueChanged += dataGridViewSteps_CellValueChanged;
            dataGridViewIngredients.CellValueChanged += dataGridViewIngredients_CellValueChanged;

            InitializeDataGridViewSteps();
            InitializeDataGridViewIngredients();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (optionsListBox.SelectedIndex != -1)
            {
                int recipeId = (int)optionsListBox.SelectedValue;

                // Delete steps
                var stepAdapter = new RecipeStepsTableAdapter();
                stepAdapter.DeleteStepsByRecipeID(recipeId);

                // Delete ingredients from RecipeIngredients table (not from Ingredient table)
                var ingredientAdapter = new RecipeIngredientsTableAdapter();
                ingredientAdapter.DeleteIngredientsByRecipeID(recipeId);

                // Delete recipe
                var recipeAdapter = new RecipesTableAdapter();
                recipeAdapter.DeleteRecipeByID(recipeId);

                // Refresh the ListBox and clear DataGridViews
                this.recipesTableAdapter.Fill(this.recipeDataSet.Recipes);
                optionsListBox.DataSource = recipeDataSet.Recipes;
                dataGridViewSteps.DataSource = null;
                dataGridViewIngredients.DataSource = null;
            }
        }

        // ListBox selected index changed event handler

        private void optionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optionsListBox.SelectedIndex != -1)
            {
                // Get the selected recipe ID from the ListBox

                int selectedRecipeId = (int)optionsListBox.SelectedValue;

                // Create an instance of the RecipeStepsTableAdapter to interact with the RecipeSteps table

                var stepAdapter = new RecipeStepsTableAdapter();
                // Create an empty DataTable to hold the steps of the selected recipe
                var rsDataTable = new RecipeDataSet.RecipeStepsDataTable();
                // Fill the DataTable with steps of the selected recipe using the TableAdapter
                stepAdapter.GetStepsByRecipeID(rsDataTable, selectedRecipeId);

                // Debug: Output fetched rows to console
                foreach (DataRow row in rsDataTable.Rows)
                {
                    Console.WriteLine($"StepNumber: {row["StepNumber"]}, StepInfo: {row["StepInfo"]}");
                }

                // Bind the DataGridView for steps to the populated DataTable
                dataGridViewSteps.DataSource = rsDataTable;

                // Create an instance of the RecipeIngredientsTableAdapter to interact with the RecipeIngredients table
                var ingredientAdapter = new RecipeIngredientsTableAdapter();
                // Create an empty DataTable to hold the ingredients of the selected recipe

                var riDataTable = new RecipeDataSet.RecipeIngredientsDataTable();
                // Fill the DataTable with ingredients of the selected recipe using the TableAdapter
                ingredientAdapter.GetIngredientsWithNamesByRecipeID(riDataTable, selectedRecipeId);

                // Debug: Output fetched rows to console
                foreach (DataRow row in riDataTable.Rows)
                {
                    Console.WriteLine($"IngredientName: {row["IngredientName"]}, Quantity: {row["Quantity"]}, Unit: {row["Unit"]}");
                }

                // Ensure columns are set correctly

                // Bind the DataGridView for ingredients to the populated DataTable
                dataGridViewIngredients.DataSource = riDataTable;
            }
        }
        private void InitializeDataGridViewSteps()
        {
            // Disable auto-generation of columns to manually define the columns
            dataGridViewSteps.AutoGenerateColumns = false;
            // Clear any existing columns
            dataGridViewSteps.Columns.Clear();

            // Add a new column for step number

            dataGridViewSteps.Columns.Add(new DataGridViewTextBoxColumn
            {
                // Bind this column to the "stepNumber" property in the data source
                DataPropertyName = "stepNumber",

                // Set the header text displayed for this column
                HeaderText = "Step #",

                // Set the name of the column for reference in code
                Name = "stepNumber",

                Width=50 
            });

            dataGridViewSteps.Columns.Add(new DataGridViewTextBoxColumn
            {
                // Bind this column to the "stepInfo" property in the data source
                DataPropertyName = "stepInfo",
                // Set the header text displayed for this column
                HeaderText = "Step Description",

                // Set the name of the column for reference in code
                Name = "stepInfo",
                Width = 300
            }); ;
        }

        private void InitializeDataGridViewIngredients()
        {
            dataGridViewIngredients.AutoGenerateColumns = false;
            dataGridViewIngredients.Columns.Clear();

            dataGridViewIngredients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ingredientName",
                HeaderText = "Ingredient Name",
                  Name = "ingredientName"
            }) ;

            dataGridViewIngredients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "quantity",
                HeaderText = "Quantity",
                Name = "quantity",
                Width=60
            });

            dataGridViewIngredients.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "unit",
                HeaderText = "Unit",
                Name = "unit"
            });
        }
        private void dataGridViewSteps_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected recipe ID from the ListBox
                int recipeId = (int)optionsListBox.SelectedValue;
                // Get the step number from the changed row
                int stepNumber = (int)dataGridViewSteps.Rows[e.RowIndex].Cells["stepNumber"].Value;

                // Get the updated step description from the changed row
                string stepInfo = dataGridViewSteps.Rows[e.RowIndex].Cells["stepInfo"].Value.ToString();

                // Create an instance of the RecipeStepsTableAdapter to interact with the RecipeSteps table
                var stepAdapter = new RecipeStepsTableAdapter();
                // Update the step information in the database
                stepAdapter.UpdateStepInfo(stepInfo, recipeId, stepNumber);

                // Create an empty DataTable to hold the updated steps of the selected recipe
                var rsDataTable = new RecipeDataSet.RecipeStepsDataTable();
                // Fill the DataTable with the updated steps of the selected recipe using the TableAdapter
                stepAdapter.GetStepsByRecipeID(rsDataTable, recipeId);
                // Bind the DataGridView for steps to the updated DataTable
                dataGridViewSteps.DataSource = rsDataTable;
            }
        }

        private void dataGridViewIngredients_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed cell is valid

            if (e.RowIndex >= 0)
            {
                // Get the selected recipe ID from the ListBox
                int recipeId = (int)optionsListBox.SelectedValue;
                // Get the updated ingredient name from the changed row
                string ingredientName = dataGridViewIngredients.Rows[e.RowIndex].Cells["ingredientName"].Value.ToString();
                // Get the updated quantity from the changed row
                string quantity = dataGridViewIngredients.Rows[e.RowIndex].Cells["quantity"].Value.ToString();

                // Get the updated unit from the changed row
                string unit = dataGridViewIngredients.Rows[e.RowIndex].Cells["unit"].Value.ToString();

                // Create instances of the TableAdapters to interact with the Ingredient and RecipeIngredients table
                var ingredientAdapter = new RecipeDataSetTableAdapters.IngredientTableAdapter();
                var recipeIngredientsAdapter = new RecipeDataSetTableAdapters.RecipeIngredientsTableAdapter();

                // Ensure ingredient exists or create it
                int ingredientId = EnsureIngredient(ingredientName, ingredientAdapter);

                // Update the RecipeIngredients table
                recipeIngredientsAdapter.UpdateIngredient(quantity, unit, recipeId, ingredientId);

                // Refresh the DataGridView by fetching the updated ingredients data
                var riDataTable = new RecipeDataSet.RecipeIngredientsDataTable();
                recipeIngredientsAdapter.GetIngredientsWithNamesByRecipeID(riDataTable, recipeId);
                dataGridViewIngredients.DataSource = riDataTable;
            }
        }
        /*
        private void modifyButton_Click(object sender, EventArgs e)
        {
            var ingredientAdapter = new RecipeDataSetTableAdapters.IngredientTableAdapter();
            var recipeIngredientsAdapter = new RecipeDataSetTableAdapters.RecipeIngredientsTableAdapter();

            // Steps DataGridView
            foreach (DataGridViewRow row in dataGridViewSteps.Rows)
            {
                if (row.IsNewRow) continue;

                int recipeId = (int)optionsListBox.SelectedValue;
                int stepNumber = (int)row.Cells["stepNumber"].Value; // Use correct column name
                string stepInfo = row.Cells["stepInfo"].Value.ToString(); // Use correct column name

                var stepAdapter = new RecipeStepsTableAdapter();
                stepAdapter.UpdateStepInfo(stepInfo, recipeId, stepNumber);
            }

            // Ingredients DataGridView
            foreach (DataGridViewRow row in dataGridViewIngredients.Rows)
            {
                if (row.IsNewRow) continue;

                int recipeId = (int)optionsListBox.SelectedValue;
                string ingredientName = row.Cells["ingredientName"].Value.ToString(); // Use correct column name
                string quantity = row.Cells["quantity"].Value.ToString(); // Use correct column name
                string unit = row.Cells["unit"].Value.ToString(); // Use correct column name

                // Ensure ingredient exists or create it
                int ingredientId = EnsureIngredient(ingredientName, ingredientAdapter);

                // Update the RecipeIngredients table
                recipeIngredientsAdapter.UpdateIngredient(quantity, unit, recipeId, ingredientId);
            }

            // Refresh data
            optionsListBox_SelectedIndexChanged(null, null);
        }
        */
        private int EnsureIngredient(string ingredientName, RecipeDataSetTableAdapters.IngredientTableAdapter ingredientAdapter)
        {
            // Check if the ingredient exists and get its ID
            // Try to get the ID of the ingredient by its name
            //int? is a nullable integer (the more you know)
            int? ingredientId = ingredientAdapter.GetIngredientIDByName(ingredientName);
            // If the ingredient exists, return its ID
            if (ingredientId.HasValue)
            {
                return ingredientId.Value;
            }
            else
            {
                // Ingredient does not exist, create a new one
                // Insert the new ingredient into the database
                ingredientAdapter.InsertIngredient(ingredientName);
                // Get the ID of the newly created ingredient and return it
                return (int)ingredientAdapter.GetIngredientIDByName(ingredientName);
            }
        }

        private void addStepButton_Click(object sender, EventArgs e)
        {
            // Create and show a dialog to input the step description
            /*This line creates a new instance of the StepInputDialog 
             * class and shows it to the user. The using statement ensures 
             * that the dialog is properly disposed of after it is used.
             */
            using (var stepDialog = new StepInputDialog())
            {
                
                // Check if the dialog result is OK (i.e., the user clicked OK)
                if (stepDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the step description entered by the user
                    string stepDescription = stepDialog.StepDescription;

                    // Get the selected recipe ID from the ListBox
                    int recipeId = (int)optionsListBox.SelectedValue;
                    // Create an instance of the RecipeStepsTableAdapter to interact with the RecipeSteps table
                    var stepAdapter = new RecipeDataSetTableAdapters.RecipeStepsTableAdapter();

                    // Get the maximum step number for the recipe and add 1 to it
                    var steps = new RecipeDataSet.RecipeStepsDataTable();
                    // Fill the DataTable with steps of the selected recipe using the TableAdapter
                    stepAdapter.GetStepsByRecipeID(steps, recipeId);

                    // Get the maximum step number for the recipe and add 1 to it
                    /*
                     * These lines calculate the new step number by finding the maximum step number in the existing
                     * steps and adding 1 to it. If there are no existing steps, the new step number is set to 1.
                     */
                    int maxStepNumber = steps.Any() ? steps.Max(s => s.StepNumber) : 0;
                    int newStepNumber = maxStepNumber + 1;

                    // Add the new step
                    stepAdapter.InsertStep(recipeId, newStepNumber, stepDescription);

                    // Refresh DataGridView
                    stepAdapter.GetStepsByRecipeID(steps, recipeId);
                    dataGridViewSteps.DataSource = steps;
                }
            }
        }

        private void deleteStepButton_Click(object sender, EventArgs e)
        {
            // Check if there are any selected rows in the steps DataGridView
            if (dataGridViewSteps.SelectedRows.Count > 0)
            {
                // Create an instance of the RecipeStepsTableAdapter to interact with the RecipeSteps table
                var stepAdapter = new RecipeStepsTableAdapter();

                // Get the selected recipe ID from the ListBox
                int recipeId = (int)optionsListBox.SelectedValue;

                // Loop through the selected rows in the steps DataGridView
                //This loop iterates over each selected row in the dataGridViewSteps.
                foreach (DataGridViewRow row in dataGridViewSteps.SelectedRows)
                {
                    // Get the step number from the selected row
                    int stepNumber = (int)row.Cells["stepNumber"].Value;
                    // Delete the step from the database using the step number and recipe ID
                    stepAdapter.DeleteStepByRecipeIDAndStepNumber(recipeId, stepNumber);
                }

                // Refresh DataGridView
                var rsDataTable = new RecipeDataSet.RecipeStepsDataTable();
                stepAdapter.GetStepsByRecipeID(rsDataTable, recipeId);
                dataGridViewSteps.DataSource = rsDataTable;
            }
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            // Show the dialog to input the ingredient name
            using (var ingredientDialog = new IngredientInputDialog())
            {
                // Check if the dialog result is OK (i.e., the user clicked OK)
                if (ingredientDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the ingredient name entered by the user
                    string newIngredientName = ingredientDialog.IngredientName;

                    // Show the dialog to input the unit
                    using (var unitDialog = new UnitInputDialog())
                    {
                        // Check if the dialog result is OK (i.e., the user clicked OK)
                        if (unitDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Get the unit entered by the user, or set to null if empty
                            string unit = string.IsNullOrEmpty(unitDialog.Unit) ? null : unitDialog.Unit;

                            // Get the selected recipe ID from the ListBox
                            int recipeId = (int)optionsListBox.SelectedValue;

                            // Create instances of the TableAdapters to interact with the Ingredient and RecipeIngredients tables
                            var ingredientAdapter = new RecipeDataSetTableAdapters.IngredientTableAdapter();
                            var recipeIngredientsAdapter = new RecipeDataSetTableAdapters.RecipeIngredientsTableAdapter();
                         
                            // Ensure the ingredient exists or create it if it doesn't
                            int ingredientId = EnsureIngredient(newIngredientName, ingredientAdapter);

                            // Add the new ingredient to the RecipeIngredients table with default quantity and optional unit
                            recipeIngredientsAdapter.InsertIngredient(recipeId, ingredientId, "Required Field", unit);

                            // Refresh DataGridView
                            var riDataTable = new RecipeDataSet.RecipeIngredientsDataTable();
                            recipeIngredientsAdapter.GetIngredientsWithNamesByRecipeID(riDataTable, recipeId);
                            dataGridViewIngredients.DataSource = riDataTable;
                        }
                    }
                }
            }
        }

        private void removeIngredientButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewIngredients.SelectedRows.Count > 0)
            {
                // Create an instance of the RecipeIngredientsTableAdapter to interact with the RecipeIngredients table
                var recipeIngredientsAdapter = new RecipeDataSetTableAdapters.RecipeIngredientsTableAdapter();
                // Get the selected recipe ID from the ListBox
                int recipeId = (int)optionsListBox.SelectedValue;

                // Loop through the selected rows in the ingredients DataGridView
                foreach (DataGridViewRow row in dataGridViewIngredients.SelectedRows)
                {

                    // Get the ingredient name from the selected row
                    string ingredientName = row.Cells["ingredientName"].Value.ToString();
                    // Create an instance of the IngredientTableAdapter to interact with the Ingredient table
                    var ingredientAdapter = new RecipeDataSetTableAdapters.IngredientTableAdapter();
                    int ingredientId = ingredientAdapter.GetIngredientIDByName(ingredientName).Value;

                    recipeIngredientsAdapter.DeleteIngredientByRecipeIDAndIngredientID(recipeId, ingredientId);
                }

                // Refresh DataGridView
                var riDataTable = new RecipeDataSet.RecipeIngredientsDataTable();
                recipeIngredientsAdapter.GetIngredientsWithNamesByRecipeID(riDataTable, recipeId);
                dataGridViewIngredients.DataSource = riDataTable;
            }
        }

      
    }
}