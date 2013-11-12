using System;
using System.Linq;

namespace School
{
    public class Teacher : People
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}