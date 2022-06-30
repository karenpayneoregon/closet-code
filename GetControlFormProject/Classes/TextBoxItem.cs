namespace GetControlFormProject.Classes
{
    public class TextBoxItem
    {
        public string Name { get; }
        public string Text { get; }

        public TextBoxItem(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public override string ToString()
        {
            return $"{Name} = {Text}";
        }

    }
}