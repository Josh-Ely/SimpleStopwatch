namespace SimpleStopwatch
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            RefreshGreetingTimer = new System.Windows.Forms.Timer(components);
            MainTimer = new System.Windows.Forms.Timer(components);
            SimpleStopwatchContextMenuStrip = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            maintainSizeToolStripMenuItem = new ToolStripMenuItem();
            placeTopLeftToolStripMenuItem = new ToolStripMenuItem();
            showOnlyTimeToolStripMenuItem = new ToolStripMenuItem();
            SaveFileDialog = new SaveFileDialog();
            OpenFileDialog = new OpenFileDialog();
            resetButton = new Button();
            startButton = new Button();
            timeElapsedLabel = new Label();
            greetingMessage = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            SimpleStopwatchContextMenuStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // RefreshGreetingTimer
            // 
            RefreshGreetingTimer.Enabled = true;
            RefreshGreetingTimer.Interval = 60000;
            RefreshGreetingTimer.Tick += RefreshGreetingTimer_Tick;
            // 
            // MainTimer
            // 
            MainTimer.Enabled = true;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // SimpleStopwatchContextMenuStrip
            // 
            SimpleStopwatchContextMenuStrip.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, saveToolStripMenuItem, viewToolStripMenuItem, resetToolStripMenuItem, maintainSizeToolStripMenuItem, placeTopLeftToolStripMenuItem, showOnlyTimeToolStripMenuItem });
            SimpleStopwatchContextMenuStrip.Name = "contextMenuStrip1";
            SimpleStopwatchContextMenuStrip.Size = new Size(169, 158);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.BackColor = Color.Black;
            addToolStripMenuItem.ForeColor = Color.White;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(168, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += AddToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = Color.Black;
            saveToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 9F);
            saveToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(168, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.BackColor = Color.Black;
            viewToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 9F);
            viewToolStripMenuItem.ForeColor = Color.White;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(168, 22);
            viewToolStripMenuItem.Text = "View ";
            viewToolStripMenuItem.Click += ViewToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.BackColor = Color.Black;
            resetToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 9F);
            resetToolStripMenuItem.ForeColor = Color.White;
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(168, 22);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += ResetToolStripMenuItem_Click;
            // 
            // maintainSizeToolStripMenuItem
            // 
            maintainSizeToolStripMenuItem.BackColor = Color.Black;
            maintainSizeToolStripMenuItem.CheckOnClick = true;
            maintainSizeToolStripMenuItem.ForeColor = Color.White;
            maintainSizeToolStripMenuItem.Name = "maintainSizeToolStripMenuItem";
            maintainSizeToolStripMenuItem.Size = new Size(168, 22);
            maintainSizeToolStripMenuItem.Text = "Maintain Size";
            maintainSizeToolStripMenuItem.Click += MaintainSizeToolStripMenuItem_Click;
            // 
            // placeTopLeftToolStripMenuItem
            // 
            placeTopLeftToolStripMenuItem.BackColor = Color.Black;
            placeTopLeftToolStripMenuItem.ForeColor = Color.White;
            placeTopLeftToolStripMenuItem.Name = "placeTopLeftToolStripMenuItem";
            placeTopLeftToolStripMenuItem.Size = new Size(168, 22);
            placeTopLeftToolStripMenuItem.Text = "Place Top Left";
            placeTopLeftToolStripMenuItem.Click += PlaceTopLeftToolStripMenuItem_Click;
            // 
            // showOnlyTimeToolStripMenuItem
            // 
            showOnlyTimeToolStripMenuItem.BackColor = Color.Black;
            showOnlyTimeToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 9F);
            showOnlyTimeToolStripMenuItem.ForeColor = Color.White;
            showOnlyTimeToolStripMenuItem.Name = "showOnlyTimeToolStripMenuItem";
            showOnlyTimeToolStripMenuItem.Size = new Size(168, 22);
            showOnlyTimeToolStripMenuItem.Text = "Show Only Time";
            showOnlyTimeToolStripMenuItem.Click += ShowOnlyTimeToolStripMenuItem_Click;
            // 
            // SaveFileDialog
            // 
            SaveFileDialog.DefaultExt = "txt";
            SaveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Black;
            resetButton.Dock = DockStyle.Fill;
            resetButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetButton.ForeColor = Color.White;
            resetButton.Location = new Point(117, 1);
            resetButton.Margin = new Padding(1);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(87, 33);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += RestartButton_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Black;
            startButton.Dock = DockStyle.Fill;
            startButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(1, 1);
            startButton.Margin = new Padding(1);
            startButton.Name = "startButton";
            startButton.Size = new Size(85, 33);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartButton_Click;
            // 
            // timeElapsedLabel
            // 
            timeElapsedLabel.AutoSize = true;
            timeElapsedLabel.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeElapsedLabel.ForeColor = Color.White;
            timeElapsedLabel.Location = new Point(35, 26);
            timeElapsedLabel.Name = "timeElapsedLabel";
            timeElapsedLabel.Size = new Size(140, 62);
            timeElapsedLabel.TabIndex = 17;
            timeElapsedLabel.Text = "Time";
            timeElapsedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // greetingMessage
            // 
            greetingMessage.AutoSize = true;
            greetingMessage.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greetingMessage.ForeColor = Color.White;
            greetingMessage.Location = new Point(4, 6);
            greetingMessage.Margin = new Padding(1, 0, 1, 0);
            greetingMessage.Name = "greetingMessage";
            greetingMessage.Size = new Size(67, 20);
            greetingMessage.TabIndex = 11;
            greetingMessage.Text = "Greeting";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.7807426F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4385033F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.78075F));
            tableLayoutPanel1.Controls.Add(resetButton, 2, 0);
            tableLayoutPanel1.Controls.Add(startButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 91);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(205, 35);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(205, 126);
            ContextMenuStrip = SimpleStopwatchContextMenuStrip;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(greetingMessage);
            Controls.Add(timeElapsedLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            MaximizeBox = false;
            MaximumSize = new Size(554, 202);
            MinimumSize = new Size(221, 165);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Stopwatch";
            Load += StopWatch_Load;
            Resize += MainForm_Resize;
            SimpleStopwatchContextMenuStrip.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer RefreshGreetingTimer;
        private System.Windows.Forms.Timer MainTimer;
        private ContextMenuStrip SimpleStopwatchContextMenuStrip;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem showOnlyTimeToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private SaveFileDialog SaveFileDialog;
        private OpenFileDialog OpenFileDialog;
        private Button resetButton;
        private Button startButton;
        private Label timeElapsedLabel;
        private Label greetingMessage;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem maintainSizeToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem placeTopLeftToolStripMenuItem;
    }
}