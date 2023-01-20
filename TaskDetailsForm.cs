using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TimeManager
{
    public partial class TaskDetailsForm : Form
    {
        public TimeSheet timeSheet;

        public TaskDetailsForm()
        {
            InitializeComponent();
            timeSheet = new TimeSheet();
        }

        // When the form is opened, start the timer
        private void TaskDetailsForm_Load(object sender, EventArgs e)
        {
            timeSheet.StartTimer();
        }

        // When the form is closed, stop the timer and store the time spent
        private void TaskDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timeSheet.StopTimer();
        }
    }
}
