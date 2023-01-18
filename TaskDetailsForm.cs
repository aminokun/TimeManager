using System;
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
    public partial class TaskDetailsForm : Form
    {
        private Task task { get; }

        public TaskDetailsForm(Task task)
        {
            InitializeComponent();
            this.task = task;
        }

        private void TaskDetailsForm_Load(object sender, EventArgs e)
        {
            lblTaskName.Text = this.task.TaskName;
        }
    }
}
