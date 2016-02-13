using System;
using NUnit.Framework;

namespace CheckContracts.Tests
{
    [TestFixture]
    public sealed class SafeCastTests
    {
        [Test]
        public void CastNullArgumentTest()
        {
            var action = new TestDelegate(() => SafeCast.CastArgument<string>(null, "arg"));

            Assert.That(action, Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void CastInvalidArgumentTest()
        {
            var action = new TestDelegate(() => SafeCast.CastArgument<string>(new object(), "arg"));

            Assert.That(action, Throws.ArgumentException);
        }

        [Test]
        public void CastValidArgumentTest()
        {
            object input = "123";

            var result = SafeCast.CastArgument<string>(input, "arg");

            Assert.AreEqual(input, result);
        }

        [Test]
        public void CastNullValueTest()
        {
            var action = new TestDelegate(() => SafeCast.Cast<string>(null, "text {0}", "text"));

            Assert.That(action, Throws.InvalidOperationException);
        }

        [Test]
        public void CastInvalidValueTest()
        {
            var action = new TestDelegate(() => SafeCast.Cast<string>(new object(), "text {0}", "text"));

            Assert.That(action, Throws.InvalidOperationException);
        }

        [Test]
        public void CastValidValueTest()
        {
            object input = "123";

            var result = SafeCast.Cast<string>(input, "text {0}", "text");

            Assert.AreEqual(input, result);
        }

    }
}
