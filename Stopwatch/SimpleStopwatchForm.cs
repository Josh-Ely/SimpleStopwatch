using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SimpleStopwatch
{
    public partial class SimpleStopwatchForm : Form
    {
        private new bool MouseDown { get; set; }
        private Point LastLocation { get; set; }
        private Stopwatch Stopwatch { get; set; }

        private const int AW_HIDE = 0x10000;
        private const int AW_BLEND = 0x80000;

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        public SimpleStopwatchForm()
        {
            InitializeComponent();
            Stopwatch = new Stopwatch();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text.Equals("Start") || startButton.Text.Equals("Resume"))
            {
                Stopwatch.Start();
                startButton.Text = "Pause";
            }
            else
            {
                Stopwatch.Stop();
                startButton.Text = "Resume";
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            if(!Stopwatch.IsRunning)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to reset the timer?", "Simple Stopwatch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Stopwatch.Restart();
                Stopwatch.Stop();
                startButton.Text = "Start";
            }
        }

        private void TitleBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            LastLocation = e.Location;
        }

        private void TitleBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - LastLocation.X) + e.X, (this.Location.Y - LastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Greeting()
        {
            if (DateTime.Now.Hour < 12)
                greetingMessage.Text = "Good Morning";
            else if (DateTime.Now.Hour < 17)
                greetingMessage.Text = "Good Afternoon";
            else
                greetingMessage.Text = "Good Evening";
        }

        private void StopWatch_Load(object sender, EventArgs e)
        {
            Greeting();
            greetingMessage.Select();
        }

        private void RefreshGreetingTimer_Tick(object sender, EventArgs e)
        {
            Greeting();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            timeElapsedLabel.Text = string.Format("{0:hh\\:mm\\:ss}", Stopwatch.Elapsed);
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.IndianRed;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Transparent;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 75, AW_HIDE | AW_BLEND);
            Application.Exit();
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.Transparent;
        }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.DeepSkyBlue;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}