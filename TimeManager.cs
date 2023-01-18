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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static TimeManager.Task;

namespace TimeManager
{
    public partial class TimeManager : Form
    {
        public TimeManager()
        {
            InitializeComponent();

            cBoxTaskType.DataSource = Enum.GetValues(typeof(TaskType));
            cBoxTaskType.SelectedIndex = 0;

        }

        public void TaskRefresher()
        {
            int priority = (int)numPriority.Value;

            Person p = (Person)cBoxPeople.SelectedItem; //casting
            p.assignedTasks.Add(new Task(txtTaskName.Text, txtDescription.Text, priority.ToString(), txtPlace.Text, txtDeadline.Text, (TaskType)cBoxTaskType.SelectedItem));
            dGTaskView.Rows.Clear();
            foreach (Task t in p.assignedTasks)
            {
                dGTaskView.Rows.Add(t.TaskName, t.Description, t.Priority, t.Place, t.Deadline, t.tType.ToString());
            }
        }

        private void TimeManager_Load(object sender, EventArgs e)
        {
            //pre made tasks
            Task Wiskunde = new Task("Wiskunde", "Opdracht 42, 43", "3", "Huiswerk Bijles", "15-01-2023", TaskType.Homework);
            Task Sporten = new Task("Voetbal Training", "Om 19:00", "4", "Voetbalveld", "19-01-2023", TaskType.Workout);
            Task Dokter = new Task("Bloed Controle", "Bloed prikken", "3", "Ziekenhuis", "29-01-2023", TaskType.Doctor);
            Task Knutselen = new Task("Sinterklaas Surprise", "voor neefje", "2", "Thuis", "05-12-2023", TaskType.Hobby);


            var people = new List<Person>();
            people.Add(new Person(1, "Josh", "Frank", new List<Task> { Wiskunde, Sporten }));
            people.Add(new Person(2, "George", "Julius", new List<Task> { Dokter, Wiskunde }));
            people.Add(new Person(3, "Bob", "Jackson", new List<Task> { Knutselen }));
            people.Add(new Person(4, "B", "Joe"));



            //link data to dropdown menu
            cBoxPeople.DataSource = people;
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
            txtDeadline.Text = string.Empty;
            numPriority.Value = 0;

           
        }

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

        private void txtDeadline_Click(object sender, EventArgs e)
        {
            txtDeadline.Text = string.Empty;
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
            if (e.RowIndex >= 0 && dGTaskView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dGTaskView.SelectedRows[0];
                Task selectedTask = (Task)selectedRow.DataBoundItem;
                if (selectedTask != null)
                {
                    TaskDetailsForm taskDetailsForm = new TaskDetailsForm(selectedTask);
                    taskDetailsForm.Show();
                }
                else
                {
                    // show a message box to inform the user that the selected task is null
                    MessageBox.Show("The selected task is null, please make sure that the data grid view is properly bound to the data source and that the data source contains the tasks");
                }
            }

        }
    }
}




