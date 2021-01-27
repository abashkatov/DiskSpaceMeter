﻿using DiskSpaceMeter.View;
using DiskSpaceMeter.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
            MainWindowContext context = new MainWindowContext();
            MainWindow window = new MainWindow(context);
            window.Show();
        }
    }
}
