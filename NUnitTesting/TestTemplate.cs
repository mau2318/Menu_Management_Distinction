using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MenuManagement;
using System;

namespace NUnitTesting
{
    [TestFixture]
    public class TestTemplate
    {
        private Object _testableObject;
        private string _testableString;

        [SetUp]
        public void SetUp()
        {
            _testableObject = new object();
            _testableString = "Some string.";
        }

        [Test]
        public void TestObjectExists()
        {
            Assert.IsNotNull(_testableObject);
            StringAssert.AreEqualIgnoringCase
                (
                "some string.", //expected
                _testableString, //actual
                "Testing that the string is indeed some string"
                );
        }

        [TestCase("Some string.")]
        [TestCase("SOME sTrInG.")]
        [TestCase("some string.")]
        public void TestString(string toTest)
        {
            StringAssert.AreEqualIgnoringCase(toTest, _testableString, "Testing the strings are actually the same.");
        }
    }
}