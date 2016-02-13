using NUnit.Framework;

namespace CheckContracts.Tests
{
    [TestFixture]
    internal sealed class DirectValidationChecks
    {

        [Test]
        public void CheckArgumentGreaterThan()
        {
            var action = new TestDelegate(() => Validate.ArgumentGreaterThan(-1, 0, "arg"));

            Assert.That(action, Throws.ArgumentException.And.Message.Contains("should be greater than 0"));
        }
    }
}