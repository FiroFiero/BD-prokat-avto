namespace CarRental
{
    partial class Form2
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
            this.searchClientComboBox = new System.Windows.Forms.ComboBox();
            this.searchCarComboBox = new System.Windows.Forms.ComboBox();
            this.firstDateOfIssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.secondDateOfIssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchSubmitButton = new System.Windows.Forms.Button();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.carNameLabel = new System.Windows.Forms.Label();
            this.startDateOfIssueLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchClientComboBox
            // 
            this.searchClientComboBox.FormattingEnabled = true;
            this.searchClientComboBox.Location = new System.Drawing.Point(14, 34);
            this.searchClientComboBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.searchClientComboBox.Name = "searchClientComboBox";
            this.searchClientComboBox.Size = new System.Drawing.Size(420, 23);
            this.searchClientComboBox.TabIndex = 0;
            // 
            // searchCarComboBox
            // 
            this.searchCarComboBox.FormattingEnabled = true;
            this.searchCarComboBox.Location = new System.Drawing.Point(14, 92);
            this.searchCarComboBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.searchCarComboBox.Name = "searchCarComboBox";
            this.searchCarComboBox.Size = new System.Drawing.Size(420, 23);
            this.searchCarComboBox.TabIndex = 1;
            // 
            // firstDateOfIssueDateTimePicker
            // 
            this.firstDateOfIssueDateTimePicker.CustomFormat = "\"MM/dd/yyyy hh:mm:ss\";";
            this.firstDateOfIssueDateTimePicker.Location = new System.Drawing.Point(14, 150);
            this.firstDateOfIssueDateTimePicker.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.firstDateOfIssueDateTimePicker.Name = "firstDateOfIssueDateTimePicker";
            this.firstDateOfIssueDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.firstDateOfIssueDateTimePicker.TabIndex = 2;
            // 
            // secondDateOfIssueDateTimePicker
            // 
            this.secondDateOfIssueDateTimePicker.CustomFormat = "\"MM/dd/yyyy hh:mm:ss\";";
            this.secondDateOfIssueDateTimePicker.Location = new System.Drawing.Point(234, 150);
            this.secondDateOfIssueDateTimePicker.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.secondDateOfIssueDateTimePicker.Name = "secondDateOfIssueDateTimePicker";
            this.secondDateOfIssueDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.secondDateOfIssueDateTimePicker.TabIndex = 3;
            // 
            // searchSubmitButton
            // 
            this.searchSubmitButton.Location = new System.Drawing.Point(14, 250);
            this.searchSubmitButton.Margin = new System.Windows.Forms.Padding(10);
            this.searchSubmitButton.Name = "searchSubmitButton";
            this.searchSubmitButton.Size = new System.Drawing.Size(420, 40);
            this.searchSubmitButton.TabIndex = 4;
            this.searchSubmitButton.Text = "Поиск в базе";
            this.searchSubmitButton.UseVisualStyleBackColor = true;
            this.searchSubmitButton.Click += new System.EventHandler(this.searchSubmitButton_Click);
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(14, 14);
            this.clientNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(108, 15);
            this.clientNameLabel.TabIndex = 5;
            this.clientNameLabel.Text = "Выберите клиента";
            // 
            // carNameLabel
            // 
            this.carNameLabel.AutoSize = true;
            this.carNameLabel.Location = new System.Drawing.Point(14, 72);
            this.carNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.carNameLabel.Name = "carNameLabel";
            this.carNameLabel.Size = new System.Drawing.Size(175, 15);
            this.carNameLabel.TabIndex = 6;
            this.carNameLabel.Text = "Выберите модель автомобиля";
            // 
            // startDateOfIssueLabel
            // 
            this.startDateOfIssueLabel.AutoSize = true;
            this.startDateOfIssueLabel.Location = new System.Drawing.Point(14, 130);
            this.startDateOfIssueLabel.Margin = new System.Windows.Forms.Padding(5);
            this.startDateOfIssueLabel.Name = "startDateOfIssueLabel";
            this.startDateOfIssueLabel.Size = new System.Drawing.Size(304, 15);
            this.startDateOfIssueLabel.TabIndex = 7;
            this.startDateOfIssueLabel.Text = "Укажите временной промежуток выдачи автомобиля";
            // 
            // dividerLabel
            // 
            this.dividerLabel.AutoSize = true;
            this.dividerLabel.Location = new System.Drawing.Point(219, 154);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(12, 15);
            this.dividerLabel.TabIndex = 8;
            this.dividerLabel.Text = "-";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 309);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.startDateOfIssueLabel);
            this.Controls.Add(this.carNameLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.searchSubmitButton);
            this.Controls.Add(this.secondDateOfIssueDateTimePicker);
            this.Controls.Add(this.firstDateOfIssueDateTimePicker);
            this.Controls.Add(this.searchCarComboBox);
            this.Controls.Add(this.searchClientComboBox);
            this.Name = "Form2";
            this.Text = "Поиск в базе";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox searchClientComboBox;
        private ComboBox searchCarComboBox;
        private DateTimePicker firstDateOfIssueDateTimePicker;
        private DateTimePicker secondDateOfIssueDateTimePicker;
        private Button searchSubmitButton;
        private Label clientNameLabel;
        private Label carNameLabel;
        private Label startDateOfIssueLabel;
        private Label dividerLabel;
    }
}