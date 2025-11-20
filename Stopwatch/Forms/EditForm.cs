using SimpleStopwatch.Data;

namespace SimpleStopwatch.Forms
{
    public partial class EditForm : Form
    {
        // Id for the time log that is to be updated
        private int Id { get; set; }

        // path to the database
        private string DbPath { get; set; }

        // ViewForm - used to set the location of this form 
        private ViewForm ViewForm { get; set; }

        private TimeSpan ExistingTimeSpan { get; set; }

        public EditForm(TimeSpan existingTimeSpan, ViewForm viewForm, int id, string dbPath)
        {
            InitializeComponent();

            Id = id;
            DbPath = dbPath;
            ViewForm = viewForm;
            ExistingTimeSpan = existingTimeSpan;
        }

        /// <summary>
        /// set the UpdateButton as the AcceptButton (click enter to activate)
        /// sets the location of this form to the location from the ViewForm
        /// displays the TimeSpan values the user is editing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditForm_Load(object sender, EventArgs e)
        {
            AcceptButton = UpdateButton;
            this.Location = ViewForm.Location;

            hourTextBox.Text = ((int)ExistingTimeSpan.TotalHours).ToString();
            minuteTextBox.Text = ExistingTimeSpan.Minutes.ToString();
            secondtextBox.Text = ExistingTimeSpan.Seconds.ToString();
        }

        /// <summary>
        /// Updates a time log based on user entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            // gets value in string format
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

            // converts strings to intergers 
            _ = int.TryParse(hourString, out int hour);
            _ = int.TryParse(minuteString, out int minute);
            _ = int.TryParse(secondString, out int second);

            // creates a TimeSpan object based interger conversions 
            TimeSpan updatedTimeSpan = new(hour, minute, second);

            // updates the time log
            await DatabaseHelper.UpdateTimeLog(Id, updatedTimeSpan, DbPath);

            // closes out of this form
            Close();
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
    }
}
