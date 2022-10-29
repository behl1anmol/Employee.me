using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Employee.me.ViewModel;


[INotifyPropertyChanged]
public partial class MainPageViewModel
{
    private readonly IEmployeeService _employeeService;

    [ObservableProperty]
    public bool _isVisible = false;

    [ObservableProperty]
    public bool _isRunning = false;


    public MainPageViewModel(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [RelayCommand]
    public async void ButtonClicked()
    {
        IsVisible = true;
        IsRunning = true;
        var emps = new ObservableCollection<EmployeeModel>(await _employeeService.GetAllEmployees());

        await Shell.Current.GoToAsync(nameof(EmployeeView), true,
            new Dictionary<string, object>()
            {
                ["Employees"] = emps,
            });

        IsVisible = false;
        IsRunning = false;
    }
}
