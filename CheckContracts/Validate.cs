using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace CheckContracts
{
    /// <summary>
    /// General validation class
    /// </summary>
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public static class Validate
    {
        /// <summary>
        /// Compares two input integers and raises exception if values are different.
        /// This checking is useful to check that two collections have the same size.
        /// </summary>
        [StringFormatMethod("messageFormat")]
        public static void AreEqual(int first, int second, string messageFormat, params object[] args)
        {
            Condition(first == second, messageFormat, args);
        }

        /// <summary>
        /// Checks that the target object is not null
        /// </summary>
        [StringFormatMethod("messageFormat")]
        [ContractAnnotation("targetObject:null => halt")]
        public static void IsNotNull(object targetObject, string messageFormat, params object[] args)
        {
            Condition(!ReferenceEquals(null, targetObject), messageFormat, args);
        }

        /// <summary>
        /// Checks that <paramref name="targetObject"/> object is not null. Otherwise raises exception with generic type details (it is better than NullReferenceException without the type details).
        /// </summary>
        [ContractAnnotation("targetObject:null => halt")]
        public static void IsNotNull<TInput>(TInput targetObject)
            where TInput : class
        {
            IsNotNull(targetObject, "The object with type {0} is null", typeof(TInput));
        }

        [StringFormatMethod("messageFormat")]
        public static void CollectionHasElements<TValue>(IEnumerable<TValue> elements, string messageFormat, params object[] args)
        {
            IsNotNull(elements, messageFormat, args);
            Condition(elements.Any(), messageFormat, args);
        }

        /// <summary>
        /// General conditions to check any. Raises InvalidOperationException in case of false input.
        /// </summary>
        [StringFormatMethod("messageFormat")]
        [ContractAnnotation("condition:false => halt")]
        public static void Condition(bool condition, string messageFormat, params object[] args)
        {
            if (!condition)
                throw new InvalidOperationException(string.Format(messageFormat, args));
        }

        /// <summary>
        /// General argument condition to check any. Raises InvalidOperationException in case of false input.
        /// </summary>
        [StringFormatMethod("messageFormat")]
        [ContractAnnotation("argumentCondition:false => halt")]
        public static void ArgumentCondition(bool argumentCondition, [InvokerParameterName] string argumentName, string messageFormat, params object[] args)
        {
            if (!argumentCondition)
                throw new ArgumentException(string.Format(messageFormat, args), argumentName);
        }

        [StringFormatMethod("messageFormat")]
        [ContractAnnotation("argument:null => halt")]
        public static void ArgumentIsNotNull(object argument, [InvokerParameterName()] string argumentName)
        {
            if (argument == null)
                throw new ArgumentNullException(argumentName);
        }

        [StringFormatMethod("messageFormat")]
        [ContractAnnotation("argument:null => halt")]
        public static void ArgumentStringIsMeanful(string argument, [InvokerParameterName()] string argumentName)
        {
            ArgumentIsNotNull(argument, argumentName);
            ArgumentCondition(!string.IsNullOrWhiteSpace(argument), argumentName, "String argument {0} should not be empty", argumentName);
        }

        /// <summary>
        /// Check that input value is greater or equal zero. Contract is useful for database objects checking.
        /// </summary>
        [StringFormatMethod("messageFormat")]
        [ContractAnnotation("argument:null => halt")]
        public static void ArgumentIntGreaterOrEqualZero(int argument, [InvokerParameterName()] string argumentName)
        {
            ArgumentCondition(argument >= 0, argumentName, "Argument {0} has value {1} which is less than zero", argumentName, argument);
        }

        [StringFormatMethod("messageFormat")]
        [ContractAnnotation("argument:null => halt")]
        public static void ArgumentIntLessThan(int argument, int limitValue, [InvokerParameterName()] string argumentName)
        {
            ArgumentCondition(argument < limitValue, argumentName, "Argument {0} should be less than {2}. Current value: {1}", argumentName, argument, limitValue);
        }

        [StringFormatMethod("messageFormat")]
        public static void CollectionArgumentHasElements<TValue>(IEnumerable<TValue> elements, [InvokerParameterName] string argumentName)
        {
            ArgumentIsNotNull(elements, argumentName);
            ArgumentCondition(elements.Any(), argumentName, "Collection of type {0}<{1}> does not contain elements", elements.GetType().Name, typeof(TValue));
        }

        /// <summary>
        /// Checks if the specified value is defined in enumeration. 
        /// </summary>
        /// <typeparam name="T">Argument type.</typeparam>
        /// <param name="argument">Argument.</param>
        /// <param name="argumentName">Argument name.</param>
        public static void ArgumentEnumerationValueIsDefined<T>(T argument, [InvokerParameterName] string argumentName = null)
            where T : struct, IComparable, IFormattable
        {
            Type enumerationType = typeof(T);

            ArgumentCondition(enumerationType.IsEnum, argumentName, "Parameter {0} should be enum", argumentName);
            ArgumentCondition(Enum.IsDefined(enumerationType, argument), argumentName, "Enumeration {0} does not contain value {1}.", enumerationType.Name, argument);
        }
    }
}
