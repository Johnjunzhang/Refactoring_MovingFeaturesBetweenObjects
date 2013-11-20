namespace MovingFeaturesBetweenObjects.MoveMethod
{
    public class AccountTypeForMoveMethod
    {
        private readonly bool isPremium;

        public AccountTypeForMoveMethod(bool isPremium)
        {
            this.isPremium = isPremium;
        }

        public bool IsPremium()
        {
            return isPremium;
        }
    }
}