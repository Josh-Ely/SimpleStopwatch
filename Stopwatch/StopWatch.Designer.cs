namespace WorkCounter
{
    partial class StopWatch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatch));
            this.startButton = new System.Windows.Forms.Button();
            this.timeDisplayLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.greetingMessage = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.RefreshGreetingTimer = new System.Windows.Forms.Timer(this.components);
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(19, 111);
            this.startButton.Margin = new System.Windows.Forms.Padding(1);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 38);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timeDisplayLabel
            // 
            this.timeDisplayLabel.AutoSize = true;
            this.timeDisplayLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeDisplayLabel.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeDisplayLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.timeDisplayLabel.Location = new System.Drawing.Point(19, 30);
            this.timeDisplayLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.timeDisplayLabel.Name = "timeDisplayLabel";
            this.timeDisplayLabel.Size = new System.Drawing.Size(287, 81);
            this.timeDisplayLabel.TabIndex = 3;
            this.timeDisplayLabel.Text = "00:00:00";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(203, 111);
            this.resetButton.Margin = new System.Windows.Forms.Padding(1);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(96, 38);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.Black;
            this.titleBarPanel.Controls.Add(this.greetingMessage);
            this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarPanel.Margin = new System.Windows.Forms.Padding(1);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(313, 29);
            this.titleBarPanel.TabIndex = 10;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            this.titleBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseMove);
            this.titleBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseUp);
            // 
            // greetingMessage
            // 
            this.greetingMessage.AutoSize = true;
            this.greetingMessage.Font = new System.Drawing.Font("Trebuchet MS", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greetingMessage.ForeColor = System.Drawing.Color.White;
            this.greetingMessage.Location = new System.Drawing.Point(5, 4);
            this.greetingMessage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.greetingMessage.Name = "greetingMessage";
            this.greetingMessage.Size = new System.Drawing.Size(83, 24);
            this.greetingMessage.TabIndex = 11;
            this.greetingMessage.Text = "Greeting";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(284, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 27);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.AutoSize = true;
            this.minimizeLabel.ForeColor = System.Drawing.Color.White;
            this.minimizeLabel.Location = new System.Drawing.Point(256, 0);
            this.minimizeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.minimizeLabel.Size = new System.Drawing.Size(23, 25);
            this.minimizeLabel.TabIndex = 11;
            this.minimizeLabel.Text = "__";
            this.minimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            this.minimizeLabel.MouseEnter += new System.EventHandler(this.MinimizeLabel_MouseEnter);
            this.minimizeLabel.MouseLeave += new System.EventHandler(this.MinimizeLabel_MouseLeave);
            // 
            // RefreshGreetingTimer
            // 
            this.RefreshGreetingTimer.Enabled = true;
            this.RefreshGreetingTimer.Interval = 60000;
            this.RefreshGreetingTimer.Tick += new System.EventHandler(this.RefreshGreetingTimer_Tick);
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(313, 163);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timeDisplayLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "StopWatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Stopwatch";
            this.Load += new System.EventHandler(this.StopWatch_Load);
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button startButton;
        private Label timeDisplayLabel;
        private Button resetButton;
        private Panel titleBarPanel;
        private Label minimizeLabel;
        private System.Windows.Forms.Timer RefreshGreetingTimer;
        private Label greetingMessage;
        private System.Windows.Forms.Timer MainTimer;
        private Button closeButton;
    }
}