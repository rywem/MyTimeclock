using MyTimeclock.Core.Enums;
using MyTimeclock.SharedKernal;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTimeclock.Core.ValueObjects
{
    public class TimeEntry : ValueObject
    {
        public DateTime Time { get; private set; }
        public TimeEntryType Type { get; private set; }

        public TimeEntry(DateTime time, TimeEntryType type)
        {
            this.Time = time;
            this.Type = type;
        }
    }
}
