using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataBindValidate.Classes
{

    public class EntityValidationResult
    {
        public IList<ValidationResult> Errors { get; set; }

        public bool HasError => Errors.Count > 0;

        public bool IsValid => Errors.Count == 0;
        public bool IsNotValid => Errors.Count > 0;

        public EntityValidationResult(IList<ValidationResult> errors = null)
        {
            this.Errors = errors ?? new List<ValidationResult>();
        }
    }
    public class EntityValidator<T> where T : class
    {
        public EntityValidationResult Validate(T entity)
        {
            var validationResults = new List<ValidationResult>();
            var vc = new ValidationContext(entity, null, null);
            var isValid = Validator.TryValidateObject(entity, vc, validationResults, true);

            return new EntityValidationResult(validationResults);

        }
    }
}
