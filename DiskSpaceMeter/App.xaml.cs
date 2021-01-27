using DiskSpaceMeter.View;
using DiskSpaceMeter.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace DiskSpaceMeter
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<MainWindowContext>();
            services.AddSingleton<MainWindow>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            MainWindow window = serviceProvider.GetService<MainWindow>();
            window.Show();
        }
    }
}
