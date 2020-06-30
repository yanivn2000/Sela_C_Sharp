using System;

namespace EventHandler1
{
    public class ProcessBusinessLogic
    {
        public string information { get; set; }
        // declaring an event using built-in EventHandler
        public event EventHandler ProcessCompleted;//Built-in EventHandler Delegate
        public event EventHandler<bool> ProcessCompletedBool;//Passing an Event Data

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted(EventArgs.Empty); //No event data
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            information = "Completed";
            ProcessCompleted?.Invoke(this, e);
            ProcessCompletedBool?.Invoke(this,true);
        }
    }
}
