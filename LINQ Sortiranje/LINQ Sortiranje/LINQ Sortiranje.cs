﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Sortiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };

            Student[] students = new Student[10];

            int i = 0;

            foreach (Student std in studentArray)
            {
                if (std.Age > 18 && std.Age < 26)
                {
                    students[i] = std;
                    i++;
                }
                Console.WriteLine(students.ToString());
            }

            Console.ReadKey();
        }
    }
}

class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        string ispis = "Redi broj: " + this.StudentID + " Ime: " + this.StudentName + " Godine: " + this.Age;
        return ispis;
    }
}