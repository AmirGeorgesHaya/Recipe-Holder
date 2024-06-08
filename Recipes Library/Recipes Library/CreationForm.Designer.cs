namespace Recipes_Library
{
    partial class CreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationForm));
            this.designLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.optionLabel = new System.Windows.Forms.Label();
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.recipeSaveButton = new System.Windows.Forms.Button();
            this.dataGridViewIngredients = new System.Windows.Forms.DataGridView();
            this.ingredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSteps = new System.Windows.Forms.DataGridView();
            this.stepNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeDisplayForm1 = new Recipes_Library.TimeDisplayForm();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSteps)).BeginInit();
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
            // recipeNameTextBox
            // 
            resources.ApplyResources(this.recipeNameTextBox, "recipeNameTextBox");
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            // 
            // recipeSaveButton
            // 
            resources.ApplyResources(this.recipeSaveButton, "recipeSaveButton");
            this.recipeSaveButton.Name = "recipeSaveButton";
            this.recipeSaveButton.UseVisualStyleBackColor = true;
            this.recipeSaveButton.Click += new System.EventHandler(this.recipeSaveButton_Click);
            // 
            // dataGridViewIngredients
            // 
            resources.ApplyResources(this.dataGridViewIngredients, "dataGridViewIngredients");
            this.dataGridViewIngredients.AllowUserToDeleteRows = false;
            this.dataGridViewIngredients.AllowUserToResizeColumns = false;
            this.dataGridViewIngredients.AllowUserToResizeRows = false;
            this.dataGridViewIngredients.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientName,
            this.quantity,
            this.unit});
            this.dataGridViewIngredients.Name = "dataGridViewIngredients";
            this.dataGridViewIngredients.RowTemplate.Height = 24;
            // 
            // ingredientName
            // 
            this.ingredientName.FillWeight = 111.9289F;
            resources.ApplyResources(this.ingredientName, "ingredientName");
            this.ingredientName.Name = "ingredientName";
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
            // dataGridViewSteps
            // 
            resources.ApplyResources(this.dataGridViewSteps, "dataGridViewSteps");
            this.dataGridViewSteps.AllowUserToDeleteRows = false;
            this.dataGridViewSteps.AllowUserToOrderColumns = true;
            this.dataGridViewSteps.AllowUserToResizeColumns = false;
            this.dataGridViewSteps.AllowUserToResizeRows = false;
            this.dataGridViewSteps.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stepNumber,
            this.stepInfo});
            this.dataGridViewSteps.Name = "dataGridViewSteps";
            this.dataGridViewSteps.RowTemplate.Height = 24;
            // 
            // stepNumber
            // 
            resources.ApplyResources(this.stepNumber, "stepNumber");
            this.stepNumber.Name = "stepNumber";
            // 
            // stepInfo
            // 
            resources.ApplyResources(this.stepInfo, "stepInfo");
            this.stepInfo.Name = "stepInfo";
            // 
            // cookTimeTextBox
            // 
            resources.ApplyResources(this.cookTimeTextBox, "cookTimeTextBox");
            this.cookTimeTextBox.Name = "cookTimeTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // timeDisplayForm1
            // 
            resources.ApplyResources(this.timeDisplayForm1, "timeDisplayForm1");
            this.timeDisplayForm1.BackColor = System.Drawing.Color.SteelBlue;
            this.timeDisplayForm1.Name = "timeDisplayForm1";
            // 
            // CreationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.timeDisplayForm1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cookTimeTextBox);
            this.Controls.Add(this.dataGridViewSteps);
            this.Controls.Add(this.dataGridViewIngredients);
            this.Controls.Add(this.recipeSaveButton);
            this.Controls.Add(this.recipeNameTextBox);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.designLabel);
            this.Name = "CreationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label designLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.TextBox recipeNameTextBox;
        private System.Windows.Forms.Button recipeSaveButton;
        private System.Windows.Forms.DataGridView dataGridViewIngredients;
        private System.Windows.Forms.DataGridView dataGridViewSteps;
        private System.Windows.Forms.TextBox cookTimeTextBox;
        private System.Windows.Forms.Label label1;
        private TimeDisplayForm timeDisplayForm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
    }
}