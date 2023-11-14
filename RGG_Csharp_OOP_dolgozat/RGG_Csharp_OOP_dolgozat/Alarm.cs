using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGG_Csharp_OOP_dolgozat
{
    public class Alarm
    {
        public int AlarmHour { get; set; }
        public int AlarmMinute { get; set;}
        public bool IsAlarmOn { get; set; }

        public Alarm(int alarmHour, int alarmMinute)
        {
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
            IsAlarmOn = true;
        }

        public void SetAlarm(int hour, int minute)
        {
            AlarmHour = hour;
            AlarmMinute = minute;
        }


        public void TurnAlarmOn()
        {
            IsAlarmOn = true;
        }

        public void TurnAlarmOff()
        {
            IsAlarmOn = false;
        }

        public bool IsAlarmTime(int hour, int minute)
        {
            if(hour ==  AlarmHour && minute == AlarmMinute)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
