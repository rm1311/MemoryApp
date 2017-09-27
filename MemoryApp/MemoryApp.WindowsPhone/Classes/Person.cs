using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryApp.Classes
{
    public class Person
    {
        private String Name;
        public String _Name { get { return Name; } set { Name = value; } }
        private String Score;
        public String _Score { get { return Score; } set { Score = value; } }

        public Person()
        {

        }
    }
}
