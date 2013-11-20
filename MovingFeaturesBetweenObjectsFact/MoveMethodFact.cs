using MovingFeaturesBetweenObjects.MoveMethod;
using Xunit;

namespace MovingFeaturesBetweenObjectsFact
{
    public class MoveMethodFact
    {
        [Fact]
        public void should_not_get_over_draft_charge_given_is_premium_and_days_over_drawn_less_than_seven_days()
        {
            const bool isPremium = true;
            var accountTypeForMoveMethod = new AccountTypeForMoveMethod(isPremium);
            var accountForMoveMethod = new AccountForMoveMethod(accountTypeForMoveMethod, 6);
            Assert.Equal(14.5, accountForMoveMethod.BankCharge());
        }

        [Fact]
        public void should_get_over_draft_charge_given_is_premium_and_days_over_drawn_more_than_seven_days()
        {
            const bool isPremium = true;
            var accountTypeForMoveMethod = new AccountTypeForMoveMethod(isPremium);
            var accountForMoveMethod = new AccountForMoveMethod(accountTypeForMoveMethod, 8);
            Assert.Equal(15.35, accountForMoveMethod.BankCharge());
        }

        [Fact]
        public void should_get_over_draft_charge_given_is_not_premium()
        {
            const bool isPremium = false;
            var accountTypeForMoveMethod = new AccountTypeForMoveMethod(isPremium);
            var accountForMoveMethod = new AccountForMoveMethod(accountTypeForMoveMethod, 6);
            Assert.Equal(15, accountForMoveMethod.BankCharge());
        }

        [Fact]
        public void should_not_get_over_draft_charge_given_days_over_drawn_is_zero()
        {
            const bool isPremium = false;
            var accountTypeForMoveMethod = new AccountTypeForMoveMethod(isPremium);
            var accountForMoveMethod = new AccountForMoveMethod(accountTypeForMoveMethod, 0);
            Assert.Equal(4.5, accountForMoveMethod.BankCharge());
        }
    }
}