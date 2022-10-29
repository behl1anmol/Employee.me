namespace Employee.me.View;

public partial class EmployeeView : ContentPage
{
	public EmployeeView(EmployeeViewModel _viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel;
	}
}