namespace SimpleStopwatch
{
    partial class SimpleStopwatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleStopwatchForm));
            startButton = new Button();
            resetButton = new Button();
            greetingMessage = new Label();
            RefreshGreetingTimer = new System.Windows.Forms.Timer(components);
            MainTimer = new System.Windows.Forms.Timer(components);
            timeElapsedLabel = new Label();
            simpleStopwatchContextMenuStrip = new ContextMenuStrip(components);
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            showOnlyTimeToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            simpleStopwatchContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.Black;
            startButton.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(13, 114);
            startButton.Margin = new Padding(1);
            startButton.Name = "startButton";
            startButton.Size = new Size(96, 38);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Black;
            resetButton.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = Color.White;
            resetButton.Location = new Point(186, 114);
            resetButton.Margin = new Padding(1);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(96, 38);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += RestartButton_Click;
            // 
            // greetingMessage
            // 
            greetingMessage.AutoSize = true;
            greetingMessage.Font = new Font("Trebuchet MS", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            greetingMessage.ForeColor = Color.White;
            greetingMessage.Location = new Point(4, 6);
            greetingMessage.Margin = new Padding(1, 0, 1, 0);
            greetingMessage.Name = "greetingMessage";
            greetingMessage.Size = new Size(83, 24);
            greetingMessage.TabIndex = 11;
            greetingMessage.Text = "Greeting";
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
            // timeElapsedLabel
            // 
            timeElapsedLabel.AutoSize = true;
            timeElapsedLabel.Font = new Font("Microsoft YaHei UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            timeElapsedLabel.ForeColor = Color.White;
            timeElapsedLabel.Location = new Point(5, 30);
            timeElapsedLabel.Name = "timeElapsedLabel";
            timeElapsedLabel.Size = new Size(293, 83);
            timeElapsedLabel.TabIndex = 17;
            timeElapsedLabel.Text = "00:00:00";
            timeElapsedLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // simpleStopwatchContextMenuStrip
            // 
            simpleStopwatchContextMenuStrip.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem, saveAsToolStripMenuItem, showOnlyTimeToolStripMenuItem, resetToolStripMenuItem });
            simpleStopwatchContextMenuStrip.Name = "contextMenuStrip1";
            simpleStopwatchContextMenuStrip.Size = new Size(161, 92);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = Color.Black;
            saveToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(160, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.BackColor = Color.Black;
            saveAsToolStripMenuItem.ForeColor = Color.White;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(160, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // showOnlyTimeToolStripMenuItem
            // 
            showOnlyTimeToolStripMenuItem.BackColor = Color.Black;
            showOnlyTimeToolStripMenuItem.ForeColor = Color.White;
            showOnlyTimeToolStripMenuItem.Name = "showOnlyTimeToolStripMenuItem";
            showOnlyTimeToolStripMenuItem.Size = new Size(160, 22);
            showOnlyTimeToolStripMenuItem.Text = "Show Only Time";
            showOnlyTimeToolStripMenuItem.Click += ShowOnlyTimeToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.BackColor = Color.Black;
            resetToolStripMenuItem.ForeColor = Color.White;
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(160, 22);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += ResetToolStripMenuItem_Click;
            // 
            // SimpleStopwatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(293, 163);
            ContextMenuStrip = simpleStopwatchContextMenuStrip;
            Controls.Add(greetingMessage);
            Controls.Add(timeElapsedLabel);
            Controls.Add(resetButton);
            Controls.Add(startButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            MaximizeBox = false;
            Name = "SimpleStopwatchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Stopwatch";
            Load += StopWatch_Load;
            simpleStopwatchContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button startButton;
        private Button resetButton;
        private System.Windows.Forms.Timer RefreshGreetingTimer;
        private Label greetingMessage;
        private System.Windows.Forms.Timer MainTimer;
        private Label timeElapsedLabel;
        private ContextMenuStrip simpleStopwatchContextMenuStrip;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem showOnlyTimeToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
    }
}