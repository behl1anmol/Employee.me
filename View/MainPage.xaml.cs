using System.Runtime.CompilerServices;

namespace Employee.me.View;

public partial class MainPage : ContentPage
{

    public MainPage(MainPageViewModel _viewModel)
    {
        InitializeComponent();
        BindingContext = _viewModel;
    }

}

