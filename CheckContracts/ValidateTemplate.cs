
using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
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
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(sbyte value, sbyte minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(sbyte value, sbyte minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(sbyte value, sbyte minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(sbyte value, sbyte minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(short value, short minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(short value, short minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(short value, short minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(short value, short minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(int value, int minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(int value, int minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(int value, int minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(int value, int minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(long value, long minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(long value, long minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(long value, long minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(long value, long minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(byte value, byte minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(byte value, byte minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(byte value, byte minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(byte value, byte minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(ushort value, ushort minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(ushort value, ushort minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(ushort value, ushort minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(ushort value, ushort minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(uint value, uint minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(uint value, uint minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(uint value, uint minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(uint value, uint minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(ulong value, ulong minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(ulong value, ulong minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(ulong value, ulong minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(ulong value, ulong minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(double value, double minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(double value, double minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(double value, double minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(double value, double minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(float value, float minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(float value, float minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(float value, float minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(float value, float minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(DateTime value, DateTime minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(DateTime value, DateTime minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(DateTime value, DateTime minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(DateTime value, DateTime minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(TimeSpan value, TimeSpan minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan(TimeSpan value, TimeSpan minValue)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(TimeSpan value, TimeSpan minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan(TimeSpan value, TimeSpan minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value > minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(sbyte value, sbyte minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(sbyte value, sbyte minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(sbyte value, sbyte minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(sbyte value, sbyte minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(short value, short minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(short value, short minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(short value, short minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(short value, short minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(int value, int minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(int value, int minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(int value, int minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(int value, int minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(long value, long minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(long value, long minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(long value, long minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(long value, long minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(byte value, byte minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(byte value, byte minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(byte value, byte minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(byte value, byte minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(ushort value, ushort minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(ushort value, ushort minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(ushort value, ushort minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(ushort value, ushort minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(uint value, uint minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(uint value, uint minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(uint value, uint minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(uint value, uint minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(ulong value, ulong minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(ulong value, ulong minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(ulong value, ulong minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(ulong value, ulong minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(double value, double minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(double value, double minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(double value, double minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(double value, double minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(float value, float minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(float value, float minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(float value, float minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(float value, float minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(DateTime value, DateTime minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(DateTime value, DateTime minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(DateTime value, DateTime minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(DateTime value, DateTime minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(TimeSpan value, TimeSpan minValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan(TimeSpan value, TimeSpan minValue)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(TimeSpan value, TimeSpan minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan(TimeSpan value, TimeSpan minValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value >= minValue)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, minValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(sbyte value, sbyte maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(sbyte value, sbyte maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(sbyte value, sbyte maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(sbyte value, sbyte maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(short value, short maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(short value, short maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(short value, short maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(short value, short maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(int value, int maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(int value, int maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(int value, int maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(int value, int maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(long value, long maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(long value, long maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(long value, long maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(long value, long maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(byte value, byte maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(byte value, byte maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(byte value, byte maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(byte value, byte maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(ushort value, ushort maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(ushort value, ushort maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(ushort value, ushort maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(ushort value, ushort maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(uint value, uint maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(uint value, uint maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(uint value, uint maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(uint value, uint maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(ulong value, ulong maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(ulong value, ulong maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(ulong value, ulong maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(ulong value, ulong maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(double value, double maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(double value, double maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(double value, double maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(double value, double maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(float value, float maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(float value, float maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(float value, float maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(float value, float maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(DateTime value, DateTime maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(DateTime value, DateTime maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(DateTime value, DateTime maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(DateTime value, DateTime maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(TimeSpan value, TimeSpan maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan(TimeSpan value, TimeSpan maxValue)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(TimeSpan value, TimeSpan maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan(TimeSpan value, TimeSpan maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value < maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(sbyte value, sbyte maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(sbyte value, sbyte maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(sbyte value, sbyte maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(sbyte value, sbyte maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(short value, short maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(short value, short maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(short value, short maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(short value, short maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(int value, int maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(int value, int maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(int value, int maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(int value, int maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(long value, long maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(long value, long maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(long value, long maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(long value, long maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(byte value, byte maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(byte value, byte maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(byte value, byte maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(byte value, byte maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(ushort value, ushort maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(ushort value, ushort maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(ushort value, ushort maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(ushort value, ushort maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(uint value, uint maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(uint value, uint maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(uint value, uint maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(uint value, uint maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(ulong value, ulong maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(ulong value, ulong maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(ulong value, ulong maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(ulong value, ulong maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(double value, double maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(double value, double maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(double value, double maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(double value, double maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(float value, float maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(float value, float maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(float value, float maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(float value, float maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(DateTime value, DateTime maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(DateTime value, DateTime maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(DateTime value, DateTime maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(DateTime value, DateTime maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(TimeSpan value, TimeSpan maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan(TimeSpan value, TimeSpan maxValue)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(TimeSpan value, TimeSpan maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan(TimeSpan value, TimeSpan maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ value.GetType(), value, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(sbyte value, sbyte minValue, sbyte maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(sbyte value, sbyte minValue, sbyte maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(sbyte value, sbyte minValue, sbyte maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(sbyte value, sbyte minValue, sbyte maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(short value, short minValue, short maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(short value, short minValue, short maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(short value, short minValue, short maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(short value, short minValue, short maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(int value, int minValue, int maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(int value, int minValue, int maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(int value, int minValue, int maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(int value, int minValue, int maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(long value, long minValue, long maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(long value, long minValue, long maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(long value, long minValue, long maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(long value, long minValue, long maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(byte value, byte minValue, byte maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(byte value, byte minValue, byte maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(byte value, byte minValue, byte maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(byte value, byte minValue, byte maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(ushort value, ushort minValue, ushort maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(ushort value, ushort minValue, ushort maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(ushort value, ushort minValue, ushort maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(ushort value, ushort minValue, ushort maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(uint value, uint minValue, uint maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(uint value, uint minValue, uint maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(uint value, uint minValue, uint maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(uint value, uint minValue, uint maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(ulong value, ulong minValue, ulong maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(ulong value, ulong minValue, ulong maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(ulong value, ulong minValue, ulong maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(ulong value, ulong minValue, ulong maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(double value, double minValue, double maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(double value, double minValue, double maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(double value, double minValue, double maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(double value, double minValue, double maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(float value, float minValue, float maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(float value, float minValue, float maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(float value, float minValue, float maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(float value, float minValue, float maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(DateTime value, DateTime minValue, DateTime maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(DateTime value, DateTime minValue, DateTime maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(DateTime value, DateTime minValue, DateTime maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(DateTime value, DateTime minValue, DateTime maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(TimeSpan value, TimeSpan minValue, TimeSpan maxValue, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between(TimeSpan value, TimeSpan minValue, TimeSpan maxValue)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(TimeSpan value, TimeSpan minValue, TimeSpan maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween(TimeSpan value, TimeSpan minValue, TimeSpan maxValue, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(minValue <= value && value <= maxValue)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that value is equals with expected value
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void EqualsWith<TValue>(TValue value, TValue expected, [NotNull] string errorFormat, [NotNull] params object[] args )
        
        {
            if(ReferenceEquals(value, expected) || (!ReferenceEquals(expected, null) && expected.Equals(value)) || (!ReferenceEquals(value, null) && value.Equals(expected)))
                return;

            var message = BuildMessage("Value of type {0} should be {1} but was {2}", new object[]{ typeof(TValue), value, expected }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that value is equals with expected value
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void EqualsWith<TValue>(TValue value, TValue expected)
        
        {
            if(ReferenceEquals(value, expected) || (!ReferenceEquals(expected, null) && expected.Equals(value)) || (!ReferenceEquals(value, null) && value.Equals(expected)))
                return;

            var message = BuildMessage("Value of type {0} should be {1} but was {2}", new object[]{ typeof(TValue), value, expected }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that value is equals with expected value
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentEqualsWith<TValue>(TValue value, TValue expected, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        
        {
            if(ReferenceEquals(value, expected) || (!ReferenceEquals(expected, null) && expected.Equals(value)) || (!ReferenceEquals(value, null) && value.Equals(expected)))
                return;

            var message = BuildMessage("Value of type {0} should be {1} but was {2}", new object[]{ typeof(TValue), value, expected }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that value is equals with expected value
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentEqualsWith<TValue>(TValue value, TValue expected, [InvokerParameterName, NotNull] string argumentName)
        
        {
            if(ReferenceEquals(value, expected) || (!ReferenceEquals(expected, null) && expected.Equals(value)) || (!ReferenceEquals(value, null) && value.Equals(expected)))
                return;

            var message = BuildMessage("Value of type {0} should be {1} but was {2}", new object[]{ typeof(TValue), value, expected }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void CollectionHasElements<TCollection, TValue>(TCollection collection, [NotNull] string errorFormat, [NotNull] params object[] args )
        where TCollection : IEnumerable<TValue>
        {
            if(collection.Any())
                return;

            var message = BuildMessage("Collection with {0} should not be empty", new object[]{ typeof(TCollection), collection }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void CollectionHasElements<TCollection, TValue>(TCollection collection)
        where TCollection : IEnumerable<TValue>
        {
            if(collection.Any())
                return;

            var message = BuildMessage("Collection with {0} should not be empty", new object[]{ typeof(TCollection), collection }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentCollectionHasElements<TCollection, TValue>(TCollection collection, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args)
        where TCollection : IEnumerable<TValue>
        {
            if(collection.Any())
                return;

            var message = BuildMessage("Collection with {0} should not be empty", new object[]{ typeof(TCollection), collection }, errorFormat, args, argumentName);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentCollectionHasElements<TCollection, TValue>(TCollection collection, [InvokerParameterName, NotNull] string argumentName)
        where TCollection : IEnumerable<TValue>
        {
            if(collection.Any())
                return;

            var message = BuildMessage("Collection with {0} should not be empty", new object[]{ typeof(TCollection), collection }, null, null, argumentName);

            throw new InvalidOperationException(message);
        }
                
    }
}