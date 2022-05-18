using DirectoryHelpersLibrary.Classes;

namespace DirectoryHelpersLibrary.Models
{
    public class FileItem
    {
        public string Name { get; set; }
        public long Length { get; set; }
        public string Size => Length.SizeSuffix();
        public override string ToString() => $"{Name}, {Size}";
    }
}
