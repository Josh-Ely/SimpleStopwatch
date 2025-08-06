namespace SimpleStopwatch.Forms
{
    partial class ViewForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            timeLogsDataGrid = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            TimeColumn = new DataGridViewTextBoxColumn();
            timeThisWeekLabel = new Label();
            DeleteAllLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)timeLogsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // timeLogsDataGrid
            // 
            timeLogsDataGrid.AllowUserToAddRows = false;
            timeLogsDataGrid.AllowUserToDeleteRows = false;
            timeLogsDataGrid.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            timeLogsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            timeLogsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            timeLogsDataGrid.Columns.AddRange(new DataGridViewColumn[] { IdColumn, dateColumn, TimeColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            timeLogsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            timeLogsDataGrid.EnableHeadersVisualStyles = false;
            timeLogsDataGrid.Location = new Point(12, 12);
            timeLogsDataGrid.Name = "timeLogsDataGrid";
            timeLogsDataGrid.ReadOnly = true;
            timeLogsDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            timeLogsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            timeLogsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            timeLogsDataGrid.Size = new Size(171, 269);
            timeLogsDataGrid.TabIndex = 0;
            timeLogsDataGrid.CellDoubleClick += TimeLogsDataGrid_CellDoubleClick;
            timeLogsDataGrid.KeyDown += TimeLogsDataGrid_KeyDown;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "ID";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Visible = false;
            // 
            // dateColumn
            // 
            dateColumn.HeaderText = "Date";
            dateColumn.Name = "dateColumn";
            dateColumn.ReadOnly = true;
            dateColumn.Width = 75;
            // 
            // TimeColumn
            // 
            TimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TimeColumn.HeaderText = "Time";
            TimeColumn.Name = "TimeColumn";
            TimeColumn.ReadOnly = true;
            // 
            // timeThisWeekLabel
            // 
            timeThisWeekLabel.AutoSize = true;
            timeThisWeekLabel.ForeColor = Color.White;
            timeThisWeekLabel.Location = new Point(12, 284);
            timeThisWeekLabel.Name = "timeThisWeekLabel";
            timeThisWeekLabel.Size = new Size(62, 15);
            timeThisWeekLabel.TabIndex = 1;
            timeThisWeekLabel.Text = "This week:";
            // 
            // DeleteAllLinkLabel
            // 
            DeleteAllLinkLabel.AutoSize = true;
            DeleteAllLinkLabel.LinkColor = SystemColors.ActiveCaption;
            DeleteAllLinkLabel.Location = new Point(128, 284);
            DeleteAllLinkLabel.Name = "DeleteAllLinkLabel";
            DeleteAllLinkLabel.Size = new Size(55, 15);
            DeleteAllLinkLabel.TabIndex = 2;
            DeleteAllLinkLabel.TabStop = true;
            DeleteAllLinkLabel.Text = "Delete all";
            DeleteAllLinkLabel.Visible = false;
            DeleteAllLinkLabel.LinkClicked += DeleteAllLinkLabel_LinkClicked;
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(194, 307);
            Controls.Add(DeleteAllLinkLabel);
            Controls.Add(timeThisWeekLabel);
            Controls.Add(timeLogsDataGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewForm";
            Text = "View";
            Load += ViewTimeForm_Load;
            ((System.ComponentModel.ISupportInitialize)timeLogsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView timeLogsDataGrid;
        private Label timeThisWeekLabel;
        private LinkLabel DeleteAllLinkLabel;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn dateColumn;
        private DataGridViewTextBoxColumn TimeColumn;
    }
}