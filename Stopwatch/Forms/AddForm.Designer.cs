namespace SimpleStopwatch.Forms
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            secondtextBox = new TextBox();
            label3 = new Label();
            minuteTextBox = new TextBox();
            label2 = new Label();
            hourTextBox = new TextBox();
            label1 = new Label();
            SaveButton = new Button();
            label4 = new Label();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
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
            label3.TabIndex = 10;
            label3.Text = "Seconds:";
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
            label2.TabIndex = 9;
            label2.Text = "Minutes:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Hours:";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Black;
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(12, 188);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(129, 30);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 13;
            label4.Text = "Date:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker.CalendarTitleForeColor = Color.AliceBlue;
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(12, 159);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(129, 23);
            dateTimePicker.TabIndex = 3;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(152, 224);
            Controls.Add(dateTimePicker);
            Controls.Add(label4);
            Controls.Add(SaveButton);
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
            Name = "AddForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Add";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox secondtextBox;
        private Label label3;
        private TextBox minuteTextBox;
        private Label label2;
        private TextBox hourTextBox;
        private Label label1;
        private Button SaveButton;
        private Label label4;
        private MaskedTextBox dateTimeTextBox;
        private DateTimePicker dateTimePicker;
    }
}