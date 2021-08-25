using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL;
using Restaurant.BL.Services;
using Restaurant.BL.Services.Abstract;
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
            services.AddTransient<MainWindowViewModel>();
            _serviceProvider = services.BuildServiceProvider();
        }
        
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow mainWindow = new MainWindow();
            MainWindowViewModel context = _serviceProvider.GetService<MainWindowViewModel>();
            var menuService = _serviceProvider.GetService<IMenuService>();
            mainWindow.DataContext = context;
            mainWindow.Show();
        }
    }
}
