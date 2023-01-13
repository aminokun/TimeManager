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

namespace TimeManager
{
    public partial class TimeManager : Form
    {
        public TimeManager()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            TimeManager task1 = new TimeManager();
            task1.Task = "Wiskunde Huiswerk";
            task1.Description = "Opdracht 32";
            task1.Priority = "3";

            task1.tType = TaskType.Homework;

            Console.WriteLine(task1.ToString());
            Console.WriteLine(task1.Place);

            TimeManager task2 = new TimeManager("Gamen", "potje fifa", "1");
            Console.WriteLine(task2);

            TimeManager task3 = new TimeManager("Benchpress", "3x 8x 50kg", "2", TaskType.Workout);

            TimeManager task4 = new TimeManager("Werken", "Maandag 16-20", "3", "Eindhoven");
            task4.tType = TaskType.Work;

            List<TimeManager> MyList = new List<TimeManager>();
            MyList.Add(task1);
            MyList.Add(task2);
            MyList.Add(task3);
            MyList.Add(task4);

            foreach (TimeManager task in MyList)
            {
                if (task.tType == TaskType.Work)
                {
                    Console.WriteLine("Task: " + task);
                }
            }
        }
        public enum TaskType
        {
            Homework,
            Workout,
            Work,
            Hobby
        }

        public class TimeManager
        {
            public string Task { get; set; }
            public string Description { get; set; }
            public string Priority { get; set; }
            public string Place { get; private set; }
            public TaskType tType { get; set; }

            public TimeManager()
            {
                this.Place = "School";
            }

            public TimeManager(string _task, string _description, string _priority)
            {
                this.Task = _task;
                this.Description = _description;
                this.Priority = _priority;
            }
            public TimeManager(string _task, string _description, string _priority, string _place)
            {
                this.Task = _task;
                this.Description = _description;
                this.Priority = _priority;
                this.Place = "Place:" + _place;
            }
            public TimeManager(string _task, string _description, string _priority, TaskType _type)
            {
                this.Task = _task;
                this.Description = _description;
                this.Priority = _priority;
                this.tType = _type;
            }

            public override string ToString()
            {
                return this.Priority + ", " + this.Task + " " + this.Description + " (" + this.Place + ")"; ;
                //return "";
            }
        }

        
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTask.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtPlace.Text))
            {
                // show a message box that the textboxes are empty
                MessageBox.Show("Please fill all the fields before adding a new task");
                return;
            }
            string task = txtTask.Text;
            string description = txtDescription.Text;
            int priority = (int)numPriority.Value;
            string place = txtPlace.Text;


            TimeManager newTask = new TimeManager(task, description, priority.ToString());

            dGTaskView.Rows.Add(newTask.Task, newTask.Description, newTask.Priority);
            txtTask.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPlace.Text = string.Empty;
            numPriority.Value = 0;
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dGTaskView.CurrentRow != null)
            {
                dGTaskView.CurrentRow.Cells["Task"].Value = txtTask.Text;
                dGTaskView.CurrentRow.Cells["Description"].Value = txtDescription.Text;
                dGTaskView.CurrentRow.Cells["Priority"].Value = numPriority.Value.ToString();
                dGTaskView.CurrentRow.Cells["Place"].Value = txtPlace.Text;
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (dGTaskView.CurrentRow != null)
            {
                dGTaskView.Rows.RemoveAt(dGTaskView.CurrentRow.Index);
            }
        }
    }
}




