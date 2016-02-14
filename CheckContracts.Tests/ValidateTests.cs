using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace CheckContracts.Tests
{
    [TestFixture]
    [ExcludeFromCodeCoverage]
    internal sealed class ValidateTests
    {
        private static int _index = 0;

        private static readonly TestCaseData[] Cases = CreateExceptionalCases().Select(vc => new TestCaseData(vc).SetName(vc.CaseName)).ToArray();

        [Test]
        public void IsNotNullTests()
        {
            const string nullString = null;

            Assert.That(() => Validate.IsNotNull(nullString), Throws.InvalidOperationException.And.Message.Contains("String"));
            Assert.That(() => Validate.ArgumentIsNotNull(nullString, "arg12"), Throws.InstanceOf(typeof(ArgumentNullException)).And.Message.Contains("String").And.Message.Contains("arg12"));
            Assert.That(() => Validate.ArgumentIsNotNull("123", "arg12"), Throws.Nothing);
            Assert.That(() => Validate.IsNotNull("123"), Throws.Nothing);
        }

        [Test]
        public void CollectionIsEmptyTestDraft()
        {
            string[] nullCollection = null;
            var emptyCollection = new string[] { };
            var notEmptyCollection = new[] { string.Empty };

            Assert.That(() => Validate.EnumerableHasElements(notEmptyCollection), Throws.Nothing);
            Assert.That(() => Validate.ArgumentEnumerableHasElements(notEmptyCollection, "123"), Throws.Nothing);

            Assert.That(() => Validate.EnumerableHasElements(nullCollection),
                Throws.InvalidOperationException
                .And.Message.Contains("is null")
                .And.Message.Contains("String"));
            Assert.That(() => Validate.ArgumentEnumerableHasElements(nullCollection, "arg1"),
                Throws.ArgumentException
                .And.Message.Contains("String")
                .And.Message.Contains("is null")
                .And.Message.Contains("arg1"));

            Assert.That(() => Validate.EnumerableHasElements(emptyCollection),
                Throws.InvalidOperationException
                .And.Message.Contains("is not null")
               .And.Message.Contains("String"));
            Assert.That(() => Validate.ArgumentEnumerableHasElements(emptyCollection, "arg1"),
                Throws.ArgumentException
                .And.Message.Contains("String")
                .And.Message.Contains("is not null")
                .And.Message.Contains("arg1"));
        }

        [Test]
        [TestCaseSource(nameof(Cases))]
        public void ExceptionRaiseTest(ValidationCase validationCase)
        {
            Assert.That(new TestDelegate(validationCase.ActionToTest), GetResolveConstrains(validationCase));
        }

        private static IResolveConstraint GetResolveConstrains(ValidationCase validationCase)
        {
            if (!validationCase.shouldRaiseError)
            {
                return Throws.Nothing;
            }

            Constraint result = Throws.InstanceOf(validationCase.ExceptionType);

            return validationCase.exceptionSubstrings.Aggregate(result, (current, line) => current.And.Message.Contains(line));
        }

        private static CheckFunctions<IEnumerable<TValue>> GetEnumerableHasElementsChecks<TValue>()
        {
            return new CheckFunctions<IEnumerable<TValue>>(
                "CollectionHasElements",
                Validate.EnumerableHasElements,
                Validate.EnumerableHasElements,
                Validate.ArgumentEnumerableHasElements,
                Validate.ArgumentEnumerableHasElements,
                new[] { typeof(TValue).Name }
                );
        }

        private static CheckFunctions<IReadOnlyCollection<TValue>> GetCollectionHasElementsChecks<TValue>()
        {
            return new CheckFunctions<IReadOnlyCollection<TValue>>(
                "CollectionHasElements",
                Validate.CollectionHasElements,
                Validate.CollectionHasElements,
                Validate.ArgumentCollectionHasElements,
                Validate.ArgumentCollectionHasElements,
                new[] { typeof(TValue).Name }
                );
        }

        private static CheckFunctions<TValue> GetGreaterOrEqualThanChecks<TValue>(TValue comparer) where TValue : struct, IComparable<TValue>
        {
            return new CheckFunctions<TValue>(
                "GreaterOrEqualThan",
                (v) => Validate.GreaterOrEqualThan(v, comparer),
                (v, msg, args) => Validate.GreaterOrEqualThan(v, comparer, msg, args),
                (v, param) => Validate.ArgumentGreaterOrEqualThan(v, comparer, param),
                (v, param, msg, args) => Validate.ArgumentGreaterOrEqualThan(v, comparer, param, msg, args),
                new[] { typeof(TValue).Name, comparer.ToString() }
                );
        }

        private static CheckFunctions<TValue> GetGreaterThanChecks<TValue>(TValue comparer) where TValue : struct, IComparable<TValue>
        {
            return new CheckFunctions<TValue>(
                "GreaterThan",
                (v) => Validate.GreaterThan(v, comparer),
                (v, msg, args) => Validate.GreaterThan(v, comparer, msg, args),
                (v, param) => Validate.ArgumentGreaterThan(v, comparer, param),
                (v, param, msg, args) => Validate.ArgumentGreaterThan(v, comparer, param, msg, args),
                new[] { typeof(TValue).Name, comparer.ToString() }
                );
        }

        private static CheckFunctions<TValue> GetLessOrEqualThanChecks<TValue>(TValue comparer) where TValue : struct, IComparable<TValue>
        {
            return new CheckFunctions<TValue>(
                "LessOrEqualThan",
                (v) => Validate.LessOrEqualThan(v, comparer),
                (v, msg, args) => Validate.LessOrEqualThan(v, comparer, msg, args),
                (v, param) => Validate.ArgumentLessOrEqualThan(v, comparer, param),
                (v, param, msg, args) => Validate.ArgumentLessOrEqualThan(v, comparer, param, msg, args),
                new[] { typeof(TValue).Name, comparer.ToString() }
                );
        }

        private static CheckFunctions<TValue> GetLessThanChecks<TValue>(TValue comparer) where TValue : struct, IComparable<TValue>
        {
            return new CheckFunctions<TValue>(
                "LessThan",
                (v) => Validate.LessThan(v, comparer),
                (v, msg, args) => Validate.LessThan(v, comparer, msg, args),
                (v, param) => Validate.ArgumentLessThan(v, comparer, param),
                (v, param, msg, args) => Validate.ArgumentLessThan(v, comparer, param, msg, args),
                new[] { typeof(TValue).Name, comparer.ToString() }
                );
        }

        private static CheckFunctions<TValue> GetBetweenChecks<TValue>(TValue min, TValue max) where TValue : struct, IComparable<TValue>
        {
            return new CheckFunctions<TValue>(
                "Between",
                (v) => Validate.Between(v, min, max),
                (v, msg, args) => Validate.Between(v, min, max, msg, args),
                (v, param) => Validate.ArgumentBetween(v, min, max, param),
                (v, param, msg, args) => Validate.ArgumentBetween(v, min, max, param, msg, args),
                new[] { typeof(TValue).Name, max.ToString(), min.ToString() }
                );
        }

        private static CheckFunctions<TValue> GetIsInChecks<TValue>(IReadOnlyCollection<TValue> allowedItems)
        {
            return new CheckFunctions<TValue>(
                "IsIn",
                (v) => Validate.IsIn(v, allowedItems),
                (v, msg, args) => Validate.IsIn(v, allowedItems, msg, args),
                (v, param) => Validate.ArgumentIsIn(v, allowedItems, param),
                (v, param, msg, args) => Validate.ArgumentIsIn(v, allowedItems, param, msg, args),
                allowedItems.Select(i => i.ToString()).Concat(new[] { typeof(TValue).Name }).ToArray()
                );
        }
        private static CheckFunctions<TValue> GetEqualsWithChecks<TValue>(TValue comparer)
        {
            return new CheckFunctions<TValue>(
                "EqualsWith",
                (v) => Validate.EqualsWith(v, comparer),
                (v, msg, args) => Validate.EqualsWith(v, comparer, msg, args),
                (v, param) => Validate.ArgumentEqualsWith(v, comparer, param),
                (v, param, msg, args) => Validate.ArgumentEqualsWith(v, comparer, param, msg, args),
                new[] { typeof(TValue).Name }
                );
        }

        private static CheckFunctions<TValue> GetNotEqualsWithChecks<TValue>(TValue comparer)
        {
            return new CheckFunctions<TValue>(
                "EqualsWith",
                (v) => Validate.NotEqualsWith(v, comparer),
                (v, msg, args) => Validate.NotEqualsWith(v, comparer, msg, args),
                (v, param) => Validate.ArgumentNotEqualsWith(v, comparer, param),
                (v, param, msg, args) => Validate.ArgumentNotEqualsWith(v, comparer, param, msg, args),
                new[] { typeof(TValue).Name }
                );
        }

        private static CheckFunctions<bool> GetConditionChecks()
        {
            return new CheckFunctions<bool>(
                "Condition",
                Validate.Condition,
                Validate.Condition,
                Validate.ArgumentCondition,
                Validate.ArgumentCondition,
                new string[] { }
                );
        }

        private static CheckFunctions<int> GetGreaterThanZeroIntChecks()
        {
            return new CheckFunctions<int>(
                "Condition",
                Validate.GreaterThanZero,
                Validate.GreaterThanZero,
                Validate.ArgumentGreaterThanZero,
                Validate.ArgumentGreaterThanZero,
                new string[] { }
                );
        }

        private static CheckFunctions<double> GetGreaterThanZeroDoubleChecks()
        {
            return new CheckFunctions<double>(
                "Condition",
                Validate.GreaterThanZero,
                Validate.GreaterThanZero,
                Validate.ArgumentGreaterThanZero,
                Validate.ArgumentGreaterThanZero,
                new string[] { }
                );
        }

        private static CheckFunctions<int> GetGreaterOrEqualThanZeroIntChecks()
        {
            return new CheckFunctions<int>(
                "Condition",
                Validate.GreaterOrEqualThanZero,
                Validate.GreaterOrEqualThanZero,
                Validate.ArgumentGreaterOrEqualThanZero,
                Validate.ArgumentGreaterOrEqualThanZero,
                new string[] { }
                );
        }

        private static CheckFunctions<double> GetGreaterOrEqualThanZeroDoubleChecks()
        {
            return new CheckFunctions<double>(
                "Condition",
                Validate.GreaterOrEqualThanZero,
                Validate.GreaterOrEqualThanZero,
                Validate.ArgumentGreaterOrEqualThanZero,
                Validate.ArgumentGreaterOrEqualThanZero,
                new string[] { }
                );
        }

        private static CheckFunctions<TValue> GetEnumerationValueIsDefinedChecks<TValue>()
            where TValue : struct, IConvertible
        {
            return new CheckFunctions<TValue>(
                "Condition",
                Validate.EnumerationValueIsDefined,
                Validate.EnumerationValueIsDefined,
                Validate.ArgumentEnumerationValueIsDefined,
                Validate.ArgumentEnumerationValueIsDefined,
                new[] { typeof(TValue).Name }
                );
        }

        private static CheckFunctions<string> GetStringIsMeanfulChecks()
        {
            return new CheckFunctions<string>(
                "StringIsMeanful",
                Validate.StringIsMeanful,
                Validate.StringIsMeanful,
                Validate.ArgumentStringIsMeanful,
                Validate.ArgumentStringIsMeanful,
                new string[] { }
                );
        }

        private static CheckFunctions<DateTime> GetDateIsRealChecks()
        {
            return new CheckFunctions<DateTime>(
                "DateIsReal",
                Validate.DateIsReal,
                Validate.DateIsReal,
                Validate.ArgumentDateIsReal,
                Validate.ArgumentDateIsReal,
                new string[] { "1900" }
                );
        }

        private static ValidationCase[] CreateExceptionalCases()
        {
            var result = new List<ValidationCase>();

            result.AddRange(CreateCorrectCases(new[] { new[] { 1 } }, new[] { new int[0], null }, GetEnumerableHasElementsChecks<int>()));
            result.AddRange(CreateCorrectCases(new[] { new[] { string.Empty } }, new[] { new string[0], null }, GetEnumerableHasElementsChecks<string>()));

            result.AddRange(CreateCorrectCases(new[] { new[] { 1 } }, new[] { new int[0], null }, GetCollectionHasElementsChecks<int>()));
            result.AddRange(CreateCorrectCases(new[] { new[] { string.Empty } }, new[] { new string[0], null }, GetCollectionHasElementsChecks<string>()));

            result.AddRange(CreateCorrectCases(new[] { 1 }, new[] { -1, 0 }, GetGreaterThanZeroIntChecks()));
            result.AddRange(CreateCorrectCases(new[] { 1, 0 }, new[] { -1 }, GetGreaterOrEqualThanZeroIntChecks()));

            result.AddRange(CreateCorrectCases(new[] { 1.0 }, new[] { -1.0, +0.0 }, GetGreaterThanZeroDoubleChecks()));
            result.AddRange(CreateCorrectCases(new[] { 1.0, +0.0 }, new[] { -1.0 }, GetGreaterOrEqualThanZeroDoubleChecks()));

            result.AddRange(CreateCorrectCases(new[] { 0, 1 }, new[] { -1 }, GetGreaterOrEqualThanChecks(0)));
            result.AddRange(CreateCorrectCases(new[] { 1 }, new[] { -1, 0 }, GetGreaterThanChecks(0)));
            result.AddRange(CreateCorrectCases(new[] { -1, 0 }, new[] { 1 }, GetLessOrEqualThanChecks(0)));
            result.AddRange(CreateCorrectCases(new[] { -1 }, new[] { 1, 0 }, GetLessThanChecks(0)));
            result.AddRange(CreateCorrectCases(new[] { 1, 2, 3 }, new[] { 0, 4 }, GetBetweenChecks(1, 3)));
            result.AddRange(CreateCorrectCases(new[] { 1, 2, 3 }, new[] { 0, 4 }, GetIsInChecks(new[] { 1, 2, 3 })));

            result.AddRange(CreateCorrectCases(new[] { 0 }, new[] { 1, -1 }, GetEqualsWithChecks(0)));
            result.AddRange(CreateCorrectCases(new[] { "123" }, new[] { "1", string.Empty, null }, GetEqualsWithChecks("123")));
            result.AddRange(CreateCorrectCases(new string[] { null }, new[] { "1", string.Empty }, GetEqualsWithChecks<string>(null)));

            result.AddRange(CreateCorrectCases(new[] { -1, 1 }, new[] { 0 }, GetNotEqualsWithChecks(0)));
            result.AddRange(CreateCorrectCases(new[] { null, string.Empty, "1" }, new[] { "123" }, GetNotEqualsWithChecks("123")));
            result.AddRange(CreateCorrectCases(new[] { "1", string.Empty }, new string[] { null }, GetNotEqualsWithChecks<string>(null)));

            result.AddRange(CreateCorrectCases(new[] { true }, new[] { false }, GetConditionChecks()));

            result.AddRange(CreateCorrectCases(new[] { "123" }, new[] { string.Empty, null, "   " }, GetStringIsMeanfulChecks()));

            result.AddRange(CreateCorrectCases(new[] { StringSplitOptions.None, StringSplitOptions.RemoveEmptyEntries }, new StringSplitOptions[] { (StringSplitOptions)128 }, GetEnumerationValueIsDefinedChecks<StringSplitOptions>()));

            result.AddRange(CreateCorrectCases(new[] { DateTime.Now, DateTime.UtcNow, new DateTime(1950, 01, 01), }, new[] { default(DateTime), default(DateTime).AddYears(100), DateTime.MaxValue }, GetDateIsRealChecks()));

            return result.ToArray();
        }

        private static IEnumerable<ValidationCase> CreateCorrectCases<TValue>(
            IEnumerable<TValue> correctValues,
            IEnumerable<TValue> inccorrectValues,
            CheckFunctions<TValue> checkFunction)
        {
            var emptyStringArray = new string[0];

            foreach (var value in correctValues)
            {
                var name = checkFunction.functionName + " of " + value;

                yield return new ValidationCase(() => checkFunction.StateCheck(value), false, null, null, name + _index++);
                yield return new ValidationCase(() => checkFunction.StateCheckFormat(value, "123 {0}", new object[] { "1" }), false, null, null, name + _index++);
                yield return new ValidationCase(() => checkFunction.ArgumentCheck(value, "arg1"), false, null, null, name + _index++);
                yield return new ValidationCase(() => checkFunction.ArgumentCheckFormat(value, "arg1", "123 {0}", new object[] { "1" }), false, null, null, name + _index++);
            }

            var nonFormatRequirements = checkFunction.RequiredSubstrings;
            var formatterRequirements = nonFormatRequirements.Concat(new[] { "longMessage formatParameter" }).ToArray();

            foreach (var value in inccorrectValues)
            {
                var name = checkFunction.functionName + " of " + value;

                yield return new ValidationCase(() => checkFunction.StateCheck(value), true, nonFormatRequirements, typeof(InvalidOperationException), name + _index++);
                yield return new ValidationCase(() => checkFunction.StateCheckFormat(value, "longMessage {0}", new object[] { "formatParameter" }), true, formatterRequirements, typeof(InvalidOperationException), name + _index++);
                yield return new ValidationCase(() => checkFunction.ArgumentCheck(value, "arg1"), true, nonFormatRequirements, typeof(ArgumentException), name + _index++);
                yield return new ValidationCase(() => checkFunction.ArgumentCheckFormat(value, "arg1", "longMessage {0}", new object[] { "formatParameter" }), true, formatterRequirements, typeof(ArgumentException), name + _index++);

                // invalid input parameters
                yield return new ValidationCase(() => checkFunction.StateCheckFormat(value, "longMessage {0}", new object[] { "formatParameter", "formatParameter2" }), true, emptyStringArray, typeof(InvalidOperationException), name + _index++);
                yield return new ValidationCase(() => checkFunction.ArgumentCheck(value, null), true, emptyStringArray, typeof(ArgumentException), name + _index++);
                yield return new ValidationCase(() => checkFunction.ArgumentCheck(value, string.Empty), true, emptyStringArray, typeof(ArgumentException), name + _index++);
                yield return new ValidationCase(() => checkFunction.ArgumentCheckFormat(value, null, "longMessage {0}", new object[] { "formatParameter" }), true, emptyStringArray, typeof(ArgumentException), name + _index++);
                yield return new ValidationCase(() => checkFunction.ArgumentCheckFormat(value, string.Empty, "longMessage {0}", new object[] { "formatParameter" }), true, emptyStringArray, typeof(ArgumentException), name + _index++);
            }
        }

        private sealed class CheckFunctions<TValue>
        {
            public CheckFunctions(string functionName, Action<TValue> stateCheck, Action<TValue, string, object[]> stateCheckFormat, Action<TValue, string> argumentCheck, Action<TValue, string, string, object[]> argumentCheckFormat, string[] requiredSubstrings)
            {
                this.functionName = functionName;
                StateCheck = stateCheck;
                StateCheckFormat = stateCheckFormat;
                ArgumentCheck = argumentCheck;
                ArgumentCheckFormat = argumentCheckFormat;
                RequiredSubstrings = requiredSubstrings;
            }

            public readonly string functionName;
            public readonly Action<TValue> StateCheck;
            public readonly Action<TValue, string, object[]> StateCheckFormat;
            public readonly Action<TValue, string> ArgumentCheck;
            public readonly Action<TValue, string, string, object[]> ArgumentCheckFormat;
            public readonly string[] RequiredSubstrings;
        }

        internal sealed class ValidationCase
        {
            public ValidationCase(Action actionToTest, bool shouldRaiseError, string[] exceptionSubstrings, Type exceptionType, string caseName)
            {
                ActionToTest = actionToTest;
                this.shouldRaiseError = shouldRaiseError;
                this.exceptionSubstrings = exceptionSubstrings;
                ExceptionType = exceptionType;
                CaseName = caseName.Replace(':', '_').Replace(' ', '_').Replace('.', '_');
            }

            public readonly string CaseName;
            public readonly Action ActionToTest;
            public readonly bool shouldRaiseError;
            public readonly string[] exceptionSubstrings;
            public readonly Type ExceptionType;

            public override string ToString()
            {
                return $"Function: {CaseName}, Throws: {(shouldRaiseError ? ExceptionType.ToString() : "nothing")};";
            }
        }
    }
}