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
        public TaskType tType { get; }
        public TimeSpan TimeSpent { get; set; }


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

        public static List<Task> CreateTasks()
        {
            var taskList = new List<Task>();

            taskList.Add(new Task("Wiskunde", "Opdracht 42, 43", "3", "Huiswerk Bijles", "15/02/2023", TaskType.Homework));
            taskList.Add(new Task("Voetbal Training", "Om 19:00", "4", "Voetbalveld", "19/02/2023", TaskType.Workout));
            taskList.Add(new Task("Bloed Controle", "Bloed prikken", "3", "Ziekenhuis", "28/02/2023", TaskType.Doctor));
            taskList.Add(new Task("Sinterklaas Surprise", "voor neefje", "2", "Thuis", "05/02/2023", TaskType.Hobby));
            return taskList;
        }

        public void UpdateTimeSpent(TimeSpan timeSpent)
        {
            this.TimeSpent += timeSpent;
        }
    }
}