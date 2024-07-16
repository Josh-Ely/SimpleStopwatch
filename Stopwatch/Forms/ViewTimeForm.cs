namespace SimpleStopwatch.Forms
{
    public partial class ViewTimeForm : Form
    {
        /// <summary>
        /// holds the path to the save file
        /// </summary>
        private string SaveFile { get; set; }

        public ViewTimeForm(string saveFile)
        {
            InitializeComponent();
            SaveFile = saveFile;
        }

        /// <summary>
        /// gets all lines from the save file into a list and returns the list
        /// </summary>
        /// <returns></returns>
        private List<string> GetSavedTime()
        {
            // gets all lines from the save file into a list and sets it equal to the savedTimeList
            List<string> savedTimeList = File.ReadAllLines(SaveFile).ToList();

            savedTimeList.Reverse();

            // returns list
            return savedTimeList;
        }

        /// <summary>
        /// adds each value from the savedTimeList to the viewTimeDataGrid
        /// </summary>
        /// <param name="savedTimeList"></param>
        private void AddTimeToDataGrid(List<string> savedTimeList)
        {
            int totalItems = 0;

            // loops through each string in the list
            foreach (string item in savedTimeList)
            {
                // checks if the string contains a dash
                if (item.Contains('-'))
                {
                    // gets date and time values by splitting the string at the dash symbol
                    string date = item.Split('-')[0].Trim();
                    string timeWorked = item.Split("-")[1].Trim();

                    // adds values to the data grid
                    viewTimeDataGrid.Rows.Add(date, timeWorked);

                    totalItems++;
                }
            }

            totalItemsLabel.Text = $"Items: {totalItems}";
        }

        private void ViewTimeForm_Load(object sender, EventArgs e)
        {
            // checks if the save file exists when the form first loads
            if (File.Exists(SaveFile))
            {
                // gets a list of saved time
                List<string> savedTimeList = GetSavedTime();

                // adds values from the list onto the data grid
                AddTimeToDataGrid(savedTimeList);
            }
            else
            {
                // inform the user the save file was not found 
                MessageBox.Show("Unable to display time because the save file was not found.", "Save File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
