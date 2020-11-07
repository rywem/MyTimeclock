using MyTimeclock.SharedKernal;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTimeclock.Core.Entities
{
    public class Employee : BaseEntity
    {
        public string UserId { get; set; } // Id from .NET Identity
        public decimal HourlyRate { get; set; }
        public DateTime StartDate { get; set; }
    }
}
