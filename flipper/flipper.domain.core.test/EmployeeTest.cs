using Xunit.Sdk;

namespace flipper.domain.core.test
{
    [TestClass]
    public class EmployeeTest
    {
        Employee employee;

        [TestMethod]
        public void TestCreate()
        {
            employee = new Employee("Vitor", 34, DateTime.Now, true);
            
        }
    }
}