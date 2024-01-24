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
            // can only save as a txt file
            OpenFileDialog openFileDialog = new()
            {
                Title = "Save Time to an Existing File",
                Filter = "Text Files|*.txt"
            };

            // shows the open file dialog form
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // writes the elapsed time to the existing file
                using StreamWriter writer = new(openFileDialog.FileName, true);
                writer.WriteLine(DateTime.Now.ToString("MM/dd/yyyy - ") + string.Format("{0:hh\\:mm\\:ss}", Stopwatch.Elapsed));
            }
        }

        /// <summary>
        /// Allows the user to save time as a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // can only save as a txt file
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Text Files|*.txt",
                Title = "Save Time as Text File"
            };

            // shows the save dialog form
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // writes the elapsed time to the new file
                using StreamWriter writer = new(saveFileDialog.FileName);
                writer.WriteLine(DateTime.Now.ToString("MM/dd/yyyy - ") + string.Format("{0:hh\\:mm\\:ss}", Stopwatch.Elapsed));
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
    }
}