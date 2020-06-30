using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

/**
 * The point of Dispose is to free unmanaged resources.
 * It needs to be done at some point, otherwise they will never be cleaned up.
 * The garbage collector doesn't know how to call DeleteHandle() on a variable of type IntPtr,
 * it doesn't know whether or not it needs to call DeleteHandle().
 */

public class DisposeExample
{
    // A base class that implements IDisposable.
    // By implementing IDisposable, you are announcing that
    // instances of this type allocate scarce resources.

    //So you make your object expose the IDisposable interface,
    //and that way you promise that you've written that single method to clean up your unmanaged resources:
    public class MyResource : IDisposable
    {
        // Pointer to an external unmanaged resource.
        private IntPtr handle;
        // Other managed resource this class uses.
        private Component component = new Component();
        // Track whether Dispose has been called.
        private bool disposed = false;

        // The class constructor.
        public MyResource(IntPtr handle)
        {
            this.handle = handle;
        }

        // Dispose method is the only method to implement for IDisposable.
        // * Do not make this method virtual - A derived class should not be able to override this method.
        //** What if the person forgot to call Dispose() on your object? Then they would leak some unmanaged resources!
        public void Dispose()
        {
            Dispose(true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue (to the Freachable queue)
            // and prevent finalization code for this object from executing a second time.
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources
        // can be disposed.
        // If disposing equals false, the method has been called by the
        // runtime from inside the finalizer and you should not reference
        // other objects. Only unmanaged resources can be disposed.
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    // Dispose managed resources.
                    component.Dispose();
                }

                // Call the appropriate methods to clean up
                // unmanaged resources here.
                // If disposing is false,
                // only the following code is executed.
                CloseHandle(handle);
                handle = IntPtr.Zero;

                // Note disposing has been done.
                disposed = true;
            }
        }

        // Use interop to call the method necessary
        // to clean up the unmanaged resource.
        [System.Runtime.InteropServices.DllImport("Kernel32")]
        private extern static Boolean CloseHandle(IntPtr handle);

        // Use C# destructor syntax for finalization code.
        // This destructor will run only if the Dispose method
        // does not get called.
        // It gives your base class the opportunity to finalize.
        // Do not provide destructors in types derived from this class.
        ~MyResource()
        {
            // Do not re-create Dispose clean-up code here.
            // Calling Dispose(false) is optimal in terms of
            // readability and maintainability.
            Dispose(false);
        }
    }

    //Another way tto dispose unmanaged object is to use the "using"
    //The reason for the using statement is to ensure that the object is disposed
    //as soon as it goes out of scope, and it doesn't require explicit code to ensure that this happens.
    static string CalculateMD5(string filename)
    {
        using (var md5 = MD5.Create())
        {
            using (var stream = File.OpenRead(filename))
            {
                var hash = md5.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }
    }
    public static void Main()
    {
        string file_name = System.Environment.CurrentDirectory + "/../../resources/Avicii.mp3";

        FileStream SourceStream = File.Open(file_name, FileMode.Open);
        var ptr = Marshal.GetIUnknownForObject(SourceStream);
        MyResource myResource = new MyResource(ptr);
        myResource = null;

        //dispose using "using"
        //string md5 = CalculateMD5(file_name);
        //Console.WriteLine($"The md5 of is {md5}");

    }
}

/* More about
* Freachable what?
* You might ask. Freachable (pronounced F-reachable) is one of CLR Garbage Collector internal structures
* that is used in a finalization part of garbage collection. You might have heard about the Finalization
* queue where every object that needs finalization lands initially. This is determined based on whether
* he has a Finalize method, or it’s object type contains a Finalize method definition to speak more precisely.
* This seems like a good idea, GC wants to keep track of all objects that he needs to call Finalize on,
* so that when he collects he can find them easily. Why would he need another collection then?
* Well apparently what GC does when he finds a garbage object that is on Finalizable queue,
* is a bit more complicated than you might expect. GC doesn’t call the Finalize method directly,
* instead removes object reference from Finalizable queue and puts it on a (wait for it.. ) Freachable queue.
* Weird, huh? Well it turns out there is a specialized CLR thread that is only responsible for monitoring the
* Freachable queue and when GC adds new items there, he kicks in, takes objects one by one and calls it’s Finalize method.
* One important point about it is that you shouldn’t rely on Finalize method being called by the same
* thread as rest of you app, don’t count on Thread Local Storage etc.
*
* But what interest me more is why? Well the article doesn’t give an answer to that,
* but there are two things that come to my mind. First is performance, you obviously want the
* garbage collection to be as fast as possible and a great deal of work was put into making it so.
* It seems only natural to keep side tasks like finalization handled by a background thread,
* so that main one can be as fast a possible. Second, but not less important is that Finalize
* is after all a client code from the GC perspective, CLR can’t really trust your dear reader implementation.
* Maybe your Finalize will throw exception or will go into infinite loop? It’s not something you want to
* be a part of GC process, it’s much less dangerous if it can only affect a background thread.
*/
