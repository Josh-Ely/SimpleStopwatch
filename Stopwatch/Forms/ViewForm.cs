using SimpleStopwatch.Data;
using System.Data;

namespace SimpleStopwatch.Forms
{
    public partial class ViewForm : Form
    {
        // path to the database
        private string DbPath { get; set; }

        // list of saved time logs
        private List<TimeLog> TimeLogs { get; set; }

        public ViewForm(string saveFile)
        {
            InitializeComponent();

            DbPath = saveFile;
            TimeLogs = [];
        }

        /// <summary>
        /// gets a list of saved time logs from the database
        /// adds time logs to the data grid
        /// calculates the total time for the current week 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewTimeForm_Load(object sender, EventArgs e)
        {
            try
            {
                TimeLogs = DatabaseHelper.GetTimeLogs(DbPath);

                AddRows();
                TotalWorked();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error has occurred. Try again.\n\nError: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// adds rows to the data frid
        /// </summary>
        private void AddRows()
        {
            // clears any existing rows
            timeLogsDataGrid.Rows.Clear();

            // loops through time logs
            foreach (var timeLog in TimeLogs)
            {
                // gets only the date portion 
                string saveAt = timeLog.SavedAt.Split(' ')[0].Trim();

                // adds a row
                timeLogsDataGrid.Rows.Add(timeLog.Id, saveAt, timeLog.ElapsedFormatted);
            }

            // removes any selection
            timeLogsDataGrid.ClearSelection();
        }

        /// <summary>
        /// calculates the total time for this week
        /// Monday - Sunday
        /// </summary>
        private void TotalWorked()
        {
            // current date
            DateTime now = DateTime.Now;

            // calculate how many days to subtract to get back to Monday
            int daysSinceMonday = ((int)now.DayOfWeek + 6) % 7; // Monday = 0

            DateTime weekStart = now.Date.AddDays(-daysSinceMonday);

            // gets logs for the current week
            var weeklyLogs = TimeLogs.Where(log => DateTime.TryParse(log.SavedAt, out var savedAt) && savedAt >= weekStart).ToList();

            // sums up the total number of seconds
            double totalSeconds = weeklyLogs.Sum(log => log.ElapsedSeconds);

            // convert to TimeSpan
            TimeSpan totalTime = TimeSpan.FromSeconds(totalSeconds);

            // format
            string formatted = TimeLog.FormatTimeSpan(totalTime);

            // update label text to display the total
            timeThisWeekLabel.Text = $"This week: {formatted}";
        }

        /// <summary>
        /// deletes all times logs from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DeleteAllLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // asks the user to confirm deletion
            DialogResult result = MessageBox.Show("Delete all saved time?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                // return out if the user selects "No"
                return;
            }

            // delete all records
            await DatabaseHelper.DeleteAllTimeLogs(DbPath);
        }

        /// <summary>
        /// deletes a time log when the user selects a row on the data grid and clicks the delete key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void TimeLogsDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            // checks if the clicked key was delete
            if (e.KeyCode != Keys.Delete)
            {
                // return out if the key was not delete
                return;
            }

            // gets the selected row
            DataGridViewRow selectedRow = timeLogsDataGrid.SelectedRows[0];

            // get the id associated with the row 
            int id = Convert.ToInt32(selectedRow.Cells["IdColumn"].Value);

            // deletes the time log from the database
            await DatabaseHelper.DeleteTimeLog(id, DbPath);

            // removes the selected row from the data grid
            timeLogsDataGrid.Rows.Remove(selectedRow);
        }

        /// <summary>
        /// displays the EditForm when a row is double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeLogsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // check for a proper row index
            if (e.RowIndex >= 0)
            {
                // hide this form
                Hide();

                // get the selected row
                var row = timeLogsDataGrid.Rows[e.RowIndex];

                // get the id associated with the row 
                int id = Convert.ToInt32(row.Cells["IdColumn"].Value);

                // create a new EditForm
                EditForm editTimeForm = new(id, DbPath, this);
                editTimeForm.ShowDialog(); // show the edit form

                // update the list of time logs after EditForm is closed
                TimeLogs = DatabaseHelper.GetTimeLogs(DbPath);

                // display updated time logs
                AddRows();

                // update total for this week
                TotalWorked();

                // reshow this form
                Show();
            }
        }
    }
}
