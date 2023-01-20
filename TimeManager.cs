using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static TimeManager.Task;
using System.Globalization;

namespace TimeManager
{
    public partial class TimeManager : Form
    {
        private TimeSheet timeSheet;
        public TimeManager()
        {
            InitializeComponent();

            cBoxTaskType.DataSource = Enum.GetValues(typeof(TaskType));
            cBoxTaskType.SelectedIndex = 0;

            timeSheet = new TimeSheet(); // Initialize the timeSheet field
        }

        public void TaskRefresher()
        {
            int priority = (int)numPriority.Value;

            Person p = (Person)cBoxPeople.SelectedItem; //casting
            p.assignedTasks.Add(new Task(txtTaskName.Text, txtDescription.Text, priority.ToString(), txtPlace.Text, dateTimeInput.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), (TaskType)cBoxTaskType.SelectedItem));
            dGTaskView.Rows.Clear();
            foreach (Task t in p.assignedTasks)
            {
                dGTaskView.Rows.Add(t.TaskName, t.Description, t.Priority, t.Place, t.Deadline, t.tType.ToString());
            }
        }

        private void TimeManager_Load(object sender, EventArgs e)
        {

            var people = Person.CreatePeople();

            ////link data to dropdown menu
            cBoxPeople.DataSource = Person.CreatePeople();
            cBoxPeople.DisplayMember = "Fullname";
            cBoxPeople.ValueMember = "PersonID";
        }


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskName.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtPlace.Text))
            {
                // show a message box that the textboxes are empty
                MessageBox.Show("Please fill all the fields before adding a new task");
                return;
            }

            TaskRefresher();

            //clear fields
            txtTaskName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            numPriority.Text = string.Empty;
            txtPlace.Text = string.Empty;
            dateTimeInput.Value = DateTime.Now;
            numPriority.Value = 0;

           
        }


        //Send DataGridView To TextBoxes To Edit
        private void dGTaskView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGTaskView.CurrentRow != null)
            {
                txtTaskName.Text = dGTaskView.CurrentRow.Cells["Task"].Value.ToString();
                txtDescription.Text = dGTaskView.CurrentRow.Cells["Description"].Value.ToString();
                numPriority.Value = Convert.ToDecimal(dGTaskView.CurrentRow.Cells["Priority"].Value);
                txtPlace.Text = dGTaskView.CurrentRow.Cells["Place"].Value.ToString();
                cBoxTaskType.Text = dGTaskView.CurrentRow.Cells["Type"].Value.ToString();
                dateTimeInput.Value = Convert.ToDateTime(dGTaskView.CurrentRow.Cells["Deadline"].Value);
            }
        }



        //Apply Edit To DataGridView
        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskName.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtPlace.Text))
            {
                // show a message box that the textboxes are empty
                MessageBox.Show("Please fill all the fields before editing a task");
                return;
            }
            //edit selected task
            if (dGTaskView.CurrentRow != null)
            {
                dGTaskView.CurrentRow.Cells["Task"].Value = txtTaskName.Text;
                dGTaskView.CurrentRow.Cells["Description"].Value = txtDescription.Text;
                dGTaskView.CurrentRow.Cells["Priority"].Value = numPriority.Value.ToString();
                dGTaskView.CurrentRow.Cells["Place"].Value = txtPlace.Text;

            }
        }


        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            //clear selected row
            if (dGTaskView.CurrentRow != null)
            {
                dGTaskView.Rows.RemoveAt(dGTaskView.CurrentRow.Index);
            }
        }


        private void cBoxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGTaskView.Rows.Clear();
            Person p = (Person)cBoxPeople.SelectedItem; //casting
            foreach (Task t in p.assignedTasks) 
            {
                dGTaskView.Rows.Add(t.TaskName, t.Description, t.Priority, t.Place, t.Deadline, t.tType.ToString());
            }
            //loop through individual properties for the Task

        }

        private void dGTaskView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int TaskName = 0;
            int Description = 1;
            int Priority = 2;
            int Place = 3;
            int Deadline = 4;

            TaskDetailsForm taskDetails = new TaskDetailsForm();
            taskDetails.lblTaskNameDetails.Text = this.dGTaskView.CurrentRow.Cells[TaskName].Value.ToString();
            taskDetails.rtxtDescriptionDetails.Text = this.dGTaskView.CurrentRow.Cells[Description].Value.ToString();
            taskDetails.lblPriorityLevel.Text = this.dGTaskView.CurrentRow.Cells[Priority].Value.ToString();
            taskDetails.rtxtPlaceDetails.Text = this.dGTaskView.CurrentRow.Cells[Place].Value.ToString();

            // Get the date strings from the DataGridView cells
            string startDateString = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            string endDateString = this.dGTaskView.CurrentRow.Cells[Deadline].Value.ToString();
            
            // Convert the date strings to DateTime objects
            DateTime startDate = DateTime.ParseExact(startDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            
            // Set the start and end dates of the MonthCalendar control
            taskDetails.mCalenderDetails.SelectionStart = startDate;
            taskDetails.mCalenderDetails.SelectionEnd = endDate;

            taskDetails.mCalenderDetails.MaxSelectionCount = 1;
            taskDetails.mCalenderDetails.MaxDate = endDate;

            // Get the time spent on the task from the timeSheet object
            taskDetails.lblTimeSpent.Text = timeSheet.GenerateReport(startDate, endDate);
            taskDetails.ShowDialog();
        }
    }
}




