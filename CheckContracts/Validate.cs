using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using JetBrains.Annotations;

namespace CheckContracts
{
    /// <summary>
    /// General validation class
    /// </summary>
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    [DebuggerStepThrough]
    public static partial class Validate
    {
        private static readonly DateTime MinDate = new DateTime(1900, 01, 01, 00, 00, 00, DateTimeKind.Utc);

        /// <summary>
        /// Checks that the target object is not null
        /// </summary>
        [StringFormatMethod("messageFormat")]
        [ContractAnnotation("targetObject:null => halt")]
        public static void IsNotNull([CanBeNull] object targetObject, string messageFormat, params object[] args)
        {
            Condition(!ReferenceEquals(null, targetObject), messageFormat, args);
        }

        /// <summary>
        /// Checks that <paramref name="targetObject"/> object is not null. Otherwise raises exception with generic type details (it is better than NullReferenceException without the type details).
        /// </summary>
        [ContractAnnotation("targetObject:null => halt")]
        public static void IsNotNull<TInput>([CanBeNull] TInput targetObject)
            where TInput : class
        {
            IsNotNull(targetObject, "The object with type {0} is null", typeof(TInput));
        }

        /// <summary>
        /// Checks that input argument is not null (for nullable types)
        /// </summary>
        [StringFormatMethod("messageFormat")]
        [ContractAnnotation("argument:null => halt")]
        public static void ArgumentIsNotNull<TValue>([CanBeNull] TValue argument, [InvokerParameterName()] string argumentName)
        {
            if (argument == null)
                throw new ArgumentNullException(argumentName,
                    $"Argument '{argumentName}' with type {typeof(TValue)} is null");
        }

        private static string BuildMessage(string defaultFormatPerffix, object[] systemArguments, string userFormat, object[] userArguments, string argumentName = null)
        {
            var builder = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(argumentName))
            {
                builder.AppendFormat("Invalid argument {0}. ", argumentName);
            }

            if (!string.IsNullOrWhiteSpace(defaultFormatPerffix))
            {
                builder.AppendFormat(defaultFormatPerffix, systemArguments);
                builder.Append(". ");
            }

            if (!string.IsNullOrWhiteSpace(userFormat))
            {
                builder.AppendFormat(userFormat, userArguments);
            }

            return builder.ToString();
        }
    }
}
