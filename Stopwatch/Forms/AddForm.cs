using SimpleStopwatch.Data;

namespace SimpleStopwatch.Forms
{
    public partial class AddForm : Form
    {
        // path to the database
        private string DbPath { get; set; }

        public AddForm(string dbPath)
        {
            InitializeComponent();
            DbPath = dbPath;
        }

        /// <summary>
        /// saves the time log to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            // gets values in string format
            string hourString = hourTextBox.Text.Trim();
            string minuteString = minuteTextBox.Text.Trim();
            string secondString = secondtextBox.Text.Trim();

            // checks if all text boxes are empty
            if (string.IsNullOrEmpty(hourString) && string.IsNullOrEmpty(minuteString) && string.IsNullOrEmpty(secondString))
            {
                // prompts user to continue or not
                DialogResult result = MessageBox.Show("No values were entered.\nWould you like to continue?", "Simple Stopwatch", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    // selects the hour text box and returns out of this method if user chooses not to continue
                    hourTextBox.Select();
                    return;
                }
            }

            // gets the selected date from the date time picker
            DateTime selectedDateTime = dateTimePicker.Value;

            // converts strings to intergers 
            _ = int.TryParse(hourString, out int hour);
            _ = int.TryParse(minuteString, out int minute);
            _ = int.TryParse(secondString, out int second);

            // creates a TimeSpan object based interger conversions 
            TimeSpan updatedTimeSpan = new(hour, minute, second);

            string elapsedFormatted = TimeLog.FormatTimeSpan(updatedTimeSpan);

            TimeLog timeLog = new()
            {
                ElapsedFormatted = elapsedFormatted,
                ElapsedSeconds = updatedTimeSpan.TotalSeconds,
                SavedAt = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss"),
            };

            // inserts the new time log into the database
            await DatabaseHelper.Insert(timeLog, DbPath);

            // resets the form for new input
            ResetForm();
        }

        /// <summary>
        /// resets the form to default values
        /// </summary>
        private void ResetForm()
        {
            hourTextBox.Clear();
            minuteTextBox.Clear();
            secondtextBox.Clear();
            dateTimePicker.Value = DateTime.Now;

            hourTextBox.Select();
        }

        /// <summary>
        /// only allows numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void MinuteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void SecondtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        /// <summary>
        /// sets the accept button to the save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddForm_Load(object sender, EventArgs e)
        {
            AcceptButton = SaveButton;
        }
    }
}
