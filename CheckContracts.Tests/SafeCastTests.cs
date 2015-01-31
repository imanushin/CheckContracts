using System;
using NUnit.Framework;

namespace CheckContracts.Tests
{
    [TestFixture]
    public sealed class SafeCastTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CastNullArgumentTest()
        {
            SafeCast.CastArgument<string>(null, "arg");
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CastInvalidArgumentTest()
        {
            SafeCast.CastArgument<string>(new object(), "arg");
        }

        [Test]
        public void CastValidArgumentTest()
        {
            object input = "123";

            var result = SafeCast.CastArgument<string>(input, "arg");

            Assert.AreEqual(input, result);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CastNullValueTest()
        {
            SafeCast.Cast<string>(null, "text {0}", "text");
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CastInvalidValueTest()
        {
            SafeCast.Cast<string>(new object(), "text {0}", "text");
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
