**Simple Stopwatch**<br />
As an hourly employee without a set schedule, it’s easy to lose track of time at a desk job. I built SimpleStopwatch to solve that problem. After clocking in, I start the app and let it run, checking it throughout the day to see when I’ve reached eight hours.
<br /> <br /> SimpleStopwatch is written entirely in C# using Windows Forms and stores elapsed time in a local SQLite database. It’s called “Simple” because it doesn’t display milliseconds, giving the UI a cleaner look as the time updates.

**Features**
* Start, Pause, and Reset buttons for managing elapsed time
* Time based greeting that updates automatically (Good morning, afternoon, or evening)
* Right click context menu with the following options:
  - Add – Opens a form to manually add time  
  - Save – Saves elapsed time to a local SQLite database
  - View – Displays saved times in a separate form
    - Double clicking a row allows editing the selected saved time
  - Maintain Size – Launches the form at its previous size
  - Place Top Left – Moves the form to the top-left corner of the screen
  - Show Only Time – Hides buttons and greeting, showing only the running time for a minimal display
<br /> <br />
![Screenshot_SimpleStopwatch](https://github.com/user-attachments/assets/02b1aae1-631a-4169-8766-61556c33b74c)
