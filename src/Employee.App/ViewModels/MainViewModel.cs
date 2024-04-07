using System.Collections.ObjectModel;

namespace Employee.App.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Models.Employee> Employees { get; set; } = new() { new Models.Employee() { Email = "test@test.se", Name = "Tester" } };
    }
}
