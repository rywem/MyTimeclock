using MyTimeclock.Core.Entities;
using MyTimeclock.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTimeclock.UnitTests.Builders
{
    public class ShiftBuilder
    {
        private Shift _shift;

        public Shift WithValidTimes()
        {
            DateTime now = DateTime.Now;
            Shift shift = new Shift(1, new TimeEntry(now.AddHours(-2), MyTimeclock.Core.Enums.TimeEntryType.In), 
                new TimeEntry(now.AddHours(-1), MyTimeclock.Core.Enums.TimeEntryType.Out));

            return shift;
        }
    }
}
