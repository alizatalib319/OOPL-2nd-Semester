using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manual_3_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime time= DateTime.Now;
            TimeSpan currenttime;
            TimeSpan farTime;
            currenttime = TimeSpan.Parse(time.ToString("HH:mm:ss"));
            Console.WriteLine(currenttime);
            ClockType s=new ClockType(currenttime);
            int timeSeconds;
            timeSeconds = s.elapsedTimeinSec(currenttime);
            Console.WriteLine(timeSeconds);
            Console.WriteLine(s.remainTime(currenttime));
            farTime=s.farClockCalulate();
            Console.WriteLine(farTime);
            Console.ReadKey();

        }
    }
}
