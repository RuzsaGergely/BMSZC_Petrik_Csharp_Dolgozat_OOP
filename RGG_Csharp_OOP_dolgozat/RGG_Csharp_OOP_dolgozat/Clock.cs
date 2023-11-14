﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGG_Csharp_OOP_dolgozat
{
    public class Clock
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string TimeZone {  get; set; }
        public bool Is24HourFormat { get; set; }

        public Clock(int hour, int minute, int second, string timeZone, bool is24HourFormat)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            TimeZone = timeZone;
            Is24HourFormat = is24HourFormat;
        }
        
        public void SetTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public void DisplayTime()
        {
            Console.WriteLine($"{Hour}:{Minute}:{Second} {TimeZone}");
        }

        public void SetTimeZone(string timezone)
        {
            TimeZone = timezone;
        }

        public void ToggleTimeFormat()
        {
            if(Is24HourFormat)
            {
                Is24HourFormat = false;
            } else
            {
                Is24HourFormat = true;
            }
        }

    }
}
