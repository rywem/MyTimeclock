using MyTimeclock.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTimeclock.Core.Entities
{
    public class Shift
    {
        public int EmployeeId { get; set; }
        public TimeEntry TimeIn { get; set; }
        public TimeEntry TimeOut { get; set; }

        public Shift(int employeeId, TimeEntry timeIn, TimeEntry timeOut)
        {
            this.TimeIn = timeIn;
            this.TimeOut = timeOut;
            this.EmployeeId = employeeId;
        }

        public bool ValidateTime()
        {
            return TimeIn.Time < TimeOut.Time;
        } 
    }
}
