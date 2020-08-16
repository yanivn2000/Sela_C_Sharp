using System;

namespace EventHandler1
{
    public class ProcessBusinessLogic
    {
        public string information { get; set; }
        // declaring an event using built-in EventHandler
        public event EventHandler ProcessCompleted;//Built-in EventHandler Delegate
        public event EventHandler<bool> ProcessCompletedBool;//Passing an Event Data

        public void ReadNumber()
        {
            Console.WriteLine("Process Started!");
            Console.Write("Please enter a number: ");
            int value;
            if(int.TryParse(Console.ReadLine(), out value))
            {
                OnProcessCompleted(true); //No event data
            }
            else
            {
                OnProcessCompleted(false); //No event data
            }

            // some code here..
        }

        protected virtual void OnProcessCompleted(bool result)
        {
            //information = "Completed";
            //EventArgs e = new EventArgs();
            //ProcessCompleted?.Invoke(this, e);
            ProcessCompletedBool?.Invoke(this,result);
        }
    }
}
