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

        public EditForm(int id, string dbPath, ViewForm viewForm)
        {
            InitializeComponent();

            Id = id;
            DbPath = dbPath;
            ViewForm = viewForm;
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

        /// <summary>
        /// set the UpdateButton as the AcceptButton (click enter to activate)
        /// sets the location of this form to the location from the ViewForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditForm_Load(object sender, EventArgs e)
        {
            AcceptButton = UpdateButton;
            this.Location = ViewForm.Location;
        }
    }
}
