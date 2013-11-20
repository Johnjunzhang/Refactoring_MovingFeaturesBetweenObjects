namespace MovingFeaturesBetweenObjects.InlineClass
{
    public class TelephoneNumberForInlineClass
    {
        private readonly string officeAreaCode;
        private readonly string officeNumber;

        public TelephoneNumberForInlineClass(string officeAreaCode, string officeNumber)
        {
            this.officeAreaCode = officeAreaCode;
            this.officeNumber = officeNumber;
        }
        public string GetTelephoneNumber()
        {
            return ("(" + officeAreaCode + ") ") + officeNumber;
        }
    }
}