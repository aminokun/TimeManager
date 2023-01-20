using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager
{
    public class TimeSheet
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public TimeSpan TotalTime { get; private set; }

        public TimeSheet()
        {
            StartTime = DateTime.MinValue;
            EndTime = DateTime.MinValue;
            TotalTime = TimeSpan.Zero;
        }

        public void StartTimer()
        {
            StartTime = DateTime.Now;
        }

        public void StopTimer()
        {
            EndTime = DateTime.Now;
            TotalTime = EndTime - StartTime;
        }

        public TimeSpan GetTimeSpentOnTask(DateTime startDate, DateTime endDate)
        {
            if (StartTime < startDate)
            {
                startDate = StartTime;
            }
            if (EndTime > endDate)
            {
                endDate = EndTime;
            }
            return (endDate - startDate);
        }

        public void GenerateReport(DateTime startDate, DateTime endDate)
        {
            TimeSpan timeSpent = GetTimeSpentOnTask(startDate, endDate);
            double totalMinutes = timeSpent.TotalMinutes;
        }
    }
}
