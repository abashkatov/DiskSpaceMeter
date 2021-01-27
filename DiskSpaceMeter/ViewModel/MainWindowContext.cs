using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using FileDto = DiskSpaceMeter.Model.Navigator.Dto.FileDto;

namespace DiskSpaceMeter.ViewModel
{
    public class MainWindowContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<FileDto> _files;
        public ObservableCollection<FileDto> Files
        {
            get => _files;
            set
            {
                _files = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Files)));
            }
        }
        private string _currentDirectory = Directory.GetCurrentDirectory();
        public string CurrentDirectory
        {
            get => _currentDirectory;
            set
            {
                _currentDirectory = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentDirectory)));
            }
        }
    }
}
