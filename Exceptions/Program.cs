using System;

/*
 * Exceptions are used to indicate that an error has occurred while running the program.
 * Exception objects that describe an error are created and then thrown with the throw keyword.
 * The runtime then searches for the most compatible exception handler.
 */

/*
* Exceptions contain a property named StackTrace.
* This string contains the name of the methods on the current call stack,
* together with the file name and line number where the exception was thrown for each method.
* A StackTrace object is created automatically by the common language runtime (CLR) from the point of the throw statement,
* so that exceptions must be thrown from the point where the stack trace should begin.
* */

/*
 * All exceptions contain a property named Message.
 * This string should be set to explain the reason for the exception.
 * Note that information that is sensitive to security should not be put in the message text.
 * In addition to Message, ArgumentException contains a property named ParamName that should be set to
 * the name of the argument that caused the exception to be thrown. In the case of a property setter,
 * ParamName should be set to value.
 */

/*
 * Throwing and catching exceptions is expensive compared to any normal return mechanism,
 * but it's kind of besides the point - we're not supposed to use exceptions as normal control-flow mechanisms,
 * but to handle exceptional things.
 */

 /*
  * Things to Avoid When Throwing Exceptions
    The following list identifies practices to avoid when throwing exceptions:
    1. Exceptions should not be used to change the flow of a program as part of ordinary execution. Exceptions should only be used to report and handle error conditions.
    2. Exceptions should not be returned as a return value or parameter instead of being thrown.
    3. Do not throw System.Exception, System.SystemException, System.NullReferenceException, or System.IndexOutOfRangeException intentionally from your own source code.
    4. Do not create exceptions that can be thrown in debug mode but not release mode. To identify run-time errors during the development phase, use Debug Assert instead.
 */

namespace Exceptions
{
    class MainClass
    {
        //Exception IlligalCardException
        public static void Main(string[] args)
        {

            int num = 0;
            int[] bs1 = new int[10];
            bool dontStop = true;
            //Using while - Exception handling recovery code
            int counter = 0;
            while (dontStop)
            {
                counter++;
                Console.WriteLine("please enter an index");
                string index = Console.ReadLine();
                num = int.Parse(index);
                
                //When an argument to a method causes an exception.
                try
                {
                    bs1[num] = num;
                    dontStop = false;
                }
                catch (IndexOutOfRangeException e)
                {
                    //throw new illegalCardException(e.Message, counter);
                    Console.WriteLine("Index was out of range");
                    Console.WriteLine(e.Message);
                }
            }

            //The method cannot complete its defined functionality.
            try
            {
                Object k = null;
                CopyObject(k);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Copy object failed");
                Console.WriteLine(e.Message);
                //rethrow exception
                //if you can add value on the specific exception, such as unique key violation,
                //You can throw a custom exception so that your system could present a meaningful error message.
                //here is an example for SQL
                //throw new Exception("SELECT....", "Error in data access layer");
            }

            //An inappropriate call to an object is made, based on the object state.
            try
            {
                WriteLog();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Write file has failed");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Write file has failed");
                Console.WriteLine(e.Message);
            }

            //The following example demonstrates a catch block that is defined to handle ArithmeticException errors.
            //This catch block also catches DivideByZeroException errors
            int x = 0;
            try
            {
                int y = 100 / x;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"ArithmeticException Handler: {e.Message}");
            }

            //Exception base class (all exception inhert from it)
            x = 0;
            try
            {
                int y = 100 / x;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e.Message}");
            }

            //Throw a userdefined exception
            try
            {
                Console.WriteLine("Do something wrong");
                throw new illegalCardException("This is a user defined exception");
            }
            catch (illegalCardException e)
            {
                Console.WriteLine($"EmployeeListNotFoundException: {e.Message}");
            }
        }
        //Throw exception
        static void CopyObject(Object original)
        {
            if (original == null)
            {
                Exception exc = new System.ArgumentException("Parameter cannot be null", "original");
                throw exc;
            }
        }

        static System.IO.FileStream logFile = null;
        void OpenLog(System.IO.FileInfo fileName, System.IO.FileMode mode) { }

        static void WriteLog()
        {
            if (logFile == null)//!logFile.CanWrite
            {
                throw new System.InvalidOperationException("Logfile cannot be read-only");
            }
            // Else write data to the log and return.
        }

    }
    //user-defined exception
    //When creating your own exceptions, end the class name of the user-defined exception with the word "Exception",
    //and implement the three common constructors, as shown in the following example.
    public class illegalCardException : Exception
    {
        public illegalCardException()
            : base("this is an empty exception")
        {
        }

        public illegalCardException(string message, int num_of_tries)
            : base(message + $"Card deck: {num_of_tries}")
        {
        }
        public illegalCardException(string message)
            : base(message)
        {
        }
        public illegalCardException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
