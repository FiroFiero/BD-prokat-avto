namespace CarRental
{
    partial class Form3
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
            dateOfIssueDateTimePicker = new DateTimePicker();
            dateOfReturnDateTimePicker = new DateTimePicker();
            dateOfActualReturnDateTimePicker = new DateTimePicker();
            costNumericUpDown = new NumericUpDown();
            fineNumericUpDown = new NumericUpDown();
            discountNumericUpDown = new NumericUpDown();
            searchClientComboBox = new ComboBox();
            searchCarComboBox = new ComboBox();
            addNewOrderButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            searchStatusComboBox = new ComboBox();
            addClientButton = new Button();
            addCarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)costNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fineNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // dateOfIssueDateTimePicker
            // 
            dateOfIssueDateTimePicker.Location = new Point(14, 164);
            dateOfIssueDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateOfIssueDateTimePicker.Name = "dateOfIssueDateTimePicker";
            dateOfIssueDateTimePicker.Size = new Size(311, 27);
            dateOfIssueDateTimePicker.TabIndex = 0;
            // 
            // dateOfReturnDateTimePicker
            // 
            dateOfReturnDateTimePicker.Location = new Point(14, 228);
            dateOfReturnDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateOfReturnDateTimePicker.Name = "dateOfReturnDateTimePicker";
            dateOfReturnDateTimePicker.Size = new Size(311, 27);
            dateOfReturnDateTimePicker.TabIndex = 1;
            // 
            // dateOfActualReturnDateTimePicker
            // 
            dateOfActualReturnDateTimePicker.Location = new Point(333, 228);
            dateOfActualReturnDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateOfActualReturnDateTimePicker.Name = "dateOfActualReturnDateTimePicker";
            dateOfActualReturnDateTimePicker.Size = new Size(311, 27);
            dateOfActualReturnDateTimePicker.TabIndex = 2;
            // 
            // costNumericUpDown
            // 
            costNumericUpDown.Location = new Point(14, 292);
            costNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            costNumericUpDown.Name = "costNumericUpDown";
            costNumericUpDown.Size = new Size(312, 27);
            costNumericUpDown.TabIndex = 3;
            // 
            // fineNumericUpDown
            // 
            fineNumericUpDown.Location = new Point(14, 356);
            fineNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            fineNumericUpDown.Name = "fineNumericUpDown";
            fineNumericUpDown.Size = new Size(312, 27);
            fineNumericUpDown.TabIndex = 4;
            // 
            // discountNumericUpDown
            // 
            discountNumericUpDown.Location = new Point(14, 420);
            discountNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            discountNumericUpDown.Name = "discountNumericUpDown";
            discountNumericUpDown.Size = new Size(312, 27);
            discountNumericUpDown.TabIndex = 5;
            // 
            // searchClientComboBox
            // 
            searchClientComboBox.FormattingEnabled = true;
            searchClientComboBox.Location = new Point(14, 36);
            searchClientComboBox.Margin = new Padding(3, 4, 3, 4);
            searchClientComboBox.Name = "searchClientComboBox";
            searchClientComboBox.Size = new Size(311, 28);
            searchClientComboBox.TabIndex = 6;
            // 
            // searchCarComboBox
            // 
            searchCarComboBox.FormattingEnabled = true;
            searchCarComboBox.Location = new Point(14, 100);
            searchCarComboBox.Margin = new Padding(3, 4, 3, 4);
            searchCarComboBox.Name = "searchCarComboBox";
            searchCarComboBox.Size = new Size(311, 28);
            searchCarComboBox.TabIndex = 7;
            // 
            // addNewOrderButton
            // 
            addNewOrderButton.Location = new Point(14, 518);
            addNewOrderButton.Margin = new Padding(3, 4, 3, 4);
            addNewOrderButton.Name = "addNewOrderButton";
            addNewOrderButton.Size = new Size(312, 53);
            addNewOrderButton.TabIndex = 8;
            addNewOrderButton.Text = "Добавить запись";
            addNewOrderButton.UseVisualStyleBackColor = true;
            addNewOrderButton.Click += addNewOrderButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 9;
            label1.Text = "Выберите клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 10;
            label2.Text = "Выберите автомобиль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 140);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 11;
            label3.Text = "Укажите дату выдачи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 204);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 12;
            label4.Text = "Укажите дату возврата";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 204);
            label5.Name = "label5";
            label5.Size = new Size(265, 20);
            label5.TabIndex = 13;
            label5.Text = "Укажите дату фактического возврата";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 268);
            label6.Name = "label6";
            label6.Size = new Size(143, 20);
            label6.TabIndex = 14;
            label6.Text = "Укажите стоимость";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 332);
            label7.Name = "label7";
            label7.Size = new Size(171, 20);
            label7.TabIndex = 15;
            label7.Text = "Укажите сумму штрафа";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 396);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 16;
            label8.Text = "Укажите сумму скидки";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 458);
            label9.Name = "label9";
            label9.Size = new Size(172, 20);
            label9.TabIndex = 17;
            label9.Text = "Выберите статус заказа";
            // 
            // searchStatusComboBox
            // 
            searchStatusComboBox.FormattingEnabled = true;
            searchStatusComboBox.Location = new Point(14, 482);
            searchStatusComboBox.Margin = new Padding(3, 4, 3, 4);
            searchStatusComboBox.Name = "searchStatusComboBox";
            searchStatusComboBox.Size = new Size(311, 28);
            searchStatusComboBox.TabIndex = 18;
            // 
            // addClientButton
            // 
            addClientButton.FlatAppearance.BorderColor = Color.Silver;
            addClientButton.FlatStyle = FlatStyle.Flat;
            addClientButton.ForeColor = SystemColors.ActiveCaptionText;
            addClientButton.Location = new Point(331, 36);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(175, 29);
            addClientButton.TabIndex = 19;
            addClientButton.Text = "Добавить клиента";
            addClientButton.TextAlign = ContentAlignment.MiddleLeft;
            addClientButton.UseVisualStyleBackColor = true;
            addClientButton.Click += addClientButton_Click;
            // 
            // addCarButton
            // 
            addCarButton.FlatAppearance.BorderColor = Color.Silver;
            addCarButton.FlatStyle = FlatStyle.Flat;
            addCarButton.ForeColor = SystemColors.ActiveCaptionText;
            addCarButton.Location = new Point(331, 100);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(175, 29);
            addCarButton.TabIndex = 20;
            addCarButton.Text = "Добавить автомобиль";
            addCarButton.TextAlign = ContentAlignment.MiddleLeft;
            addCarButton.UseVisualStyleBackColor = true;
            addCarButton.Click += addCarButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 581);
            Controls.Add(addCarButton);
            Controls.Add(addClientButton);
            Controls.Add(searchStatusComboBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addNewOrderButton);
            Controls.Add(searchCarComboBox);
            Controls.Add(searchClientComboBox);
            Controls.Add(discountNumericUpDown);
            Controls.Add(fineNumericUpDown);
            Controls.Add(costNumericUpDown);
            Controls.Add(dateOfActualReturnDateTimePicker);
            Controls.Add(dateOfReturnDateTimePicker);
            Controls.Add(dateOfIssueDateTimePicker);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Добавление нового заказа";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)costNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)fineNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateOfIssueDateTimePicker;
        private DateTimePicker dateOfReturnDateTimePicker;
        private DateTimePicker dateOfActualReturnDateTimePicker;
        private NumericUpDown costNumericUpDown;
        private NumericUpDown fineNumericUpDown;
        private NumericUpDown discountNumericUpDown;
        private ComboBox searchClientComboBox;
        private ComboBox searchCarComboBox;
        private Button addNewOrderButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox searchStatusComboBox;
        private Button addClientButton;
        private Button addCarButton;
    }
}