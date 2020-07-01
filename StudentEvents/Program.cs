using System;
using System.Collections.Generic;


namespace StudentEvents
{
    //public delegate void EventHandler(object obj, EventArgs args);  // delegate
    //public delegate bool EventHandler2(int index);  // delegate

    class MainClass
    {
        public static void Main(string[] args)
        {
            //create amanger and start it
            Manager manager = new Manager();
            manager.Start();
            //print the manager
            manager.PrintAll();
        }
    }

    class Manager
    {
        //student que that will hold qtudents
        StudentQueue studentQueue;

        public Manager()
        {
            //create student queue with limitation of 92 students and 70 grade (exceeded..)
            studentQueue = new StudentQueue(70, 92);
            //Append 2 methods for LimitationExceed event
            studentQueue.LimitationExeeded += RemoveByGrade;
            studentQueue.LimitationExeeded += PrintCount;
        }
        public void Start()
        {
            //create random studets
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                Student stud = new Student(rand.Next(100000, 200000), rand.Next(50, 100));
                try
                {
                    studentQueue.AddStudent(stud);
                }
                catch (QueueLimitationException e)
                {
                    //limitation exceeded therefore call to RemoveByGrade
                    Console.WriteLine($"Exception! {e.Message}");
                    studentQueue.RemoveByGrade();
                }
            }
        }
        //Remove all the students by grade (70)
        public void RemoveByGrade(object obj, EventArgs args)
        {
            Console.WriteLine(((MyEventArgs)args).myInfo);
            studentQueue.RemoveByGrade();
        }
        //Print the number of students
        public void PrintCount(object obj, EventArgs args)
        {
            studentQueue.printCount();
        }
        //print the students
        public void PrintAll()
        {
            Console.WriteLine("Queue:");
            studentQueue.printQueue();
        }
    }
    //Student queue that will hold all the studets
    class StudentQueue
    {
        //*********** EVENT *************//
        public event EventHandler LimitationExeeded;//Built-in EventHandler Delegate

        int MinGrade;
        int MaxStudents;
        List<Student> _students;
        public StudentQueue(int minimumGrade, int maxStudents)
        {
            MinGrade = minimumGrade;
            MaxStudents = maxStudents;
            _students = new List<Student>();

        }
        //Remove all the studets that are below the limitation
        public void RemoveByGrade()
        {
            _students.RemoveAll((x) => x.grade < MinGrade);             /*
            for (int i = _students.Count - 1; i >= 0; i--)
            {
                if (_students[i].grade < MinGrade)
                    _students.RemoveAt(i);
            }*/
        }
        //add student to the list
        //in case the count exceed 92
        //1. Throw exception
        //2. Call the event
        public void AddStudent(Student student)
        {
            _students.Add(student);
            if(_students.Count > 92){
                //throw new QueueLimitationException($"Queue exceeded limitation: {MaxStudents}");
                if(LimitationExeeded != null)
                    LimitationExeeded.Invoke(this, new MyEventArgs("Limitation exceeded 92 students"));
            }
        }
        //Print hte students
        public void printQueue()
        {
            Console.WriteLine($"Total number of students: {_students.Count}");
            foreach (Student stud in _students)
            {
                Console.WriteLine(stud);
            }
        }
        //Print thenumber of students in the queue
        public void printCount()
        {
            Console.WriteLine($"Total number of students: {_students.Count}");
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
    //Exception definition
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
    //EventArgs
    class MyEventArgs : EventArgs
    {
        public MyEventArgs(string info)
        {
            myInfo = info;
        }
        public string myInfo { get; set; }
    }
}
