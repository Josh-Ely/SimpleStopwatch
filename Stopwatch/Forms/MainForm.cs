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
            ApplySavedSize();

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
        /// allows the user to start, resume, or stop the stopwatch
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
        /// allows the user to restart the stopwatch
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
        /// displays a greeting message based on the time of the day
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
        /// updates the greeting message 
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
        /// updates the time elapsed label with the elapsed time from the stopwatch
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
        /// saves the elapsed time to the TimeLogs tables
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
        /// only shows the time elapsed label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowOnlyTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideComponents();
        }

        /// <summary>
        /// shows all components (greeting & buttons)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowComponents();
        }

        /// <summary>
        /// hides UI components
        /// </summary>
        private void HideComponents()
        {
            resetButton.Hide();
            startButton.Hide();
            greetingMessage.Hide();
        }

        /// <summary>
        /// shows UI components
        /// </summary>
        private void ShowComponents()
        {
            resetButton.Show();
            startButton.Show();
            greetingMessage.Show();
        }

        /// <summary>
        /// shows the ViewTimeForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // gets the database path
            string dbPath = GetDatabasePath();

            // creates a new ViewForm
            ViewForm viewTimeForm = new(dbPath);

            // sets its location
            HandleChildFormLocation(viewTimeForm);

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

        /// <summary>
        /// updates the "Size" variable in the Settings table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MaintainSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // gets the database path
            string dbPath = GetDatabasePath();

            // gets the check state of the "Maintain Size" menu item
            bool isChecked = maintainSizeToolStripMenuItem.Checked;
            if (isChecked)
            {
                // gets the current size of this form
                string currentSize = $"{Size.Width},{Size.Height}";

                // updates the "Size" variable in the Settings table
                await DatabaseHelper.InsertSetting("Size", currentSize, dbPath);
            }
            else
            {
                // removes the value for the "Size" variable in the Settings table
                await DatabaseHelper.InsertSetting("Size", null, dbPath);
            }
        }

        /// <summary>
        /// changes the size of this form during the load event if the "Size" variable has a value in the Settings table
        /// </summary>
        private void ApplySavedSize()
        {
            // gets the database path
            string dbPath = GetDatabasePath();
            bool checkState = false;

            // gets the "Size" setting from the Settings table
            var setting = DatabaseHelper.GetSetting("Size", dbPath);
            if (setting is not null && !string.IsNullOrEmpty(setting.Value))
            {
                // splits the width and height values
                string[] sizeValues = setting.Value.Split(',');

                // converts the width and height values to integers
                int width = Convert.ToInt32(sizeValues[0]);
                int height = Convert.ToInt32(sizeValues[1]);

                // sets the size of this form
                Size size = new(width, height);
                Size = size;

                checkState = true;
            }

            // updates the check state of the "Maintain Size" menu item
            maintainSizeToolStripMenuItem.Checked = checkState;
        }

        /// <summary>
        /// shows the AddForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // gets the database path
            string dbPath = GetDatabasePath();

            // creates a new AddForm
            AddForm addForm = new(dbPath);

            // sets its location
            HandleChildFormLocation(addForm);

            // shows the form
            addForm.Show();
        }

        /// <summary>
        /// places the main form to the top-left of the screen it is currently on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlaceTopLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Find the screen that currently contains the form
            Screen currentScreen = Screen.FromControl(this);

            // Get the working area
            Rectangle workingArea = currentScreen.WorkingArea;

            // Move form to the top-left of that screen
            Location = new Point(workingArea.Left, workingArea.Top);
        }

        /// <summary>
        /// sets the location of a child form based on the location of this main form
        /// </summary>
        /// <param name="form"></param>
        private void HandleChildFormLocation(Form form)
        {
            int gapBetweenMainAndChild = 10;

            // Get the screen where the main form currently is
            Screen currentScreen = Screen.FromControl(this);
            Rectangle workingArea = currentScreen.WorkingArea;

            // Check if it fits on the right
            int rightPos = this.Right + gapBetweenMainAndChild;
            if (rightPos + form.Width <= workingArea.Right)
            {
                // Place on the right
                form.Location = new Point(rightPos, this.Top);
            }
            else
            {
                // Check if it fits on the left
                int leftPos = this.Left - form.Width - gapBetweenMainAndChild;
                if (leftPos >= workingArea.Left)
                {
                    // Place on the left
                    form.Location = new Point(leftPos, this.Top);
                }
                else
                {
                    // Otherwise place center screen
                    form.StartPosition = FormStartPosition.CenterScreen;
                }
            }
        }
    }
}