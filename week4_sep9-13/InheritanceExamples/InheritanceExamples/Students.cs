using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    public enum Grade { A, B, C, D, F};

    public class Student
    {
        private double _hours;
        private double _points;

        public double GPA => _points / _hours;
        public string First { get; set; }
        public string Last { get; set; }

        public Student(string first, string last)
        {
            this.First = first;
            this.Last = last;
        }

        public void AddCourseGrade(uint creditHours, Grade finalGrade)
        {
            this._hours += creditHours;
            switch (finalGrade)
            {
                case Grade.A:
                    this._points += 4 * creditHours;
                    break;
                case Grade.B:
                    this._points += 3 * creditHours;
                    break;
                case Grade.C:
                    this._points += 2 * creditHours;
                    break;
                case Grade.D:
                    this._points += 1 * creditHours;
                    break;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name: {First} {Last}");
            Console.WriteLine($"GPA: {GPA}");
        }
    }


    public class UndergraduateStudent : Student
    {
        //DO THIS
        //Why is there an error?
        //How to write constructor that takes first/last name?
    
        //Print?
    }


    public class GraduateStudent : Student
    {
        public string BachelorDegree { get; }

        //DO THIS
        //Why is there an error? Fix. What to do with "degree"?
        public GraduateStudent(string first, string last, string degree) 
        {
            
        }

        //Print?
        public void Print()
        {
            Console.WriteLine($"Name: {First} {Last}");
            Console.WriteLine($"GPA: {GPA}");
            Console.WriteLine($"Degree: {BachelorDegree}");
        }
    }
}

/*
//Is this OK?
Student s = new GraduateStudent("Amy", "Jones", "Math");
s.Print();

//What about this?
GraduateStudent stu = s as GraduateStudent;
stu.Print();


//This one?
GraduateStudent g = new Student("John", "Doe");

*/
