using System;

namespace ShallowVsDeepCopy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine($"student 1 age is {student1.Age}");
            Console.WriteLine($"teachet 1 salery is {student1.MyTeacher.Salery}");

            Student student2 = student1.ShallowCopy();
            Console.WriteLine($"student 2 age is {student2.Age}");
            Console.WriteLine($"teachet 2 salery is {student1.MyTeacher.Salery}");

            //changing age of student2
            student2.Age = 25;
            Console.WriteLine("student2.Age = 25");
            //changing salery of teacher2
            //BECAUSE OF THE SHALLOW COPY - TEACHER SALERY ON BOTH CALSSES WILL be CHANGED!
            student2.MyTeacher.Salery = 8000;
            Console.WriteLine("student2.MyTeacher.Salery = 8000");

            Console.WriteLine($"student 1 age is {student1.Age}");
            Console.WriteLine($"teachet 1 salery is {student1.MyTeacher.Salery}");
            Console.WriteLine($"student 2 age is {student2.Age}");
            Console.WriteLine($"teachet 2 salery is {student2.MyTeacher.Salery}");

            Student student3 = student1.DeepCopy();
            Console.WriteLine("Student student3 = student1.DeepCopy()");
            student3.Age = 22;
            Console.WriteLine("student3.Age = 22");
            student3.MyTeacher.Salery = 6000;
            Console.WriteLine("student3.MyTeacher.Salery = 6000");

            Console.WriteLine($"student 1 age is {student1.Age}");
            Console.WriteLine($"student 3 age is {student3.Age}");
            Console.WriteLine($"teachet 1 salery is {student1.MyTeacher.Salery}");
            Console.WriteLine($"teachet 3 salery is {student3.MyTeacher.Salery}");



        }
    }
    class Student
    {
        public Student()
        {
            Age = 30;
            MyTeacher = new Teacher();
        }
        public int Age { get; set; }
        public Teacher MyTeacher { get; set; }

        /*
        Shallow copy is a bit-wise copy of an object.
        A new object is created that has an exact copy of the values in the original object.
        If any of the fields of the object are references to other objects,
        just the reference addresses are copied i.e., only the memory address is copied.
        */
        public Student ShallowCopy()
        {
            return (Student)this.MemberwiseClone();//A shallow copy of the current Object.

        }
        /*
        Deep copy
        A deep copy copies all fields, and makes copies of dynamically allocated memory pointed to by the fields.
        A deep copy occurs when an object is copied along with the objects to which it refers.
        */
        public Student DeepCopy()
        {
            Student student = new Student();
            student = (Student)this.MemberwiseClone();
            student.MyTeacher = new Teacher() { Salery = this.MyTeacher.Salery };
            return student;
        }
    }
    class Teacher
    {
        public Teacher()
        {
            Salery = 10000;
        }
        public int Salery { get; set; }
    }
}
