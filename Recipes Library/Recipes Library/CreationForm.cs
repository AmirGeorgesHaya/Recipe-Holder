using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace Recipes_Library
{
    public partial class CreationForm : Form
    {
        public CreationForm()
        {
            InitializeComponent();
        }

        // Method to insert a new recipe and get its ID

        private int InsertRecipeAndGetID(string recipeName, string cookTime)
        {
            // Create an instance of the RecipesTableAdapter to interact with the Recipes table

            using (var recipeAdapter = new RecipeDataSetTableAdapters.RecipesTableAdapter())
            {
                // Insert the recipe into the database and get the new recipe ID
                // Convert the returned ID to an integer and return it
                return Convert.ToInt32(recipeAdapter.InsertAndGetRecipeID(recipeName, cookTime));
            }
        }
        private int EnsureIngredient(string ingredientName, RecipeDataSetTableAdapters.IngredientTableAdapter ingredientAdapter)
        {
            // Check if the ingredient exists and get its ID
            int? ingredientId = ingredientAdapter.GetIngredientIDByName(ingredientName);
            if (ingredientId.HasValue)
            {
                return ingredientId.Value;
            }
            else
            {
                // Ingredient does not exist, create a new one and get its ID
                return (int) ingredientAdapter.InsertIngredient(ingredientName);
            }
        }

        private void recipeSaveButton_Click(object sender, EventArgs e)
        {
            // Get the recipe name and cook time from the text boxes and trim any whitespace

            string recipeName = recipeNameTextBox.Text.Trim();
            string cookTime = cookTimeTextBox.Text.Trim();

            // Validate the recipe name

            if (string.IsNullOrEmpty(recipeName))
            {
                MessageBox.Show("Please enter a recipe name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(cookTime))
            {
                MessageBox.Show("Please enter the cook time.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validate all inputs before starting the save process
            if (!ValidateIngredients() || !ValidateSteps())
            {
                // Validation messages are shown inside the respective methods
                return;
            }
            // Use the recipe adapter to check for duplicate recipe names
            using (var recipeAdapter = new RecipeDataSetTableAdapters.RecipesTableAdapter())
            {
                // Check for duplicate recipe name
                if (recipeAdapter.GetCountByRecipeName(recipeName) > 0)
                {
                    MessageBox.Show("A recipe with this name already exists. Please use a different name.", "Duplicate Recipe Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Begin transaction to ensure a single unit of work
                /*
                 * System.Transactions namespace that provides an easy way to handle transactions. It ensures 
                 * that a group of operations are treated as a single, atomic unit of work.
                 * This means that either all operations within the transaction succeed, or none of them are applied.
                 */
                using (var transaction = new TransactionScope())
                {
                    try
                    {
                        // Insert the recipe and get its ID
                        int recipeId = InsertRecipeAndGetID(recipeName, cookTime);

                        // Insert ingredients into the RecipeIngredients table
                        using (var ingredientAdapter = new RecipeDataSetTableAdapters.IngredientTableAdapter())
                        {
                            var recipeIngredientsAdapter = new RecipeDataSetTableAdapters.RecipeIngredientsTableAdapter();
                            foreach (DataGridViewRow row in dataGridViewIngredients.Rows)
                            {
                                if (!row.IsNewRow && !string.IsNullOrEmpty(Convert.ToString(row.Cells["ingredientName"].Value)))
                                {
                                    string ingredientName = Convert.ToString(row.Cells["ingredientName"].Value);
                                    string quantity = Convert.ToString(row.Cells["quantity"].Value);
                                    string unit = Convert.ToString(row.Cells["unit"].Value);

                                    int ingredientId = EnsureIngredient(ingredientName, ingredientAdapter);
                                    recipeIngredientsAdapter.Insert(recipeId, ingredientId, quantity, unit);
                                }
                            }
                        }
                        // Insert steps into the RecipeSteps table
                        using (var stepsAdapter = new RecipeDataSetTableAdapters.RecipeStepsTableAdapter())
                        {
                            foreach (DataGridViewRow row in dataGridViewSteps.Rows)
                            {
                                if (!row.IsNewRow && !string.IsNullOrEmpty(Convert.ToString(row.Cells["stepInfo"].Value)))
                                {
                                    int stepNumber = Convert.ToInt32(row.Cells["stepNumber"].Value);
                                    string stepInfo = Convert.ToString(row.Cells["stepInfo"].Value);
                                    stepsAdapter.Insert(recipeId, stepNumber, stepInfo);
                                }
                            }
                        }

                        // Commit the transaction
                        transaction.Complete();

                        MessageBox.Show("Recipe saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally clear form for next input
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        // Handle and log the error, rollback transaction if needed
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool ValidateIngredients()
        {
            foreach (DataGridViewRow row in dataGridViewIngredients.Rows)
            {
                if (!row.IsNewRow)
                {
                    string ingredientName = Convert.ToString(row.Cells["ingredientName"].Value);
                    string quantity = Convert.ToString(row.Cells["quantity"].Value);
                    string unit = Convert.ToString(row.Cells["unit"].Value);

                    if (string.IsNullOrEmpty(ingredientName))
                    {
                        MessageBox.Show("Please ensure all ingredient fields are filled out correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }
        private bool ValidateSteps()
        {
            foreach (DataGridViewRow row in dataGridViewSteps.Rows)
            {
                if (!row.IsNewRow)
                {
                    string stepInfo = Convert.ToString(row.Cells["stepInfo"].Value);
                    if (string.IsNullOrEmpty(stepInfo))
                    {
                        MessageBox.Show("Please ensure all step descriptions are provided.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }
        private void ClearForm()
        {
            recipeNameTextBox.Clear();
            dataGridViewIngredients.Rows.Clear();
            dataGridViewSteps.Rows.Clear();
        }

    }
}
