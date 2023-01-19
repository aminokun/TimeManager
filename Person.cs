using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public string Fullname
        {
            get 
            { 
                return Name + " " + Lastname; 
            }
        }

        public Person(int personID, string name, string lastname, List<Task> assignedTasks)
        {
            this.PersonID = personID;
            this.Name = name;
            this.Lastname = lastname;
            this.assignedTasks = assignedTasks;
        }
        public Person(int personID, string name, string lastname) : this(personID, name, lastname, new List<Task>())
        {

        }
        public List<Task> assignedTasks = new List<Task>();

        public static List<Person> CreatePeople()
        {
            var people = new List<Person>();
            people.Add(new Person(1, "Josh", "Frank", Task.CreateTasks().Where(x=>x.TaskName == "Wiskunde" || x.TaskName == "Voetbal Training").ToList()));
            people.Add(new Person(2, "George", "Julius", Task.CreateTasks().Where(x=>x.TaskName == "Bloed Controle" || x.TaskName == "Wiskunde" ).ToList()));
            people.Add(new Person(3, "Bob", "Jackson", Task.CreateTasks().Where(x=>x.TaskName == "Sinterklaas Surprise" ).ToList()));
            people.Add(new Person(4, "B", "Joe"));
            return people;
        }
    }
}
