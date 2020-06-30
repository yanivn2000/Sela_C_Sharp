using System;

namespace CounterEventMichal
{
    class Program
    {
        static void Main(string[] args)
        {

            Counter counter1 = new Counter();

            Client client1 = new Client(counter1); // creating a new client with c1 as server

            counter1.tickUp();
            counter1.tickUp();
            counter1.tickUp();
            counter1.tickUp();
            counter1.tickDown();
            counter1.tickDown();
            counter1.tickDown();
            counter1.tickDown();
            counter1.tickDown();
            counter1.tickDown();
            counter1.tickDown();

        }
    }
}
