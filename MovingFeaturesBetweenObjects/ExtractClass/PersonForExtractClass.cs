namespace MovingFeaturesBetweenObjects.ExtractClass
{
    public class PersonForExtractClass
    {
        private readonly string officeNumber;
        private readonly string officeAreaCode;

        public PersonForExtractClass(string officeAreaCode, string officeNumber)
        {
            this.officeAreaCode = officeAreaCode;
            this.officeNumber = officeNumber;
        }

        public string Name { get; set; }

        public string GetTelephoneNumber()
        {
            return ("(" + officeAreaCode + ") ") + officeNumber;
        }
    }
}