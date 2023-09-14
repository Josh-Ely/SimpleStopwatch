namespace SimpleStopwatch
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // Initialize application configuration
                ApplicationConfiguration.Initialize();

                // starts the application with the main form
                Application.Run(new SimpleStopwatchForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Simple Stopwatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}