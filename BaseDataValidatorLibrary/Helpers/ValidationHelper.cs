using System.Linq;
using System.Text;

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
        /// <summary>
        /// Validate entity
        /// </summary>
        /// <param name="entity">Customer instance</param>
        /// <returns>success and if not valid error messages</returns>
        public static (bool success, string errorMessages) IsValidEntity<T>(T entity) where T : class
        {
            var result = ValidateEntity(entity);

            if (result.IsNotValid)
            {
                StringBuilder builder = new();
                if (result.Errors.Count == 1)
                {
                    return (false, result.Errors.FirstOrDefault()!.ErrorMessage);
                }
                else
                {
                    result.Errors.ToList().ForEach(x => builder.AppendLine(x.ErrorMessage));
                    return (false, builder.ToString());
                }

            }
            else
            {
                return (true, null);
            }
        }
    }
}
