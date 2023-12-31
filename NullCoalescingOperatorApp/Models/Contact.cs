namespace NullCoalescingOperatorApp.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// This works if a property is null, if an empty string use string.IsNullOrWhitespace
        /// </summary>
        public string DisplayCoalescing =>
            $"Name: {(FirstName ?? "no first"), -10} {(LastName ?? "no last"), -10} " +
            $"Mail: {(Email ?? "no mail")}";

        public override string ToString() => $"'{FirstName}' '{LastName}'";

    }
}
