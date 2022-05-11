namespace BaseDataValidatorLibrary.Helpers
{
    public class ValidationHelper
    {
        /// <summary>
        /// Validate entity against validation rules
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static EntityValidationResult ValidateEntity<T>(T entity) where T : class
        {
            return (new EntityValidator<T>()).Validate(entity);
        }
    }
}
