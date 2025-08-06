using SimpleStopwatch.Data;
using SimpleStopwatch.Forms;
using System.Diagnostics;

namespace SimpleStopwatch
{
    public partial class MainForm : Form
    {
        // Stopwatch from System.Diagnostics
        private Stopwatch Stopwatch { get; set; }

        public MainForm()
        {
            InitializeComponent();

            Stopwatch = new Stopwatch();
        }

        /// <summary>
        /// creates SQLite database
        /// displays greeting message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void StopWatch_Load(object sender, EventArgs e)
        {
            await InitializeDatabase();

            Greeting();
            greetingMessage.Select();
        }

        /// <summary>
        /// creates folder directory that holds the .sqlite file
        /// returns the path to the database
        /// </summary>
        /// <returns></returns>
        private static string GetDatabasePath()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string folderName = "SimpleStopwatch";
            string folderPath = Path.Combine(folder, folderName);

            Directory.CreateDirectory(folderPath);

            string fileName = "Simplestopwatch.sqlite";
            string filePath = Path.Combine(folderPath, fileName);

            return filePath;
        }

        /// <summary>
        /// creates SQLite database
        /// </summary>
        /// <returns></returns>
        private static async Task InitializeDatabase()
        {
            // path to the database
            string dbPath = GetDatabasePath();

            // creates the .sqlite file (database) and TimeLogs table
            await DatabaseHelper.InitializeDatabase(dbPath);
        }

        /// <summary>
        /// Allows the user to start, resume, or stop the stopwatch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text.Equals("Start") || startButton.Text.Equals("Resume"))
            {
                // starts the stopwatch
                Stopwatch.Start();

                // changes the button text to "Pause"
                startButton.Text = "Pause";
            }
            else
            {
                // the button text is set to "Pause" 
                // stop the stopwatch
                Stopwatch.Stop();

                // changes the button text to "Resume"
                startButton.Text = "Resume";
            }
        }

        /// <summary>
        /// Allows the user to restart the stopwatch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestartButton_Click(object sender, EventArgs e)
        {
            // ask the user to confirm stopwatch restart
            DialogResult result = MessageBox.Show("Reset the stopwatch?", "Simple Stopwatch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            // restarts the stopwatch
            Stopwatch.Restart();
            Stopwatch.Stop();

            // changes the button text to "Start"
            startButton.Text = "Start";
        }

        /// <summary>
        /// Displays a greeting message based on the time of the day
        /// </summary>
        private void Greeting()
        {
            if (DateTime.Now.Hour < 12)
                greetingMessage.Text = "Good Morning";
            else if (DateTime.Now.Hour < 17)
                greetingMessage.Text = "Good Afternoon";
            else
                greetingMessage.Text = "Good Evening";
        }


        /// <summary>
        /// Updates the greeting message 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshGreetingTimer_Tick(object sender, EventArgs e)
        {
            Greeting();
        }

        /// <summary>
        /// centers the time elapsed label
        /// </summary>
        private void CenterLabel()
        {
            // Center horizontally in the form
            timeElapsedLabel.Left = (this.ClientSize.Width - timeElapsedLabel.Width) / 2;
        }

        /// <summary>
        /// Updates the time elapsed label with the elapsed time from the stopwatch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            // gets the formatted timespan
            string timeSpan = TimeLog.FormatTimeSpan(Stopwatch.Elapsed);

            // set the time elapsed label to the formatted timespan
            timeElapsedLabel.Text = timeSpan;

            // centers label
            CenterLabel();
        }

        /// <summary>
        /// Saves the elapsed time to the TimeLogs tables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // the date time of when the log gets saved
                string savedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                var elapsedTime = Stopwatch.Elapsed;

                // total number of seconds that have elapsed
                double elapsedSeconds = elapsedTime.TotalSeconds;

                // formates the elapsed time
                string elapsedFormatted = TimeLog.FormatTimeSpan(elapsedTime);

                // creates a new TimeLog
                TimeLog timeLog = new()
                {
                    ElapsedSeconds = elapsedSeconds,
                    ElapsedFormatted = elapsedFormatted,
                    SavedAt = savedAt,
                };

                // gets the database path
                string dbPath = GetDatabasePath();

                // saves the time log to the database
                await DatabaseHelper.Insert(timeLog, dbPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error has occurred. Try again.\n\nError: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Only shows the time elapsed label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowOnlyTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideComponents();
        }

        /// <summary>
        /// Shows all components (greeting & buttons)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowComponents();
        }

        /// <summary>
        /// Hids UI components
        /// </summary>
        private void HideComponents()
        {
            resetButton.Hide();
            startButton.Hide();
            greetingMessage.Hide();
        }

        /// <summary>
        /// Shows UI components
        /// </summary>
        private void ShowComponents()
        {
            resetButton.Show();
            startButton.Show();
            greetingMessage.Show();
        }

        /// <summary>
        /// Shows the ViewTimeForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // gets the database path
            string dbPath = GetDatabasePath();

            // creates a new ViewForm
            ViewForm viewTimeForm = new(dbPath);

            // shows the form
            viewTimeForm.Show();
        }

        /// <summary>
        /// centers time elapsed label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterLabel();
        }
    }
}