namespace SimpleStopwatch.Forms
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            label1 = new Label();
            hourTextBox = new TextBox();
            minuteTextBox = new TextBox();
            label2 = new Label();
            secondtextBox = new TextBox();
            label3 = new Label();
            UpdateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Hours:";
            // 
            // hourTextBox
            // 
            hourTextBox.BackColor = Color.Black;
            hourTextBox.ForeColor = Color.White;
            hourTextBox.Location = new Point(12, 27);
            hourTextBox.Name = "hourTextBox";
            hourTextBox.Size = new Size(129, 23);
            hourTextBox.TabIndex = 0;
            hourTextBox.TextAlign = HorizontalAlignment.Center;
            hourTextBox.KeyPress += HourTextBox_KeyPress;
            // 
            // minuteTextBox
            // 
            minuteTextBox.BackColor = Color.Black;
            minuteTextBox.ForeColor = Color.White;
            minuteTextBox.Location = new Point(12, 71);
            minuteTextBox.Name = "minuteTextBox";
            minuteTextBox.Size = new Size(129, 23);
            minuteTextBox.TabIndex = 1;
            minuteTextBox.TextAlign = HorizontalAlignment.Center;
            minuteTextBox.KeyPress += MinuteTextBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Minutes:";
            // 
            // secondtextBox
            // 
            secondtextBox.BackColor = Color.Black;
            secondtextBox.ForeColor = Color.White;
            secondtextBox.Location = new Point(12, 115);
            secondtextBox.Name = "secondtextBox";
            secondtextBox.Size = new Size(129, 23);
            secondtextBox.TabIndex = 2;
            secondtextBox.TextAlign = HorizontalAlignment.Center;
            secondtextBox.KeyPress += SecondtextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Seconds:";
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.Black;
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(12, 144);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(129, 30);
            UpdateButton.TabIndex = 3;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(152, 183);
            Controls.Add(UpdateButton);
            Controls.Add(secondtextBox);
            Controls.Add(label3);
            Controls.Add(minuteTextBox);
            Controls.Add(label2);
            Controls.Add(hourTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox hourTextBox;
        private TextBox minuteTextBox;
        private Label label2;
        private TextBox secondtextBox;
        private Label label3;
        private Button UpdateButton;
    }
}