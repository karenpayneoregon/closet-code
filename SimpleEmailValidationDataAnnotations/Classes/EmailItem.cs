namespace SimpleEmailValidationDataAnnotations.Classes
{
    public class EmailItem
    {
        public Human Human { get; }
        public bool IsValid { get; }

        public EmailItem(Human human, bool isValid)
        {
            Human = human;
            IsValid = isValid;
        }

        public override string ToString()
        {
            return $"{{ Human = {Human}, IsValid = {IsValid} }}";
        }
    }
}