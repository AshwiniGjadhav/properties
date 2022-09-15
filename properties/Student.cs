using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Student
    {
        private int rollno;
        private string name;
        private int percentage;

        public int Rollno
        {
            get { return rollno; }
            set { rollno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }

        public override string ToString()
        {
            return $"student detail: {rollno} {name} { percentage}";
        }
    }
}
