
using System;
using System.Collections.Generic;
using FluentValidation;

namespace FluentValidationLibrary.Classes
{
    public static class GenericRules
    {
        /// <summary>
        /// Limits a list to less than <see cref="number"/>
        /// </summary>
        /// <typeparam name="T">model</typeparam>
        /// <typeparam name="TElement">property</typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="number">limit</param>
        /// <returns>is valid</returns>
        public static IRuleBuilderOptions<T, IList<TElement>> ListMustContainFewerThan<T, TElement>(this IRuleBuilder<T, IList<TElement>> ruleBuilder, int number)
        {

            return ruleBuilder.Must((_, list, context) =>
            {
                context.MessageFormatter.AppendArgument("MaxElements", number);
                return list.Count < number;
            }).WithMessage("{PropertyName} must contain fewer than {MaxElements} items.");
        }

    }
    
}
