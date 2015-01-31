using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CheckContracts.Tests
{
    [TestFixture]
    public sealed class SafeConvertTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConvertNullArgumentTest()
        {
            SafeConvert.ConvertArgument<string>(null, "arg");
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertInvalidArgumentTest()
        {
            SafeConvert.ConvertArgument<string>(new object(), "arg");
        }

        [Test]
        public void ConvertValidArgumentTest()
        {
            object input = "123";

            var result = SafeConvert.ConvertArgument<string>(input, "arg");

            Assert.AreEqual(input, result);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ConvertNullValueTest()
        {
            SafeConvert.Convert<string>(null, "text {0}", "text");
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ConvertInvalidValueTest()
        {
            SafeConvert.Convert<string>(new object(), "text {0}", "text");
        }

        [Test]
        public void ConvertValidValueTest()
        {
            object input = "123";

            var result = SafeConvert.Convert<string>(input, "text {0}", "text");

            Assert.AreEqual(input, result);
        }

    }
}
