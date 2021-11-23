using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCampCourseCsharp
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string studentName, string studentMajor, double studentGpa)
        {
            name = studentName;
            major = studentMajor;
            gpa = studentGpa;

        }

        public bool hasHonors()
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }


    }
}
