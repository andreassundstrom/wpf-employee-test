using Employee.App.Models;
using Employee.App.ViewModels;
using Employee.App.Views;
using System.Windows;

namespace Employee.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel vm { get; set; }
        public MainWindow()
        {
            vm = new MainViewModel();
            vm.Employees = EmployeeManager.GetEmployees();
            this.DataContext = vm;
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewUser newEmployeeDialog = new AddNewUser()
            {
                Owner = this
            };
            newEmployeeDialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            bool? result = newEmployeeDialog.ShowDialog();


        }
    }
}