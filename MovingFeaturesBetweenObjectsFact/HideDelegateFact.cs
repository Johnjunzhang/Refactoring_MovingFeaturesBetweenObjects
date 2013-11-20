using MovingFeaturesBetweenObjects.HideDelegate;
using Xunit;

namespace MovingFeaturesBetweenObjectsFact
{
    public class HideDelegateFact
    {
        [Fact]
        public void should_get_name_for_manager_of_john()
        {
            const string managerName = "Kent";
            var manager = new PersonForHideDelegate(managerName);
            var departmentForHideDelegate = new DepartmentForHideDelegate(manager);
            var employee = new PersonForHideDelegate(departmentForHideDelegate, "John");
            var managerForEmployee = employee.GetOwnDepartment().GetManager();
            Assert.Equal(managerName, managerForEmployee.Name);
        }
    }
}