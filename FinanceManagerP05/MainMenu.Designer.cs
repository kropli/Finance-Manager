namespace FinanceManagerP05
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            sourceTextBox = new TextBox();
            RemoveSourceButton = new Button();
            AddSourceButton = new Button();
            incomeSourcesListBox = new ListBox();
            label5 = new Label();
            categoryTextBox = new TextBox();
            RemoveCategoryButton = new Button();
            AddCategoryButton = new Button();
            expenseCategoriesListBox = new ListBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            currenciesListBox = new ListBox();
            walletsListBox = new ListBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(sourceTextBox);
            panel1.Controls.Add(RemoveSourceButton);
            panel1.Controls.Add(AddSourceButton);
            panel1.Controls.Add(incomeSourcesListBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(categoryTextBox);
            panel1.Controls.Add(RemoveCategoryButton);
            panel1.Controls.Add(AddCategoryButton);
            panel1.Controls.Add(expenseCategoriesListBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(currenciesListBox);
            panel1.Controls.Add(walletsListBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1938, 629);
            panel1.TabIndex = 0;
            // 
            // sourceTextBox
            // 
            sourceTextBox.Font = new Font("SimSun-ExtB", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            sourceTextBox.Location = new Point(832, 527);
            sourceTextBox.Name = "sourceTextBox";
            sourceTextBox.Size = new Size(241, 22);
            sourceTextBox.TabIndex = 14;
            // 
            // RemoveSourceButton
            // 
            RemoveSourceButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveSourceButton.Location = new Point(832, 441);
            RemoveSourceButton.Name = "RemoveSourceButton";
            RemoveSourceButton.Size = new Size(241, 37);
            RemoveSourceButton.TabIndex = 13;
            RemoveSourceButton.Text = "Видалити категорію витрат";
            RemoveSourceButton.UseVisualStyleBackColor = true;
            RemoveSourceButton.Click += RemoveSourceButton_Click;
            // 
            // AddSourceButton
            // 
            AddSourceButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddSourceButton.Location = new Point(832, 484);
            AddSourceButton.Name = "AddSourceButton";
            AddSourceButton.Size = new Size(241, 37);
            AddSourceButton.TabIndex = 12;
            AddSourceButton.Text = "Додати категорію витрат";
            AddSourceButton.UseVisualStyleBackColor = true;
            AddSourceButton.Click += AddSourceButton_Click;
            // 
            // incomeSourcesListBox
            // 
            incomeSourcesListBox.FormattingEnabled = true;
            incomeSourcesListBox.ItemHeight = 15;
            incomeSourcesListBox.Location = new Point(832, 160);
            incomeSourcesListBox.Name = "incomeSourcesListBox";
            incomeSourcesListBox.Size = new Size(210, 274);
            incomeSourcesListBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(832, 124);
            label5.Name = "label5";
            label5.Size = new Size(204, 30);
            label5.TabIndex = 10;
            label5.Text = "Категорії витрат";
            // 
            // categoryTextBox
            // 
            categoryTextBox.Font = new Font("SimSun-ExtB", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            categoryTextBox.Location = new Point(488, 527);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.Size = new Size(241, 22);
            categoryTextBox.TabIndex = 9;
            // 
            // RemoveCategoryButton
            // 
            RemoveCategoryButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveCategoryButton.Location = new Point(488, 441);
            RemoveCategoryButton.Name = "RemoveCategoryButton";
            RemoveCategoryButton.Size = new Size(241, 37);
            RemoveCategoryButton.TabIndex = 8;
            RemoveCategoryButton.Text = "Видалити категорію витрат";
            RemoveCategoryButton.UseVisualStyleBackColor = true;
            // 
            // AddCategoryButton
            // 
            AddCategoryButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddCategoryButton.Location = new Point(488, 484);
            AddCategoryButton.Name = "AddCategoryButton";
            AddCategoryButton.Size = new Size(241, 37);
            AddCategoryButton.TabIndex = 7;
            AddCategoryButton.Text = "Додати категорію витрат";
            AddCategoryButton.UseVisualStyleBackColor = true;
            // 
            // expenseCategoriesListBox
            // 
            expenseCategoriesListBox.FormattingEnabled = true;
            expenseCategoriesListBox.ItemHeight = 15;
            expenseCategoriesListBox.Location = new Point(488, 160);
            expenseCategoriesListBox.Name = "expenseCategoriesListBox";
            expenseCategoriesListBox.Size = new Size(210, 274);
            expenseCategoriesListBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(488, 124);
            label4.Name = "label4";
            label4.Size = new Size(204, 30);
            label4.TabIndex = 5;
            label4.Text = "Категорії витрат";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 124);
            label3.Name = "label3";
            label3.Size = new Size(121, 30);
            label3.TabIndex = 4;
            label3.Tag = "";
            label3.Text = "Всі гаманці";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(250, 124);
            label2.Name = "label2";
            label2.Size = new Size(130, 30);
            label2.TabIndex = 3;
            label2.Text = "Всі валюти";
            // 
            // currenciesListBox
            // 
            currenciesListBox.FormattingEnabled = true;
            currenciesListBox.ItemHeight = 15;
            currenciesListBox.Location = new Point(250, 160);
            currenciesListBox.Name = "currenciesListBox";
            currenciesListBox.Size = new Size(130, 184);
            currenciesListBox.TabIndex = 2;
            // 
            // walletsListBox
            // 
            walletsListBox.FormattingEnabled = true;
            walletsListBox.ItemHeight = 15;
            walletsListBox.Location = new Point(12, 157);
            walletsListBox.Name = "walletsListBox";
            walletsListBox.Size = new Size(193, 274);
            walletsListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(789, 9);
            label1.Name = "label1";
            label1.Size = new Size(282, 65);
            label1.TabIndex = 0;
            label1.Text = "Main menu";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1938, 629);
            Controls.Add(panel1);
            Name = "MainMenu";
            Text = "MainMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox currenciesListBox;
        private ListBox walletsListBox;
        private ImageList imageList1;
        private Label label3;
        private Label label2;
        private ListBox expenseCategoriesListBox;
        private Label label4;
        private TextBox categoryTextBox;
        private Button RemoveCategoryButton;
        private Button AddCategoryButton;
        private TextBox sourceTextBox;
        private Button RemoveSourceButton;
        private Button AddSourceButton;
        private ListBox incomeSourcesListBox;
        private Label label5;
    }
}