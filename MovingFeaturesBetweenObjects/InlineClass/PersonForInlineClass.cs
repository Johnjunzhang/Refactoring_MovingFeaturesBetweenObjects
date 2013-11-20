namespace MovingFeaturesBetweenObjects.InlineClass
{
    public class PersonForInlineClass
    {
        private readonly TelephoneNumberForInlineClass telephoneNumberForInlineClass;

        public PersonForInlineClass(string officeAreaCode, string officeNumber)
        {
            telephoneNumberForInlineClass = new TelephoneNumberForInlineClass(officeAreaCode, officeNumber);
        }

        public string Name { get; set; }

        public string GetTelephoneNumber()
        {
            return telephoneNumberForInlineClass.GetTelephoneNumber();
        }
    }
}