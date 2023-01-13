using System;
using System.Collections.Generic;
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

    }
}
