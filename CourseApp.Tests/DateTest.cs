using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DateTest
    {
        [Theory]
        [InlineData(2001, 7, 14, 19, 232, 7088)]
        [InlineData(1900, 1, 1, 120, 1451, 44172)]
        [InlineData(2018, 2, 5, 2, 34, 1038)]
        public void TestAge(int y, int m, int d, int expY, int expM, int expD)
        {
            DateTime brithday = new DateTime(y, m, d);
            DateTime date = new DateTime(2020, 12, 9);
            string exp = $"Age:\n day:{expD}\n Month:{expM}\n Year:{expY}";
            var res = Program.Age(brithday, date);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestDatesEqual()
        {
            DateTime brithday = new DateTime(2020, 12, 9);
            DateTime date = new DateTime(2020, 12, 9);
            string exp = "The dates are equal";
            var res = Program.Age(brithday, date);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestBrithdayLatelyToday()
        {
            DateTime brithday = new DateTime(2020, 12, 10);
            DateTime date = new DateTime(2020, 12, 9);
            string exp = "The date has not come";
            var res = Program.Age(brithday, date);
            Assert.Equal(exp, res);
        }
    }
}