namespace CarRental
{
    partial class Form5
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
            nameLabel = new Label();
            costHourLabel = new Label();
            yearLabel = new Label();
            nameTextBox = new TextBox();
            yearNumericUpDown = new NumericUpDown();
            costHourNumericUpDown = new NumericUpDown();
            addCarButton = new Button();
            brandLabel = new Label();
            brandTextBox = new TextBox();
            carTypeLabel = new Label();
            carTypeTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)yearNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)costHourNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(199, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Введите название машины";
            // 
            // costHourLabel
            // 
            costHourLabel.AutoSize = true;
            costHourLabel.Location = new Point(12, 123);
            costHourLabel.Name = "costHourLabel";
            costHourLabel.Size = new Size(182, 20);
            costHourLabel.TabIndex = 1;
            costHourLabel.Text = "Укажите стоимость в час";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(12, 66);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(244, 20);
            yearLabel.TabIndex = 2;
            yearLabel.Text = "Укажите год выпуска автомобиля";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 32);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(317, 27);
            nameTextBox.TabIndex = 3;
            // 
            // yearNumericUpDown
            // 
            yearNumericUpDown.Location = new Point(12, 89);
            yearNumericUpDown.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            yearNumericUpDown.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            yearNumericUpDown.Name = "yearNumericUpDown";
            yearNumericUpDown.Size = new Size(317, 27);
            yearNumericUpDown.TabIndex = 4;
            yearNumericUpDown.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // costHourNumericUpDown
            // 
            costHourNumericUpDown.Location = new Point(12, 146);
            costHourNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            costHourNumericUpDown.Name = "costHourNumericUpDown";
            costHourNumericUpDown.Size = new Size(317, 27);
            costHourNumericUpDown.TabIndex = 5;
            // 
            // addCarButton
            // 
            addCarButton.Location = new Point(12, 301);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(317, 40);
            addCarButton.TabIndex = 6;
            addCarButton.Text = "Добавить автомобиль";
            addCarButton.UseVisualStyleBackColor = true;
            addCarButton.Click += addCarButton_Click;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(12, 180);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(279, 20);
            brandLabel.TabIndex = 7;
            brandLabel.Text = "Введите название бренда автомобиля";
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(12, 203);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(317, 27);
            brandTextBox.TabIndex = 8;
            // 
            // carTypeLabel
            // 
            carTypeLabel.AutoSize = true;
            carTypeLabel.Location = new Point(12, 237);
            carTypeLabel.Name = "carTypeLabel";
            carTypeLabel.Size = new Size(182, 20);
            carTypeLabel.TabIndex = 9;
            carTypeLabel.Text = "Введите тип автомобиля";
            // 
            // carTypeTextBox
            // 
            carTypeTextBox.Location = new Point(12, 260);
            carTypeTextBox.Name = "carTypeTextBox";
            carTypeTextBox.Size = new Size(317, 27);
            carTypeTextBox.TabIndex = 10;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 450);
            Controls.Add(carTypeTextBox);
            Controls.Add(carTypeLabel);
            Controls.Add(brandTextBox);
            Controls.Add(brandLabel);
            Controls.Add(addCarButton);
            Controls.Add(costHourNumericUpDown);
            Controls.Add(yearNumericUpDown);
            Controls.Add(nameTextBox);
            Controls.Add(yearLabel);
            Controls.Add(costHourLabel);
            Controls.Add(nameLabel);
            Name = "Form5";
            Text = "Добавление автомобиля";
            FormClosing += Form5_FormClosing;
            ((System.ComponentModel.ISupportInitialize)yearNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)costHourNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label costHourLabel;
        private Label yearLabel;
        private TextBox nameTextBox;
        private NumericUpDown yearNumericUpDown;
        private NumericUpDown costHourNumericUpDown;
        private Button addCarButton;
        private Label brandLabel;
        private TextBox brandTextBox;
        private Label carTypeLabel;
        private TextBox carTypeTextBox;
    }
}