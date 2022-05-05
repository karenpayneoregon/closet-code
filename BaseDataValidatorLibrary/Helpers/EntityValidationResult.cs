using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.Helpers
{
    public class EntityValidationResult
    {
        /// <summary>
        /// List of validation errors
        /// </summary>
        public IList<ValidationResult> Errors { get; set; }

        /// <summary>
        /// Model has errors
        /// </summary>
        public bool HasError => Errors.Count > 0;
        /// <summary>
        /// Model is valid
        /// </summary>
        public bool IsValid => Errors.Count == 0;

        public EntityValidationResult(IList<ValidationResult> errors = null)
        {
            Errors = errors ?? new List<ValidationResult>();
        }
    }
}