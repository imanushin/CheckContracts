﻿
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
        public static void GreaterThan<TValue>(TValue value, TValue minValue, [NotNull] string errorFormat, [NotNull] params object[] args ) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ typeof(TValue), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterThan<TValue>(TValue value, TValue minValue) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ typeof(TValue), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan<TValue>(TValue value, TValue minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ typeof(TValue), value, minValue }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterThan<TValue>(TValue value, TValue minValue, [InvokerParameterName, NotNull] string argumentName) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) > 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater than {1}. Current value: {2}", new object[]{ typeof(TValue), value, minValue }, null, null, argumentName);

            throw new ArgumentException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan<TValue>(TValue value, TValue minValue, [NotNull] string errorFormat, [NotNull] params object[] args ) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ typeof(TValue), value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void GreaterOrEqualThan<TValue>(TValue value, TValue minValue) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ typeof(TValue), value, minValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan<TValue>(TValue value, TValue minValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ typeof(TValue), value, minValue }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is greater or equal with minValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentGreaterOrEqualThan<TValue>(TValue value, TValue minValue, [InvokerParameterName, NotNull] string argumentName) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) >= 0)
                return;

            var message = BuildMessage("Value of type {0} should be greater or equal than {1}. Current value: {2}", new object[]{ typeof(TValue), value, minValue }, null, null, argumentName);

            throw new ArgumentException(message);
        }
        
        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan<TValue>(TValue value, TValue maxValue, [NotNull] string errorFormat, [NotNull] params object[] args ) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(maxValue) < 0)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ typeof(TValue), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessThan<TValue>(TValue value, TValue maxValue) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(maxValue) < 0)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ typeof(TValue), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan<TValue>(TValue value, TValue maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(maxValue) < 0)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ typeof(TValue), value, maxValue }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is less (and not equal with) maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessThan<TValue>(TValue value, TValue maxValue, [InvokerParameterName, NotNull] string argumentName) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(maxValue) < 0)
                return;

            var message = BuildMessage("Value of type {0} should be less than {1}. Current value: {2}", new object[]{ typeof(TValue), value, maxValue }, null, null, argumentName);

            throw new ArgumentException(message);
        }
        
        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan<TValue>(TValue value, TValue maxValue, [NotNull] string errorFormat, [NotNull] params object[] args ) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ typeof(TValue), value, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void LessOrEqualThan<TValue>(TValue value, TValue maxValue) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ typeof(TValue), value, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan<TValue>(TValue value, TValue maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ typeof(TValue), value, maxValue }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is less or equal with maxValue
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentLessOrEqualThan<TValue>(TValue value, TValue maxValue, [InvokerParameterName, NotNull] string argumentName) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be less or equal than {1}. Current value: {2}", new object[]{ typeof(TValue), value, maxValue }, null, null, argumentName);

            throw new ArgumentException(message);
        }
        
        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between<TValue>(TValue value, TValue minValue, TValue maxValue, [NotNull] string errorFormat, [NotNull] params object[] args ) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Between<TValue>(TValue value, TValue minValue, TValue maxValue) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween<TValue>(TValue value, TValue minValue, TValue maxValue, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input value is between minValue and maxValue (inclusive)
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentBetween<TValue>(TValue value, TValue minValue, TValue maxValue, [InvokerParameterName, NotNull] string argumentName) where TValue : struct, IComparable<TValue>
        {
            if(value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0)
                return;

            var message = BuildMessage("Value of type {0} should be between {1} and {2} (inclusive). Current value: {3}", new object[]{ value.GetType(), value, minValue, maxValue }, null, null, argumentName);

            throw new ArgumentException(message);
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

            throw new ArgumentException(message);
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

            throw new ArgumentException(message);
        }
        
        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void CollectionHasElements<TValue>(IEnumerable<TValue> collection, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(!ReferenceEquals(null, collection) && collection.Any())
                return;

            var message = BuildMessage("Collection with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void CollectionHasElements<TValue>(IEnumerable<TValue> collection) 
        {
            if(!ReferenceEquals(null, collection) && collection.Any())
                return;

            var message = BuildMessage("Collection with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, null, null);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentCollectionHasElements<TValue>(IEnumerable<TValue> collection, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(!ReferenceEquals(null, collection) && collection.Any())
                return;

            var message = BuildMessage("Collection with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input collection has elements
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentCollectionHasElements<TValue>(IEnumerable<TValue> collection, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(!ReferenceEquals(null, collection) && collection.Any())
                return;

            var message = BuildMessage("Collection with elements of type {0} should not be empty. Collection is {1}null", new object[]{ typeof(TValue), ReferenceEquals(null, collection) ? string.Empty : "not " }, null, null, argumentName);

            throw new ArgumentException(message);
        }
        
        /// <summary>
        /// Condition check
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Condition(bool condition, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(condition)
                return;

            var message = BuildMessage("Condition was failed", new object[]{  }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Condition check
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void Condition(bool condition) 
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
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentCondition(bool condition, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(condition)
                return;

            var message = BuildMessage("Condition was failed", new object[]{  }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Condition check
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentCondition(bool condition, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(condition)
                return;

            var message = BuildMessage("Condition was failed", new object[]{  }, null, null, argumentName);

            throw new ArgumentException(message);
        }
        
        /// <summary>
        /// Checks that input string is not null, is not empty and is not writespace
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void StringIsMeanful(string inputString, [NotNull] string errorFormat, [NotNull] params object[] args ) 
        {
            if(!string.IsNullOrWhiteSpace(inputString))
                return;

            var message = BuildMessage("Input string is empty: '{0}'", new object[]{ inputString ?? "{null}" }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that input string is not null, is not empty and is not writespace
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void StringIsMeanful(string inputString) 
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
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentStringIsMeanful(string inputString, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) 
        {
            if(!string.IsNullOrWhiteSpace(inputString))
                return;

            var message = BuildMessage("Input string is empty: '{0}'", new object[]{ inputString ?? "{null}" }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that input string is not null, is not empty and is not writespace
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentStringIsMeanful(string inputString, [InvokerParameterName, NotNull] string argumentName) 
        {
            if(!string.IsNullOrWhiteSpace(inputString))
                return;

            var message = BuildMessage("Input string is empty: '{0}'", new object[]{ inputString ?? "{null}" }, null, null, argumentName);

            throw new ArgumentException(message);
        }
        
        /// <summary>
        /// Checks that enumeration value is defined. Uses Enum.IsDefined function
        /// </summary>
        [StringFormatMethod("errorFormat")]
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void EnumerationValueIsDefined<TEnum>(TEnum enumeration, [NotNull] string errorFormat, [NotNull] params object[] args ) where TEnum : struct, IConvertible
        {
            if(Enum.IsDefined(typeof(TEnum), enumeration))
                return;

            var message = BuildMessage("Enumeration value {0} is not defined for type {1}", new object[]{ enumeration, typeof(TEnum) }, errorFormat, args);

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Checks that enumeration value is defined. Uses Enum.IsDefined function
        /// </summary>
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void EnumerationValueIsDefined<TEnum>(TEnum enumeration) where TEnum : struct, IConvertible
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
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentEnumerationValueIsDefined<TEnum>(TEnum enumeration, [InvokerParameterName, NotNull] string argumentName, [NotNull] string errorFormat, [NotNull] params object[] args) where TEnum : struct, IConvertible
        {
            if(Enum.IsDefined(typeof(TEnum), enumeration))
                return;

            var message = BuildMessage("Enumeration value {0} is not defined for type {1}", new object[]{ enumeration, typeof(TEnum) }, errorFormat, args, argumentName);

            throw new ArgumentException(message);
        }

        /// <summary>
        /// Checks that enumeration value is defined. Uses Enum.IsDefined function
        /// </summary>        
        [GeneratedCode("T4 Code Generator", "1.0")]
        public static void ArgumentEnumerationValueIsDefined<TEnum>(TEnum enumeration, [InvokerParameterName, NotNull] string argumentName) where TEnum : struct, IConvertible
        {
            if(Enum.IsDefined(typeof(TEnum), enumeration))
                return;

            var message = BuildMessage("Enumeration value {0} is not defined for type {1}", new object[]{ enumeration, typeof(TEnum) }, null, null, argumentName);

            throw new ArgumentException(message);
        }
                
    }
}