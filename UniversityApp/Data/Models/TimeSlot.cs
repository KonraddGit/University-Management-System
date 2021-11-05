using System;
using System.Collections.Generic;

namespace UniversityApp.Data.Models
{
    public class TimeSlot
    {
        public int TimeSlotId { get; set; }
        public List<Days> Days { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public Subject Subject { get; set; }
    }

    public class Days
    {
        public int DaysId { get; set; }
        public DaysType Day { get; set; }
    }
    public enum DaysType
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
}