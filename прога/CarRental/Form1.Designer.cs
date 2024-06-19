namespace CarRental
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
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfIssueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfReturnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfActualReturnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordersDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.CostColumn,
            this.DiscountColumn,
            this.FineColumn,
            this.DateOfIssueColumn,
            this.DateOfReturnColumn,
            this.DateOfActualReturnColumn,
            this.ClientColumn,
            this.StatusColumn,
            this.CarColumn});
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.ordersDataGridView.Location = new System.Drawing.Point(241, 0);
            this.ordersDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowTemplate.Height = 25;
            this.ordersDataGridView.Size = new System.Drawing.Size(875, 495);
            this.ordersDataGridView.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.FillWeight = 32F;
            this.IdColumn.HeaderText = "Код";
            this.IdColumn.Name = "IdColumn";
            // 
            // CostColumn
            // 
            this.CostColumn.FillWeight = 69.61777F;
            this.CostColumn.HeaderText = "Стоимость";
            this.CostColumn.Name = "CostColumn";
            // 
            // DiscountColumn
            // 
            this.DiscountColumn.FillWeight = 69.61777F;
            this.DiscountColumn.HeaderText = "Сумма скидки";
            this.DiscountColumn.Name = "DiscountColumn";
            // 
            // FineColumn
            // 
            this.FineColumn.FillWeight = 69.61777F;
            this.FineColumn.HeaderText = "Сумма Штрафа";
            this.FineColumn.Name = "FineColumn";
            // 
            // DateOfIssueColumn
            // 
            this.DateOfIssueColumn.FillWeight = 69.61777F;
            this.DateOfIssueColumn.HeaderText = "Дата Выдачи";
            this.DateOfIssueColumn.Name = "DateOfIssueColumn";
            // 
            // DateOfReturnColumn
            // 
            this.DateOfReturnColumn.FillWeight = 69.61777F;
            this.DateOfReturnColumn.HeaderText = "Дата возврата";
            this.DateOfReturnColumn.Name = "DateOfReturnColumn";
            // 
            // DateOfActualReturnColumn
            // 
            this.DateOfActualReturnColumn.FillWeight = 69.61777F;
            this.DateOfActualReturnColumn.HeaderText = "Дата Фактического возврата";
            this.DateOfActualReturnColumn.Name = "DateOfActualReturnColumn";
            // 
            // ClientColumn
            // 
            this.ClientColumn.FillWeight = 69.61777F;
            this.ClientColumn.HeaderText = "Клиент";
            this.ClientColumn.Name = "ClientColumn";
            // 
            // StatusColumn
            // 
            this.StatusColumn.FillWeight = 69.61777F;
            this.StatusColumn.HeaderText = "Статус";
            this.StatusColumn.Name = "StatusColumn";
            // 
            // CarColumn
            // 
            this.CarColumn.FillWeight = 69.61777F;
            this.CarColumn.HeaderText = "Автомобиль";
            this.CarColumn.Name = "CarColumn";
            // 
            // viewAllButton
            // 
            this.viewAllButton.AutoSize = true;
            this.viewAllButton.Location = new System.Drawing.Point(19, 19);
            this.viewAllButton.Margin = new System.Windows.Forms.Padding(10);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(202, 40);
            this.viewAllButton.TabIndex = 1;
            this.viewAllButton.Text = "Загрузить данные";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.AutoSize = true;
            this.addNewItemButton.Location = new System.Drawing.Point(19, 436);
            this.addNewItemButton.Margin = new System.Windows.Forms.Padding(10);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(202, 40);
            this.addNewItemButton.TabIndex = 2;
            this.addNewItemButton.Text = "Добавить запись";
            this.addNewItemButton.UseVisualStyleBackColor = true;
            this.addNewItemButton.Click += new System.EventHandler(this.addNewItemButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(19, 79);
            this.searchButton.Margin = new System.Windows.Forms.Padding(10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(202, 40);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Поиск данных";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1116, 495);
            this.Controls.Add(this.addNewItemButton);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.viewAllButton);
            this.Name = "Form1";
            this.Text = "Управление заказами";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ordersDataGridView;
        private Button viewAllButton;
        private Button addNewItemButton;
        private Button searchButton;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn CostColumn;
        private DataGridViewTextBoxColumn DiscountColumn;
        private DataGridViewTextBoxColumn FineColumn;
        private DataGridViewTextBoxColumn DateOfIssueColumn;
        private DataGridViewTextBoxColumn DateOfReturnColumn;
        private DataGridViewTextBoxColumn DateOfActualReturnColumn;
        private DataGridViewTextBoxColumn ClientColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewTextBoxColumn CarColumn;
    }
}