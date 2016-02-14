
using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Linq;
using JetBrains.Annotations;



namespace CheckContracts
{
    partial class Validate
    {
#if (true)
        /// <summary>
        /// Checks that input value is greater zero
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void GreaterThanZero(int value, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(value > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than zero. Current value: {1}", new object[]{ value.GetType(), value }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater zero
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThanZero(int value) 
        {
            if(value > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than zero. Current value: {1}", new object[]{ value.GetType(), value }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater zero
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThanZero(int value, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(value > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than zero. Current value: {1}", new object[]{ value.GetType(), value }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is greater zero
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThanZero(int value, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(value > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than zero. Current value: {1}", new object[]{ value.GetType(), value }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that input value is greater zero
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void GreaterThanZero(double value, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(value > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than zero. Current value: {1}", new object[]{ value.GetType(), value }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater zero
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThanZero(double value) 
        {
            if(value > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than zero. Current value: {1}", new object[]{ value.GetType(), value }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater zero
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThanZero(double value, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(value > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than zero. Current value: {1}", new object[]{ value.GetType(), value }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is greater zero
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThanZero(double value, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(value > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than zero. Current value: {1}", new object[]{ value.GetType(), value }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that input value is greater or equal than zero
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void GreaterOrEqualThanZero(int value, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(value >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than zero. Current value: {1}", new object[]{ value.GetType(), value }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal than zero
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThanZero(int value) 
        {
            if(value >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than zero. Current value: {1}", new object[]{ value.GetType(), value }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal than zero
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThanZero(int value, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(value >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than zero. Current value: {1}", new object[]{ value.GetType(), value }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal than zero
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThanZero(int value, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(value >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than zero. Current value: {1}", new object[]{ value.GetType(), value }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that input value is greater or equal than zero
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void GreaterOrEqualThanZero(double value, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(value >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than zero. Current value: {1}", new object[]{ value.GetType(), value }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal than zero
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThanZero(double value) 
        {
            if(value >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than zero. Current value: {1}", new object[]{ value.GetType(), value }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal than zero
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThanZero(double value, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(value >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than zero. Current value: {1}", new object[]{ value.GetType(), value }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal than zero
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThanZero(double value, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(value >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than zero. Current value: {1}", new object[]{ value.GetType(), value }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void GreaterThan<TValueType>(TValueType value, TValueType minValue, [NotNull] string errorFormat, [NotNull] params object[] args ) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan<TValueType>(TValueType value, TValueType minValue) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan<TValueType>(TValueType value, TValueType minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, minValue }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan<TValueType>(TValueType value, TValueType minValue, [InvokerParameterName, NotNull] string argumentName) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, minValue }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void GreaterOrEqualThan<TValueType>(TValueType value, TValueType minValue, [NotNull] string errorFormat, [NotNull] params object[] args ) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan<TValueType>(TValueType value, TValueType minValue) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan<TValueType>(TValueType value, TValueType minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, minValue }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan<TValueType>(TValueType value, TValueType minValue, [InvokerParameterName, NotNull] string argumentName) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, minValue }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void LessThan<TValueType>(TValueType value, TValueType maxValue, [NotNull] string errorFormat, [NotNull] params object[] args ) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(maxValue) < 0)
                return;

            var message = BuildMessage("Value of type {0} should be less than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan<TValueType>(TValueType value, TValueType maxValue) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(maxValue) < 0)
                return;

            var message = BuildMessage("Value of type {0} should be less than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan<TValueType>(TValueType value, TValueType maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(maxValue) < 0)
                return;

            var message = BuildMessage("Value of type {0} should be less than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, maxValue }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan<TValueType>(TValueType value, TValueType maxValue, [InvokerParameterName, NotNull] string argumentName) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(maxValue) < 0)
                return;

            var message = BuildMessage("Value of type {0} should be less than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, maxValue }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void LessOrEqualThan<TValueType>(TValueType value, TValueType maxValue, [NotNull] string errorFormat, [NotNull] params object[] args ) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan<TValueType>(TValueType value, TValueType maxValue) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan<TValueType>(TValueType value, TValueType maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, maxValue }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan<TValueType>(TValueType value, TValueType maxValue, [InvokerParameterName, NotNull] string argumentName) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {2}. Current value: {1}", new object[]{ typeof(TValueType), value, maxValue }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void Between<TValueType>(TValueType value, TValueType minValue, TValueType maxValue, [NotNull] string errorFormat, [NotNull] params object[] args ) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be between {2} and {3} (inclusive). Current value: {1}", new object[]{ typeof(TValueType), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between<TValueType>(TValueType value, TValueType minValue, TValueType maxValue) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be between {2} and {3} (inclusive). Current value: {1}", new object[]{ typeof(TValueType), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween<TValueType>(TValueType value, TValueType minValue, TValueType maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be between {2} and {3} (inclusive). Current value: {1}", new object[]{ typeof(TValueType), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween<TValueType>(TValueType value, TValueType minValue, TValueType maxValue, [InvokerParameterName, NotNull] string argumentName) where TValueType : struct, IComparable<TValueType>
        {
            if(value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be between {2} and {3} (inclusive). Current value: {1}", new object[]{ typeof(TValueType), value, minValue, maxValue }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that value is equal with expected value
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void EqualsWith<TValue>([CanBeNull]TValue value, [CanBeNull]TValue expected, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(ReferenceEquals(value, expected) || (!ReferenceEquals(expected, null) && expected.Equals(value)) || (!ReferenceEquals(value, null) && value.Equals(expected)))
                return;

            var message = BuildMessage("Value of type {0} should be {2} but was {1}", new object[]{ typeof(TValue), value, expected }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that value is equal with expected value
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void EqualsWith<TValue>([CanBeNull]TValue value, [CanBeNull]TValue expected) 
        {
            if(ReferenceEquals(value, expected) || (!ReferenceEquals(expected, null) && expected.Equals(value)) || (!ReferenceEquals(value, null) && value.Equals(expected)))
                return;

            var message = BuildMessage("Value of type {0} should be {2} but was {1}", new object[]{ typeof(TValue), value, expected }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that value is equal with expected value
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentEqualsWith<TValue>([CanBeNull]TValue value, [CanBeNull]TValue expected, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(ReferenceEquals(value, expected) || (!ReferenceEquals(expected, null) && expected.Equals(value)) || (!ReferenceEquals(value, null) && value.Equals(expected)))
                return;

            var message = BuildMessage("Value of type {0} should be {2} but was {1}", new object[]{ typeof(TValue), value, expected }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that value is equal with expected value
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentEqualsWith<TValue>([CanBeNull]TValue value, [CanBeNull]TValue expected, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(ReferenceEquals(value, expected) || (!ReferenceEquals(expected, null) && expected.Equals(value)) || (!ReferenceEquals(value, null) && value.Equals(expected)))
                return;

            var message = BuildMessage("Value of type {0} should be {2} but was {1}", new object[]{ typeof(TValue), value, expected }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that value is not equal with expected value
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void NotEqualsWith<TValue>([CanBeNull]TValue value, [CanBeNull]TValue expected, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(!ReferenceEquals(value, expected) && ((!ReferenceEquals(value, null) && !value.Equals(expected)) || (!ReferenceEquals(expected, null) && !expected.Equals(value))))
                return;

            var message = BuildMessage("Value of type {0} should not be {1} they are equal", new object[]{ typeof(TValue), expected }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that value is not equal with expected value
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void NotEqualsWith<TValue>([CanBeNull]TValue value, [CanBeNull]TValue expected) 
        {
            if(!ReferenceEquals(value, expected) && ((!ReferenceEquals(value, null) && !value.Equals(expected)) || (!ReferenceEquals(expected, null) && !expected.Equals(value))))
                return;

            var message = BuildMessage("Value of type {0} should not be {1} they are equal", new object[]{ typeof(TValue), expected }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that value is not equal with expected value
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentNotEqualsWith<TValue>([CanBeNull]TValue value, [CanBeNull]TValue expected, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(!ReferenceEquals(value, expected) && ((!ReferenceEquals(value, null) && !value.Equals(expected)) || (!ReferenceEquals(expected, null) && !expected.Equals(value))))
                return;

            var message = BuildMessage("Value of type {0} should not be {1} they are equal", new object[]{ typeof(TValue), expected }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that value is not equal with expected value
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentNotEqualsWith<TValue>([CanBeNull]TValue value, [CanBeNull]TValue expected, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(!ReferenceEquals(value, expected) && ((!ReferenceEquals(value, null) && !value.Equals(expected)) || (!ReferenceEquals(expected, null) && !expected.Equals(value))))
                return;

            var message = BuildMessage("Value of type {0} should not be {1} they are equal", new object[]{ typeof(TValue), expected }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		[ContractAnnotation("collection:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void EnumerableHasElements<TValue>([CanBeNull]IEnumerable<TValue> collection, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(!ReferenceEquals(null, collection) && collection.Any())
                return;

            var message = BuildMessage("Enumerable with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("collection:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void EnumerableHasElements<TValue>([CanBeNull]IEnumerable<TValue> collection) 
        {
            if(!ReferenceEquals(null, collection) && collection.Any())
                return;

            var message = BuildMessage("Enumerable with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("collection:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void ArgumentEnumerableHasElements<TValue>([CanBeNull]IEnumerable<TValue> collection, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(!ReferenceEquals(null, collection) && collection.Any())
                return;

            var message = BuildMessage("Enumerable with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("collection:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void ArgumentEnumerableHasElements<TValue>([CanBeNull]IEnumerable<TValue> collection, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(!ReferenceEquals(null, collection) && collection.Any())
                return;

            var message = BuildMessage("Enumerable with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (ReadonlyCollectionDefined)
        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		[ContractAnnotation("collection:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void CollectionHasElements<TValue>([CanBeNull]IReadOnlyCollection<TValue> collection, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(!ReferenceEquals(null, collection) && collection.Count > 0)
                return;

            var message = BuildMessage("Collection with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("collection:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void CollectionHasElements<TValue>([CanBeNull]IReadOnlyCollection<TValue> collection) 
        {
            if(!ReferenceEquals(null, collection) && collection.Count > 0)
                return;

            var message = BuildMessage("Collection with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("collection:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void ArgumentCollectionHasElements<TValue>([CanBeNull]IReadOnlyCollection<TValue> collection, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(!ReferenceEquals(null, collection) && collection.Count > 0)
                return;

            var message = BuildMessage("Collection with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("collection:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void ArgumentCollectionHasElements<TValue>([CanBeNull]IReadOnlyCollection<TValue> collection, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(!ReferenceEquals(null, collection) && collection.Count > 0)
                return;

            var message = BuildMessage("Collection with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (ReadonlyCollectionDefined)
        /// <summary>
        /// Checks, that collection contains the target value
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		[ContractAnnotation("allowedItems:null=>halt")][ContractAnnotation("value:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void IsIn<TValue>([CanBeNull]TValue value, [NotNull]IReadOnlyCollection<TValue> allowedItems, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(!ReferenceEquals(null, allowedItems) && allowedItems.Contains(value))
                return;

            var message = BuildMessage("Item {0} (type - '{1}') should be one of the following: '{1}'.", new object[]{ value, typeof(TValue), ReferenceEquals(null, allowedItems) ? "null" : string.Join(", ", allowedItems) }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks, that collection contains the target value
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("allowedItems:null=>halt")][ContractAnnotation("value:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void IsIn<TValue>([CanBeNull]TValue value, [NotNull]IReadOnlyCollection<TValue> allowedItems) 
        {
            if(!ReferenceEquals(null, allowedItems) && allowedItems.Contains(value))
                return;

            var message = BuildMessage("Item {0} (type - '{1}') should be one of the following: '{1}'.", new object[]{ value, typeof(TValue), ReferenceEquals(null, allowedItems) ? "null" : string.Join(", ", allowedItems) }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks, that collection contains the target value
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("allowedItems:null=>halt")][ContractAnnotation("value:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void ArgumentIsIn<TValue>([CanBeNull]TValue value, [NotNull]IReadOnlyCollection<TValue> allowedItems, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(!ReferenceEquals(null, allowedItems) && allowedItems.Contains(value))
                return;

            var message = BuildMessage("Item {0} (type - '{1}') should be one of the following: '{1}'.", new object[]{ value, typeof(TValue), ReferenceEquals(null, allowedItems) ? "null" : string.Join(", ", allowedItems) }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks, that collection contains the target value
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("allowedItems:null=>halt")][ContractAnnotation("value:null=>halt")][CollectionAccess(CollectionAccessType.Read)]public static void ArgumentIsIn<TValue>([CanBeNull]TValue value, [NotNull]IReadOnlyCollection<TValue> allowedItems, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(!ReferenceEquals(null, allowedItems) && allowedItems.Contains(value))
                return;

            var message = BuildMessage("Item {0} (type - '{1}') should be one of the following: '{1}'.", new object[]{ value, typeof(TValue), ReferenceEquals(null, allowedItems) ? "null" : string.Join(", ", allowedItems) }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Condition check
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		[ContractAnnotation("condition:null=>halt")]public static void Condition(bool condition, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(condition)
                return;

            var message = BuildMessage("Condition was failed", new object[]{  }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Condition check
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("condition:null=>halt")]public static void Condition(bool condition) 
        {
            if(condition)
                return;

            var message = BuildMessage("Condition was failed", new object[]{  }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Condition check
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("condition:null=>halt")]public static void ArgumentCondition(bool condition, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(condition)
                return;

            var message = BuildMessage("Condition was failed", new object[]{  }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Condition check
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("condition:null=>halt")]public static void ArgumentCondition(bool condition, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(condition)
                return;

            var message = BuildMessage("Condition was failed", new object[]{  }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that input string is not null, is not empty and is not writespace
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		[ContractAnnotation("inputString:null=>halt")]public static void StringIsMeanful([CanBeNull]string inputString, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(!string.IsNullOrWhiteSpace(inputString))
                return;

            var message = BuildMessage("Input string is empty: '{0}'", new object[]{ inputString ?? "{null}" }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input string is not null, is not empty and is not writespace
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("inputString:null=>halt")]public static void StringIsMeanful([CanBeNull]string inputString) 
        {
            if(!string.IsNullOrWhiteSpace(inputString))
                return;

            var message = BuildMessage("Input string is empty: '{0}'", new object[]{ inputString ?? "{null}" }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input string is not null, is not empty and is not writespace
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("inputString:null=>halt")]public static void ArgumentStringIsMeanful([CanBeNull]string inputString, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(!string.IsNullOrWhiteSpace(inputString))
                return;

            var message = BuildMessage("Input string is empty: '{0}'", new object[]{ inputString ?? "{null}" }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input string is not null, is not empty and is not writespace
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        [ContractAnnotation("inputString:null=>halt")]public static void ArgumentStringIsMeanful([CanBeNull]string inputString, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(!string.IsNullOrWhiteSpace(inputString))
                return;

            var message = BuildMessage("Input string is empty: '{0}'", new object[]{ inputString ?? "{null}" }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that enumeration value is defined. Uses Enum.IsDefined function
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void EnumerationValueIsDefined<TEnum>(TEnum enumeration, [NotNull] string errorFormat, [NotNull] params object[] args ) where TEnum : struct
        {
            if(Enum.IsDefined(typeof(TEnum), enumeration))
                return;

            var message = BuildMessage("Enumeration value {0} is not defined for type {1}", new object[]{ enumeration, typeof(TEnum) }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that enumeration value is defined. Uses Enum.IsDefined function
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void EnumerationValueIsDefined<TEnum>(TEnum enumeration) where TEnum : struct
        {
            if(Enum.IsDefined(typeof(TEnum), enumeration))
                return;

            var message = BuildMessage("Enumeration value {0} is not defined for type {1}", new object[]{ enumeration, typeof(TEnum) }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that enumeration value is defined. Uses Enum.IsDefined function
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentEnumerationValueIsDefined<TEnum>(TEnum enumeration, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TEnum : struct
        {
            if(Enum.IsDefined(typeof(TEnum), enumeration))
                return;

            var message = BuildMessage("Enumeration value {0} is not defined for type {1}", new object[]{ enumeration, typeof(TEnum) }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that enumeration value is defined. Uses Enum.IsDefined function
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentEnumerationValueIsDefined<TEnum>(TEnum enumeration, [InvokerParameterName, NotNull] string argumentName) where TEnum : struct
        {
            if(Enum.IsDefined(typeof(TEnum), enumeration))
                return;

            var message = BuildMessage("Enumeration value {0} is not defined for type {1}", new object[]{ enumeration, typeof(TEnum) }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
        #if (true)
        /// <summary>
        /// Checks that input date has year more than 1900. This check is useful to avoid default(DateTime) value (with year 0001) and the same dates near it
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
		public static void DateIsReal(DateTime inputDate, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(inputDate > MinDate)
                return;

            var message = BuildMessage("Date should be more than {0}. Actual value: {1}", new object[]{ MinDate, inputDate }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input date has year more than 1900. This check is useful to avoid default(DateTime) value (with year 0001) and the same dates near it
        /// </summary>
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void DateIsReal(DateTime inputDate) 
        {
            if(inputDate > MinDate)
                return;

            var message = BuildMessage("Date should be more than {0}. Actual value: {1}", new object[]{ MinDate, inputDate }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input date has year more than 1900. This check is useful to avoid default(DateTime) value (with year 0001) and the same dates near it
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentDateIsReal(DateTime inputDate, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(inputDate > MinDate)
                return;

            var message = BuildMessage("Date should be more than {0}. Actual value: {1}", new object[]{ MinDate, inputDate }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input date has year more than 1900. This check is useful to avoid default(DateTime) value (with year 0001) and the same dates near it
        /// </summary>        
        [AssertionMethod]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentDateIsReal(DateTime inputDate, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(inputDate > MinDate)
                return;

            var message = BuildMessage("Date should be more than {0}. Actual value: {1}", new object[]{ MinDate, inputDate }, null, null, argumentName);

            throw new ArgumentException(message);
        }
#endif
                
    }
}