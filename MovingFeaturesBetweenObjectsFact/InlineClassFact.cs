using MovingFeaturesBetweenObjects.InlineClass;
using Xunit;

namespace MovingFeaturesBetweenObjectsFact
{
    public class InlineClassFact
    {
        [Fact]
        public void should_get_correct_telephone_number()
        {
            var personForExtractClass = new PersonForInlineClass("CA", "01");
            Assert.Equal("(CA) 01", personForExtractClass.GetTelephoneNumber());
        }
    }
}