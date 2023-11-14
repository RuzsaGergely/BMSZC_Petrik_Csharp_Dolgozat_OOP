using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGG_Csharp_OOP_dolgozat
{
    public class Timer
    {
        public int RemainingSeconds { get; set; }
        public Timer(int remainingSeconds)
        {
            RemainingSeconds = remainingSeconds;
        }

        public void SetTime(int seconds)
        {
            RemainingSeconds = seconds;
        }

        public void StartTimer()
        {
            // Nem teljesen értem a feladatot itt, de... feltételezzük, hogy 1 ciklus 1 másodperc. 

            for (int i = RemainingSeconds; i > 0; i--)
            {
                Console.WriteLine(RemainingSeconds - i);

            }
        }
    }
}
