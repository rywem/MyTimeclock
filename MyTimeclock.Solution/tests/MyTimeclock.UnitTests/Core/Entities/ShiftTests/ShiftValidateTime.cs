using MyTimeclock.Core.Entities;
using MyTimeclock.UnitTests.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyTimeclock.UnitTests.Core.Entities.ShiftTests
{
    public class ShiftValidateTime
    {
        [Fact]
        public void ValidateReturnTrueIfTimeInChronologicalOrder()
        {
            ShiftBuilder builder = new ShiftBuilder();
            Shift shift = builder.WithValidTimes();
            Assert.True(shift.ValidateTime());
        }

        [Fact]
        public void ValidateReturnFalseIfTimeInReverseOrder()
        {
            ShiftBuilder builder = new ShiftBuilder();
            Shift shift = builder.WithTimesInReverseOrder();
            Assert.False(shift.ValidateTime());
        }
    }
}
