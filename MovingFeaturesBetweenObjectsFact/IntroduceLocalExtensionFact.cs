using System;
using MovingFeaturesBetweenObjects.IntroduceLocalExtension;
using Xunit;

namespace MovingFeaturesBetweenObjectsFact
{
    public class IntroduceLocalExtensionFact
    {
        [Fact]
        public void should_get_correct_next_day()
        {
            var previousDate = new DateTime(2011, 11, 11);
            var calculateDate = new DateCalculator(previousDate);
            var nextDay = new DateTime(2011, 11, 12);
            Assert.Equal(nextDay, calculateDate.GetDate());
        }
    }
}