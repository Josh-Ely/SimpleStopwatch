using System.Diagnostics;

namespace WorkCounter
{
    public partial class StopWatch : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private readonly Stopwatch stopwatch;

        public StopWatch()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text.Equals("Start"))
            {
                stopwatch.Start();
                startButton.Text = "Pause";
            }
            else
            {
                stopwatch.Stop();
                startButton.Text = "Start";
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            stopwatch.Stop();
            startButton.Text = "Start";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeDisplayLabel.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TitleBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void TitleBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

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

        private void timer_Tick_1(object sender, EventArgs e)
        {
            timeDisplayLabel.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}