using System;

namespace _07_Timer
{
    internal class Timer
    {
        private int seconds;

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public override string ToString()
        {
            TimeSpan span = TimeSpan.FromSeconds(seconds);
            return (span.ToString());


        }

        internal string Padded(int v)
        {
            return v.ToString("00");
        }
    }
}