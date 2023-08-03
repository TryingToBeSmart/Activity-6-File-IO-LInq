namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            URLTextBox = new TextBox();
            AddToListButton = new Button();
            SaveToFileButton = new Button();
            LoadFromFileButton = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 4);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 40);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 125);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 40);
            label2.TabIndex = 1;
            label2.Text = "URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 65);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 40);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(165, 4);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(211, 46);
            FirstNameTextBox.TabIndex = 3;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(165, 65);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(211, 46);
            LastNameTextBox.TabIndex = 4;
            // 
            // URLTextBox
            // 
            URLTextBox.Location = new Point(165, 125);
            URLTextBox.Name = "URLTextBox";
            URLTextBox.Size = new Size(211, 46);
            URLTextBox.TabIndex = 5;
            // 
            // AddToListButton
            // 
            AddToListButton.Location = new Point(12, 189);
            AddToListButton.Name = "AddToListButton";
            AddToListButton.Size = new Size(281, 54);
            AddToListButton.TabIndex = 6;
            AddToListButton.Text = "Add To List ->";
            AddToListButton.UseVisualStyleBackColor = true;
            AddToListButton.Click += AddToListButton_Click;
            // 
            // SaveToFileButton
            // 
            SaveToFileButton.Location = new Point(52, 308);
            SaveToFileButton.Name = "SaveToFileButton";
            SaveToFileButton.Size = new Size(217, 54);
            SaveToFileButton.TabIndex = 7;
            SaveToFileButton.Text = "Save To File";
            SaveToFileButton.UseVisualStyleBackColor = true;
            SaveToFileButton.Click += SaveToFileButton_Click;
            // 
            // LoadFromFileButton
            // 
            LoadFromFileButton.Location = new Point(52, 380);
            LoadFromFileButton.Name = "LoadFromFileButton";
            LoadFromFileButton.Size = new Size(217, 54);
            LoadFromFileButton.TabIndex = 8;
            LoadFromFileButton.Text = "Load From File";
            LoadFromFileButton.UseVisualStyleBackColor = true;
            LoadFromFileButton.Click += LoadFromFileButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 40;
            listBox1.Location = new Point(391, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(433, 444);
            listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 464);
            Controls.Add(listBox1);
            Controls.Add(LoadFromFileButton);
            Controls.Add(SaveToFileButton);
            Controls.Add(AddToListButton);
            Controls.Add(URLTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox URLTextBox;
        private Button AddToListButton;
        private Button SaveToFileButton;
        private Button LoadFromFileButton;
        private ListBox listBox1;
    }
}