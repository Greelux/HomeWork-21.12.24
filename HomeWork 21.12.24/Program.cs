using System;
using System.Collections.Generic;


namespace HomeWork_21._12._24
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Faculty { get; set; }

        public Student()
        {
            Name = "Unknown";
            Age = 0;
            Faculty = "Unknown";
        }
        public Student(string name, int age, string faculty)
        {
            Name = name;
            Age = age;
            Faculty = faculty;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Student Information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Faculty: {Faculty}");
        }
        
    }

    public class University
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void ShowStudentsByFaculty(string faculty) 
        {
            Console.WriteLine($"Students in {faculty} Faculty:");
            foreach (var student in students)
            {
                if (student.Faculty == faculty)
                {
                    student.ShowInfo();
                    Console.WriteLine();
                }
            }
        }
    }


    public class ITStudent : Student
    {
        public string ProgrammingLanguage { get; set; }
            public override void ShowInfo()
            {
                base.ShowInfo(); 
                Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
            }
    }
    public class MechStudent : Student
    {
        public string Specialization { get; set; }
            public override void ShowInfo()
            {
                base.ShowInfo(); 
                Console.WriteLine($"Speciality: {Specialization}");
            }
    }
    public class MedicineStudent : Student
    {
        public string Specialization { get; set; }
            public override void ShowInfo()
            {
                base.ShowInfo(); 
                Console.WriteLine($"Specialization: {Specialization}");
            }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University();

            ITStudent itStudent = new ITStudent
            {
                Name = "Kirill",
                Age = 17,
                Faculty = "IT",
                ProgrammingLanguage = "C#"
            };

            MechStudent MechStudent = new MechStudent
            {
                Name = "Max",
                Age = 17,
                Faculty = "Engineering Mechanics",
                Specialization = "Welder\n"
            };

            MedicineStudent medStudent = new MedicineStudent
            {
                Name = "Denis",
                Age = 17,
                Faculty = "Medicine",
                Specialization = "Dentist\n"
            };

            university.AddStudent(MechStudent);
            university.AddStudent(itStudent);
            university.AddStudent(medStudent);
            university.ShowStudentsByFaculty("IT");
            university.ShowStudentsByFaculty("Medicine");
            university.ShowStudentsByFaculty("Engineering Mechanics");

            Console.ReadLine();
        }
    }
}
