using System;
using System.Collections.Generic;
using System.Linq;

namespace Clock
{
    public class Clock
    {
        public int ClockHour;
        public int ClockMinute;
        public int HourHandAnglex2;
        public int MinuteHandAngle;


        public Clock (int clockHour, int clockMinute)
        {
            ClockHour = clockHour;
            ClockMinute = clockMinute;

        }

        public float Distance()
        {
           
           MinuteHandAngle = ClockMinute*6;
           HourHandAnglex2 = ClockHour*60 + ClockMinute;
           return Math.Abs(Convert.ToSingle(HourHandAnglex2)/2-Convert.ToSingle(MinuteHandAngle));
        }

        

    
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the hour and the minute");
            int clockHour = int.Parse(Console.ReadLine());
            int clockMinute = int.Parse(Console.ReadLine());


            Clock clock = new Clock(clockHour,clockMinute);
            Console.WriteLine(clock.Distance());

        }
    }

}