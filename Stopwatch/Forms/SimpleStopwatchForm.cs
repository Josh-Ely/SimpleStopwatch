using SimpleStopwatch.Forms;
using System.Diagnostics;

namespace SimpleStopwatch
{
    public partial class SimpleStopwatchForm : Form
    {
        private Stopwatch Stopwatch { get; set; }

        public SimpleStopwatchForm()
        {
            InitializeComponent();
            Stopwatch = new Stopwatch();
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

                // changes the button text so user knows the timer can be paused once it starts
                startButton.Text = "Pause";
            }
            else
            {
                // the text of the button is "Pause" so the stopwatch is stopped
                Stopwatch.Stop();

                // changes the button text so user knows the stopwatch can be resumed after its paused 
                startButton.Text = "Resume";
            }
        }

        /// <summary>
        /// Allows the user to reset/restart the stopwatch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestartButton_Click(object sender, EventArgs e)
        {
            // shows a message box asking the user to confirm they want to restart the stopwatch
            DialogResult result = MessageBox.Show("Reset the stopwatch?", "Simple Stopwatch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // restarts the stopwatch
                Stopwatch.Restart();
                Stopwatch.Stop();

                // changes button text to "Start" so the user knows the stopwatch can be started again
                startButton.Text = "Start";
            }
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
        /// Shows the greeting when the form first loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopWatch_Load(object sender, EventArgs e)
        {
            Greeting();

            greetingMessage.Select();
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
        /// Updates the timeElapsedLabel with the elapsed time from the stopwatch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            timeElapsedLabel.Text = string.Format("{0:hh\\:mm\\:ss}", Stopwatch.Elapsed);
        }

        /// <summary>
        /// Allows the user to save time to an existing file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // gets the path to the save file
            string saveFile = Properties.Settings.Default.FilePath;

            // checks if the save file is null
            if (!string.IsNullOrEmpty(saveFile))
            {
                // saves time to the file
                SaveTime(saveFile);
            }
            else
            {
                // if so, inform the user that a save file needs to be created in order to save time
                DialogResult messageBoxResult = MessageBox.Show("In order to save time, a save file must be created.\nClick 'OK' to create a new save file.", "Save File", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (messageBoxResult == DialogResult.OK)
                {
                    // show the save file dialog
                    DialogResult saveFileDialogResult = SaveFileDialog.ShowDialog();

                    // checks if the user click 'OK' on the save file dialog
                    if (saveFileDialogResult == DialogResult.OK)
                    {
                        using FileStream fileStream = File.Create(SaveFileDialog.FileName);
                        SaveFilePathSetting(SaveFileDialog.FileName);
                    }

                    // gets the path to the new save file
                    string newSaveFile = Properties.Settings.Default.FilePath;

                    // saves time to the new file
                    SaveTime(newSaveFile);
                }
            }
        }

        private void SaveTime(string saveFile)
        {
            using StreamWriter writer = new(saveFile, true);
            writer.WriteLine(DateTime.Now.ToString("MM/dd/yyyy - ") + string.Format("{0:hh\\:mm\\:ss}", Stopwatch.Elapsed));
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
        /// Makes components invisible
        /// </summary>
        private void HideComponents()
        {
            resetButton.Hide();
            startButton.Hide();
            greetingMessage.Hide();
        }

        /// <summary>
        /// Makes components visible
        /// </summary>
        private void ShowComponents()
        {
            resetButton.Show();
            startButton.Show();
            greetingMessage.Show();
        }

        private void SimpleStopwatchForm_Shown(object sender, EventArgs e)
        {
            string filePath = Properties.Settings.Default.FilePath;

            if (string.IsNullOrEmpty(filePath))
            {
                DialogResult messageBoxResult = MessageBox.Show("Want to save your time?\nClick 'OK' to create a new save file.", "Save File", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (messageBoxResult == DialogResult.OK)
                {

                    DialogResult saveFileDialogResult = SaveFileDialog.ShowDialog();

                    if (saveFileDialogResult == DialogResult.OK)
                    {
                        using FileStream fileStream = File.Create(filePath);
                        SaveFilePathSetting(SaveFileDialog.FileName);
                    }
                }
            }
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTimeForm viewTimeForm = new ViewTimeForm(Properties.Settings.Default.FilePath);
            viewTimeForm.Show();
        }

        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult openFileDialogResult = OpenFileDialog.ShowDialog();

            if (openFileDialogResult == DialogResult.OK)
            {
                SaveFilePathSetting(OpenFileDialog.FileName);
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult saveFileDialogResult = SaveFileDialog.ShowDialog();

            if (saveFileDialogResult == DialogResult.OK)
            {
                string filePath = SaveFileDialog.FileName;

                using FileStream fileStream = File.Create(filePath);
                SaveFilePathSetting(filePath);
            }
        }

        private static void SaveFilePathSetting(string filePath)
        {
            Properties.Settings.Default.FilePath = filePath;
            Properties.Settings.Default.Save();
        }
    }
}