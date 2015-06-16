
using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;



namespace CheckContracts
{
    partial class Validate
    {

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        public static void GreaterThan(int value, int minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void GreaterThan(int value, int minValue)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        public static void ArgumentGreaterThan(int value, int minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void ArgumentGreaterThan(int value, int minValue, [InvokerParameterName, NotNull] string argumentName)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        public static void GreaterThan(double value, double minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void GreaterThan(double value, double minValue)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        public static void ArgumentGreaterThan(double value, double minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void ArgumentGreaterThan(double value, double minValue, [InvokerParameterName, NotNull] string argumentName)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        public static void GreaterThan(long value, long minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void GreaterThan(long value, long minValue)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        public static void ArgumentGreaterThan(long value, long minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void ArgumentGreaterThan(long value, long minValue, [InvokerParameterName, NotNull] string argumentName)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        public static void GreaterThan(byte value, byte minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void GreaterThan(byte value, byte minValue)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        public static void ArgumentGreaterThan(byte value, byte minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void ArgumentGreaterThan(byte value, byte minValue, [InvokerParameterName, NotNull] string argumentName)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        public static void GreaterThan(short value, short minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void GreaterThan(short value, short minValue)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        public static void ArgumentGreaterThan(short value, short minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void ArgumentGreaterThan(short value, short minValue, [InvokerParameterName, NotNull] string argumentName)
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
                
    }
}