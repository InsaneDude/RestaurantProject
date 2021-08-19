using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL;
using Restaurant.Mappers.MapperBLToModel;
using Restaurant.Mappers.MapperEntityToBL;
using Restaurant.WPF.ViewModels;

namespace Restaurant.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;
        
        public App()
        {
            var services = new ServiceCollection();
            services.RegisterDAL();
            services.RegisterBL();
            services.AddSingleton<MainWindow>();
            services.AddTransient<MainWindowViewModel>();
            serviceProvider = services.BuildServiceProvider(); 
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow app = serviceProvider.GetService<MainWindow>();
        }
    }
}
