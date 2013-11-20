using System;

namespace MovingFeaturesBetweenObjects.IntroduceForeignMethod
{
    public class DateManager
    {
        private DateTime previousDate;

        public DateManager(DateTime previousDate)
        {
            this.previousDate = previousDate;
        }

        public DateTime GetDate()
        {
            return new DateTime(previousDate.Year, previousDate.Month, previousDate.Day + 1);
        }
    }
}