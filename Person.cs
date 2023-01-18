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
    }
}
