// In case you need some guidance: https://refactoring.guru/design-patterns/adapter

using System.Runtime.InteropServices;

namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem _thirdPartyBillingSystem = new();
        
        private readonly List<Employee> _employeeList = new();

        public void ProcessCompanySalary(string[,] employees)
        {

            for (int row = 0; row < employees.GetLength(0); row++)
            {
                int id = int.Parse(employees[row, 0]);
                string name = employees[row, 1];
                string designation = employees[row, 2];
                decimal salary = decimal.Parse(employees[row, 3]);
                
                _employeeList.Add(new Employee(id, name, designation, salary));
            }
            
        }

        public List<Employee> GetEmployeeList()
        {
            return _employeeList;
        }
        
        
    }
}
