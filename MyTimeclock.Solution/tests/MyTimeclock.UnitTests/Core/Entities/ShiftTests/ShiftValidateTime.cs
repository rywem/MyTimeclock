using MyTimeclock.Core.Entities;
using MyTimeclock.UnitTests.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyTimeclock.UnitTests.Core.Entities.ShiftTests
{
    public class ShiftTime
    {
        [Fact]
        public void DoesValidateSucceedWithValidTimeEntries()
        {
            ShiftBuilder builder = new ShiftBuilder();

            Assert.True(builder.WithValidTimes().ValidateTime());
        }

    }
}
