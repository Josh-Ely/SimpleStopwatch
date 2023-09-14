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
            titleBarPanel = new Panel();
            minimizeButton = new Button();
            greetingMessage = new Label();
            closeButton = new Button();
            RefreshGreetingTimer = new System.Windows.Forms.Timer(components);
            MainTimer = new System.Windows.Forms.Timer(components);
            timeElapsedLabel = new Label();
            titleBarPanel.SuspendLayout();
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
            resetButton.Location = new Point(210, 114);
            resetButton.Margin = new Padding(1);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(96, 38);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += RestartButton_Click;
            // 
            // titleBarPanel
            // 
            titleBarPanel.BackColor = Color.Black;
            titleBarPanel.Controls.Add(minimizeButton);
            titleBarPanel.Controls.Add(greetingMessage);
            titleBarPanel.Location = new Point(0, 0);
            titleBarPanel.Margin = new Padding(1);
            titleBarPanel.Name = "titleBarPanel";
            titleBarPanel.Size = new Size(317, 29);
            titleBarPanel.TabIndex = 10;
            titleBarPanel.MouseDown += TitleBarPanel_MouseDown;
            titleBarPanel.MouseMove += TitleBarPanel_MouseMove;
            titleBarPanel.MouseUp += TitleBarPanel_MouseUp;
            // 
            // minimizeButton
            // 
            minimizeButton.BackColor = Color.Transparent;
            minimizeButton.FlatAppearance.BorderColor = Color.Black;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            minimizeButton.ForeColor = Color.White;
            minimizeButton.Image = (Image)resources.GetObject("minimizeButton.Image");
            minimizeButton.Location = new Point(262, -1);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(29, 27);
            minimizeButton.TabIndex = 12;
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += MinimizeButton_Click;
            minimizeButton.MouseEnter += MinimizeButton_MouseEnter;
            minimizeButton.MouseLeave += MinimizeButton_MouseLeave;
            // 
            // greetingMessage
            // 
            greetingMessage.AutoSize = true;
            greetingMessage.Font = new Font("Trebuchet MS", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            greetingMessage.ForeColor = Color.White;
            greetingMessage.Location = new Point(5, 4);
            greetingMessage.Margin = new Padding(1, 0, 1, 0);
            greetingMessage.Name = "greetingMessage";
            greetingMessage.Size = new Size(83, 24);
            greetingMessage.TabIndex = 11;
            greetingMessage.Text = "Greeting";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Transparent;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(291, -1);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(29, 27);
            closeButton.TabIndex = 11;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += CloseButton_Click;
            closeButton.MouseEnter += CloseButton_MouseEnter;
            closeButton.MouseLeave += CloseButton_MouseLeave;
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
            timeElapsedLabel.Location = new Point(14, 30);
            timeElapsedLabel.Name = "timeElapsedLabel";
            timeElapsedLabel.Size = new Size(293, 83);
            timeElapsedLabel.TabIndex = 17;
            timeElapsedLabel.Text = "00:00:00";
            timeElapsedLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // StopWatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(318, 166);
            Controls.Add(timeElapsedLabel);
            Controls.Add(closeButton);
            Controls.Add(resetButton);
            Controls.Add(startButton);
            Controls.Add(titleBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            Name = "StopWatchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Stopwatch";
            Load += StopWatch_Load;
            titleBarPanel.ResumeLayout(false);
            titleBarPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button startButton;
        private Button resetButton;
        private Panel titleBarPanel;
        private System.Windows.Forms.Timer RefreshGreetingTimer;
        private Label greetingMessage;
        private System.Windows.Forms.Timer MainTimer;
        private Button closeButton;
        private Button minimizeButton;
        private Label timeElapsedLabel;
    }
}