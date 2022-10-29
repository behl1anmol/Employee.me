using CommunityToolkit.Maui;
using Employee.me.View;
using Employee.me.ViewModel;

namespace Employee.me;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();

        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddSingleton<IEmployeeService,EmployeeService>();
        builder.Services.AddTransient<EmployeeView>();
        builder.Services.AddTransient<EmployeeViewModel>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();


        return builder.Build();
	}
}
