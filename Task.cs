using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TimeManager.TimeManager;

namespace TimeManager
{
    public class Task
    {
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Place { get; set; }
        public string Deadline { get; set; }
        public TaskType tType { get; set; }

        public enum TaskType
        {
            Homework,
            Workout,
            Work,
            Hobby,
            Doctor
        }

        public Task(string _taskname, string _description, string _priority, string _place, string _deadline, TaskType _ttype)
        {
            this.TaskName = _taskname;
            this.Description = _description;
            this.Priority = _priority;
            this.Place = _place;
            this.Deadline = _deadline;
            this.tType = _ttype;
        }

        //public override string ToString()
        //{
        //    return "Priority level:" + this.Priority ;
        //    //return "";
        //}
    }


}
