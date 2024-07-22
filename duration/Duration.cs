using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_5.duration
{
    public class Duration
    {
        #region Attributes
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region constructor
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration() : this(0, 0, 0) { }
        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            seconds %= 3600;
            Minutes = seconds / 60;
            Seconds = seconds % 60;
        }
        #endregion

        #region Impemented functions
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration duration)
            {
                return Hours == duration.Hours && Minutes == duration.Minutes && Seconds == duration.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        #endregion

        #region functions
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.Hours > d2.Hours || (d1.Hours == d2.Hours && d1.Minutes > d2.Minutes) || (d1.Hours == d2.Hours && d1.Minutes == d2.Minutes && d1.Seconds > d2.Seconds);
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.Hours < d2.Hours || (d1.Hours == d2.Hours && d1.Minutes < d2.Minutes) || (d1.Hours == d2.Hours && d1.Minutes == d2.Minutes && d1.Seconds < d2.Seconds);
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return (d1 < d2);
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return (d1 > d2);
        }
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        } 
        #endregion
    }
}
