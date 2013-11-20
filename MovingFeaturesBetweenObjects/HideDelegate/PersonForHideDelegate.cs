namespace MovingFeaturesBetweenObjects.HideDelegate
{
    public class PersonForHideDelegate
    {
        private readonly DepartmentForHideDelegate ownDepartment;
        private readonly string name;

        public PersonForHideDelegate(DepartmentForHideDelegate ownDepartment, string name)
        {
            this.ownDepartment = ownDepartment;
            this.name = name;
        }

        public PersonForHideDelegate(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public DepartmentForHideDelegate GetOwnDepartment()
        {
            return ownDepartment;
        }
    }
}