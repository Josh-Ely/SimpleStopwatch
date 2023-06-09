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

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text.Equals("Start") || startButton.Text.Equals("Resume"))
            {
                stopwatch.Start();
                startButton.Text = "Pause";
            }
            else
            {
                stopwatch.Stop();
                startButton.Text = "Resume";
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            stopwatch.Stop();
            startButton.Text = "Start";
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

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            timeDisplayLabel.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
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
            Application.Exit();
        }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.DeepSkyBlue;
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.Transparent;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}