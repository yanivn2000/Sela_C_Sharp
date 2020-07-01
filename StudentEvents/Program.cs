using System;
using System.Collections.Generic;

namespace StudentEvents
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.PrintAll();
        }
    }

    class Manager
    {
        StudentQueue studentQueue;
        public Manager()
        {
            studentQueue = new StudentQueue(70);
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                Student stud = new Student(rand.Next(100000, 200000), rand.Next(50, 100));
                studentQueue.AddStudent(stud);
            }
        }
        public void PrintAll()
        {
            studentQueue.printQueue();
        }
    }
    class StudentQueue
    {
        int MinGrade;
        List<Student> _students;
        public StudentQueue(int minimumGrade)
        {
            MinGrade = minimumGrade;
            _students = new List<Student>();

        }
        public void RemoveByGrade()
        {
            foreach (Student stud in _students)
            {
                if (stud.grade < MinGrade)
                {
                    _students.Remove(stud);
                }
            }
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public void printQueue()
        {
            foreach (Student stud in _students)
            {
                Console.WriteLine(stud);
            }
        }
    }

    class Student
    {
        public int id { get; set; }
        public int grade { get; set; }
        public Student(int id1, int grade1)
        {
            id = id1;
            grade = grade1;
        }
        public override string ToString()
        {
            return $"Id: {id}, grade: {grade}";
        }
    }


}
