using DiskSpaceMeter.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using DiskSpaceMeter.Model.Navigator.Dto;
using System.Collections.ObjectModel;

namespace DiskSpaceMeter.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowContext context)
        {
            InitializeComponent();
            DataContext = context;

            string CurrentDirectory = Directory.GetCurrentDirectory();
            ObservableCollection<FileDto> files = new ObservableCollection<FileDto>();

            string[] items = Directory.GetFileSystemEntries(CurrentDirectory);
            foreach (string item in items) {
                files.Add(new FileDto(item));
            }
            //FileInfo fileInfo = new FileInfo(CurrentDirectory);
            files.Add(new FileDto(CurrentDirectory, ".."));

            context.Files = files;
        }
    }
}
