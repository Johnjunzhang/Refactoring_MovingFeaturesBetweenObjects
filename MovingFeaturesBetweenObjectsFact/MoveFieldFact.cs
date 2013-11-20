using MovingFeaturesBetweenObjects.MoveField;
using Xunit;

namespace MovingFeaturesBetweenObjectsFact
{
    public class MoveFieldFact
    {
        [Fact]
        public void should_get_correct_interest_for_amount_days()
        {
            var accountTypeForMoveField = new AccountTypeForMoveField();
            const decimal interestRate = 0.03M;
            var accountForMoveField = new AccountForMoveField(accountTypeForMoveField, interestRate);
            Assert.Equal(30, accountForMoveField.InterestForAmountDays(1000, 365));
        }
    }
}