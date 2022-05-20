namespace DataBindValidate.Classes
{
    public class ErrorDetail
    {
        /// <summary>
        /// Property
        /// </summary>
        public string PropertyName { get; }
        /// <summary>
        /// Validation error message
        /// </summary>
        public string Message { get; }

        public ErrorDetail(string propertyName, string message)
        {
            PropertyName = propertyName;
            Message = message;
        }

        public override string ToString() => PropertyName;
    }
}