using MovingFeaturesBetweenObjects.ExtractClass;
using Xunit;

namespace MovingFeaturesBetweenObjectsFact
{
    public class ExtractClassFact
    {
        [Fact]
        public void should_get_correct_telephone_number()
        {
            var personForExtractClass = new PersonForExtractClass("CA", "01");
            Assert.Equal("(CA) 01", personForExtractClass.GetTelephoneNumber());
        }
    }
}