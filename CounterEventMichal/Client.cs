using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterEventMichal
{
    public class Client
    {
        private Counter _server;
        public Client(Counter server)
        {
            _server = server;
            server.CounterEvent += onTick;
            server.IsValidEvent += isValid;
        }
        public void onTick(Counter sender, CounterEventArgs args)
        {
            Console.WriteLine("Client got a tick, counter is: {0}", args.Counter);
        }
        public bool isValid(int counter)
        {
            if (counter > 0 && counter < 5) return true;
            return false;
        }
    }
}
