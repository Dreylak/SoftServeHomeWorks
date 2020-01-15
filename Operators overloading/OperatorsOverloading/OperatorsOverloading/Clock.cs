using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloading
{
    class Clock
    {
        public int Hours { get; set; }
        
        public int Minutes { get; set; }

        public int Seconds { get; set; }

        public Clock(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public void Normalize()
        {
            NormalizeSeconds();
            NormalizeMinutes();
            if (Hours < 0) Hours = 0;
        }

        private void NormalizeSeconds()
        {
            if (Seconds < 0)
            {
                Minutes -= (Math.Abs(Seconds) + 60) / 60;
                Seconds = 60 - (Math.Abs(Seconds) % 60);
            }
            else
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
        }

        private void NormalizeMinutes()
        {
            if (Minutes < 0)
            {
                Hours -= (Math.Abs(Minutes) + 60) / 60;
                Minutes = 60 - (Math.Abs(Minutes) % 60);
            }
            else
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        public override string ToString()
        {
            return $"Hours: {Hours} Minutes: {Minutes} Seconds: {Seconds}";
        }

        public static bool operator <(Clock c1, Clock c2)
        {
            if (c1.Hours == c2.Hours)
            {
                if (c1.Minutes == c2.Minutes)
                {
                    return c1.Seconds < c2.Seconds;
                }
                else return c1.Minutes < c2.Minutes;
            }
            else return c1.Hours < c2.Hours;
        }

        public static bool operator >(Clock c1, Clock c2)
        {
            return c2 < c1;
        }

        public static bool operator <=(Clock c1, Clock c2)
        {
            return c1 < c2 || c1 == c2;
        }

        public static bool operator >=(Clock c1, Clock c2)
        {
            return c1 > c2 || c1 == c2;
        }

        public static bool operator ==(Clock c1, Clock c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Clock c1, Clock c2)
        {
            return !(c1 == c2);
        }

        public static Clock operator +(Clock clock, Timer timer)
        {
            var result = new Clock(clock.Hours,
                    clock.Minutes + timer.Minutes,
                    clock.Seconds + timer.Seconds + timer.Milliseconds / 500);
            result.Normalize();

            return result;
        }

        public static Clock operator -(Clock clock, Timer timer)
        {
            var result = new Clock(clock.Hours,
                    clock.Minutes - timer.Minutes,
                    clock.Seconds - timer.Seconds - timer.Milliseconds / 500);
            result.Normalize();

            return result;
        }
    }
}
