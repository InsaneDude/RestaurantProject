using System;
using System.Collections.ObjectModel;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL;
using Restaurant.BL.Services.Abstract;
using Restaurant.WPF;
using Restaurant.WPF.ViewModels;

namespace Restaurant.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            // this.DataContext = new MainWindowViewModel(serviceProvider);
        }
    }
}