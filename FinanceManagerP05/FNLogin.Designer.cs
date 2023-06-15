namespace FinanceManagerP05
{
    partial class FNLogin
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
            panel1 = new Panel();
            LoginButton = new Button();
            usernameTextBox = new TextBox();
            accountNameTextBox = new TextBox();
            AddUserButton = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(usernameTextBox);
            panel1.Controls.Add(accountNameTextBox);
            panel1.Controls.Add(AddUserButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.Location = new Point(554, 320);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(166, 41);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("SimSun-ExtB", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(56, 236);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(197, 22);
            usernameTextBox.TabIndex = 3;
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.Font = new Font("SimSun-ExtB", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            accountNameTextBox.Location = new Point(554, 236);
            accountNameTextBox.Name = "accountNameTextBox";
            accountNameTextBox.Size = new Size(166, 22);
            accountNameTextBox.TabIndex = 2;
            // 
            // AddUserButton
            // 
            AddUserButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddUserButton.Location = new Point(56, 320);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(197, 41);
            AddUserButton.TabIndex = 1;
            AddUserButton.Text = "Add Account";
            AddUserButton.UseVisualStyleBackColor = true;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(554, 25);
            label3.Name = "label3";
            label3.Size = new Size(166, 63);
            label3.TabIndex = 2;
            label3.Text = "Login";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(45, 25);
            label2.Name = "label2";
            label2.Size = new Size(394, 56);
            label2.TabIndex = 3;
            label2.Text = "Create Account";
            // 
            // label1
            // 
            label1.Location = new Point(31, 44);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // FNLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FNLogin";
            Text = "FNLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Button AddUserButton;
        private Button LoginButton;
        private TextBox usernameTextBox;
        private TextBox accountNameTextBox;
    }
}