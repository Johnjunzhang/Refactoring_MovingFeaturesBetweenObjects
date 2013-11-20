using MovingFeaturesBetweenObjects.RemoveMiddleMan;
using Xunit;

namespace MovingFeaturesBetweenObjectsFact
{
    public class RemoveMiddleManFact
    {
        [Fact]
        public void should_get_name_for_manager_of_john()
        {
            const string managerName = "Kent";
            var manager = new PersonForRemoveMiddleMan(managerName);
            var department = new DepartmentForRemoveMiddleMan(manager);
            var employee = new PersonForRemoveMiddleMan(department, "John");
            var managerForEmployee = employee.GetManager();
            Assert.Equal(managerName, managerForEmployee.Name);
        }
    }
}