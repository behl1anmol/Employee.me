using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;

namespace Employee.me.ViewModel;

[INotifyPropertyChanged]
[QueryProperty(nameof(Employees), "Employees")]
public partial class EmployeeViewModel
{

    [ObservableProperty]
    public ObservableCollection<EmployeeModel> _employees;

    public EmployeeViewModel()
    {
    }


}
