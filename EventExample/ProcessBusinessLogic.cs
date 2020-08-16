using System;

public delegate void EventHandler();  // delegate

public class ProcessBusinessLogic
{
    //Raises the completed event of the process.
    public event EventHandler ProcessCompleted; // event

    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        // some code here..
        OnProcessCompleted();
    }

    protected virtual void OnProcessCompleted() //protected virtual method
    {
        EventArgs e = new EventArgs();
        //if ProcessCompleted is not null then call delegate
        ProcessCompleted?.Invoke();
    }
}