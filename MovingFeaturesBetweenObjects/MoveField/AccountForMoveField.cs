namespace MovingFeaturesBetweenObjects.MoveField
{
    public class AccountForMoveField
    {
        private readonly AccountTypeForMoveField accountTypeForMoveField;
        private readonly decimal interestRate;

        public AccountForMoveField(AccountTypeForMoveField accountTypeForMoveField, decimal interestRate)
        {
            this.accountTypeForMoveField = accountTypeForMoveField;
            this.interestRate = interestRate;
        }

        public decimal InterestForAmountDays(decimal amount, int days)
        {
            return interestRate * amount * days / 365;
        }

        public decimal MethodIsUsingInterestRate1()
        {
            return interestRate*2;
        }

        public decimal MethodIsUsingInterestRate2()
        {
            return interestRate*3;
        }
    }
}