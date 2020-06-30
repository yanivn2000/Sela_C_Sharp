using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterEventMichal
{
    public class CounterEventArgs : EventArgs
    {
        public CounterEventArgs(int countedValue) { Counter = countedValue; }
        public int Counter { get; private set; }
        public string Name { get; private set; }
    }

    public delegate void CounterEventHandler(Counter sender, CounterEventArgs args);
    public delegate bool IsValidHandler(int counter);

    public class Counter
    {
        public event CounterEventHandler CounterEvent;
        public event IsValidHandler IsValidEvent;
        public Counter(int startVal = 0) { CountedValue = startVal; }
        public int CountedValue { get; private set; }
        public void tickUp()
        {
            if (IsValidEvent.Invoke(CountedValue + 1))
            {
                CountedValue++;
                OnTick();
            }
        }
        public void tickDown()
        {
            if (IsValidEvent.Invoke(CountedValue - 1))
            {
                CountedValue--;
                OnTick();
            }
        }
        private void OnTick()
        {
            if (CounterEvent != null)
            {
                CounterEventArgs args = new CounterEventArgs(this.CountedValue);
                CounterEvent.Invoke(this, args);
            }
        }

    }
}
