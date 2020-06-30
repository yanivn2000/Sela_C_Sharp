using System;

namespace StachVsHeap
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Testing copy integers vs objects");

            int score1 = 99; //on the stack
            int score2 = score1;//on the stack + copy value on the stack
            Console.WriteLine($"score1 = {score1}, score2 = {score2}");
            //change score2 that is a copy on the stack
            score1 = 100;//change the value on the stack
            Console.WriteLine("Changing score1 to 100");
            Console.WriteLine($"score1 = {score1}, score2 = {score2}");

            Report report1 = new Report("First Report", 1);//pointer on the stack, object on the heap

            //both pointers point to the same object on th eheap.
            Report report2 = report1;//copy of pointer (!!!) on the stack (NO COPY OF OBJECT on the HEAP!!)
            //Report report2 = new Report(report1);//CREATE NEW REPORT AND COPY VALUES FROM REPORT1
            report1.Display();
            report2.Display();

            //change the value on the heap
            report1.Pages = 99;//change the value on the heap (both pointers point to the same memory)
            Console.WriteLine("Changing report1.Pages to 99");
            report1.Display();
            report2.Display();


            //+PASSING BYVALUE BYREF
            Console.WriteLine();
            Console.WriteLine("Testing byval and by ref");
            Console.WriteLine($"score1 is {score1}");
            report1.Display();
            ProcessIt(score1, report1);
            Console.WriteLine($"score1 is {score1}");
            report1.Display();

        }

        static void ProcessIt(int s, Report r)
        {
            Console.WriteLine("ProcessIt is changing score to 50 and report.pages to 555");
            s = 50;
            r.Pages = 555;
        }
    }

    /*
     * if you change to struct it will be BY VALUE
     * if you change to class it will be BY REFERENCE
     */
    class Report
    {
        public string Title { get; set; }
        public int Pages { get; set; }

        public Report(string title1, int page1)
        {
            Title = title1;
            Pages = page1;
        }
        public Report(Report obj)
        {
            Title = obj.Title;
            Pages = obj.Pages;
        }
        public void Display()
        {
            Console.WriteLine($"Title {Title} has {Pages} pages");
        }
    }
}
