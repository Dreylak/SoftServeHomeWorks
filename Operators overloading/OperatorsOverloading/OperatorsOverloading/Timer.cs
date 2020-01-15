using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloading
{
    class Timer
    {
        public int Minutes { get; set; }

        public int Seconds { get; set; }

        public int Milliseconds { get; set; }

        public Timer(int minutes, int seconds, int milliseconds)
        {
            Minutes = minutes;
            Seconds = seconds;
            Milliseconds = milliseconds;
        }

        public override string ToString()
        {
            return $"Minutes: {Minutes} Seconds: {Seconds} Milliseconds: {Milliseconds}";
        }

        public static bool operator < (Timer t1, Timer t2)
        {
            if (t1.Minutes == t2.Minutes)
            {
                if (t1.Seconds == t2.Seconds)
                {
                    return t1.Milliseconds < t2.Milliseconds;
                }
                else return t1.Seconds < t2.Seconds;
            }
            else return t1.Minutes < t2.Minutes;
        }

        public static bool operator >(Timer t1, Timer t2)
        {
            return t2 < t1;
        }

        public static bool operator <=(Timer t1, Timer t2)
        {
            return t1 < t2 || t1 == t2;
        }

        public static bool operator >=(Timer t1, Timer t2)
        {
            return t1 > t2 || t1 == t2;
        }

        public static bool operator ==(Timer t1, Timer t2)
        {
            return t1.Equals(t2);
        }

        public static bool operator !=(Timer t1, Timer t2)
        {
            return !(t1 == t2);
        }
    }
}
