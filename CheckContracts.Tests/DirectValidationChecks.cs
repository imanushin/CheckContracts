using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using NUnit.Framework;

namespace CheckContracts.Tests
{
    [TestFixture]
    [ExcludeFromCodeCoverage]
    internal sealed class DirectValidationChecks
    {

        [Test]
        public void CheckArgumentGreaterThan()
        {
            // When
            var action = new TestDelegate(() => Validate.ArgumentGreaterThan(-1, 0, "arg"));

            // Then
            Assert.That(action, Throws.ArgumentException.And.Message.Contains("should be greater than 0"));
        }

        [Test]
        public void IsInInheritanceCheck()
        {
            // Given
            var allowedError = new InvalidOperationException();
            var allowedItems = new Exception[] { allowedError }; // Exception[] should inherit IReadOnlyCollection<Exception>

            // When
            var action = new TestDelegate(() => Validate.IsIn(allowedError, allowedItems));

            // Then
            Assert.DoesNotThrow(action);
        }

        [Test]
        public void IsInHugeArrayCheck()
        {
            // Given
            var allowedError = -1;
            var allowedItems = Enumerable.Range(0, 100).ToArray();

            // When
            var action = new TestDelegate(() => Validate.IsIn(allowedError, allowedItems));

            // Then
            Assert.That(action, Throws.InvalidOperationException.And.Message.Contains("-1").And.Message.Contains("99"));
        }
    }
}