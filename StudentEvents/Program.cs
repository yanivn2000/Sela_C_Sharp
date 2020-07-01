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
            studentQueue = new StudentQueue(70, 92);
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                Student stud = new Student(rand.Next(100000, 200000), rand.Next(50, 100));
                try
                {
                    studentQueue.AddStudent(stud);
                }
                catch(QueueLimitationException e)
                {
                    Console.WriteLine($"Exception! {e.Message}");
                    studentQueue.RemoveByGrade();
                }
            }
        }
        public void PrintAll()
        {
            Console.WriteLine("Queue:");
            studentQueue.printQueue();
        }
    }
    class StudentQueue
    {
        int MinGrade;
        int MaxStudents;
        List<Student> _students;
        public StudentQueue(int minimumGrade, int maxStudents)
        {
            MinGrade = minimumGrade;
            MaxStudents = maxStudents;
            _students = new List<Student>();

        }
        public void RemoveByGrade()
        {
            _students.RemoveAll((x) => x.grade < MinGrade);             /*
            for (int i = _students.Count - 1; i >= 0; i--)
            {
                if (_students[i].grade < MinGrade)
                    _students.RemoveAt(i);
            }*/
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
            if(_students.Count > 92){
                throw new QueueLimitationException($"Queue exceeded limitation: {MaxStudents}");
            }
        }
        public void printQueue()
        {
            Console.WriteLine($"Total number of students: {_students.Count}");
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

    public class QueueLimitationException : Exception
    {
        public QueueLimitationException()
            : base("this is an empty exception")
        {
        }
        public QueueLimitationException(string message)
            : base(message)
        {
        }
        public QueueLimitationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
