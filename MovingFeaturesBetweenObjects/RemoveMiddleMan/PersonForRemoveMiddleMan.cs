namespace MovingFeaturesBetweenObjects.RemoveMiddleMan
{
    public class PersonForRemoveMiddleMan
    {
        private readonly DepartmentForRemoveMiddleMan department;
        private readonly string name;

        public PersonForRemoveMiddleMan(DepartmentForRemoveMiddleMan department, string name)
        {
            this.department = department;
            this.name = name;
        }

        public PersonForRemoveMiddleMan(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public PersonForRemoveMiddleMan GetManager()
        {
            return department.GetManager();
        }
    }
}