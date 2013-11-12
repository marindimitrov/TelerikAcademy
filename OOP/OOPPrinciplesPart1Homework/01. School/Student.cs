using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Student : People
    {
        private string name;
        private int classNumber;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int ClassNumber
        {
            get { return this.classNumber; }
            set { this.classNumber = value; }
        }
    }
}