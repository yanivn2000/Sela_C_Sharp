﻿using System;

namespace EventHandler1
{
    class Program
    {
        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            //bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.ProcessCompletedBool += bl_ProcessCompletedBool;

            while(true)
                bl.ReadNumber();
        }

        // event handler
        public static void bl_ProcessCompleted(object sender, EventArgs e)
        {
            ProcessBusinessLogic pbl = sender as ProcessBusinessLogic;
            Console.WriteLine(pbl.information);
        }
        // event handler
        public static void bl_ProcessCompletedBool(object sender, bool isTrue)
        {
            if(isTrue)
                Console.WriteLine("User entered a number");
            else
                Console.WriteLine("User entered a NONE number");

            //ProcessBusinessLogic pbl = sender as ProcessBusinessLogic;
            //Console.WriteLine(pbl.information);
        }
    }
}
