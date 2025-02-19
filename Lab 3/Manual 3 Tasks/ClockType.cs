using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Manual_3_Tasks
{
    public class ClockType
    {
        public TimeSpan currenttime;
        public TimeSpan elapsedtime;
        public TimeSpan remainingtime;
        private TimeSpan fartime;
        public ClockType(TimeSpan currenttime)
        {
            this.currenttime = currenttime;
        }
        public int elapsedTimeinSec(TimeSpan currenttime)
        {
            elapsedtime = currenttime- TimeSpan.Zero;
            int i = 0;
            int time;
            time = elapsedtime.Hours*3600+ elapsedtime.Minutes * 60+ elapsedtime.Seconds;
            return time;
        }
        public TimeSpan remainTime(TimeSpan currenttime)
        {
            remainingtime= TimeSpan.FromHours(24) - currenttime;
            return remainingtime;
        }
        public TimeSpan farClockCalulate()
        {
            if(elapsedtime>remainingtime)
            {
                fartime=elapsedtime-remainingtime;
            }
            else
            {
                fartime = remainingtime - elapsedtime;
            }
            return fartime;
        }
    }
}
