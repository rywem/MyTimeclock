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
    }
}
