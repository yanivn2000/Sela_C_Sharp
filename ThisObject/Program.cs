using System;

namespace ThisObject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string Title = "some title";
            string Title2 = "some title 2";
            Report report = new Report(Title);
            report.PrintTitle(Title2);
        }
    }

    class Report
    {
        string Title;
        int Pages;
        public Report()
        {
            Title = "Original Title";
            Pages = 100;
        }
        public Report(string title) : this()
        {
            Title = title;
        }
        public void PrintTitle (string Title)
        {
            Console.WriteLine($"The title is: {Title}");
            Console.WriteLine($"The title is: {this.Title}");
        }
    }
}
