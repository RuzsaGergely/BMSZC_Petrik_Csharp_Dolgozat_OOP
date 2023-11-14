namespace RGG_Csharp_OOP_dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMSZC Petrik - Ruzsa Gergely Gábor - 2/14. SL - C# dolgozat OOP");
            Clock ora = new Clock(12, 30, 45, "UTC+2", true);
            List<Alarm> ebresztok = new List<Alarm>()
            {
                new Alarm(6,0),
                new Alarm(8,0)
            };
            Timer idozito = new Timer(10);

            ora.DisplayTime();

            foreach (var item in ebresztok)
            {
                if(item.IsAlarmTime(ora.Hour, ora.Minute))
                {
                    Console.WriteLine("Az ébresztő megszólalt!");
                }
            }
            idozito.StartTimer();
        }
    }
}