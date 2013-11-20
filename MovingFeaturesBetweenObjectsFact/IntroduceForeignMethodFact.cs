using System;
using MovingFeaturesBetweenObjects.IntroduceForeignMethod;
using Xunit;

namespace MovingFeaturesBetweenObjectsFact
{
    public class IntroduceForeignMethodFact
    {
        [Fact]
        public void should_get_correct_next_day()
        {
            var previousDate = new DateTime(2011, 11, 11);
            var calculateDate = new DateManager(previousDate);
            var nextDay = new DateTime(2011, 11, 12);
            Assert.Equal(nextDay, calculateDate.GetDate());
        }
    }
}