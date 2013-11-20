namespace MovingFeaturesBetweenObjects.RemoveMiddleMan
{
    public class DepartmentForRemoveMiddleMan
    {
        private readonly PersonForRemoveMiddleMan manager;

        public DepartmentForRemoveMiddleMan(PersonForRemoveMiddleMan manager)
        {
            this.manager = manager;
        }

        public PersonForRemoveMiddleMan GetManager()
        {
            return manager;
        }
    }
}