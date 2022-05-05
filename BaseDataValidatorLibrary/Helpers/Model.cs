using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using BaseDataValidatorLibrary.Classes;
using BaseDataValidatorLibrary.CommonRules;

namespace BaseDataValidatorLibrary.Helpers
{
    public partial class Model
    {
        /// <summary>
        /// Validate entity against validation rules
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static EntityValidationResult Validate<T>(T entity) where T : class 
            => (new EntityValidator<T>()).Validate(entity);


    }
}

