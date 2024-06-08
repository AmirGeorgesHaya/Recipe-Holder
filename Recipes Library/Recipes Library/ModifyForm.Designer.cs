namespace Recipes_Library
{
    partial class ModifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyForm));
            this.designLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.optionsListBox = new System.Windows.Forms.ListBox();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDataSet = new Recipes_Library.RecipeDataSet();
            this.optionLabel = new System.Windows.Forms.Label();
            this.recipesTableAdapter = new Recipes_Library.RecipeDataSetTableAdapters.RecipesTableAdapter();
            this.removeButton = new System.Windows.Forms.Button();
            this.dataGridViewSteps = new System.Windows.Forms.DataGridView();
            this.stepNumber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stepInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeStepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewIngredients = new System.Windows.Forms.DataGridView();
            this.ingredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.recipeStepsTableAdapter = new Recipes_Library.RecipeDataSetTableAdapters.RecipeStepsTableAdapter();
            this.addStepButton = new System.Windows.Forms.Button();
            this.deleteStepButton = new System.Windows.Forms.Button();
            this.removeIngredientButton = new System.Windows.Forms.Button();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.timeDisplayForm1 = new Recipes_Library.TimeDisplayForm();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeStepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // designLabel
            // 
            this.designLabel.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.designLabel, "designLabel");
            this.designLabel.Name = "designLabel";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // optionsListBox
            // 
            this.optionsListBox.DataSource = this.recipesBindingSource;
            this.optionsListBox.DisplayMember = "RecipeName";
            this.optionsListBox.FormattingEnabled = true;
            resources.ApplyResources(this.optionsListBox, "optionsListBox");
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
            // optionLabel
            // 
            resources.ApplyResources(this.optionLabel, "optionLabel");
            this.optionLabel.Name = "optionLabel";
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // removeButton
            // 
            resources.ApplyResources(this.removeButton, "removeButton");
            this.removeButton.Name = "removeButton";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // dataGridViewSteps
            // 
            this.dataGridViewSteps.AllowUserToAddRows = false;
            this.dataGridViewSteps.AllowUserToDeleteRows = false;
            this.dataGridViewSteps.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stepNumber,
            this.stepInfo});
            resources.ApplyResources(this.dataGridViewSteps, "dataGridViewSteps");
            this.dataGridViewSteps.Name = "dataGridViewSteps";
            this.dataGridViewSteps.RowTemplate.Height = 24;
            this.dataGridViewSteps.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSteps_CellValueChanged);
            // 
            // stepNumber
            // 
            this.stepNumber.DataPropertyName = "stepNumber";
            resources.ApplyResources(this.stepNumber, "stepNumber");
            this.stepNumber.Name = "stepNumber";
            this.stepNumber.ReadOnly = true;
            this.stepNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stepNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // stepInfo
            // 
            this.stepInfo.DataPropertyName = "stepInfo";
            resources.ApplyResources(this.stepInfo, "stepInfo");
            this.stepInfo.Name = "stepInfo";
            // 
            // recipeStepsBindingSource
            // 
            this.recipeStepsBindingSource.DataMember = "RecipeSteps";
            this.recipeStepsBindingSource.DataSource = this.recipeDataSet;
            // 
            // dataGridViewIngredients
            // 
            this.dataGridViewIngredients.AllowUserToAddRows = false;
            this.dataGridViewIngredients.AllowUserToDeleteRows = false;
            this.dataGridViewIngredients.AllowUserToResizeColumns = false;
            this.dataGridViewIngredients.AllowUserToResizeRows = false;
            this.dataGridViewIngredients.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientName,
            this.quantity,
            this.unit});
            resources.ApplyResources(this.dataGridViewIngredients, "dataGridViewIngredients");
            this.dataGridViewIngredients.Name = "dataGridViewIngredients";
            this.dataGridViewIngredients.RowTemplate.Height = 24;
            this.dataGridViewIngredients.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIngredients_CellValueChanged);
            // 
            // ingredientName
            // 
            this.ingredientName.FillWeight = 111.9289F;
            resources.ApplyResources(this.ingredientName, "ingredientName");
            this.ingredientName.Name = "ingredientName";
            this.ingredientName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 76.14214F;
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            // 
            // unit
            // 
            this.unit.FillWeight = 111.9289F;
            resources.ApplyResources(this.unit, "unit");
            this.unit.Name = "unit";
            // 
            // recipesBindingSource1
            // 
            this.recipesBindingSource1.DataMember = "Recipes";
            this.recipesBindingSource1.DataSource = this.recipeDataSet;
            // 
            // recipeStepsTableAdapter
            // 
            this.recipeStepsTableAdapter.ClearBeforeFill = true;
            // 
            // addStepButton
            // 
            resources.ApplyResources(this.addStepButton, "addStepButton");
            this.addStepButton.Name = "addStepButton";
            this.addStepButton.UseVisualStyleBackColor = true;
            this.addStepButton.Click += new System.EventHandler(this.addStepButton_Click);
            // 
            // deleteStepButton
            // 
            resources.ApplyResources(this.deleteStepButton, "deleteStepButton");
            this.deleteStepButton.Name = "deleteStepButton";
            this.deleteStepButton.UseVisualStyleBackColor = true;
            this.deleteStepButton.Click += new System.EventHandler(this.deleteStepButton_Click);
            // 
            // removeIngredientButton
            // 
            resources.ApplyResources(this.removeIngredientButton, "removeIngredientButton");
            this.removeIngredientButton.Name = "removeIngredientButton";
            this.removeIngredientButton.UseVisualStyleBackColor = true;
            this.removeIngredientButton.Click += new System.EventHandler(this.removeIngredientButton_Click);
            // 
            // addIngredientButton
            // 
            resources.ApplyResources(this.addIngredientButton, "addIngredientButton");
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // timeDisplayForm1
            // 
            this.timeDisplayForm1.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.timeDisplayForm1, "timeDisplayForm1");
            this.timeDisplayForm1.Name = "timeDisplayForm1";
            // 
            // ModifyForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.timeDisplayForm1);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.removeIngredientButton);
            this.Controls.Add(this.deleteStepButton);
            this.Controls.Add(this.addStepButton);
            this.Controls.Add(this.dataGridViewSteps);
            this.Controls.Add(this.dataGridViewIngredients);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.optionsListBox);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.designLabel);
            this.Name = "ModifyForm";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeStepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label designLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox optionsListBox;
        private System.Windows.Forms.Label optionLabel;
        private RecipeDataSet recipeDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private RecipeDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridView dataGridViewSteps;
        private System.Windows.Forms.DataGridView dataGridViewIngredients;
        private System.Windows.Forms.BindingSource recipesBindingSource1;
        private System.Windows.Forms.BindingSource recipeStepsBindingSource;
        private RecipeDataSetTableAdapters.RecipeStepsTableAdapter recipeStepsTableAdapter;
        private System.Windows.Forms.Button addStepButton;
        private System.Windows.Forms.Button deleteStepButton;
        private System.Windows.Forms.Button removeIngredientButton;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewComboBoxColumn stepNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepInfo;
        private TimeDisplayForm timeDisplayForm1;
    }
}