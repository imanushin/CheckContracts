using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace CheckContracts.Tests
{
    [TestFixture]
    internal sealed class ValidateTests
    {
        private static readonly ValidationCase[] Cases = CreateExceptionalCases();

        [Test]
        public void IsNotNullTests()
        {
            const string nullString = null;

            Assert.That(()=>Validate.IsNotNull(nullString), Throws.InvalidOperationException.And.Message.Contains("String"));
            Assert.That(()=>Validate.ArgumentIsNotNull(nullString, "arg12"), Throws.InstanceOf(typeof(ArgumentNullException)).And.Message.Contains("String").And.Message.Contains("arg12"));
            Assert.That(()=>Validate.ArgumentIsNotNull("123", "arg12"), Throws.Nothing);
            Assert.That(()=>Validate.IsNotNull("123"), Throws.Nothing);
        }

        [Test]
        public void CollectionIsEmptyTestDraft()
        {
            string[] nullCollection = null;
            var emptyCollection = new string [] { };
            var notEmptyCollection = new[] {string.Empty};

            Assert.That(() => Validate.CollectionHasElements(notEmptyCollection), Throws.Nothing);
            Assert.That(() => Validate.ArgumentCollectionHasElements(notEmptyCollection, "123"), Throws.Nothing);

            Assert.That(()=>Validate.CollectionHasElements(nullCollection), 
                Throws.InvalidOperationException
                .And.Message.Contains("is null")
                .And.Message.Contains("String"));
            Assert.That(()=>Validate.ArgumentCollectionHasElements(nullCollection, "arg1"), 
                Throws.ArgumentException
                .And.Message.Contains("String")
                .And.Message.Contains("is null")
                .And.Message.Contains("arg1"));

            Assert.That(() => Validate.CollectionHasElements(emptyCollection),
                Throws.InvalidOperationException
                .And.Message.Contains("is not null")
               .And.Message.Contains("String"));
            Assert.That(() => Validate.ArgumentCollectionHasElements(emptyCollection, "arg1"),
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

        private static CheckFunctions<IEnumerable<TValue>> GetCollectionHasElementsChecks<TValue>()
        {
            return new CheckFunctions<IEnumerable<TValue>>(
                "CollectionHasElements",
                Validate.CollectionHasElements,
                Validate.CollectionHasElements,
                Validate.ArgumentCollectionHasElements,
                Validate.ArgumentCollectionHasElements,
                new[] { typeof(TValue).Name}
                );
        }

        private static ValidationCase[] CreateExceptionalCases()
        {
            var result = new List<ValidationCase>();

            result.AddRange(CreateCorrectCases(new[] {new [] {1}}, new[]{ new int[0], null}, GetCollectionHasElementsChecks<int>()));
            result.AddRange(CreateCorrectCases(new[] {new [] {string.Empty}}, new []{ new string[0], null}, GetCollectionHasElementsChecks<string>()));

            return result.ToArray();
        }

        private static IEnumerable<ValidationCase> CreateCorrectCases<TValue>(
            IEnumerable<TValue> correctValues, 
            IEnumerable<TValue> inccorrectValues, 
            CheckFunctions<TValue> checkFunction)
        {
            foreach (var value in correctValues)
            {
                var name = checkFunction.functionName + " of " + value;

                yield return new ValidationCase(() => checkFunction.StateCheck(value), false, null, null, name);
                yield return new ValidationCase(() => checkFunction.StateCheckFormat(value, "123 {0}", new object[] { "1" }), false, null, null, name);
                yield return new ValidationCase(() => checkFunction.ArgumentCheck(value, "arg1"), false, null, null, name);
                yield return new ValidationCase(() => checkFunction.ArgumentCheckFormat(value, "arg1", "123 {0}", new object[] { "1" }), false, null, null, name);
            }

            var nonFormatRequirements = checkFunction.RequiredSubstrings;
            var formatterRequirements = nonFormatRequirements.Concat(new[] {"longMessage formatParameter"}).ToArray();

            foreach (var value in inccorrectValues)
            {
                var name = checkFunction.functionName + " of " + value;

                yield return new ValidationCase(() => checkFunction.StateCheck(value), true, nonFormatRequirements, typeof(InvalidOperationException), name);
                yield return new ValidationCase(() => checkFunction.StateCheckFormat(value, "longMessage {0}", new object[] { "formatParameter" }), true, formatterRequirements, typeof(InvalidOperationException), name);
                yield return new ValidationCase(() => checkFunction.ArgumentCheck(value, "arg1"), true, nonFormatRequirements, typeof(ArgumentException), name);
                yield return new ValidationCase(() => checkFunction.ArgumentCheckFormat(value, "arg1", "longMessage {0}", new object[] { "formatParameter" }), true, formatterRequirements, typeof(ArgumentException), name);
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
                CaseName = caseName;
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