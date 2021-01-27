using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskSpaceMeter.Model.Navigator.Dto
{
    public class FileDto
    {
        public FileDto(string path, string name) : this(path)
        {
            Name = name;
        }
        public FileDto(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            Path = path;
            Attributes = fileInfo.Attributes;
            Name = fileInfo.Name;
            if (Attributes != FileAttributes.Directory)
            {
                Size = fileInfo.Length;
            }
        }

        public string Name { set; get; }
        public string Path { set; get; }
        public long Size { set; get; }
        public FileAttributes Attributes { set; get; }
    }
}
