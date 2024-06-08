namespace Recipes_Library
{
    partial class ViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.designLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.optionLabel = new System.Windows.Forms.Label();
            this.ingredientLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.optionsListBox = new System.Windows.Forms.ListBox();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDataSet = new Recipes_Library.RecipeDataSet();
            this.recipesTableAdapter = new Recipes_Library.RecipeDataSetTableAdapters.RecipesTableAdapter();
            this.tableAdapterManager = new Recipes_Library.RecipeDataSetTableAdapters.TableAdapterManager();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientTableAdapter = new Recipes_Library.RecipeDataSetTableAdapters.IngredientTableAdapter();
            this.recipeStepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeStepsTableAdapter = new Recipes_Library.RecipeDataSetTableAdapters.RecipeStepsTableAdapter();
            this.stopwatchUserForm1 = new Recipes_Library.StopwatchUserForm();
            this.ingredientTextBox = new System.Windows.Forms.TextBox();
            this.stepsTextBox = new System.Windows.Forms.TextBox();
            this.timeDisplayForm1 = new Recipes_Library.TimeDisplayForm();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeStepsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // designLabel
            // 
            resources.ApplyResources(this.designLabel, "designLabel");
            this.designLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.designLabel.Name = "designLabel";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // optionLabel
            // 
            resources.ApplyResources(this.optionLabel, "optionLabel");
            this.optionLabel.Name = "optionLabel";
            // 
            // ingredientLabel
            // 
            resources.ApplyResources(this.ingredientLabel, "ingredientLabel");
            this.ingredientLabel.Name = "ingredientLabel";
            // 
            // timerLabel
            // 
            resources.ApplyResources(this.timerLabel, "timerLabel");
            this.timerLabel.Name = "timerLabel";
            // 
            // stepsLabel
            // 
            resources.ApplyResources(this.stepsLabel, "stepsLabel");
            this.stepsLabel.Name = "stepsLabel";
            // 
            // optionsListBox
            // 
            resources.ApplyResources(this.optionsListBox, "optionsListBox");
            this.optionsListBox.DataSource = this.recipesBindingSource;
            this.optionsListBox.DisplayMember = "RecipeName";
            this.optionsListBox.FormattingEnabled = true;
            this.optionsListBox.Name = "optionsListBox";
            this.optionsListBox.ValueMember = "RecipeID";
            this.optionsListBox.SelectedIndexChanged += new System.EventHandler(this.optionsListBox_SelectedIndexChanged);
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.recipeDataSet;
            // 
            // recipeDataSet
            // 
            this.recipeDataSet.DataSetName = "RecipeDataSet";
            this.recipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IngredientTableAdapter = null;
            this.tableAdapterManager.RecipeIngredientsTableAdapter = null;
            this.tableAdapterManager.RecipesTableAdapter = this.recipesTableAdapter;
            this.tableAdapterManager.RecipeStepsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Recipes_Library.RecipeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataMember = "Ingredient";
            this.ingredientBindingSource.DataSource = this.recipeDataSet;
            // 
            // ingredientTableAdapter
            // 
            this.ingredientTableAdapter.ClearBeforeFill = true;
            // 
            // recipeStepsBindingSource
            // 
            this.recipeStepsBindingSource.DataMember = "RecipeSteps";
            this.recipeStepsBindingSource.DataSource = this.recipeDataSet;
            // 
            // recipeStepsTableAdapter
            // 
            this.recipeStepsTableAdapter.ClearBeforeFill = true;
            // 
            // stopwatchUserForm1
            // 
            resources.ApplyResources(this.stopwatchUserForm1, "stopwatchUserForm1");
            this.stopwatchUserForm1.Name = "stopwatchUserForm1";
            // 
            // ingredientTextBox
            // 
            resources.ApplyResources(this.ingredientTextBox, "ingredientTextBox");
            this.ingredientTextBox.Name = "ingredientTextBox";
            this.ingredientTextBox.ReadOnly = true;
            // 
            // stepsTextBox
            // 
            resources.ApplyResources(this.stepsTextBox, "stepsTextBox");
            this.stepsTextBox.Name = "stepsTextBox";
            this.stepsTextBox.ReadOnly = true;
            // 
            // timeDisplayForm1
            // 
            resources.ApplyResources(this.timeDisplayForm1, "timeDisplayForm1");
            this.timeDisplayForm1.BackColor = System.Drawing.Color.SteelBlue;
            this.timeDisplayForm1.Name = "timeDisplayForm1";
            // 
            // ViewForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.timeDisplayForm1);
            this.Controls.Add(this.stepsTextBox);
            this.Controls.Add(this.ingredientTextBox);
            this.Controls.Add(this.stopwatchUserForm1);
            this.Controls.Add(this.optionsListBox);
            this.Controls.Add(this.ingredientLabel);
            this.Controls.Add(this.stepsLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.designLabel);
            this.Name = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeStepsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label designLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.Label ingredientLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label stepsLabel;
        private System.Windows.Forms.ListBox optionsListBox;
        private RecipeDataSet recipeDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private RecipeDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private RecipeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private RecipeDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter;
        private System.Windows.Forms.BindingSource recipeStepsBindingSource;
        private RecipeDataSetTableAdapters.RecipeStepsTableAdapter recipeStepsTableAdapter;
        private StopwatchUserForm stopwatchUserForm1;
        private System.Windows.Forms.TextBox ingredientTextBox;
        private System.Windows.Forms.TextBox stepsTextBox;
        private TimeDisplayForm timeDisplayForm1;
    }
}