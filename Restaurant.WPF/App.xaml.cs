using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL;
using Restaurant.BL.Services.Abstract;
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
            services.RegisterBL();
            serviceProvider = services.BuildServiceProvider();
        }

        // protected override void OnStartup(StartupEventArgs e)
        // {
        // MainWindowViewModel mainWindowViewModel = new MainWindowViewModel(
        //     serviceProvider.GetService<IOrderService>(),
        //     serviceProvider.GetService<IChiefService>(),
        //     serviceProvider.GetService<IMenuService>(),
        //     serviceProvider.GetService<IInstrumentService>());
        //     MainWindow mainWindow = new MainWindow();    
        //     mainWindow.DataContext = mainWindowViewModel;
        //     MainWindow.Show();
        // }
    }
}
