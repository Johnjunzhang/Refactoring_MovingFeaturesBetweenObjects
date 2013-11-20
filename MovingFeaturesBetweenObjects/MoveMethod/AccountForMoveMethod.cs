namespace MovingFeaturesBetweenObjects.MoveMethod
{
    public class AccountForMoveMethod
    {
        private readonly AccountTypeForMoveMethod type;
        private readonly double daysOverdrawn;

        public AccountForMoveMethod(AccountTypeForMoveMethod type, double daysOverdrawn)
        {
            this.type = type;
            this.daysOverdrawn = daysOverdrawn;
        }

        public double OverDraftCharge()
        {
            if (type.IsPremium())
            {
                double result = 10;
                if (daysOverdrawn > 7)
                    result += (daysOverdrawn - 7)*0.85;
                return result;
            }

            return daysOverdrawn*1.75;
        }

        public double BankCharge()
        {
            var result = 4.5;
            if (daysOverdrawn > 0)
                result += OverDraftCharge();
            return result;
        }
    }
}