namespace BaseConsoleCoreTemplate.Models
{
    public class Settings
    {
        public string Title { get; set; }
        public bool FullScreen { get; set; }
        public override string ToString() => Title;
    }
}
