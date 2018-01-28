using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2___Class_Student
{
    class Student
    {
        string name;
        string sname;
        double gpa;

        /// <summary>
        /// Method constructor that takes initial values of fields
        /// </summary>
        /// <param name="name"> Name of the student</param>
        /// <param name="sname">Surname of the student</param>
        /// <param name="gpa">Average mark of the student</param>
        
        public Student(string name, string sname, double gpa)
        {
            this.name = name;
            this.sname = sname;
            this.gpa = gpa;
        }
        public override string ToString()
        {
            return name + " " + sname + " " + gpa;
        }
    }
}
