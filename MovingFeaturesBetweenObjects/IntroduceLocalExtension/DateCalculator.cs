using System;

namespace MovingFeaturesBetweenObjects.IntroduceLocalExtension
{
    public class DateCalculator
    {
        private DateTime previousDate;

        public DateCalculator(DateTime previousDate)
        {
            this.previousDate = previousDate;
        }

        public DateTime GetDate()
        {
            return new DateTime(previousDate.Year, previousDate.Month, previousDate.Day + 1);
        }
    }
}