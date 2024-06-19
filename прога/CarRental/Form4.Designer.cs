namespace CarRental
{
    partial class Form4
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
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            patronymicTextBox = new TextBox();
            addressTextBox = new TextBox();
            phoneTextBox = new TextBox();
            surnameLabel = new Label();
            nameLabel = new Label();
            patronymicLabel = new Label();
            addressLabel = new Label();
            phoneLabel = new Label();
            addClientButton = new Button();
            SuspendLayout();
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(12, 32);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(398, 27);
            surnameTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 88);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(398, 27);
            nameTextBox.TabIndex = 1;
            // 
            // patronymicTextBox
            // 
            patronymicTextBox.Location = new Point(12, 145);
            patronymicTextBox.Name = "patronymicTextBox";
            patronymicTextBox.Size = new Size(398, 27);
            patronymicTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(12, 202);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(398, 27);
            addressTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(12, 259);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(398, 27);
            phoneTextBox.TabIndex = 4;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(12, 9);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(195, 20);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Введите фамилию клиента";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(156, 20);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Введите имя клиента";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new Point(12, 122);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new Size(189, 20);
            patronymicLabel.TabIndex = 7;
            patronymicLabel.Text = "Введите отчество клиента";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 179);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(168, 20);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Введите адрес клиента";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(12, 236);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(244, 20);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Введите номер телефона клиента";
            // 
            // addClientButton
            // 
            addClientButton.Location = new Point(12, 300);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(398, 40);
            addClientButton.TabIndex = 10;
            addClientButton.Text = "Добавить клиента";
            addClientButton.UseVisualStyleBackColor = true;
            addClientButton.Click += addClientButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 450);
            Controls.Add(addClientButton);
            Controls.Add(phoneLabel);
            Controls.Add(addressLabel);
            Controls.Add(patronymicLabel);
            Controls.Add(nameLabel);
            Controls.Add(surnameLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(patronymicTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(surnameTextBox);
            Name = "Form4";
            Text = "Добавление клиента";
            FormClosing += Form4_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private TextBox patronymicTextBox;
        private TextBox addressTextBox;
        private TextBox phoneTextBox;
        private Label surnameLabel;
        private Label nameLabel;
        private Label patronymicLabel;
        private Label addressLabel;
        private Label phoneLabel;
        private Button addClientButton;
    }
}