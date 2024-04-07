using Employee.App.Models;
using Employee.App.ViewModels;
using System.Windows;

namespace Employee.App.Views
{
    /// <summary>
    /// Interaction logic for AddNewUser.xaml
    /// </summary>
    public partial class AddNewUser : Window
    {
        public AddNewUserViewModel vm { get; set; }
        public AddNewUser()
        {
            vm = new AddNewUserViewModel();
            this.DataContext = vm;
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            EmployeeManager.AddEmployee(new Models.Employee { Email = vm.Email, Name = vm.Name });
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
