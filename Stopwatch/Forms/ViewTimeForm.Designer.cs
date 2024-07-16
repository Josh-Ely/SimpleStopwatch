namespace SimpleStopwatch.Forms
{
    partial class ViewTimeForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTimeForm));
            viewTimeDataGrid = new DataGridView();
            dateColumn = new DataGridViewTextBoxColumn();
            TimeColumn = new DataGridViewTextBoxColumn();
            totalItemsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)viewTimeDataGrid).BeginInit();
            SuspendLayout();
            // 
            // viewTimeDataGrid
            // 
            viewTimeDataGrid.AllowUserToAddRows = false;
            viewTimeDataGrid.AllowUserToDeleteRows = false;
            viewTimeDataGrid.BackgroundColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewTimeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            viewTimeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewTimeDataGrid.Columns.AddRange(new DataGridViewColumn[] { dateColumn, TimeColumn });
            viewTimeDataGrid.EnableHeadersVisualStyles = false;
            viewTimeDataGrid.Location = new Point(12, 12);
            viewTimeDataGrid.Name = "viewTimeDataGrid";
            viewTimeDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            viewTimeDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            viewTimeDataGrid.RowTemplate.Height = 25;
            viewTimeDataGrid.Size = new Size(247, 348);
            viewTimeDataGrid.TabIndex = 0;
            // 
            // dateColumn
            // 
            dateColumn.HeaderText = "Date";
            dateColumn.Name = "dateColumn";
            // 
            // TimeColumn
            // 
            TimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TimeColumn.HeaderText = "Time";
            TimeColumn.Name = "TimeColumn";
            // 
            // totalItemsLabel
            // 
            totalItemsLabel.AutoSize = true;
            totalItemsLabel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalItemsLabel.ForeColor = Color.White;
            totalItemsLabel.Location = new Point(12, 363);
            totalItemsLabel.Name = "totalItemsLabel";
            totalItemsLabel.Size = new Size(40, 17);
            totalItemsLabel.TabIndex = 1;
            totalItemsLabel.Text = "Items";
            // 
            // ViewTimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(270, 388);
            Controls.Add(totalItemsLabel);
            Controls.Add(viewTimeDataGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewTimeForm";
            Text = "View";
            Load += ViewTimeForm_Load;
            ((System.ComponentModel.ISupportInitialize)viewTimeDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView viewTimeDataGrid;
        private DataGridViewTextBoxColumn dateColumn;
        private DataGridViewTextBoxColumn TimeColumn;
        private Label totalItemsLabel;
    }
}