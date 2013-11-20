namespace MovingFeaturesBetweenObjects.HideDelegate
{
    public class DepartmentForHideDelegate
    {
        private readonly PersonForHideDelegate manager;

        public DepartmentForHideDelegate(PersonForHideDelegate manager)
        {
            this.manager = manager;
        }

        public PersonForHideDelegate GetManager()
        {
            return manager;
        }
    }
}