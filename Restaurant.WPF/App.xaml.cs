using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL;
using Restaurant.DAL;
using Restaurant.WPF.ViewModels;

namespace Restaurant.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;
        
        public App()
        {
            var services = new ServiceCollection();
            services.RegisterDAL();
            services.RegisterBL();
            services.AddScoped<MainWindowViewModel>();
            _serviceProvider = services.BuildServiceProvider(); 
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = _serviceProvider.GetService<MainWindowViewModel>();
        }
    }
}
