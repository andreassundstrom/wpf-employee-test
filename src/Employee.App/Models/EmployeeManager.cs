using System.Collections.ObjectModel;

namespace Employee.App.Models
{
    public static class EmployeeManager
    {
        public static ObservableCollection<Employee> Employees { get; set; } =
            new ObservableCollection<Employee> { new Employee { Name = "Andreas Sundström", Email = "andreas.sundstrom@hotmail.com" } };

        public static ObservableCollection<Employee> GetEmployees() => Employees;
        public static void AddEmployee(Employee NewEmployee) => Employees.Add(NewEmployee);
    }
}
